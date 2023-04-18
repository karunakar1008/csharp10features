namespace Feature4
{
    public class LambdaImprovements
    {
        static void Main()
        {
            var helloWorld = () => "Hello Karuna";
            var text = string? () => "kk";
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
