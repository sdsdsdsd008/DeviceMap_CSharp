using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices.map
{
    internal class DevicePointMap_PLC_RanYouZhengQi : DevicePointMap
    {
        public const string Key = "PLC_RanYouZhengQi";

        public DevicePointMap_PLC_RanYouZhengQi()
        {
            #region----------------------计算属性（不显示）----------------------
            map.Add("_addshuibeng", ByteField.Init(new Meta.PLC.DeviceField(), "_addshuibeng", 0, 0, "给水泵", false));
            map.Add("_jienengbeng", ByteField.Init(new Meta.PLC.DeviceField(), "_jienengbeng", 0, 0, "节能泵", false));
            map.Add("_chuanyangbeng", ByteField.Init(new Meta.PLC.DeviceField(), "_chuanyangbeng", 0, 0, "除氧泵", false));
            map.Add("_zhaoqifan", ByteField.Init(new Meta.PLC.DeviceField(), "_zhaoqifan", 0, 0, "沼气风机", false));
            #endregion

            map.Add(SdcSoftDevice.KEY_POINT_RUN_HOURS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_HOURS, 9, 2, "运行小时数", "时"));
            map.Add(SdcSoftDevice.KEY_POINT_RUN_DAYS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_DAYS, 11, 2, "运行天数", "天"));
            map.Add(SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, 13, 2, "系统状态", PLC_Common_ValueMaps.coms_status));
            map.Add(SdcSoftDevice.KEY_POINT_POWER, ByteField.Init(new Meta.PLC.PowerField(), SdcSoftDevice.KEY_POINT_POWER, 0, 0, "燃料", DevicePointMap.coms_power));
            map.Add(SdcSoftDevice.KEY_POINT_MEDIA, ByteField.Init(new Meta.PLC.MediaField(), SdcSoftDevice.KEY_POINT_MEDIA, 1, 0, "介质", DevicePointMap.coms_media));
            map.Add("ba_shuiweizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_shuiweizhuangtai", 19, 2, "水位状态", DevicePointMap.coms_level));
            map.Add("ba_ranshaoqizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_ranshaoqizhuangtai", 21, 2, "燃烧器状态", PLC_Common_ValueMaps.coms_ranshaoqi_status));

            map.Add("mo_zhengqiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqiyali", 35, 4, "蒸汽压力", "MPa"));
            map.Add("mo_guorezhengqiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_guorezhengqiyali", 39, 4, "过热蒸汽压力", "MPa"));
            map.Add("mo_zhengqiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqiwendu", 43, 4, "蒸汽温度", "℃"));
            map.Add("mo_guorezhengqiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_guorezhengqiwendu", 47, 4, "过热蒸汽温度", "℃"));
            map.Add("mo_guolushuiwei", ByteField.Init(new Meta.PLC.MockField(), "mo_guolushuiwei", 51, 4, "锅炉水位", ""));
            map.Add("mo_zhengqishunshiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqishunshiliuliang", 55, 4, "蒸汽瞬时流量", "m³/h"));
            map.Add("mo_bushuishunshiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_bushuishunshiliuliang", 59, 4, "补水瞬时流量", "m³/h"));
            map.Add("mo_lutangwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_lutangwendu", 63, 4, "炉膛温度", "℃"));
            map.Add("mo_lutangyali", ByteField.Init(new Meta.PLC.MockField(), "mo_lutangyali", 67, 4, "炉膛压力", "MPa"));
            map.Add("mo_lengningqijinkouyanwen", ByteField.Init(new Meta.PLC.MockField(), "mo_lengningqijinkouyanwen", 71, 4, "冷凝器进口烟温", "℃"));
            map.Add("mo_lengningqijinkouyanya", ByteField.Init(new Meta.PLC.MockField(), "mo_lengningqijinkouyanya", 75, 4, "冷凝器进口烟压", "kPa"));
            map.Add("mo_jienengqijinkouyanwen", ByteField.Init(new Meta.PLC.MockField(), "mo_jienengqijinkouyanwen", 79, 4, "节能器进口烟温", "℃"));
            map.Add("mo_jienengqijinkouyanya", ByteField.Init(new Meta.PLC.MockField(), "mo_jienengqijinkouyanya", 83, 4, "节能器进口烟压", "kPa"));
            map.Add("mo_zhengqileijiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqileijiliuliang", 87, 4, "蒸汽累计流量", "m³/h"));
            map.Add("mo_bushuileijiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_bushuileijiliuliang", 91, 4, "补水累计流量", "m³/h"));
            map.Add("mo_kongyuqijinyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqijinyanwendu", 95, 4, "空预器进烟温度", "℃"));
            map.Add("mo_kongyuqijinyanyali", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqijinyanyali", 99, 4, "空预器进烟压力", "kPa"));
            map.Add("mo_zuizhongpaiyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_zuizhongpaiyanwendu", 103, 4, "最终排烟温度", "℃"));
            map.Add("mo_zuizhongpaiyanyali", ByteField.Init(new Meta.PLC.MockField(), "mo_zuizhongpaiyanyali", 107, 4, "最终排烟压力", "MPa"));
            map.Add("mo_lengningqijinshuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_lengningqijinshuiwendu", 111, 4, "冷凝器进水温度", "℃"));
            map.Add("mo_lengningqichushuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_lengningqichushuiwendu", 115, 4, "冷凝器出水温度", "℃"));
            map.Add("mo_jienengqijinshuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_jienengqijinshuiwendu", 119, 4, "节能器进水温度", "℃"));
            map.Add("mo_jienengqichushuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_jienengqichushuiwendu", 123, 4, "节能器出水温度", "℃"));
            map.Add("mo_lengningqichushuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_lengningqichushuiyali", 127, 4, "冷凝器出水压力", "MPa"));
            map.Add("mo_jienengqichushuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_jienengqichushuiyali", 131, 4, "节能器出水压力", "MPa"));
            map.Add("mo_addshuibengpinlüfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_addshuibengpinlüfankui", 135, 4, "补水泵频率反馈", ""));
            map.Add("mo_ruanshuixiangyewei", ByteField.Init(new Meta.PLC.MockField(), "mo_ruanshuixiangyewei", 139, 4, "软水箱液位", "mm"));
            map.Add("mo_chuyangqiyewei", ByteField.Init(new Meta.PLC.MockField(), "mo_chuyangqiyewei", 143, 4, "除氧器液位", "mm"));
            map.Add("mo_chuyangqiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_chuyangqiwendu", 147, 4, "除氧器温度", "℃"));
            map.Add("mo_bushuidiandongfafankui", ByteField.Init(new Meta.PLC.MockField(), "mo_bushuidiandongfafankui", 151, 4, "补水电动阀反馈", ""));
            map.Add("mo_guoreqijiangwendiandongfafankui", ByteField.Init(new Meta.PLC.MockField(), "mo_guoreqijiangwendiandongfafankui", 155, 4, "过热器降温电动阀反馈", ""));
            map.Add("mo_zhufengjipinlüfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_zhufengjipinlüfankui", 159, 4, "主风机频率反馈", ""));
            map.Add("mo_xunhuanfengjipinlüfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_xunhuanfengjipinlüfankui", 163, 4, "循环风机频率反馈", ""));
            map.Add("mo_kongyuqijinfengwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqijinfengwendu", 167, 4, "空预器进风温度", "℃"));
            map.Add("mo_kongyuqijinfengyali", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqijinfengyali", 171, 4, "空预器进风压力", "MPa"));
            map.Add("mo_kongyuqichufengwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqichufengwendu", 175, 4, "空预器出风温度", "℃"));
            map.Add("mo_kongyuqichufengyali", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqichufengyali", 179, 4, "空预器出风压力", "MPa"));
            map.Add("mo_zhaoqiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_zhaoqiyali", 183, 4, "沼气压力", "KPa"));
            map.Add("mo_zhaoqishunshiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_zhaoqishunshiliuliang", 187, 4, "沼气瞬时流量", "m³/h"));
            map.Add("mo_zhaoqileijiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_zhaoqileijiliuliang", 191, 4, "沼气累计流量", "m³/h"));
            map.Add("mo_zhaoqifengjipinlvfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_zhaoqifengjipinlvfankui", 195, 4, "沼气风机频率反馈", "Hz"));


            map.Add("se_qiluyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_qiluyalisheding", 248, 4, "启炉压力设定", "MPa"));
            map.Add("se_mubiaoyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_mubiaoyalisheding", 252, 4, "目标压力设定", "MPa"));
            map.Add("se_tingluyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_tingluyalisheding", 256, 4, "停炉压力设定", "MPa"));
            map.Add("se_chaoyabaojingyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chaoyabaojingyalisheding", 260, 4, "超压报警压力设定", "MPa"));
            map.Add("se_paiyanchaowenbaojing", ByteField.Init(new Meta.PLC.SettingField(), "se_paiyanchaowenbaojing", 264, 4, "排烟超温报警", "℃"));
            map.Add("se_guolushuiweimubiaosheding", ByteField.Init(new Meta.PLC.SettingField(), "se_guolushuiweimubiaosheding", 268, 4, "锅炉水位目标设定", "mm"));
            map.Add("se_guolushuiweijigaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_guolushuiweijigaobaojingsheding", 272, 4, "锅炉水位极高报警设定", "mm"));
            map.Add("se_guolushuiweijidibaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_guolushuiweijidibaojingsheding", 276, 4, "锅炉水位极低报警设定", "mm"));
            map.Add("se_addshuibengshoudongpinlüsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_addshuibengshoudongpinlüsheding", 280, 4, "给水泵手动频率设定", "Hz"));
            map.Add("se_chuyangqibushuimubiaosheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chuyangqibushuimubiaosheding", 284, 4, "除氧器补水目标设定", "mm"));
            map.Add("se_chuyangqijigaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chuyangqijigaobaojingsheding", 288, 4, "除氧器极高报警设定", "mm"));
            map.Add("se_chuyangqitingbengyeweisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chuyangqitingbengyeweisheding", 292, 4, "除氧器停泵液位设定", "mm"));
            map.Add("se_chuyangqiqibengyeweisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chuyangqiqibengyeweisheding", 296, 4, "除氧器启泵液位设定", "mm"));
            map.Add("se_chuyangqijidibaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chuyangqijidibaojingsheding", 300, 4, "除氧器极低报警设定", "mm"));
            map.Add("se_chuyangqibushuishoudonggeisu", ByteField.Init(new Meta.PLC.SettingField(), "se_chuyangqibushuishoudonggeisu", 304, 4, "除氧器补水手动给速", "Hz"));
            map.Add("se_zhaoqiyalimubiaosheding", ByteField.Init(new Meta.PLC.SettingField(), "se_zhaoqiyalimubiaosheding", 308, 4, "沼气压力目标设定", "KPa"));


            map.Add("de_1_addshuibeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_addshuibeng_auto", 368, 2, "1#补水泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_addshuibeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_addshuibeng_start_stop", 370, 2, "1#补水泵", DevicePointMap.coms_start_stop));
            map.Add("de_2_addshuibeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_addshuibeng_auto", 372, 2, "2#补水泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_addshuibeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_addshuibeng_start_stop", 374, 2, "2#补水泵", DevicePointMap.coms_start_stop));
            map.Add("de_1_jienengbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_jienengbeng_auto", 376, 2, "1#节能泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_jienengbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_jienengbeng_start_stop", 378, 2, "1#节能泵", DevicePointMap.coms_start_stop));
            map.Add("de_2_jienengbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_jienengbeng_auto", 380, 2, "2#节能泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_jienengbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_jienengbeng_start_stop", 382, 2, "2#节能泵", DevicePointMap.coms_start_stop));
            map.Add("de_1_chuyangbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_chuyangbeng_auto", 384, 2, "1#除氧泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_chuyangbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_chuyangbeng_start_stop", 386, 2, "1#除氧泵", DevicePointMap.coms_start_stop));
            map.Add("de_2_chuyangbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_chuyangbeng_auto", 388, 2, "2#除氧泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_chuyangbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_chuyangbeng_start_stop", 390, 2, "2#除氧泵", DevicePointMap.coms_start_stop));
            map.Add("de_baojingshuchuzhishi", ByteField.Init(new Meta.PLC.DeviceField(), "de_baojingshuchuzhishi", 392, 2, "报警输出指示", DevicePointMap.coms_open_close));
            map.Add("de_1_zhaoqifengji_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_zhaoqifengji_auto", 394, 2, "1#沼气风机", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_zhaoqifengji_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_zhaoqifengji_start_stop", 396, 2, "1#沼气风机", DevicePointMap.coms_start_stop));
            map.Add("de_2_zhaoqifengji_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_zhaoqifengji_auto", 398, 2, "2#沼气风机", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_zhaoqifengji_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_zhaoqifengji_start_stop", 400, 2, "2#沼气风机启", DevicePointMap.coms_start_stop));

            map.Add("ex_chaoyabaojingyalikaiguan", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chaoyabaojingyalikaiguan", 448, 2, "超压报警（压力开关）", 0));
            map.Add("ex_chaoyabaojingshedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chaoyabaojingshedingzhi", 448, 2, "超压报警（设定值）", 1));
            map.Add("ex_paiyanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanchaowenbaojing", 448, 2, "排烟超温报警", 2));
            map.Add("ex_ruanshuixiangqueshuibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ruanshuixiangqueshuibaojing", 448, 2, "软水箱缺水报警", 3));
            map.Add("ex_shuidianjiluojicuobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuidianjiluojicuobaojing", 448, 2, "水电极逻辑错报警", 4));
            map.Add("ex_yalibiansongqiguzhangbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_yalibiansongqiguzhangbaojing", 448, 2, "压力变送器故障报警", 5));
            map.Add("ex_shuiweibiansongqiguzhangbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweibiansongqiguzhangbaojing", 448, 2, "水位变送器故障报警", 6));
            map.Add("ex_paiyanwenduchuanganqiguzhangbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanwenduchuanganqiguzhangbaojing", 448, 2, "排烟温度传感器故障报警", 7));

            map.Add("ex_ranshaoqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranshaoqiguzhang", 448, 2, "燃烧器故障", 8));
            map.Add("ex_ranqixielou", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranqixielou", 448, 2, "燃气泄漏", 9));
            map.Add("ex_ranqiyaliyichang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ranqiyaliyichang", 448, 2, "燃气压力异常", 10));
            map.Add("ex_shuiweiweidibaojingdianji", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweiweidibaojingdianji", 448, 2, "水位危低报警（电极）", 11));
            map.Add("ex_shuiweijidibaojingdianji", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijidibaojingdianji", 448, 2, "水位极低报警（电极）", 12));
            map.Add("ex_shuiweijigaobaojingdianji", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijigaobaojingdianji", 448, 2, "水位极高报警（电极）", 13));
            map.Add("ex_shuiweijidibaojingshedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijidibaojingshedingzhi", 448, 2, "水位极低报警（设定值）", 14));
            map.Add("ex_shuiweijigaobaojingshedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijigaobaojingshedingzhi", 448, 2, "水位极高报警（设定值）", 15));

            map.Add("ex_addshuibeng1guzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_addshuibeng1guzhang", 450, 2, "给水泵1故障", 0));
            map.Add("ex_addshuibeng2guzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_addshuibeng2guzhang", 450, 2, "给水泵2故障", 1));
            map.Add("ex_zhaoqifengjibianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_zhaoqifengjibianpinqiguzhang", 450, 2, "沼气风机变频器故障", 2));

            map.Add("ex_chuyangqiqueshuibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chuyangqiqueshuibaojing", 450, 2, "除氧器缺水报警", 8));
            map.Add("ex_chuyangqigaoshuiweibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chuyangqigaoshuiweibaojing", 450, 2, "除氧器高水位报警", 9));
            map.Add("ex_addshuibengbianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_addshuibengbianpinqiguzhang", 450, 2, "给水泵变频器故障", 10));
            map.Add("ex_chuyangbengbianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chuyangbengbianpinqiguzhang", 450, 2, "除氧泵变频器故障", 11));
            map.Add("ex_zhufengjibianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_zhufengjibianpinqiguzhang", 450, 2, "主风机变频器故障", 12));
            map.Add("ex_xunhuanfengjibianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_xunhuanfengjibianpinqiguzhang", 450, 2, "循环风机变频器故障", 13));
            map.Add("ex_jienengbeng1guzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_jienengbeng1guzhang", 450, 2, "节能泵1故障", 14));
            map.Add("ex_jienengbeng2guzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_jienengbeng2guzhang", 450, 2, "节能泵2故障", 15));
        }
    }
}
