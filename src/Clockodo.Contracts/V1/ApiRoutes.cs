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
        public const string ClockodoUserName = "";
        public const string ClockodoPassword = "";

        public static class Absences
        {
            public const string GetListAbsences = Base + "/absences";
            public const string Get = Base + "/absences/{id}";
            public const string Post = Base + "/absences";
            public const string Put = Base + "/absences/{id}";
            public const string Delete = Base + "/absences/{id}";
        }

        public static class Clock
        {
            public const string GetClock = Base + "/clock";
            public const string GetClockUpdate = Base + "/clock/update";
            public const string GetSearchText = Base + "/clock/searchtexts";
            public const string PostStartClock = Base + "/clock";
            public const string PutClock = Base + "/clock/{id}";
            public const string DeleteStopClock = Base + "/clock/{id}";
        }

        public static class Customers
        {
            public const string GetListCustomers = Base + "/customers";
            public const string GetCustomersById = Base + "/customers/{id}";
            public const string PostCustomers = Base + "/customers";
            public const string PutCustomers = Base + "/customers/{id}";
            public const string DeleteCustomer = Base + "/customers/{id}";
        }

        public static class EntryGroups
        {
            public const string GetRequestGroups = Base + "/entrygroups";
            public const string PutEntries = Base + "/entrygroups";
            public const string DeleteEntries = Base + "/entrygroups";
        }

        public static class HolidaysCarry
        {
            public const string GetListHolidaysCarry = Base + "/holidayscarry";
            public const string GetHolidaysCarryByUserIdYear = Base + "/holidayscarry/{id}/{year}";
            public const string PostHolidaysCarry = Base + "/holidayscarry";
            public const string PuttHolidaysCarry = Base + "/holidayscarry/{id}/{year}";
            public const string DeleteHolidaysCarry = Base + "/holidayscarry/{id}/{year}";
        }

        public static class HolidaysQuota
        {
            public const string GetListHolidaysQuota = Base + "/holidaysquota";
            public const string GetHolidaysQuotaById = Base + "/holidaysquota/{id}";
            public const string PostHolidaysQuota = Base + "/holidaysquota";
            public const string PuttHolidaysQuota = Base + "/holidaysquota/{id}";
            public const string DeletetHolidaysQuota = Base + "/holidaysquota/{id}";
        }

        public static class LumpSumServices
        {
            public const string GetListLumpSumServices = Base + "/lumpsumservices";
            public const string GetLumpSumServices = Base + "/lumpsumservices/{id}";
            public const string PostLumpSumServices = Base + "/lumpsumservices";
            public const string PutLumpSumServices = Base + "/lumpsumservices/{id}";
            public const string DeleteLumpSumServices = Base + "/lumpsumservices/{id}";
        }

        public static class NonBusinessDays
        {
            public const string GetListNonBusinessDays = Base + "/nonbusinessdays";
        }

        public static class NonBusinessGroups
        {
            public const string GetListNonBusinessGroups = Base + "/nonbusinessgroups";
        }

        public static class OverTimeCarry
        {
            public const string GetListOverTimeCarry = Base + "/overtimecarry";
            public const string GetOverTimeCarry = Base + "/overtimecarry/{id}/{year}";
            public const string PostOverTimeCarry = Base + "/overtimecarry";
            public const string PutOverTimeCarry = Base + "/overtimecarry/{id}/{year}";
            public const string DeleteOverTimeCarry = Base + "/overtimecarry/{id}/{year}";
        }

        public static class Projects
        {
            public const string GetListProjects = Base + "/projects";
            public const string GetProjects = Base + "/projects/{id}";
            public const string PostProjects = Base + "/projects";
            public const string PutProjects = Base + "/projects/{id}";
            public const string DeleteteProjects = Base + "/projects/{id}";
        }

        public static class Account
        {
            public const string PostRegisterAcount = Base + "/register";
        }


        public static class Services
        {
            public const string GetListServices = Base + "/services";
            public const string GetServices = Base + "/services/{id}";
            public const string PostServices = Base + "/services";
            public const string PutServices = Base + "/services/{id}";
            public const string DeleteteServices = Base + "/services/{id}";
        }

        public static class TargetHours
        {
            public const string GetListTargetHours = Base + "/targethours";
            public const string GetTargetHours = Base + "/targethours/{id}";
            public const string PostTargetHours = Base + "/targethours";
            public const string PutTargetHours = Base + "/targethours/{id}";
            public const string DeleteteTargetHours = Base + "/targethours/{id}";
        }

        public static class UserReports
        {
            public const string GetListUserReportsOfAllCoWorkers = Base + "/userreports";
            public const string GetUserReportsOfAllCoWorkersById = Base + "/userreports/{id}";
        }

        public static class Users
        {
            public const string GetListUsers = Base + "/users";
            public const string GetUsersById = Base + "/users/{id}";
            public const string PostUsers = Base + "/users";
            public const string PutUsers = Base + "/users/{id}";
            public const string DeleteteUsers = Base + "/users/{id}";
        }
    }
}
