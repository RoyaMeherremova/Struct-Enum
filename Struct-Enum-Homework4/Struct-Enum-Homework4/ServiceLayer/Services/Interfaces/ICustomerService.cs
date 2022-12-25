using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICustomerService
    {
        double  GetCustomerMiddleAge(Customer[] arr);
        int GetCustomerAge(Customer[] arr);
    }
}
