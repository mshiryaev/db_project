using System;
using System.Windows.Forms;
using TestDb.Common;

namespace TestDb
{
    public partial class AddClient : BaseForm
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void CreateClient_Click(object sender, EventArgs e)
        {
            if (ClientName.Text.Trim().Length == 0 ||
                ClientLastName.Text.Trim().Length == 0 ||
                ClientTelephone.Text.Trim().Length == 0 ||
                ClientPassportData.Text.Trim().Length == 0 ||
                ClientDiscount.Value < 0)
            {
                MessageBox.Show("Некорректно заполнены поля");
                return;
            }

            var client = new Db.Clients { Name = ClientName.Text,
                Lastname = ClientLastName.Text,
                Middlename = ClientMiddleName.Text,
                PassportData = ClientPassportData.Text,
                Telephone = ClientTelephone.Text,
                Discount = Convert.ToDouble(ClientDiscount.Value)
            };

            DbContext.Clients.InsertOnSubmit(client);
            DbContext.SubmitChanges();
            Close();
        }
    }
}
