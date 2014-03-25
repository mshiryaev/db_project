using System;
using TestDb.Common;

namespace TestDb
{
    public partial class CloseRent : BaseForm
    {
        public CloseRent()
        {
            InitializeComponent();
        }

        private void ReturnCar_Click(object sender, EventArgs e)
        {
            // проверить пользователя по штрафам, создать если нужно новый, вычислить окончательную сумму и отобразить ее
            Close();
        }
    }
}
