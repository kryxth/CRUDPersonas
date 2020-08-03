using CapaBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class svcPersona : IsvcPersona
    {
        public void Actualizar(PersonaBO pPersona)
        {
            CapaDatos.Persona objDatos = new Persona();
            objDatos.Actualizar(pPersona);
        }

        public List<PersonaBO> Consultar(int? pIdPersona = null)
        {
            CapaDatos.Persona objDatos = new Persona();
            return objDatos.Consultar(pIdPersona);
        }

        public void Eliminar(int pIdPersona)
        {
            CapaDatos.Persona objDatos = new Persona();
            objDatos.Eliminar(pIdPersona);
        }

        public void Insertar(PersonaBO pPersona)
        {
            CapaDatos.Persona objDatos = new Persona();
            objDatos.Insertar(pPersona);
        }
    }
}
