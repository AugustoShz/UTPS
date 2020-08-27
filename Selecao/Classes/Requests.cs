using System;
using System.Net;
using System.Text.Json;

namespace Selecao.Classes
{
    class Requests
    {
        public Empresa Get(string url)
        {
            Empresa json = null;
            try
            {
                var resposta = new WebClient().DownloadData(url);
                var readOnlySpan = new ReadOnlySpan<byte>(resposta);
                json = JsonSerializer.Deserialize<Empresa>(readOnlySpan);
            }
            catch(Exception x){}

            return json;
        }
    }
}
