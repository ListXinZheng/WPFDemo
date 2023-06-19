using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WPFAPP.DataAcess;

namespace WPFAPP.Common
{
    public  class GlobalValues
    {
        public static UserDataEntity Userinfo { get; set; } = new UserDataEntity ();
    }
}
