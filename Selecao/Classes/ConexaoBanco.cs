using System.Data;
using MySql.Data.MySqlClient;

public class ConexaoBanco
{
	string _conStr = string.Empty;
	public ConexaoBanco()
	{
		_conStr = "Server=localhost;Port=3306;Database=projeto;Uid=root;Pwd=root";
	}
    public DataTable procurarCNPJ(string CNPJ)
    {
        return this.select("Select * from Empresa WHERE CNPJ = " + CNPJ);
    }

	public DataTable select(string query)
    {

		MySqlConnection _con = new MySqlConnection(_conStr);
		DataTable _table = new DataTable();
		MySqlDataAdapter _adp = new MySqlDataAdapter(query, _con);
		_con.Close();

		_adp.Fill(_table);
        return GenerateTransposedTable(_table);
    }

    private DataTable GenerateTransposedTable(DataTable inputTable)
    {
        DataTable outputTable = new DataTable();

        outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

        foreach (DataRow inRow in inputTable.Rows)
        {
            string newColName = inRow[0].ToString();
            outputTable.Columns.Add(newColName);
        }

        for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
        {
            DataRow newRow = outputTable.NewRow();
            newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
            for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
            {
                string colValue = inputTable.Rows[cCount][rCount].ToString();
                newRow[cCount + 1] = colValue;
            }
            outputTable.Rows.Add(newRow);
        }

        return outputTable;
    }
}
