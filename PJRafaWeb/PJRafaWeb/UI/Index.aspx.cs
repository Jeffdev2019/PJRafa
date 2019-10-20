using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UI.Models;
using UI.ServiceCliente;

namespace UI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ServiceCliente.ServiceClienteClient.
                ServiceCliente.ServiceClienteClient.
                
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