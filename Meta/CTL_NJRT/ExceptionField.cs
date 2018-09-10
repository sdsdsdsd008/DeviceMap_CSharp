using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdcSoft.Devices.Meta.CTL_NJRT
{
    internal class ExceptionField : Meta.ExceptionField
    {
        public override bool haveValue(params byte[] bytes)
        {
            value = bytes[0] << 8 | bytes[1];
            int i = 1 << bit;
            if ((i & value) == i)
            {
                value = 1;
                return true;
            }
            else
            {
                value = 0;
                return false;
            }
        }
    }
}
