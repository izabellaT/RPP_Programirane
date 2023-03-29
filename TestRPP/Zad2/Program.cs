using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                if (cmd[0] == "stop")
                {
                    break;
                }
                switch (cmd[0])
                {
                    case "insert":
                        {
                            int index = int.Parse(cmd[1]);
                            string name = cmd[2];
                            names.Insert(index, name);
                            break;
                        }
                    case "find":
                        {
                            string symbol = cmd[1];
                            Console.WriteLine(string.Join(" ",names.Where(x => x.EndsWith(symbol))));
                            break;
                        }
                    case "del":
                        {
                            string name = cmd[1];
                                if (names.Contains(name))
                                {
                                names.RemoveAll(x => x == name);
                                }
                                else
                                {
                                    names.Add(name);
                                }
                            break;
                        }
                }
            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
