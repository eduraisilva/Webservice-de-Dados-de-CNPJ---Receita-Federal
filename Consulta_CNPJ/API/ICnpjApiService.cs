using Refit;
using System.Threading.Tasks;

namespace Consulta_CNPJ.API
{
    public interface ICnpjApiService
    {
        [Get("/v1/cnpj/{numero}")]
        Task<CnpjResponse> GetAddressAsync(string numero);
    }
}
