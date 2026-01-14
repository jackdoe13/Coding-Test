using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";
        
        for(int i = 0; i < s; i++)
        {
            answer += my_string[i];                 // s까지만 추가하고
        }
        
        
        for(int i = e-s; i >= 0; i--)
        {
            answer += my_string[(s+i)];                 // e까지 뒤집어서 추가하고
            
        }
        
        for(int i = 1; i < (my_string.Length-e) ; i++)
        {
            answer += my_string[e+i];                 // 남은 문자열 추가하고
        }
        
        return answer;
    }
}