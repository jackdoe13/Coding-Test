using System;
using System.Linq;  // 1. LINQ의 Select 메서드를 사용하기 위해 추가

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        // 2. var 변수에 문자열 s Select 메서드를 이용해 각 문자가 대문자면 소문자, 아니면 대문자로 변경 후 대입
        var Change_aA = s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));
        
        // 3. Var 변수를 ToArray() 함수를 통헤 문자열로 변환 하여 s에 다시 대입
        s = new string(Change_aA.ToArray());
        
        Console.Write(s);
        
        

    }
}