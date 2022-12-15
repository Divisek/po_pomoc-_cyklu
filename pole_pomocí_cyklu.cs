using System;

namespace pole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole= new int[10];
            pole[0] = 1;
            for (int posun_indexu = 0; posun_indexu < 10; posun_indexu++)
            {
                pole[posun_indexu] = posun_indexu + 1;
            }
            for (int index = 0; index < pole.Length; index++)
                Console.Write("{0}", pole[index]);
        }
    }
}
