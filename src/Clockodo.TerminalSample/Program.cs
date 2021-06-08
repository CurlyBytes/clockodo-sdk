using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Enums;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Sdk;
using Refit;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clockodo.TerminalSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
  
            var authHeader = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(ApiRoutes.ClockodoUserName + ":" + ApiRoutes.ClockodoPassword));
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };


            IAbsences absences = RestService.For<IAbsences>(ApiRoutes.BaseAddress, refitSettings);


            try
            {
              //  var todoApi = RestService.For<IAbsences>("https://localhost:44311/");

                Console.WriteLine("Creating Todo Item...");
                //var createTodoResponse = await absences.GetAllAbsences(new GetAbsenceRequest
                //{

                //    Year = 2021
                //});
                var createTodoResponse = await absences.DeleteAbsencesAsync(648756);

                var todoResponse = createTodoResponse.Content;

                Console.WriteLine("get absense Item..." + todoResponse);
                //var createTodoResponse = await absences.PostAbsencesAsync(new PostAbsencesRequest
                //{
                //    date_since = "2021-06-09",
                //    date_until = "2021-06-09",
                //    type = 2

                //});

                ////var createTodoResponse = await todoApi.GetllAbsencesById(646977);
                //var todoResponse = createTodoResponse.Content;

                //if (createTodoResponse.StatusCode != HttpStatusCode.OK)
                //{
                //    Console.WriteLine(createTodoResponse.StatusCode);
                //}
                //else

                //{
                //    Console.WriteLine(createTodoResponse.StatusCode);
                //}

                //Console.WriteLine(todoResponse.Absence);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
            finally
            {

            }
   

            //Console.WriteLine("\nUpdating Todo Item...");
            //var updatewrapperAbsenceResponse = await todoApi.UpdateAsync(todoItemId, new UpdateTodoRequest
            //{
            //    IsCompleted = true
            //});

            //wrapperAbsenceResponse = updatewrapperAbsenceResponse.Content;

            //Console.WriteLine($"Name:{wrapperAbsenceResponse.Name} ({wrapperAbsenceResponse.Id})");
            //Console.WriteLine($"Completed: {wrapperAbsenceResponse.IsCompleted}");

            //Console.WriteLine("\nDeleting Todo Item...");
            //var deletewrapperAbsenceResponse = await todoApi.DeleteAsync(todoItemId);

            //Console.WriteLine("\nGetting All Todo Items...");
            //var getAllwrapperAbsenceResponse = await todoApi.GetAllAsync();

            //var todoItems = getAllwrapperAbsenceResponse.Content;

            //Console.WriteLine($"Todo Items Remaining: {todoItems.Count}");

            Console.ReadKey();

        }


        public class AuthHandler : HttpClientHandler
        {
            private readonly string _username;
            private readonly string _password;

            public AuthHandler(string username,
                string password)
            {
                _username = username;
                _password = password;
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                request.Headers.Add("User-Agent", "<your user name or app name>");
                request.Headers.Authorization = new AuthenticationHeaderValue("Basic",
                    Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(
                        $"{_username}:{_password}")));

                return await base.SendAsync(request, cancellationToken)
                    .ConfigureAwait(false);
            }
        }
    }
}
