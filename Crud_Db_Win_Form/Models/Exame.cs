using Crud_Db_Win_Form.Models.DB;
using System.Data;
using System.Data.SQLite;

namespace Crud_Db_Win_Form.Models;

public class Exame
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Resultado { get; set; } = string.Empty;
    public string Local { get; set; } = string.Empty;
    public string DataExame { get; set; } = string.Empty;
    public string DataEntrega { get; set; } = string.Empty;


    public Exame() { }

    public Exame(string nome, string resultado, string local, string dataExame, string dataEntrega)
    {
        Nome = nome;
        Resultado = resultado;
        Local = local;
        DataExame = dataExame;
        DataEntrega = dataEntrega;
    }


    // =========================================================================
    public static DataTable Get()
    {
        DataTable _table = new();
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Exames";
                SQLiteDataAdapter _adapter = new(cmd.CommandText, ConectaDb.Conectar());
                _adapter.Fill(_table);
                return _table;
            }
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível recuperar os dados! ***",
                         "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return _table = null;
        }
    }

    // =========================================================================
    public static DataTable Get(int id)
    {
        DataTable _table = new();
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Exames WHERE Id=" + id;
                SQLiteDataAdapter _adapter = new(cmd.CommandText, ConectaDb.Conectar());
                _adapter.Fill(_table);
                return _table;
            }
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível recuperar os dados do id: {id}! ***",
                         "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return _table = null;
        }
    }

    // =========================================================================
    public static bool Add(Exame exame)
    {
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Exames" +
                    "(Nome, Resultado, Local, DataExame, DataEntrega) \n\tVALUES" +
                    "(@Nome, @Resultado, @Local, @DataExame, @DataEntrega)";
                Clipboard.SetText(cmd.CommandText);
                cmd.Parameters.AddWithValue("@Nome", exame.Nome);
                cmd.Parameters.AddWithValue("@Resultado", exame.Resultado);
                cmd.Parameters.AddWithValue("@Local", exame.Local);
                cmd.Parameters.AddWithValue("@DataExame", exame.DataExame);
                cmd.Parameters.AddWithValue("@DataEntrega", exame.DataEntrega);
                Clipboard.SetText(cmd.Parameters.ToString());
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível inserir todos dados! ***",
                         "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // =========================================================================

    public static bool Update(Exame exame)
    {
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                //if (exame.Id != null)
                {
                    cmd.CommandText = "UPDATE Exames SET Nome=@Nome, Resultado=@Resultado, Local=@Local, " +
                                      "DataExame=@DataExame, DataEntrega=@DataEntrega WHERE Id=@Id";
                    Clipboard.SetText(cmd.CommandText);
                    cmd.Parameters.AddWithValue("@Id", exame.Id);
                    cmd.Parameters.AddWithValue("@Nome", exame.Nome);
                    cmd.Parameters.AddWithValue("@Resultado", exame.Resultado);
                    cmd.Parameters.AddWithValue("@Local", exame.Local);
                    cmd.Parameters.AddWithValue("@DataExame", exame.DataExame);
                    cmd.Parameters.AddWithValue("@DataEntrega", exame.DataEntrega);
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível atualizar os dados do exame: {exame.Nome}! ***",
                         "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // =========================================================================
    public static bool Delete(int id)
    {
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Exames Where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível deletar os dados do id: {id}! ***",
                         "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // =========================================================================
    // =========================================================================
    public static bool GerarTabela()
    {
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                cmd.CommandText += "CREATE TABLE IF NOT EXISTS ";
                cmd.CommandText += "Exames";
                cmd.CommandText += "(\n\t id INTEGER PRIMARY KEY AUTOINCREMENT,";
                cmd.CommandText += "\n\t nome VARCHAR(100) NOT NULL,";
                cmd.CommandText += "\n\t resultado VARCHAR(50) NULL,";
                cmd.CommandText += "\n\t local VARCHAR(100) NOT NULL,";
                cmd.CommandText += "\n\t dataExame VARCHAR(20) NOT NULL,";
                cmd.CommandText += "\n\t dataEntrega VARCHAR(20) NULL \n);";

                Clipboard.SetText(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível gerar a tabela \"Exames\"! ***",
                         "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // =========================================================================
    public static bool ExcluirTabela()
    {
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                cmd.CommandText += "DROP TABLE IF EXISTS ";
                cmd.CommandText += "Exames ;";

                Clipboard.SetText(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível excluir a tabela \"Exames\"! ***",
                         "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // =========================================================================
    public static bool GerarDadosIniciais()
    {
        bool ok = true;
        if (!ok) return false;
        Exame exame = new("Hemograma", "Normal", "Lab. 01", "15/03/2024", "21/03/2024");
        ok = Add(exame);

        if (!ok) return false;
        exame = new("Colesterol", "Alto", "Lab. 02", "20/03/2024", "02/04/2024");
        ok = Add(exame);

        if (!ok) return false;
        exame = new("Glicemia", "Baixa", "Lab. 03", "21/05/2024", "22/05/2024");
        ok = Add(exame);

        if (!ok) return false;
        exame = new("Visão", "Tá fudido!", "Lab. 04", "11/04/2024", "12/04/2024");
        ok = Add(exame);

        if (!ok) return false;
        exame = new("Urina", "Normal", "Lab. 05", "30/03/2024", "20/04/2024");
        ok = Add(exame);

        return true;
    }

}