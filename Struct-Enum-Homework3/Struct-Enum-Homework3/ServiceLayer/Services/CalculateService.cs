using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculateService
    {
        public int GetEvenNumberSumAndSquare(int[] arr)
        {
            int result = 0;
            int sum = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            result = (int)Math.Pow(sum, 2);
            return result;
        }

        public int GetNumberMultiplication(int[] arr)
        {
            int multiple = 1;
            foreach (var item in arr)
            {
                if (item > 1 && item < 20)
                {
                    multiple *= item;
                }
            }
            return multiple;
        }
    }
}
