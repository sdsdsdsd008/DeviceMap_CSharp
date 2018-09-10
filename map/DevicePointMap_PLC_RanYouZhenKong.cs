using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices.map
{
    internal class DevicePointMap_PLC_RanYouZhenKong : DevicePointMap
    {
        public const string Key = "PLC_RanYouZhenKong";

        public DevicePointMap_PLC_RanYouZhenKong()
        {
            #region----------------------计算属性（不显示）----------------------
            map.Add("_xunhuanbeng", ByteField.Init(new Meta.PLC.DeviceField(), "_xunhuanbeng", 0, 0, "循环泵", false));
            map.Add("_addshuibeng", ByteField.Init(new Meta.PLC.DeviceField(), "_addshuibeng", 0, 0, "给水泵", false));
            map.Add("_zhenkongbeng", ByteField.Init(new Meta.PLC.DeviceField(), "_zhenkongbeng", 0, 0, "真空泵", false));
            #endregion

            map.Add(SdcSoftDevice.KEY_POINT_RUN_HOURS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_HOURS, 9, 2, "运行小时数", "时"));
            map.Add(SdcSoftDevice.KEY_POINT_RUN_DAYS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_DAYS, 11, 2, "运行天数", "天"));
            map.Add(SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, 13, 2, "系统状态",PLC_Common_ValueMaps.coms_status));
            map.Add(SdcSoftDevice.KEY_POINT_POWER, ByteField.Init(new Meta.PLC.PowerField(), SdcSoftDevice.KEY_POINT_POWER, 0, 0, "燃料",DevicePointMap.coms_power));
            map.Add(SdcSoftDevice.KEY_POINT_MEDIA, ByteField.Init(new Meta.PLC.MediaField(), SdcSoftDevice.KEY_POINT_MEDIA, 4, 0, "介质",DevicePointMap.coms_media));
            map.Add("ba_shuiweizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_shuiweizhuangtai", 19, 2, "水位状态",DevicePointMap.coms_level));
            map.Add("ba_ranshaoqizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_ranshaoqizhuangtai", 21, 2, "燃烧器状态",PLC_Common_ValueMaps.coms_ranshaoqi_status));

            map.Add("mo_remeishuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_remeishuiwendu", 35, 4, "热媒水温度", "℃"));
            map.Add("mo_zhenkongyali", ByteField.Init(new Meta.PLC.MockField(), "mo_zhenkongyali", 39, 4, "真空压力", "Kpa"));
            map.Add("mo_jinyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_jinyanwendu", 43, 4, "进烟温度", "℃"));
            map.Add("mo_paiyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_paiyanwendu", 47, 4, "排烟温度", "℃"));
            map.Add("mo_shiwaiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_shiwaiwendu", 51, 4, "室外温度", "℃"));
            map.Add("mo_cainuanchushuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_cainuanchushuiwendu", 55, 4, "采暖出水温度", "℃"));
            map.Add("mo_cainuanhuishuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_cainuanhuishuiwendu", 59, 4, "采暖回水温度", "℃"));
            map.Add("mo_cainuanchushuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_cainuanchushuiyali", 63, 4, "采暖出水压力", "Mpa"));
            map.Add("mo_cainuanhuishuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_cainuanhuishuiyali", 67, 4, "采暖回水压力", "Mpa"));
            map.Add("mo_shenghuochushuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_shenghuochushuiwendu", 71, 4, "生活出水温度", "℃"));
            map.Add("mo_shenghuohuishuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_shenghuohuishuiwendu", 75, 4, "生活回水温度", "℃"));
            map.Add("mo_shenghuochushuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_shenghuochushuiyali", 79, 4, "生活出水压力", "Mpa"));
            map.Add("mo_shenghuohuishuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_shenghuohuishuiyali", 83, 4, "生活回水压力", "Mpa"));

            map.Add("se_qiluwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_qiluwendusheding", 111, 4, "启炉温度设定", "℃"));
            map.Add("se_mubiaowendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_mubiaowendusheding", 115, 4, "目标温度设定", "℃"));
            map.Add("se_tingluwendusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_tingluwendusheding", 119, 4, "停炉温度设定", "℃"));
            map.Add("se_zhenkongyalidisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_zhenkongyalidisheding", 123, 4, "真空压力低设定", "KPa"));
            map.Add("se_zhenkongyaligaosheding", ByteField.Init(new Meta.PLC.SettingField(), "se_zhenkongyaligaosheding", 127, 4, "真空压力高设定", "KPa"));
            map.Add("se_paiyanwenduchaogaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_paiyanwenduchaogaobaojingsheding", 131, 4, "排烟温度超高报警设定", "℃"));
            map.Add("se_chukouwenduchaogaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chukouwenduchaogaobaojingsheding", 135, 4, "出口温度超高报警设定", "℃"));
            map.Add("se_zhenkongyalichaogaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_zhenkongyalichaogaobaojingsheding", 139, 4, "真空压力超高报警设定", "KPa"));

            map.Add("de_ranshaojiqiting", ByteField.Init(new Meta.PLC.DeviceField(), "de_ranshaojiqiting", 163, 2, "燃烧器",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_xunhuanbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_xunhuanbeng_auto", 165, 2, "1#循环泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_xunhuanbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_xunhuanbeng_start_stop", 167, 2, "1#循环泵",DevicePointMap.coms_start_stop));
            map.Add("de_2_xunhuanbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_xunhuanbeng_auto", 169, 2, "2#循环泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_xunhuanbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_xunhuanbeng_start_stop", 171, 2, "2#循环泵", DevicePointMap.coms_start_stop));
            map.Add("de_1_addshuibeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_addshuibeng_auto", 173, 2, "1#补水泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_addshuibeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_addshuibeng_start_stop", 175, 2, "1#补水泵", DevicePointMap.coms_start_stop));
            map.Add("de_2_addshuibeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_addshuibeng_auto", 177, 2, "2#补水泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_addshuibeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_addshuibeng_start_stop", 179, 2, "2#补水泵", DevicePointMap.coms_start_stop));
            map.Add("de_zhenkongbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_zhenkongbeng_auto", 181, 2, "真空泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_zhenkongbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_zhenkongbeng_start_stop", 183, 2, "真空泵", DevicePointMap.coms_start_stop));

            map.Add("ex_lubichaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_lubichaowenbaojing", 203, 2, "炉壁超温报警", 0));
            map.Add("ex_remeishuiwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_remeishuiwenduchuanganqiguzhang", 203, 2, "热媒水温度传感器故障", 1));
            map.Add("ex_paiyanwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanwenduchuanganqiguzhang", 203, 2, "排烟温度传感器故障", 2));
            map.Add("ex_cainuanchushuiwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_cainuanchushuiwenduchuanganqiguzhang", 203, 2, "采暖出水温度传感器故障", 3));
            map.Add("ex_shenghuochushuiwenduchuanganqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shenghuochushuiwenduchuanganqiguzhang", 203, 2, "生活出水温度传感器故障", 4));
            map.Add("ex_wendushedingcuowubaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_wendushedingcuowubaojing", 203, 2, "温度设定错误报警", 5));
            map.Add("ex_xunhuanbengliansuoduankaibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_xunhuanbengliansuoduankaibaojing", 203, 2, "循环泵连锁断开报警", 6));
            map.Add("ex_waibuliansuoduankaibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_waibuliansuoduankaibaojing", 203, 2, "外部连锁断开报警", 7));

            map.Add("ex_ranshaojiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranshaojiguzhang", 203, 2, "燃烧器故障", 8));
            map.Add("ex_ranqixielou", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranqixielou", 203, 2, "燃气泄漏", 9));
            map.Add("ex_ranqiyaliyichang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranqiyaliyichang", 203, 2, "燃气压力异常", 10));
            map.Add("ex_luneiyaligaobaojingshedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_luneiyaligaobaojingshedingzhi", 203, 2, "炉内压力高报警（设定值）", 11));
            map.Add("ex_luneiyaligaobaojingyalikaiguan", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_luneiyaligaobaojingyalikaiguan", 203, 2, "炉内压力高报警（压力开关）", 12));
            map.Add("ex_paiyanwenduchaogaobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanwenduchaogaobaojing", 203, 2, "排烟温度超高报警", 13));
            map.Add("ex_remeishuiwenduchaogaobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_remeishuiwenduchaogaobaojing", 203, 2, "热媒水温度超高报警", 14));
            map.Add("ex_queshuibaohubaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_queshuibaohubaojing", 203, 2, "缺水保护报警", 15));

        }
    }
}
