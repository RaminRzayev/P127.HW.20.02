using System;
using System.Collections.Generic;
using System.Text;

namespace P127.HW._20._02
{
    class Admin:User
    {
        public bool IsSuperAdmin;





        public Admin(bool issuperadmin=true, string username="Admin", string password="12345"):base(username, password)
        {
            IsSuperAdmin = issuperadmin;
            
        }


        public void GetInfoAdmin()
        {
            Console.WriteLine($"Username: ");
        }

    }
}
