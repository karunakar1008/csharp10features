using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet3
{
    //Lambda imorovements
    internal class Lambdaimprovements
    {
        Func<string> helloWorld = () => "Hello Karuna"; //Infered deligate type is not available in 9
        Func<string> text = () => null; //or var text = string? () => null;  //Do not require to specify the type when you return the value from the lambda

    }
    public class LamdaExpressions
    {
        static void Main(string[] args)
        {
            Func<string> helloWorld = () => "Hello Karuna";
            Func<string> text = () => null;
        }
    }
}
