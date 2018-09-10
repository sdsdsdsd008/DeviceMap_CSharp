namespace SdcSoft.Devices.Meta.CTL_NJZJ_485
{
    internal class BaseInfoField : Meta.BaseInfoField
    {
        public override bool haveValue(params byte[] bytes)
        {
            if (getBytesLength() < 1)
                return false;

            value = bytes[0] | (bytes[1]  << 8);
            return 0x7FFF != value;
        }
        public override string getValueString()
        {
            if (null != valueMap)
                return valueMap[value];
            return base.getValueString();
        }
    }
}
