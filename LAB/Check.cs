using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB
{
    public class CheckIFormattable
    {
        public bool Check(object obj)
        {
            if (obj is IFormattable)
            {
                IFormattable iformattableobj = obj as IFormattable;
                if (iformattableobj != null)
                {
                    return true;
                }
            }
            return false;
        }
        

    }
}
