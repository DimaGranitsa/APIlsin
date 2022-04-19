using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using API.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;


namespace API.Service
{
   public  class ResService : IRestServise
    {
        List<Entries> EntryModels { get; set; }
        JsonSerializerOptions JsonSerializerOptions;
        HttpClient HttpClient = new HttpClient();
        
        public ResService()
        {
            JsonSerializerOptions = new JsonSerializerOptions();
            {
                PropertyNamingPolicy = new JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }

        public async Task<List<Entrycontainer>> GetDataAsync()
        {

        }
    }
}
