using CapaBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDPersonas
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ddlSexo.Items.Add(new ListItem("Seleccione", "0"));
                ddlSexo.Items.Add(new ListItem("Masculino", "M"));
                ddlSexo.Items.Add(new ListItem("Femenino", "F"));

                if (Request.QueryString["IdUsuario"] != null)
                {
                    hdfId.Value = Request.QueryString["IdUsuario"];

                    svrPersona.IsvcPersonaClient client = new svrPersona.IsvcPersonaClient();
                    PersonaBO objPersona = client.Consultar(int.Parse(hdfId.Value)).First();

                    txtNombre.Text = objPersona.Nombre;
                    cldFechaNacimiento.SelectedDate = objPersona.FechaNacimiento;
                    ddlSexo.SelectedValue = objPersona.Sexo.ToString();

                    btnRegistrar.Text = "Actualizar";
                }
                else
                    btnRegistrar.Text = "Insertar";
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            svrPersona.IsvcPersonaClient client = new svrPersona.IsvcPersonaClient();
            PersonaBO objPersona = new PersonaBO();

            if (hdfId.Value == "")
            {
                objPersona.Nombre = txtNombre.Text;
                objPersona.FechaNacimiento = cldFechaNacimiento.SelectedDate;
                objPersona.Sexo = char.Parse(ddlSexo.SelectedValue);
                client.Insertar(objPersona);
                ScriptManager.RegisterStartupScript(Page, typeof(Page), "MensajeExitoso", "alert('Se ha registrado correctamente')", true);
                Limpiar();
            }
            else
            {
                objPersona.IdPersona = int.Parse(hdfId.Value);
                objPersona.Nombre = txtNombre.Text;
                objPersona.FechaNacimiento = cldFechaNacimiento.SelectedDate;
                objPersona.Sexo = char.Parse(ddlSexo.SelectedValue);
                client.Actualizar(objPersona);
                ScriptManager.RegisterStartupScript(Page, typeof(Page), "MensajeExitoso", "alert('Se ha actualizado correctamente')", true);
            }

        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            cldFechaNacimiento.SelectedDate = DateTime.Today;
            ddlSexo.SelectedValue = "0";
        }
    }
}