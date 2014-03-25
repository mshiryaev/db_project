using System;
using System.Linq;
using TestDb.Common;

namespace TestDb
{
    public partial class AddCar : BaseForm
    {
        public AddCar()
        {
            InitializeComponent();
            var properties = DbContext.Properties.Select(p => p).ToList();
            var data = properties.Select(property => new MainForm.PropertyInfo {Id = property.PropertyID, Description = property.Description}).ToList();
            CarProperties.DisplayMember = "Description";
            CarProperties.DataSource = data;
        }

        private void CreateCar_Click(object sender, EventArgs e)
        {
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
                var prop2car = new Db.Property2car { PropertyID = (item as MainForm.PropertyInfo).Id, CarID = car.CarID };
                DbContext.Property2car.InsertOnSubmit(prop2car);
            }
            DbContext.SubmitChanges();
            Close();
        }
    }
}
