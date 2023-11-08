using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEPWF
{
    internal interface ICEPApiServices
    {
        [Get("/ws/{cep}/json")]

        Task<CepResponse> GetAddressAsync(string CEP);
    }
}
