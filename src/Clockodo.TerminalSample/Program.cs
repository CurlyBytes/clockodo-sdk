using Clockodo.Contracts.V1.Enums;
using Clockodo.Contracts.V1.Requests;
using Clockodo.Contracts.V1.Responses;
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
            var username = "franz.noyaba@gmail.com";
            var password = "8c0477c9ad68448ac7c296ef6ca63c23";
            var authHeader = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
            var baseAddress = "https://my.clockodo.com";
            var refitSettings = new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(authHeader)
            };

            var handler = new AuthHandler(username, password);
            var githubApi = RestService.For<IAbsences>(new HttpClient(handler)
            {
                BaseAddress = new Uri("https://api.github.com")
            });


            IAbsences absences = RestService.For<IAbsences>(baseAddress, refitSettings);


            try
            {
                var todoApi = RestService.For<IAbsences>(baseAddress, refitSettings);

                Console.WriteLine("get absense Item...");
                var createTodoResponse = await todoApi.GetAllAbsences(new GetAbsenceRequest
                {
                    Year = 2021
                });

               // var createTodoResponse = await todoApi.GetAllAbsences(2021);
                var todoResponse = createTodoResponse.Content;

                if (createTodoResponse.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine(createTodoResponse.StatusCode);
                }
                else

                {
                    Console.WriteLine(createTodoResponse.StatusCode);
                }

                Console.WriteLine(todoResponse.Absences.Count);

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
