﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace GTalkReminderSite.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ReminderDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ReminderDBEntities object using the connection string found in the 'ReminderDBEntities' section of the application configuration file.
        /// </summary>
        public ReminderDBEntities() : base("name=ReminderDBEntities", "ReminderDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ReminderDBEntities object.
        /// </summary>
        public ReminderDBEntities(string connectionString) : base(connectionString, "ReminderDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ReminderDBEntities object.
        /// </summary>
        public ReminderDBEntities(EntityConnection connection) : base(connection, "ReminderDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Task> Tasks
        {
            get
            {
                if ((_Tasks == null))
                {
                    _Tasks = base.CreateObjectSet<Task>("Tasks");
                }
                return _Tasks;
            }
        }
        private ObjectSet<Task> _Tasks;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tasks EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTasks(Task task)
        {
            base.AddObject("Tasks", task);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReminderDBModel", Name="Task")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Task : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Task object.
        /// </summary>
        /// <param name="taskID">Initial value of the taskID property.</param>
        /// <param name="title">Initial value of the title property.</param>
        /// <param name="message">Initial value of the message property.</param>
        /// <param name="startTime">Initial value of the startTime property.</param>
        /// <param name="endTime">Initial value of the endTime property.</param>
        /// <param name="interval">Initial value of the interval property.</param>
        /// <param name="recipients">Initial value of the recipients property.</param>
        public static Task CreateTask(global::System.Int32 taskID, global::System.String title, global::System.String message, global::System.DateTime startTime, global::System.DateTime endTime, global::System.String interval, global::System.String recipients)
        {
            Task task = new Task();
            task.taskID = taskID;
            task.title = title;
            task.message = message;
            task.startTime = startTime;
            task.endTime = endTime;
            task.interval = interval;
            task.recipients = recipients;
            return task;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 taskID
        {
            get
            {
                return _taskID;
            }
            set
            {
                if (_taskID != value)
                {
                    OntaskIDChanging(value);
                    ReportPropertyChanging("taskID");
                    _taskID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("taskID");
                    OntaskIDChanged();
                }
            }
        }
        private global::System.Int32 _taskID;
        partial void OntaskIDChanging(global::System.Int32 value);
        partial void OntaskIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String title
        {
            get
            {
                return _title;
            }
            set
            {
                OntitleChanging(value);
                ReportPropertyChanging("title");
                _title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("title");
                OntitleChanged();
            }
        }
        private global::System.String _title;
        partial void OntitleChanging(global::System.String value);
        partial void OntitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String message
        {
            get
            {
                return _message;
            }
            set
            {
                OnmessageChanging(value);
                ReportPropertyChanging("message");
                _message = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("message");
                OnmessageChanged();
            }
        }
        private global::System.String _message;
        partial void OnmessageChanging(global::System.String value);
        partial void OnmessageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime startTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                OnstartTimeChanging(value);
                ReportPropertyChanging("startTime");
                _startTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("startTime");
                OnstartTimeChanged();
            }
        }
        private global::System.DateTime _startTime;
        partial void OnstartTimeChanging(global::System.DateTime value);
        partial void OnstartTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime endTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                OnendTimeChanging(value);
                ReportPropertyChanging("endTime");
                _endTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("endTime");
                OnendTimeChanged();
            }
        }
        private global::System.DateTime _endTime;
        partial void OnendTimeChanging(global::System.DateTime value);
        partial void OnendTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String interval
        {
            get
            {
                return _interval;
            }
            set
            {
                OnintervalChanging(value);
                ReportPropertyChanging("interval");
                _interval = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("interval");
                OnintervalChanged();
            }
        }
        private global::System.String _interval;
        partial void OnintervalChanging(global::System.String value);
        partial void OnintervalChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String recipients
        {
            get
            {
                return _recipients;
            }
            set
            {
                OnrecipientsChanging(value);
                ReportPropertyChanging("recipients");
                _recipients = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("recipients");
                OnrecipientsChanged();
            }
        }
        private global::System.String _recipients;
        partial void OnrecipientsChanging(global::System.String value);
        partial void OnrecipientsChanged();

        #endregion
    
    }

    #endregion
    
}
