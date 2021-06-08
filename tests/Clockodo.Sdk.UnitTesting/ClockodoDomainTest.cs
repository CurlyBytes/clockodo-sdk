using Clockodo.Contracts.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Clockodo.Sdk.UnitTesting
{
    public class ClockodoDomainTest
    {
        public string ApiBaseUrl { get; set; } = ApiRoutes.BaseAddress;
        public string ClockodoUserName { get; set; } = ApiRoutes.ClockodoUserName;
        public string ClockodoPassword { get; set; } = ApiRoutes.ClockodoPassword;

        public ClockodoDomainTest()
        {

            string apiBaseUrl = Environment.GetEnvironmentVariable("ApiBaseUrl");
            if (!String.IsNullOrEmpty(apiBaseUrl))
            {
                ApiBaseUrl = apiBaseUrl;
            }

            string clockodoUserName = Environment.GetEnvironmentVariable("ClockodoUserName");
            if (!String.IsNullOrEmpty(clockodoUserName))
            {
                ClockodoUserName = clockodoUserName;
            }

            string clockodoPassword = Environment.GetEnvironmentVariable("ClockodoPassword");
            if (!String.IsNullOrEmpty(clockodoPassword))
            {
                ClockodoPassword = clockodoPassword;
            }
        }

        [Fact]
        public async Task Valid_ApiEndpoint()
        {
            var apiClient = new HttpClient();

            var apiResponse = await apiClient.GetAsync($"{ApiBaseUrl}");

            Assert.True(apiResponse.IsSuccessStatusCode);
        }

        [Fact]
        public async Task Valid_ApiStatusCode()
        {
            HttpStatusCode statusCode = await GetStatusCode(ClockodoUserName, ClockodoPassword);

            Assert.Equal(HttpStatusCode.OK, statusCode);
        }

        [Fact]
        public async Task Unauthorize_ApiStatusCode()
        {
            HttpStatusCode statusCode = await GetStatusCode("wrongusername", "Wrongpassword");

            Assert.Equal(HttpStatusCode.Unauthorized, statusCode);
        }

        private async Task<HttpStatusCode> GetStatusCode(string userName, string password)
        {
            HttpMessageHandler handler = new HttpClientHandler()
            {
            };

            var httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri(ApiBaseUrl),
                Timeout = new TimeSpan(0, 2, 0)
            };

            httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");

            //This is the key section you were missing    
            var plainTextBytes = Encoding.UTF8.GetBytes($"{userName}:{password}");
            string token = Convert.ToBase64String(plainTextBytes);
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + token);

            HttpResponseMessage response = httpClient.GetAsync(ApiBaseUrl + "/api/services").Result;
      

            return response.StatusCode;
        }

    
    }
}
