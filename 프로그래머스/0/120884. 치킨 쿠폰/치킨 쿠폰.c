#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int chicken) {
    int answer = 0;
    int coupon = 0;
    
    coupon = chicken;
    
    while (true)
    {
        if(coupon < 10)
            break;
        
        coupon -= 10;
        answer++;
        coupon++;
        
       
       
    }
    
    
    return answer;
}