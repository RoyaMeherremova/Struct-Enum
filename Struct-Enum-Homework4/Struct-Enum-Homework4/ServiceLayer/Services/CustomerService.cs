using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerService : ICustomerService
    {
        public int GetCustomerAge(Customer[]arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (item.Age>25 && item.Age<30)
                {
                    count++;
                }

            }
            return count;
        }

        public double GetCustomerMiddleAge(Customer[]arr)
        {
            int sum = 0;
            int count = 0;
            double result = 0;
            foreach (var item in arr)
            {
                sum+= item.Age;
               
                count++;
                result = sum / count;
            } 
            return result;
        }



    }
}
