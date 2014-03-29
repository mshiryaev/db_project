// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from car_rental on 2014-03-23 15:51:36Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
using System;
using System.ComponentModel;
using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
using DbLinq.Data.Linq;
using DbLinq.Vendor;
#endif  // MONO_STRICT
using System.Data.Linq.Mapping;
using System.Diagnostics;

namespace Db
{
    public partial class CarRental : DataContext
    {

        #region Extensibility Method Declarations
        partial void OnCreated();
        #endregion


        public CarRental(string connectionString) :
            base(connectionString)
        {
            this.OnCreated();
        }

        public CarRental(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            this.OnCreated();
        }

        public CarRental(IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            this.OnCreated();
        }

        public Table<Cars> Cars
        {
            get
            {
                return this.GetTable<Cars>();
            }
        }

        public Table<Clients> Clients
        {
            get
            {
                return this.GetTable<Clients>();
            }
        }

        public Table<Payments> Payments
        {
            get
            {
                return this.GetTable<Payments>();
            }
        }

        public Table<Penalties> Penalties
        {
            get
            {
                return this.GetTable<Penalties>();
            }
        }

        public Table<Preferences> Preferences
        {
            get
            {
                return this.GetTable<Preferences>();
            }
        }

        public Table<Properties> Properties
        {
            get
            {
                return this.GetTable<Properties>();
            }
        }

        public Table<Property2car> Property2car
        {
            get
            {
                return this.GetTable<Property2car>();
            }
        }

        public Table<Property2preference> Property2preference
        {
            get
            {
                return this.GetTable<Property2preference>();
            }
        }

        public Table<Rents> Rents
        {
            get
            {
                return this.GetTable<Rents>();
            }
        }
    }

    #region Start MONO_STRICT
#if MONO_STRICT

public partial class CarRental
{
	
	public CarRental(IDbConnection connection) : 
			base(connection)
	{
		this.OnCreated();
	}
}
    #region End MONO_STRICT
#endregion
#else     // MONO_STRICT

    public partial class CarRental
    {

        public CarRental(IDbConnection connection) :
            base(connection, new DbLinq.PostgreSql.PgsqlVendor())
        {
            this.OnCreated();
        }

        public CarRental(IDbConnection connection, IVendor sqlDialect) :
            base(connection, sqlDialect)
        {
            this.OnCreated();
        }

        public CarRental(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) :
            base(connection, mappingSource, sqlDialect)
        {
            this.OnCreated();
        }
    }
    #region End Not MONO_STRICT
    #endregion
#endif     // MONO_STRICT
    #endregion

    [Table(Name = "public.cars")]
    public partial class Cars : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _carID;

        private string _brand;

        private double _cost;

        private double _dailyCost;

        private EntitySet<Rents> _rents;

        private EntitySet<Property2car> _property2cAr;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnCarIDChanged();

        partial void OnCarIDChanging(int value);

        partial void OnBrandChanged();

        partial void OnBrandChanging(string value);

        partial void OnCostChanged();

        partial void OnCostChanging(double value);

        partial void OnDailyCostChanged();

        partial void OnDailyCostChanging(double value);
        #endregion


        public Cars()
        {
            _rents = new EntitySet<Rents>(new Action<Rents>(this.Rents_Attach), new Action<Rents>(this.Rents_Detach));
            _property2cAr = new EntitySet<Property2car>(new Action<Property2car>(this.Property2Car_Attach), new Action<Property2car>(this.Property2Car_Detach));
            this.OnCreated();
        }

        [Column(Storage = "_carID", Name = "car_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'car_id_seq\')")]
        [DebuggerNonUserCode()]
        public int CarID
        {
            get
            {
                return this._carID;
            }
            set
            {
                if ((_carID != value))
                {
                    this.OnCarIDChanging(value);
                    this.SendPropertyChanging();
                    this._carID = value;
                    this.SendPropertyChanged("CarID");
                    this.OnCarIDChanged();
                }
            }
        }

        [Column(Storage = "_brand", Name = "brand", DbType = "character varying(40)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Brand
        {
            get
            {
                return this._brand;
            }
            set
            {
                if (((_brand == value)
                            == false))
                {
                    this.OnBrandChanging(value);
                    this.SendPropertyChanging();
                    this._brand = value;
                    this.SendPropertyChanged("Brand");
                    this.OnBrandChanged();
                }
            }
        }

        [Column(Storage = "_cost", Name = "cost", DbType = "double precision", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public double Cost
        {
            get
            {
                return this._cost;
            }
            set
            {
                if ((_cost != value))
                {
                    this.OnCostChanging(value);
                    this.SendPropertyChanging();
                    this._cost = value;
                    this.SendPropertyChanged("Cost");
                    this.OnCostChanged();
                }
            }
        }

        [Column(Storage = "_dailyCost", Name = "daily_cost", DbType = "double precision", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public double DailyCost
        {
            get
            {
                return this._dailyCost;
            }
            set
            {
                if ((_dailyCost != value))
                {
                    this.OnDailyCostChanging(value);
                    this.SendPropertyChanging();
                    this._dailyCost = value;
                    this.SendPropertyChanged("DailyCost");
                    this.OnDailyCostChanged();
                }
            }
        }

        #region Children
        [Association(Storage = "_rents", OtherKey = "CarID", ThisKey = "CarID", Name = "rents_car_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Rents> Rents
        {
            get
            {
                return this._rents;
            }
            set
            {
                this._rents = value;
            }
        }

        [Association(Storage = "_property2cAr", OtherKey = "CarID", ThisKey = "CarID", Name = "property2car_car_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Property2car> Property2Car
        {
            get
            {
                return this._property2cAr;
            }
            set
            {
                this._property2cAr = value;
            }
        }
        #endregion

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #region Attachment handlers
        private void Rents_Attach(Rents entity)
        {
            this.SendPropertyChanging();
            entity.Cars = this;
        }

        private void Rents_Detach(Rents entity)
        {
            this.SendPropertyChanging();
            entity.Cars = null;
        }

        private void Property2Car_Attach(Property2car entity)
        {
            this.SendPropertyChanging();
            entity.Cars = this;
        }

        private void Property2Car_Detach(Property2car entity)
        {
            this.SendPropertyChanging();
            entity.Cars = null;
        }
        #endregion
    }

    [Table(Name = "public.clients")]
    public partial class Clients : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _clientID;

        private string _name;

        private string _lastname;

        private string _middlename;

        private string _passportData;

        private string _telephone;

        private System.Nullable<double> _discount;

        private EntitySet<Preferences> _preferences;

        private EntitySet<Rents> _rents;

        private EntitySet<Penalties> _penalties;

        private EntitySet<Payments> _payments;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnClientIDChanged();

        partial void OnClientIDChanging(int value);

        partial void OnNameChanged();

        partial void OnNameChanging(string value);

        partial void OnLastnameChanged();

        partial void OnLastnameChanging(string value);

        partial void OnMiddlenameChanged();

        partial void OnMiddlenameChanging(string value);

        partial void OnPassportDataChanged();

        partial void OnPassportDataChanging(string value);

        partial void OnTelephoneChanged();

        partial void OnTelephoneChanging(string value);

        partial void OnDiscountChanged();

        partial void OnDiscountChanging(System.Nullable<double> value);
        #endregion


        public Clients()
        {
            _preferences = new EntitySet<Preferences>(new Action<Preferences>(this.Preferences_Attach), new Action<Preferences>(this.Preferences_Detach));
            _rents = new EntitySet<Rents>(new Action<Rents>(this.Rents_Attach), new Action<Rents>(this.Rents_Detach));
            _penalties = new EntitySet<Penalties>(new Action<Penalties>(this.Penalties_Attach), new Action<Penalties>(this.Penalties_Detach));
            _payments = new EntitySet<Payments>(new Action<Payments>(this.Payments_Attach), new Action<Payments>(this.Payments_Detach));
            this.OnCreated();
        }

        [Column(Storage = "_clientID", Name = "client_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'client_id_seq\')")]
        [DebuggerNonUserCode()]
        public int ClientID
        {
            get
            {
                return this._clientID;
            }
            set
            {
                if ((_clientID != value))
                {
                    this.OnClientIDChanging(value);
                    this.SendPropertyChanging();
                    this._clientID = value;
                    this.SendPropertyChanged("ClientID");
                    this.OnClientIDChanged();
                }
            }
        }

        [Column(Storage = "_name", Name = "name", DbType = "character varying(30)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (((_name == value)
                            == false))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [Column(Storage = "_lastname", Name = "lastname", DbType = "character varying(30)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Lastname
        {
            get
            {
                return this._lastname;
            }
            set
            {
                if (((_lastname == value)
                            == false))
                {
                    this.OnLastnameChanging(value);
                    this.SendPropertyChanging();
                    this._lastname = value;
                    this.SendPropertyChanged("Lastname");
                    this.OnLastnameChanged();
                }
            }
        }

        [Column(Storage = "_middlename", Name = "middlename", DbType = "character varying(30)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public string Middlename
        {
            get
            {
                return this._middlename;
            }
            set
            {
                if (((_middlename == value)
                            == false))
                {
                    this.OnMiddlenameChanging(value);
                    this.SendPropertyChanging();
                    this._middlename = value;
                    this.SendPropertyChanged("Middlename");
                    this.OnMiddlenameChanged();
                }
            }
        }

        [Column(Storage = "_passportData", Name = "passport_data", DbType = "character varying(150)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string PassportData
        {
            get
            {
                return this._passportData;
            }
            set
            {
                if (((_passportData == value)
                            == false))
                {
                    this.OnPassportDataChanging(value);
                    this.SendPropertyChanging();
                    this._passportData = value;
                    this.SendPropertyChanged("PassportData");
                    this.OnPassportDataChanged();
                }
            }
        }

        [Column(Storage = "_telephone", Name = "telephone", DbType = "character varying(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                if (((_telephone == value)
                            == false))
                {
                    this.OnTelephoneChanging(value);
                    this.SendPropertyChanging();
                    this._telephone = value;
                    this.SendPropertyChanged("Telephone");
                    this.OnTelephoneChanged();
                }
            }
        }

        [Column(Storage = "_discount", Name = "discount", DbType = "double precision", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public System.Nullable<double> Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                if ((_discount != value))
                {
                    this.OnDiscountChanging(value);
                    this.SendPropertyChanging();
                    this._discount = value;
                    this.SendPropertyChanged("Discount");
                    this.OnDiscountChanged();
                }
            }
        }

        #region Children
        [Association(Storage = "_preferences", OtherKey = "ClientID", ThisKey = "ClientID", Name = "preferences_client_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Preferences> Preferences
        {
            get
            {
                return this._preferences;
            }
            set
            {
                this._preferences = value;
            }
        }

        [Association(Storage = "_rents", OtherKey = "ClientID", ThisKey = "ClientID", Name = "rents_client_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Rents> Rents
        {
            get
            {
                return this._rents;
            }
            set
            {
                this._rents = value;
            }
        }

        [Association(Storage = "_penalties", OtherKey = "ClientID", ThisKey = "ClientID", Name = "penalties_client_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Penalties> Penalties
        {
            get
            {
                return this._penalties;
            }
            set
            {
                this._penalties = value;
            }
        }

        [Association(Storage = "_payments", OtherKey = "ClientID", ThisKey = "ClientID", Name = "payments_client_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Payments> Payments
        {
            get
            {
                return this._payments;
            }
            set
            {
                this._payments = value;
            }
        }
        #endregion

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #region Attachment handlers
        private void Preferences_Attach(Preferences entity)
        {
            this.SendPropertyChanging();
            entity.Clients = this;
        }

        private void Preferences_Detach(Preferences entity)
        {
            this.SendPropertyChanging();
            entity.Clients = null;
        }

        private void Rents_Attach(Rents entity)
        {
            this.SendPropertyChanging();
            entity.Clients = this;
        }

        private void Rents_Detach(Rents entity)
        {
            this.SendPropertyChanging();
            entity.Clients = null;
        }

        private void Penalties_Attach(Penalties entity)
        {
            this.SendPropertyChanging();
            entity.Clients = this;
        }

        private void Penalties_Detach(Penalties entity)
        {
            this.SendPropertyChanging();
            entity.Clients = null;
        }

        private void Payments_Attach(Payments entity)
        {
            this.SendPropertyChanging();
            entity.Clients = this;
        }

        private void Payments_Detach(Payments entity)
        {
            this.SendPropertyChanging();
            entity.Clients = null;
        }
        #endregion
    }

    [Table(Name = "public.payments")]
    public partial class Payments : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _paymentID;

        private int _rentID;

        private double _totalCost;

        private int _clientID;

        private EntityRef<Rents> _rents = new EntityRef<Rents>();

        private EntityRef<Clients> _clients = new EntityRef<Clients>();

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnPaymentIDChanged();

        partial void OnPaymentIDChanging(int value);

        partial void OnRentIDChanged();

        partial void OnRentIDChanging(int value);

        partial void OnTotalCostChanged();

        partial void OnTotalCostChanging(double value);

        partial void OnClientIDChanged();

        partial void OnClientIDChanging(int value);
        #endregion


        public Payments()
        {
            this.OnCreated();
        }

        [Column(Storage = "_paymentID", Name = "payment_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'payment_id_seq\')")]
        [DebuggerNonUserCode()]
        public int PaymentID
        {
            get
            {
                return this._paymentID;
            }
            set
            {
                if ((_paymentID != value))
                {
                    this.OnPaymentIDChanging(value);
                    this.SendPropertyChanging();
                    this._paymentID = value;
                    this.SendPropertyChanged("PaymentID");
                    this.OnPaymentIDChanged();
                }
            }
        }

        [Column(Storage = "_rentID", Name = "rent_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int RentID
        {
            get
            {
                return this._rentID;
            }
            set
            {
                if ((_rentID != value))
                {
                    this.OnRentIDChanging(value);
                    this.SendPropertyChanging();
                    this._rentID = value;
                    this.SendPropertyChanged("RentID");
                    this.OnRentIDChanged();
                }
            }
        }

        [Column(Storage = "_totalCost", Name = "total_cost", DbType = "double precision", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public double TotalCost
        {
            get
            {
                return this._totalCost;
            }
            set
            {
                if ((_totalCost != value))
                {
                    this.OnTotalCostChanging(value);
                    this.SendPropertyChanging();
                    this._totalCost = value;
                    this.SendPropertyChanged("TotalCost");
                    this.OnTotalCostChanged();
                }
            }
        }

        [Column(Storage = "_clientID", Name = "client_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ClientID
        {
            get
            {
                return this._clientID;
            }
            set
            {
                if ((_clientID != value))
                {
                    this.OnClientIDChanging(value);
                    this.SendPropertyChanging();
                    this._clientID = value;
                    this.SendPropertyChanged("ClientID");
                    this.OnClientIDChanged();
                }
            }
        }

        #region Parents
        [Association(Storage = "_rents", OtherKey = "RentID", ThisKey = "RentID", Name = "payments_rent_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Rents Rents
        {
            get
            {
                return this._rents.Entity;
            }
            set
            {
                if (((this._rents.Entity == value)
                            == false))
                {
                    if ((this._rents.Entity != null))
                    {
                        Rents previousRents = this._rents.Entity;
                        this._rents.Entity = null;
                        previousRents.Payments.Remove(this);
                    }
                    this._rents.Entity = value;
                    if ((value != null))
                    {
                        value.Payments.Add(this);
                        _rentID = value.RentID;
                    }
                    else
                    {
                        _rentID = default(int);
                    }
                }
            }
        }

        [Association(Storage = "_clients", OtherKey = "ClientID", ThisKey = "ClientID", Name = "payments_client_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Clients Clients
        {
            get
            {
                return this._clients.Entity;
            }
            set
            {
                if (((this._clients.Entity == value)
                            == false))
                {
                    if ((this._clients.Entity != null))
                    {
                        Clients previousClients = this._clients.Entity;
                        this._clients.Entity = null;
                        previousClients.Payments.Remove(this);
                    }
                    this._clients.Entity = value;
                    if ((value != null))
                    {
                        value.Payments.Add(this);
                        _clientID = value.ClientID;
                    }
                    else
                    {
                        _clientID = default(int);
                    }
                }
            }
        }
        #endregion

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "public.penalties")]
    public partial class Penalties : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _penaltyID;

        private int _type;

        private double _sum;

        private int _clientID;

        private int _rentID;

        private EntityRef<Clients> _clients = new EntityRef<Clients>();

        private EntityRef<Rents> _rents = new EntityRef<Rents>();

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnPenaltyIDChanged();

        partial void OnPenaltyIDChanging(int value);

        partial void OnTypeChanged();

        partial void OnTypeChanging(int value);

        partial void OnSumChanged();

        partial void OnSumChanging(double value);

        partial void OnClientIDChanged();

        partial void OnClientIDChanging(int value);

        partial void OnRentIDChanged();

        partial void OnRentIDChanging(int value);
        #endregion


        public Penalties()
        {
            this.OnCreated();
        }

        [Column(Storage = "_penaltyID", Name = "penalty_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'penalty_id_seq\')")]
        [DebuggerNonUserCode()]
        public int PenaltyID
        {
            get
            {
                return this._penaltyID;
            }
            set
            {
                if ((_penaltyID != value))
                {
                    this.OnPenaltyIDChanging(value);
                    this.SendPropertyChanging();
                    this._penaltyID = value;
                    this.SendPropertyChanged("PenaltyID");
                    this.OnPenaltyIDChanged();
                }
            }
        }

        [Column(Storage = "_type", Name = "type", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((_type != value))
                {
                    this.OnTypeChanging(value);
                    this.SendPropertyChanging();
                    this._type = value;
                    this.SendPropertyChanged("Type");
                    this.OnTypeChanged();
                }
            }
        }

        [Column(Storage = "_sum", Name = "sum", DbType = "double precision", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public double Sum
        {
            get
            {
                return this._sum;
            }
            set
            {
                if ((_sum != value))
                {
                    this.OnSumChanging(value);
                    this.SendPropertyChanging();
                    this._sum = value;
                    this.SendPropertyChanged("Sum");
                    this.OnSumChanged();
                }
            }
        }

        [Column(Storage = "_clientID", Name = "client_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ClientID
        {
            get
            {
                return this._clientID;
            }
            set
            {
                if ((_clientID != value))
                {
                    this.OnClientIDChanging(value);
                    this.SendPropertyChanging();
                    this._clientID = value;
                    this.SendPropertyChanged("ClientID");
                    this.OnClientIDChanged();
                }
            }
        }

        [Column(Storage = "_rentID", Name = "rent_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int RentID
        {
            get
            {
                return this._rentID;
            }
            set
            {
                if ((_rentID != value))
                {
                    this.OnRentIDChanging(value);
                    this.SendPropertyChanging();
                    this._rentID = value;
                    this.SendPropertyChanged("RentID");
                    this.OnRentIDChanged();
                }
            }
        }

        #region Parents
        [Association(Storage = "_clients", OtherKey = "ClientID", ThisKey = "ClientID", Name = "penalties_client_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Clients Clients
        {
            get
            {
                return this._clients.Entity;
            }
            set
            {
                if (((this._clients.Entity == value)
                            == false))
                {
                    if ((this._clients.Entity != null))
                    {
                        Clients previousClients = this._clients.Entity;
                        this._clients.Entity = null;
                        previousClients.Penalties.Remove(this);
                    }
                    this._clients.Entity = value;
                    if ((value != null))
                    {
                        value.Penalties.Add(this);
                        _clientID = value.ClientID;
                    }
                    else
                    {
                        _clientID = default(int);
                    }
                }
            }
        }

        [Association(Storage = "_rents", OtherKey = "RentID", ThisKey = "RentID", Name = "penalties_rent_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Rents Rents
        {
            get
            {
                return this._rents.Entity;
            }
            set
            {
                if (((this._rents.Entity == value)
                            == false))
                {
                    if ((this._rents.Entity != null))
                    {
                        Rents previousRents = this._rents.Entity;
                        this._rents.Entity = null;
                        previousRents.Penalties.Remove(this);
                    }
                    this._rents.Entity = value;
                    if ((value != null))
                    {
                        value.Penalties.Add(this);
                        _rentID = value.RentID;
                    }
                    else
                    {
                        _rentID = default(int);
                    }
                }
            }
        }
        #endregion

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "public.preferences")]
    public partial class Preferences : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _preferenceID;

        private System.DateTime _rentStart;

        private System.DateTime _rentStop;

        private int _clientID;

        private string _brand;

        private double _maxDailyCost;

        private EntitySet<Rents> _rents;

        private EntitySet<Property2preference> _property2pReference;

        private EntityRef<Clients> _clients = new EntityRef<Clients>();

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnPreferenceIDChanged();

        partial void OnPreferenceIDChanging(int value);

        partial void OnRentStartChanged();

        partial void OnRentStartChanging(System.DateTime value);

        partial void OnRentStopChanged();

        partial void OnRentStopChanging(System.DateTime value);

        partial void OnClientIDChanged();

        partial void OnClientIDChanging(int value);

        partial void OnBrandChanged();

        partial void OnBrandChanging(string value);

        partial void OnMaxDailyCostChanged();

        partial void OnMaxDailyCostChanging(double value);
        #endregion


        public Preferences()
        {
            _rents = new EntitySet<Rents>(new Action<Rents>(this.Rents_Attach), new Action<Rents>(this.Rents_Detach));
            _property2pReference = new EntitySet<Property2preference>(new Action<Property2preference>(this.Property2Preference_Attach), new Action<Property2preference>(this.Property2Preference_Detach));
            this.OnCreated();
        }

        [Column(Storage = "_preferenceID", Name = "preference_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'preference_id_seq\')")]
        [DebuggerNonUserCode()]
        public int PreferenceID
        {
            get
            {
                return this._preferenceID;
            }
            set
            {
                if ((_preferenceID != value))
                {
                    this.OnPreferenceIDChanging(value);
                    this.SendPropertyChanging();
                    this._preferenceID = value;
                    this.SendPropertyChanged("PreferenceID");
                    this.OnPreferenceIDChanged();
                }
            }
        }

        [Column(Storage = "_rentStart", Name = "rent_start", DbType = "timestamp without time zone", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public System.DateTime RentStart
        {
            get
            {
                return this._rentStart;
            }
            set
            {
                if ((_rentStart != value))
                {
                    this.OnRentStartChanging(value);
                    this.SendPropertyChanging();
                    this._rentStart = value;
                    this.SendPropertyChanged("RentStart");
                    this.OnRentStartChanged();
                }
            }
        }

        [Column(Storage = "_rentStop", Name = "rent_stop", DbType = "timestamp without time zone", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public System.DateTime RentStop
        {
            get
            {
                return this._rentStop;
            }
            set
            {
                if ((_rentStop != value))
                {
                    this.OnRentStopChanging(value);
                    this.SendPropertyChanging();
                    this._rentStop = value;
                    this.SendPropertyChanged("RentStop");
                    this.OnRentStopChanged();
                }
            }
        }

        [Column(Storage = "_clientID", Name = "client_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ClientID
        {
            get
            {
                return this._clientID;
            }
            set
            {
                if ((_clientID != value))
                {
                    this.OnClientIDChanging(value);
                    this.SendPropertyChanging();
                    this._clientID = value;
                    this.SendPropertyChanged("ClientID");
                    this.OnClientIDChanged();
                }
            }
        }

        [Column(Storage = "_brand", Name = "brand", DbType = "character varying(30)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Brand
        {
            get
            {
                return this._brand;
            }
            set
            {
                if (((_brand == value)
                            == false))
                {
                    this.OnBrandChanging(value);
                    this.SendPropertyChanging();
                    this._brand = value;
                    this.SendPropertyChanged("Brand");
                    this.OnBrandChanged();
                }
            }
        }

        [Column(Storage = "_maxDailyCost", Name = "max_daily_cost", DbType = "double precision", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public double MaxDailyCost
        {
            get
            {
                return this._maxDailyCost;
            }
            set
            {
                if ((_maxDailyCost != value))
                {
                    this.OnMaxDailyCostChanging(value);
                    this.SendPropertyChanging();
                    this._maxDailyCost = value;
                    this.SendPropertyChanged("MaxDailyCost");
                    this.OnMaxDailyCostChanged();
                }
            }
        }

        #region Children
        [Association(Storage = "_rents", OtherKey = "PreferenceID", ThisKey = "PreferenceID", Name = "rents_preference_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Rents> Rents
        {
            get
            {
                return this._rents;
            }
            set
            {
                this._rents = value;
            }
        }

        [Association(Storage = "_property2pReference", OtherKey = "PreferenceID", ThisKey = "PreferenceID", Name = "property2preference_preference_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Property2preference> Property2Preference
        {
            get
            {
                return this._property2pReference;
            }
            set
            {
                this._property2pReference = value;
            }
        }
        #endregion

        #region Parents
        [Association(Storage = "_clients", OtherKey = "ClientID", ThisKey = "ClientID", Name = "preferences_client_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Clients Clients
        {
            get
            {
                return this._clients.Entity;
            }
            set
            {
                if (((this._clients.Entity == value)
                            == false))
                {
                    if ((this._clients.Entity != null))
                    {
                        Clients previousClients = this._clients.Entity;
                        this._clients.Entity = null;
                        previousClients.Preferences.Remove(this);
                    }
                    this._clients.Entity = value;
                    if ((value != null))
                    {
                        value.Preferences.Add(this);
                        _clientID = value.ClientID;
                    }
                    else
                    {
                        _clientID = default(int);
                    }
                }
            }
        }
        #endregion

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #region Attachment handlers
        private void Rents_Attach(Rents entity)
        {
            this.SendPropertyChanging();
            entity.Preferences = this;
        }

        private void Rents_Detach(Rents entity)
        {
            this.SendPropertyChanging();
            entity.Preferences = null;
        }

        private void Property2Preference_Attach(Property2preference entity)
        {
            this.SendPropertyChanging();
            entity.Preferences = this;
        }

        private void Property2Preference_Detach(Property2preference entity)
        {
            this.SendPropertyChanging();
            entity.Preferences = null;
        }
        #endregion
    }

    [Table(Name = "public.properties")]
    public partial class Properties : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _propertyID;

        private string _description;

        private EntitySet<Property2car> _property2cAr;

        private EntitySet<Property2preference> _property2pReference;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnPropertyIDChanged();

        partial void OnPropertyIDChanging(int value);

        partial void OnDescriptionChanged();

        partial void OnDescriptionChanging(string value);
        #endregion


        public Properties()
        {
            _property2cAr = new EntitySet<Property2car>(new Action<Property2car>(this.Property2Car_Attach), new Action<Property2car>(this.Property2Car_Detach));
            _property2pReference = new EntitySet<Property2preference>(new Action<Property2preference>(this.Property2Preference_Attach), new Action<Property2preference>(this.Property2Preference_Detach));
            this.OnCreated();
        }

        [Column(Storage = "_propertyID", Name = "property_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'property_id_seq\')")]
        [DebuggerNonUserCode()]
        public int PropertyID
        {
            get
            {
                return this._propertyID;
            }
            set
            {
                if ((_propertyID != value))
                {
                    this.OnPropertyIDChanging(value);
                    this.SendPropertyChanging();
                    this._propertyID = value;
                    this.SendPropertyChanged("PropertyID");
                    this.OnPropertyIDChanged();
                }
            }
        }

        [Column(Storage = "_description", Name = "description", DbType = "character varying(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                if (((_description == value)
                            == false))
                {
                    this.OnDescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._description = value;
                    this.SendPropertyChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }

        #region Children
        [Association(Storage = "_property2cAr", OtherKey = "PropertyID", ThisKey = "PropertyID", Name = "property2car_property_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Property2car> Property2Car
        {
            get
            {
                return this._property2cAr;
            }
            set
            {
                this._property2cAr = value;
            }
        }

        [Association(Storage = "_property2pReference", OtherKey = "ProrertyID", ThisKey = "PropertyID", Name = "property2preference_prorerty_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Property2preference> Property2Preference
        {
            get
            {
                return this._property2pReference;
            }
            set
            {
                this._property2pReference = value;
            }
        }
        #endregion

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #region Attachment handlers
        private void Property2Car_Attach(Property2car entity)
        {
            this.SendPropertyChanging();
            entity.Properties = this;
        }

        private void Property2Car_Detach(Property2car entity)
        {
            this.SendPropertyChanging();
            entity.Properties = null;
        }

        private void Property2Preference_Attach(Property2preference entity)
        {
            this.SendPropertyChanging();
            entity.Properties = this;
        }

        private void Property2Preference_Detach(Property2preference entity)
        {
            this.SendPropertyChanging();
            entity.Properties = null;
        }
        #endregion
    }

    [Table(Name = "public.property2car")]
    public partial class Property2car : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _property2carID;

        private int _propertyID;

        private int _carID;

        private EntityRef<Properties> _properties = new EntityRef<Properties>();

        private EntityRef<Cars> _cars = new EntityRef<Cars>();

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnProperty2carIDChanged();

        partial void OnProperty2carIDChanging(int value);

        partial void OnPropertyIDChanged();

        partial void OnPropertyIDChanging(int value);

        partial void OnCarIDChanged();

        partial void OnCarIDChanging(int value);
        #endregion


        public Property2car()
        {
            this.OnCreated();
        }

        [Column(Storage = "_property2carID", Name = "property2car_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'property2car_id_seq\')")]
        [DebuggerNonUserCode()]
        public int Property2carID
        {
            get
            {
                return this._property2carID;
            }
            set
            {
                if ((_property2carID != value))
                {
                    this.OnProperty2carIDChanging(value);
                    this.SendPropertyChanging();
                    this._property2carID = value;
                    this.SendPropertyChanged("Property2carID");
                    this.OnProperty2carIDChanged();
                }
            }
        }

        [Column(Storage = "_propertyID", Name = "property_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int PropertyID
        {
            get
            {
                return this._propertyID;
            }
            set
            {
                if ((_propertyID != value))
                {
                    this.OnPropertyIDChanging(value);
                    this.SendPropertyChanging();
                    this._propertyID = value;
                    this.SendPropertyChanged("PropertyID");
                    this.OnPropertyIDChanged();
                }
            }
        }

        [Column(Storage = "_carID", Name = "car_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int CarID
        {
            get
            {
                return this._carID;
            }
            set
            {
                if ((_carID != value))
                {
                    this.OnCarIDChanging(value);
                    this.SendPropertyChanging();
                    this._carID = value;
                    this.SendPropertyChanged("CarID");
                    this.OnCarIDChanged();
                }
            }
        }

        #region Parents
        [Association(Storage = "_properties", OtherKey = "PropertyID", ThisKey = "PropertyID", Name = "property2car_property_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Properties Properties
        {
            get
            {
                return this._properties.Entity;
            }
            set
            {
                if (((this._properties.Entity == value)
                            == false))
                {
                    if ((this._properties.Entity != null))
                    {
                        Properties previousProperties = this._properties.Entity;
                        this._properties.Entity = null;
                        previousProperties.Property2Car.Remove(this);
                    }
                    this._properties.Entity = value;
                    if ((value != null))
                    {
                        value.Property2Car.Add(this);
                        _propertyID = value.PropertyID;
                    }
                    else
                    {
                        _propertyID = default(int);
                    }
                }
            }
        }

        [Association(Storage = "_cars", OtherKey = "CarID", ThisKey = "CarID", Name = "property2car_car_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Cars Cars
        {
            get
            {
                return this._cars.Entity;
            }
            set
            {
                if (((this._cars.Entity == value)
                            == false))
                {
                    if ((this._cars.Entity != null))
                    {
                        Cars previousCars = this._cars.Entity;
                        this._cars.Entity = null;
                        previousCars.Property2Car.Remove(this);
                    }
                    this._cars.Entity = value;
                    if ((value != null))
                    {
                        value.Property2Car.Add(this);
                        _carID = value.CarID;
                    }
                    else
                    {
                        _carID = default(int);
                    }
                }
            }
        }
        #endregion

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "public.property2preference")]
    public partial class Property2preference : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _property2preferenceID;

        private int _prorertyID;

        private int _preferenceID;

        private EntityRef<Properties> _properties = new EntityRef<Properties>();

        private EntityRef<Preferences> _preferences = new EntityRef<Preferences>();

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnProperty2preferenceIDChanged();

        partial void OnProperty2preferenceIDChanging(int value);

        partial void OnProrertyIDChanged();

        partial void OnProrertyIDChanging(int value);

        partial void OnPreferenceIDChanged();

        partial void OnPreferenceIDChanging(int value);
        #endregion


        public Property2preference()
        {
            this.OnCreated();
        }

        [Column(Storage = "_property2preferenceID", Name = "property2preference_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'property2preference_id_seq\')")]
        [DebuggerNonUserCode()]
        public int Property2preferenceID
        {
            get
            {
                return this._property2preferenceID;
            }
            set
            {
                if ((_property2preferenceID != value))
                {
                    this.OnProperty2preferenceIDChanging(value);
                    this.SendPropertyChanging();
                    this._property2preferenceID = value;
                    this.SendPropertyChanged("Property2preferenceID");
                    this.OnProperty2preferenceIDChanged();
                }
            }
        }

        [Column(Storage = "_prorertyID", Name = "prorerty_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ProrertyID
        {
            get
            {
                return this._prorertyID;
            }
            set
            {
                if ((_prorertyID != value))
                {
                    this.OnProrertyIDChanging(value);
                    this.SendPropertyChanging();
                    this._prorertyID = value;
                    this.SendPropertyChanged("ProrertyID");
                    this.OnProrertyIDChanged();
                }
            }
        }

        [Column(Storage = "_preferenceID", Name = "preference_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int PreferenceID
        {
            get
            {
                return this._preferenceID;
            }
            set
            {
                if ((_preferenceID != value))
                {
                    this.OnPreferenceIDChanging(value);
                    this.SendPropertyChanging();
                    this._preferenceID = value;
                    this.SendPropertyChanged("PreferenceID");
                    this.OnPreferenceIDChanged();
                }
            }
        }

        #region Parents
        [Association(Storage = "_properties", OtherKey = "PropertyID", ThisKey = "ProrertyID", Name = "property2preference_prorerty_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Properties Properties
        {
            get
            {
                return this._properties.Entity;
            }
            set
            {
                if (((this._properties.Entity == value)
                            == false))
                {
                    if ((this._properties.Entity != null))
                    {
                        Properties previousProperties = this._properties.Entity;
                        this._properties.Entity = null;
                        previousProperties.Property2Preference.Remove(this);
                    }
                    this._properties.Entity = value;
                    if ((value != null))
                    {
                        value.Property2Preference.Add(this);
                        _prorertyID = value.PropertyID;
                    }
                    else
                    {
                        _prorertyID = default(int);
                    }
                }
            }
        }

        [Association(Storage = "_preferences", OtherKey = "PreferenceID", ThisKey = "PreferenceID", Name = "property2preference_preference_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Preferences Preferences
        {
            get
            {
                return this._preferences.Entity;
            }
            set
            {
                if (((this._preferences.Entity == value)
                            == false))
                {
                    if ((this._preferences.Entity != null))
                    {
                        Preferences previousPreferences = this._preferences.Entity;
                        this._preferences.Entity = null;
                        previousPreferences.Property2Preference.Remove(this);
                    }
                    this._preferences.Entity = value;
                    if ((value != null))
                    {
                        value.Property2Preference.Add(this);
                        _preferenceID = value.PreferenceID;
                    }
                    else
                    {
                        _preferenceID = default(int);
                    }
                }
            }
        }
        #endregion

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [Table(Name = "public.rents")]
    public partial class Rents : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _rentID;

        private int _carID;

        private int _clientID;

        private System.DateTime _rentStart;

        private System.DateTime _rentStop;

        private int _preferenceID;

        private EntitySet<Penalties> _penalties;

        private EntitySet<Payments> _payments;

        private EntityRef<Cars> _cars = new EntityRef<Cars>();

        private EntityRef<Clients> _clients = new EntityRef<Clients>();

        private EntityRef<Preferences> _preferences = new EntityRef<Preferences>();

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnRentIDChanged();

        partial void OnRentIDChanging(int value);

        partial void OnCarIDChanged();

        partial void OnCarIDChanging(int value);

        partial void OnClientIDChanged();

        partial void OnClientIDChanging(int value);

        partial void OnRentStartChanged();

        partial void OnRentStartChanging(System.DateTime value);

        partial void OnRentStopChanged();

        partial void OnRentStopChanging(System.DateTime value);

        partial void OnPreferenceIDChanged();

        partial void OnPreferenceIDChanging(int value);
        #endregion


        public Rents()
        {
            _penalties = new EntitySet<Penalties>(new Action<Penalties>(this.Penalties_Attach), new Action<Penalties>(this.Penalties_Detach));
            _payments = new EntitySet<Payments>(new Action<Payments>(this.Payments_Attach), new Action<Payments>(this.Payments_Detach));
            this.OnCreated();
        }

        [Column(Storage = "_rentID", Name = "rent_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'rent_id_seq\')")]
        [DebuggerNonUserCode()]
        public int RentID
        {
            get
            {
                return this._rentID;
            }
            set
            {
                if ((_rentID != value))
                {
                    this.OnRentIDChanging(value);
                    this.SendPropertyChanging();
                    this._rentID = value;
                    this.SendPropertyChanged("RentID");
                    this.OnRentIDChanged();
                }
            }
        }

        [Column(Storage = "_carID", Name = "car_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int CarID
        {
            get
            {
                return this._carID;
            }
            set
            {
                if ((_carID != value))
                {
                    this.OnCarIDChanging(value);
                    this.SendPropertyChanging();
                    this._carID = value;
                    this.SendPropertyChanged("CarID");
                    this.OnCarIDChanged();
                }
            }
        }

        [Column(Storage = "_clientID", Name = "client_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int ClientID
        {
            get
            {
                return this._clientID;
            }
            set
            {
                if ((_clientID != value))
                {
                    this.OnClientIDChanging(value);
                    this.SendPropertyChanging();
                    this._clientID = value;
                    this.SendPropertyChanged("ClientID");
                    this.OnClientIDChanged();
                }
            }
        }

        [Column(Storage = "_rentStart", Name = "rent_start", DbType = "timestamp without time zone", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public System.DateTime RentStart
        {
            get
            {
                return this._rentStart;
            }
            set
            {
                if ((_rentStart != value))
                {
                    this.OnRentStartChanging(value);
                    this.SendPropertyChanging();
                    this._rentStart = value;
                    this.SendPropertyChanged("RentStart");
                    this.OnRentStartChanged();
                }
            }
        }

        [Column(Storage = "_rentStop", Name = "rent_stop", DbType = "timestamp without time zone", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public System.DateTime RentStop
        {
            get
            {
                return this._rentStop;
            }
            set
            {
                if ((_rentStop != value))
                {
                    this.OnRentStopChanging(value);
                    this.SendPropertyChanging();
                    this._rentStop = value;
                    this.SendPropertyChanged("RentStop");
                    this.OnRentStopChanged();
                }
            }
        }

        [Column(Storage = "_preferenceID", Name = "preference_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
        [DebuggerNonUserCode()]
        public int PreferenceID
        {
            get
            {
                return this._preferenceID;
            }
            set
            {
                if ((_preferenceID != value))
                {
                    this.OnPreferenceIDChanging(value);
                    this.SendPropertyChanging();
                    this._preferenceID = value;
                    this.SendPropertyChanged("PreferenceID");
                    this.OnPreferenceIDChanged();
                }
            }
        }

        #region Children
        [Association(Storage = "_penalties", OtherKey = "RentID", ThisKey = "RentID", Name = "penalties_rent_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Penalties> Penalties
        {
            get
            {
                return this._penalties;
            }
            set
            {
                this._penalties = value;
            }
        }

        [Association(Storage = "_payments", OtherKey = "RentID", ThisKey = "RentID", Name = "payments_rent_id_fkey")]
        [DebuggerNonUserCode()]
        public EntitySet<Payments> Payments
        {
            get
            {
                return this._payments;
            }
            set
            {
                this._payments = value;
            }
        }
        #endregion

        #region Parents
        [Association(Storage = "_cars", OtherKey = "CarID", ThisKey = "CarID", Name = "rents_car_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Cars Cars
        {
            get
            {
                return this._cars.Entity;
            }
            set
            {
                if (((this._cars.Entity == value)
                            == false))
                {
                    if ((this._cars.Entity != null))
                    {
                        Cars previousCars = this._cars.Entity;
                        this._cars.Entity = null;
                        previousCars.Rents.Remove(this);
                    }
                    this._cars.Entity = value;
                    if ((value != null))
                    {
                        value.Rents.Add(this);
                        _carID = value.CarID;
                    }
                    else
                    {
                        _carID = default(int);
                    }
                }
            }
        }

        [Association(Storage = "_clients", OtherKey = "ClientID", ThisKey = "ClientID", Name = "rents_client_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Clients Clients
        {
            get
            {
                return this._clients.Entity;
            }
            set
            {
                if (((this._clients.Entity == value)
                            == false))
                {
                    if ((this._clients.Entity != null))
                    {
                        Clients previousClients = this._clients.Entity;
                        this._clients.Entity = null;
                        previousClients.Rents.Remove(this);
                    }
                    this._clients.Entity = value;
                    if ((value != null))
                    {
                        value.Rents.Add(this);
                        _clientID = value.ClientID;
                    }
                    else
                    {
                        _clientID = default(int);
                    }
                }
            }
        }

        [Association(Storage = "_preferences", OtherKey = "PreferenceID", ThisKey = "PreferenceID", Name = "rents_preference_id_fkey", IsForeignKey = true)]
        [DebuggerNonUserCode()]
        public Preferences Preferences
        {
            get
            {
                return this._preferences.Entity;
            }
            set
            {
                if (((this._preferences.Entity == value)
                            == false))
                {
                    if ((this._preferences.Entity != null))
                    {
                        Preferences previousPreferences = this._preferences.Entity;
                        this._preferences.Entity = null;
                        previousPreferences.Rents.Remove(this);
                    }
                    this._preferences.Entity = value;
                    if ((value != null))
                    {
                        value.Rents.Add(this);
                        _preferenceID = value.PreferenceID;
                    }
                    else
                    {
                        _preferenceID = default(int);
                    }
                }
            }
        }
        #endregion

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
            if ((h != null))
            {
                h(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
            if ((h != null))
            {
                h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        #region Attachment handlers
        private void Penalties_Attach(Penalties entity)
        {
            this.SendPropertyChanging();
            entity.Rents = this;
        }

        private void Penalties_Detach(Penalties entity)
        {
            this.SendPropertyChanging();
            entity.Rents = null;
        }

        private void Payments_Attach(Payments entity)
        {
            this.SendPropertyChanging();
            entity.Rents = this;
        }

        private void Payments_Detach(Payments entity)
        {
            this.SendPropertyChanging();
            entity.Rents = null;
        }
        #endregion
    }

}
