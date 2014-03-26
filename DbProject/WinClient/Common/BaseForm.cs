using System.Windows.Forms;
using Db;
using WebPU.DebugUtils;

namespace TestDb.Common
{
    public enum CarFilter
    {
        All = 0,
        InRent,
        NotInRent,
        Popular
    }

    public enum ClientFilter
    {
        All = 0,
        Constant,
        Profitable
    }

    public enum PenaltyType
    {
        Warning = 0,
        Money
    }

    public class CarInfo
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public double DailyCost { get; set; }
    }

    public class ClientInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PropertyInfo
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public class BaseForm : Form
    {
        protected CarRental DbContext = new CarRental("Server=localhost; Database=car_rental; User Id=postgres; Password=1; DbLinqProvider=PostgreSql; DbLinqConnectionType=Npgsql.NpgsqlConnection, Npgsql, Version=2.0.6.0, Culture=neutral, PublicKeyToken=5d8b90d52f46fda7");

        public BaseForm()
        {
#if DEBUG
            DbContext.Log = new DebugTextWriter();
#endif
        }
    }
}
