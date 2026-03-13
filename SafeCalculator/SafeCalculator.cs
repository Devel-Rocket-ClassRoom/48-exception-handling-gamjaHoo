using System;
using System.Collections.Generic;
using System.Text;

namespace SafeCalculator
{
    internal class SafeCalculator
    {
        public void Divide(string num1, string num2)
        {
            int a, b;
            try
            {
                a = int.Parse(num1);
                b = int.Parse(num2);
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("올바른 숫자를 입력하세요.");
                return;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("0으로 나눌 수 없습니다.");
            }
            finally
            {
                Console.WriteLine("계산기를 종료합니다.");
            }
        }
    }
}
