﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace L2S.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Address', mapped on table 'AdventureWorks.Person.Address'.</summary>
	[Table(Name="[Person].[Address]")]
	public partial class Address : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_addressId;
		private System.String	_addressLine1;
		private System.String	_addressLine2;
		private System.String	_city;
		private System.DateTime	_modifiedDate;
		private System.String	_postalCode;
		private System.Guid	_rowguid;
		private System.Int32	_stateProvinceId;
		private EntitySet <CustomerAddress> _customerAddresses;
		private EntitySet <EmployeeAddress> _employeeAddresses;
		private EntitySet <SalesOrderHeader> _salesOrderHeaders;
		private EntitySet <SalesOrderHeader> _salesOrderHeaders1;
		private EntityRef <StateProvince> _stateProvince;
		private EntitySet <VendorAddress> _vendorAddresses;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnAddressIdChanging(System.Int32 value);
		partial void OnAddressIdChanged();
		partial void OnAddressLine1Changing(System.String value);
		partial void OnAddressLine1Changed();
		partial void OnAddressLine2Changing(System.String value);
		partial void OnAddressLine2Changed();
		partial void OnCityChanging(System.String value);
		partial void OnCityChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnPostalCodeChanging(System.String value);
		partial void OnPostalCodeChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnStateProvinceIdChanging(System.Int32 value);
		partial void OnStateProvinceIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="Address"/> class.</summary>
		public Address()
		{
			_customerAddresses = new EntitySet<CustomerAddress>(new Action<CustomerAddress>(this.Attach_CustomerAddresses), new Action<CustomerAddress>(this.Detach_CustomerAddresses) );
			_employeeAddresses = new EntitySet<EmployeeAddress>(new Action<EmployeeAddress>(this.Attach_EmployeeAddresses), new Action<EmployeeAddress>(this.Detach_EmployeeAddresses) );
			_salesOrderHeaders = new EntitySet<SalesOrderHeader>(new Action<SalesOrderHeader>(this.Attach_SalesOrderHeaders), new Action<SalesOrderHeader>(this.Detach_SalesOrderHeaders) );
			_salesOrderHeaders1 = new EntitySet<SalesOrderHeader>(new Action<SalesOrderHeader>(this.Attach_SalesOrderHeaders1), new Action<SalesOrderHeader>(this.Detach_SalesOrderHeaders1) );
			_stateProvince = default(EntityRef<StateProvince>);
			_vendorAddresses = new EntitySet<VendorAddress>(new Action<VendorAddress>(this.Attach_VendorAddresses), new Action<VendorAddress>(this.Detach_VendorAddresses) );
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_CustomerAddresses(CustomerAddress entity)
		{
			this.SendPropertyChanging("CustomerAddresses");
			entity.Address = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_CustomerAddresses(CustomerAddress entity)
		{
			this.SendPropertyChanging("CustomerAddresses");
			entity.Address = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_EmployeeAddresses(EmployeeAddress entity)
		{
			this.SendPropertyChanging("EmployeeAddresses");
			entity.Address = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_EmployeeAddresses(EmployeeAddress entity)
		{
			this.SendPropertyChanging("EmployeeAddresses");
			entity.Address = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_SalesOrderHeaders(SalesOrderHeader entity)
		{
			this.SendPropertyChanging("SalesOrderHeaders");
			entity.Address = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_SalesOrderHeaders(SalesOrderHeader entity)
		{
			this.SendPropertyChanging("SalesOrderHeaders");
			entity.Address = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_SalesOrderHeaders1(SalesOrderHeader entity)
		{
			this.SendPropertyChanging("SalesOrderHeaders1");
			entity.Address1 = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_SalesOrderHeaders1(SalesOrderHeader entity)
		{
			this.SendPropertyChanging("SalesOrderHeaders1");
			entity.Address1 = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_VendorAddresses(VendorAddress entity)
		{
			this.SendPropertyChanging("VendorAddresses");
			entity.Address = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_VendorAddresses(VendorAddress entity)
		{
			this.SendPropertyChanging("VendorAddresses");
			entity.Address = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the AddressId field. Mapped on target field 'AddressID'. </summary>
		[Column(Name="AddressID", Storage="_addressId", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int32 AddressId
		{
			get	{ return _addressId; }
			set
			{
				if((_addressId != value))
				{
					OnAddressIdChanging(value);
					SendPropertyChanging("AddressId");
					_addressId = value;
					SendPropertyChanged("AddressId");
					OnAddressIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the AddressLine1 field. Mapped on target field 'AddressLine1'. </summary>
		[Column(Name="AddressLine1", Storage="_addressLine1", CanBeNull=false, DbType="nvarchar(60) NOT NULL")]
		public System.String AddressLine1
		{
			get	{ return _addressLine1; }
			set
			{
				if((_addressLine1 != value))
				{
					OnAddressLine1Changing(value);
					SendPropertyChanging("AddressLine1");
					_addressLine1 = value;
					SendPropertyChanged("AddressLine1");
					OnAddressLine1Changed();
				}
			}
		}

		/// <summary>Gets or sets the AddressLine2 field. Mapped on target field 'AddressLine2'. </summary>
		[Column(Name="AddressLine2", Storage="_addressLine2", DbType="nvarchar(60) NULL")]
		public System.String AddressLine2
		{
			get	{ return _addressLine2; }
			set
			{
				if((_addressLine2 != value))
				{
					OnAddressLine2Changing(value);
					SendPropertyChanging("AddressLine2");
					_addressLine2 = value;
					SendPropertyChanged("AddressLine2");
					OnAddressLine2Changed();
				}
			}
		}

		/// <summary>Gets or sets the City field. Mapped on target field 'City'. </summary>
		[Column(Name="City", Storage="_city", CanBeNull=false, DbType="nvarchar(30) NOT NULL")]
		public System.String City
		{
			get	{ return _city; }
			set
			{
				if((_city != value))
				{
					OnCityChanging(value);
					SendPropertyChanging("City");
					_city = value;
					SendPropertyChanged("City");
					OnCityChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		[Column(Name="ModifiedDate", Storage="_modifiedDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the PostalCode field. Mapped on target field 'PostalCode'. </summary>
		[Column(Name="PostalCode", Storage="_postalCode", CanBeNull=false, DbType="nvarchar(15) NOT NULL")]
		public System.String PostalCode
		{
			get	{ return _postalCode; }
			set
			{
				if((_postalCode != value))
				{
					OnPostalCodeChanging(value);
					SendPropertyChanging("PostalCode");
					_postalCode = value;
					SendPropertyChanged("PostalCode");
					OnPostalCodeChanged();
				}
			}
		}

		/// <summary>Gets or sets the Rowguid field. Mapped on target field 'rowguid'. </summary>
		[Column(Name="rowguid", Storage="_rowguid", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="uniqueidentifier NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid Rowguid
		{
			get	{ return _rowguid; }
			set
			{
				if((_rowguid != value))
				{
					OnRowguidChanging(value);
					SendPropertyChanging("Rowguid");
					_rowguid = value;
					SendPropertyChanged("Rowguid");
					OnRowguidChanged();
				}
			}
		}

		/// <summary>Gets or sets the StateProvinceId field. Mapped on target field 'StateProvinceID'. </summary>
		[Column(Name="StateProvinceID", Storage="_stateProvinceId", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 StateProvinceId
		{
			get	{ return _stateProvinceId; }
			set
			{
				if((_stateProvinceId != value))
				{
					if(_stateProvince.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnStateProvinceIdChanging(value);
					SendPropertyChanging("StateProvinceId");
					_stateProvinceId = value;
					SendPropertyChanged("StateProvinceId");
					OnStateProvinceIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'CustomerAddress.Address - Address.CustomerAddresses (m:1)'</summary>
		[Association(Name="CustomerAddress_Addressaa2cda66a08a4dd79c546c1833605c8e", Storage="_customerAddresses", OtherKey="AddressId")]
		public EntitySet<CustomerAddress> CustomerAddresses
		{
			get { return this._customerAddresses; }
			set { this._customerAddresses.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'EmployeeAddress.Address - Address.EmployeeAddresses (m:1)'</summary>
		[Association(Name="EmployeeAddress_Addressbd22e8ef8a93482abf983ea0b84276bd", Storage="_employeeAddresses", OtherKey="AddressId")]
		public EntitySet<EmployeeAddress> EmployeeAddresses
		{
			get { return this._employeeAddresses; }
			set { this._employeeAddresses.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.Address - Address.SalesOrderHeaders (m:1)'</summary>
		[Association(Name="SalesOrderHeader_Address947db26d776746528cad265631f42f16", Storage="_salesOrderHeaders", OtherKey="BillToAddressId")]
		public EntitySet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return this._salesOrderHeaders; }
			set { this._salesOrderHeaders.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.Address1 - Address.SalesOrderHeaders1 (m:1)'</summary>
		[Association(Name="SalesOrderHeader_Addressc3a2cfc434b44655acce779f61874e83", Storage="_salesOrderHeaders1", OtherKey="ShipToAddressId")]
		public EntitySet<SalesOrderHeader> SalesOrderHeaders1
		{
			get { return this._salesOrderHeaders1; }
			set { this._salesOrderHeaders1.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Address.StateProvince - StateProvince.Addresses (m:1)'</summary>
		[Association(Name="Address_StateProvince2c6fb96e26d04236ae51fb241f769560", Storage="_stateProvince", ThisKey="StateProvinceId", IsForeignKey=true)] 
		public StateProvince StateProvince
		{
			get { return _stateProvince.Entity; }
			set
			{
				StateProvince previousValue = _stateProvince.Entity;
				if((previousValue != value) || (_stateProvince.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("StateProvince");
					if(previousValue != null)
					{
						_stateProvince.Entity = null;
						previousValue.Addresses.Remove(this);
					}
					_stateProvince.Entity = value;
					if(value == null)
					{
						_stateProvinceId = default(System.Int32);
					}
					else
					{
						value.Addresses.Add(this);
						_stateProvinceId = value.StateProvinceId;
					}
					this.SendPropertyChanged("StateProvince");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'VendorAddress.Address - Address.VendorAddresses (m:1)'</summary>
		[Association(Name="VendorAddress_Address3a3c04911dbe42189b3af85d0223f01a", Storage="_vendorAddresses", OtherKey="AddressId")]
		public EntitySet<VendorAddress> VendorAddresses
		{
			get { return this._vendorAddresses; }
			set { this._vendorAddresses.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649