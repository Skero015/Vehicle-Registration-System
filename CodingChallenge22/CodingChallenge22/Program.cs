using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letterList = new List<string>();
            string letter = "";
            string mostRecur = "";
            int iterate = 0;
            int recursion = 0;
            int recurses = 0;

            Console.WriteLine("Enter 5 letters:");

            for (int i = 0; i < 5; i++)
            {
                letter = Console.ReadLine();
                letterList.Add(letter);
            }

            int[] recurCounterrr = new int[letterList.Count];

            for (int i = 0; i < letterList.Count; i++)
            {
                iterate = i + 1;
                
                while(iterate < letterList.Count)
                {
                    if (letterList[i] == letterList[iterate])
                    {
                        recurses++;
                        if (recurses > 0)
                        {
                            mostRecur = letterList[i];
                        }
                    }
                    recursion = 1;
                    iterate++;
                }
                recurCounterrr[i] = recurses;
                
                recurses = 0;
            }
            iterate = 0;

            //check if first value recurs more than second value
            for (int i = 0; i < recurCounterrr.Length; i++)
            {
                iterate = i + 1;
                while (iterate < recurCounterrr.Length)
                {
                    if (recurCounterrr[i] > recurCounterrr[iterate])
                    {
                        mostRecur = letterList[i];
                        recursion++;
                    }
                    else if (recurCounterrr[i] == recurCounterrr[iterate] && recursion > 1)
                    {
                        mostRecur = "None";
                    }
                    iterate++;
                }
            }
            if (recursion == letterList.Count || recursion == 1 || letterList.Count == 0)
            {
                mostRecur = "None";
            }
            Console.WriteLine($"\"{mostRecur}\"");
            Console.ReadLine();
        }
    }
}
