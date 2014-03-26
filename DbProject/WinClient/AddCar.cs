using System;
using System.Linq;
using System.Windows.Forms;
using TestDb.Common;

namespace TestDb
{
    public partial class AddCar : BaseForm
    {
        public AddCar()
        {
            InitializeComponent();
            var properties = DbContext.Properties.Select(p => p).ToList();
            var data = properties.Select(property => new PropertyInfo {Id = property.PropertyID, Description = property.Description}).ToList();
            CarProperties.DisplayMember = "Description";
            CarProperties.DataSource = data;
        }

        private void CreateCar_Click(object sender, EventArgs e)
        {
            if (CarBrand.Text.Trim().Length == 0 || CarCost.Value < 0 || CarDailyCost.Value < 0)
            {
                MessageBox.Show("Некорректно заполнены поля");
                return;
            }
            var car = new Db.Cars
                {
                    Brand = CarBrand.Text,
                    Cost = Convert.ToDouble(CarCost.Value),
                    DailyCost = Convert.ToDouble(CarDailyCost.Value)
                };
            DbContext.Cars.InsertOnSubmit(car);
            DbContext.SubmitChanges();

            foreach (var item in CarProperties.SelectedItems)
            {
                var prop2car = new Db.Property2car { PropertyID = (item as PropertyInfo).Id, CarID = car.CarID };
                DbContext.Property2car.InsertOnSubmit(prop2car);
            }
            DbContext.SubmitChanges();
            Close();
        }
    }
}
