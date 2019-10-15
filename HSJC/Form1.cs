using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace HSJC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                    "确定退出吗？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }
            if (Commondata.IsInit)
            {
                Commondata.GalilControler.GCommand("MO");
                Commondata.GalilControler.GClose();
            }

        }

    private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;


        }

        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(Commondata.dbPath))
            {
                try
                {
                    //创建数据库文件
                    SQLiteConnection.CreateFile(Commondata.dbPath);

                }

                catch (Exception ex)
                {
                    MessageBox.Show("数据库创建错误！" + ex.Message);
                    return;
                }
            }
            Thread.Sleep(500);
            try
            {
                //连接数据库
                SQLiteConnection dbConnection = new SQLiteConnection(Commondata.connectionString);
                dbConnection.Open();
                //创建表
                string[] colNames = new string[] { "ID", "Model", "State", "Height", "Baseheight", "Date", "Createman", "Tips" };
                string[] colTypes = new string[] { "INTEGER PRIMARY KEY AUTOINCREMENT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT", "TEXT" };
                string tableName = "ProductInfo";
                string queryString = "CREATE TABLE IF NOT EXISTS " + tableName + "(" + colNames[0] + " " + colTypes[0];
                for (int i = 1; i < colNames.Length; i++)
                {
                    queryString += ", " + colNames[i] + " " + colTypes[i];
                }
                queryString += ")";
                SQLiteCommand dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandText = queryString;
                SQLiteDataReader dataReader = dbCommand.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("表创建错误！");
                return;
            }

            new AddProduct().ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要退出吗？", "提示！", messButton);
            if (dr == DialogResult.OK)
            {
                if (Commondata.IsInit)
                {
                    Commondata.GalilControler.GCommand("MO");
                    Commondata.GalilControler.GClose();
                }
                System.Environment.Exit(0);
            }
            else
            {
                return;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)   //后台任务开始操作
        {
            InitPowerLand((string)e.Argument);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)   //后台任务完成操作
        {
            menuStrip1.Enabled = true;
            if (Commondata.IsInit)
            {
                button1.Enabled = false;
                label2.Text = "已就绪";
                label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            }

        }


        private void button1_Click_1(object sender, EventArgs e)    //初始化按钮
        {
            try
            {

                TrueInit(Commondata.PowerLandIp);
            }
            catch
            {
                MessageBox.Show("初始化失败！");
                return;
            }

        }

        /*private void InitDrive()
        {
            backgroundWorker1.RunWorkerAsync();
        }*/

        private void TrueInit(string address)
        {
            menuStrip1.Enabled = false;
            backgroundWorker1.RunWorkerAsync(address);
        }

        private bool InitPowerLand(string address)   //初始化powerland
        {
            gclib gclib = null;
            try
            {
                gclib = new gclib();

                PrintOutput("gclib version: ", PrintStyle.Normal, true);
                PrintOutput(gclib.GVersion(), PrintStyle.GclibData);

                PrintOutput("Opening connection to \"" + address + "\"... ", PrintStyle.Normal, true);
                gclib.GOpen(address);
                PrintOutput("Connected.", PrintStyle.Normal);
                PrintOutput("Setting AZ...", PrintStyle.Normal);
                gclib.GCommand(CommandCreate.AZCommand(""));
                PrintOutput("Complete.", PrintStyle.Normal);


                Commondata.GalilControler = new gclib();
                PrintOutput("Connectting to Controler...", PrintStyle.Normal);
                Commondata.GalilControler.GOpen(Commondata.DmcC640Ip);
                PrintOutput("Connected.Version is " + Commondata.GalilControler.GInfo(), PrintStyle.Normal);

                PrintOutput("Now TP position is " + Commondata.GalilControler.GCommand("TP"), PrintStyle.Normal);


                Commondata.IsInit = true;
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("PowerLand初始化失败！" + ex.Message);
                //MessageBox.Show(e.Message);
                return false;
            }
        }

        private void ViewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewProduct().ShowDialog();
        }

        public void SetProductValue(string text)
        {
            textBox1.Text = text;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductSelect IForm = new ProductSelect();
            IForm.Owner = this;
            IForm.ShowDialog();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", Commondata.commandtxt);
            }
            catch
            {
                MessageBox.Show("命令查看错误！");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)   //开始按钮
        {
            string com = CommandCreate.TestCommand("");
            Commondata.GalilControler.GProgramDownload(com);
            Commondata.GalilControler.GProgramUpload();
            Commondata.GalilControler.GCommand("XQ#TEST");
        }



        private enum PrintStyle
        {
            Instruction,
            Normal,
            GalilData,
            GclibData,
            Err,
        }

        /// <summary>
        /// Thread safe printing call.
        /// </summary>
        /// <param name="Message">The message to print</param>
        /// <param name="Style">The style enum to indicate how to print</param>
        /// <param name="SuppressCrLf">If true, the string will be printed without a trailing cr+lf</param>
        private void PrintOutput(string Message, PrintStyle Style = PrintStyle.Normal, bool SuppressCrLf = false)
        {
            if (Output.InvokeRequired)
            {
                Output.Invoke(new Printer(PrintOutput), new object[] { Message, Style, SuppressCrLf });
            }
            else
            {
                Color color;

                switch (Style)
                {
                    case PrintStyle.Instruction:
                        color = Color.Black;
                        break;
                    case PrintStyle.GalilData:
                        color = Color.Green;
                        break;
                    case PrintStyle.Normal:
                        color = Color.Blue;
                        break;
                    case PrintStyle.Err:
                        color = Color.Red;
                        break;
                    case PrintStyle.GclibData:
                        color = Color.Magenta;
                        break;
                    default:
                        color = Color.Blue;
                        break;
                }//switch

                Output.SelectionStart = Output.Text.Length;
                Output.SelectionColor = color;
                Output.AppendText(Message);

                if (!SuppressCrLf)
                    Output.AppendText("\r\n");

            }//invoke check
        }




        /// <summary>
        /// Delegate used to print status when the status is generated in a thread other than the UI thread.
        /// </summary>
        /// <param name="Message">Message to print</param>
        /// <param name="Style">Print Style</param>
        /// <param name="SuppressCrLf">If true, the string will be printed without a trailing cr+lf</param>
        private delegate void Printer(string Message, PrintStyle Style, bool SuppressCrLf);

        private void button3_Click(object sender, EventArgs e) //急停按钮
        {
            Commondata.GalilControler.GCommand("AB");
        }

        private void button4_Click(object sender, EventArgs e)   //复位按钮
        {
            if (Commondata.YZeroValue == null && Commondata.ZZeroValue == null && Commondata.WZeroValue == null)
            {
                MessageBox.Show("请先定义原点！");
            }
            else
            {
                Commondata.GalilControler.GProgramDownload(CommandCreate.ReSetCommand(Commondata.GetConfigValue("YZeroValue"), Commondata.GetConfigValue("ZZeroValue"), Commondata.GetConfigValue("WZeroValue")));   //w轴动作待定
                Commondata.GalilControler.GProgramUpload();
                Console.WriteLine(Commondata.WZeroValue);
                Commondata.GalilControler.GCommand("XQ#RSET");
            }
        }

        private void SetZeroPositionToolStripMenuItem_Click(object sender, EventArgs e)    //定义原点
        {

            if (Commondata.IsInit)
            {
                string YZeroValue, ZZeroValue, WZeroValue;

                YZeroValue = Commondata.GalilControler.GCommand("TPY");
                ZZeroValue = Commondata.GalilControler.GCommand("TPZ");
                WZeroValue = Commondata.GalilControler.GCommand("TPW");

                bool resY = Commondata.SetConfigValue("YZeroValue", YZeroValue.ToString());
                bool resZ = Commondata.SetConfigValue("ZZeroValue", ZZeroValue.ToString());
                bool resW = Commondata.SetConfigValue("WZeroValue", WZeroValue.ToString());

                if (resY && resZ && resW)
                {
                    MessageBox.Show("原点设置成功！");
                    Commondata.IsInitZero = true;
                    return;
                }
                else
                    MessageBox.Show("原点设置错误！");
            }
            else
            {
                MessageBox.Show("请先初始化设备！");
            }
        }

        private void SingelToolStripMenuItem1_Click(object sender, EventArgs e)  //独立控制按钮
        {
            if (Commondata.IsInit)
                new SingelContorl().ShowDialog();
            else
            {
                MessageBox.Show("请先初始化设备!");
                return;
            }

           
        }

        private void EleSetToolStripMenuItem_Click(object sender, EventArgs e)    //参数设置按钮
        {
            new ConfigSet().ShowDialog();
        }
    }
}