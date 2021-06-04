using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Parte_12___ASP_NET_Core_parte_1___E_commerce
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}