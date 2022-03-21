using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography; 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            op = Convert.ToInt16(Console.ReadLine());
            do
            {
                Console.WriteLine("1.1024 bit");
                Console.WriteLine("2.2048 bit");
                Console.WriteLine("3.3072 bit");
                Console.WriteLine("4.4096 bit");
                Console.WriteLine("5.Iesire");
                Console.WriteLine("Alegeti Optiunea: ");
                op = Convert.ToInt16(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
            while (op != 5);
        }
        public static double[] time_generation(int size, byte[] plain)
        {
            double[] results = new double[5];
             RSACryptoServiceProvider myrsa = new RSACryptoServiceProvider(1600);
           System.Diagnostics.Stopwatch swatch = new  System.Diagnostics.Stopwatch();
             int size1;
             int count = 100;
            swatch.Start();
          for (int i = 0; i < count; i++)
        {
        myrsa = new RSACryptoServiceProvider(2048);
         size = myrsa.KeySize;
       }
        swatch.Stop();
Console.WriteLine("Generation time at 1024 bit ... " + 
(swatch.ElapsedTicks / (10*count)).ToString() + " ms");
byte[] plain = new byte[20];
byte[] ciphertext = myrsa.Encrypt(plain, true);
swatch.Reset();
swatch.Start()
        }
    }
}
