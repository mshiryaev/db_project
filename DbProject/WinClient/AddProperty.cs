using System;
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
            var property = new Db.Properties {Description = PropertyDescription.Text};
            DbContext.Properties.InsertOnSubmit(property);
            DbContext.SubmitChanges();
            Close();
        }
    }
}
