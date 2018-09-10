using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices.map
{
    internal class DevicePointMap_CTL_NJRT_T2 : DevicePointMap
    {
        public const string Key = "CTL_NJZJ_IPK2";
        public DevicePointMap_CTL_NJRT_T2()
        {
            #region----------------------计算属性（不显示）----------------------
            map.Add("_ranshaoqi", ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), "_ranshaoqi", 0, 0, "燃烧器", false));
            map.Add("_addshuibeng", ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), "_addshuibeng", 0, 0, "给水泵", false));
            map.Add("_lengningbeng", ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), "_lengningbeng", 0, 0, "冷凝泵", false));
            #endregion

            map.Add(SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, 0, 2, "系统状态", CTL_NJRT_Common_ValueMaps.coms_status));

            map.Add(SdcSoftDevice.KEY_POINT_RUN_LIFE, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_LIFE, 21, 2, "运行时间"));

            map.Add(SdcSoftDevice.KEY_POINT_RUN_DAYS, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_DAYS, 0, 0, "运行天数","天"));

            map.Add(SdcSoftDevice.KEY_POINT_RUN_HOURS, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_HOURS, 0, 0, "运行小时数","时"));

            map.Add(SdcSoftDevice.KEY_POINT_POWER, ByteField.Init(new Meta.CTL_NJRT.PowerField(), SdcSoftDevice.KEY_POINT_POWER, 0, 0, "燃料类型", DevicePointMap.coms_power));

            map.Add(SdcSoftDevice.KEY_POINT_MEDIA, ByteField.Init(new Meta.CTL_NJRT.MediaField(), SdcSoftDevice.KEY_POINT_MEDIA, 0, 0, "介质类型", DevicePointMap.coms_media));

            
            map.Add("oc_ranshaoqiqitingkongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_ranshaoqiqitingkongzhi", 9, 2, "燃烧器启停控制", 0, DevicePointMap.coms_start_stop));
            map.Add("oc_ranshaoqifuhetiaojie", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_ranshaoqifuhetiaojie", 9, 2, "燃烧器负荷调节", 1, coms_start_stop));
            
            map.Add("oc_1_addshuibeng_start_stop", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_1_addshuibeng_start_stop", 9, 2, "给水泵（主）控制", 3, coms_start_stop));
            map.Add("oc_2_addshuibeng_start_stop", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_2_addshuibeng_start_stop", 9, 2, "给水泵（备）控制", 4, coms_start_stop));
            map.Add("oc_1_lengningxunhuanbeng_start_stop", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_1_lengningxunhuanbeng_start_stop", 9, 2, "冷凝循环泵控制", 5, coms_start_stop));
            map.Add("oc_baojingshuchu", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_baojingshuchu", 9, 2, "报警输出", 6, coms_start_stop));

            map.Add("oc_addshuibengzhubei", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_addshuibengzhubei", 49, 2, "给水泵主备", 0, CTL_NJRT_Common_ValueMaps.coms_master));
            map.Add("oc_addshuibengshouzi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_addshuibengshouzi", 49, 2, "给水泵手自", 1, CTL_NJRT_Common_ValueMaps.coms_atuo));
            map.Add("oc_jienengxunhuanbengshouzi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jienengxunhuanbengshouzi", 49, 2, "节能循环泵手自", 3, CTL_NJRT_Common_ValueMaps.coms_master));

            map.Add("ex_shuiweichuanganqicut", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_shuiweichuanganqicut", 45, 2, "水位传感器断路", 3));
            map.Add("ex_shuiweichuanganqishort", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_shuiweichuanganqishort", 45, 2, "水位传感器短路", 4));
            map.Add("ex_jixiandishuiweibaojingdianliu", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_jixiandishuiweibaojingdianliu", 45, 2, "极限低水位报警（电流）", 5));
            map.Add("ex_gaoshuiweibaojingdianliu", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_gaoshuiweibaojingdianliu", 45, 2, "高水位报警（电流）", 6));
            map.Add("ex_paiyanwendugaobaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_paiyanwendugaobaojing", 45, 2, "排烟温度高报警", 7));
            map.Add("ex_jixiandishuiweibaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_jixiandishuiweibaojing", 45, 2, "极限低水位报警", 8));
            map.Add("ex_shuiweidianjiluojicuo", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_shuiweidianjiluojicuo", 45, 2, "水位电极逻辑错", 9));
            map.Add("ex_dishuiweibaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_dishuiweibaojing", 45, 2, "低水位报警", 10));
            map.Add("ex_gaoshuiweibaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_gaoshuiweibaojing", 45, 2, "高水位报警", 11));
            map.Add("ex_bianpinqiguzhang", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_bianpinqiguzhang", 45, 2, "变频器故障", 12));
            map.Add("ex_chaoyabaojingkongzhiqi", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_chaoyabaojingkongzhiqi", 45, 2, "超压报警（控制器）", 13));
            map.Add("ex_ranqiyalidibaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_ranqiyalidibaojing", 45, 2, "燃气压力低报警", 14));
            map.Add("ex_ranqiyaligaobaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_ranqiyaligaobaojing", 45, 2, "燃气压力高报警", 15));
            map.Add("ex_ranqixieloubaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_ranqixieloubaojing", 47, 2, "燃气泄漏报警", 0));
            map.Add("ex_ranshaoqiguzhang", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_ranshaoqiguzhang", 47, 2, "燃烧器故障", 1));

            map.Add("mo_lengningqiyanwen", ByteField.Init(new Meta.CTL_NJRT.MockField(), "mo_lengningqiyanwen", 13, 2, "冷凝器烟温", "℃"));
            map.Add("mo_jishuiwendu", ByteField.Init(new Meta.CTL_NJRT.MockField(), "mo_jishuiwendu", 15, 2, "给水温度", "℃"));
            map.Add("mo_shuiweixinhao", ByteField.Init(new Meta.CTL_NJRT.MockField(), "mo_shuiweixinhao", 19, 2, "水位", "%"));
            map.Add("mo_paiyanwendu", ByteField.Init(new Meta.CTL_NJRT.MockField(), "mo_paiyanwendu", 21, 2, "排烟温度", "℃"));
            map.Add("mo_jienengqiyanwen", ByteField.Init(new Meta.CTL_NJRT.MockField(), "mo_jienengqiyanwen", 23, 2, "节能器烟温", "℃"));


        }
    }
}
