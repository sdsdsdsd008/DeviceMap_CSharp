using SdcSoft.Devices.Meta;
using System.Collections.Generic;

namespace SdcSoft.Devices.map
{
    internal class DevicePointMap_PLC_DianReShui : DevicePointMap
    {
        public const string Key = "PLC_DianReShui";

        public DevicePointMap_PLC_DianReShui()
        {

            #region----------------------计算属性（不显示）----------------------
            map.Add("_addshuibeng", ByteField.Init(new Meta.PLC.DeviceField(), "_addshuibeng", 0, 0, "补水泵",false));
            map.Add("_xunhuanbeng", ByteField.Init(new Meta.PLC.DeviceField(), "_xunhuanbeng", 0, 0, "循环泵",false));
            #endregion



            map.Add(SdcSoftDevice.KEY_POINT_RUN_HOURS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_HOURS, 9, 2, "运行小时数", "时"));
            map.Add(SdcSoftDevice.KEY_POINT_RUN_DAYS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_DAYS, 11, 2, "运行天数", "天"));
            map.Add(SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, 13, 2, "系统状态", PLC_Common_ValueMaps.coms_status));
            map.Add(SdcSoftDevice.KEY_POINT_POWER, ByteField.Init(new Meta.PLC.PowerField(), SdcSoftDevice.KEY_POINT_POWER, 1, 0, "燃料", DevicePointMap.coms_power));
            map.Add(SdcSoftDevice.KEY_POINT_MEDIA, ByteField.Init(new Meta.PLC.MediaField(), SdcSoftDevice.KEY_POINT_MEDIA, 0, 0, "介质", DevicePointMap.coms_media));
            map.Add("ba_shuiweizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_shuiweizhuangtai", 19, 2, "水位状态", DevicePointMap.coms_level));
            map.Add("ba_ranshaoqizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_ranshaoqizhuangtai", 21, 2, "燃烧器状态", PLC_Common_ValueMaps.coms_ranshaoqi_status));

            map.Add("mo_chushuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_chushuiwendu", 35, 4, "出水温度", "℃"));
            map.Add("mo_huishuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_huishuiwendu", 39, 4, "回水温度", "℃"));
            map.Add("mo_chushuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_chushuiyali", 43, 4, "出水压力", "Mpa"));
            map.Add("mo_huishuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_huishuiyali", 47, 4, "回水压力", "Mpa"));
            map.Add("mo_qidongjiarezushu", ByteField.Init(new Meta.PLC.MockField(), "mo_qidongjiarezushu", 79, 4, "启动加热组数", "组"));
            map.Add("mo_qidongjiarezushubaifenbi", ByteField.Init(new Meta.PLC.MockField(), "mo_qidongjiarezushubaifenbi", 83, 4, "启动加热组数百分比", "%"));

            map.Add("se_chaowenbaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chaowenbaojingsheding", 127, 4, "超温报警设定", "℃"));
            map.Add("se_shiyongjiarezushusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_shiyongjiarezushusheding", 131, 4, "使用加热组数设定", "组"));
            map.Add("se_touqiejiangeshijiansheding", ByteField.Init(new Meta.PLC.SettingField(), "se_touqiejiangeshijiansheding", 135, 4, "投切间隔时间设定", "S"));
            map.Add("se_kuaiqiejiangeshijiansheding", ByteField.Init(new Meta.PLC.SettingField(), "se_kuaiqiejiangeshijiansheding", 139, 4, "快切间隔时间设定", "S"));
            map.Add("se_tingluwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_tingluwendusheding", 143, 4, "停炉温度设定", "℃"));
            map.Add("se_shiyongwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_shiyongwendusheding", 147, 4, "使用温度设定", "℃"));
            map.Add("se_qiluwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_qiluwendusheding", 151, 4, "启炉温度设定", "℃"));
            map.Add("se_yalidibaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_yalidibaojingsheding", 155, 4, "压力低报警设定", "Mpa"));
            map.Add("se_yaligaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_yaligaobaojingsheding", 159, 4, "压力高报警设定", "Mpa"));
            map.Add("se_qibengyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_qibengyalisheding", 163, 4, "启泵压力设定", "Mpa"));
            map.Add("se_tingbengyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_tingbengyalisheding", 167, 4, "停泵压力设定", "Mpa"));
            map.Add("se_xunhuanbengshangxianwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_xunhuanbengshangxianwendusheding", 171, 4, "循环泵上限温度设定", "℃"));
            map.Add("se_xunhuanbengxiaxianwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_xunhuanbengxiaxianwendusheding", 175, 4, "循环泵下限温度设定", "℃"));

            

            map.Add("de_1_addshuibeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_addshuibeng_auto", 199, 2, "1#补水泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_addshuibeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_addshuibeng_start_stop", 201, 2, "1#补水泵", DevicePointMap.coms_start_stop));
            map.Add("de_2_addshuibeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_addshuibeng_auto", 203, 2, "2#补水泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_addshuibeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_addshuibeng_start_stop", 205, 2, "2#补水泵", DevicePointMap.coms_start_stop));
            map.Add("de_baojingshuchuzhishi", ByteField.Init(new Meta.PLC.DeviceField(), "de_baojingshuchuzhishi", 207, 2, "报警输出指示", coms_open_close));
            map.Add("de_1_xunhuanbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_xunhuanbeng_auto", 209, 2, "1#循环泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_xunhuanbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_xunhuanbeng_start_stop", 211, 2, "1#循环泵", DevicePointMap.coms_start_stop));
            map.Add("de_2_xunhuanbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_xunhuanbeng_auto", 213, 2, "2#循环泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_xunhuanbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_xunhuanbeng_start_stop", 215, 2, "2#循环泵", DevicePointMap.coms_start_stop));

            map.Add("ex_shuiweijidibaojing（dianji）", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijidibaojing（dianji）", 233, 2, "水位极低报警（电极）", 8));
            map.Add("ex_xitongchaoyabaojing（shedingzhi）", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_xitongchaoyabaojing（shedingzhi）", 233, 2, "系统超压报警（设定值）", 9));
            map.Add("ex_xitongyalidibaojing（shedingzhi）", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_xitongyalidibaojing（shedingzhi）", 233, 2, "系统压力低报警（设定值）", 10));
            map.Add("ex_xitongchaoyabaojing（dianjiedianyalibiao）", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_xitongchaoyabaojing（dianjiedianyalibiao）", 233, 2, "系统超压报警（电接点压力表）", 11));
            map.Add("ex_xitongyalidibaojing（dianjiedianyalibiao）", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_xitongyalidibaojing（dianjiedianyalibiao）", 233, 2, "系统压力低报警（电接点压力表）", 12));
            map.Add("ex_chushuiwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chushuiwenduchuanganqiguzhang", 233, 2, "出水温度传感器故障", 13));
            map.Add("ex_huishuiwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_huishuiwenduchuanganqiguzhang）", 233, 2, "回水温度传感器故障", 14));
            map.Add("ex_chushuiyalibiansongqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chushuiyalibiansongqiguzhang", 233, 2, "出水压力变送器故障", 15));
            map.Add("ex_huishuiyalibiansongqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_huishuiyalibiansongqiguzhang", 233, 2, "回水压力变送器故障", 0));
            map.Add("ex_lubichaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_lubichaowenbaojing", 233, 2, "炉壁超温报警", 1));
            map.Add("ex_waibuliansuoduankaibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_waibuliansuoduankaibaojing", 233, 2, "外部连锁断开报警", 2));
            map.Add("ex_xunhuanbengliansuoduankaibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_xunhuanbengliansuoduankaibaojing", 233, 2, "循环泵连锁断开报警", 3));
            map.Add("ex_loudianbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_loudianbaojing", 233, 2, "漏电报警", 4));
            map.Add("ex_qianyabaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_qianyabaojing", 233, 2, "欠压报警", 5));
            map.Add("ex_chushuichaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chushuichaowenbaojing", 233, 2, "出水超温报警", 6));
            map.Add("ex_wendushedingcuowubaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_wendushedingcuowubaojing", 233, 2, "温度设定错误报警", 7));
            map.Add("ex_Axiangguoliubaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_Axiangguoliubaojing", 235, 2, "A相过流报警", 8));
            map.Add("ex_Bxiangguoliubaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_Bxiangguoliubaojing", 235, 2, "B相过流报警", 9));
            map.Add("ex_Cxiangguoliubaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_Cxiangguoliubaojing", 235, 2, "C相过流报警"   , 10));
        }
    }
}
