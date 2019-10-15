using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HSJC
{
    class Commondata
    {
        public static string nowPath = System.IO.Directory.GetCurrentDirectory();
        public static string dbPath = nowPath + "/hsjc.db";
        public static string connectionString = "Data Source=" + dbPath;
        public static string commandtxt = nowPath + "/command.dmc";
        public static string PowerLandIp = "192.168.1.200" + " --direct --subscribe ALL";
        public static string DmcC640Ip = "192.168.1.21" + " --direct --subscribe ALL";
        public static bool IsInit = false;
        public static bool IsInitZero = false;
        //零点位置
        public static string YZeroValue = GetConfigValue("YZeroValue");
        public static string ZZeroValue = GetConfigValue("ZZeroValue");
        public static string WZeroValue = GetConfigValue("WZeroValue");
        //各轴AZ值
        public static string YAZ = "8192";
        public static string ZAZ = "8192";
        public static string WAZ = "8192";
        //各轴机械参数缺省值
        public static string TransmissionRatioY = "100";
        public static string HelicalPitchZ = "6";
        public static string TransmissionRatioW = "1";
        //各轴速度缺省值
        public static string SpeedY = "20000";
        public static string SpeedZ = "20000";
        public static string SpeedW = "20000";

        public static gclib GalilControler { get; set; }
        //设置参数
        public static bool SetConfigValue(string key, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.AppSettings.Settings[key] != null)
                    config.AppSettings.Settings[key].Value = value;
                else
                    config.AppSettings.Settings.Add(key, value);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch
            {
                return false;
            }
        }
        //获取参数
        public static string GetConfigValue(string key)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] != null)
                return config.AppSettings.Settings[key].Value;
            else

                return string.Empty;
        }
    }
}
