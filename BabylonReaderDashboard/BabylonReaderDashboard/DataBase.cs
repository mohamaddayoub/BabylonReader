using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraBars.Objects;
using System.Threading;
using DevExpress.XtraEditors;

namespace BabylonReaderDashboard
{
    internal class DataBase
    {
       static string serverIP = "";
       static string databaseName = "";
       static string userid = "";
       static string password = "";
       static string connectionString = "";
        public DataBase() { }
        public DataBase(string serverIp, string datbaseName, string userId, string pass)
        {
            serverIP = serverIp;
            databaseName = datbaseName;
            userid = userId;
            password = pass;
            connectionString = $"server={serverIP};DataBase={databaseName}; User Id={userId}; Password={password};";
        }
        public bool checkConnection()
        {
            if (serverIP != "")
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                    }
                    return true;
                }
                catch
                {
                    string title = "", msg = "";
                    if (Thread.CurrentThread.CurrentCulture.ToString() == "en") { title = "Sorry"; msg = "There is a connection error"; }
                    else { title = "عذرا"; msg = "هناك خطأ في الاتصال"; }
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else return false;
        }
        private void Open()
        {
            SqlConnection con = new SqlConnection(connectionString);
            if (con.State == ConnectionState.Closed) con.Open();
        }
        private DataTable executeQuery(string query)
        {
            if (!checkConnection()) return null;
            DataTable dtKeys = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                    {

                        sda.Fill(dtKeys);
                        if (dtKeys.Rows.Count > 0)
                            return dtKeys;
                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }
        }
        public DataTable getKeys()
        {
            string query = "Select * from keys";
            return executeQuery(query);
        }

        public bool generateNewKey(int months)
        {
            if (!checkConnection()) return false;
            string generate = $"SET @NewKey = CONCAT(LEFT(NEWID(), 4), '-{months}',"
                + "LEFT(NEWID(), 3), '-',"
                + "LEFT(NEWID(), 4), '-',"
                + "LEFT(NEWID(), 4)) ";

            string query = "DECLARE @NewKey VARCHAR(19) "
                  + generate
                  + "WHILE EXISTS (SELECT * FROM keys WHERE Product_key = @NewKey) BEGIN "
                  + generate
                  + " End "
                  + $"INSERT INTO keys VALUES (@NewKey, null, {months}, null, null)";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void selectMessageLanguage (ref string title, ref string msg)
        {
            if (Thread.CurrentThread.CurrentUICulture.ToString() == "en")
            {
                title = "Sorry";
                msg = "The key is not found.";
            }else
            {
                title = "عذرا";
                msg = ".المفتاح غير موجود";
            }
        }
        public DataTable searchAboutKey(string key)
        {
            string query = $"Select * from keys where Product_Key = {key}";

            DataTable dt = executeQuery(query);
            if (dt != null) return dt;
            else
            {
                string title = "", msg = "";
                selectMessageLanguage(ref title, ref msg);
                MessageBox.Show(msg,title,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return null;
            }
        }
    }
}
