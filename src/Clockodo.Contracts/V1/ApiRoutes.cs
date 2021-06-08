using System;
using System.Collections.Generic;
using System.Text;

namespace Clockodo.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Base = "/" + Root ;
        public const string BaseAddress = "https://my.clockodo.com";
        public const string ClockodoUserName = "franz.noyaba@gmail.com";
        public const string ClockodoPassword = "8c0477c9ad68448ac7c296ef6ca63c23";

        public static class Absences
        {
            public const string GetListAbsences = Base + "/absences";
            public const string Get = Base + "/absences/{id}";
            public const string Post = Base + "/absences";
            public const string Put = Base + "/absences/{id}";
            public const string Delete = Base + "/absences/{id}";
        }
    }
}
