using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COM.Domain;
namespace ERP.Domain
{
    public class Class1
    {
        public void Test()
        {
            tb_Sys_User user = new tb_Sys_User();
            tb_Sys_User user2 = new tb_Sys_User(Guid.NewGuid());
            
        }
    }
}
