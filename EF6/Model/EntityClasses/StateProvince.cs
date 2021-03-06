﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'StateProvince'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class StateProvince : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="StateProvince"/> class.</summary>
		public StateProvince() : base()
		{
			this.Addresses = new HashSet<Address>();
			this.SalesTaxRates = new HashSet<SalesTaxRate>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the IsOnlyStateProvinceFlag field. </summary>
		[DataMember]
		public System.Boolean IsOnlyStateProvinceFlag { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		[DataMember]
		public System.String Name { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the StateProvinceCode field. </summary>
		[DataMember]
		public System.String StateProvinceCode { get; set;}
		/// <summary>Gets or sets the StateProvinceId field. </summary>
		[DataMember]
		public System.Int32 StateProvinceId { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Address.StateProvince - StateProvince.Addresses (m:1)'</summary>
		[DataMember]
		public virtual ICollection<Address> Addresses { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'StateProvince.CountryRegion - CountryRegion.StateProvinces (m:1)'</summary>
		[DataMember]
		public virtual CountryRegion CountryRegion { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesTaxRate.StateProvince - StateProvince.SalesTaxRates (m:1)'</summary>
		[DataMember]
		public virtual ICollection<SalesTaxRate> SalesTaxRates { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'StateProvince.SalesTerritory - SalesTerritory.StateProvinces (m:1)'</summary>
		[DataMember]
		public virtual SalesTerritory SalesTerritory { get; set;}
		#endregion
	}
}
