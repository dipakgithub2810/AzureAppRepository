using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.ServiceModel;

namespace WebApplication11
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string text;

            ServiceReference1.Service1Client tt = new ServiceReference1.Service1Client();

            text=tt.GetMessage("deepak");
            lbl1.Text = text;

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            //SqlConnection con= new SqlConnection("Integrated security=true;Initial Catalog=PrizmProdcution;Data source=LP-5CD6518SPQ");

            SqlConnection con = new SqlConnection("Initial Catalog=mysampleDatabase;User ID=azureuser;Password=Azure1234567;Data source=sqldbserver999.database.windows.net");

            

            SqlCommand cmd;
            con.Open();
            string s = "insert into AzureUser values(@p1,@p2)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@p1", username.Text);
            cmd.Parameters.AddWithValue("@p2", pwd.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show(i + " Row(s) Inserted ");

        }
    }
}