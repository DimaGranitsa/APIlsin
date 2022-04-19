using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using API.Model;

namespace API.Service
{
   public interface IRestServise
    {
        Task<List<Entries>> GetDataAsync();
    }
}
