using System;

namespace kredit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı daxil edin");
            Console.ReadLine();
            Console.WriteLine("Şifreni daxil edin");
            Console.ReadLine();
            Console.WriteLine("\t\t\t\t\t\t -------------------------");
            Console.WriteLine("\t\t\t\t\t\t\tKredit Menu");

            Console.Write("Emelliyat novunu secin" +
                $"\n" + "1.Kredit Goturmek \n" + "2.Kredit Odemek \n" + "3.Hesabat\n");
        tryagain:
            Console.Write("\n\n");
            int num1, num2, res;
            int Choose;
            Choose = Convert.ToInt32(Console.ReadLine());
         
            if (Choose == 1)
            {
                Console.WriteLine("Kredit Goturmek");
            }
            else if (Choose == 2)
            {
                Console.WriteLine("Kredit Odemek");
            }
            else if (Choose == 3)
            {
                Console.WriteLine("Hesabat");
            }
            else
            {
                Console.WriteLine("Invalid");
                goto tryagain;
            }
           
                    
           int mebleg = 0, ay = 0, faiz = 0, umumi = 0,odenis=0;

            Console.WriteLine("Ay daxil edin;");
            Console.ReadLine();
            if (ay < 12)
            {
                Console.WriteLine("12%");
            }
            else if (ay > 12)
            {
                Console.WriteLine("18%");
            }

            Console.WriteLine("Mebleg daxil edin;");
            Console.ReadLine();


            Console.WriteLine("Odenliecek meblegi yazin");
            Console.ReadLine();
            Console.WriteLine("Qalan borcunuz");
            mebleg=--odenis;
            --ay;










        }
    }
}