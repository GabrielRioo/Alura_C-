using System.Collections.Generic;

namespace Parte_12___ASP_NET_Core_parte_1___E_commerce
{
    public interface ICatalogo
    {
        List<Livro> GetLivros();
    }
}