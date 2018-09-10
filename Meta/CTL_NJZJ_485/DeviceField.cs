using System.Text;

namespace SdcSoft.Devices.Meta.CTL_NJZJ_485
{
    internal class DeviceField : Meta.DeviceField
    {
        protected StringBuilder sb = new StringBuilder();

        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0]  | (bytes[1] << 8);

            if (0x7FFF == value)
                return false;

            sb.Remove(0, sb.Length);
            if (null != valueMap)
            {
                int v = (bytes[1] & 0xFF) | 0x3F;
                if (0xC0 == (v & 0xC0))
                {
                    sb.Append(valueMap[0xC0]);
                    sb.Append('/');
                }
                else
                {
                    sb.Append(valueMap[0x3F]);
                    sb.Append('/');
                }
                v = (bytes[1] & 0xFF) | 0xCF;
                if (0x30 == (v & 0x30))
                {
                    sb.Append(valueMap[0x30]);
                    sb.Append('/');
                }
                else
                {
                    sb.Append(valueMap[0xCF]);
                    sb.Append('/');
                }
                v = (bytes[1] & 0xFF) | 0xF0;
                if (0x0F == (v & 0x0F))
                {
                    sb.Append(valueMap[0x0F]);
                }
                else
                {
                    sb.Append(valueMap[0xF0]);
                }
            }

            value = bytes[0] & 0xFF;
            return true;
        }
    }
}
