namespace SdcSoft.Devices.Meta.CTL_NJZJ
{
    internal class BaseInfoField : Meta.BaseInfoField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0];
            return 0xFF != value;
        }
        public override string getValueString()
        {
            if (null != valueMap)
                return valueMap[value];
            return base.getValueString();
        }
    }
}
