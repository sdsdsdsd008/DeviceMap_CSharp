using System.Collections.Generic;
using SdcSoft.Devices.Entity;
using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices
{
    /// <summary>
    /// 获取IPK2关注信息
    /// </summary>
    internal partial class Device_CTL_NJZJ_IPK2 : Device_CTL
    {
        
        public override List<DeviceFieldForUI> getDeviceFocusFields()
        {
            Dictionary<string, DeviceFieldForUI> map = this.getBaseInfoFields();
            var list = new MyArrayList<DeviceFieldForUI>();
            list.Add(GetUiItem(getBaseInfoFields(),SdcSoftDevice.KEY_POINT_RUN_DAYS));
            list.Add(GetUiItem(getBaseInfoFields(),SdcSoftDevice.KEY_POINT_RUN_HOURS));
            if (map[SdcSoftDevice.KEY_POINT_POWER].getValue().Equals(Power.Dian))
            {
                if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ReShui))
                {
                    list.Add(GetUiItem(getDeviceFields(),"de_jiarezu"));
                    list.Add(GetUiItem(getMockFields(),"mo_chukouwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_rukouwendu"));
                    list.Add(GetUiItem(getBaseInfoFields(),"ba_shuixiangshuiweizhuangtai"));
                    list.Add(GetUiItem(getBaseInfoFields(),"ba_guolushuiweizhuangtai"));
                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.DaoReYou))
                {

                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ReFeng))
                {

                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ZhengQi))
                {
                    list.Add(GetUiItem(getDeviceFields(),"de_jiarezu"));
                    list.Add(GetUiItem(getBaseInfoFields(),"ba_guolushuiweizhuangtai"));
                    if (this.getBaseInfoFields().ContainsKey("ba_guoluyalizhuangtai"))
                    {
                        list.Add(GetUiItem(getBaseInfoFields(),"ba_guoluyalizhuangtai"));
                    }
                    else
                    {
                        list.Add(GetUiItem(getMockFields(),"mo_zhengqiyali"));
                    }
                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ZhenKong))
                {

                }
            }
            else if (map[SdcSoftDevice.KEY_POINT_POWER].getValue().Equals(Power.Mei))
            {
                if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ReShui))
                {
                    list.Add(GetUiItem(getMockFields(),"mo_paiyanwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_chukouwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_rukouwendu"));
                    if (this.getBaseInfoFields().ContainsKey("ba_guoluyalizhuangtai"))
                    {
                        list.Add(GetUiItem(getBaseInfoFields(),"ba_guoluyalizhuangtai"));
                    }
                    else
                    {
                        list.Add(GetUiItem(getMockFields(),"mo_zhengqiyali"));
                    }

                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.DaoReYou))
                {
                    list.Add(GetUiItem(getMockFields(),"mo_paiyanwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_chukouwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_rukouwendu"));
                    if (this.getBaseInfoFields().ContainsKey("ba_guoluyalizhuangtai"))
                    {
                        list.Add(GetUiItem(getBaseInfoFields(),"ba_guoluyalizhuangtai"));
                    }
                    else
                    {
                        list.Add(GetUiItem(getMockFields(),"mo_zhengqiyali"));
                    }
                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ReFeng))
                {

                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ZhengQi))
                {
                    if (this.getBaseInfoFields().ContainsKey("ba_guoluyalizhuangtai"))
                    {
                        list.Add(GetUiItem(getBaseInfoFields(),"ba_guoluyalizhuangtai"));
                    }
                    else
                    {
                        list.Add(GetUiItem(getMockFields(),"mo_zhengqiyali"));
                    }
                    list.Add(GetUiItem(getMockFields(),"mo_paiyanwendu"));
                    list.Add(GetUiItem(getBaseInfoFields(),"ba_guolushuiweizhuangtai"));

                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ZhenKong))
                {

                }
            }
            else if (map[SdcSoftDevice.KEY_POINT_POWER].getValue().Equals(Power.ShengWuZhi))
            {
                if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ReShui))
                {

                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.DaoReYou))
                {

                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ReFeng))
                {

                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ZhengQi))
                {

                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ZhenKong))
                {

                }
            }
            else if (map[SdcSoftDevice.KEY_POINT_POWER].getValue().Equals(Power.YouQi))
            {
                if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ReShui))
                {
                    list.Add(GetUiItem(getMockFields(),"mo_paiyanwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_chukouwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_rukouwendu"));
                    list.Add(GetUiItem(getBaseInfoFields(),"ba_guolushuiweizhuangtai"));
                    list.Add(GetUiItem(getBaseInfoFields(),"ba_shuixiangshuiweizhuangtai"));
                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.DaoReYou))
                {
                    list.Add(GetUiItem(getMockFields(),"mo_paiyanwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_chukouwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_rukouwendu"));
                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ReFeng))
                {
                    list.Add(GetUiItem(getMockFields(),"mo_chukouwendu"));
                    list.Add(GetUiItem(getDeviceFields(),"de_ranshaoqi"));
                    list.Add(GetUiItem(getDeviceFields(),"de_yinfengji_fan"));
                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ZhengQi))
                {
                    list.Add(GetUiItem(getBaseInfoFields(),"ba_guolushuiweizhuangtai"));
                    list.Add(GetUiItem(getMockFields(),"mo_paiyanwendu"));

                    if (this.getBaseInfoFields().ContainsKey("ba_guoluyalizhuangtai"))
                    {
                        list.Add(GetUiItem(getBaseInfoFields(),"ba_guoluyalizhuangtai"));
                    }
                    else
                    {
                        list.Add(GetUiItem(getMockFields(),"mo_zhengqiyali"));
                    }

                }
                else if (map[SdcSoftDevice.KEY_POINT_MEDIA].getValue().Equals(Media.ZhenKong))
                {
                    list.Add(GetUiItem(getMockFields(),"mo_paiyanwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_chukouwendu"));
                    list.Add(GetUiItem(getMockFields(),"mo_meishuiwendu"));
                    list.Add(GetUiItem(getBaseInfoFields(),"ba_guolushuiweizhuangtai"));
                    if (this.getBaseInfoFields().ContainsKey("ba_guoluyalizhuangtai"))
                    {
                        list.Add(GetUiItem(getBaseInfoFields(),"ba_guoluyalizhuangtai"));
                    }
                    else
                    {
                        list.Add(GetUiItem(getMockFields(),"mo_zhengqiyali"));
                    }

                }
            }
            return list;
        }
    }
    /// <summary>
    /// IPK2基本信息处理
    /// </summary>
    internal partial class Device_CTL_NJZJ_IPK2 : Device_CTL
    {
        internal override void handleByteField(ByteField field, byte[] bytes)
        {
            switch (field.getBytesLength())
            {
                case 0:
                    if (field.haveValue(bytes[field.getStartIndex()], bytes[field.getStartIndex() + 1]))
                    {
                        AddField(field.getDeviceFieldForUI());
                    }
                    break;
                case 2:
                    if (field.haveValue(bytes[field.getStartIndex()], bytes[field.getStartIndex() + 1]))
                    {
                        this.AddField(field.getDeviceFieldForUI());
                    }
                    break;
                default:
                    if (field.haveValue(bytes[field.getStartIndex()], bytes[field.getStartIndex() + 1]))
                    {
                        this.AddField(field.getDeviceFieldForUI());
                    }
                    break;
            }
        }

        internal override string handleDeviceNo(byte[] bytes)
        {
            string deviceNo = System.Text.Encoding.ASCII.GetString(bytes, 10, 10);
            setDeviceNo(deviceNo);
            return deviceNo;

        }
        public override int getMode()
        {
            return getBaseInfoFields()["ba_moshibianhao"].getValue();
        }
    }
    /// <summary>
    /// 获取燃料信息、水泵、风机
    /// </summary>
    internal partial class Device_CTL_NJZJ_IPK2 : Device_CTL
    {
        internal const string Device_Suffix_Beng = "_beng";
        internal const string Device_Suffix_Fan = "_fan";

        internal const string KEY_POINT_RAN_SHAO_QI = "de_ranshaoqi";
        internal const string KEY_POINT_JIA_RE_ZU = "se_jiarezushu";
        internal const string KEY_POINT_YIN_FENG_JI = "de_yinfengji_fan";


        internal override DeviceFieldForUI getPowerInfo()
        {
            var power = getBaseInfoFields()[KEY_POINT_POWER];

            var devices = getDeviceFields();

            if (power.getValue() == Power.Dian)
            {
                return getSettingFields()[KEY_POINT_JIA_RE_ZU];
            }
            else if (power.getValue() == Power.Mei)
            {
                return devices[KEY_POINT_YIN_FENG_JI];
            }
            return devices[KEY_POINT_RAN_SHAO_QI];
        }

        public override List<Element> getBeng()
        {
            return getElements(Device_Suffix_Beng, Element.Prefix_Beng, Element.Index_Beng_Count);
        }

        public override List<Element> getFan()
        {
            return getElements(Device_Suffix_Fan, Element.Prefix_Fan, Element.Index_Fan_Count);
        }

        private List<Element> getElements(string deviceSuffix, string elementPrefix, int valueIndex)
        {
            List<Element> list = new List<Element>();
            var devices = getDeviceFields();
            foreach (var device in devices.Values)
            {
                if (device.getName().Contains(deviceSuffix))
                {
                    Element element = new Element
                    {
                        Title = device.getTitle(),
                        Prefix = elementPrefix
                    };

                    var value = device.getValue() & 0x80;

                    if (0x80 == value)
                    {
                        element.SetValues(valueIndex, 1, 1);
                    }
                    else
                    {
                        element.SetValues(valueIndex, 1, 0);
                    }

                    list.Add(element);
                }
            }
            return list;
        }

    }
}
