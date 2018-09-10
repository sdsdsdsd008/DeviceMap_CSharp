using System;
using SdcSoft.Devices.Meta;

namespace SdcSoft.Devices
{
    class Device_CTL_NJZJ_IPK2_485 : Device_CTL_NJZJ_IPK2
    {
        public Device_CTL_NJZJ_IPK2_485()
        {
            BYTE_ARRAY_LENGTH = 765;
        }
        
        internal override string handleDeviceNo(byte[] bytes)
        {
            return "";
        }

        internal override void handleByteField(ByteField field, byte[] bytes)
        {

            if (field.haveValue(bytes[field.getStartIndex()+1], bytes[field.getStartIndex()]))
            {
                this.AddField(field.getDeviceFieldForUI());
            }
        }

        public override int getMode()
        {
            return -1;
        }
    }
}
