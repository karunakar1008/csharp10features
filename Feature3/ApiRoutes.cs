namespace Feature3
{
    public static class ApiRoutes
    {
        public const string ApiBase = "http://localhost/api/employees";
        public const string GetById = $"{ApiBase}/id:{{guid}}";
        public const string GetByName = $"{ApiBase}/name:{{guid}}";//String interpolation
        public const string GetAll = ApiBase;

        public static void ChangeContsant()
        {
            //ApiBase = "change base addrees";
        }
    }
}
