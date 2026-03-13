using System;
using System.Collections.Generic;

//1
string[] strings = new string[3];
try
{
    strings[5] = "1234";
}
catch
{
    Console.WriteLine("에러가 발생했습니다.");
}

//2
{
    try
    {
        strings[5] = "1234";
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

//3
{
    try
    {
        int a = int.Parse("3.14");
    }
    catch (FormatException e)
    {
        Console.WriteLine($"에러 발생: {e.Message}");
        Console.WriteLine("3.14는 정수여야 합니다.");
    }
}

//4
{
    try
    {
        int zero = 0;
        int a = 10 / zero;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("0으로 나눌 수 없습니다.");
    }
}

//5
{
    int errorCode = 404;

    try
    {
        throw new Exception("페이지를 찾을 수 없습니다.");
    }
    catch (Exception ex) when (errorCode == 404)
    {
        Console.WriteLine($"404 오류: {ex.Message}");
    }
    catch (Exception ex) when (errorCode == 500)
    {
        Console.WriteLine($"500 오류: {ex.Message}");
    }
}

//6
{
    try
    {
        int zero = 0;
        int a = 10 / zero;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("0으로 나눌 수 없습니다.");
    }
    finally
    {
        Console.WriteLine("프로그램을 종료합니다.");
    }
}

//7
{
    try
    {
        int zero = 1;
        int a = 10 / zero;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("0으로 나눌 수 없습니다.");
    }
    finally
    {
        Console.WriteLine("프로그램을 종료합니다.");
    }
}

////8
//FileManager fm = new FileManager("log.txt");
//fm.Write();
//fm.Dispose();
//class FileManager : IDisposable
//{
//    private string _filename;
//    public FileManager(string fileName)
//    {
//        _filename = fileName;
//        Console.WriteLine($"{_filename} 파일 열기");
//    }
//    public void Write()
//    {
//        Console.WriteLine($"{_filename}에 'Hello' 작성");
//    }
//    public void Dispose()
//    {
//        Console.WriteLine($"{_filename} 파일 닫기");
//    }
//}


////9

//Console.WriteLine("=== using 문 테스트 ===");

//using (GameResource game = new GameResource("던전"))
//{
//    game.Play();
//}

//Console.WriteLine("=== 종료 ===");

//class GameResource : IDisposable
//{
//    private string _name;

//    public GameResource(string name)
//    {
//        _name = name;
//        Console.WriteLine($"[{_name}] 리소스 로드");
//    }

//    public void Play()
//    {
//        Console.WriteLine($"[{_name}] 게임 진행 중...");
//    }

//    public void Dispose()
//    {
//        Console.WriteLine($"[{_name}] 리소스 해제");
//    }
//}


////10
//using(Resource resource = new Resource())
//{
//    resource.Work();
//}


//class Resource : IDisposable
//{
//    private bool _disposed = false;

//    public void Work()
//    {
//        Console.WriteLine("작업 수행");
//    }

//    public void Dispose()
//    {
//        if (!_disposed)
//        {
//            Console.WriteLine("리소스 정리됨");
//            _disposed = true;
//        }
//    }
//}

////11
//try
//{
//    Divide(10, 2);
//    Divide(10, 0);
//}
//catch(DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//void Divide(int a, int b)
//{
//    if( b == 0)
//    {
//        throw new DivideByZeroException("오류: 0으로 나눌 수 없습니다.");
//    }
//    Console.WriteLine($"{a} / {b} = {a / b}");
//}

//12

void SetAge(int age)
{
    if( age < 0)
    {
        throw new ArgumentException("인수 오류: 나이는 0 이상이어야 합니다.", nameof(age));
    }
    if( age > 900)
    {
        throw new ArgumentOutOfRangeException("dd");
    }
}