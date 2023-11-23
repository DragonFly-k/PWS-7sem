﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 10/10/2021 8:45:04 PM
namespace ASP_labsModel
{
    
    /// <summary>
    /// There are no comments for ASP_labsEntities in the schema.
    /// </summary>
    public partial class ASP_labsEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new ASP_labsEntities object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public ASP_labsEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Notes> Notes
        {
            get
            {
                if ((this._Notes == null))
                {
                    this._Notes = base.CreateQuery<Notes>("Notes");
                }
                return this._Notes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Notes> _Notes;
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Students> Students
        {
            get
            {
                if ((this._Students == null))
                {
                    this._Students = base.CreateQuery<Students>("Students");
                }
                return this._Students;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Students> _Students;
        /// <summary>
        /// There are no comments for Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToNotes(Notes notes)
        {
            base.AddObject("Notes", notes);
        }
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToStudents(Students students)
        {
            base.AddObject("Students", students);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = "<edmx:Edmx Version=\"1.0\" xmlns:edmx=\"http://schemas.microsoft.com/ado/2007/06/edm" +
                "x\"><edmx:DataServices m:DataServiceVersion=\"1.0\" m:MaxDataServiceVersion=\"3.0\" x" +
                "mlns:m=\"http://schemas.microsoft.com/ado/2007/08/dataservices/metadata\"><Schema " +
                "Namespace=\"ASP_labsModel\" xmlns=\"http://schemas.microsoft.com/ado/2009/11/edm\"><" +
                "EntityType Name=\"Notes\"><Key><PropertyRef Name=\"Id\" /></Key><Property Name=\"Id\" " +
                "Type=\"Edm.Int32\" Nullable=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"" +
                "http://schemas.microsoft.com/ado/2009/02/edm/annotation\" /><Property Name=\"Stude" +
                "ntId\" Type=\"Edm.Int32\" /><Property Name=\"Subj\" Type=\"Edm.String\" MaxLength=\"50\" " +
                "FixedLength=\"false\" Unicode=\"false\" /><Property Name=\"Note\" Type=\"Edm.Int32\" /><" +
                "NavigationProperty Name=\"Students\" Relationship=\"ASP_labsModel.FK__Notes__Studen" +
                "tId__72C60C4A\" ToRole=\"Students\" FromRole=\"Notes\" /></EntityType><EntityType Nam" +
                "e=\"Students\"><Key><PropertyRef Name=\"Id\" /></Key><Property Name=\"Id\" Type=\"Edm.I" +
                "nt32\" Nullable=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"http://sche" +
                "mas.microsoft.com/ado/2009/02/edm/annotation\" /><Property Name=\"Name\" Type=\"Edm." +
                "String\" MaxLength=\"100\" FixedLength=\"false\" Unicode=\"true\" /><Property Name=\"Pho" +
                "ne\" Type=\"Edm.Int32\" Nullable=\"false\" /><NavigationProperty Name=\"Notes\" Relatio" +
                "nship=\"ASP_labsModel.FK__Notes__StudentId__72C60C4A\" ToRole=\"Notes\" FromRole=\"St" +
                "udents\" /></EntityType><Association Name=\"FK__Notes__StudentId__72C60C4A\"><End T" +
                "ype=\"ASP_labsModel.Students\" Role=\"Students\" Multiplicity=\"0..1\" /><End Type=\"AS" +
                "P_labsModel.Notes\" Role=\"Notes\" Multiplicity=\"*\" /><ReferentialConstraint><Princ" +
                "ipal Role=\"Students\"><PropertyRef Name=\"Id\" /></Principal><Dependent Role=\"Notes" +
                "\"><PropertyRef Name=\"StudentId\" /></Dependent></ReferentialConstraint></Associat" +
                "ion></Schema><Schema Namespace=\"PWS_6_odata\" xmlns=\"http://schemas.microsoft.com" +
                "/ado/2009/11/edm\"><EntityContainer Name=\"ASP_labsEntities\" m:IsDefaultEntityCont" +
                "ainer=\"true\"><EntitySet Name=\"Notes\" EntityType=\"ASP_labsModel.Notes\" /><EntityS" +
                "et Name=\"Students\" EntityType=\"ASP_labsModel.Students\" /><AssociationSet Name=\"F" +
                "K__Notes__StudentId__72C60C4A\" Association=\"ASP_labsModel.FK__Notes__StudentId__" +
                "72C60C4A\"><End Role=\"Notes\" EntitySet=\"Notes\" /><End Role=\"Students\" EntitySet=\"" +
                "Students\" /></AssociationSet></EntityContainer></Schema></edmx:DataServices></ed" +
                "mx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for ASP_labsModel.Notes in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Notes")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Notes : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Notes object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Notes CreateNotes(int ID)
        {
            Notes notes = new Notes();
            notes.Id = ID;
            return notes;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property StudentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> StudentId
        {
            get
            {
                return this._StudentId;
            }
            set
            {
                this.OnStudentIdChanging(value);
                this._StudentId = value;
                this.OnStudentIdChanged();
                this.OnPropertyChanged("StudentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _StudentId;
        partial void OnStudentIdChanging(global::System.Nullable<int> value);
        partial void OnStudentIdChanged();
        /// <summary>
        /// There are no comments for Property Subj in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Subj
        {
            get
            {
                return this._Subj;
            }
            set
            {
                this.OnSubjChanging(value);
                this._Subj = value;
                this.OnSubjChanged();
                this.OnPropertyChanged("Subj");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Subj;
        partial void OnSubjChanging(string value);
        partial void OnSubjChanged();
        /// <summary>
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Note;
        partial void OnNoteChanging(global::System.Nullable<int> value);
        partial void OnNoteChanged();
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Students Students
        {
            get
            {
                return this._Students;
            }
            set
            {
                this._Students = value;
                this.OnPropertyChanged("Students");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Students _Students;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ASP_labsModel.Students in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Students")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Students : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Students object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="phone">Initial value of Phone.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Students CreateStudents(int ID, int phone)
        {
            Students students = new Students();
            students.Id = ID;
            students.Phone = phone;
            return students;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Phone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                this.OnPhoneChanging(value);
                this._Phone = value;
                this.OnPhoneChanged();
                this.OnPropertyChanged("Phone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Phone;
        partial void OnPhoneChanging(int value);
        partial void OnPhoneChanged();
        /// <summary>
        /// There are no comments for Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Notes> Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this._Notes = value;
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Notes> _Notes = new global::System.Data.Services.Client.DataServiceCollection<Notes>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
