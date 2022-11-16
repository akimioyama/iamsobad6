﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iamsobad6
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="iamsobad")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertStudentList(StudentList instance);
    partial void UpdateStudentList(StudentList instance);
    partial void DeleteStudentList(StudentList instance);
    partial void InsertSubject(Subject instance);
    partial void UpdateSubject(Subject instance);
    partial void DeleteSubject(Subject instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::iamsobad6.Properties.Settings.Default.iamsobadConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<StudentList> StudentList
		{
			get
			{
				return this.GetTable<StudentList>();
			}
		}
		
		public System.Data.Linq.Table<Subject> Subject
		{
			get
			{
				return this.GetTable<Subject>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetStudentById")]
		public ISingleResult<GetStudentByIdResult> GetStudentById([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> stId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), stId);
			return ((ISingleResult<GetStudentByIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetStudentByFIO")]
		public ISingleResult<GetStudentByFIOResult> GetStudentByFIO([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string stName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), stName);
			return ((ISingleResult<GetStudentByFIOResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetSubject")]
		public ISingleResult<GetSubjectResult> GetSubject([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string subName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), subName);
			return ((ISingleResult<GetSubjectResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StudentList")]
	public partial class StudentList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_student;
		
		private string _FIO;
		
		private string _id_grupp;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_studentChanging(int value);
    partial void Onid_studentChanged();
    partial void OnFIOChanging(string value);
    partial void OnFIOChanged();
    partial void Onid_gruppChanging(string value);
    partial void Onid_gruppChanged();
    #endregion
		
		public StudentList()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_student", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_student
		{
			get
			{
				return this._id_student;
			}
			set
			{
				if ((this._id_student != value))
				{
					this.Onid_studentChanging(value);
					this.SendPropertyChanging();
					this._id_student = value;
					this.SendPropertyChanged("id_student");
					this.Onid_studentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FIO", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FIO
		{
			get
			{
				return this._FIO;
			}
			set
			{
				if ((this._FIO != value))
				{
					this.OnFIOChanging(value);
					this.SendPropertyChanging();
					this._FIO = value;
					this.SendPropertyChanged("FIO");
					this.OnFIOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_grupp", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string id_grupp
		{
			get
			{
				return this._id_grupp;
			}
			set
			{
				if ((this._id_grupp != value))
				{
					this.Onid_gruppChanging(value);
					this.SendPropertyChanging();
					this._id_grupp = value;
					this.SendPropertyChanged("id_grupp");
					this.Onid_gruppChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Subject")]
	public partial class Subject : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_subject;
		
		private string _name_subject;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_subjectChanging(int value);
    partial void Onid_subjectChanged();
    partial void Onname_subjectChanging(string value);
    partial void Onname_subjectChanged();
    #endregion
		
		public Subject()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_subject", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id_subject
		{
			get
			{
				return this._id_subject;
			}
			set
			{
				if ((this._id_subject != value))
				{
					this.Onid_subjectChanging(value);
					this.SendPropertyChanging();
					this._id_subject = value;
					this.SendPropertyChanged("id_subject");
					this.Onid_subjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_subject", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name_subject
		{
			get
			{
				return this._name_subject;
			}
			set
			{
				if ((this._name_subject != value))
				{
					this.Onname_subjectChanging(value);
					this.SendPropertyChanging();
					this._name_subject = value;
					this.SendPropertyChanged("name_subject");
					this.Onname_subjectChanged();
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
	
	public partial class GetStudentByIdResult
	{
		
		private int _id_student;
		
		private string _FIO;
		
		private string _id_grupp;
		
		public GetStudentByIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_student", DbType="Int NOT NULL")]
		public int id_student
		{
			get
			{
				return this._id_student;
			}
			set
			{
				if ((this._id_student != value))
				{
					this._id_student = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FIO", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FIO
		{
			get
			{
				return this._FIO;
			}
			set
			{
				if ((this._FIO != value))
				{
					this._FIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_grupp", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string id_grupp
		{
			get
			{
				return this._id_grupp;
			}
			set
			{
				if ((this._id_grupp != value))
				{
					this._id_grupp = value;
				}
			}
		}
	}
	
	public partial class GetStudentByFIOResult
	{
		
		private int _id_student;
		
		private string _FIO;
		
		private string _id_grupp;
		
		public GetStudentByFIOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_student", DbType="Int NOT NULL")]
		public int id_student
		{
			get
			{
				return this._id_student;
			}
			set
			{
				if ((this._id_student != value))
				{
					this._id_student = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FIO", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FIO
		{
			get
			{
				return this._FIO;
			}
			set
			{
				if ((this._FIO != value))
				{
					this._FIO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_grupp", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string id_grupp
		{
			get
			{
				return this._id_grupp;
			}
			set
			{
				if ((this._id_grupp != value))
				{
					this._id_grupp = value;
				}
			}
		}
	}
	
	public partial class GetSubjectResult
	{
		
		private int _id_subject;
		
		private string _name_subject;
		
		public GetSubjectResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_subject", DbType="Int NOT NULL")]
		public int id_subject
		{
			get
			{
				return this._id_subject;
			}
			set
			{
				if ((this._id_subject != value))
				{
					this._id_subject = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name_subject", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name_subject
		{
			get
			{
				return this._name_subject;
			}
			set
			{
				if ((this._name_subject != value))
				{
					this._name_subject = value;
				}
			}
		}
	}
}
#pragma warning restore 1591