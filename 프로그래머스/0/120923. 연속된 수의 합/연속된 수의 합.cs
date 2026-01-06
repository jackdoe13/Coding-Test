using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        
        int sum = 0, n = 0;
        n = (total - num);      // 내가 원하는 것은 {total-num,total-num+1,...total-1}
        
      
        
    
        for (int i = 0; i < num; i++)
        {
            answer[i] = n;              // answer = {....total-2,total-1}
            n++;
        }
        
        while(true)
        {
            for(int j = 0; j < answer.Length; j++)
            {
                sum += answer[j];           // 배열의 총 합을 구하고
            }
            
            if (sum > total)                // 배열의 총합을 total과 비교해서 sum이 더 크면 -10;
            {
                for(int k = 0; k < answer.Length; k++)
                {
                    answer[k] = answer[k] - 10;
                }
                
                sum = 0;        // 각 배열 요소의 합을 다시 구하기 위한 초기화
                continue;       // 재진행
                
            } else if (sum < total)
            {
               for(int k = 0; k < answer.Length; k++)
                {
                    answer[k] = answer[k] + 1;
                }
                
                sum = 0;
                continue;
                
                
            } else if (sum == total)        // 배열의 총합이 total과 같으면 break;
            {
                 break;
            }
            
        }
        
        return answer;
    }
}


/* total = 12;
   num = 3;
   answer = [3,4,5]
   이라는 것은 결국 num은 answer 배열의 길이가 되고 total은 각 요소의 합이 된다.
   */