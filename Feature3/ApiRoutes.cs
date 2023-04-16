namespace Feature3
{
    public static class ApiRoutes
    {
        private const string ApiBase = "/api";
        private const string GetById = $"{ApiBase}/id:{{guid}}";
        private const string GetByName = $"{ApiBase}/name:{{guid}}";//String interpolation
        private const string GetAll = ApiBase;

        public static void ChangeContsant()
        {
            //ApiBase = "change base addrees";
        }
    }
}
