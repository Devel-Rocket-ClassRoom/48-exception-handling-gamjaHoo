using System;

namespace SafeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            SafeCalculator sc = new SafeCalculator();
            Console.WriteLine("=== 테스트 1: 정상 입력 ===");
            sc.Divide("10", "2");

            Console.WriteLine("\n=== 테스트 2: 0으로 나누기 ===");
            sc.Divide("10", "0");

            Console.WriteLine("\n=== 테스트 3: 잘못된 형식 ===");
            sc.Divide("10", "ssss0");
        }
    }
}