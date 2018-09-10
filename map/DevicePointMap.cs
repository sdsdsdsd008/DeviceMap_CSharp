using SdcSoft.Devices.Meta;
using System.Collections.Generic;

namespace SdcSoft.Devices.map
{
    internal abstract class DevicePointMap
    {
        protected Dictionary<string, ByteField> map = new Dictionary<string, ByteField>();
        public Dictionary<string, ByteField> getPointMap()
        {
            return map;
        }
        public static Dictionary<int, string> coms_media = new Dictionary<int, string>() {
                {0, "热水"},
                {1, "蒸汽"},
                {2, "导热油"},
                {3, "热风"},
                {4, "真空"},
            };
        public static Dictionary<int, string> coms_power = new Dictionary<int, string>() {
                {0, "油气"},
                {1, "电"},
                {2, "煤"},
                {3, "生物质"},
            };
        public static Dictionary<int, string> coms_level = new Dictionary<int, string>() {
                {0, "缺水"},
                {1, "低报警"},
                {2, "低位"},
                {3, "正常"},
                {4, "高位"},
                {5, "超高位"},
                {6, "逻辑错"},
            };
        public static Dictionary<int, string> coms_open_close = new Dictionary<int, string>() {
            {0, "关"},
            {1, "开"},
        };
        public static Dictionary<int, string> coms_start_stop = new Dictionary<int, string>() {
            {0, "停"},
            {1, "启"},
        };

        internal class PLC_Common_ValueMaps
        {
            public static Dictionary<int, string> coms_status = new Dictionary<int, string>() {

                {0, "待命"},
                {1, "运行"},
                {2, "报警"},

            };
            public static Dictionary<int, string> coms_atuo = new Dictionary<int, string>() {
                {0, "自"},
                {1, "手"},
            };
            public static Dictionary<int, string> coms_ranshaoqi_status = new Dictionary<int, string>() {
                {0, "停"},
                {1, "运行"},
                {2, "大火"},
            };
        }

        internal class CTL_NJZJ_Common_ValueMaps
        {
            public static Dictionary<int, string> coms_status = new Dictionary<int, string>() {
                {0, "关机"},
                {1, "待机"},
                {2, "运行"},
                {3, "报警"},
            };
            public static Dictionary<int, string> coms_ranshaoqi_status = new Dictionary<int, string>() {
                {0, "停"},
                {1, "小火"},
                {2, "大火"},
            };
            public static Dictionary<int, string> coms_yalistatus = new Dictionary<int, string>() {
                {0, "常压"},
                {1, "低压"},
                {2, "中压"},
                {3, "高压"},
                {4, "超压"},
            };
            public static Dictionary<int, string> coms_device = new Dictionary<int, string>() {
                {0xC0, "手"},
                {0x3F, "自"},
                {0x30, "备"},
                {0xCF, "主"},
                {0x0F, "启"},
                {0xF0, "停"},
            };
        }

        internal class CTL_NJRT_Common_ValueMaps
        {
            public static Dictionary<int, string> coms_status = new Dictionary<int, string>() {

                {0, "待机"},
                {1, "报警"},
                {2, "运行"},
            };
            public static Dictionary<int, string> coms_atuo = new Dictionary<int, string>() {
                {0, "自"},
                {1, "手"},
            };
            public static Dictionary<int, string> coms_master = new Dictionary<int, string>() {
                {0, "主"},
                {1, "备"},
            };
            public static Dictionary<int, string> coms_ranshaoqi_status = new Dictionary<int, string>() {
                {0, "小火"},
                {1, "大火"},
            };
        }
    }
}
