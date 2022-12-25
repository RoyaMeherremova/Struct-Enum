


using ServiceLayer.Services;

CalculateService calculateService=new CalculateService();

int[] arr = { 1, 5, 8, 15, 33, 66, 45 };
Console.WriteLine(calculateService.GetNumberMultiplication(arr));

int[] arr2 = { 1, 2, 5, 6, 8, 9, 10 };
Console.WriteLine(calculateService.GetEvenNumberSumAndSquare(arr2));
