using Crud_Db_Win_Form.Models.DB;
using System.Data;
using System.Data.SQLite;

namespace Crud_Db_Win_Form.Models;

public class Consulta
{
    public int Id { get; set; }
    public int PacienteId { get; set; }
    public string Medico { get; set; } = string.Empty;
    public int ExameId { get; set; }
    public string Diagnostico { get; set; } = string.Empty;
    public string DataConsulta { get; set; } = string.Empty;


    public Consulta() { }

    public Consulta(int pacienteId, string medico, int exameId, string diagnostico, string dataConsulta)
    {
        PacienteId = pacienteId;
        Medico = medico;
        ExameId = exameId;
        Diagnostico = diagnostico;
        DataConsulta = dataConsulta;
    }

    // =========================================================================
    public static DataTable Get()
    {
        DataTable _table = new();
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                cmd.CommandText += "SELECT * FROM Consultas A";
                cmd.CommandText += "\n\t JOIN Exames B \n\t ON A.exame_id = B.id";
                cmd.CommandText += "\n\t JOIN Pacientes C \n\t ON A.paciente_id = C.id";
                //Clipboard.SetText(cmd.CommandText);
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
                cmd.CommandText = "SELECT * FROM Consultas WHERE Id=" + id;
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
    public static bool Add(Consulta consulta)
    {
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Consultas" +
                    "(Paciente_Id, Medico, Exame_Id, Diagnostico, DataConsulta) \n\tVALUES" +
                    "(@PacienteId, @Medico, @ExameId, @Diagnostico, @DataConsulta)";
                Clipboard.SetText(cmd.CommandText);
                cmd.Parameters.AddWithValue("@PacienteId", consulta.PacienteId);
                cmd.Parameters.AddWithValue("@Medico", consulta.Medico);
                cmd.Parameters.AddWithValue("@ExameId", consulta.ExameId);
                cmd.Parameters.AddWithValue("@Diagnostico", consulta.Diagnostico);
                cmd.Parameters.AddWithValue("@DataConsulta", consulta.DataConsulta);
                //Clipboard.SetText(cmd.Parameters.ToString());
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

    public static bool Update(Consulta consulta)
    {
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                //if (consulta.Id != null)
                {
                    cmd.CommandText = "UPDATE Consultas SET Paciente_Id=@PacienteId, Medico=@Medico, Exame_Id=@ExameId, " +
                                        "Diagnostico=@Diagnostico, DataConsulta=@DataConsulta WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", consulta.Id);
                    cmd.Parameters.AddWithValue("@PacienteId", consulta.PacienteId);
                    cmd.Parameters.AddWithValue("@Medico", consulta.Medico);
                    cmd.Parameters.AddWithValue("@ExameId", consulta.ExameId);
                    cmd.Parameters.AddWithValue("@Diagnostico", consulta.Diagnostico);
                    cmd.Parameters.AddWithValue("@DataConsulta", consulta.DataConsulta);
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível atualizar os dados da consulta: {consulta.PacienteId}! ***",
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
                cmd.CommandText = "DELETE FROM Consultas Where Id=@Id";
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
                cmd.CommandText += "Consultas ";
                cmd.CommandText += "(\n\t id INTEGER PRIMARY KEY AUTOINCREMENT,";
                cmd.CommandText += "\n\t paciente_id INT NOT NULL,";
                cmd.CommandText += "\n\t medico VARCHAR(100) NOT NULL,";
                cmd.CommandText += "\n\t exame_id INT NOT NULL,";
                cmd.CommandText += "\n\t diagnostico VARCHAR(20) NULL,";
                cmd.CommandText += "\n\t dataConsulta VARCHAR(20) NOT NULL,";
                cmd.CommandText += "\n\t FOREIGN KEY(exame_id) REFERENCES Exames(id),";
                cmd.CommandText += "\n\t FOREIGN KEY(paciente_id) REFERENCES Pacientes(id) \n);";

                Clipboard.SetText(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível gerar a tabela \"Consultas\"! ***",
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
                cmd.CommandText += "Consultas;";

                Clipboard.SetText(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível excluir a tabela \"Consultas\"! ***",
                         "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // =========================================================================
    public static bool GerarDadosIniciais()
    {
        bool ok = true;
        if (!ok) return false;
        Consulta consulta = new(2, "Carlos Saraiva", 3, "Tá Lascado!", "20/03/2024");
        ok = Add(consulta);

        if (!ok) return false;
        consulta = new(5, "Roberto Dutra", 4, "Se salvou!", "20/03/2024");
        ok = Add(consulta);

        if (!ok) return false;
        consulta = new(1, "Pedro Gentil", 1, "Faça Testamento.", "20/03/2024");
        ok = Add(consulta);

        if (!ok) return false;
        consulta = new(3, "Rafael Botelho", 2, "Tá bem.", "20/03/2024");
        ok = Add(consulta);

        if (!ok) return false;
        consulta = new(2, "Maria Eduarda", 3, "Não sei.", "20/03/2024");
        ok = Add(consulta);

        return true;
    }

}