using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppAssignment11
{
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-MFQ8M0P;Database=ContentDB;Trusted_Connection=true;");
                SqlCommand cmd = new SqlCommand("Select * From Articles", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                ArticleTbl.DataSource = ds;
                ArticleTbl.DataBind();
            }
            catch (Exception ex)
            {
                Lbl.Text = ex.Message;
            }
        }
    }
}