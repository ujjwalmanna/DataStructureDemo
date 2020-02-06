using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStrucrureDemo
{
    class _2ndHighestNum
    {
        public void GetMaxAndNextMaxNum(List<int> num)
        {
            var tournamnetArray=PrepareTournamentArrayTree(num);
            tournamnetArray.All(s => { Console.WriteLine(s.ToString());return true; });
            var max = GetNextMax(tournamnetArray, num.Count);
            Console.WriteLine($"Highest:{tournamnetArray[1]}");
            Console.WriteLine($"2nd Highest:{max}");
        }

       
        public int GetNextMax(int[] tournamentArray,int recordCount)
        {
            int i = 2;

            var next = GetMinNumber(tournamentArray[2], tournamentArray[3]);
            while (i <= 2 * recordCount - 1)
            {
                if (tournamentArray[i] > tournamentArray[i + 1])
                {
                    next = GetMaxNumber(tournamentArray[i + 1], next);
                    i = 2 * i;
                }
                else
                {
                    next = GetMaxNumber(tournamentArray[i], next);
                    i = 2 * (i+1);
                }
            }
            return next;
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






        //public void PrepareTournamentTree(List<int> num,ref List<int>tournamentList)
        //{
        //    List<int> temp = new List<int>();
        //    //if (num.Count < 3) return;//1,7,45,51,98
        //    for (int i=num.Count-1;i>=0;)
        //    {
        //        if (i == 0 && num.Count>1)
        //        {
        //            temp.Add(num[i]);
        //            //tournamentList.Add(num[i]);
        //            break;
        //        }
        //        if (num.Count==1)
        //        {
        //            //temp.Add(num[i]);
        //            tournamentList.Add(num[i]);
        //            break;
        //        }
        //        tournamentList.Add(num[i]);
        //        tournamentList.Add(num[i-1]);
        //        temp.Add(GetMaxNumber(num[i],num[i-1]));
        //        i = i - 2;
        //    }
        //    if(temp.Count>0)
        //     PrepareTournamentTree(temp,ref tournamentList);
        //}

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
