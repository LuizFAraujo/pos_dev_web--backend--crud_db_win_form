using System.Data.SQLite;

namespace Crud_Db_Win_Form.Models.DB;

public class ConectaDb
{
    private static SQLiteConnection? conn;
    private static string strInit = "Data Source=";
    private static string strBancoDir = "C:\\DB\\"; // utilizar \\ para separar diretórios
    protected static string strBdName = "crud_db.sqlite";
    private static string strVersao = "; Version=3;";

    private static string strBancoArq = $"{strBancoDir}{strBdName}";
    private static string connStr = $"{strInit}{strBancoDir}{strBdName}{strVersao}";

    public ConectaDb() { }

    public static string StrBancoDir { get { return strBancoDir; } private set { strBancoDir = value; } }
    public static string StrBancoArq { get { return strBancoArq; } private set { strBancoArq = value; } }
    public static SQLiteConnection Conn { get { return conn; } }


    public static SQLiteConnection Conectar()
    {
        conn = new SQLiteConnection(connStr);

        try
        {
            conn.Open();
            return conn;
        }
        catch (SQLiteException)
        {
            //MessageBox.Show($"Erro: {ex.ErrorCode}" +
            //    $"\n{ex.Message}" +
            //    $"\n\n*** Não foi possível conectar ao banco! ***",
            //    "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();
            return conn = null;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro:" +
                $"\n{ex.Message}" +
                $"\n\n*** Não foi possível conectar ao banco! ***",
                "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            conn.Close();
            return conn = null;
        }
    }


}
