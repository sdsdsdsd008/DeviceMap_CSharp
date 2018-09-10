using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices.map
{
    internal class DevicePointMap_PLC_RanMeiZhengQi : DevicePointMap
    {
        public const string Key = "PLC_RanMeiZhengQi";

        public DevicePointMap_PLC_RanMeiZhengQi()
        {
            #region----------------------计算属性（不显示）----------------------
            map.Add("_addshuibeng", ByteField.Init(new Meta.PLC.DeviceField(), "_addshuibeng", 0, 0, "给水泵", false));
            map.Add("_chuanyangbeng", ByteField.Init(new Meta.PLC.DeviceField(), "_chuanyangbeng", 0, 0, "除氧泵", false));
            map.Add("_gufengfan", ByteField.Init(new Meta.PLC.DeviceField(), "_gufengfan", 0, 0, "鼓风", false));
            map.Add("_yinfengfan", ByteField.Init(new Meta.PLC.DeviceField(), "_yinfengfan", 0, 0, "引风", false));
            map.Add("_lupaifan", ByteField.Init(new Meta.PLC.DeviceField(), "_lupaifan", 0, 0, "炉排", false));
            map.Add("_chuzhafan", ByteField.Init(new Meta.PLC.DeviceField(), "_chuzhafan", 0, 0, "出渣", false));
            #endregion

            map.Add(SdcSoftDevice.KEY_POINT_RUN_HOURS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_HOURS, 9, 2, "运行小时数", "时"));
            map.Add(SdcSoftDevice.KEY_POINT_RUN_DAYS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_DAYS, 11, 2, "运行天数", "天"));
            map.Add(SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, 13, 2, "系统状态",PLC_Common_ValueMaps.coms_status));
            map.Add(SdcSoftDevice.KEY_POINT_POWER, ByteField.Init(new Meta.PLC.PowerField(), SdcSoftDevice.KEY_POINT_POWER, 2, 0, "燃料",DevicePointMap.coms_power));
            map.Add(SdcSoftDevice.KEY_POINT_MEDIA, ByteField.Init(new Meta.PLC.MediaField(), SdcSoftDevice.KEY_POINT_MEDIA, 1, 0, "介质",DevicePointMap.coms_media));
            map.Add("ba_shuiweizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_shuiweizhuangtai", 19, 2, "水位状态",DevicePointMap.coms_level));
            map.Add("ba_ranshaoqizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_ranshaoqizhuangtai", 21, 2, "燃烧器状态",PLC_Common_ValueMaps.coms_ranshaoqi_status));

            map.Add("mo_zhengqiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqiyali", 35, 4, "蒸汽压力", "MPa"));
            map.Add("mo_guoluyewei", ByteField.Init(new Meta.PLC.MockField(), "mo_guoluyewei", 39, 4, "锅炉液位", "mm"));
            map.Add("mo_zhengqishunshiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqishunshiliuliang", 43, 4, "蒸汽瞬时流量", "T/h"));
            map.Add("mo_bushuishunshiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_bushuishunshiliuliang", 47, 4, "补水瞬时流量", "m³/h"));
            map.Add("mo_lutangwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_lutangwendu", 51, 4, "炉膛温度", "℃"));
            map.Add("mo_lutangyali", ByteField.Init(new Meta.PLC.MockField(), "mo_lutangyali", 55, 4, "炉膛压力", "Pa"));
            map.Add("mo_shengmeiqijinkouyanwen", ByteField.Init(new Meta.PLC.MockField(), "mo_shengmeiqijinkouyanwen", 59, 4, "省煤器进口烟温", "℃"));
            map.Add("mo_zuizhongpaiyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_zuizhongpaiyanwendu", 63, 4, "最终排烟温度", "℃"));
            map.Add("mo_zhengqileijiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqileijiliuliang", 67, 4, "蒸汽累计流量", "T"));
            map.Add("mo_bushuileijiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_bushuileijiliuliang", 71, 4, "补水累计流量", "m³"));
            map.Add("mo_shengmeiqijinshuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_shengmeiqijinshuiwendu", 75, 4, "省煤器进水温度", "℃"));
            map.Add("mo_shengmeiqichushuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_shengmeiqichushuiwendu", 79, 4, "省煤器出水温度", "℃"));
            map.Add("mo_bushuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_bushuiwendu", 83, 4, "补水温度", "℃"));
            map.Add("mo_paiyanyali", ByteField.Init(new Meta.PLC.MockField(), "mo_paiyanyali", 87, 4, "排烟压力", "Pa"));
            map.Add("mo_addshuibengpinlvfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_addshuibengpinlvfankui", 91, 4, "给水泵频率反馈", "Hz"));
            map.Add("mo_yinfengjipinlvfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_yinfengjipinlvfankui", 95, 4, "引风机频率反馈", "Hz"));
            map.Add("mo_gufengjipinlvfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_gufengjipinlvfankui", 99, 4, "鼓风机频率反馈", "Hz"));
            map.Add("mo_ruanshuixiangyewei", ByteField.Init(new Meta.PLC.MockField(), "mo_ruanshuixiangyewei", 103, 4, "软水箱液位", "%"));
            map.Add("mo_guorezhengqiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_guorezhengqiyali", 107, 4, "过热蒸汽压力", "MPa"));
            map.Add("mo_chuyangqiyewei", ByteField.Init(new Meta.PLC.MockField(), "mo_chuyangqiyewei", 111, 4, "除氧器液位", "%"));
            map.Add("mo_guoreqichukouyanwen", ByteField.Init(new Meta.PLC.MockField(), "mo_guoreqichukouyanwen", 115, 4, "过热器出口烟温", "℃"));
            map.Add("mo_guoreqizhengqiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_guoreqizhengqiwendu", 119, 4, "过热器蒸汽温度", "℃"));
            map.Add("mo_baohezhengqiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_baohezhengqiwendu", 123, 4, "饱和蒸汽温度", "℃"));
            map.Add("mo_yureqijinyanwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_yureqijinyanwendu", 127, 4, "预热器进烟温度", "℃"));
            map.Add("mo_yureqijinyanyali", ByteField.Init(new Meta.PLC.MockField(), "mo_yureqijinyanyali", 131, 4, "预热器进烟压力", "Pa"));
            map.Add("mo_chuyangqiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_chuyangqiwendu", 135, 4, "除氧器温度", "℃"));
            map.Add("mo_chuyangqiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_chuyangqiyali", 139, 4, "除氧器压力", "KPa"));
            map.Add("mo_chuyangbengpinlvfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_chuyangbengpinlvfankui", 143, 4, "除氧泵频率反馈", "Hz"));
            map.Add("mo_bushuidiandongfafankui", ByteField.Init(new Meta.PLC.MockField(), "mo_bushuidiandongfafankui", 147, 4, "补水电动阀反馈", "%"));
            map.Add("mo_jianwenshuidiandongfafankui", ByteField.Init(new Meta.PLC.MockField(), "mo_jianwenshuidiandongfafankui", 151, 4, "减温水电动阀反馈", "%"));
            map.Add("mo_chuyangjiarediandongfafankui", ByteField.Init(new Meta.PLC.MockField(), "mo_chuyangjiarediandongfafankui", 155, 4, "除氧加热电动阀反馈", "%"));
            map.Add("mo_zhaoqiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_zhaoqiyali", 159, 4, "沼气压力", "kPa"));
            map.Add("mo_lutangchukouyanwen", ByteField.Init(new Meta.PLC.MockField(), "mo_lutangchukouyanwen", 163, 4, "炉膛出口烟温", "℃"));
            map.Add("mo_kongyuqichukouyanwen", ByteField.Init(new Meta.PLC.MockField(), "mo_kongyuqichukouyanwen", 167, 4, "空预器出口烟温", "℃"));
            map.Add("mo_shengmeiqichukouyanwen", ByteField.Init(new Meta.PLC.MockField(), "mo_shengmeiqichukouyanwen", 171, 4, "省煤器出口烟温", "℃"));



            map.Add("se_qiluyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_qiluyalisheding", 248, 4, "启炉压力设定", "MPa"));
            map.Add("se_mubiaoyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_mubiaoyalisheding", 252, 4, "目标压力设定", "MPa"));
            map.Add("se_tingluyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_tingluyalisheding", 256, 4, "停炉压力设定", "MPa"));
            map.Add("se_chaoyabaojingyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chaoyabaojingyalisheding", 260, 4, "超压报警压力设定", "MPa"));
            map.Add("se_paiyanchaowenbaojing", ByteField.Init(new Meta.PLC.SettingField(), "se_paiyanchaowenbaojing", 264, 4, "排烟超温报警", "℃"));
            map.Add("se_guolushuiweimubiaosheding", ByteField.Init(new Meta.PLC.SettingField(), "se_guolushuiweimubiaosheding", 268, 4, "锅炉水位目标设定", "mm"));
            map.Add("se_guolushuiweijigaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_guolushuiweijigaobaojingsheding", 272, 4, "锅炉水位极高报警设定", "mm"));
            map.Add("se_guolutingbengshuiweisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_guolutingbengshuiweisheding", 276, 4, "锅炉停泵水位设定", "mm"));
            map.Add("se_guoluqibengshuiweisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_guoluqibengshuiweisheding", 280, 4, "锅炉启泵水位设定", "mm"));
            map.Add("se_guolushuiweijidibaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_guolushuiweijidibaojingsheding", 284, 4, "锅炉水位极低报警设定", "mm"));
            map.Add("se_guolushuiweishoudonggeisu", ByteField.Init(new Meta.PLC.SettingField(), "se_guolushuiweishoudonggeisu", 288, 4, "锅炉水位手动给速", "%"));

            map.Add("de_yinfeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_yinfeng_auto", 368, 2, "引风",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_yinfenji_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_yinfenji_start_stop", 370, 2, "引风", DevicePointMap.coms_start_stop));
            map.Add("de_gufeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_gufeng_auto", 372, 2, "鼓风",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_gufengji_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_gufengji_start_stop", 374, 2, "鼓风", DevicePointMap.coms_start_stop));
            map.Add("de_lupai_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_lupai_auto", 376, 2, "炉排",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_lupai_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_lupai_start_stop", 378, 2, "炉排", DevicePointMap.coms_start_stop));
            map.Add("de_chuzha_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_chuzha_auto", 380, 2, "除渣",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_chuzha_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_chuzha_start_stop", 382, 2, "出渣", DevicePointMap.coms_start_stop));
            map.Add("de_1_addshuibeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_addshuibeng_auto", 384, 2, "1#给水泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_addshuibeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_addshuibeng_start_stop", 386, 2, "1#给水泵", DevicePointMap.coms_start_stop));
            map.Add("de_2_addshuibeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_addshuibeng_auto", 388, 2, "2#给水泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_addshuibeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_addshuibeng_start_stop", 390, 2, "2#给水泵", DevicePointMap.coms_start_stop));
            map.Add("de_1_chuyangbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_chuyangbeng_auto", 392, 2, "1#除氧泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_chuyangbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_chuyangbeng_start_stop", 394, 2, "1#除氧泵", DevicePointMap.coms_start_stop));
            map.Add("de_2_chuyangbeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_chuyangbeng_auto", 396, 2, "2#除氧泵",PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_chuyangbeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_chuyangbeng_start_stop", 398, 2, "2#除氧泵", DevicePointMap.coms_start_stop));

            map.Add("ex_shuiweijidibaojing_shedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijidibaojing_shedingzhi", 448, 2, "水位极低报警（设定值）", 0));
            map.Add("ex_shuiweijigaobaojing_shedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijigaobaojing_shedingzhi", 448, 2, "水位极高报警（设定值）", 1));
            map.Add("ex_chaoyabaojing_yalikaiguan", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chaoyabaojing_yalikaiguan", 448, 2, "超压报警（压力开关）", 2));
            map.Add("ex_chaoyabaojing_shedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chaoyabaojing_shedingzhi", 448, 2, "超压报警（设定值）", 3));
            map.Add("ex_paiyanchaowenbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanchaowenbaojing", 448, 2, "排烟超温报警", 4));
            map.Add("ex_ruanshuixiangqueshuibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ruanshuixiangqueshuibaojing", 448, 2, "软水箱缺水报警", 5));
            map.Add("ex_shuidianjiluojicuobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuidianjiluojicuobaojing", 448, 2, "水电极逻辑错报警", 6));
            map.Add("ex_yalibiansongqiguzhangbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_yalibiansongqiguzhangbaojing", 448, 2, "压力变送器故障报警", 7));

            map.Add("ex_yinfengjibianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_yinfengjibianpinqiguzhang", 448, 2, "引风机变频器故障", 8));
            map.Add("ex_gufengjibianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_gufengjibianpinqiguzhang", 448, 2, "鼓风机变频器故障", 9));
            map.Add("ex_lupaibianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_lupaibianpinqiguzhang", 448, 2, "炉排变频器故障", 10));
            map.Add("ex_chuzhabianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chuzhabianpinqiguzhang", 448, 2, "除渣变频器故障", 11));
            map.Add("ex_jishuibianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_jishuibianpinqiguzhang", 448, 2, "给水变频器故障", 12));
            map.Add("ex_shuiweiweidibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweiweidibaojing", 448, 2, "水位危低报警（电极）", 13));
            map.Add("ex_shuiweijidibaojing_dianji", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijidibaojing_dianji", 448, 2, "水位极低报警（电极）", 14));
            map.Add("ex_shuiweijigaobaojing_dianji", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijigaobaojing_dianji", 448, 2, "水位极高报警（电极）", 15));


            map.Add("ex_shuiweibiansongqiguzhangbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweibiansongqiguzhangbaojing", 450, 2, "水位变送器故障报警", 8));
            map.Add("ex_paiyanwenduchuanganqiguzhangbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_paiyanwenduchuanganqiguzhangbaojing", 450, 2, "排烟温度传感器故障报警", 9));
            map.Add("ex_chuyangqiqueshuibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chuyangqiqueshuibaojing", 450, 2, "除氧器缺水报警", 10));
            map.Add("ex_chuyangqigaoshuiweibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chuyangqigaoshuiweibaojing", 450, 2, "除氧器高水位报警", 11));

        }
    }
}
