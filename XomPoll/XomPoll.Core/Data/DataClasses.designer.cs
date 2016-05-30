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

namespace XomPoll.Core.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="xompoll")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAnswer(Answer instance);
    partial void UpdateAnswer(Answer instance);
    partial void DeleteAnswer(Answer instance);
    partial void InsertAnswerOption(AnswerOption instance);
    partial void UpdateAnswerOption(AnswerOption instance);
    partial void DeleteAnswerOption(AnswerOption instance);
    partial void InsertQuestionType(QuestionType instance);
    partial void UpdateQuestionType(QuestionType instance);
    partial void DeleteQuestionType(QuestionType instance);
    partial void InsertEvent(Event instance);
    partial void UpdateEvent(Event instance);
    partial void DeleteEvent(Event instance);
    partial void InsertQuestion(Question instance);
    partial void UpdateQuestion(Question instance);
    partial void DeleteQuestion(Question instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::XomPoll.Core.Properties.Settings.Default.xompollConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Answer> Answers
		{
			get
			{
				return this.GetTable<Answer>();
			}
		}
		
		public System.Data.Linq.Table<AnswerOption> AnswerOptions
		{
			get
			{
				return this.GetTable<AnswerOption>();
			}
		}
		
		public System.Data.Linq.Table<QuestionType> QuestionTypes
		{
			get
			{
				return this.GetTable<QuestionType>();
			}
		}
		
		public System.Data.Linq.Table<Event> Events
		{
			get
			{
				return this.GetTable<Event>();
			}
		}
		
		public System.Data.Linq.Table<Question> Questions
		{
			get
			{
				return this.GetTable<Question>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Answer")]
	public partial class Answer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _QuestionId;
		
		private int _AnswerOptionId;
		
		private string _Descritpion;
		
		private EntityRef<AnswerOption> _AnswerOption;
		
		private EntityRef<Question> _Question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnQuestionIdChanging(int value);
    partial void OnQuestionIdChanged();
    partial void OnAnswerOptionIdChanging(int value);
    partial void OnAnswerOptionIdChanged();
    partial void OnDescritpionChanging(string value);
    partial void OnDescritpionChanged();
    #endregion
		
		public Answer()
		{
			this._AnswerOption = default(EntityRef<AnswerOption>);
			this._Question = default(EntityRef<Question>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionId", DbType="Int NOT NULL")]
		public int QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					if (this._Question.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnswerOptionId", DbType="Int NOT NULL")]
		public int AnswerOptionId
		{
			get
			{
				return this._AnswerOptionId;
			}
			set
			{
				if ((this._AnswerOptionId != value))
				{
					if (this._AnswerOption.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAnswerOptionIdChanging(value);
					this.SendPropertyChanging();
					this._AnswerOptionId = value;
					this.SendPropertyChanged("AnswerOptionId");
					this.OnAnswerOptionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descritpion", DbType="NVarChar(4000)")]
		public string Descritpion
		{
			get
			{
				return this._Descritpion;
			}
			set
			{
				if ((this._Descritpion != value))
				{
					this.OnDescritpionChanging(value);
					this.SendPropertyChanging();
					this._Descritpion = value;
					this.SendPropertyChanged("Descritpion");
					this.OnDescritpionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AnswerOption_Answer", Storage="_AnswerOption", ThisKey="AnswerOptionId", OtherKey="Id", IsForeignKey=true)]
		public AnswerOption AnswerOption
		{
			get
			{
				return this._AnswerOption.Entity;
			}
			set
			{
				AnswerOption previousValue = this._AnswerOption.Entity;
				if (((previousValue != value) 
							|| (this._AnswerOption.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AnswerOption.Entity = null;
						previousValue.Answers.Remove(this);
					}
					this._AnswerOption.Entity = value;
					if ((value != null))
					{
						value.Answers.Add(this);
						this._AnswerOptionId = value.Id;
					}
					else
					{
						this._AnswerOptionId = default(int);
					}
					this.SendPropertyChanged("AnswerOption");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Question_Answer", Storage="_Question", ThisKey="QuestionId", OtherKey="Id", IsForeignKey=true)]
		public Question Question
		{
			get
			{
				return this._Question.Entity;
			}
			set
			{
				Question previousValue = this._Question.Entity;
				if (((previousValue != value) 
							|| (this._Question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Question.Entity = null;
						previousValue.Answers.Remove(this);
					}
					this._Question.Entity = value;
					if ((value != null))
					{
						value.Answers.Add(this);
						this._QuestionId = value.Id;
					}
					else
					{
						this._QuestionId = default(int);
					}
					this.SendPropertyChanged("Question");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AnswerOption")]
	public partial class AnswerOption : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Description;
		
		private int _QuestionId;
		
		private EntitySet<Answer> _Answers;
		
		private EntityRef<Question> _Question;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnQuestionIdChanging(int value);
    partial void OnQuestionIdChanged();
    #endregion
		
		public AnswerOption()
		{
			this._Answers = new EntitySet<Answer>(new Action<Answer>(this.attach_Answers), new Action<Answer>(this.detach_Answers));
			this._Question = default(EntityRef<Question>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(4000)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionId", DbType="Int NOT NULL")]
		public int QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					if (this._Question.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="AnswerOption_Answer", Storage="_Answers", ThisKey="Id", OtherKey="AnswerOptionId")]
		public EntitySet<Answer> Answers
		{
			get
			{
				return this._Answers;
			}
			set
			{
				this._Answers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Question_AnswerOption", Storage="_Question", ThisKey="QuestionId", OtherKey="Id", IsForeignKey=true)]
		public Question Question
		{
			get
			{
				return this._Question.Entity;
			}
			set
			{
				Question previousValue = this._Question.Entity;
				if (((previousValue != value) 
							|| (this._Question.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Question.Entity = null;
						previousValue.AnswerOptions.Remove(this);
					}
					this._Question.Entity = value;
					if ((value != null))
					{
						value.AnswerOptions.Add(this);
						this._QuestionId = value.Id;
					}
					else
					{
						this._QuestionId = default(int);
					}
					this.SendPropertyChanged("Question");
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
		
		private void attach_Answers(Answer entity)
		{
			this.SendPropertyChanging();
			entity.AnswerOption = this;
		}
		
		private void detach_Answers(Answer entity)
		{
			this.SendPropertyChanging();
			entity.AnswerOption = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QuestionType")]
	public partial class QuestionType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Description;
		
		private EntitySet<Question> _Questions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public QuestionType()
		{
			this._Questions = new EntitySet<Question>(new Action<Question>(this.attach_Questions), new Action<Question>(this.detach_Questions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuestionType_Question", Storage="_Questions", ThisKey="Id", OtherKey="QuestionTypeId")]
		public EntitySet<Question> Questions
		{
			get
			{
				return this._Questions;
			}
			set
			{
				this._Questions.Assign(value);
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
		
		private void attach_Questions(Question entity)
		{
			this.SendPropertyChanging();
			entity.QuestionType = this;
		}
		
		private void detach_Questions(Question entity)
		{
			this.SendPropertyChanging();
			entity.QuestionType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Event")]
	public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Description;
		
		private string _UrlName;
		
		private System.DateTime _InitDate;
		
		private System.DateTime _EndDate;
		
		private EntitySet<Question> _Questions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnUrlNameChanging(string value);
    partial void OnUrlNameChanged();
    partial void OnInitDateChanging(System.DateTime value);
    partial void OnInitDateChanged();
    partial void OnEndDateChanging(System.DateTime value);
    partial void OnEndDateChanged();
    #endregion
		
		public Event()
		{
			this._Questions = new EntitySet<Question>(new Action<Question>(this.attach_Questions), new Action<Question>(this.detach_Questions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(4000)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrlName", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string UrlName
		{
			get
			{
				return this._UrlName;
			}
			set
			{
				if ((this._UrlName != value))
				{
					this.OnUrlNameChanging(value);
					this.SendPropertyChanging();
					this._UrlName = value;
					this.SendPropertyChanged("UrlName");
					this.OnUrlNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InitDate", DbType="DateTime NOT NULL")]
		public System.DateTime InitDate
		{
			get
			{
				return this._InitDate;
			}
			set
			{
				if ((this._InitDate != value))
				{
					this.OnInitDateChanging(value);
					this.SendPropertyChanging();
					this._InitDate = value;
					this.SendPropertyChanged("InitDate");
					this.OnInitDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="DateTime NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_Question", Storage="_Questions", ThisKey="Id", OtherKey="EventId")]
		public EntitySet<Question> Questions
		{
			get
			{
				return this._Questions;
			}
			set
			{
				this._Questions.Assign(value);
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
		
		private void attach_Questions(Question entity)
		{
			this.SendPropertyChanging();
			entity.Event = this;
		}
		
		private void detach_Questions(Question entity)
		{
			this.SendPropertyChanging();
			entity.Event = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Question")]
	public partial class Question : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _EventId;
		
		private int _QuestionTypeId;
		
		private string _Description;
		
		private EntitySet<Answer> _Answers;
		
		private EntitySet<AnswerOption> _AnswerOptions;
		
		private EntityRef<Event> _Event;
		
		private EntityRef<QuestionType> _QuestionType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEventIdChanging(int value);
    partial void OnEventIdChanged();
    partial void OnQuestionTypeIdChanging(int value);
    partial void OnQuestionTypeIdChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Question()
		{
			this._Answers = new EntitySet<Answer>(new Action<Answer>(this.attach_Answers), new Action<Answer>(this.detach_Answers));
			this._AnswerOptions = new EntitySet<AnswerOption>(new Action<AnswerOption>(this.attach_AnswerOptions), new Action<AnswerOption>(this.detach_AnswerOptions));
			this._Event = default(EntityRef<Event>);
			this._QuestionType = default(EntityRef<QuestionType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventId", DbType="Int NOT NULL")]
		public int EventId
		{
			get
			{
				return this._EventId;
			}
			set
			{
				if ((this._EventId != value))
				{
					if (this._Event.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEventIdChanging(value);
					this.SendPropertyChanging();
					this._EventId = value;
					this.SendPropertyChanged("EventId");
					this.OnEventIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionTypeId", DbType="Int NOT NULL")]
		public int QuestionTypeId
		{
			get
			{
				return this._QuestionTypeId;
			}
			set
			{
				if ((this._QuestionTypeId != value))
				{
					if (this._QuestionType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionTypeIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionTypeId = value;
					this.SendPropertyChanged("QuestionTypeId");
					this.OnQuestionTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(4000) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Question_Answer", Storage="_Answers", ThisKey="Id", OtherKey="QuestionId")]
		public EntitySet<Answer> Answers
		{
			get
			{
				return this._Answers;
			}
			set
			{
				this._Answers.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Question_AnswerOption", Storage="_AnswerOptions", ThisKey="Id", OtherKey="QuestionId")]
		public EntitySet<AnswerOption> AnswerOptions
		{
			get
			{
				return this._AnswerOptions;
			}
			set
			{
				this._AnswerOptions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Event_Question", Storage="_Event", ThisKey="EventId", OtherKey="Id", IsForeignKey=true)]
		public Event Event
		{
			get
			{
				return this._Event.Entity;
			}
			set
			{
				Event previousValue = this._Event.Entity;
				if (((previousValue != value) 
							|| (this._Event.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Event.Entity = null;
						previousValue.Questions.Remove(this);
					}
					this._Event.Entity = value;
					if ((value != null))
					{
						value.Questions.Add(this);
						this._EventId = value.Id;
					}
					else
					{
						this._EventId = default(int);
					}
					this.SendPropertyChanged("Event");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuestionType_Question", Storage="_QuestionType", ThisKey="QuestionTypeId", OtherKey="Id", IsForeignKey=true)]
		public QuestionType QuestionType
		{
			get
			{
				return this._QuestionType.Entity;
			}
			set
			{
				QuestionType previousValue = this._QuestionType.Entity;
				if (((previousValue != value) 
							|| (this._QuestionType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._QuestionType.Entity = null;
						previousValue.Questions.Remove(this);
					}
					this._QuestionType.Entity = value;
					if ((value != null))
					{
						value.Questions.Add(this);
						this._QuestionTypeId = value.Id;
					}
					else
					{
						this._QuestionTypeId = default(int);
					}
					this.SendPropertyChanged("QuestionType");
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
		
		private void attach_Answers(Answer entity)
		{
			this.SendPropertyChanging();
			entity.Question = this;
		}
		
		private void detach_Answers(Answer entity)
		{
			this.SendPropertyChanging();
			entity.Question = null;
		}
		
		private void attach_AnswerOptions(AnswerOption entity)
		{
			this.SendPropertyChanging();
			entity.Question = this;
		}
		
		private void detach_AnswerOptions(AnswerOption entity)
		{
			this.SendPropertyChanging();
			entity.Question = null;
		}
	}
}
#pragma warning restore 1591