using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        while(true)
        {
            if((n < 7) && (n !=0))
            {
                answer++;
                break;
            }
            else if (n >= 7)
            {
                n -= 7;
                answer++;
            }
            else
            {
                   break;
            }
              
        }
        
        if (answer == 0)
        {
            answer++;
        }
        
        return answer;
    }
}