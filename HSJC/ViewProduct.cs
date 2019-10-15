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
    public partial class ViewProduct : Form
    {
        private SQLiteConnection conn = null;
        private SQLiteDataAdapter da = null;
        SQLiteCommand command = null;
        DataSet ds = new DataSet();
        private const string sql_select = "select * from ProductInfo"; 

        public ViewProduct()
        {
            InitializeComponent();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e) //修改产品
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要修改该产品数据吗", "提示！", messButton);
            if (dr == DialogResult.OK)
            {
                try
                {
                    SQLiteCommandBuilder scb = new SQLiteCommandBuilder(da);
                    da.UpdateCommand = scb.GetUpdateCommand();
                    da.Update(ds, "ProductInfo");
                }
                catch
                {
                    MessageBox.Show("修改错误！");
                    return;
                }
                MessageBox.Show("修改成功！");
            }
            else
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)  //删除产品
        {
            ds.AcceptChanges();
            SQLiteCommandBuilder scb = new SQLiteCommandBuilder(da);
            ds.Tables[0].Rows[this.dataGridView1.CurrentRow.Index].Delete();
            da.DeleteCommand = scb.GetDeleteCommand();
            da.Update(ds, "ProductInfo");
        }
    }
}
