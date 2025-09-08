using AccSamse._1._2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AccSamse._1._2.controllers
{
    internal class EmployeersController
    {
        // 🔹 Crear empleado
        public void AddEmployee(string name, string lastName, string email, string rol, bool status)
        {
            try
            {
                SqlConnection conn = ConexionDataBase.GetConnection();
                string query = "INSERT INTO Employeers (Name, Last_Name, Email, Rol, Status) " +
                               "VALUES (@Name, @LastName, @Email, @Rol, @Status)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Rol", rol);
                cmd.Parameters.AddWithValue("@Status", status);

                cmd.ExecuteNonQuery();
                Console.WriteLine("✅ Empleado agregado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al agregar empleado: " + ex.Message);
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

        // 🔹 Obtener empleados
        public void GetEmployees()
        {
            try
            {
                SqlConnection conn = ConexionDataBase.GetConnection();
                string query = "SELECT * FROM Employeers";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Id_Employee"]} - {reader["Name"]} {reader["Last_Name"]}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al obtener empleados: " + ex.Message);
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

        // 🔹 Actualizar empleado
        public void UpdateEmployee(int id, string name, string lastName, string email, string rol, bool status)
        {
            try
            {
                SqlConnection conn = ConexionDataBase.GetConnection();
                string query = "UPDATE Employeers SET Name=@Name, Last_Name=@LastName, Email=@Email, Rol=@Rol, Status=@Status " +
                               "WHERE Id_Employee=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Rol", rol);
                cmd.Parameters.AddWithValue("@Status", status);

                cmd.ExecuteNonQuery();
                Console.WriteLine("✅ Empleado actualizado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al actualizar empleado: " + ex.Message);
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

        // 🔹 Eliminar empleado
        public void DeleteEmployee(int id)
        {
            try
            {
                SqlConnection conn = ConexionDataBase.GetConnection();
                string query = "DELETE FROM Employeers WHERE Id_Employee=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
                Console.WriteLine("✅ Empleado eliminado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error al eliminar empleado: " + ex.Message);
            }
            finally
            {
                ConexionDataBase.CloseConnection();
            }
        }

    }
}
