using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Stack<string> stc = new Stack<string>();
            foreach (var i in str)
            {
                string str_i = Convert.ToString(i);
                switch (str_i)
                {
                    case "(":
                        stc.Push(str_i);
                        break;
                    case "{":
                        stc.Push(str_i);
                        break;
                    case "[":
                        stc.Push(str_i);
                        break;
                    case ")":
                        if (stc.Peek() == "(")
                            stc.Pop();
                        else
                            continue;
                        break;
                    case "}":
                        if (stc.Peek() == "{")
                            stc.Pop();
                        else
                            continue;
                        break;
                    case "]":
                        if (stc.Peek() == "[")
                            stc.Pop();
                        else
                            continue;
                        break;
                }
            }
            //Console.WriteLine($"{stc.Count()}") ;
            if (stc.Count()==0)
                Console.WriteLine("Cкобки расставлены корректно");
            else
                Console.WriteLine("Cкобки расставлены не корректно");
            Console.ReadKey();
        }
    }
}
