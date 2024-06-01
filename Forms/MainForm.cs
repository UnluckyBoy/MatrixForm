using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatrixForm.Tools;
using System.Net.NetworkInformation;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace MatrixForm
{
    public partial class MainForm : Form
    {
        /*定义私有对象*/
        private String ipAddress;
        private String port;
        private String encodingType;

        private TcpListener listener;
        private Thread listenThread;
        private TcpClient client;
        private bool keepTcp= true;
        private List<TcpClient> clients = new List<TcpClient>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //IPBox.Text = "192.168.0.4";
            //PortBox.Text = "8080";
            // 从App.config中读取IP地址和端口号  
            string ipAddress = ConfigurationManager.AppSettings["IPAddress"];
            string port = ConfigurationManager.AppSettings["Port"];
            // 分配值给TextBox控件  
            IPBox.Text = ipAddress;
            PortBox.Text = port;

            TcpTypeBox.SelectedIndex=0;
            EncodingComboBox.SelectedIndex = 0;
        }

     


        /// <summary>
        /// 按钮响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imgBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("点击了按钮！");
            // 获取当前应用程序的执行目录  
            string basePath = AppDomain.CurrentDomain.BaseDirectory;/*执行文件目录*/
            Debug.Print("路径:" + basePath);
            // 向上导航一级目录到达项目根目录（与Form和Resources同级的目录）  
            //string projectRootPath = Directory.GetParent(basePath).FullName;
            //Debug.Print("路径2:" + projectRootPath);
            // 构建要读取的文件的完整路径  
            string filePath = Path.Combine(basePath, "config", "file", "img2.txt");
            try
            {
                // 检查文件是否存在
                if (File.Exists(filePath))
                {
                    // 读取文件内容  
                    string fileContent = File.ReadAllText(filePath);
                    Debug.Print("文件内容:" + fileContent);
                    //MessageBox.Show(fileContent, "文件内容");
                    byte[] byteArray = Convert.FromBase64String(fileContent);
                    // 使用 MemoryStream将字节数组转换为Image  
                    using (MemoryStream ms = new MemoryStream(byteArray))
                    {
                        // 从 MemoryStream 加载 Image  
                        Image image = Image.FromStream(ms);
                        // 将 Image 赋值给 PictureBox 的 Image 属性  
                        imgBox.Image = image;
                    }
                }
                else
                {
                    // 文件不存在时的处理  
                    MessageBox.Show("文件不存在！", "错误");
                }
            }
            catch (Exception ex)
            {
                // 处理可能出现的异常  
                MessageBox.Show("读取文件时出错: " + ex.Message, "错误");
            }
        }

        #region 通信响应逻辑

        private void TcpBtn_Click(object sender, EventArgs e)
        {
            ipAddress = IPBox.Text.Trim();
            port= PortBox.Text.Trim();

            if (CheckTools.IsNullOrEmptyString(ipAddress) | CheckTools.IsNullOrEmptyString(port))
            {
                MessageBox.Show("IP或端口不能为空!");
                return;
            }
            else
            {
                if (listener != null && listener.Server.IsBound)
                {
                    UpdateUIThreadSafe("服务监听已启动！");
                }
                else
                {
                    encodingType = EncodingComboBox.SelectedItem.ToString();// 获取选取框选中的文本
                    IPAddress localAddress = IPAddress.Parse(ipAddress);
                    // 创建TcpListener实例  
                    listener = new TcpListener(localAddress, int.Parse(port));
                    // 开始监听连接请求  
                    listener.Start();
                    // 在新线程中监听连接  
                    listenThread = new Thread(new ThreadStart(ListenForClients));
                    listenThread.IsBackground = true;
                    listenThread.Start();
                    // 更新UI以显示正在监听
                    UpdateUIThreadSafe("正在监听:" + ipAddress + ":" + port);
                }
            }
        }

        private void ListenForClients()
        {
            if (!keepTcp)
            {
                keepTcp = !keepTcp;
            }
            Console.WriteLine("keepTcp:" + keepTcp);
            while (keepTcp) 
            {
                try
                {
                    client = listener.AcceptTcpClient();

                    clients.Add(client);

                    // 创建线程处理客户端通信  
                    Thread clientThread = new Thread(() => HandleClientComm(client));
                    clientThread.IsBackground = true;
                    clientThread.Start();
                    UpdateUIThreadSafe("客户端连接成功：" + client.Client.RemoteEndPoint);
                    clients.Add(client);
                }
                catch (SocketException)
                {
                    if (keepTcp == false) //主动停止的,退出循环  
                    {
                        return;
                    }
                    // 否则,记录异常并继续监听或执行其他错误处理逻辑  
                }
                catch (Exception e)
                {
                    // 处理其他类型的异常
                    UpdateUIThreadSafe("异常：" + e.Message);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        private void HandleClientComm(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;
            try {
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    string receivedData;
                    switch (encodingType)
                    {
                        /**ASCLL,Unicode,UTF8,HEX*/
                        case "ASCII":
                            // 将接收到的数据转换为字符串
                            receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                            break;
                        case "Unicode":
                            receivedData = Encoding.Unicode.GetString(buffer, 0, bytesRead);
                            break;
                        case "UTF8":
                            receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                            break;
                        default:
                            receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                            break;
                    }
                    // 更新UI以显示接收到的数据  
                    UpdateUIThreadSafe(receivedData);
                }
            }
            catch (IOException e) when ((uint)e.HResult == 0x800703E3)
            {
                UpdateUIThreadSafe("连接被主机关闭");
            }
            catch (SocketException e) when (e.SocketErrorCode == SocketError.OperationAborted)
            {
                // 可能会抛出SocketException
                //UpdateUIThreadSafe("Socket操作被中止，连接可能已关闭");
            }
            catch (Exception)
            {
                // 处理其他类型的异常
                //UpdateUIThreadSafe("发生异常: " + e.Message);
            }
            // 关闭连接  
            client.Close();
            UpdateUIThreadSafe("客户端连接已关闭!");
        }

        /// <summary>
        /// 安全地更新UI的方法  
        /// </summary>
        /// <param name="text"></param>
        private void UpdateUIThreadSafe(string text)
        {
            if (tcpTextBox.InvokeRequired)
            {
                var d = new Action<string>(UpdateUIThreadSafe);
                tcpTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                tcpTextBox.AppendText(text + Environment.NewLine);
            }
        }

        private void StopTcpBtn_Click(object sender, EventArgs e)
        {
            keepTcp = false;
            CloseAllClients();
        }

        private void CloseAllClients()
        {
            //Console.WriteLine("Close-listener.Server:" + listener.Server.IsBound);
            if (!listener.Server.IsBound)
            {
                UpdateUIThreadSafe("已停止监听！");
            }
            else
            {
                listener.Stop();
                UpdateUIThreadSafe("停止监听！");
                // 关闭所有已接受的客户端连接  
                foreach (var client in clients)
                {
                    try
                    {
                        client.Close();
                    }
                    catch (Exception e)
                    {
                        // 处理关闭客户端时可能出现的异常  
                        UpdateUIThreadSafe("关闭客户端时出错: " + e.Message);
                    }
                }
                clients.Clear(); // 清除客户端列表
                listenThread.Join(); // 等待监听线程结束
            }
        }
    }
    #endregion
}
