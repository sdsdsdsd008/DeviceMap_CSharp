using SdcSoft.Devices.Meta;


/**
 * Created by jialiang on 2018/4/20.
 */
namespace SdcSoft.Devices.map
{
    class DevicePointMap_CTL_NJZJ_IPK2_485 : DevicePointMap
    {
        public const string Key = "CTL_NJZJ_IPK2_485";

        public DevicePointMap_CTL_NJZJ_IPK2_485()
        {

            map.Add(SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, ByteField.Init(new Meta.CTL_NJZJ_485.BaseInfoField(), SdcSoftDevice.KEY_POINT_SYSTEM_STATUS, 7, 2, "系统状态", CTL_NJZJ_Common_ValueMaps.coms_status));

            map.Add("ba_yunxingtianshu", ByteField.Init(new Meta.CTL_NJZJ_485.RunDaysField(), "ba_yunxingtianshu", 0, 0, "运行天数", "天"));

            map.Add("ba_yunxingxiaoshishu", ByteField.Init(new Meta.CTL_NJZJ_485.BaseInfoField(), "ba_yunxingxiaoshishu", 0, 0, "运行小时数", "时"));

            map.Add(SdcSoftDevice.KEY_POINT_POWER, ByteField.Init(new Meta.CTL_NJZJ_485.PowerField(), SdcSoftDevice.KEY_POINT_POWER, 3, 2, "燃料类型", coms_power));

            map.Add(SdcSoftDevice.KEY_POINT_MEDIA, ByteField.Init(new Meta.CTL_NJZJ_485.MediaField(), SdcSoftDevice.KEY_POINT_MEDIA, 5, 2, "介质类型", coms_media));

            map.Add("ba_guolushuiweizhuangtai", ByteField.Init(new Meta.CTL_NJZJ_485.BaseInfoField(), "ba_guolushuiweizhuangtai", 25, 2, "锅炉液位状态", coms_level));

            map.Add("ba_shuixiangshuiweizhuangtai", ByteField.Init(new Meta.CTL_NJZJ_485.BaseInfoField(), "ba_shuixiangshuiweizhuangtai", 27, 2, "水箱液位状态", coms_level));

            map.Add("ba_guoluyalizhuangtai", ByteField.Init(new Meta.CTL_NJZJ_485.BaseInfoField(), "ba_guoluyalizhuangtai", 29, 30, "锅炉压力状态", CTL_NJZJ_Common_ValueMaps.coms_yalistatus));
            map.Add("ba_moshibianhao", ByteField.Init(new Meta.CTL_NJZJ_485.BaseInfoField(), "ba_moshibianhao", 0, 0, "模式编号"));
            map.Add("ba_fangdongkaiguan", ByteField.Init(new Meta.CTL_NJZJ_485.BaseInfoField(), "ba_fangdongkaiguan", 0, 0, "防冻开关", DevicePointMap.coms_open_close));
            map.Add("ex_paiyanwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_paiyanwendugaobaojing", 36, 2, "排烟温度高报警"));
            map.Add("ex_lushuiwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lushuiwendugaobaojing", 38, 2, "炉水温度高报警"));

            map.Add("ex_chukouwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_chukouwendugaobaojing", 40, 2, "出口温度高报警"));

            map.Add("ex_chaoyabaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_chaoyabaojing", 42, 2, "超压报警"));

            map.Add("ex_jixiandishuiweibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jixiandishuiweibaojing", 44, 2, "极限低水位报警"));

            map.Add("ex_dishuiweibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_dishuiweibaojing", 46, 2, "低水位报警"));

            map.Add("ex_gaoshuiweibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_gaoshuiweibaojing", 48, 2, "高水位报警"));

            map.Add("ex_shuiweixinhaoluojicuobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shuiweixinhaoluojicuobaojing", 50, 2, "水位信号逻辑错报警"));

            map.Add("ex_lubiwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lubiwendugaobaojing", 52, 2, "炉壁温度高报警"));

            map.Add("ex_fuyazhengqiwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_fuyazhengqiwendugaobaojing", 54, 2, "负压蒸汽温度高报警"));

            map.Add("ex_ranshaoqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ranshaoqiguzhangbaojing", 56, 2, "燃烧器故障报警"));

            map.Add("ex_ranqixieloubaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ranqixieloubaojing", 58, 2, "燃气泄漏报警"));

            map.Add("ex_ranqiyalidibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ranqiyalidibaojing", 60, 2, "燃气压力低报警"));

            map.Add("ex_ranqiyaliyichangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ranqiyaliyichangbaojing", 62, 2, "燃气压力异常报警"));

            map.Add("ex_ranqiyaligaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ranqiyaligaobaojing", 64, 2, "燃气压力高报警"));

            map.Add("ex_jishuibianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jishuibianpinqiguzhangbaojing", 66, 2, "给水变频器故障报警"));

            map.Add("ex_xunhuanbianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_xunhuanbianpinqiguzhangbaojing", 68, 2, "循环变频器故障报警"));

            map.Add("ex_yinfengbianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_yinfengbianpinqiguzhangbaojing", 70, 2, "引风变频器故障报警"));

            map.Add("ex_gufengbianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_gufengbianpinqiguzhangbaojing", 72, 2, "鼓风变频器故障报警"));

            map.Add("ex_ecigufengbianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ecigufengbianpinqiguzhangbaojing", 74, 2, "二次鼓风变频器故障报警"));

            map.Add("ex_lupaibianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lupaibianpinqiguzhangbaojing", 76, 2, "炉排变频器故障报警"));

            map.Add("ex_addshuibengguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_addshuibengguzhangbaojing", 78, 2, "给水泵故障报警"));

            map.Add("ex_xunhuanbengguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_xunhuanbengguzhangbaojing", 80, 2, "循环泵故障报警"));

            map.Add("ex_chaodiyabaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_chaodiyabaojing", 82, 2, "超低压报警"));

            map.Add("ex_qiandianyabaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_qiandianyabaojing", 84, 2, "欠电压报警"));

            map.Add("ex_guodianyabaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_guodianyabaojing", 86, 2, "过电压报警"));

            map.Add("ex_quexiangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_quexiangbaojing", 88, 2, "缺相报警"));

            map.Add("ex_loudianbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_loudianbaojing", 90, 2, "漏电报警"));

            map.Add("ex_biansongqiguoyabaohu", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_biansongqiguoyabaohu", 92, 2, "变送器过压保护"));

            map.Add("ex_guanjiancanshuyichang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_guanjiancanshuyichang", 94, 2, "关键参数异常"));

            map.Add("ex_shedingcanshuyichang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shedingcanshuyichang", 96, 2, "设定参数异常"));

            map.Add("ex_shizhongguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shizhongguzhang", 98, 2, "时钟故障"));

            map.Add("ex_cunchuqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_cunchuqiguzhang", 100, 2, "存储器故障"));

            map.Add("ex_waibuliansuobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_waibuliansuobaojing", 102, 2, "外部连锁报警"));

            map.Add("ex_queyoubaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_queyoubaojing", 104, 2, "缺油报警"));

            map.Add("ex_diyouweibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_diyouweibaojing", 106, 2, "低油位报警"));

            map.Add("ex_bentipaiyanwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_bentipaiyanwendugaobaojing", 108, 2, "本体排烟温度高报警"));

            map.Add("ex_bianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_bianpinqiguzhangbaojing", 110, 2, "变频器故障报警"));

            map.Add("ex_meishuiwendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_meishuiwendugaobaojing", 112, 2, "媒水温度高报警"));

            map.Add("ex_1haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_1haoguoluguzhang", 114, 2, "1号锅炉故障"));

            map.Add("ex_2haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_2haoguoluguzhang", 116, 2, "2号锅炉故障"));

            map.Add("ex_3haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_3haoguoluguzhang", 118, 2, "3号锅炉故障"));

            map.Add("ex_4haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_4haoguoluguzhang", 120, 2, "4号锅炉故障"));

            map.Add("ex_5haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_5haoguoluguzhang", 122, 2, "5号锅炉故障"));

            map.Add("ex_6haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_6haoguoluguzhang", 124, 2, "6号锅炉故障"));

            map.Add("ex_7haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_7haoguoluguzhang", 126, 2, "7号锅炉故障"));

            map.Add("ex_8haoguoluguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_8haoguoluguzhang", 128, 2, "8号锅炉故障"));

            map.Add("ex_bushuibianpinqiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_bushuibianpinqiguzhangbaojing", 130, 2, "补水变频器故障报警"));

            map.Add("ex_diliuliangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_diliuliangbaojing", 132, 2, "低流量报警"));

            map.Add("ex_rukouwendudibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_rukouwendudibaojing", 134, 2, "入口温度低报警"));

            map.Add("ex_xunhuanbengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_xunhuanbengbianpinqiguzhang", 136, 2, "循环泵变频器故障"));

            map.Add("ex_ecixunhuanbengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ecixunhuanbengbianpinqiguzhang", 138, 2, "二次循环泵变频器故障"));

            map.Add("ex_reshuibengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_reshuibengbianpinqiguzhang", 140, 2, "热水泵变频器故障"));

            map.Add("ex_buyoubengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_buyoubengbianpinqiguzhang", 142, 2, "补油泵变频器故障"));

            map.Add("ex_ecigufengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ecigufengbianpinqiguzhang", 144, 2, "二次鼓风变频器故障"));

            map.Add("ex_songliaojibianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_songliaojibianpinqiguzhang", 146, 2, "送料机变频器故障"));

            map.Add("ex_zhenkongbengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_zhenkongbengbianpinqiguzhang", 148, 2, "真空泵变频器故障"));

            map.Add("ex_lengningbengbianpinqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lengningbengbianpinqiguzhang", 150, 2, "冷凝泵变频器故障"));

            map.Add("ex_addshuibengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_addshuibengguzhang", 152, 2, "补水泵故障"));

            map.Add("ex_buyoubengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_buyoubengguzhang", 154, 2, "补油泵故障"));

            map.Add("ex_lengningbengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lengningbengguzhang", 156, 2, "冷凝泵故障"));

            map.Add("ex_reshuibengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_reshuibengguzhang", 158, 2, "热水泵故障"));

            map.Add("ex_zhenkongbengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_zhenkongbengguzhang", 160, 2, "真空泵故障"));

            map.Add("ex_ecixunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ecixunhuanbengguzhang", 162, 2, "二次循环泵故障"));

            map.Add("ex_huilu1xunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu1xunhuanbengguzhang", 164, 2, "回路1循环泵故障"));

            map.Add("ex_huilu2xunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu2xunhuanbengguzhang", 166, 2, "回路2循环泵故障"));

            map.Add("ex_huilu3xunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu3xunhuanbengguzhang", 168, 2, "回路3循环泵故障"));

            map.Add("ex_huilu4xunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu4xunhuanbengguzhang", 170, 2, "回路4循环泵故障"));

            map.Add("ex_huilu5xunhuanbengguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu5xunhuanbengguzhang", 172, 2, "回路5循环泵故障"));

            map.Add("ex_huilu1wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu1wendugaobaojing", 174, 2, "回路1温度高报警"));

            map.Add("ex_huilu2wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu2wendugaobaojing", 176, 2, "回路2温度高报警"));

            map.Add("ex_huilu3wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu3wendugaobaojing", 178, 2, "回路3温度高报警"));

            map.Add("ex_huilu4wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu4wendugaobaojing", 180, 2, "回路4温度高报警"));

            map.Add("ex_huilu5wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu5wendugaobaojing", 182, 2, "回路5温度高报警"));

            map.Add("ex_panguan1wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan1wendugaobaojing", 184, 2, "盘管1温度高报警"));

            map.Add("ex_panguan2wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan2wendugaobaojing", 186, 2, "盘管2温度高报警"));

            map.Add("ex_panguan3wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan3wendugaobaojing", 188, 2, "盘管3温度高报警"));

            map.Add("ex_panguan4wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan4wendugaobaojing", 190, 2, "盘管4温度高报警"));

            map.Add("ex_panguan5wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan5wendugaobaojing", 192, 2, "盘管5温度高报警"));

            map.Add("ex_panguan6wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan6wendugaobaojing", 194, 2, "盘管6温度高报警"));

            map.Add("ex_panguan7wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan7wendugaobaojing", 196, 2, "盘管7温度高报警"));

            map.Add("ex_panguan8wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan8wendugaobaojing", 198, 2, "盘管8温度高报警"));

            map.Add("ex_panguan9wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan9wendugaobaojing", 200, 2, "盘管9温度高报警"));

            map.Add("ex_panguan10wendugaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan10wendugaobaojing", 202, 2, "盘管10温度高报警"));

            map.Add("ex_shanzhengguanchaoyabaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shanzhengguanchaoyabaojing", 204, 2, "闪蒸罐超压报警"));

            map.Add("ex_lengningguanchaoyabaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lengningguanchaoyabaojing", 206, 2, "冷凝罐超压报警"));

            map.Add("ex_pengzhangguanchaoyabaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_pengzhangguanchaoyabaojing", 208, 2, "膨胀罐超压报警"));

            map.Add("ex_shanzhengguanyeweigaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shanzhengguanyeweigaobaojing", 210, 2, "闪蒸罐液位高报警"));

            map.Add("ex_shanzhengguanyeweidibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shanzhengguanyeweidibaojing", 212, 2, "闪蒸罐液位低报警"));

            map.Add("ex_lengningguanyeweigaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lengningguanyeweigaobaojing", 214, 2, "冷凝罐液位高报警"));

            map.Add("ex_lengningguanyeweidibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lengningguanyeweidibaojing", 216, 2, "冷凝罐液位低报警"));

            map.Add("ex_pengzhangguanyeweigaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_pengzhangguanyeweigaobaojing", 218, 2, "膨胀罐液位高报警"));

            map.Add("ex_pengzhangguanyeweidibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_pengzhangguanyeweidibaojing", 220, 2, "膨胀罐液位低报警"));

            map.Add("ex_jinchukouyachadibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jinchukouyachadibaojing", 222, 2, "进出口压差低报警"));

            map.Add("ex_jinchukouyachagaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jinchukouyachagaobaojing", 224, 2, "进出口压差高报警"));

            map.Add("ex_zhenkongyalibuzubaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_zhenkongyalibuzubaojing", 226, 2, "真空压力不足报警"));

            map.Add("ex_jinchukouwenchadibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jinchukouwenchadibaojing", 228, 2, "进出口温差低报警"));

            map.Add("ex_jinchukouwenchagaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jinchukouwenchagaobaojing", 230, 2, "进出口温差高报警"));

            map.Add("ex_guoluhuohuiluchukouyaligaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_guoluhuohuiluchukouyaligaobaojing", 232, 2, "出口压力高报警（锅炉或回路）"));

            map.Add("ex_guoluhuohuiluchukouyalidibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_guoluhuohuiluchukouyalidibaojing", 239, 2, "出口压力低报警（锅炉或回路）"));

            map.Add("ex_guoluhuohuilurukouyaligaobaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_guoluhuohuilurukouyaligaobaojing", 241, 2, "入口压力高报警（锅炉或回路）"));

            map.Add("ex_guoluhuohuilurukouyalidibaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_guoluhuohuilurukouyalidibaojing", 243, 2, "入口压力低报警（锅炉或回路）"));

            map.Add("ex_dongzuofankuiyichangyinfengjiguzhangbaojing", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_dongzuofankuiyichangyinfengjiguzhangbaojing", 245, 2, "引风机故障报警（动作反馈异常）"));

            map.Add("ex_bentipaiyanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_bentipaiyanwenduchuanganqiguzhang", 252, 2, "本体排烟温度传感器故障"));

            map.Add("ex_paiyanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_paiyanwenduchuanganqiguzhang", 254, 2, "排烟温度传感器故障"));

            map.Add("ex_lushuiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lushuiwenduchuanganqiguzhang", 256, 2, "炉水温度传感器故障"));

            map.Add("ex_chukouwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_chukouwenduchuanganqiguzhang", 258, 2, "出口温度传感器故障"));

            map.Add("ex_rukouwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_rukouwenduchuanganqiguzhang", 260, 2, "入口温度传感器故障"));

            map.Add("ex_jienengqichukouwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jienengqichukouwenduchuanganqiguzhang", 262, 2, "节能器出口温度传感器故障"));

            map.Add("ex_jienengqirukouwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jienengqirukouwenduchuanganqiguzhang", 264, 2, "节能器入口温度传感器故障"));

            map.Add("ex_jishuiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jishuiwenduchuanganqiguzhang", 266, 2, "给水温度传感器故障"));

            map.Add("ex_lutangwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lutangwenduchuanganqiguzhang", 268, 2, "炉膛温度传感器故障"));

            map.Add("ex_lutangchukouwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lutangchukouwenduchuanganqiguzhang", 270, 2, "炉膛出口温度传感器故障"));

            map.Add("ex_lubiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lubiwenduchuanganqiguzhang", 272, 2, "炉壁温度传感器故障"));

            map.Add("ex_ranliaowenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ranliaowenduchuanganqiguzhang", 274, 2, "燃料温度传感器故障"));

            map.Add("ex_refengwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_refengwenduchuanganqiguzhang", 276, 2, "热风温度传感器故障"));

            map.Add("ex_fuyazhengqiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_fuyazhengqiwenduchuanganqiguzhang", 278, 2, "负压蒸汽温度传感器故障"));

            map.Add("ex_guorezhengqiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_guorezhengqiwenduchuanganqiguzhang", 280, 2, "过热蒸汽温度传感器故障"));

            map.Add("ex_huilu1wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu1wenduchuanganqiguzhang", 282, 2, "回路1温度传感器故障"));

            map.Add("ex_huilu2wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu2wenduchuanganqiguzhang", 284, 2, "回路2温度传感器故障"));

            map.Add("ex_huilu3wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu3wenduchuanganqiguzhang", 286, 2, "回路3温度传感器故障"));

            map.Add("ex_huilu4wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu4wenduchuanganqiguzhang", 288, 2, "回路4温度传感器故障"));

            map.Add("ex_huilu5wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_huilu5wenduchuanganqiguzhang", 290, 2, "回路5温度传感器故障"));

            map.Add("ex_shiwaiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shiwaiwenduchuanganqiguzhang", 292, 2, "室外温度传感器故障"));

            map.Add("ex_zhengqiyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_zhengqiyalichuanganqiguzhang", 294, 2, "蒸汽压力变送器故障"));

            map.Add("ex_jishuiyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jishuiyalichuanganqiguzhang", 296, 2, "给水压力传感器故障"));

            map.Add("ex_chukouyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_chukouyalichuanganqiguzhang", 298, 2, "出口压力传感器故障"));

            map.Add("ex_rukouyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_rukouyalichuanganqiguzhang", 300, 2, "入口压力传感器故障"));

            map.Add("ex_lutangyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lutangyalichuanganqiguzhang", 302, 2, "炉膛压力传感器故障"));

            map.Add("ex_lutangchukouyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lutangchukouyalichuanganqiguzhang", 304, 2, "炉膛出口压力传感器故障"));

            map.Add("ex_ranqiyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ranqiyalichuanganqiguzhang", 306, 2, "燃气压力传感器故障"));

            map.Add("ex_yicifengyachuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_yicifengyachuanganqiguzhang", 308, 2, "一次风压传感器故障"));

            map.Add("ex_ecifengyachuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ecifengyachuanganqiguzhang", 310, 2, "二次风压传感器故障"));

            map.Add("ex_ranliaoliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_ranliaoliangchuanganqiguzhang", 312, 2, "燃料量传感器故障"));

            map.Add("ex_zhengqiliuliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_zhengqiliuliangchuanganqiguzhang", 314, 2, "蒸汽流量传感器故障"));

            map.Add("ex_jishuiliuliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jishuiliuliangchuanganqiguzhang", 316, 2, "给水流量传感器故障"));

            map.Add("ex_xunhuanliuliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_xunhuanliuliangchuanganqiguzhang", 318, 2, "循环流量传感器故障"));

            map.Add("ex_bushuiliuliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_bushuiliuliangchuanganqiguzhang", 320, 2, "补水流量传感器故障"));

            map.Add("ex_guoluyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_guoluyeweichuanganqiguzhang", 322, 2, "锅炉液位传感器故障"));

            map.Add("ex_shuixiangyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shuixiangyeweichuanganqiguzhang", 324, 2, "水箱液位传感器故障"));

            map.Add("ex_paiyanyanghanliangchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_paiyanyanghanliangchuanganqiguzhang", 326, 2, "排烟氧含量传感器故障"));

            map.Add("ex_lupaisudufankuichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lupaisudufankuichuanganqiguzhang", 328, 2, "炉排速度反馈传感器故障"));

            map.Add("ex_yinfengshuchufankuichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_yinfengshuchufankuichuanganqiguzhang", 330, 2, "引风输出反馈传感器故障"));

            map.Add("ex_gufengshuchufankuichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_gufengshuchufankuichuanganqiguzhang", 332, 2, "鼓风输出反馈传感器故障"));

            map.Add("ex_jishuishuchufankuichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jishuishuchufankuichuanganqiguzhang", 334, 2, "给水输出反馈传感器故障"));

            map.Add("ex_meishuiwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_meishuiwenduchuanganqiguzhang", 336, 2, "媒水温度传感器故障"));

            map.Add("ex_shuixiangwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shuixiangwenduchuanganqiguzhang", 338, 2, "水箱温度传感器故障"));

            map.Add("ex_pengzhangguanyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_pengzhangguanyeweichuanganqiguzhang", 340, 2, "膨胀罐液位传感器故障"));

            map.Add("ex_shanzhengguanyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shanzhengguanyeweichuanganqiguzhang", 342, 2, "闪蒸罐液位传感器故障"));

            map.Add("ex_lengningyeguanyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lengningyeguanyeweichuanganqiguzhang", 344, 2, "冷凝液罐液位传感器故障"));

            map.Add("ex_chuguanyeweichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_chuguanyeweichuanganqiguzhang", 346, 2, "储罐液位传感器故障"));

            map.Add("ex_pengzhangguanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_pengzhangguanwenduchuanganqiguzhang", 348, 2, "膨胀罐温度传感器故障"));

            map.Add("ex_shanzhengguanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_shanzhengguanwenduchuanganqiguzhang", 350, 2, "闪蒸罐温度传感器故障"));

            map.Add("ex_lengningyeguanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_lengningyeguanwenduchuanganqiguzhang", 350, 2, "冷凝液罐温度传感器故障"));

            map.Add("ex_chuguanwenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_chuguanwenduchuanganqiguzhang", 354, 2, "储罐温度传感器故障"));

            map.Add("ex_guoluyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_guoluyalichuanganqiguzhang", 356, 2, "锅炉压力传感器故障"));

            map.Add("ex_guorezhengqiyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_guorezhengqiyalichuanganqiguzhang", 358, 2, "过热蒸汽压力传感器故障"));

            map.Add("ex_paiyanchuyalichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_paiyanchuyalichuanganqiguzhang", 360, 2, "排烟处压力传感器故障"));

            map.Add("ex_fengshifengyachuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_fengshifengyachuanganqiguzhang", 362, 2, "风室风压传感器故障"));

            map.Add("ex_yinfengjidianliuchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_yinfengjidianliuchuanganqiguzhang", 364, 2, "引风机电流传感器故障"));

            map.Add("ex_gufengjidianliuchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_gufengjidianliuchuanganqiguzhang", 366, 2, "鼓风机电流传感器故障"));

            map.Add("ex_jiliaojisudufankuichuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_jiliaojisudufankuichuanganqiguzhang", 368, 2, "给料机速度反馈传感器故障"));

            map.Add("ex_panguan1wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan1wenduchuanganqiguzhang", 370, 2, "盘管1温度传感器故障"));

            map.Add("ex_panguan2wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan2wenduchuanganqiguzhang", 372, 2, "盘管2温度传感器故障"));

            map.Add("ex_panguan3wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan3wenduchuanganqiguzhang", 374, 2, "盘管3温度传感器故障"));

            map.Add("ex_panguan4wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan4wenduchuanganqiguzhang", 376, 2, "盘管4温度传感器故障"));

            map.Add("ex_panguan5wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan5wenduchuanganqiguzhang", 378, 2, "盘管5温度传感器故障"));

            map.Add("ex_panguan6wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan6wenduchuanganqiguzhang", 380, 2, "盘管6温度传感器故障"));

            map.Add("ex_panguan7wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan7wenduchuanganqiguzhang", 382, 2, "盘管7温度传感器故障"));

            map.Add("ex_panguan8wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan8wenduchuanganqiguzhang", 384, 2, "盘管8温度传感器故障"));

            map.Add("ex_panguan9wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan9wenduchuanganqiguzhang", 386, 2, "盘管9温度传感器故障"));

            map.Add("ex_panguan10wenduchuanganqiguzhang", ByteField.Init(new Meta.CTL_NJZJ_485.ExceptionField(), "ex_panguan10wenduchuanganqiguzhang", 388, 2, "盘管10温度传感器故障"));

            map.Add("mo_bentipaiyanwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_bentipaiyanwendu", 395, 2, "本体排烟温度", "℃"));

            map.Add("mo_paiyanwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_paiyanwendu", 397, 2, "排烟温度", "℃"));

            map.Add("mo_lushuiwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_lushuiwendu", 399, 2, "炉水温度", "℃"));

            map.Add("mo_chukouwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_chukouwendu", 401, 2, "出口温度", "℃"));

            map.Add("mo_rukouwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_rukouwendu", 403, 2, "入口温度", "℃"));

            map.Add("mo_jienengqichukouwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_jienengqichukouwendu", 405, 2, "节能器出口温度", "℃"));

            map.Add("mo_jienengqirukouwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_jienengqirukouwendu", 407, 2, "节能器入口温度", "℃"));

            map.Add("mo_jishuiwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_jishuiwendu", 409, 2, "给水温度", "℃"));

            map.Add("mo_lutangwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_lutangwendu", 411, 2, "炉膛温度", "℃"));

            map.Add("mo_lutangchukouwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_lutangchukouwendu", 413, 2, "炉膛出口温度", "℃"));

            map.Add("mo_lubiwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_lubiwendu", 415, 2, "炉壁温度", "℃"));

            map.Add("mo_ranliaowendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_ranliaowendu", 417, 2, "燃料温度", "℃"));

            map.Add("mo_refengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_refengwendu", 419, 2, "热风温度", "℃"));

            map.Add("mo_fuyazhengqiwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_fuyazhengqiwendu", 421, 2, "负压蒸汽温度", "℃"));

            map.Add("mo_guorezhengqiwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_guorezhengqiwendu", 423, 2, "过热蒸汽温度", "℃"));

            map.Add("mo_huilu1wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_huilu1wendu", 425, 2, "回路1温度", "℃"));

            map.Add("mo_huilu2wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_huilu2wendu", 427, 2, "回路2温度", "℃"));

            map.Add("mo_huilu3wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_huilu3wendu", 429, 2, "回路3温度", "℃"));

            map.Add("mo_huilu4wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_huilu4wendu", 431, 2, "回路4温度", "℃"));

            map.Add("mo_huilu5wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_huilu5wendu", 433, 2, "回路5温度", "℃"));

            map.Add("mo_shiwaiwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_shiwaiwendu", 435, 2, "室外温度", "℃"));

            map.Add("mo_zhengqiyali", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_zhengqiyali", 437, 2, "蒸汽压力", "MPa", 100));

            map.Add("mo_jishuiyali", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_jishuiyali", 439, 2, "给水压力", "MPa", 100));

            map.Add("mo_chukouyali", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_chukouyali", 441, 2, "出口压力", "MPa", 100));

            map.Add("mo_rukouyali", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_rukouyali", 443, 2, "入口压力", "MPa", 100));

            map.Add("mo_lutangyali", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_lutangyali", 445, 2, "炉膛压力", "Pa"));

            map.Add("mo_lutangchukouyali", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_lutangchukouyali", 447, 2, "炉膛出口压力", "Pa"));

            map.Add("mo_ranqiyali", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_ranqiyali", 449, 2, "燃气压力", "KPa"));

            map.Add("mo_yicifengya", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_yicifengya", 451, 2, "一次风压", "KPa"));

            map.Add("mo_ecifengya", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_ecifengya", 453, 2, "二次风压", "KPa"));

            map.Add("mo_ranliaoliang", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_ranliaoliang", 455, 2, "燃料量"));

            map.Add("mo_zhengqiliuliang", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_zhengqiliuliang", 457, 2, "蒸汽流量"));

            map.Add("mo_jishuiliuliang", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_jishuiliuliang", 459, 2, "给水流量"));

            map.Add("mo_xunhuanliuliang", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_xunhuanliuliang", 461, 2, "循环流量"));

            map.Add("mo_bushuiliuliang", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_bushuiliuliang", 463, 2, "补水流量"));

            map.Add("mo_guoluyewei", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_guoluyewei", 465, 2, "锅炉液位", "mm"));

            map.Add("mo_shuixiangyewei", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_shuixiangyewei", 467, 2, "水箱液位", "mm"));

            map.Add("mo_paiyanyanghanliang", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_paiyanyanghanliang", 469, 2, "排烟氧含量", "%", 10));

            map.Add("mo_lupaisudufankui", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_lupaisudufankui", 471, 2, "炉排速度反馈", "%"));

            map.Add("mo_yinfengshuchufankui", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_yinfengshuchufankui", 473, 2, "引风输出反馈", "%"));

            map.Add("mo_gufengshuchufankui", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_gufengshuchufankui", 475, 2, "鼓风输出反馈", "%"));

            map.Add("mo_jishuishuchufankui", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_jishuishuchufankui", 477, 2, "给水输出反馈", "%"));

            map.Add("mo_meishuiwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_meishuiwendu", 479, 2, "媒水温度", "℃"));

            map.Add("mo_shuixiangwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_shuixiangwendu", 481, 2, "水箱温度", "℃"));

            map.Add("mo_pengzhangguanyewei", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_pengzhangguanyewei", 483, 2, "膨胀罐液位", "mm"));

            map.Add("mo_shanzhengguanyewei", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_shanzhengguanyewei", 485, 2, "闪蒸罐液位", "mm"));

            map.Add("mo_lengningyeguanyewei", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_lengningyeguanyewei", 487, 2, "冷凝液罐液位", "mm"));

            map.Add("mo_chuguanyewei", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_chuguanyewei", 489, 2, "储罐液位", "mm"));

            map.Add("mo_pengzhangguanwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_pengzhangguanwendu", 491, 2, "膨胀罐温度", "℃"));

            map.Add("mo_shanzhengguanwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_shanzhengguanwendu", 493, 2, "闪蒸罐温度", "℃"));

            map.Add("mo_lengningyeguanwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_lengningyeguanwendu", 495, 2, "冷凝液罐温度", "℃"));

            map.Add("mo_chuguanwendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_chuguanwendu", 497, 2, "储罐温度", "℃"));

            map.Add("mo_guoluyali", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_guoluyali", 499, 2, "锅炉压力", "MPa", 100));

            map.Add("mo_guorezhengqiyali", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_guorezhengqiyali", 501, 2, "过热蒸汽压力", "MPa", 100));

            map.Add("mo_paiyanchuyali", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_paiyanchuyali", 503, 2, "排烟处压力", "Pa"));

            map.Add("mo_fengshifengya", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_fengshifengya", 505, 2, "风室风压", "KPa"));

            map.Add("mo_yinfengjidianliu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_yinfengjidianliu", 507, 2, "引风机电流", "A"));

            map.Add("mo_gufengjidianliu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_gufengjidianliu", 509, 2, "鼓风机电流", "A"));

            map.Add("mo_jiliaojisudufankui", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_jiliaojisudufankui", 511, 2, "给料机速度反馈", "%"));

            map.Add("mo_panguan1wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_panguan1wendu", 513, 2, "盘管1温度", "℃"));

            map.Add("mo_panguan2wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_panguan2wendu", 515, 2, "盘管2温度", "℃"));

            map.Add("mo_panguan3wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_panguan3wendu", 517, 2, "盘管3温度", "℃"));

            map.Add("mo_panguan4wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_panguan4wendu", 519, 2, "盘管4温度", "℃"));

            map.Add("mo_panguan5wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_panguan5wendu", 521, 2, "盘管5温度", "℃"));

            map.Add("mo_panguan6wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_panguan6wendu", 523, 2, "盘管6温度", "℃"));

            map.Add("mo_panguan7wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_panguan7wendu", 525, 2, "盘管7温度", "℃"));

            map.Add("mo_panguan8wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_panguan8wendu", 527, 2, "盘管8温度", "℃"));

            map.Add("mo_panguan9wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_panguan9wendu", 529, 2, "盘管9温度", "℃"));

            map.Add("mo_panguan10wendu", ByteField.Init(new Meta.CTL_NJZJ_485.MockField(), "mo_panguan10wendu", 531, 2, "盘管10温度", "℃"));

            map.Add("se_paiyanwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_paiyanwendu", 538, 2, "排烟温度", "℃"));

            map.Add("se_baojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_baojingwendu", 540, 2, "报警温度", "℃"));

            map.Add("se_tingluwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_tingluwendu", 542, 2, "停炉温度", "℃"));

            map.Add("se_mubiaowendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_mubiaowendu", 544, 2, "目标温度", "℃"));

            map.Add("se_qiluwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_qiluwendu", 546, 2, "启炉温度", "℃"));

            map.Add("se_zhuanhuohuichawendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_zhuanhuohuichawendu", 548, 2, "转火回差温度", "℃"));

            map.Add("se_qiluhuichawendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_qiluhuichawendu", 550, 2, "启炉回差温度", "℃"));

            map.Add("se_kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_kaibengwendu", 552, 2, "开泵温度", "℃"));

            map.Add("se_guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_guanbengwendu", 554, 2, "关泵温度", "℃"));

            map.Add("se_baojingyali", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_baojingyali", 556, 2, "报警压力", "MPa", 100));

            map.Add("se_tingluyali", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_tingluyali", 558, 2, "停炉压力", "MPa", 100));

            map.Add("se_mubiaoyali", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_mubiaoyali", 560, 2, "目标压力", "MPa", 100));

            map.Add("se_qiluyali", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_qiluyali", 562, 2, "启炉压力", "MPa", 100));

            map.Add("se_zhuanhuohuichayali", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_zhuanhuohuichayali", 564, 2, "转火回差压力", "MPa", 100));

            map.Add("se_qiluhuichayali", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_qiluhuichayali", 566, 2, "启炉回差压力", "MPa", 100));

            map.Add("se_qianyanshi", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_qianyanshi", 568, 2, "前延时", "S"));

            map.Add("se_houyanshimiao", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_houyanshimiao", 570, 2, "后延时秒", "S"));

            map.Add("se_qianchuisao", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_qianchuisao", 572, 2, "前吹扫", "S"));

            map.Add("se_houchuisao", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_houchuisao", 574, 2, "后吹扫", "S"));

            map.Add("se_lubibaojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_lubibaojingwendu", 576, 2, "炉壁报警温度", "℃"));

            map.Add("se_lutangchukoubaojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_lutangchukoubaojingwendu", 578, 2, "炉膛出口报警温度", "℃"));

            map.Add("se_baohuwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_baohuwendu", 580, 2, "保护温度", "℃"));

            map.Add("se_bentipaiyanwendubaojingzhi", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_bentipaiyanwendubaojingzhi", 582, 2, "本体排烟温度报警值", "℃"));

            map.Add("se_jiarezushu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_jiarezushu", 584, 2, "加热组数"));

            map.Add("se_jianceyalishijian", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_jianceyalishijian", 586, 2, "检测压力时间"));

            map.Add("se_houyanshifen", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_houyanshifen", 588, 2, "后延时分", "m"));

            map.Add("se_shedingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_shedingwendu", 560, 2, "设定温度", "℃"));

            map.Add("se_mokuailutaishu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_mokuailutaishu", 592, 2, "模块炉台数"));

            map.Add("se_gufenghouyanshi", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_gufenghouyanshi", 594, 2, "鼓风后延时", "S"));

            map.Add("se_yinfenghouyanshi", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_yinfenghouyanshi", 596, 2, "引风后延时", "S"));

            map.Add("se_shuixiangkaibengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_shuixiangkaibengwendu", 598, 2, "水箱开泵温度", "℃"));

            map.Add("se_shuixiangguanbengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_shuixiangguanbengwendu", 600, 2, "水箱关泵温度", "℃"));

            map.Add("se_lushuibaojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_lushuibaojingwendu", 602, 2, "炉水报警温度", "℃"));

            map.Add("se_buchangxishu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_buchangxishu", 604, 2, "补偿系数"));

            map.Add("se_cankaowendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_cankaowendu", 606, 2, "参考温度", "℃"));

            map.Add("se_tingluzuidazhi", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_tingluzuidazhi", 608, 2, "停炉最大值", "℃"));

            map.Add("se_qiluzuixiaozhi", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_qiluzuixiaozhi", 610, 2, "启炉最小值", "℃"));

            map.Add("se_cankaohuicha", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_cankaohuicha", 612, 2, "参考回差", "℃"));

            map.Add("se_tingluwendu1", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_tingluwendu1", 614, 2, "停炉温度1", "℃"));

            map.Add("se_qiluwendu1", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_qiluwendu1", 616, 2, "启炉温度1", "℃"));

            map.Add("se_tingluwendu2", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_tingluwendu2", 618, 2, "停炉温度2", "℃"));

            map.Add("se_qiluwendu2", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_qiluwendu2", 620, 2, "启炉温度2", "℃"));

            map.Add("se_yusongliaoshijian", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_yusongliaoshijian", 622, 2, "预送料时间", "S"));

            map.Add("se_dianhuoshijian", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_dianhuoshijian", 624, 2, "点火时间", "S"));

            map.Add("se_songliaoqidongshijian", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_songliaoqidongshijian", 626, 2, "送料启动时间", "S"));

            map.Add("se_songliaotingzhishijian", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_songliaotingzhishijian", 628, 2, "送料停止时间", "S"));

            map.Add("se_dianhuojiange", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_dianhuojiange", 630, 2, "点火间隔", "m"));

            map.Add("se_dianhuochenggongwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_dianhuochenggongwendu", 632, 2, "点火成功温度", "℃"));

            map.Add("se_lushuitingluwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_lushuitingluwendu", 634, 2, "炉水停炉温度", "℃"));

            map.Add("se_lushuiqiluwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_lushuiqiluwendu", 636, 2, "炉水启炉温度", "℃"));

            map.Add("se_meishuibaojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_meishuibaojingwendu", 638, 2, "媒水报警温度", "℃"));

            map.Add("se_meishuitingluwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_meishuitingluwendu", 640, 2, "媒水停炉温度", "℃"));

            map.Add("se_meishuiqiluwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_meishuiqiluwendu", 642, 2, "媒水启炉温度", "℃"));

            map.Add("se_kaibengyali", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_kaibengyali", 644, 2, "开泵压力", "MPa", 100));

            map.Add("se_guanbengyali", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_guanbengyali", 646, 2, "关泵压力", "MPa", 100));

            map.Add("se_panguanbaojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_panguanbaojingwendu", 648, 2, "盘管报警温度", "℃"));

            map.Add("se_huilu1baojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu1baojingwendu", 650, 2, "回路1报警温度", "℃"));

            map.Add("se_huilu1kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu1kaibengwendu", 652, 2, "回路1开泵温度", "℃"));

            map.Add("se_huilu1guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu1guanbengwendu", 654, 2, "回路1关泵温度", "℃"));

            map.Add("se_huilu2baojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu2baojingwendu", 656, 2, "回路2报警温度", "℃"));

            map.Add("se_huilu2kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu2kaibengwendu", 658, 2, "回路2开泵温度", "℃"));

            map.Add("se_huilu2guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu2guanbengwendu", 660, 2, "回路2关泵温度", "℃"));

            map.Add("se_huilu3baojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu3baojingwendu", 662, 2, "回路3报警温度", "℃"));

            map.Add("se_huilu3kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu3kaibengwendu", 664, 2, "回路3开泵温度", "℃"));

            map.Add("se_huilu3guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu3guanbengwendu", 666, 2, "回路3关泵温度", "℃"));

            map.Add("se_huilu4baojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu4baojingwendu", 668, 2, "回路4报警温度", "℃"));

            map.Add("se_huilu4kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu4kaibengwendu", 670, 2, "回路4开泵温度", "℃"));

            map.Add("se_huilu4guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu4guanbengwendu", 672, 2, "回路4关泵温度", "℃"));

            map.Add("se_huilu5baojingwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu5baojingwendu", 674, 2, "回路5报警温度", "℃"));

            map.Add("se_huilu5kaibengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu5kaibengwendu", 676, 2, "回路5开泵温度", "℃"));

            map.Add("se_huilu5guanbengwendu", ByteField.Init(new Meta.CTL_NJZJ_485.SettingField(), "se_huilu5guanbengwendu", 678, 2, "回路5关泵温度", "℃"));

            map.Add("st_qidongshijian1", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_qidongshijian1", 685, 2, "启动时间1"));

            map.Add("st_tingzhishijian1", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_tingzhishijian1", 687, 2, "停止时间1"));

            map.Add("st_qidongshijian2", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_qidongshijian2", 689, 2, "启动时间2"));

            map.Add("st_tingzhishijian2", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_tingzhishijian2", 691, 2, "停止时间2"));

            map.Add("st_qidongshijian3", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_qidongshijian3", 693, 2, "启动时间3"));

            map.Add("st_tingzhishijian3", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_tingzhishijian3", 695, 2, "停止时间3"));

            map.Add("st_qidongshijian4", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_qidongshijian4", 697, 2, "启动时间4"));

            map.Add("st_tingzhishijian4", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_tingzhishijian4", 699, 2, "停止时间4"));

            map.Add("st_qidongshijian5", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_qidongshijian5", 701, 2, "启动时间5"));

            map.Add("st_tingzhishijian5", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_tingzhishijian5", 703, 2, "停止时间5"));

            map.Add("st_qidongshijian6", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_qidongshijian6", 705, 2, "启动时间6"));

            map.Add("st_tingzhishijian6", ByteField.Init(new Meta.CTL_NJZJ_485.StartStopField(), "st_tingzhishijian6", 707, 2, "停止时间6"));

            map.Add("de_ranshaoqi", ByteField.Init(new Meta.CTL_NJZJ_485.RanShaoQiField(), "de_ranshaoqi", 714, 2, "燃烧器", CTL_NJZJ_Common_ValueMaps.coms_ranshaoqi_status));

            map.Add("de_jiarezu", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_jiarezu", 716, 2, "加热组", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_bushui_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_bushui_beng", 718, 2, "补水泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_jishui_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_jishui_beng", 720, 2, "给水泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_buyou_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_buyou_beng", 722, 2, "补油泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_xunhuan_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_xunhuan_beng", 724, 2, "循环泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_lengning_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_lengning_beng", 726, 2, "冷凝泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_reshui_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_reshui_beng", 728, 2, "热水泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_zhenkong_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_zhenkong_beng", 730, 2, "真空泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_ecixunhuan_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_ecixunhuan_beng", 732, 2, "二次循环泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_yinfengji_fan", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_yinfengji_fan", 734, 2, "引风机", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_gufengji_fan", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_gufengji_fan", 736, 2, "鼓风机", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_lupai", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_lupai", 738, 2, "炉排", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_chuzhaji", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_chuzhaji", 740, 2, "出渣机", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_ecigufengji_fan", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_ecigufengji_fan", 742, 2, "二次鼓风机", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_dianhuoqi", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_dianhuoqi", 744, 2, "点火器", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_shangmeiji", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_shangmeiji", 746, 2, "上煤机", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_songliaoji", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_songliaoji", 748, 2, "送料机", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_jiayao_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_jiayao_beng", 750, 2, "加药泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_paiwufa", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_paiwufa", 752, 2, "排污阀", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_huilu1xunhuan_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_huilu1xunhuan_beng", 754, 2, "回路1循环泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_huilu2xunhuan_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_huilu2xunhuan_beng", 756, 2, "回路2循环泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_huilu3xunhuan_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_huilu3xunhuan_beng", 758, 2, "回路3循环泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_huilu4xunhuan_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_huilu4xunhuan_beng", 760, 2, "回路4循环泵", CTL_NJZJ_Common_ValueMaps.coms_device));

            map.Add("de_huilu5xunhuan_beng", ByteField.Init(new Meta.CTL_NJZJ_485.DeviceField(), "de_huilu5xunhuan_beng", 762, 2, "回路5循环泵", CTL_NJZJ_Common_ValueMaps.coms_device));

        }
    }
}