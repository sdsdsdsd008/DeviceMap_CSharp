namespace SdcSoft.Devices.Meta.CTL_NJZJ_485
{
    internal class RanShaoQiField : DeviceField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0] | (bytes[1] << 8);

            if (0x7FFF != value)
            {
                value = bytes[0] & 0xFF;
                return true;
            }
            return false;
        }
        public override string getValueString()
        {
            if (null != valueMap)
                return valueMap[value];

            return base.getValueString();
        }
    }
}
