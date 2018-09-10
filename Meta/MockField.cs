namespace SdcSoft.Devices.Meta
{
    internal abstract class MockField : ByteField
    {
        protected float value;

        public override dynamic getValue()
        {
            return value;
        }

        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.setKey(SdcSoftDevice.KEY_MOCK);
        }
    }
}
