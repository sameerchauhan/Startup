using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Web.Service
{
    public class EmployeeService : IEmployeeService
    {
        public IEnumerable<EmployeeListDto> GetEmployees(int pageSize)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55665/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                var response = client.GetAsync("api/employee?pageSize="+pageSize).Result;
                if (response.IsSuccessStatusCode)
                {
                    var employees = response.Content.ReadAsAsync<IEnumerable<EmployeeListDto>>().Result;
                    return employees;
                }

            }

            return null;
        }
    }
}
