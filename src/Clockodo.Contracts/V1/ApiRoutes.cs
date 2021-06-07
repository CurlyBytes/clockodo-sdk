using System;
using System.Collections.Generic;
using System.Text;

namespace Clockodo.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Base = "/" + Root ;

        public static class Absences
        {
            public const string GetListAbsences = "/api/absences";
            public const string Get = Base + "/absences/{id}";
            public const string Post = Base + "/absences";
            public const string Put = Base + "/absences/{id}";
            public const string Delete = Base + "/absences/{id}";
        }
    }
}
