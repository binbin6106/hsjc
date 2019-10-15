using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSJC
{
    class CommandCreate
    {
        public static string TestCommand(string model)
        {
            decimal Yadd10Circle = Convert.ToDecimal(Commondata.GetConfigValue("YZeroValue")) + 8192 * 10;
            decimal Ydec5Circle = Yadd10Circle - 8192 * 5;
            decimal Yadd3Circle = Ydec5Circle + 8192 * 3;

            decimal Zadd10Circle = Convert.ToDecimal(Commondata.GetConfigValue("ZZeroValue")) + 8192 * 10;
            decimal Zdec5Circle = Zadd10Circle - 8192 * 5;
            decimal Zadd3Circle = Zdec5Circle + 8192 * 3;

            decimal Wadd10Circle = Convert.ToDecimal(Commondata.GetConfigValue("WZeroValue")) + 8192 * 10;
            decimal Wdec5Circle = Wadd10Circle - 8192 * 5;
            decimal Wadd3Circle = Wdec5Circle + 8192 * 3;

            string Ystradd10Circle = Convert.ToString(Yadd10Circle);
            string Ystrdec5Circle = Convert.ToString(Ydec5Circle);
            string Ystradd3Circle = Convert.ToString(Yadd3Circle);

            string Zstradd10Circle = Convert.ToString(Zadd10Circle);
            string Zstrdec5Circle = Convert.ToString(Zdec5Circle);
            string Zstradd3Circle = Convert.ToString(Zadd3Circle);

            string Wstradd10Circle = Convert.ToString(Wadd10Circle);
            string Wstrdec5Circle = Convert.ToString(Wdec5Circle);
            string Wstradd3Circle = Convert.ToString(Wadd3Circle);

            string speed = Commondata.GetConfigValue("SpeedW");
            string qwe = "#TEST\nSH\nPA," + Ystradd10Circle + "," + Zstradd10Circle + "," + Wstradd10Circle + 
                "\nSP," + Commondata.GetConfigValue("SpeedY") + "," + Commondata.GetConfigValue("SpeedZ") + "," + Commondata.GetConfigValue("SpeedW") + 
                "\nBGW\nAMW\nWT1000" +
                "\nPA," + Ystrdec5Circle + "," + Zstrdec5Circle + "," + Wstrdec5Circle +
                "\nBGW\nAMW\nWT1000" +
                "\nPA," + Ystradd3Circle + "," + Zstradd3Circle + "," + Wstradd3Circle +
                "\nBGW\nAMW\nMO\nEN";
            return qwe;
        }
        public static string ReSetCommand(string Y, string Z, string W)
        {
            string com = "#RSET\nSH\nPA," + Y + "," + Z + "," + W + "\nSP," + Commondata.GetConfigValue("SpeedY") + "," + Commondata.GetConfigValue("SpeedZ") + "," + Commondata.GetConfigValue("SpeedW") + "\nBGYZW\nAMYZW\nMO\nEN";    //w轴回复动作待定
            return com;
        }

        public static string AZCommand(string model)
        {
            string YAZ, ZAZ, WAZ, com;
            YAZ = Commondata.GetConfigValue("YAZ");
            ZAZ = Commondata.GetConfigValue("YAZ");
            WAZ = Commondata.GetConfigValue("YAZ");
            if(YAZ == "" && ZAZ == "" && WAZ == "")
            {
                com = "AZ" + "8192," + Commondata.YAZ + "," + Commondata.ZAZ + "," + Commondata.WAZ;
                return com;
            }
            else
            {
                com = "AZ" + "8192," + YAZ + "," + ZAZ + "," + WAZ;
                return com;
            }

        }

        public static string SHCommand(string model)
        {
            string com = "SH";
            return com;
        }

        public static string MOCommand(string model)
        {
            string com = "MO";
            return com;
        }

        public static string TPCommand(string model)
        {
            string com = "TP";
            return com;
        }
    }
}
