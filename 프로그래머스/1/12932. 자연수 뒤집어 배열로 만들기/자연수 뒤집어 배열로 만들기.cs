using System;

public class Solution
    {
        public int[] solution(long n)
        {
            string temp = n.ToString();
            int[] answer = new int[temp.Length];
            
            for (int i = 0; i < temp.Length; i++)
            {
                answer[i] = (int)Char.GetNumericValue(temp[temp.Length-1 - i]);
            }
            return answer;
        }
    }