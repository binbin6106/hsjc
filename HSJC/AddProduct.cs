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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "data source = " + Commondata.dbPath;
            SQLiteConnection dbConnection = new SQLiteConnection(connectionString);
            dbConnection.Open();
            SQLiteCommand dbCommand = dbConnection.CreateCommand();
            string model, state, height, baseheight, date, createman, tips;
            //获取输入的值
            model = textBox1.Text;
            state = comboBox1.Text;
            height = numericUpDown1.Value.ToString();
            baseheight = numericUpDown2.Value.ToString();
            date = dateTimePicker1.Value.ToString();
            createman = textBox2.Text;
            tips = textBox3.Text;

            try
            {   
                //尝试插入数据
                string cmd = "INSERT INTO ProductInfo (Model, State, Height, Baseheight, Date, Createman, Tips) VALUES " + "(" + "\'" + model + "\'" + "," + "\'" + state + "\'" + "," + "\'" + height + "\'" + "," + "\'" + baseheight + "\'" + "," + "\'" + date + "\'" + "," + "\'" + createman + "\'" + "," + "\'" + tips + "\'" + ")";
                dbCommand.CommandText = cmd;
                dbCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("产品创建错误！");
                return;
            }

            MessageBox.Show("产品创建成功！");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
