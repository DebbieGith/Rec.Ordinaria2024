using Refuerzo2024.Model.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    }
}
