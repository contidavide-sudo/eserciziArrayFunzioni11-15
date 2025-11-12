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


        static void Main(string[] args)
        {
            //es 11

            int[] v1 = { 2, 6, 2, 2, 19 };
            int x1Main = 2;

            Console.WriteLine("x: " + CountElements(v1, x1Main));

            //es 13

            int[] v2 = { 5, 7, 8, 15, 19, 20};
            int x2Main = 8;

            Console.WriteLine("posizione: " + FindElement(v2, x2Main));


        }
        
    }
}
