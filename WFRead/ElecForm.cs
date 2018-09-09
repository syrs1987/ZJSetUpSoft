using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WFRead
{
    public partial class ElecForm : Form
    {
        public const int WM_DEVICECHANGE = 0x219;
        public const int DBT_DEVICEARRIVAL = 0x8000;
        public const int DBT_CONFIGCHANGECANCELED = 0x0019;
        public const int DBT_CONFIGCHANGED = 0x0018;
        public const int DBT_CUSTOMEVENT = 0x8006;
        public const int DBT_DEVICEQUERYREMOVE = 0x8001;
        public const int DBT_DEVICEQUERYREMOVEFAILED = 0x8002;
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        public const int DBT_DEVICEREMOVEPENDING = 0x8003;
        public const int DBT_DEVICETYPESPECIFIC = 0x8005;
        public const int DBT_DEVNODES_CHANGED = 0x0007;
        public const int DBT_QUERYCHANGECONFIG = 0x0017;
        public const int DBT_USERDEFINED = 0xFFFF;

        public ArrayList list = new ArrayList();
        int currentIndex = 0;
        public ElecForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    switch (m.WParam.ToInt32())
                    {
                        case DBT_DEVICEARRIVAL:
                            tree_file.Nodes.Clear();
                            DriveInfo[] s = DriveInfo.GetDrives();
                            foreach (DriveInfo drive in s)
                            {
                                if (drive.DriveType == DriveType.Fixed || drive.DriveType == DriveType.Removable)
                                {
                                    if (Directory.Exists(@drive.Name + "供电公司软件包"))
                                    {
                                        FindFile2(@drive.Name + "供电公司软件包");
                                    }
                                }
                            }
                            break;
                        case DBT_DEVICEREMOVECOMPLETE:
                            //USB拔出时要处理的事件  
                            MessageBox.Show("USB已拔出");
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            base.WndProc(ref m);
        }

        private void btn_cf_Click(object sender, EventArgs e)
        {
            tree_file.Nodes.Clear();
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txtFilePath.Text = path.SelectedPath;
            List<string> files = FindFile2(path.SelectedPath);
        }

        public List<string> FindFile2(string sSourcePath)
        {
            List<String> list = new List<string>();
            //遍历文件夹
            DirectoryInfo theFolder = new DirectoryInfo(sSourcePath);
            FileInfo[] thefileInfo = theFolder.GetFiles("*.exe*", SearchOption.TopDirectoryOnly);

            foreach (FileInfo NextFile in thefileInfo)  //遍历文件
            {
                list.Add(NextFile.FullName);
            }
            //遍历子文件夹
            DirectoryInfo[] dirInfo = theFolder.GetDirectories();
            int i = 1;
            foreach (DirectoryInfo NextFolder in dirInfo)
            {
                //list.Add(NextFolder.ToString());
                FileInfo[] fileInfo = NextFolder.GetFiles("*.exe*", SearchOption.AllDirectories);
                TreeNode tn = tree_file.Nodes.Add(NextFolder.Name);
                tn.ImageIndex = i;
                tn.Checked = true;
                foreach (FileInfo NextFile in fileInfo)  //遍历文件
                {
                    if (i == 9) {
                        if (NextFile.Name.Contains("SAP")) {
                            list.Add(NextFile.FullName);
                            TreeNode cn = new TreeNode();
                            cn.Text = NextFile.Name;
                            cn.Tag = NextFile.FullName;
                            cn.Checked = true;
                            cn.ImageIndex = 0;
                            tn.Nodes.Add(cn);
                        }
                    }
                    else {
                        list.Add(NextFile.FullName);
                        TreeNode cn = new TreeNode();
                        cn.Text = NextFile.Name;
                        cn.Tag = NextFile.FullName;
                        cn.Checked = true;
                        cn.ImageIndex = -1;
                        tn.Nodes.Add(cn);
                    }
                }
                i++;
            }
            tree_file.ExpandAll();
            return list;
        }

        private void btn_setup_Click(object sender, EventArgs e)
        {
            list.Clear();
            foreach (TreeNode node in tree_file.Nodes)
            {
                foreach (TreeNode cnode in node.Nodes)  //遍历文件
                {
                    if (cnode.Checked)
                    {
                        list.Add(cnode.Tag);
                    }
                }
            }
            setUPEXE(currentIndex);
        }
        //exep_Exited事件处理代码，这里外部程序退出后激活，可以执行你要的操作
        void exep_Exited(object sender, EventArgs e)
        {
            MessageBox.Show(list[currentIndex].ToString() + "运行完毕");
            currentIndex += 1;
            if (currentIndex < list.Count)
                setUPEXE(currentIndex);
            else
                currentIndex = 0;
        }

        void setUPEXE(int currentIndex)
        {
            System.Diagnostics.Process exep = new System.Diagnostics.Process();
            exep.StartInfo.FileName = list[currentIndex].ToString();
            exep.EnableRaisingEvents = true;
            exep.Exited += new EventHandler(exep_Exited);
            exep.Start();
        }


        private void btn_SetIP_Click(object sender, EventArgs e)
        {
            string _ipaddress = txt_IP.Text;
            string _submask = "255.255.255.0";
            string _gateway = "";
            string _Dns = txt_DNS.Text;
            string adpName = "";
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ip = adapter.GetIPProperties();
                    try
                    {
                        adpName = adapter.Name;
                        //_submask = ip.UnicastAddresses[0].IPv4Mask.ToString();
                        _gateway = ip.GatewayAddresses[0].Address.ToString();
                        //int DnsCount = ip.DnsAddresses.Count;
                        //if (DnsCount > 0)
                        //{
                        //    //其中第一个为首选DNS，第二个为备用的，余下的为所有DNS为DNS备用，按使用顺序排列
                        //    _Dns = ip.DnsAddresses[0].ToString();
                        //}
                    }
                    catch { continue; }
                    break;
                }
            }

            string _doscmd = "netsh interface ip set address " + adpName + " static " + _ipaddress + " " + _submask + " " + _gateway;
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            //p.StandardInput.WriteLine(_doscmd.ToString());
            //_doscmd = "netsh interface ip set dns WLAN static " + _dns1;
            //p.StandardInput.WriteLine(_doscmd.ToString());
            p.StandardInput.WriteLine(_doscmd);
            _doscmd = "netsh interface ip set dns " + adpName + " static " + _Dns;
            p.StandardInput.WriteLine(_doscmd);
            p.StandardInput.WriteLine("exit");
            string output = p.StandardOutput.ReadToEnd();
            p.Close();//等待程序执行完退出进程
            MessageBox.Show(output);
        }

        private void btn_Site_Click(object sender, EventArgs e)
        {
            string url = txt_Site.Text.Replace("www.", "");
            RegistryKey hkml = Registry.CurrentUser;//读取HKEY_CURRENT_USER
            string address = @"SOFTWARE\MICROSOFT\WINDOWS\CURRENTVERSION\INTERNET SETTINGS\ZONEMAP\Domains";
            RegistryKey key1 = hkml.OpenSubKey(address, true);
            RegistryKey baidu = key1.CreateSubKey(url);//新建项  baidu.com按需求替换
            RegistryKey ww = baidu.CreateSubKey("www");//新建子项  www按需求替换
            ww.SetValue("http", 0x2, RegistryValueKind.DWord);//赋值
            MessageBox.Show("设置成功");
        }

        private void ElecForm_Load(object sender, EventArgs e)
        {
        
        }

        private void btn_ConNet_Click(object sender, EventArgs e)
        {
            string _doscmd = "ncpa.cpl";
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(_doscmd);
            p.StandardInput.WriteLine("exit");
            string output = p.StandardOutput.ReadToEnd();
            p.Close();//等待程序执行完退出进程
        }

        private void tree_file_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {
                if (e.Node.Checked)
                {
                    //取消节点选中状态之后，取消所有父节点的选中状态
                    setChildNodeCheckedState(e.Node, true);

                }
                else
                {
                    //取消节点选中状态之后，取消所有父节点的选中状态
                    setChildNodeCheckedState(e.Node, false);
                    //如果节点存在父节点，取消父节点的选中状态
                    if (e.Node.Parent != null)
                    {
                        setParentNodeCheckedState(e.Node, false);
                    }
                }
            }
        }
        //取消节点选中状态之后，取消所有父节点的选中状态
        private void setParentNodeCheckedState(TreeNode currNode, bool state)
        {
            TreeNode parentNode = currNode.Parent;

            parentNode.Checked = state;
            if (currNode.Parent.Parent != null)
            {
                setParentNodeCheckedState(currNode.Parent, state);
            }
        }
        //选中节点之后，选中节点的所有子节点
        private void setChildNodeCheckedState(TreeNode currNode, bool state)
        {
            TreeNodeCollection nodes = currNode.Nodes;
            if (nodes.Count > 0)
                foreach (TreeNode tn in nodes)
                {

                    tn.Checked = state;
                    setChildNodeCheckedState(tn, state);
                }
        }

    }
}
