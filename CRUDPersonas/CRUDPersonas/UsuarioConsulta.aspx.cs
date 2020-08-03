using CapaBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDPersonas
{
    public partial class UsuarioConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                hdfId.Value = Request.QueryString["IdUsuario"];

                svrPersona.IsvcPersonaClient client = new svrPersona.IsvcPersonaClient();
                List<PersonaBO> lsPersonas = client.Consultar(null).ToList();
                grvPersonas.DataSource = lsPersonas;
                grvPersonas.DataBind();
            }
        }

        protected void grvPersonas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            string id = Convert.ToString(this.grvPersonas.DataKeys[rowIndex]["IdPersona"]);

            if (e.CommandName == "Editar")
                Response.Redirect("Usuario.aspx?IdUsuario=" + id);
            

            if (e.CommandName == "Eliminar")
            {
                svrPersona.IsvcPersonaClient client = new svrPersona.IsvcPersonaClient();
                client.Eliminar(Convert.ToInt32(id));
                grvPersonas.DataSource = client.Consultar(null);
                grvPersonas.DataBind();
            }
        }

        protected void lnkNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuario.aspx");
        }
    }
}