using Microsoft.AspNetCore.Mvc;

namespace WebApi.Models
{
    public interface ISingletonHttp
    {
        Task<List<Country>> GetServices();
    }
}
