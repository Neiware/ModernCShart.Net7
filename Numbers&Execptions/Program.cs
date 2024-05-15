namespace Numbers_Execptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                byte maxbyte = byte.MaxValue;
                maxbyte++;
                Console.WriteLine(maxbyte);
                //int max = 500;
                //for (byte i = 0; i < max; i++)
                //{
                //    Console.WriteLine(i);
                //}
                IntDivideByZero();
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        static void IntDivideByZero()
        {
            int[] arrayInt = new int[] { 10, 30, 55, 43, 23, 99 };

            foreach (int i in arrayInt)
            {
                Console.WriteLine(
                    format: $"Number: {0} divided by zero is: {1}",
                    arg0: i,
                    arg1: i / 0
                    );
            }
        }
    }
}
