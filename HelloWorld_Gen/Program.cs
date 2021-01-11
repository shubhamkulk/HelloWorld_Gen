using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Gen
{
    class Program
    {
        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        static void Main(string[] args)
        {
            start:
            try
            {
                Console.WriteLine("Enter an Inefficient String");
                string helloWorld = Console.ReadLine();
                //"Hello World!";

                char[] chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^& ".ToCharArray();
                string generated = string.Empty;
                string generatedTrial = string.Empty;
                while (generated != helloWorld)
                {
                    Random r = new Random();

                    var singleChar = chars[r.Next(chars.Length)];
                    if (string.IsNullOrEmpty(generated))
                    {
                        if(singleChar == helloWorld[0])
                            generated+=singleChar;
                    }
                    else if (!string.IsNullOrEmpty(generated))
                    {
                        generatedTrial = generated;

                        if (singleChar == helloWorld[generated.Length])
                        {
                            generated += singleChar;
                        }
                        else
                        {
                            Console.Write(generatedTrial + singleChar);
                            System.Threading.Thread.Sleep(200);
                            ClearLastLine();
                        }

                    }
                    if (!string.IsNullOrEmpty(generated))
                    {
                        Console.WriteLine(generated);
                    }
                    generatedTrial = generated;
                }                
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Enter a String Only");
                goto start;

            }
        }
    }
}
