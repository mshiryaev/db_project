using System;
using System.Windows.Forms;
using TestDb.Common;

namespace TestDb
{
    public partial class AddProperty : BaseForm
    {
        public AddProperty()
        {
            InitializeComponent();
        }

        private void CreateProperty_Click(object sender, EventArgs e)
        {
            if (PropertyDescription.Text.Trim().Length == 0)
            {
                MessageBox.Show("Некорректно заполнены поля");
                return;
            }
            var property = new Db.Properties {Description = PropertyDescription.Text};
            DbContext.Properties.InsertOnSubmit(property);
            DbContext.SubmitChanges();
            Close();
        }
    }
}
