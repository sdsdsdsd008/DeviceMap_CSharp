namespace SdcSoft.Devices.Meta
{
    internal abstract class PowerField : ByteField
    {
        protected int value;


        public override dynamic getValue()
        {
            return value;
        }



        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.setKey(SdcSoftDevice.KEY_BASE);
        }


        public override string getValueString()
        {
            if (null != valueMap)
                return valueMap[value];
            return base.getValueString();
        }
    }
}
