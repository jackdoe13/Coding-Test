using System;

public class Solution {
    public int solution(int[] A, int[] B) {
        int answer = 0;
            
        // 배열 A에서 가장 낮은 값 X 배열 B에서 가장 높은 값
        // 곱한 후 제거한 다음 그 다음으로 낮은 값 X 높은 값
    
        //배열 A는 오름차순으로 배열 B는 내림차순으로 변경한 후 같은 인덱스끼리 곱하기스끼리 곱하기
    
        Array.Sort(A);
        Array.Sort(B);
        Array.Reverse(B);
        
        for (int i = 0; i < A.Length; i++)
        {
            answer += (A[i]*B[i]);
        }
        
        return answer;
    }
}