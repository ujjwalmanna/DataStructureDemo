using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStrucrureDemo
{
    class ShortNum
    {
        public void ShortNumbers(List<int> num)
        {
            var tournamnetArray=PrepareTournamentArrayTree(num);
            var minNum = num.Min()-1;
            for(int i = 1; i <= num.Count; i++)
            {
                Console.WriteLine($"{tournamnetArray[1]}");
                GetNext(tournamnetArray,num.Count,minNum);
            }
            
            
        }

       
        public int[] GetNext(int[] tournamentArray,int recordCount,int minValue)
        {
            int i = 2;            
            while (i <= 2 * recordCount - 1)
            {
                if (tournamentArray[i] > tournamentArray[i + 1])
                {
                    tournamentArray[i] = minValue;
                    i = 2 * i;
                }
                else
                {
                    tournamentArray[i+1] = minValue;
                    i = 2 * (i+1);
                }

                
            }
            for (i = i / 2; i > 1; i = i / 2)
            {
                if (i % 2 == 0)
                    tournamentArray[i / 2] = GetMaxNumber(tournamentArray[i], tournamentArray[i + 1]);
                else                    
                    tournamentArray[i / 2] = GetMaxNumber(tournamentArray[i], tournamentArray[i - 1]);

            }
            return tournamentArray;
        }

        public int[] PrepareTournamentArrayTree(List<int> num)
        {
            var recordCount = num.Count;
          
            var length = num.Count-1;
            int [] tournamentArray = new int[2*recordCount];

            int counter = 0;
            for (int i = recordCount; i <= (2 * recordCount - 1); i++)
            {
                
                tournamentArray[i] = num[counter++];
            }

           // num.ForEach(n => tournamentArray[length++] = n);

            for(int i = 2*recordCount-2; i>1; i=i-2)
            {
                var maxnum = GetMaxNumber(tournamentArray[i], tournamentArray[i+1]);
                tournamentArray[i/2] = maxnum;
            }

            return tournamentArray;
        }

        public int GetMinNumberInArray(List<int> num)
        {
            var min = num.Min();
            return min;
        }






        

        public int GetMaxNumber(int num1,int num2)
        {
            if (num1 > num2)
                return num1;
            else
                return num2;
        }
        public int GetMinNumber(int num1, int num2)
        {
            if (num1 < num2)
                return num1;
            else
                return num2;
        }
    }
}
