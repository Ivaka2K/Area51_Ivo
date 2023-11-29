using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area51
{
    public static class FloorExtensions
    {
        public static SecurityLevel GetRequiredSecurityLevel(this Floor floor)
        {
            switch (floor)
            {
                case Floor.G:
                    return SecurityLevel.Confidential;
                case Floor.S:
                    return SecurityLevel.Secret;
                case Floor.T1:
                case Floor.T2:
                    return SecurityLevel.TopSecret;
                default:
                    throw new ArgumentOutOfRangeException(nameof(floor), floor, null);
            }
        }
    }
}
