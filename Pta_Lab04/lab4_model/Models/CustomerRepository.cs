using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_model.Models
{
    internal interface CustomerRepository : IcustomerRepository
    {
        static readonly List<PtaCustomer> data = new List<PtaCustomer>()
        {
            new PtaCustomer() {PtaCustomId = "001",
                PtaFullName = "Phan Trường Anh",
                Address = "Thái Bình",
                Email = "anhnganh04@gmail.com"},
                new PtaCustomer() {PtaCustomId = "002",
                PtaFullName = "Phan Trường ",
                Address = "Thái Ha",
                Email = "anhnganh04@gmail.com"},
                new PtaCustomer() {PtaCustomId = "003",
                PtaFullName = "Phan  Anh",
                Address = "Bình Duong",
                Email = "anhnganh04@gmail.com"},
        };
    }
}
