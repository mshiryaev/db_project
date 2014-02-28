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
        private Test db = new Test("Server=localhost; Database=test; User Id=postgres; Password=1; DbLinqProvider=PostgreSql; DbLinqConnectionType=Npgsql.NpgsqlConnection, Npgsql, Version=2.0.6.0, Culture=neutral, PublicKeyToken=5d8b90d52f46fda7");
        public Form1()
        {
            InitializeComponent();
            db.Users.InsertOnSubmit(new Users { GroupID = 10, Username = "Иванов И.В.", Hash = "{0000-0000-0000-00000000-000000000000}"});
            db.SubmitChanges();
            var users = db.Users.Select(u => u).ToList();
            foreach (var user in users)
            {
                userTable.Rows.Add(user.UserID, user.GroupID, user.Username, user.Hash);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
