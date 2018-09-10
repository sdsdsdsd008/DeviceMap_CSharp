namespace SdcSoft.Devices.Meta
{
    internal abstract class OpenCloseField : ByteField
    {
        protected int value;

        public override dynamic getValue()
        {
            return value;
        }

        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.setKey(SdcSoftDevice.KEY_OPENCLOSE); ;
        }
    }
}
