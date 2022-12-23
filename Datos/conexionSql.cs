using MySql.Data;
namespace Datos
{
    public class conexionSql
    {
        static string conexion = "server=localhost;port=3306;uid=root;pwd='';database=restauranttest";
        SqlConnection conn = new SqlConnection(conexion);
    }
}