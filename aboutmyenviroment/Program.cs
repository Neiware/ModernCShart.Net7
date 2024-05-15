namespace aboutmyenviroment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CsharpVoca.Run();
            Console.WriteLine(RawString.backlash);
        }
       

        private void Interpolated()
        {
            string name = "Pedro";
            int num = 10;
            string testString = $"Hola {name} plus {num}";

        }
    }
    
}
