using System;
using System.Collections.Generic;
using System.Text;

namespace _20Task20
{
    internal class Admin : User
    {
        public bool isSuperAdmin;
        public bool Section;

        
        public Admin(string username, string password, bool isSuperAdmin = true, bool Section = true) : base(username, password)
        {
            isSuperAdmin = isSuperAdmin;
            Section = Section;
        }

        
         
     
    }

}
