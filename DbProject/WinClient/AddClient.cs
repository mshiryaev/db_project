using System;
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
