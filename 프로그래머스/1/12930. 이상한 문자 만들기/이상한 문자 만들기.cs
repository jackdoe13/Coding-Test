using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int a = 0;
        
        foreach (char c in s)
        {
        //if (c == ' ')시도했으나 문제의 공백은 ' '이든 '   '이든 하나로 보기 때문에 제출 후 채점에서 틀린              것 같다.
            if (c == ' ')
            {
                answer += ' ';
                a = -1;
            }
            else if((a%2) == 0)
            {
                answer += char.ToUpper(c);
            }
            else
            {
                answer += char.ToLower(c);
            }
            
            a++;
        }
        
        return answer;
    }
}