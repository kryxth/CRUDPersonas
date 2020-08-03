using CapaBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CapaNegocio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IsvcPersona
    {

        [OperationContract]
        void Insertar(PersonaBO pPersona);

        [OperationContract]
        void Actualizar(PersonaBO pPersona);

        [OperationContract]
        void Eliminar(int pIdPersona);

        [OperationContract]
        List<PersonaBO> Consultar(int? pIdPersona = null);

    }


}
