using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices.map
{
    internal class DevicePointMap_PLC_RanYouDaoReYou : DevicePointMap
    {
        public const string Key = "PLC_DaoReYou";

       
        public DevicePointMap_PLC_RanYouDaoReYou()
        {

            #region----------------------计算属性（不显示）----------------------
            map.Add("_zhuyoubeng", ByteField.Init(new Meta.PLC.DeviceField(), "_zhuyoubeng", 0, 0, "注油泵", false));
            map.Add("_xunhuanbeng", ByteField.Init(new Meta.PLC.DeviceField(), "_xunhuanbeng", 0, 0, "循环泵", false));
            #endregion


            map.Add(SdcSoftDevice.KEY_POINT_RUN_HOURS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_HOURS, 9, 2, "运行小时数"));
            map.Add(SdcSoftDevice.KEY_POINT_RUN_DAYS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_DAYS, 11, 2, "运行天数"));
            map.Add(SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, 13, 2, "系统状态", PLC_Common_ValueMaps.coms_status));
            map.Add(SdcSoftDevice.KEY_POINT_POWER, ByteField.Init(new Meta.PLC.PowerField(), SdcSoftDevice.KEY_POINT_POWER, 0, 0, "燃料", DevicePointMap.coms_power));
            map.Add(SdcSoftDevice.KEY_POINT_MEDIA, ByteField.Init(new Meta.PLC.MediaField(), SdcSoftDevice.KEY_POINT_MEDIA, 2, 0, "介质", DevicePointMap.coms_media));
            map.Add("ba_shuiweizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_shuiweizhuangtai", 19, 2, "水位状态", DevicePointMap.coms_level));
            map.Add("ba_ranshaoqizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_ranshaoqizhuangtai", 21, 2, "燃烧器状态", PLC_Common_ValueMaps.coms_ranshaoqi_status));

            map.Add("mo_jinkouwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_jinkouwendu", 35, 4, "进口温度", "℃"));
            map.Add("mo_chukouwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_chukouwendu", 39, 4, "出口温度", "℃"));
            map.Add("mo_gaoweiyoucaowendu", ByteField.Init(new Meta.PLC.MockField(), "mo_gaoweiyoucaowendu", 43, 4, "高位油槽温度", "℃"));
            map.Add("mo_paiyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_paiyanwendu", 47, 4, "排烟温度", "℃"));
            map.Add("mo_lutangwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_lutangwendu", 51, 4, "炉膛温度", "℃"));
            map.Add("mo_lutangchukouwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_lutangchukouwendu", 55, 4, "炉膛出口温度", "℃"));
            map.Add("mo_kongyuqianwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqianwendu", 59, 4, "空预前温度", "℃"));
            map.Add("mo_kongyuhouwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuhouwendu", 63, 4, "空预后温度", "℃"));
            map.Add("mo_jinkouyali", ByteField.Init(new Meta.PLC.MockField(), "mo_jinkouyali", 67, 4, "进口压力", "MPa"));
            map.Add("mo_chukouyali", ByteField.Init(new Meta.PLC.MockField(), "mo_chukouyali", 71, 4, "出口压力", "MPa"));
            map.Add("mo_danqiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_danqiyali", 75, 4, "氮气压力", "kPa"));
            map.Add("mo_lutangyali", ByteField.Init(new Meta.PLC.MockField(), "mo_lutangyali", 79, 4, "炉膛压力", "kPa"));
            map.Add("mo_gaoweiyoucaowei", ByteField.Init(new Meta.PLC.MockField(), "mo_gaoweiyoucaowei", 83, 4, "高位槽油位", "%"));
            map.Add("mo_chuyouguanyouwei", ByteField.Init(new Meta.PLC.MockField(), "mo_chuyouguanyouwei", 87, 4, "储油罐油位", "%"));
            map.Add("mo_liuliangceliang", ByteField.Init(new Meta.PLC.MockField(), "mo_liuliangceliang", 91, 4, "流量测量", "m³/h"));
            map.Add("mo_diandongtiaojiefashuchu", ByteField.Init(new Meta.PLC.MockField(), "mo_diandongtiaojiefashuchu", 95, 4, "电动调节阀输出", "%"));
            map.Add("mo_bianpinqipinlvshuchu", ByteField.Init(new Meta.PLC.MockField(), "mo_bianpinqipinlvshuchu", 99, 4, "变频器频率输出", "Hz"));

            map.Add("se_chukouwenduqiluwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chukouwenduqiluwendusheding", 111, 4, "出口温度起炉温度设定", "℃"));
            map.Add("se_chukouwendubitiaowendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chukouwendubitiaowendusheding", 115, 4, "出口温度比调温度设定", "℃"));
            map.Add("se_chukouwendutingluwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chukouwendutingluwendusheding", 119, 4, "出口温度停炉温度设定", "℃"));
            map.Add("se_chukouwenduchaogaobaojingwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chukouwenduchaogaobaojingwendusheding", 123, 4, "出口温度超高报警温度设定", "℃"));
            map.Add("se_paiyanwenduchaogaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_paiyanwenduchaogaobaojingsheding", 127, 4, "排烟温度超高报警设定", "℃"));
            map.Add("se_gaoweicaoyouweidisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_gaoweicaoyouweidisheding", 131, 4, "高位槽油位低设定", "%"));
            map.Add("se_gaoweicaoyouweigaosheding", ByteField.Init(new Meta.PLC.SettingField(), "se_gaoweicaoyouweigaosheding", 135, 4, "高位槽油位高设定", "%"));
            map.Add("se_anquanyouwensheding", ByteField.Init(new Meta.PLC.SettingField(), "se_anquanyouwensheding", 139, 4, "安全油温设定", "℃"));
            map.Add("se_fengjiqidongshijiansheding", ByteField.Init(new Meta.PLC.SettingField(), "se_fengjiqidongshijiansheding", 143, 4, "风机启动时间设定", "S"));
            map.Add("se_fengjiqidongpinlvsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_fengjiqidongpinlvsheding", 147, 4, "风机启动频率设定", "Hz"));
            map.Add("se_fengjiyunxingpinlvsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_fengjiyunxingpinlvsheding", 151, 4, "风机运行频率设定", "Hz"));
            map.Add("se_jinchukouyachagaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_jinchukouyachagaobaojingsheding", 155, 4, "进出口压差高报警设定", "MPa"));
            map.Add("se_jinchukouyachadibaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_jinchukouyachadibaojingsheding", 159, 4, "进出口压差低报警设定", "MPa"));
            map.Add("se_liuliangxiaxianbaojing", ByteField.Init(new Meta.PLC.SettingField(), "se_liuliangxiaxianbaojing", 163, 4, "流量下限报警", "m³/h"));
            map.Add("se_liuliangjidibaojing", ByteField.Init(new Meta.PLC.SettingField(), "se_liuliangjidibaojing", 167, 4, "流量极低报警", "m³/h"));
            map.Add("se_danqiyalidisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_danqiyalidisheding", 171, 4, "氮气压力低设定", "kPa"));
            map.Add("se_danqiyaligaosheding", ByteField.Init(new Meta.PLC.SettingField(), "se_danqiyaligaosheding", 175, 4, "氮气压力高设定", "kPa"));
            map.Add("se_diandongfashoudongkaidusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_diandongfashoudongkaidusheding", 179, 4, "电动阀手动开度设定", "%"));

            map.Add("de_1_xunhuanbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_xunhuanbeng_auto", 203, 2, "1#循环泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_xunhuanbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_xunhuanbeng_start_stop", 205, 2, "1#循环泵", DevicePointMap.coms_start_stop));
            map.Add("de_2_xunhuanbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_xunhuanbeng_auto", 207, 2, "2#循环泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_xunhuanbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_xunhuanbeng_start_stop", 209, 2, "2#循环泵", DevicePointMap.coms_start_stop));
            map.Add("de_3_xunhuanbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_3_xunhuanbeng_auto", 211, 2, "3#循环泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_3_xunhuanbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_3_xunhuanbeng_start_stop", 213, 2, "3#循环泵", DevicePointMap.coms_start_stop));
            map.Add("de_zhuyoubeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_zhuyoubeng_auto", 215, 2, "注油泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_zhuyoubeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_zhuyoubeng_start_stop", 217, 2, "注油泵", DevicePointMap.coms_start_stop));

            map.Add("ex_ranshaoqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranshaoqiguzhang", 229, 2, "燃烧器故障", 8));
            map.Add("ex_ranqixielou", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranqixielou", 229, 2, "燃气泄漏", 9));
            map.Add("ex_ranqiyaliyichang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranqiyaliyichang", 229, 2, "燃气压力异常", 10));
            map.Add("ex_fengjiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_fengjiguzhang", 229, 2, "风机故障", 11));
            map.Add("ex_1_xunhuanbengguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "xunhuanbengguzhang", 229, 2, "1#循环泵故障", 12));
            map.Add("ex_2_xunhuanbengguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "xunhuanbengguzhang", 229, 2, "2#循环泵故障", 13));
            map.Add("ex_3_xunhuanbengguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "xunhuanbengguzhang", 229, 2, "3#循环泵故障", 14));
            map.Add("ex_zhuyoubengguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_zhuyoubengguzhang", 229, 2, "注油泵故障", 15));
            map.Add("ex_jinchukouyachachaogao", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_jinchukouyachachaogao", 229, 2, "进出口压差超高", 0));
            map.Add("ex_jinchukouyachachaodi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_jinchukouyachachaodi", 229, 2, "进出口压差超低", 1));
            map.Add("ex_paiyanwenduchaogao", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanwenduchaogao", 229, 2, "排烟温度超高", 2));
            map.Add("ex_chukouwenduchaogao", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chukouwenduchaogao", 229, 2, "出口温度超高", 3));
            map.Add("ex_liuliangxiaxianbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_liuliangxiaxianbaojing", 229, 2, "流量下限报警", 4));
            map.Add("ex_liuliangjidibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_liuliangjidibaojing", 229, 2, "流量极低报警", 5));
            map.Add("ex_queyoubaojingfuqiu", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_queyoubaojingfuqiu", 229, 2, "缺油报警（浮球）", 6));
            map.Add("ex_chuyouwenduchuanganqibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chuyouwenduchuanganqibaojing", 229, 2, "出油温度传感器故障", 7));

            map.Add("ex_huiyouwenduchuanganqibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_huiyouwenduchuanganqibaojing", 231, 2, "回油温度传感器故障", 8));
            map.Add("ex_paiyanwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanwenduchuanganqiguzhang", 231, 2, "排烟温度传感器故障", 9));
            map.Add("ex_xunhuanbengliansuoguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_xunhuanbengliansuoguzhang", 231, 2, "循环泵连锁故障", 10));
            map.Add("ex_wendushedingcuowuguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_wendushedingcuowuguzhang", 231, 2, "温度设定错误故障", 11));
            map.Add("ex_gaoweiyoucaoyouweidibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_gaoweiyoucaoyouweidibaojing", 231, 2, "高位油槽油位低报警", 12));
            map.Add("ex_gaoweiyoucaoyouweigaobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_gaoweiyoucaoyouweigaobaojing", 231, 2, "高位油槽油位高报警", 13));
            map.Add("ex_1_zhiguanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_1_zhiguanchaowenbaojing", 231, 2, "1#支管超温报警", 14));
            map.Add("ex_2_zhiguanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_2_zhiguanchaowenbaojing", 231, 2, "2#支管超温报警", 15));
            map.Add("ex_3_zhiguanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_3_zhiguanchaowenbaojing", 231, 2, "3#支管超温报警", 0));
            map.Add("ex_4_zhiguanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_4_zhiguanchaowenbaojing", 231, 2, "4#支管超温报警", 1));
            map.Add("ex_5_zhiguanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_5_zhiguanchaowenbaojing", 231, 2, "5#支管超温报警", 2));
            map.Add("ex_6_zhiguanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_6_zhiguanchaowenbaojing", 231, 2, "6#支管超温报警", 3));
            map.Add("ex_7_zhiguanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_7_zhiguanchaowenbaojing", 231, 2, "7#支管超温报警", 4));
            map.Add("ex_8_zhiguanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_8_zhiguanchaowenbaojing", 231, 2, "8#支管超温报警", 5));
            map.Add("ex_9_zhiguanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_9_zhiguanchaowenbaojing", 231, 2, "9#支管超温报警", 6));
            map.Add("ex_10_zhiguanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_10_zhiguanchaowenbaojing", 231, 2, "10#支管超温报警", 7));
            map.Add("ex_plcguzhangbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_plcguzhangbaojing", 233, 2, "PLC故障报警", 8));
        }

    }
}
