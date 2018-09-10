namespace SdcSoft.Devices.Meta.PLC
{
    internal class BaseInfoField : Meta.BaseInfoField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = (bytes[1] << 8) | bytes[0];

            return value != 0x7FFF;
        }

        public override string getValueString()
        {
            if (null != valueMap)
                return valueMap[value];
            return base.getValueString();
        }
    }
}
