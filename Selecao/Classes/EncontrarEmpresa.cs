using System;
using System.Data;

namespace Selecao.Classes
{
    class EncontrarEmpresa
    {

        Requests requests = new Requests();
        ConexaoBanco cb = new ConexaoBanco();

        public Tuple<DataTable,int> pesquisar(string CNPJ)
        {
            DataTable aux = null;

            aux = pesquisarBanco(CNPJ);
            if (aux.Columns.Count > 1)
                return Tuple.Create(aux, 0);

            aux = pesquisarAPI(CNPJ);
            if (aux != null)
                return Tuple.Create(aux, 1);

            aux = null;
            return Tuple.Create(aux, 2);
        }

        public DataTable pesquisarBanco(string CNPJ)
        {
            DataTable retorno = this.cb.procurarCNPJ(CNPJ);

            return retorno;
        }

        public DataTable pesquisarAPI(string CNPJ)
        {
            Empresa emp = this.requests.GetEmpresa(CNPJ);
            DataTable retorno = null;
            if (emp != null)
            {
                retorno = new DataTable();
                retorno = emp.toDataTable();
            }

            return retorno;
        }
    }
}
