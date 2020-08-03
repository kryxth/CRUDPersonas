using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaBO;

namespace CapaDatos
{
    public class Persona : Conexion
    {
        public List<PersonaBO> Consultar(int? pIdPersona = null)
        {
            using (SqlConnection con = AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "proPersonaSeleccionar";
                    if(pIdPersona.HasValue)
                        command.Parameters.AddWithValue("IdPersona", pIdPersona.Value);
                    command.Connection = con;
                    command.ExecuteNonQuery();

                    SqlDataReader reader = command.ExecuteReader();
                    List<PersonaBO> lsPersonas = new List<PersonaBO>();
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            PersonaBO objPersona = new PersonaBO();
                            objPersona.IdPersona = reader.GetInt32(0);
                            objPersona.Nombre = reader.GetString(1);
                            objPersona.FechaNacimiento = reader.GetDateTime(2);
                            objPersona.Sexo = Convert.ToChar(reader.GetString(3));
                            lsPersonas.Add(objPersona);
                        }
                    }
                    return lsPersonas;
                }
                catch
                {
                    throw new Exception("No se ha podido Consultar");
                }
            }
        }

        public void Insertar(PersonaBO pPersona)
        {
            using (SqlConnection con = AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "proPersonaInsertar";
                    command.Parameters.AddWithValue("Nombre", pPersona.Nombre);
                    command.Parameters.AddWithValue("FechaNacimiento", pPersona.FechaNacimiento);
                    command.Parameters.AddWithValue("Sexo", pPersona.Sexo);
                    command.Connection = con;
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw new Exception("No se ha podido insertar");
                }
            }
        }

        public void Actualizar(PersonaBO pPersona)
        {
            using (SqlConnection con = AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "proPersonaActualizar";
                    command.Parameters.AddWithValue("IdPersona", pPersona.IdPersona);
                    command.Parameters.AddWithValue("Nombre", pPersona.Nombre);
                    command.Parameters.AddWithValue("FechaNacimiento", pPersona.FechaNacimiento);
                    command.Parameters.AddWithValue("Sexo", pPersona.Sexo);
                    command.Connection = con;
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    throw new Exception("No se ha podido actualizar");
                }
            }
        }

        public void Eliminar(int IdPersona)
        {
            using (SqlConnection con = AbrirConexion())
            {
                try
                {

                    SqlCommand command = new SqlCommand();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "proPersonaEliminar";
                    command.Parameters.AddWithValue("IdPersona", IdPersona);
                    command.Connection = con;
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw new Exception("No se ha podido eliminar");
                }
            }
        }

    }
}
