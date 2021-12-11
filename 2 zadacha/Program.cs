using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] slovo = s.Split(new[] { " " }, StringSplitOptions.None);
            
                string[] slovo = s.Split(new[] { " " }, StringSplitOptions.None);
                string sl = "";
                int drs = 0;
                foreach (string ds in slovo)
                {
                    if (ds.Length > drs)
                    {
                        sl = ds;
                        drs = ds.Length;
                    }
                }
                Console.WriteLine(sl);
                Console.ReadKey();
            }
        }
    }
