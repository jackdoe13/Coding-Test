using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        float f = 0;
        
        f = ((float)(num1) / (float)(num2)) * 1000;
        
        answer = (int)f;
        
        return answer;
    }
}