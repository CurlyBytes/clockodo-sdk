using Clockodo.Contracts.V1;
using Clockodo.Contracts.V1.Absence.Requests;
using Clockodo.Contracts.V1.Absence.Responses;
using Clockodo.Contracts.V1.Customer.Requests;
using Clockodo.Contracts.V1.Customer.Response;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Clockodo.Sdk
{
    [Headers("Authorization: Basic")]
    public interface ICustomer
    {
        [Get(ApiRoutes.Customers.GetListCustomers)]
        Task<ApiResponse<WrapperCustomersResponse>> GetAllCustomers();

        [Get(ApiRoutes.Customers.GetCustomersById)]
        Task<ApiResponse<WrapperCustomerResponse>> GetllCustomersById(int id);

        [Post(ApiRoutes.Customers.GetListCustomers)]
        Task<ApiResponse<WrapperCustomerResponse>> PostCustomersAsync([Body(BodySerializationMethod.UrlEncoded)] PostCustomersRequest postCustomers);

        [Put(ApiRoutes.Customers.PutCustomers)]
        Task<ApiResponse<WrapperCustomerResponse>> PutCustomersAsync(int id, [Body(BodySerializationMethod.UrlEncoded)] PutCustomersRequest putCustomers);

        [Delete(ApiRoutes.Customers.DeleteCustomer)]
        Task<ApiResponse<string>> DeleteCustomersAsync(int id);
    }
}
