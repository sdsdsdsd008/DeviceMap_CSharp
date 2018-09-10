namespace SdcSoft.Devices.Meta
{
    internal abstract class  ExceptionField : ByteField
    {
        protected int value;

        public override dynamic getValue() { return value; }

        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.setKey(SdcSoftDevice.KEY_EXCEPTION);
        }
    }
}
