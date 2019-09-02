using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Models;

namespace UI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                var d = new List<ClienteModel>();
                var c1 = new ClienteModel() { Nome = "jeff1", CPF = "655g61", RG = "515d4651", Telefone = "65165s51" };
                var c2 = new ClienteModel() { Nome = "jeff2", CPF = "6f5561", RG = "5154f651", Telefone = "65m16551" };
                var c3 = new ClienteModel() { Nome = "jeff3", CPF = "6556k1", RG = "5154d651", Telefone = "65165k51" };
                d.Add(c1);
                d.Add(c2);
                d.Add(c3);
                gridClientes.DataSource = d.ToList();//Popular grid;
                gridClientes.DataBind();
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pages/Consultar.aspx");
        }
    }
}