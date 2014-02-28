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


public partial class Test : DataContext
{

    #region Extensibility Method Declarations
    partial void OnCreated();
    #endregion


    public Test(string connectionString) :
        base(connectionString)
    {
        this.OnCreated();
    }

    public Test(string connection, MappingSource mappingSource) :
        base(connection, mappingSource)
    {
        this.OnCreated();
    }

    public Test(IDbConnection connection, MappingSource mappingSource) :
        base(connection, mappingSource)
    {
        this.OnCreated();
    }

    public Table<Autos> Autos
    {
        get
        {
            return this.GetTable<Autos>();
        }
    }

    public Table<Orders> Orders
    {
        get
        {
            return this.GetTable<Orders>();
        }
    }

    public Table<Users> Users
    {
        get
        {
            return this.GetTable<Users>();
        }
    }
}

#region Start MONO_STRICT
#if MONO_STRICT

public partial class Test
{
	
	public Test(IDbConnection connection) : 
			base(connection)
	{
		this.OnCreated();
	}
}
#region End MONO_STRICT
#endregion
#else     // MONO_STRICT

public partial class Test
{

    public Test(IDbConnection connection) :
        base(connection, new DbLinq.PostgreSql.PgsqlVendor())
    {
        this.OnCreated();
    }

    public Test(IDbConnection connection, IVendor sqlDialect) :
        base(connection, sqlDialect)
    {
        this.OnCreated();
    }

    public Test(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) :
        base(connection, mappingSource, sqlDialect)
    {
        this.OnCreated();
    }
}
#region End Not MONO_STRICT
#endregion
#endif     // MONO_STRICT
#endregion

[Table(Name = "public.autos")]
public partial class Autos : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{

    private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

    private int _autoID;

    private int _type;

    private string _description;

    #region Extensibility Method Declarations
    partial void OnCreated();

    partial void OnAutoIDChanged();

    partial void OnAutoIDChanging(int value);

    partial void OnTypeChanged();

    partial void OnTypeChanging(int value);

    partial void OnDescriptionChanged();

    partial void OnDescriptionChanging(string value);
    #endregion


    public Autos()
    {
        this.OnCreated();
    }

    [Column(Storage = "_autoID", Name = "auto_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'auto_id_seq\')")]
    [DebuggerNonUserCode()]
    public int AutoID
    {
        get
        {
            return this._autoID;
        }
        set
        {
            if ((_autoID != value))
            {
                this.OnAutoIDChanging(value);
                this.SendPropertyChanging();
                this._autoID = value;
                this.SendPropertyChanged("AutoID");
                this.OnAutoIDChanged();
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

[Table(Name = "public.orders")]
public partial class Orders : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{

    private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

    private int _orderID;

    private int _userID;

    private int _autoID;

    private string _description;

    private System.DateTime _startTime;

    private System.DateTime _stopTime;

    #region Extensibility Method Declarations
    partial void OnCreated();

    partial void OnOrderIDChanged();

    partial void OnOrderIDChanging(int value);

    partial void OnUserIDChanged();

    partial void OnUserIDChanging(int value);

    partial void OnAutoIDChanged();

    partial void OnAutoIDChanging(int value);

    partial void OnDescriptionChanged();

    partial void OnDescriptionChanging(string value);

    partial void OnStartTimeChanged();

    partial void OnStartTimeChanging(System.DateTime value);

    partial void OnStopTimeChanged();

    partial void OnStopTimeChanging(System.DateTime value);
    #endregion


    public Orders()
    {
        this.OnCreated();
    }

    [Column(Storage = "_orderID", Name = "order_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'order_id_seq\')")]
    [DebuggerNonUserCode()]
    public int OrderID
    {
        get
        {
            return this._orderID;
        }
        set
        {
            if ((_orderID != value))
            {
                this.OnOrderIDChanging(value);
                this.SendPropertyChanging();
                this._orderID = value;
                this.SendPropertyChanged("OrderID");
                this.OnOrderIDChanged();
            }
        }
    }

    [Column(Storage = "_userID", Name = "user_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
    [DebuggerNonUserCode()]
    public int UserID
    {
        get
        {
            return this._userID;
        }
        set
        {
            if ((_userID != value))
            {
                this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._userID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
            }
        }
    }

    [Column(Storage = "_autoID", Name = "auto_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never, CanBeNull = false)]
    [DebuggerNonUserCode()]
    public int AutoID
    {
        get
        {
            return this._autoID;
        }
        set
        {
            if ((_autoID != value))
            {
                this.OnAutoIDChanging(value);
                this.SendPropertyChanging();
                this._autoID = value;
                this.SendPropertyChanged("AutoID");
                this.OnAutoIDChanged();
            }
        }
    }

    [Column(Storage = "_description", Name = "description", DbType = "character varying(200)", AutoSync = AutoSync.Never, CanBeNull = false)]
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

    [Column(Storage = "_startTime", Name = "start_time", DbType = "time without time zone", AutoSync = AutoSync.Never, CanBeNull = false)]
    [DebuggerNonUserCode()]
    public System.DateTime StartTime
    {
        get
        {
            return this._startTime;
        }
        set
        {
            if ((_startTime != value))
            {
                this.OnStartTimeChanging(value);
                this.SendPropertyChanging();
                this._startTime = value;
                this.SendPropertyChanged("StartTime");
                this.OnStartTimeChanged();
            }
        }
    }

    [Column(Storage = "_stopTime", Name = "stop_time", DbType = "time without time zone", AutoSync = AutoSync.Never, CanBeNull = false)]
    [DebuggerNonUserCode()]
    public System.DateTime StopTime
    {
        get
        {
            return this._stopTime;
        }
        set
        {
            if ((_stopTime != value))
            {
                this.OnStopTimeChanging(value);
                this.SendPropertyChanging();
                this._stopTime = value;
                this.SendPropertyChanged("StopTime");
                this.OnStopTimeChanged();
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

[Table(Name = "public.users")]
public partial class Users : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
{

    private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");

    private int _userID;

    private System.Nullable<int> _groupID;

    private string _username;

    private string _hash;

    #region Extensibility Method Declarations
    partial void OnCreated();

    partial void OnUserIDChanged();

    partial void OnUserIDChanging(int value);

    partial void OnGroupIDChanged();

    partial void OnGroupIDChanging(System.Nullable<int> value);

    partial void OnUsernameChanged();

    partial void OnUsernameChanging(string value);

    partial void OnHashChanged();

    partial void OnHashChanging(string value);
    #endregion


    public Users()
    {
        this.OnCreated();
    }

    [Column(Storage = "_userID", Name = "user_id", DbType = "integer(32,0)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false, Expression = "nextval(\'user_id_seq\')")]
    [DebuggerNonUserCode()]
    public int UserID
    {
        get
        {
            return this._userID;
        }
        set
        {
            if ((_userID != value))
            {
                this.OnUserIDChanging(value);
                this.SendPropertyChanging();
                this._userID = value;
                this.SendPropertyChanged("UserID");
                this.OnUserIDChanged();
            }
        }
    }

    [Column(Storage = "_groupID", Name = "group_id", DbType = "integer(32,0)", AutoSync = AutoSync.Never)]
    [DebuggerNonUserCode()]
    public System.Nullable<int> GroupID
    {
        get
        {
            return this._groupID;
        }
        set
        {
            if ((_groupID != value))
            {
                this.OnGroupIDChanging(value);
                this.SendPropertyChanging();
                this._groupID = value;
                this.SendPropertyChanged("GroupID");
                this.OnGroupIDChanged();
            }
        }
    }

    [Column(Storage = "_username", Name = "username", DbType = "character varying(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
    [DebuggerNonUserCode()]
    public string Username
    {
        get
        {
            return this._username;
        }
        set
        {
            if (((_username == value)
                        == false))
            {
                this.OnUsernameChanging(value);
                this.SendPropertyChanging();
                this._username = value;
                this.SendPropertyChanged("Username");
                this.OnUsernameChanged();
            }
        }
    }

    [Column(Storage = "_hash", Name = "hash", DbType = "character varying", AutoSync = AutoSync.Never, CanBeNull = false)]
    [DebuggerNonUserCode()]
    public string Hash
    {
        get
        {
            return this._hash;
        }
        set
        {
            if (((_hash == value)
                        == false))
            {
                this.OnHashChanging(value);
                this.SendPropertyChanging();
                this._hash = value;
                this.SendPropertyChanged("Hash");
                this.OnHashChanged();
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
