using SdcSoft.Devices.Meta;
namespace SdcSoft.Devices.map
{
    internal class DevicePointMap_CTL_NJRT_E3_DianZhengQi : DevicePointMap
    {
        public const string Key = "CTL_NJRT_E3_DianZhengQi";
        public DevicePointMap_CTL_NJRT_E3_DianZhengQi()
        {
            #region----------------------计算属性（不显示）----------------------
            map.Add("_jiarezu", ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), "_jiarezu", 0, 0, "加热组", false));
            map.Add("_addshuibeng", ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), "_addshuibeng", 0, 0, "给水泵", false));
            #endregion

            map.Add(SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, 3, 2, "系统状态", CTL_NJRT_Common_ValueMaps.coms_status));

            map.Add(SdcSoftDevice.KEY_POINT_RUN_LIFE, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_LIFE, 53, 2, "累计燃烧时间"));

            map.Add(SdcSoftDevice.KEY_POINT_RUN_DAYS, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_DAYS, 0, 0, "运行天数", "天"));

            map.Add(SdcSoftDevice.KEY_POINT_RUN_HOURS, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_HOURS, 0, 0, "运行小时数", "时"));

            map.Add(SdcSoftDevice.KEY_POINT_POWER, ByteField.Init(new Meta.CTL_NJRT.E3.PowerField(), SdcSoftDevice.KEY_POINT_POWER, 1, 0, "燃料类型", DevicePointMap.coms_power));

            map.Add(SdcSoftDevice.KEY_POINT_MEDIA, ByteField.Init(new Meta.CTL_NJRT.E3.MediaField(), SdcSoftDevice.KEY_POINT_MEDIA, 1, 0, "介质类型", DevicePointMap.coms_media));


            map.Add("oc_jixianshuiweidianji", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jixianshuiweidianji", 5, 2, "极限水位电极", 0, DevicePointMap.coms_open_close));
            map.Add("oc_dishuiweidianji", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_dishuiweidianji", 5, 2, "低水位电极", 1, coms_open_close));
            map.Add("oc_gaoshuiweidianji", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_gaoshuiweidianji", 5, 2, "高水位电极", 2, coms_open_close));
            map.Add("oc_gaoshuiweibaojingdianji", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_gaoshuiweibaojingdianji", 5, 2, "高水位报警电极", 3, coms_open_close));
            map.Add("oc_chaoyabaojing(kongzhiqi)", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_chaoyabaojing(kongzhiqi)", 5, 2, "超压报警（控制器）", 9, coms_open_close));



            map.Add("oc_1_addshuibeng_start_stop", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_1_addshuibeng_start_stop", 9, 2, "给水泵主控制 ", 0, coms_open_close));
            map.Add("oc_2_addshuibeng_start_stop", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_2_addshuibeng_start_stop", 9, 2, "给水泵备控制", 1, coms_open_close));
            map.Add("oc_baojingshuchu ", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_baojingshuchu ", 9, 2, "报警输出", 2, coms_open_close));
            map.Add("oc_jiarezu1kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu1kongzhi", 9, 2, "加热组1控制", 4, coms_open_close));
            map.Add("oc_jiarezu2kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu2kongzhi", 9, 2, "加热组2控制", 5, coms_open_close));
            map.Add("oc_jiarezu3kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu3kongzhi", 9, 2, "加热组3控制", 6, coms_open_close));
            map.Add("oc_jiarezu4kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu4kongzhi", 9, 2, "加热组4控制", 7, coms_open_close));
            map.Add("oc_jiarezu5kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu5kongzhi", 9, 2, "加热组5控制", 8, coms_open_close));
            map.Add("oc_jiarezu6kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu6kongzhi", 9, 2, "加热组6控制", 9, coms_open_close));
            map.Add("oc_jiarezu7kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu7kongzhi", 9, 2, "加热组7控制", 10, coms_open_close));
            map.Add("oc_jiarezu8kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu8kongzhi", 9, 2, "加热组8控制", 11, coms_open_close));
            map.Add("oc_jiarezu9kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu9kongzhi", 9, 2, "加热组9控制", 12, coms_open_close));
            map.Add("oc_jiarezu10kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu10kongzhi", 9, 2, "加热组10控制", 13, coms_open_close));
            map.Add("oc_jiarezu11kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu11kongzhi", 9, 2, "加热组11控制", 14, coms_open_close));
            map.Add("oc_jiarezu12kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu12kongzhi", 9, 2, "加热组12控制", 15, coms_open_close));

            map.Add("ex_zhengqichuanganqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_zhengqichuanganqiguzhangbaojing", 45, 2, "蒸汽传感器故障报警", 0));
            map.Add("ex_jixiandishuiweibaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_jixiandishuiweibaojing", 45, 2, "极限低水位报警", 1));
            map.Add("ex_gaoshuiweibaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_gaoshuiweibaojing", 45, 2, "高水位报警", 2));
            map.Add("ex_shuiweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_shuiweichuanganqiguzhang", 45, 2, "水位传感器故障", 3));
            map.Add("ex_chaoyabaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_chaoyabaojing", 45, 2, "超压报警", 4));
            map.Add("ex_xitongguzhang", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_xitongguzhang", 45, 2, "系统故障", 5));


            map.Add("mo_zhengqiyali", ByteField.Init(new Meta.CTL_NJRT.MockField(), "mo_zhengqiyali", 13, 4, "蒸汽压力", "P"));
        }
    }
}
