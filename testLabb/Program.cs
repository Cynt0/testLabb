using System;
using System.Numerics;

namespace testLabb
{
    class Program
    {
        static void Main(string[] args)
        {
            string print = "29535123p48723487597645723645";
            BigInteger Summan= 0; //Håller i värdet vid loop
            for (int i = 0; i < print.Length -1; i++)
            {
                char names = print[i];
                int index = print.IndexOf(names, i + 1); //Kollar index i sträng
                int length = index - i + 1;
             
                if (index != -1) //Kontrollerar så att index inte är -1. Vid -1 så dyker programmet !VIKIGT!
                {
                    string result = print.Substring(i, length);  //Håller i värdet vid beräkning -> Blir sedan Summan
                    IsDigitsOnly(result); //Kontrollerar så att det ENDAST är sifforor inom index 
                    
                    if (!IsDigitsOnly(result)) //Fall det är en bokstav i indexen, så skippas den loopen.
                    {
                        continue;
                    }

                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(result);
                        Console.ResetColor();
                        Console.Write(print.Substring(index + 1));
                        Console.WriteLine();
                        Summan += BigInteger.Parse(result); 
                    }
                    else if(index == print.Length -1)
                    {
                        Console.Write(print.Substring(0, i));
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(result);
                        Console.ResetColor();
                        Summan += BigInteger.Parse(result);
                        Console.WriteLine();

                    }
                    else if (i > 0 && index > 0 && index < print.Length -1)
                    {
                        Console.Write(print.Substring(0, i));
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(result);
                        Console.ResetColor();
                        Console.Write(print.Substring(index + 1));
                        Console.WriteLine();
                        Summan += BigInteger.Parse(result);
                    }
                    





                }
            }
            Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("Summan är: {0}", Summan);
            Console.ResetColor();


        }

        

        private static bool IsDigitsOnly(string result)
        {
            foreach (char c in result)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
