using System.Text;

namespace SdcSoft.Devices.Meta
{
    internal abstract class BaseInfoField : ByteField
    {
        protected int value;
        protected StringBuilder sb = new StringBuilder();
        public override dynamic getValue()
        {
            return value;
        }
        
        public override void setDeviceFieldForUIKey(DeviceFieldForUI fieldForUI)
        {
            fieldForUI.setKey(SdcSoftDevice.KEY_BASE);
        }
    }
}
