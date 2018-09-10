using SdcSoft.Devices.Meta;
namespace SdcSoft.Devices.map
{
    internal class DevicePointMap_CTL_NJRT_E3_DianReShui : DevicePointMap
    {
        public const string Key = "CTL_NJRT_E3_DianReShui";
        public DevicePointMap_CTL_NJRT_E3_DianReShui()
        {
            #region----------------------计算属性（不显示）----------------------
            map.Add("_jiarezu", ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), "_jiarezu", 0, 0, "加热组", false));
            map.Add("_addshuibeng", ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), "_addshuibeng", 0, 0, "补水泵", false));
            #endregion

            map.Add(SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, 3, 2, "系统状态", CTL_NJRT_Common_ValueMaps.coms_status));

            map.Add(SdcSoftDevice.KEY_POINT_RUN_LIFE, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_LIFE, 21, 2, "运行时间"));

            map.Add(SdcSoftDevice.KEY_POINT_RUN_DAYS, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_DAYS, 0, 0, "运行天数", "天"));

            map.Add(SdcSoftDevice.KEY_POINT_RUN_HOURS, ByteField.Init(new Meta.CTL_NJRT.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_HOURS, 0, 0, "运行小时数", "时"));

            map.Add(SdcSoftDevice.KEY_POINT_POWER, ByteField.Init(new Meta.CTL_NJRT.E3.PowerField(), SdcSoftDevice.KEY_POINT_POWER, 1, 0, "燃料类型", DevicePointMap.coms_power));

            map.Add(SdcSoftDevice.KEY_POINT_MEDIA, ByteField.Init(new Meta.CTL_NJRT.E3.MediaField(), SdcSoftDevice.KEY_POINT_MEDIA, 0, 0, "介质类型", DevicePointMap.coms_media));


            map.Add("oc_jixiandishuiweidianji", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jixiandishuiweidianji", 4, 2, "极限低水位电极", 0, coms_open_close));
            map.Add("oc_dishuiweidianji", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_dishuiweidianji", 4, 2, "低水位电极", 1, coms_open_close));
            map.Add("oc_gaoshuiweidianji", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_gaoshuiweidianji", 4, 2, "高水位电极", 2, coms_open_close));
            map.Add("oc_lubichaowenkaiguan", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_lubichaowenkaiguan", 4, 2, "炉壁超温开关", 6, coms_open_close));
            map.Add("oc_chaoyabaojing", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_chaoyabaojing", 5, 2, "超压报警", 1, coms_open_close));
            map.Add("oc_baojingshuchu", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_baojingshuchu", 6, 2, "报警输出", 0, coms_open_close));
            map.Add("oc_bushuibengkongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_bushuibengkongzhi", 6, 2, "补水泵控制", 1, coms_open_close));
            map.Add("oc_xunhuanbengkongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_xunhuanbengkongzhi", 6, 2, "循环泵控制", 2, coms_open_close));
            map.Add("oc_jiarezu1kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu1kongzhi", 6, 2, "加热组1控制", 3, coms_open_close));
            map.Add("oc_jiarezu2kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu2kongzhi", 6, 2, "加热组2控制", 4, coms_open_close));
            map.Add("oc_jiarezu3kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu3kongzhi", 6, 2, "加热组3控制", 5, coms_open_close));
            map.Add("oc_jiarezu4kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu4kongzhi", 6, 2, "加热组4控制", 6, coms_open_close));
            map.Add("oc_jiarezu5kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu5kongzhi", 6, 2, "加热组5控制", 7, coms_open_close));
            map.Add("oc_jiarezu6kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu6kongzhi", 6, 2, "加热组6控制", 0, coms_open_close));
            map.Add("oc_jiarezu7kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu7kongzhi", 6, 2, "加热组7控制", 1, coms_open_close));
            map.Add("oc_jiarezu8kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu8kongzhi", 6, 2, "加热组8控制", 2, coms_open_close));
            map.Add("oc_jiarezu9kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu9kongzhi", 6, 2, "加热组9控制", 3, coms_open_close));
            map.Add("oc_jiarezu10kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu10kongzhi", 6, 2, "加热组10控制", 4, coms_open_close));
            map.Add("oc_jiarezu11kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu11kongzhi", 6, 2, "加热组11控制", 5, coms_open_close));
            map.Add("oc_jiarezu12kongzhi", ByteField.Init(new Meta.CTL_NJRT.OpenCloseField(), "oc_jiarezu12kongzhi", 6, 2, "加热组12控制", 6, coms_open_close));



            map.Add("mo_chushuiwendu", ByteField.Init(new Meta.CTL_NJRT.MockField(), "mo_chushuiwendu", 8, 2, "出水温度", "℃"));
            map.Add("mo_huishuiwendu", ByteField.Init(new Meta.CTL_NJRT.MockField(), "mo_huishuiwendu", 9, 2, "回水温度", "℃"));



            map.Add("ex_chushuiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_chushuiwenduchuanganqiguzhang", 24, 2, "出水温度传感器故障", 0));
            map.Add("ex_chushuiwendugaobaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_chushuiwendugaobaojing", 24, 2, "出水温度高报警", 1));
            map.Add("ex_huishuiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_huishuiwenduchuanganqiguzhang", 24, 2, "回水温度传感器故障", 2));
            map.Add("ex_jixiandishuiweibaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_jixiandishuiweibaojing", 24, 2, "极限低水位报警", 3));
            map.Add("ex_shuiweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_shuiweichuanganqiguzhang", 24, 2, "水位传感器故障", 4));
            map.Add("ex_chaoyabaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_chaoyabaojing", 24, 2, "超压报警", 5));
            map.Add("ex_lubichaowenbaojing", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_lubichaowenbaojing", 24, 2, "炉壁超温报警", 6));
            map.Add("ex_xitongguzhang", ByteField.Init(new Meta.CTL_NJRT.ExceptionField(), "ex_xitongguzhang", 24, 2, "系统故障", 7));
        }
    }
}
