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

    [Table(Name = "public.payments")]
    public partial class Payments : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _paymentID;

        private int _rentID;

        private System.Nullable<int> _penaltyID;

        private double _totalCost;

        private int _clientID;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnPaymentIDChanged();

        partial void OnPaymentIDChanging(int value);

        partial void OnRentIDChanged();

        partial void OnRentIDChanging(int value);

        partial void OnPenaltyIDChanged();

        partial void OnPenaltyIDChanging(System.Nullable<int> value);

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

        [Column(Storage = "_penaltyID", Name = "penalty_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never)]
        [DebuggerNonUserCode()]
        public System.Nullable<int> PenaltyID
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

    [Table(Name = "public.properties")]
    public partial class Properties : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _propertyID;

        private string _description;

        #region Extensibility Method Declarations
        partial void OnCreated();

        partial void OnPropertyIDChanged();

        partial void OnPropertyIDChanging(int value);

        partial void OnDescriptionChanged();

        partial void OnDescriptionChanging(string value);
        #endregion


        public Properties()
        {
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

    [Table(Name = "public.property2car")]
    public partial class Property2car : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

        private int _property2carID;

        private int _propertyID;

        private int _carID;

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

}
