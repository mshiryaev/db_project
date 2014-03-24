using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Db;
using TestDb.Common;

namespace TestDb
{
    public partial class MainForm : BaseForm
    {
        private enum CarFilter
        {
            All = 0,
            InRent,
            NotInRent,
            Popular
        }

        private enum ClientFilter
        {
            All = 0,
            Frequent,
            Profitable
        }

        public class CarInfo
        {
            public int Id { get; set; }
            public string Brand { get; set; }
        }

        public class ClientInfo
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class PropertyInfo
        {
            public int Id { get; set; }
            public string Description { get; set; }
        }


        public MainForm()
        {
            InitializeComponent();

            RefreshCarTable();
            RefreshPropertyTable();
            RefreshClientTable();
            RefreshRentTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RefreshClientTable(ClientFilter filter = ClientFilter.All)
        {
            ClientTable.Rows.Clear();
            var clients = new List<Clients>();

            switch (filter)
            {
                case ClientFilter.Frequent:
                    /*clients =
                        DbContext.Clients.Join(DbContext.Rents, c => c.ClientID, r => r.ClientID,
                                               (c, r) =>
                                               new
                                                   {
                                                       c.ClientID,
                                                       c.Name,
                                                       c.Lastname,
                                                       c.Middlename,
                                                       c.PassportData,
                                                       c.Telephone,
                                                       c.Discount
                                                   }).ToList();*/
                    break;
                case ClientFilter.Profitable:
                    break;
                case ClientFilter.All:
                    clients = DbContext.Clients.Select(c => c).ToList();
                    break;
            }

            foreach (var client in clients)
            {
                ClientTable.Rows.Add(client.ClientID, client.Name, client.Lastname, client.Middlename, client.PassportData, client.Telephone, client.Discount);
            }
            ClientTable.Refresh();
        }

        private void RefreshPropertyTable()
        {
            PropertyTable.Rows.Clear();
            var properties = DbContext.Properties.Select(p => p).ToList();
            foreach (var prop in properties)
            {
                PropertyTable.Rows.Add(prop.PropertyID, prop.Description);
            }
            PropertyTable.Refresh();
        }

        private void RefreshCarTable(CarFilter filter = CarFilter.All)
        {
            CarTable.Rows.Clear();
            var cars = new List<Cars>();

            switch (filter)
            {
                case CarFilter.All:
                    cars = DbContext.Cars.ToList();
                    break;
                case CarFilter.InRent:
                case CarFilter.NotInRent:
                    {
                        var closedRentIds = DbContext.Payments.Select(p => p.RentID).ToArray();
                        var inRentCarIds = new List<int>();
                        if (closedRentIds.Any())
                            inRentCarIds = DbContext.Rents.Where(r => !closedRentIds.Contains(r.RentID)).Select(r => r.CarID).ToList();

                        switch (filter)
                        {
                            case CarFilter.InRent:
                                if (!inRentCarIds.Any())
                                    break;
                                cars = DbContext.Cars.Where(c => inRentCarIds.ToArray().Contains(c.CarID)).ToList();
                                break;
                            case CarFilter.NotInRent:
                                if (!inRentCarIds.Any())
                                    cars = DbContext.Cars.ToList();
                                else
                                    cars = DbContext.Cars.Where(c => !inRentCarIds.ToArray().Contains(c.CarID)).ToList();
                                break;
                        }
                    }
                    break;
                case CarFilter.Popular:
                    {
                        //var avg =
                         //   DbContext.Rents.GroupBy(r => r.CarID)
                          //           .Select(r => new { Avg = r.Average(rent => rent.) })
                           //          .Select(r => new { r })
                            //         .ToList();
                        var popularCarIds =
                            DbContext.Rents.GroupBy(r => r.CarID)
                                     .Select(r => new {CarId = r.Key, Count = r.Count() })
                                     //.Where(r => r.Count > )
                                     .ToList();
                    }
                    break;
            }

            foreach (var car in cars)
            {
                var propertyIds = DbContext.Property2car.Where(p => p.CarID == car.CarID).Select(p => p.PropertyID).ToArray();

                var carProperties = "";

                if (propertyIds.Any())
                {
                    var propertyDescriptions =
                        DbContext.Properties.Where(p => propertyIds.Contains(p.PropertyID))
                                 .Select(p => p.Description)
                                 .ToList();
                    carProperties = propertyDescriptions.Aggregate("", (current, descr) => current + (descr + ", "));
                }
                CarTable.Rows.Add(car.CarID, car.Brand, car.Cost, car.DailyCost, carProperties);
            }
            CarTable.Refresh();
        }

        private void RefreshRentTable()
        {
            RentTable.Rows.Clear();
            var rents = DbContext.Rents.Select(r => r).ToList();
            foreach (var rent in rents)
            {
                var client =
                    DbContext.Clients.Where(c => c.ClientID == rent.ClientID)
                             .Select(c => new {c.Name, c.Lastname})
                             .FirstOrDefault();

                var car =
                    DbContext.Cars.Where(c => c.CarID == rent.CarID)
                             .Select(c => c.Brand)
                             .FirstOrDefault();

                if (client != null && car != null)
                    RentTable.Rows.Add(rent.RentID, car,
                        client.Lastname + " " + client.Name,
                        rent.RentStart.ToString(CultureInfo.InvariantCulture),
                        rent.RentStop.ToString(CultureInfo.InvariantCulture));
            }
            RentTable.Refresh();
        }

        private void ChangeVisibleForNewPreference()
        {
            AddRentBox.Visible = false;
            AddPreferenceBox.Enabled = true;
        }

        // event handlers

        private void AddProperty_Click(object sender, EventArgs e)
        {
            var addProperty = new AddProperty();
            addProperty.ShowDialog();
            RefreshPropertyTable();
        }

        private void RemoveProperty_Click(object sender, EventArgs e)
        {
            for (var row = 0; row < PropertyTable.SelectedRows.Count; ++row)
            {
                var prop = new Properties
                {
                    PropertyID = Convert.ToInt32(PropertyTable.SelectedRows[row].Cells["PropertyId"].Value)
                };
                DbContext.Properties.DeleteOnSubmit(prop);
            }
            DbContext.SubmitChanges();
            RefreshPropertyTable();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            var addClient = new AddClient();
            addClient.ShowDialog();
            RefreshClientTable();
        }

        private void RemoveClient_Click(object sender, EventArgs e)
        {
            for (var row = 0; row < ClientTable.SelectedRows.Count; ++row)
            {
                var client = new Clients
                {
                    ClientID = Convert.ToInt32(ClientTable.SelectedRows[row].Cells["ClientId"].Value)
                };
                DbContext.Clients.DeleteOnSubmit(client);
            }
            DbContext.SubmitChanges();
            RefreshClientTable();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            var addCar = new AddCar();
            addCar.ShowDialog();
            RefreshCarTable();
        }

        private void RemoveCar_Click(object sender, EventArgs e)
        {
            for (var row = 0; row < CarTable.SelectedRows.Count; ++row)
            {
                var car = new Cars
                {
                    CarID = Convert.ToInt32(CarTable.SelectedRows[row].Cells["CarId"].Value)
                };
                DbContext.Cars.DeleteOnSubmit(car);
            }
            DbContext.SubmitChanges();
            RefreshCarTable();
        }

        private void CarsInRent_CheckedChanged(object sender, EventArgs e)
        {
            if (CarsInRent.Enabled)
                RefreshCarTable(CarFilter.InRent);
        }

        private void CarsNotInRent_CheckedChanged(object sender, EventArgs e)
        {
            if (CarsNotInRent.Enabled)
                RefreshCarTable(CarFilter.NotInRent);
        }

        private void AllCars_CheckedChanged(object sender, EventArgs e)
        {
            if (AllCars.Enabled)
                RefreshCarTable(CarFilter.All);
        }

        private void PopularCars_CheckedChanged(object sender, EventArgs e)
        {
            if (PopularCars.Enabled)
                RefreshCarTable(CarFilter.Popular);
        }

        private void CreatePreference_Click(object sender, EventArgs e)
        {
            var preference = new Preferences
            {
                ClientID = (RequestClients.SelectedItem as ClientInfo).Id,
                Brand = RequestBrand.Text,
                RentStart = RequestStart.Value,
                RentStop = RequestStop.Value,
                MaxDailyCost = Convert.ToDouble(RequestMaxDailyCost.Value)
            };
            DbContext.Preferences.InsertOnSubmit(preference);
            DbContext.SubmitChanges();

            var property2Preference = new List<int>();
            foreach (var item in RequestCarProperties.SelectedItems)
            {
                var p2p = new Property2preference { PreferenceID = preference.PreferenceID, ProrertyID = (item as PropertyInfo).Id };
                DbContext.Property2preference.InsertOnSubmit(p2p);
                property2Preference.Add(p2p.ProrertyID);
            }
            DbContext.SubmitChanges();

            AddRentBox.Visible = true;
            AddPreferenceBox.Enabled = false;

            PreferenceId.Text = preference.PreferenceID.ToString(CultureInfo.InvariantCulture);

            var client = DbContext.Clients.FirstOrDefault(c => c.ClientID == preference.ClientID);

            // Поиск автомобилей по предпочтениям
            var matchedCars = DbContext.Cars.ToList().
                Where(c => c.Brand == preference.Brand && c.DailyCost <= preference.MaxDailyCost).
                Select(car => new CarInfo { Id = car.CarID, Brand = car.Brand }).
                ToList();

            var carToRemove = new List<int>();
            foreach (var car in matchedCars)
            {
                var properties = DbContext.Property2car.Where(p => p.CarID == car.Id).Select(p => p.PropertyID).ToList();
                foreach (var prop in property2Preference)
                {
                    if (!properties.Contains(prop))
                    {
                        carToRemove.Add(car.Id);
                        break;
                    }
                }
            }
            if (carToRemove.Any())
                matchedCars = matchedCars.Where(c => !carToRemove.ToArray().Contains(c.Id)).ToList();

            //TODO: поискать по времени
            // </> Поиск автомобилей по предпочтениям

            if (!matchedCars.Any())
            {
                MatchedCarBox.Visible = false;
                NoMatchedCars.Visible = true;
            }
            else
            {
                MatchedCarBox.Visible = true;
                NoMatchedCars.Visible = false;
            }

            MatchedCars.DisplayMember = "Brand";
            MatchedCars.DataSource = matchedCars;

        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tabs.SelectedIndex == 4)
            {
                var clients = DbContext.Clients.ToList().Select(client => new ClientInfo
                    {
                        Id = client.ClientID, Name = client.Lastname + " " + client.Name + " " + client.Middlename
                    }).ToList();
                RequestClients.DisplayMember = "Name";
                RequestClients.DataSource = clients;

                var properties = DbContext.Properties.ToList().Select(property => new PropertyInfo { Id = property.PropertyID, Description = property.Description }).ToList();
                RequestCarProperties.DisplayMember = "Description";
                RequestCarProperties.DataSource = properties;
            }
        }

        private void CloseRent_Click(object sender, EventArgs e)
        {
            var closeRent = new CloseRent();
            closeRent.ShowDialog();
        }

        private void AddRent_Click(object sender, EventArgs e)
        {
            var rent = new Rents
                {
                    CarID = (MatchedCars.SelectedItem as CarInfo).Id,
                    ClientID = (RequestClients.SelectedItem as ClientInfo).Id,
                    PreferenceID = Convert.ToInt32(PreferenceId.Text),
                    RentStart = RequestStart.Value,
                    RentStop = RequestStop.Value
                };
            DbContext.Rents.InsertOnSubmit(rent);
            DbContext.SubmitChanges();
            RefreshRentTable();
            ChangeVisibleForNewPreference();
        }

        private void AddNewPreference_Click(object sender, EventArgs e)
        {
            ChangeVisibleForNewPreference();
        }

        private void CalculateProfit_Click(object sender, EventArgs e)
        {
            var profit = DbContext.Payments.Select(p => p.TotalCost).DefaultIfEmpty(0.0).Sum();
            ProfitLabel.Text = profit.ToString(CultureInfo.InvariantCulture);
        }
    }
}
