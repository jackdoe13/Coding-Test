using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int a = 0;
        
        foreach (char c in s)
        {
            if (c == ' ')
            {
                answer += ' ';
                a = 0;
                
            } else if (a == 0)
            {
                answer += char.ToUpper(c);
                a++;
            }
            else
            {
                answer += char.ToLower(c);
            }
        }
        
        return answer;
    }
}