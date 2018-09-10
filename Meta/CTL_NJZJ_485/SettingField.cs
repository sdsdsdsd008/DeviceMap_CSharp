namespace SdcSoft.Devices.Meta.CTL_NJZJ_485
{
    internal class SettingField : MockField
    {
        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.setKey(SdcSoftDevice.KEY_SETTING);
        }
    }
}
