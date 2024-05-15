namespace Ch03Ex03FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(
                    format: "{0}",
                    arg0: CheckFizzBuzz(i)
                    ) ;
                if(i < 100)
                {
                    Console.Write(", ");
                }
            }


        }

        static string CheckFizzBuzz(int value)
        {
            string rtnValue = string.Empty;
            if(value%3 == 0 && value%5 == 0)
            {
                rtnValue = "FizzBuzz";
            }else if(value%3 == 0) 
            {
                rtnValue = "Fizz";
            }else if(value%5 == 0)
            {
                rtnValue = "Buzz";
            }
            else
            {
                rtnValue = value.ToString();
            }

            return rtnValue;
        }
    }
}
