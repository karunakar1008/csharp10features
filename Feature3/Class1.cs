namespace Feature3
{
    //Constant interpolation strings
    public static class Class1
    {
        private const string ApiBase = "http://localhost/api/employees";
        private static readonly string GetByName = $"{ApiBase}/name:{{guid}}";//String interpolation
    }
}