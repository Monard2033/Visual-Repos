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
            double[] results = new double[5];
            byte[] plain = Encoding.ASCII.GetBytes("Mihail");
            int op;
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
                        Console.Clear();
                        results = time_generation(1024, plain);
                        Console.WriteLine("Generation time at 1024 bit " + results[0].ToString() + "ms ");
                        Console.WriteLine("Encription time at 1024 bit " + results[1].ToString() + "ms ");
                        Console.WriteLine("Decription time at 1024 bit " + results[2].ToString() + "ms ");
                        Console.WriteLine("Sign time at 1024 bit " + results[3].ToString() + "ms ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        results = time_generation(2048, plain);
                        Console.WriteLine("Generation time at 2048 bit " + results[0].ToString() + "ms ");
                        Console.WriteLine("Encription time at 2048 bit " + results[1].ToString() + "ms ");
                        Console.WriteLine("Decription time at 2048 bit " + results[2].ToString() + "ms ");
                        Console.WriteLine("Sign time at 2048 bit " + results[3].ToString() + "ms ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        results = time_generation(3072, plain);
                        Console.WriteLine("Generation time at 3072 bit " + results[0].ToString() + "ms ");
                        Console.WriteLine("Encription time at 3072 bit " + results[1].ToString() + "ms ");
                        Console.WriteLine("Decription time at 3072 bit " + results[2].ToString() + "ms ");
                        Console.WriteLine("Sign time at 3072 bit " + results[3].ToString() + "ms ");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        results = time_generation(4096, plain);
                        Console.WriteLine("Generation time at 4096 bit " + results[0].ToString() + "ms ");
                        Console.WriteLine("Encription time at 4096 bit " + results[1].ToString() + "ms ");
                        Console.WriteLine("Decription time at 4096 bit " + results[2].ToString() + "ms ");
                        Console.WriteLine("Sign time at 4096 bit " + results[3].ToString() + "ms ");
                        Console.ReadKey();
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
            long ms;
            RSACryptoServiceProvider myrsa = new RSACryptoServiceProvider(1600);
            System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch();
            int size1;
            int count = 100;
            swatch.Start();
            for (int i = 0; i < count; i++)
            {
                myrsa = new RSACryptoServiceProvider(size);
                size1 = myrsa.KeySize;
            }
            swatch.Stop();
            ms = swatch.ElapsedMilliseconds;
            results[0] = (double)((double)ms / count);
            Console.WriteLine("Generation time at " + size +" bit " + (swatch.ElapsedTicks / (10 * count)).ToString() + " ms");
            return results;

         byte[] plain1 = new byte[20];
         byte[] ciphertext = myrsa.Encrypt(plain, true);
         swatch.Reset();
         swatch.Start();
         for (int i = 0; i < count; i++)
         {
             ciphertext = myrsa.Encrypt(plain, true);
         }
         swatch.Stop();
         ms = swatch.ElapsedMilliseconds;
         results[1] = (double)((double)ms / count);
         Console.WriteLine("Encryption time at " + size +" bit "+(swatch.ElapsedTicks / (10 * count)).ToString() + " ms");
         return results;

         swatch.Reset();
         swatch.Start();
         for (int i = 0; i < count; i++)
         {
             plain = myrsa.Decrypt(ciphertext, true);
         }
         swatch.Stop();
         ms = swatch.ElapsedMilliseconds;
         results[2] = (double)((double)ms / count);
         Console.WriteLine("Decryption time at " + size + " bit ... " +(swatch.ElapsedTicks / (10 * count)).ToString() + " ms");
         Console.ReadKey();

        }
    }
}