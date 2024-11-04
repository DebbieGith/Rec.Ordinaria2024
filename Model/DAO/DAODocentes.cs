using Refuerzo2024.Model.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuerzo2024.Model.DAO
{
    internal class DAODocentes : DTODocentes
    {
        //Variable con la Conexión
        SqlConnection con = obtenerConexion();


        public DataSet ObtenerDocente()
        {
            try
            {
                string query = "SELECT * FROM Docentes";
                SqlCommand cmdObtener = new SqlCommand(query, con);
                cmdObtener.ExecuteScalar();
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmdObtener);
                adp.Fill(ds, "Docentes");
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }


        public bool AgregarDocente () 
        {
            try
            {
                string query = "INSERT INTO Docentes VALUES (@param1, @param2, @param3)";
                SqlCommand cmdInsert = new SqlCommand(query, con);
                cmdInsert.Parameters.AddWithValue("param1", NombreDocente);
                cmdInsert.Parameters.AddWithValue("param2", ApellidoDocente);
                cmdInsert.Parameters.AddWithValue("param3", Dui);
                cmdInsert.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool ActualizarDocente()
        {
            try
            {
                //Crea la instrucción de lo que se quiere hacer
                string query = "UPDATE Docentes SET nombreDocente = @nombreDocente,  apellidoDocente = @apellidoDocente, dui = @dui WHERE idDocente = @idDocente";
                //Crea el comando con la instrucción y la conexión
                SqlCommand cmdUpdate = new SqlCommand(query, con);
                cmdUpdate.Parameters.AddWithValue("nombreDocente", NombreDocente);
                cmdUpdate.Parameters.AddWithValue("apellidoDocente", ApellidoDocente);
                cmdUpdate.Parameters.AddWithValue("dui", Dui);
                cmdUpdate.Parameters.AddWithValue("idDocente", IdDocente);

                //Ejecuta la instrucciones
                cmdUpdate.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally 
            { 
                con.Close(); 
            }
        }

        public bool EliminarDocente()
        {
            try
            {
                string query = "DELETE FROM Docentes WHERE idDocente = @param1";
                SqlCommand cmdDelete = new SqlCommand(query, con);
                cmdDelete.Parameters.AddWithValue("param1", IdDocente);
                cmdDelete.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataSet BuscarDocente(string valor)
        {
            try
            {
                string query = "SELECT * FROM Docentes WHERE nombreDocente LIKE @param1 OR idDocente LIKE @param2 OR dui LIKE @param3";
                SqlCommand cmdObtener = new SqlCommand(query, con);
                cmdObtener.Parameters.AddWithValue("param1", "%" + valor + "%");
                cmdObtener.Parameters.AddWithValue("param2", "%" + valor + "%");
                cmdObtener.Parameters.AddWithValue("param3", "%" + valor + "%");
                cmdObtener.ExecuteScalar();
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmdObtener);
                adp.Fill(ds, "Docentes");
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
