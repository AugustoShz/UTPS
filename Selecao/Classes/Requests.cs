using System;
using System.Net;
using System.Text.Json;

namespace Selecao.Classes
{
    class Requests
    {
        public Empresa Get(string url)
        {
            var resposta = new WebClient().DownloadData(url);
            var readOnlySpan = new ReadOnlySpan<byte>(resposta);
            Empresa json = JsonSerializer.Deserialize<Empresa>(readOnlySpan);

            return json;
        }
    }
}
