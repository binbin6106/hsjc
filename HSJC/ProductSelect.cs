using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HSJC
{
    public partial class ProductSelect : Form
    {
        private SQLiteConnection conn = null;
        private SQLiteDataAdapter da = null;
        SQLiteCommand command = null;
        DataSet ds = new DataSet();
        public static string UploadCommand = "";
        private const string sql_select = "select * from ProductInfo";

        public ProductSelect()
        {
            InitializeComponent();
        }

        private void ProductSelect_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SQLiteConnection(Commondata.connectionString);
                conn.Open();
                command = new SQLiteCommand(sql_select, conn);
                da = new SQLiteDataAdapter(command);
                da.Fill(ds, "ProductInfo");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("数据库打开错误！");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)   //选择产品按钮
        {
            Form1 IForm1 = (Form1)this.Owner;
            string model;
            try
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("请选择一行数据！");

                }
                else
                {
                    if (Commondata.GetConfigValue("YZeroValue") == "" && Commondata.GetConfigValue("ZZeroValue") == "" && Commondata.GetConfigValue("WZeroValue") == "")
                    {
                        Console.WriteLine(Commondata.GetConfigValue("YZeroValue") + "wtf"+ Commondata.GetConfigValue("ZZeroValue") + Commondata.GetConfigValue("WZeroValue"));
                        MessageBox.Show("请设置零点！");
                    }
                    else
                    {
                        model = dataGridView1.CurrentRow.Cells["Model"].Value.ToString();
                        IForm1.SetProductValue(model);
                        UploadCommand = CommandCreate.TestCommand(model);
                        //UpLoadCommand(UploadCommand);
                        System.IO.File.WriteAllText(Commondata.commandtxt, UploadCommand);
                        MessageBox.Show("命令已生成，点击命令查看按钮以查看。");
                        this.Dispose();
                    }

                }
            }
            catch ( Exception e1)
            {
                MessageBox.Show(e1.Message);
                return;
            }

        }

        private void UpLoadCommand(string com)
        {
            try
            {
                Commondata.GalilControler.GProgramDownload(com);
                Commondata.GalilControler.GProgramUpload();
            }
            catch
            {
                MessageBox.Show("连接错误！");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
