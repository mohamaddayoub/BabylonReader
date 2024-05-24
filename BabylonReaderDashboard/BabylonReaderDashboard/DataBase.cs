using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace BabylonReaderDashboard
{
    internal class DataBase
    {
       static string connectionString = "";

        public DataBase() 
        {
            connectionString = $"server={Environment.GetEnvironmentVariable("SERVERIP")};"
               +$"DataBase={Environment.GetEnvironmentVariable("DATABASENAME")};"
               +$"User Id={Environment.GetEnvironmentVariable("USERID")};"
               +$"Password={Environment.GetEnvironmentVariable("PASSWORD")};";
        }
        public bool checkConnection()
        {
            bool variableExists = !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("SERVERIP"));
            if (variableExists)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    string title = "", msg = "";
                    if (Thread.CurrentThread.CurrentCulture.ToString() == "en") { title = "Sorry"; msg = "There is a connection error"; }
                    else { title = "عذرا"; msg = "هناك خطأ في الاتصال"; }
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else 
            {
                string msg, title;
                if (Thread.CurrentThread.CurrentUICulture.ToString() == "en")
                {
                    title = "Sorry";
                    msg = "Please adjust the database connection settings.";
                }
                else
                {
                    title = "عذرا";
                    msg = ".الرجاء ضبط اعدادات الاتصال بقاعدة البيانات";
                }
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private DataTable executeQuery(string query)
        {
            if (!checkConnection()) return null;
            DataTable dtKeys = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    if (con.State != ConnectionState.Open) con.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                    {

                        sda.Fill(dtKeys);
                        return dtKeys;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    if (con.State != ConnectionState.Open) con.Open();
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
        public DataTable searchAboutKey(string key)
        {
            string query = $"Select * from keys where Product_Key = '{key}'";   

            DataTable dt = executeQuery(query);
            return dt;
        }
    }
}
