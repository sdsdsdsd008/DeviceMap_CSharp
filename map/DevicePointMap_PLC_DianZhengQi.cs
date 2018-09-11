using SdcSoft.Devices.Meta;
using System;
using System.Collections.Generic;

namespace SdcSoft.Devices.map
{
    internal class DevicePointMap_PLC_DianZhengQi : DevicePointMap
    {
        public const string Key = "PLC_DianZhengQi";

        public DevicePointMap_PLC_DianZhengQi()
        {
            #region----------------------计算属性（不显示）----------------------
            map.Add("_addshuibeng", ByteField.Init(new Meta.PLC.DeviceField(), "_addshuibeng", 0, 0, "给水泵", false));
            #endregion

            map.Add(SdcSoftDevice.KEY_POINT_RUN_HOURS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_HOURS, 9, 2, "运行小时数", "时"));
            map.Add(SdcSoftDevice.KEY_POINT_RUN_DAYS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_RUN_DAYS, 11, 2, "运行天数", "天"));
            map.Add(SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, ByteField.Init(new Meta.PLC.BaseInfoField(), SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, 13, 2, "系统状态", PLC_Common_ValueMaps.coms_status));
            map.Add(SdcSoftDevice.KEY_POINT_POWER, ByteField.Init(new Meta.PLC.PowerField(), SdcSoftDevice.KEY_POINT_POWER, 1, 0, "燃料", DevicePointMap.coms_power));
            map.Add(SdcSoftDevice.KEY_POINT_MEDIA, ByteField.Init(new Meta.PLC.MediaField(), SdcSoftDevice.KEY_POINT_MEDIA, 1, 0, "介质", DevicePointMap.coms_media));
            map.Add("ba_shuiweizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_shuiweizhuangtai", 19, 2, "水位状态", DevicePointMap.coms_level));
            map.Add("ba_ranshaoqizhuangtai", ByteField.Init(new Meta.PLC.BaseInfoField(), "ba_ranshaoqizhuangtai", 21, 2, "燃烧器状态", PLC_Common_ValueMaps.coms_ranshaoqi_status));

            map.Add("mo_zhengqiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqiyali", 35, 4, "蒸汽压力", "MPa"));
            map.Add("mo_zhengqiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqiwendu", 39, 4, "蒸汽温度", "℃"));
            map.Add("mo_guolushuiwei", ByteField.Init(new Meta.PLC.MockField(), "mo_guolushuiwei", 43, 4, "锅炉水位", "mm"));
            map.Add("mo_zhengqishunshiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqishunshiliuliang", 47, 4, "蒸汽瞬时流量", "T/H"));
            map.Add("mo_bushuishunshiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_bushuishunshiliuliang", 51, 4, "补水瞬时流量", "T/H"));
            map.Add("mo_zhengqileijiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_zhengqileijiliuliang", 55, 4, "蒸汽累计流量", "T"));
            map.Add("mo_bushuileijiliuliang", ByteField.Init(new Meta.PLC.MockField(), "mo_bushuileijiliuliang", 59, 4, "补水累计流量", "T"));
            map.Add("mo_jinshuiwendu", ByteField.Init(new Meta.PLC.MockField(), "mo_jinshuiwendu", 63, 4, "进水温度", "℃"));
            map.Add("mo_jinshuiyali", ByteField.Init(new Meta.PLC.MockField(), "mo_jinshuiyali", 67, 4, "进水压力", "MPa"));
            map.Add("mo_addshuibengpinlvfankui", ByteField.Init(new Meta.PLC.MockField(), "mo_addshuibengpinlvfankui", 71, 4, "给水泵频率反馈", "Hz"));
            map.Add("mo_ruanshuixiangyewei", ByteField.Init(new Meta.PLC.MockField(), "mo_ruanshuixiangyewei", 75, 4, "软水箱液位", "%"));
            map.Add("mo_qidongjiarezushu", ByteField.Init(new Meta.PLC.MockField(), "mo_qidongjiarezushu", 79, 4, "启动加热组数", "组"));
            map.Add("mo_qidongjiarezushubaifenbi", ByteField.Init(new Meta.PLC.MockField(), "mo_qidongjiarezushubaifenbi", 83, 4, "启动加热组数百分比", "%"));

            map.Add("se_chaoyabaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_chaoyabaojingsheding", 127, 4, "超压报警设定", "MPa"));
            map.Add("se_shiyongjiarezushusheding", ByteField.Init(new Meta.PLC.SettingField(), "se_shiyongjiarezushusheding", 131, 4, "使用加热组数设定", "组"));
            map.Add("se_touqiejiangeshijiansheding", ByteField.Init(new Meta.PLC.SettingField(), "se_touqiejiangeshijiansheding", 135, 4, "投切间隔时间设定", "S"));
            map.Add("se_kuaiqiejiangeshijiansheding", ByteField.Init(new Meta.PLC.SettingField(), "se_kuaiqiejiangeshijiansheding", 139, 4, "快切间隔时间设定", "S"));
            map.Add("se_tingluyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_tingluyalisheding", 143, 4, "停炉压力设定", "MPa"));
            map.Add("se_shiyongyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_shiyongyalisheding", 147, 4, "使用压力设定", "MPa"));
            map.Add("se_qiluyalisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_qiluyalisheding", 151, 4, "启炉压力设定", "MPa"));
            map.Add("se_guolushuiweijidibaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_guolushuiweijidibaojingsheding", 155, 4, "锅炉水位极低报警设定", "mm"));
            map.Add("se_geishuibengshoudongpinlvsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_geishuibengshoudongpinlvsheding", 159, 4, "给水泵手动频率设定", "Hz"));
            map.Add("se_bushuimubiaosheding", ByteField.Init(new Meta.PLC.SettingField(), "se_bushuimubiaosheding", 163, 4, "补水目标设定", "mm"));
            map.Add("se_guolushuiweijigaobaojingsheding", ByteField.Init(new Meta.PLC.SettingField(), "se_guolushuiweijigaobaojingsheding", 167, 4, "锅炉水位极高报警设定", "mm"));
            map.Add("se_qibengyeweisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_qibengyeweisheding", 171, 4, "启泵液位设定", "mm"));
            map.Add("se_tingbengyeweisheding", ByteField.Init(new Meta.PLC.SettingField(), "se_tingbengyeweisheding", 175, 4, "停泵液位设定", "mm"));


            map.Add("de_1_addshuibeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_addshuibeng_auto", 199, 2, "1#给水泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_1_addshuibeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_1_addshuibeng_start_stop", 201, 2, "1#给水泵", DevicePointMap.coms_start_stop));
            map.Add("de_2_addshuibeng_auto", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_addshuibeng_auto", 203, 2, "2#给水泵", PLC_Common_ValueMaps.coms_atuo));
            map.Add("de_2_addshuibeng_start_stop", ByteField.Init(new Meta.PLC.DeviceField(), "de_2_addshuibeng_start_stop", 205, 2, "2#给水泵", DevicePointMap.coms_start_stop));
            map.Add("de_baojingshuchuzhishi", ByteField.Init(new Meta.PLC.DeviceField(), "de_baojingshuchuzhishi", 207, 2, "报警输出指示", coms_open_close));


            map.Add("ex_shuidianjiluojicuobaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuidianjiluojicuobaojing", 233, 2, "水电极逻辑错报警", 0));
            map.Add("ex_yalibiansongqiguzhangbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_yalibiansongqiguzhangbaojing", 233, 2, "压力变送器故障报警", 1));
            map.Add("ex_shuiweibiansongqiguzhangbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweibiansongqiguzhangbaojing", 233, 2, "水位变送器故障报警", 2));
            map.Add("ex_geishuibengbianpinqiguzhang", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_geishuibengbianpinqiguzhang", 233, 2, "给水泵变频器故障", 3));
            map.Add("ex_loudianbaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_loudianbaojing", 233, 2, "漏电报警", 4));
            map.Add("ex_qianyabaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_qianyabaojing", 233, 2, "欠压报警", 5));

            map.Add("ex_shuiweiweidibaojing_dianji", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweiweidibaojing_dianji", 233, 2, "水位危低报警（电极）", 8));
            map.Add("ex_shuiweijidibaojing_dianji", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijidibaojing_dianji", 233, 2, "水位极低报警（电极）", 9));
            map.Add("ex_shuiweijigaobaojing_dianji", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijigaobaojing_dianji", 233, 2, "水位极高报警（电极）", 10));
            map.Add("ex_shuiweijidibaojing_shedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijidibaojing_shedingzhi", 233, 2, "水位极低报警（设定值）", 11));
            map.Add("ex_shuiweijigaobaojing_shedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_shuiweijigaobaojing_shedingzhi", 233, 2, "水位极高报警（设定值）", 12));
            map.Add("ex_chaoyabaojing_yalikaiguan", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chaoyabaojing_yalikaiguan", 233, 2, "超压报警（压力开关）", 13));
            map.Add("ex_chaoyabaojing_shedingzhi", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_chaoyabaojing_shedingzhi", 233, 2, "超压报警（设定值）", 14));
            map.Add("ex_ruanshuixiangqueshuibaojing", ByteField.Init(new Meta.PLC.ExceptionField(), "ex_ruanshuixiangqueshuibaojing", 233, 2, "软水箱缺水报警", 15));

            map.Add("oc_1#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_1#jiarezu", 237, 2, "1#加热组反馈", 1));
            map.Add("oc_2#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_2#jiarezu", 237, 2, "2#加热组反馈", 1));
            map.Add("oc_3#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_3#jiarezu", 237, 2, "3#加热组反馈", 1));
            map.Add("oc_4#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_4#jiarezu", 237, 2, "4#加热组反馈", 1));
            map.Add("oc_5#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_5#jiarezu", 237, 2, "5#加热组反馈", 1));
            map.Add("oc_6#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_6#jiarezu", 237, 2, "6#加热组反馈", 1));
            map.Add("oc_7#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_7#jiarezu", 237, 2, "7#加热组反馈", 1));
            map.Add("oc_8#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_8#jiarezu", 237, 2, "8#加热组反馈", 1));
            map.Add("oc_9#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_9#jiarezu", 237, 2, "9#加热组反馈", 1));
            map.Add("oc_10#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_10#jiarezu", 237, 2, "10#加热组反馈", 1));
            map.Add("oc_11#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_11#jiarezu", 237, 2, "11#加热组反馈", 1));
            map.Add("oc_12#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_12#jiarezu", 237, 2, "12#加热组反馈", 1));
            map.Add("oc_13#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_13#jiarezu", 237, 2, "13#加热组反馈", 1));
            map.Add("oc_14#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_14#jiarezu", 237, 2, "14#加热组反馈", 1));
            map.Add("oc_15#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_15#jiarezu", 237, 2, "15#加热组反馈", 1));
            map.Add("oc_16#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_16#jiarezu", 237, 2, "16#加热组反馈", 1));
            map.Add("oc_17#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_17#jiarezu", 239, 2, "17#加热组反馈", 1));
            map.Add("oc_18#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_18#jiarezu", 239, 2, "18#加热组反馈", 1));
            map.Add("oc_19#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_19#jiarezu", 239, 2, "19#加热组反馈", 1));
            map.Add("oc_20#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_20#jiarezu", 239, 2, "20#加热组反馈", 1));
            map.Add("oc_21#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_21#jiarezu", 239, 2, "21#加热组反馈", 1));
            map.Add("oc_22#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_22#jiarezu", 239, 2, "22#加热组反馈", 1));
            map.Add("oc_23#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_23#jiarezu", 239, 2, "23#加热组反馈", 1));
            map.Add("oc_24#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_24#jiarezu", 239, 2, "24#加热组反馈", 1));
            map.Add("oc_25#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_25#jiarezu", 239, 2, "25#加热组反馈", 1));
            map.Add("oc_26#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_26#jiarezu", 239, 2, "26#加热组反馈", 1));
            map.Add("oc_27#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_27#jiarezu", 239, 2, "27#加热组反馈", 1));
            map.Add("oc_28#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_28#jiarezu", 239, 2, "28#加热组反馈", 1));
            map.Add("oc_29#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_29#jiarezu", 239, 2, "29#加热组反馈", 1));
            map.Add("oc_30#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_30#jiarezu", 239, 2, "30#加热组反馈", 1));
            map.Add("oc_31#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_31#jiarezu", 239, 2, "31#加热组反馈", 1));
            map.Add("oc_32#jiarezu", ByteField.Init(new Meta.PLC.OpenCloseField(), "oc_32#jiarezu", 239, 2, "32#加热组反馈", 1));

        }
    }
}
