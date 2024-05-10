using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAPI.Test.Helpers
{
    /// <summary>
    /// Método para criar um client http da api de produtos
    /// </summary>

    public class TestHelper
    {
        public static HttpClient CreateClient 
        {
            get
            {
                var accessToken = @"";
                
                var auth = new AuthenticationHeaderValue("Bearer", accessToken);
                var client = new WebApplicationFactory<Program>().CreateClient();

                client.DefaultRequestHeaders.Authorization = auth;
                return client;

            }     
        }
        
       
        /// <summary>
        /// Método para serializar o conteudo da requisição que será enviada para um serviço
        /// </summary>
        public static StringContent CreateContent<TRequest>(TRequest request) 
            => new StringContent(JsonConvert.SerializeObject(request),
                   Encoding.UTF8, "application/json");
        
        /// <summary>
        /// Método para deserializar o retorno obtido pela execução de um serviço
        /// </summary>
        public static TResponse ReadResponse<TResponse>(HttpResponseMessage message)
            => JsonConvert.DeserializeObject<TResponse>(message.Content.ReadAsStringAsync().Result);
    }
}
