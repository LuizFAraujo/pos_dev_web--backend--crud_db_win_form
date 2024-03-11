using Crud_Db_Win_Form.Models.DB;
using System.Data;
using System.Data.SQLite;

namespace Crud_Db_Win_Form.Models;

public class Paciente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string RG { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string DataNascto { get; set; } = string.Empty;


    public Paciente() { }

    public Paciente(string nome, string rg, string cpf, string email, string dataNascto)
    {
        Nome = nome;
        RG = rg;
        CPF = cpf;
        Email = email;
        DataNascto = dataNascto;
    }

    // =========================================================================
    public static DataTable Get()
    {
        DataTable _table = new();
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Pacientes";
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
                cmd.CommandText = "SELECT * FROM Pacientes WHERE Id=" + id;
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
    public static bool Add(Paciente paciente)
    {
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Pacientes" +
                    "(Nome, RG, CPF, Email, DataNascto) \n\tVALUES" +
                    "(@Nome, @RG, @CPF, @Email, @DataNascto)";
                Clipboard.SetText(cmd.CommandText);
                cmd.Parameters.AddWithValue("@Nome", paciente.Nome);
                cmd.Parameters.AddWithValue("@RG", paciente.RG);
                cmd.Parameters.AddWithValue("@CPF", paciente.CPF);
                cmd.Parameters.AddWithValue("@Email", paciente.Email);
                cmd.Parameters.AddWithValue("@DataNascto", paciente.DataNascto);
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

    public static bool Update(Paciente paciente)
    {
        try
        {
            using (var cmd = ConectaDb.Conectar().CreateCommand())
            {
                //if (paciente.Id != null)
                {
                    cmd.CommandText = "UPDATE Pacientes SET Nome=@Nome, RG=@RG, CPF=@CPF, " +
                                        "Email=@Email, DataNascto=@DataNascto WHERE Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", paciente.Id);
                    cmd.Parameters.AddWithValue("@Nome", paciente.Nome);
                    cmd.Parameters.AddWithValue("@RG", paciente.RG);
                    cmd.Parameters.AddWithValue("@CPF", paciente.CPF);
                    cmd.Parameters.AddWithValue("@Email", paciente.Email);
                    cmd.Parameters.AddWithValue("@DataNascto", paciente.DataNascto);
                    cmd.ExecuteNonQuery();
                }
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível atualizar os dados do paciente: {paciente.Nome}! ***",
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
                cmd.CommandText = "DELETE FROM Pacientes Where Id=@Id";
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
                cmd.CommandText += "Pacientes ";
                cmd.CommandText += "(\n\t id INTEGER PRIMARY KEY AUTOINCREMENT,";
                cmd.CommandText += "\n\t nome VARCHAR(100) NOT NULL,";
                cmd.CommandText += "\n\t rg VARCHAR(20) NULL,";
                cmd.CommandText += "\n\t cpf VARCHAR(20) NOT NULL,";
                cmd.CommandText += "\n\t email VARCHAR(100) NULL,";
                cmd.CommandText += "\n\t dataNascto VARCHAR(20) NULL \n);";

                Clipboard.SetText(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível gerar a tabela \"Pacientes\"! ***",
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
                cmd.CommandText += "Pacientes;";

                Clipboard.SetText(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        catch (SQLiteException ex)
        {
            MessageBox.Show($"Erro: {ex.ErrorCode}" +
                         $"\n{ex.Message}" +
                         $"\n\n*** Não foi possível excluir a tabela \"Pacientes\"! ***",
                         "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // =========================================================================
    public static bool GerarDadosIniciais()
    {
        bool ok = true;
        if (!ok) return false;
        Paciente paciente = new("Luiz", "47.921.156-5", "483.191.520-38", "luiz@luiz.com", "01/01/1980");
        ok = Add(paciente);

        if (!ok) return false;
        paciente = new("Leticia", "27.005.223-9", "969.151.920-85", "leticia@leticia.com", "02/08/1989");
        ok = Add(paciente);

        if (!ok) return false;
        paciente = new("Pedro", "22.089.817-0", "280.430.330-64", "pedro@pedro.com", "15/09/1978");
        ok = Add(paciente);

        if (!ok) return false;
        paciente = new("Maria", "15.534.132-7", "523.323.730-04", "maria@maria.com", "22/06/1985");
        ok = Add(paciente);

        if (!ok) return false;
        paciente = new("Juca", "50.205.969-2", "795.004.410-12", "juca@juca.com", "10/12/1994");
        ok = Add(paciente);

        return true;
    }

}