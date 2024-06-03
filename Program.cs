namespace ArraysE4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] i = { 5, 2, 8, 1 }; //declare and initiliase

            Console.WriteLine("Length is " + i.Length);

            for (int j = 0; j < i.Length; j++)
            {
                Console.WriteLine(i[j]);
            }
            
        }//end main

    }//end class

}//end namespace