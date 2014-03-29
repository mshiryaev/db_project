using System;
using System.Linq;
using System.Windows.Forms;
using TestDb.Common;

namespace TestDb
{
    public partial class CloseRent : BaseForm
    {
        private readonly MainForm _mainForm;
        public CloseRent(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void ReturnCar_Click(object sender, EventArgs e)
        {
            if (BadState.Checked && BadStatePenalty.Value < 0)
            {
                MessageBox.Show("Некорректно заполнены поля");
                return;
            }
            var selectedRent = _mainForm.RentTable.SelectedRows[0];
            var rentId = Convert.ToInt32(selectedRent.Cells["RentId"].Value);
            var rent = DbContext.Rents.FirstOrDefault(r => r.RentID == rentId);
            var car = DbContext.Cars.FirstOrDefault(c => c.CarID == rent.CarID);
            var client = DbContext.Clients.FirstOrDefault(c => c.ClientID == rent.ClientID);
            var penaltyCount = DbContext.Penalties.Count(p => p.ClientID == rent.ClientID);

            var overDays = (ReturnDate.Value - rent.RentStop).Days;

            if (overDays > 0 || BadState.Checked)
            {
                if (penaltyCount == 0)
                {
                    var warnPenalty = new Db.Penalties { ClientID = rent.ClientID, RentID = rentId, Sum = 0.0, Type = (int)PenaltyType.Warning};
                    DbContext.Penalties.InsertOnSubmit(warnPenalty);
                    DbContext.SubmitChanges();
                }
                else
                {
                    var moneyPenaltySum = 0.0;

                    if (overDays > 0)
                    {
                        moneyPenaltySum += car.DailyCost * overDays + (ReturnDate.Value - rent.RentStart).Days * 0.1;
                    }

                    if (BadState.Checked)
                    {
                        moneyPenaltySum += Convert.ToDouble(BadStatePenalty.Value);
                    }
                    var moneyPenalty = new Db.Penalties { ClientID = rent.ClientID, RentID = rentId, Sum = moneyPenaltySum, Type = (int)PenaltyType.Money };
                    DbContext.Penalties.InsertOnSubmit(moneyPenalty);
                    DbContext.SubmitChanges();
                }
            }

            var penalty = DbContext.Penalties.FirstOrDefault(p => p.RentID == rentId);
            var penaltySum = (penalty != null) ? penalty.Sum : 0.0;
            var totalCost = ((rent.RentStop - rent.RentStart).Days + 1) * car.DailyCost * (1 - client.Discount / 100) + penaltySum;
            var payment = new Db.Payments {ClientID = rent.ClientID, RentID = rentId, TotalCost = (double)totalCost};
            DbContext.Payments.InsertOnSubmit(payment);
            DbContext.SubmitChanges();

            Close();
        }

        private void BadState_CheckedChanged(object sender, EventArgs e)
        {
            if (BadState.Checked)
            {
                BadStatePenalty.Visible = true;
                BadStatePenaltyLabel.Visible = true;
            }
            else
            {
                BadStatePenalty.Visible = false;
                BadStatePenaltyLabel.Visible = false;
            }
        }
    }
}
