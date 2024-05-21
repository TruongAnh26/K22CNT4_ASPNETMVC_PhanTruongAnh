using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_model.Models
{
    internal interface IcustomerRepository
    {
        IList<PtaCustomer> GetPtaCustomers();
        PtaCustomer GetPtaCustomer(string PtaCustomerId);
        void UpdatePtaCustomer(PtaCustomer ptaCus);
        void AddPtaCustomer(PtaCustomer ptaCus);
        IList<PtaCustomer> SearchCustomer(string name);
        void DeletePtaCustomer(PtaCustomer ptaCus);
    }
}
