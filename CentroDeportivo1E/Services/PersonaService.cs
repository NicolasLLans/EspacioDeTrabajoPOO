using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroDeportivo1E.Services
{
    internal class PersonaService
    {
        private readonly ConexionMysql conexionMysql = ConexionMysql.getInstance();



        public bool ExistePersona(long dni)
        {
            bool existe = false;
            try
            {
                MySqlConnection conexion = conexionMysql.AbrirConexion();
                string procedimiento = "ExistePersona";

                using (conexion)
                {
                    MySqlCommand comando = new MySqlCommand(procedimiento, conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_dni", dni);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            existe = reader.GetInt32(0) > 0;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al verificar existencia de socio: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al verificar existencia de socio: " + ex.Message);
            }
            finally
            {
                conexionMysql.CerrarConexion();
            }

            return existe;
        }
    }
}
