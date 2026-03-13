using System;

namespace FilePathValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            FilePathValidator validator = new FilePathValidator();

            Console.WriteLine("=== 경로 검증 테스트 ===");

            string longPath = new string('a', 261);

            string[] paths =
            {
                "C:/Users/data/report.txt",
                null,
                "C:/Users/data/<file>.txt",
                longPath
            };

            foreach (var p in paths)
            {
                try
                {
                    validator.ValidatePath(p);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine($"[ArgumentNull 오류] {ex.Message}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"[ArgumentOutOfRange 오류] {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"[Argument 오류] {ex.Message}");
                }
            }

            Console.WriteLine("\n=== 확장자 검증 테스트 ===");

            string[] allowed = { ".txt", ".csv" };

            string[] testFiles =
            {
                "report.txt",
                "data.csv",
                "virus.exe"
            };

            foreach (var file in testFiles)
            {
                try
                {
                    validator.ValidateExtension(file, allowed);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"[Argument 오류] {ex.Message}");
                }
            }
        }
    }
}