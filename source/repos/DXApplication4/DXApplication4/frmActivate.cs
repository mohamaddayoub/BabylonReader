using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace DXApplication4
{
    public partial class frmActivate : Form
    {
        string connectionString = $"Server=192.168.1.104; DataBase=BabylonReader; User Id=BabylonReader; password=aa1bb2cc3dd4567890;";
        public frmActivate()
        {
            InitializeComponent();
        }
        private string getSerialNumber()
        {
            string machineID = string.Empty;
            try
            {
                ManagementClass managementClass = new ManagementClass("Win32_ComputerSystemProduct");
                ManagementObjectCollection managementObjects = managementClass.GetInstances();

                foreach (ManagementObject managementObject in managementObjects)
                {
                    machineID = managementObject["UUID"].ToString().Trim();
                    break;
                }
            }
            catch
            {
                throw;
            }
            return machineID;
        }
        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = $"select * from keys where Product_Key = '{txtKey.Text}'";
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                    {
                        if (con.State != ConnectionState.Open) con.Open();
                        sda.Fill(dt);
                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                string SerialNumber = getSerialNumber();
                                if (dt.Rows[0][1] != null)
                                {
                                    if (dt.Rows[0][1].ToString() == SerialNumber) activate(false, dt.Rows[0][0].ToString());
                                    else  errorMessage();
                                }
                                else activate(true, dt.Rows[0][0].ToString(), SerialNumber);
                                return;
                            }
                        }
                        errorMessage();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void errorMessage()
        {
            string msg, title;
            if (Thread.CurrentThread.CurrentUICulture.ToString() == "en")
            {
                msg = "The key is incorrect!";
                title = "Sorry";
            }
            else
            {
                msg = ".الفتاح غير صحيح";
                title = "عذرا";
            }
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void activate(bool IsNewKey,string productKey ,string months = "6", string Serial="")
        {
            if (IsNewKey)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = $"update Keys set Serial_Number='{Serial}', Start_Date='{DateTime.Now}', End_Date = '{DateTime.Now.AddMonths(int.Parse(months))}' where Product_Key = '{productKey}'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {

            }
        }
    }
}
