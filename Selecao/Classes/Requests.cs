using System;
using System.Net;
using System.Text.Json;

namespace Selecao.Classes
{
    class Requests
    {
        string ApiURL = "https://www.receitaws.com.br/v1/cnpj/";
        public Empresa GetEmpresa(string cnpj)
        {
            Empresa json = null;

            try
            {
                var resposta = new WebClient().DownloadData(ApiURL + cnpj);
                var readOnlySpan = new ReadOnlySpan<byte>(resposta);
                json = JsonSerializer.Deserialize<Empresa>(readOnlySpan);
            }
            catch(Exception x){}

            return json;
        }
    }
}
