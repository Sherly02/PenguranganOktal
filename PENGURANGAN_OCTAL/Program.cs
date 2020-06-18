using System;
namespace PENGURANGAN_OCTAL
{
    class Program
    {
        int mO2D(int OCT)
        {
            int DEC = 0, X = 0;
            while (OCT > 0)
            { 
                DEC +=(int)(OCT % 10 * Math.Pow(8, X++));
                OCT /= 10;
            }
            return DEC;
        }
        
        int mD2O(int DEC)
        {
            int OCT = 0 , X = 0;
            while (DEC > 0)
            {
                OCT +=(int)(DEC % 8 * Math.Pow(10, X++));
                DEC /= 8;
            }
            return OCT;
        }
        static void Main(string[] args)
        {
            Console.Write("    PENGURANGAN OCTAL ");
            Console.WriteLine("\n  Oleh : Sherly Tanaya Mauren ");
            int OCT, OCT1, OCT2, DEC, DEC1, DEC2;
            Console.Write("\n    Bil. Oct1   = ");
            OCT1 = int.Parse(Console.ReadLine());

            Console.Write("\n    Bil. Oct2   = ");
            OCT2 = int.Parse(Console.ReadLine());

            Program n1 = new Program();
            DEC1 = n1.mO2D(OCT1);
            DEC2 = n1.mO2D(OCT2);

            DEC = DEC1 - DEC2;
            Program n2 = new Program();
            OCT = n2.mD2O(DEC);

            Console.Write("\n    Oct1 - Oct2 = " + OCT);
            Console.ReadKey();
        }
    }
}
