namespace SdcSoft.Devices.Meta.PLC
{
    /// <summary>
    ///  对于PLC通信而言，燃料与介质是固定的。因此燃料与介质的Map点位byteLength为0
    ///  此时将startIndex作为燃料或介质的固定数值来使用
    /// </summary>
    internal class PowerField : Meta.PowerField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = startIndex;
            return true;
        }

        public override string getValueString()
        {
            if (null != valueMap)
                return valueMap[value];
            return base.getValueString();
        }
    }
}
