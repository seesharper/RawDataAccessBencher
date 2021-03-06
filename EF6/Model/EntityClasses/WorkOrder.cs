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
	/// <summary>Class which represents the entity 'WorkOrder'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class WorkOrder : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="WorkOrder"/> class.</summary>
		public WorkOrder() : base()
		{
			this.WorkOrderRoutings = new HashSet<WorkOrderRouting>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the DueDate field. </summary>
		[DataMember]
		public System.DateTime DueDate { get; set;}
		/// <summary>Gets or sets the EndDate field. </summary>
		[DataMember]
		public Nullable<System.DateTime> EndDate { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the OrderQty field. </summary>
		[DataMember]
		public System.Int32 OrderQty { get; set;}
		/// <summary>Gets or sets the ScrappedQty field. </summary>
		[DataMember]
		public System.Int16 ScrappedQty { get; set;}
		/// <summary>Gets or sets the StartDate field. </summary>
		[DataMember]
		public System.DateTime StartDate { get; set;}
		/// <summary>Gets or sets the StockedQty field. </summary>
		[DataMember]
		public System.Int32 StockedQty { get; set;}
		/// <summary>Gets or sets the WorkOrderId field. </summary>
		[DataMember]
		public System.Int32 WorkOrderId { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'WorkOrder.Product - Product.WorkOrders (m:1)'</summary>
		[DataMember]
		public virtual Product Product { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'WorkOrder.ScrapReason - ScrapReason.WorkOrders (m:1)'</summary>
		[DataMember]
		public virtual ScrapReason ScrapReason { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'WorkOrderRouting.WorkOrder - WorkOrder.WorkOrderRoutings (m:1)'</summary>
		[DataMember]
		public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set;}
		#endregion
	}
}
