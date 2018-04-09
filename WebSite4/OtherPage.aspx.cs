using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



public partial class OtherPage : System.Web.UI.Page
{
    String m1;
    String m2;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        m1=Request.QueryString["m1"];
        m2 = m1.ToString().Trim();
        Response.Write(m2);
        if (!this.IsPostBack)
        {
            this.BindGrid();
        }

    }
    private void BindGrid()
    {
        //string m1 = Request["meaning"];
        
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            //m1 = "dream";
                using (SqlCommand cmd = new SqlCommand("SELECT tblSenses.WordText,tblSynsets.Gloss FROM tblSynsets JOIN tblSenses ON tblSenses.SynsetID=tblSynsets.ID AND WordText =@dufus"))
                {
                    cmd.Parameters.AddWithValue("@dufus", m2);
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            
        }
    }
    
    }