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
	/// <summary>Class which represents the entity 'ProductProductPhoto', mapped on table 'AdventureWorks.Production.ProductProductPhoto'.</summary>
	[Table(Name="[Production].[ProductProductPhoto]")]
	public partial class ProductProductPhoto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.DateTime	_modifiedDate;
		private System.Boolean	_primary;
		private System.Int32	_productId;
		private System.Int32	_productPhotoId;
		private EntityRef <Product> _product;
		private EntityRef <ProductPhoto> _productPhoto;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnPrimaryChanging(System.Boolean value);
		partial void OnPrimaryChanged();
		partial void OnProductIdChanging(System.Int32 value);
		partial void OnProductIdChanged();
		partial void OnProductPhotoIdChanging(System.Int32 value);
		partial void OnProductPhotoIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="ProductProductPhoto"/> class.</summary>
		public ProductProductPhoto()
		{
			_product = default(EntityRef<Product>);
			_productPhoto = default(EntityRef<ProductPhoto>);
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
		

		#region Class Property Declarations
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

		/// <summary>Gets or sets the Primary field. Mapped on target field 'Primary'. </summary>
		[Column(Name="Primary", Storage="_primary", CanBeNull=false, DbType="bit NOT NULL")]
		public System.Boolean Primary
		{
			get	{ return _primary; }
			set
			{
				if((_primary != value))
				{
					OnPrimaryChanging(value);
					SendPropertyChanging("Primary");
					_primary = value;
					SendPropertyChanged("Primary");
					OnPrimaryChanged();
				}
			}
		}

		/// <summary>Gets or sets the ProductId field. Mapped on target field 'ProductID'. </summary>
		[Column(Name="ProductID", Storage="_productId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 ProductId
		{
			get	{ return _productId; }
			set
			{
				if((_productId != value))
				{
					if(_product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnProductIdChanging(value);
					SendPropertyChanging("ProductId");
					_productId = value;
					SendPropertyChanged("ProductId");
					OnProductIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the ProductPhotoId field. Mapped on target field 'ProductPhotoID'. </summary>
		[Column(Name="ProductPhotoID", Storage="_productPhotoId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 ProductPhotoId
		{
			get	{ return _productPhotoId; }
			set
			{
				if((_productPhotoId != value))
				{
					if(_productPhoto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnProductPhotoIdChanging(value);
					SendPropertyChanging("ProductPhotoId");
					_productPhotoId = value;
					SendPropertyChanged("ProductPhotoId");
					OnProductPhotoIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'ProductProductPhoto.Product - Product.ProductProductPhotos (m:1)'</summary>
		[Association(Name="ProductProductPhoto_Product8fa0e9fb804f4b3dbc53396294410f98", Storage="_product", ThisKey="ProductId", IsForeignKey=true)] 
		public Product Product
		{
			get { return _product.Entity; }
			set
			{
				Product previousValue = _product.Entity;
				if((previousValue != value) || (_product.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Product");
					if(previousValue != null)
					{
						_product.Entity = null;
						previousValue.ProductProductPhotos.Remove(this);
					}
					_product.Entity = value;
					if(value == null)
					{
						_productId = default(System.Int32);
					}
					else
					{
						value.ProductProductPhotos.Add(this);
						_productId = value.ProductId;
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'ProductProductPhoto.ProductPhoto - ProductPhoto.ProductProductPhotos (m:1)'</summary>
		[Association(Name="ProductProductPhoto_ProductPhoto7da8bba3794243b0b453e0aff347f705", Storage="_productPhoto", ThisKey="ProductPhotoId", IsForeignKey=true)] 
		public ProductPhoto ProductPhoto
		{
			get { return _productPhoto.Entity; }
			set
			{
				ProductPhoto previousValue = _productPhoto.Entity;
				if((previousValue != value) || (_productPhoto.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("ProductPhoto");
					if(previousValue != null)
					{
						_productPhoto.Entity = null;
						previousValue.ProductProductPhotos.Remove(this);
					}
					_productPhoto.Entity = value;
					if(value == null)
					{
						_productPhotoId = default(System.Int32);
					}
					else
					{
						value.ProductProductPhotos.Add(this);
						_productPhotoId = value.ProductPhotoId;
					}
					this.SendPropertyChanged("ProductPhoto");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649