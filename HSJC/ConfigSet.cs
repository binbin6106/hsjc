using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSJC
{
    public partial class ConfigSet : Form
    {
        public ConfigSet()
        {
            InitializeComponent();
        }

        private void ConfigSet_Load(object sender, EventArgs e)
        {
            string YAZ, ZAZ, WAZ;
            YAZ = Commondata.GetConfigValue("YAZ");
            ZAZ = Commondata.GetConfigValue("ZAZ");
            WAZ = Commondata.GetConfigValue("WAZ");
            if(YAZ == "" && ZAZ == "" && WAZ == "")  //AZ缺省值判断
            {
                numericUpDown1.Value = Convert.ToDecimal(Commondata.YAZ);
                numericUpDown2.Value = Convert.ToDecimal(Commondata.ZAZ);
                numericUpDown3.Value = Convert.ToDecimal(Commondata.WAZ);
            }
            else
            {
                numericUpDown1.Value = Convert.ToDecimal(YAZ);
                numericUpDown2.Value = Convert.ToDecimal(ZAZ);
                numericUpDown3.Value = Convert.ToDecimal(WAZ);
            }

            string TransmissionRatioY, HelicalPitchZ, TransmissionRatioW;
            TransmissionRatioY = Commondata.GetConfigValue("TransmissionRatioY");
            HelicalPitchZ = Commondata.GetConfigValue("HelicalPitchZ");
            TransmissionRatioW = Commondata.GetConfigValue("TransmissionRatioW");
            if (TransmissionRatioY == "" && HelicalPitchZ == "" && TransmissionRatioW == "")  //机械参数缺省值判断
            {
                numericUpDown4.Value = Convert.ToDecimal(Commondata.TransmissionRatioY);
                numericUpDown5.Value = Convert.ToDecimal(Commondata.HelicalPitchZ);
                numericUpDown6.Value = Convert.ToDecimal(Commondata.TransmissionRatioW);
            }
            else
            {
                numericUpDown4.Value = Convert.ToDecimal(TransmissionRatioY);
                numericUpDown5.Value = Convert.ToDecimal(HelicalPitchZ);
                numericUpDown6.Value = Convert.ToDecimal(TransmissionRatioW);
            }

            string SpeedY, SpeedZ, SpeedW;
            SpeedY = Commondata.GetConfigValue("SpeedY");
            SpeedZ = Commondata.GetConfigValue("SpeedZ");
            SpeedW = Commondata.GetConfigValue("SpeedW");
            if (SpeedY == "" && SpeedZ == "" && SpeedW == "")  //速度缺省值判断
            {
                numericUpDown9.Value = Convert.ToDecimal(Commondata.SpeedY);
                numericUpDown8.Value = Convert.ToDecimal(Commondata.SpeedZ);
                numericUpDown7.Value = Convert.ToDecimal(Commondata.SpeedW);
            }
            else
            {
                numericUpDown9.Value = Convert.ToDecimal(SpeedY);
                numericUpDown8.Value = Convert.ToDecimal(SpeedZ);
                numericUpDown7.Value = Convert.ToDecimal(SpeedW);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Commondata.SetConfigValue("YAZ", Convert.ToString(numericUpDown1.Value)) &&
                Commondata.SetConfigValue("ZAZ", Convert.ToString(numericUpDown2.Value)) &&
                Commondata.SetConfigValue("WAZ", Convert.ToString(numericUpDown3.Value)) &&
                Commondata.SetConfigValue("TransmissionRatioY", Convert.ToString(numericUpDown4.Value)) &&
                Commondata.SetConfigValue("HelicalPitchZ", Convert.ToString(numericUpDown5.Value)) &&
                Commondata.SetConfigValue("TransmissionRatioW", Convert.ToString(numericUpDown6.Value)) &&
                Commondata.SetConfigValue("SpeedY", Convert.ToString(numericUpDown9.Value)) &&
                Commondata.SetConfigValue("SpeedZ", Convert.ToString(numericUpDown8.Value)) &&
                Commondata.SetConfigValue("SpeedW", Convert.ToString(numericUpDown7.Value)))
                MessageBox.Show("参数设置成功！");
            else
            {
                MessageBox.Show("参数设置失败！");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
