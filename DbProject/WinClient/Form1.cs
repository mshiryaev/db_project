using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDb
{
    public partial class Form1 : Form
    {
        private CarRental db = new CarRental("Server=localhost; Database=car_rental; User Id=postgres; Password=1; DbLinqProvider=PostgreSql; DbLinqConnectionType=Npgsql.NpgsqlConnection, Npgsql, Version=2.0.6.0, Culture=neutral, PublicKeyToken=5d8b90d52f46fda7");
        public Form1()
        {
            InitializeComponent();
            db.Clients.InsertOnSubmit(new Clients { Name = "QQQ", Lastname= "WWW", Middlename = "EEE", PassportData = "SSS", Telephone = "+435345", Discount = 5.5});
            db.SubmitChanges();
            var users = db.Clients.Select(c => c).ToList();
            foreach (var user in users)
            {
                CarTable.Rows.Add(user.Name, user.Lastname, user.Middlename, user.Discount);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
