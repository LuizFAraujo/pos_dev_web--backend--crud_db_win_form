using System.Data.SQLite;

namespace Crud_Db_Win_Form.Models.DB;

public class DbUtils : ConectaDb
{
    // =========================================================================
    // ------------------ Testa se banco existe e esta conectado
    public static bool IsBancoConectado()
    {
        using var cmd = Conectar();
        if (cmd == null)
            return false;

        Conn.Close();
        return true;
    }

    // =========================================================================
    // ------------------ Testa se diretório existe, antes de criar o banco
    public static bool ExistsBancoDir()
    {
        if (Directory.Exists(StrBancoDir))
            return true;
        return false;
    }

    // =========================================================================
    // ------------------ Testa se banco existe
    public static bool ExistsBancoArq()
    {
        if (File.Exists(StrBancoArq))
            return true;
        return false;
    }

    // =========================================================================
    // ------------------ Gerar Banco
    public static bool GerarBanco()
    {
        try
        {
            if (!ExistsBancoDir()) { DirectoryInfo di = Directory.CreateDirectory(StrBancoDir); }

            SQLiteConnection.CreateFile($"{StrBancoArq}");
            MessageBox.Show("Banco de Dados gerado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        catch (Exception)
        {
            MessageBox.Show("Não foi possível gerar o Banco de Dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            throw;
        }
    }

    //// =========================================================================
    //// ------------------ Exluir Banco ( NÃO IMPLEMENTADO )
    //public static bool ExcluirBanco()
    //{
    //    try
    //    {
    //        //if (!ExistsBancoDir()) { DirectoryInfo di = Directory.CreateDirectory(StrBancoDir); }
    //        File.Delete(StrBancoArq);

    //        //MessageBox.Show("Banco Gerado.");
    //        return true;
    //    }
    //    catch (Exception)
    //    {
    //        MessageBox.Show("Não ****** foi possível gerar o banco!");
    //        throw;
    //    }
    //}



}








