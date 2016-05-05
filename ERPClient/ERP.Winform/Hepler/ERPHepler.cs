using COM.Domain;
using COM.Service;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Winform
{
   public class ERPCacheHepler
    {
       private static ERPCacheHepler instance;
       private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
       private ISupplierService supplierService = Unity.Instance.GetService<ISupplierService>();
       private ICustomerService customerService = Unity.Instance.GetService<ICustomerService>();
       public static ERPCacheHepler Instance
        {
            get
            {
                return instance ?? (instance = new ERPCacheHepler());
            }
        }

       public List<InputItem> GetSupplierData()
       {
           var supplierData = appCacheService.GetItem("Supplier") as List<InputItem>;
           if (supplierData == null || supplierData.Count == 0)
           {
               var supplierList = supplierService.GetSupplierData();
               appCacheService.AddItem("Supplier", supplierList);
               return supplierList;
           }
           else
           {
               return supplierData;
           }
       }
       public List<InputItem> GetCustomerData()
       {
           var customerData = appCacheService.GetItem("Customer") as List<InputItem>;
           if (customerData == null || customerData.Count == 0)
           {
               var customerList = customerService.GetCustomerInputData();
               appCacheService.AddItem("Customer", customerList);
               return customerList;
           }
           else
           {
               return customerData;
           }
       }
    }
}
