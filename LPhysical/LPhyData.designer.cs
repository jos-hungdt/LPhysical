﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LPhysical
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LPHYSIC")]
	public partial class LPhyDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDERAL10(DERAL10 instance);
    partial void UpdateDERAL10(DERAL10 instance);
    partial void DeleteDERAL10(DERAL10 instance);
    partial void InsertDERAL11(DERAL11 instance);
    partial void UpdateDERAL11(DERAL11 instance);
    partial void DeleteDERAL11(DERAL11 instance);
    partial void InsertDERAL12(DERAL12 instance);
    partial void UpdateDERAL12(DERAL12 instance);
    partial void DeleteDERAL12(DERAL12 instance);
    partial void InsertELEVEN(ELEVEN instance);
    partial void UpdateELEVEN(ELEVEN instance);
    partial void DeleteELEVEN(ELEVEN instance);
    partial void InsertTENBASE(TENBASE instance);
    partial void UpdateTENBASE(TENBASE instance);
    partial void DeleteTENBASE(TENBASE instance);
    partial void InsertTWENTH(TWENTH instance);
    partial void UpdateTWENTH(TWENTH instance);
    partial void DeleteTWENTH(TWENTH instance);
    #endregion
		
		public LPhyDataDataContext() : 
				base(global::LPhysical.Properties.Settings.Default.LPHYSICConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LPhyDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LPhyDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LPhyDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LPhyDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DERAL10> DERAL10s
		{
			get
			{
				return this.GetTable<DERAL10>();
			}
		}
		
		public System.Data.Linq.Table<DERAL11> DERAL11s
		{
			get
			{
				return this.GetTable<DERAL11>();
			}
		}
		
		public System.Data.Linq.Table<DERAL12> DERAL12s
		{
			get
			{
				return this.GetTable<DERAL12>();
			}
		}
		
		public System.Data.Linq.Table<ELEVEN> ELEVENs
		{
			get
			{
				return this.GetTable<ELEVEN>();
			}
		}
		
		public System.Data.Linq.Table<TENBASE> TENBASEs
		{
			get
			{
				return this.GetTable<TENBASE>();
			}
		}
		
		public System.Data.Linq.Table<TWENTH> TWENTHs
		{
			get
			{
				return this.GetTable<TWENTH>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DERAL10")]
	public partial class DERAL10 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QID;
		
		private string _CONTENT;
		
		private string _CTLDUNG;
		
		private string _CTL1;
		
		private string _CTL2;
		
		private string _CTL3;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQIDChanging(int value);
    partial void OnQIDChanged();
    partial void OnCONTENTChanging(string value);
    partial void OnCONTENTChanged();
    partial void OnCTLDUNGChanging(string value);
    partial void OnCTLDUNGChanged();
    partial void OnCTL1Changing(string value);
    partial void OnCTL1Changed();
    partial void OnCTL2Changing(string value);
    partial void OnCTL2Changed();
    partial void OnCTL3Changing(string value);
    partial void OnCTL3Changed();
    #endregion
		
		public DERAL10()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int QID
		{
			get
			{
				return this._QID;
			}
			set
			{
				if ((this._QID != value))
				{
					this.OnQIDChanging(value);
					this.SendPropertyChanging();
					this._QID = value;
					this.SendPropertyChanged("QID");
					this.OnQIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTENT", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string CONTENT
		{
			get
			{
				return this._CONTENT;
			}
			set
			{
				if ((this._CONTENT != value))
				{
					this.OnCONTENTChanging(value);
					this.SendPropertyChanging();
					this._CONTENT = value;
					this.SendPropertyChanged("CONTENT");
					this.OnCONTENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTLDUNG", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string CTLDUNG
		{
			get
			{
				return this._CTLDUNG;
			}
			set
			{
				if ((this._CTLDUNG != value))
				{
					this.OnCTLDUNGChanging(value);
					this.SendPropertyChanging();
					this._CTLDUNG = value;
					this.SendPropertyChanged("CTLDUNG");
					this.OnCTLDUNGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTL1", DbType="NVarChar(200)")]
		public string CTL1
		{
			get
			{
				return this._CTL1;
			}
			set
			{
				if ((this._CTL1 != value))
				{
					this.OnCTL1Changing(value);
					this.SendPropertyChanging();
					this._CTL1 = value;
					this.SendPropertyChanged("CTL1");
					this.OnCTL1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTL2", DbType="NVarChar(200)")]
		public string CTL2
		{
			get
			{
				return this._CTL2;
			}
			set
			{
				if ((this._CTL2 != value))
				{
					this.OnCTL2Changing(value);
					this.SendPropertyChanging();
					this._CTL2 = value;
					this.SendPropertyChanged("CTL2");
					this.OnCTL2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTL3", DbType="NVarChar(200)")]
		public string CTL3
		{
			get
			{
				return this._CTL3;
			}
			set
			{
				if ((this._CTL3 != value))
				{
					this.OnCTL3Changing(value);
					this.SendPropertyChanging();
					this._CTL3 = value;
					this.SendPropertyChanged("CTL3");
					this.OnCTL3Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DERAL11")]
	public partial class DERAL11 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QID;
		
		private string _CONTENT;
		
		private string _CTLDUNG;
		
		private string _CTL1;
		
		private string _CTL2;
		
		private string _CTL3;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQIDChanging(int value);
    partial void OnQIDChanged();
    partial void OnCONTENTChanging(string value);
    partial void OnCONTENTChanged();
    partial void OnCTLDUNGChanging(string value);
    partial void OnCTLDUNGChanged();
    partial void OnCTL1Changing(string value);
    partial void OnCTL1Changed();
    partial void OnCTL2Changing(string value);
    partial void OnCTL2Changed();
    partial void OnCTL3Changing(string value);
    partial void OnCTL3Changed();
    #endregion
		
		public DERAL11()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int QID
		{
			get
			{
				return this._QID;
			}
			set
			{
				if ((this._QID != value))
				{
					this.OnQIDChanging(value);
					this.SendPropertyChanging();
					this._QID = value;
					this.SendPropertyChanged("QID");
					this.OnQIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTENT", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string CONTENT
		{
			get
			{
				return this._CONTENT;
			}
			set
			{
				if ((this._CONTENT != value))
				{
					this.OnCONTENTChanging(value);
					this.SendPropertyChanging();
					this._CONTENT = value;
					this.SendPropertyChanged("CONTENT");
					this.OnCONTENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTLDUNG", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string CTLDUNG
		{
			get
			{
				return this._CTLDUNG;
			}
			set
			{
				if ((this._CTLDUNG != value))
				{
					this.OnCTLDUNGChanging(value);
					this.SendPropertyChanging();
					this._CTLDUNG = value;
					this.SendPropertyChanged("CTLDUNG");
					this.OnCTLDUNGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTL1", DbType="NVarChar(200)")]
		public string CTL1
		{
			get
			{
				return this._CTL1;
			}
			set
			{
				if ((this._CTL1 != value))
				{
					this.OnCTL1Changing(value);
					this.SendPropertyChanging();
					this._CTL1 = value;
					this.SendPropertyChanged("CTL1");
					this.OnCTL1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTL2", DbType="NVarChar(200)")]
		public string CTL2
		{
			get
			{
				return this._CTL2;
			}
			set
			{
				if ((this._CTL2 != value))
				{
					this.OnCTL2Changing(value);
					this.SendPropertyChanging();
					this._CTL2 = value;
					this.SendPropertyChanged("CTL2");
					this.OnCTL2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTL3", DbType="NVarChar(200)")]
		public string CTL3
		{
			get
			{
				return this._CTL3;
			}
			set
			{
				if ((this._CTL3 != value))
				{
					this.OnCTL3Changing(value);
					this.SendPropertyChanging();
					this._CTL3 = value;
					this.SendPropertyChanged("CTL3");
					this.OnCTL3Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DERAL12")]
	public partial class DERAL12 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QID;
		
		private string _CONTENT;
		
		private string _CTLDUNG;
		
		private string _CTL1;
		
		private string _CTL2;
		
		private string _CTL3;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQIDChanging(int value);
    partial void OnQIDChanged();
    partial void OnCONTENTChanging(string value);
    partial void OnCONTENTChanged();
    partial void OnCTLDUNGChanging(string value);
    partial void OnCTLDUNGChanged();
    partial void OnCTL1Changing(string value);
    partial void OnCTL1Changed();
    partial void OnCTL2Changing(string value);
    partial void OnCTL2Changed();
    partial void OnCTL3Changing(string value);
    partial void OnCTL3Changed();
    #endregion
		
		public DERAL12()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int QID
		{
			get
			{
				return this._QID;
			}
			set
			{
				if ((this._QID != value))
				{
					this.OnQIDChanging(value);
					this.SendPropertyChanging();
					this._QID = value;
					this.SendPropertyChanged("QID");
					this.OnQIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTENT", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string CONTENT
		{
			get
			{
				return this._CONTENT;
			}
			set
			{
				if ((this._CONTENT != value))
				{
					this.OnCONTENTChanging(value);
					this.SendPropertyChanging();
					this._CONTENT = value;
					this.SendPropertyChanged("CONTENT");
					this.OnCONTENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTLDUNG", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string CTLDUNG
		{
			get
			{
				return this._CTLDUNG;
			}
			set
			{
				if ((this._CTLDUNG != value))
				{
					this.OnCTLDUNGChanging(value);
					this.SendPropertyChanging();
					this._CTLDUNG = value;
					this.SendPropertyChanged("CTLDUNG");
					this.OnCTLDUNGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTL1", DbType="NVarChar(200)")]
		public string CTL1
		{
			get
			{
				return this._CTL1;
			}
			set
			{
				if ((this._CTL1 != value))
				{
					this.OnCTL1Changing(value);
					this.SendPropertyChanging();
					this._CTL1 = value;
					this.SendPropertyChanged("CTL1");
					this.OnCTL1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTL2", DbType="NVarChar(200)")]
		public string CTL2
		{
			get
			{
				return this._CTL2;
			}
			set
			{
				if ((this._CTL2 != value))
				{
					this.OnCTL2Changing(value);
					this.SendPropertyChanging();
					this._CTL2 = value;
					this.SendPropertyChanged("CTL2");
					this.OnCTL2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTL3", DbType="NVarChar(200)")]
		public string CTL3
		{
			get
			{
				return this._CTL3;
			}
			set
			{
				if ((this._CTL3 != value))
				{
					this.OnCTL3Changing(value);
					this.SendPropertyChanging();
					this._CTL3 = value;
					this.SendPropertyChanged("CTL3");
					this.OnCTL3Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ELEVEN")]
	public partial class ELEVEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _STT;
		
		private string _BAI;
		
		private string _NAME;
		
		private string _CONTENT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSTTChanging(int value);
    partial void OnSTTChanged();
    partial void OnBAIChanging(string value);
    partial void OnBAIChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnCONTENTChanging(string value);
    partial void OnCONTENTChanged();
    #endregion
		
		public ELEVEN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int STT
		{
			get
			{
				return this._STT;
			}
			set
			{
				if ((this._STT != value))
				{
					this.OnSTTChanging(value);
					this.SendPropertyChanging();
					this._STT = value;
					this.SendPropertyChanged("STT");
					this.OnSTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BAI", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string BAI
		{
			get
			{
				return this._BAI;
			}
			set
			{
				if ((this._BAI != value))
				{
					this.OnBAIChanging(value);
					this.SendPropertyChanging();
					this._BAI = value;
					this.SendPropertyChanged("BAI");
					this.OnBAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="NVarChar(100)")]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTENT", DbType="VarChar(20)")]
		public string CONTENT
		{
			get
			{
				return this._CONTENT;
			}
			set
			{
				if ((this._CONTENT != value))
				{
					this.OnCONTENTChanging(value);
					this.SendPropertyChanging();
					this._CONTENT = value;
					this.SendPropertyChanged("CONTENT");
					this.OnCONTENTChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TENBASE")]
	public partial class TENBASE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _STT;
		
		private string _BAI;
		
		private string _NAME;
		
		private string _CONTENT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSTTChanging(int value);
    partial void OnSTTChanged();
    partial void OnBAIChanging(string value);
    partial void OnBAIChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnCONTENTChanging(string value);
    partial void OnCONTENTChanged();
    #endregion
		
		public TENBASE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int STT
		{
			get
			{
				return this._STT;
			}
			set
			{
				if ((this._STT != value))
				{
					this.OnSTTChanging(value);
					this.SendPropertyChanging();
					this._STT = value;
					this.SendPropertyChanged("STT");
					this.OnSTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BAI", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string BAI
		{
			get
			{
				return this._BAI;
			}
			set
			{
				if ((this._BAI != value))
				{
					this.OnBAIChanging(value);
					this.SendPropertyChanging();
					this._BAI = value;
					this.SendPropertyChanged("BAI");
					this.OnBAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="NVarChar(100)")]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTENT", DbType="VarChar(20)")]
		public string CONTENT
		{
			get
			{
				return this._CONTENT;
			}
			set
			{
				if ((this._CONTENT != value))
				{
					this.OnCONTENTChanging(value);
					this.SendPropertyChanging();
					this._CONTENT = value;
					this.SendPropertyChanged("CONTENT");
					this.OnCONTENTChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TWENTH")]
	public partial class TWENTH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _STT;
		
		private string _BAI;
		
		private string _NAME;
		
		private string _CONTENT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSTTChanging(int value);
    partial void OnSTTChanged();
    partial void OnBAIChanging(string value);
    partial void OnBAIChanged();
    partial void OnNAMEChanging(string value);
    partial void OnNAMEChanged();
    partial void OnCONTENTChanging(string value);
    partial void OnCONTENTChanged();
    #endregion
		
		public TWENTH()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int STT
		{
			get
			{
				return this._STT;
			}
			set
			{
				if ((this._STT != value))
				{
					this.OnSTTChanging(value);
					this.SendPropertyChanging();
					this._STT = value;
					this.SendPropertyChanged("STT");
					this.OnSTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BAI", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string BAI
		{
			get
			{
				return this._BAI;
			}
			set
			{
				if ((this._BAI != value))
				{
					this.OnBAIChanging(value);
					this.SendPropertyChanging();
					this._BAI = value;
					this.SendPropertyChanged("BAI");
					this.OnBAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAME", DbType="NVarChar(100)")]
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				if ((this._NAME != value))
				{
					this.OnNAMEChanging(value);
					this.SendPropertyChanging();
					this._NAME = value;
					this.SendPropertyChanged("NAME");
					this.OnNAMEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CONTENT", DbType="VarChar(20)")]
		public string CONTENT
		{
			get
			{
				return this._CONTENT;
			}
			set
			{
				if ((this._CONTENT != value))
				{
					this.OnCONTENTChanging(value);
					this.SendPropertyChanging();
					this._CONTENT = value;
					this.SendPropertyChanged("CONTENT");
					this.OnCONTENTChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591