using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet3
{
    //Constant interpolated strings is not supported in c# 9.0
    public static class ApiRoutes
    {
        private const string ApiBase = "/api";
        private const string GetById = ApiBase + "/id:{guid}";
        private static readonly string GetByName = $"{ApiBase}/name:{{guid}}";//String interpolation

        //private const string GetByName = $"{ApiBase}/name:{{guid}}";//String interpolation

        private const string GetAll = ApiBase;
    }
}
