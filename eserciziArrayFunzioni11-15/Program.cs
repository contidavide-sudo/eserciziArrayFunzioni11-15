using System.Runtime.Intrinsics;

namespace eserciziArrayFunzioni11_15
{
    internal class Program
    {
        //funzione es 11
        static int CountElements(int[] vet1, int x)
        {
            int count = 0;

            for (int i = 0; i < vet1.Length; i++)
            {

                if (vet1[i] == x)
                {
                    count = count + 1;
                }
            }

            return count;
        }

        //fuinzione es 13

        static int FindElement(int[] vet, int x) {

            for (int i = 0; i < vet.Length; i++) {

                if (vet[i] == x) {

                    return i;
                
                }
            
            }

            return -1;
        }

        //funzione es 12

        static bool Contain(int[] vet1, int x)
        {
            int count = 0;

            for (int i = 0; i < vet1.Length; i++)
            {

                if (vet1[i] == x)
                {
                    count=count + 1;
                }
               
            }

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

           
        }

        //funzione es 14 

        static void CopyArray(int [] vet1, int [] vet2)
        {
            for (int i = 0; i < vet1.Length; i++)
            {
                vet2[i] = vet1[i];  
            }
            
        }

        static void PasteArray(int[] v)
        {
            for (int i = 0; i<v.Length; i++)
            {
                Console.Write(v[i]);
            }
        }

        //funzione es 15

        static void CopyReversedArray(int[] vet1, int[] vet2)
        {
            int indiceVet1 = vet1.Length-1;

            for (int i = 0; i<vet1.Length; i++)
            {
                vet2[i] = vet1[indiceVet1];

                indiceVet1 = indiceVet1 - 1;
            }

        }

        static void PasteReversedArray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]);
            }
        }





        static void Main(string[] args)
        {
            //es 11

            int[] v1 = { 2, 6, 2, 2, 19 };
            int x1Main = 2;

            Console.WriteLine("x: " + CountElements(v1, x1Main));

            Console.WriteLine();

            //es 13

            int[] v2 = { 5, 7, 8, 15, 19, 20};
            int x2Main = 8;

            Console.WriteLine("posizione: " + FindElement(v2, x2Main));

            Console.WriteLine();

            //es 12


            int[] v3 = { 2, 6, 2, 2, 19 };
            int x3Main = 6;

            Console.WriteLine(Contain(v3, x3Main));

            Console.WriteLine();

            //es 14

            int[] v4 = { 1, 2, 3, 4 };
            int[] v5 = new int[4];

            CopyArray(v4, v5);

            PasteArray(v5);

            Console.WriteLine();

            //es 15

            int[] v6 = { 1, 2, 3, 4 };
            int[] v7 = new int[4];

            CopyReversedArray(v6, v7);

            PasteReversedArray(v7);
        }
        
    }
}
