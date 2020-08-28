using System;
using System.Data;
using System.Windows.Forms;

namespace Selecao.Classes
{
    class EncontrarEmpresa
    {

        Requests requests = new Requests();
        ConexaoBanco cb = new ConexaoBanco();

        public Tuple<Empresa,int> pesquisar(string CNPJ)
        {
            Empresa aux = null;

            aux = pesquisarBanco(CNPJ);
            if (!aux.status.Equals("ERRO"))
                return Tuple.Create(aux, 0);

            aux = pesquisarAPI(CNPJ);
            if (!aux.status.Equals("ERROR"))
                return Tuple.Create(aux, 1);

            return Tuple.Create(aux, 2);
        }

        public Empresa pesquisarBanco(string CNPJ)
        {
            Empresa retorno = this.cb.procurarCNPJ(CNPJ);

            return retorno;
        }

        public Empresa pesquisarAPI(string CNPJ)
        {
            Empresa emp = this.requests.GetEmpresa(CNPJ);

            return emp;
        }
    }
}
