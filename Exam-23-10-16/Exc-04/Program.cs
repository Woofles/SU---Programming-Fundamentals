using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Dictionary<int, string> dicID = new Dictionary<int, string>();
            Dictionary<string, string> dicName = new Dictionary<string, string>();
            //
            while (input.ToLower() != "time for code")
            {
                var comand = input.Split().ToArray();
                int ID = int.Parse(comand[0]);
                string EVENT = comand[1];
                string[] NAMES = comand.Skip(2).ToArray();
                if (dicID.Keys.Contains(ID))
                {
                    if (dicID[ID] == EVENT && EVENT[0]=='#')
                    {
                        for (int i = 0; i < NAMES.Length; i++)
                        {
                            dicName.Add(NAMES[i], EVENT);
                        }
                    }
                }
                else
                {
                    if (EVENT[0] == '#')
                    {
                        dicID.Add(ID, EVENT);
                    }
                    for (int i = 0; i< NAMES.Length; i++)
                    {
                        dicName.Add(NAMES[i], EVENT);
                    }
                }
                input = Console.ReadLine();
            }
            //

            Dictionary<string, int> dicCount = new Dictionary<string, int>();
            foreach (var item in dicID)
            {
                dicCount.Add(item.Value, 0);
            }
            foreach (var item in dicName)
            {
                dicCount[item.Value]++;
            }
            ////
            IDictionary<int, string> dicSorted = new Dictionary<int, string>();
            foreach (var item in dicCount)
            {
                dicSorted.Add(item.Value, item.Key);
            }
            for (int i = 0; i<= dicSorted.Keys.Count+1; i++)
            {
                int M = dicSorted.Keys.Max();
                Console.WriteLine(string.Join("",dicSorted[M].Skip(1).ToArray()) + " - " + M);
                foreach (var item in dicName)
                {
                    if (item.Value == dicSorted[M]) { Console.WriteLine(item.Key); }
                }
                dicSorted.Remove(M);
            }
            foreach (var item in dicSorted)
            {
                Console.WriteLine(item.Value + " - " + item.Key);
            }
        }
    }
}
