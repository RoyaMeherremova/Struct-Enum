using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICalculateService
    {
        int GetNumberMultiplication(int[] arr);
        int GetEvenNumberSumAndSquare(int[] arr);
    }
}
