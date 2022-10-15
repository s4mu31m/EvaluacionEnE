using MySql.Data.MySqlClient;

namespace Prueba_Ene
{
    public class data_user
    {
        public prop_user Login_user(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection SqlCon = new MySqlConnection();
            SqlCon = Conexion.getInstancia().CrearConexion();
            SqlCon.Open();

            string query =
                "select * from usuarios where usuario like @usuario";
            MySqlCommand Comando = new MySqlCommand(query, SqlCon);
            Comando.Parameters.AddWithValue("@usuario", usuario);

            reader = Comando.ExecuteReader();

            prop_user usr = null;

            while (reader.Read())
            {
                usr = new prop_user();
                usr.Id = int.Parse(reader["id_usuario"].ToString());
                usr.password = reader["password"].ToString();
                usr.usuario = reader["nombre_usuario"].ToString();
                usr.id_tipo = int.Parse(reader["id_tipo"].ToString());
            }

            return usr;
        }
    }
}