using System.Windows.Forms;
using Db;

namespace TestDb.Common
{
    public class BaseForm : Form
    {
        protected CarRental DbContext = new CarRental("Server=localhost; Database=car_rental; User Id=postgres; Password=1; DbLinqProvider=PostgreSql; DbLinqConnectionType=Npgsql.NpgsqlConnection, Npgsql, Version=2.0.6.0, Culture=neutral, PublicKeyToken=5d8b90d52f46fda7");
    }
}
