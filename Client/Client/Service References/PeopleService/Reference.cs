﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.PeopleService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Actor", Namespace="http://schemas.datacontract.org/2004/07/ActorsAndDirectors.Models")]
    [System.SerializableAttribute()]
    public partial class Actor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AliveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaritalStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] MovieIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlaceOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RealNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Alive {
            get {
                return this.AliveField;
            }
            set {
                if ((this.AliveField.Equals(value) != true)) {
                    this.AliveField = value;
                    this.RaisePropertyChanged("Alive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Height {
            get {
                return this.HeightField;
            }
            set {
                if ((this.HeightField.Equals(value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MaritalStatus {
            get {
                return this.MaritalStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.MaritalStatusField, value) != true)) {
                    this.MaritalStatusField = value;
                    this.RaisePropertyChanged("MaritalStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] MovieId {
            get {
                return this.MovieIdField;
            }
            set {
                if ((object.ReferenceEquals(this.MovieIdField, value) != true)) {
                    this.MovieIdField = value;
                    this.RaisePropertyChanged("MovieId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlaceOfBirth {
            get {
                return this.PlaceOfBirthField;
            }
            set {
                if ((object.ReferenceEquals(this.PlaceOfBirthField, value) != true)) {
                    this.PlaceOfBirthField = value;
                    this.RaisePropertyChanged("PlaceOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RealName {
            get {
                return this.RealNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RealNameField, value) != true)) {
                    this.RealNameField = value;
                    this.RaisePropertyChanged("RealName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Director", Namespace="http://schemas.datacontract.org/2004/07/ActorsAndDirectors.Models")]
    [System.SerializableAttribute()]
    public partial class Director : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AliveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HeightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaritalStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] MovieIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlaceOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RealNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Alive {
            get {
                return this.AliveField;
            }
            set {
                if ((this.AliveField.Equals(value) != true)) {
                    this.AliveField = value;
                    this.RaisePropertyChanged("Alive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Height {
            get {
                return this.HeightField;
            }
            set {
                if ((this.HeightField.Equals(value) != true)) {
                    this.HeightField = value;
                    this.RaisePropertyChanged("Height");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MaritalStatus {
            get {
                return this.MaritalStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.MaritalStatusField, value) != true)) {
                    this.MaritalStatusField = value;
                    this.RaisePropertyChanged("MaritalStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] MovieId {
            get {
                return this.MovieIdField;
            }
            set {
                if ((object.ReferenceEquals(this.MovieIdField, value) != true)) {
                    this.MovieIdField = value;
                    this.RaisePropertyChanged("MovieId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonId {
            get {
                return this.PersonIdField;
            }
            set {
                if ((this.PersonIdField.Equals(value) != true)) {
                    this.PersonIdField = value;
                    this.RaisePropertyChanged("PersonId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlaceOfBirth {
            get {
                return this.PlaceOfBirthField;
            }
            set {
                if ((object.ReferenceEquals(this.PlaceOfBirthField, value) != true)) {
                    this.PlaceOfBirthField = value;
                    this.RaisePropertyChanged("PlaceOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RealName {
            get {
                return this.RealNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RealNameField, value) != true)) {
                    this.RealNameField = value;
                    this.RaisePropertyChanged("RealName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PeopleService.IPeopleService")]
    public interface IPeopleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetActors", ReplyAction="http://tempuri.org/IPeopleService/GetActorsResponse")]
        Client.PeopleService.Actor[] GetActors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetActors", ReplyAction="http://tempuri.org/IPeopleService/GetActorsResponse")]
        System.Threading.Tasks.Task<Client.PeopleService.Actor[]> GetActorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetDirector", ReplyAction="http://tempuri.org/IPeopleService/GetDirectorResponse")]
        Client.PeopleService.Director GetDirector(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetDirector", ReplyAction="http://tempuri.org/IPeopleService/GetDirectorResponse")]
        System.Threading.Tasks.Task<Client.PeopleService.Director> GetDirectorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetActor", ReplyAction="http://tempuri.org/IPeopleService/GetActorResponse")]
        Client.PeopleService.Actor GetActor(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetActor", ReplyAction="http://tempuri.org/IPeopleService/GetActorResponse")]
        System.Threading.Tasks.Task<Client.PeopleService.Actor> GetActorAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetDirectors", ReplyAction="http://tempuri.org/IPeopleService/GetDirectorsResponse")]
        Client.PeopleService.Director[] GetDirectors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetDirectors", ReplyAction="http://tempuri.org/IPeopleService/GetDirectorsResponse")]
        System.Threading.Tasks.Task<Client.PeopleService.Director[]> GetDirectorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/AddActor", ReplyAction="http://tempuri.org/IPeopleService/AddActorResponse")]
        Client.PeopleService.Actor AddActor(Client.PeopleService.Actor a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/AddActor", ReplyAction="http://tempuri.org/IPeopleService/AddActorResponse")]
        System.Threading.Tasks.Task<Client.PeopleService.Actor> AddActorAsync(Client.PeopleService.Actor a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/AddDirector", ReplyAction="http://tempuri.org/IPeopleService/AddDirectorResponse")]
        Client.PeopleService.Director AddDirector(Client.PeopleService.Director d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/AddDirector", ReplyAction="http://tempuri.org/IPeopleService/AddDirectorResponse")]
        System.Threading.Tasks.Task<Client.PeopleService.Director> AddDirectorAsync(Client.PeopleService.Director d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/DeleteActor", ReplyAction="http://tempuri.org/IPeopleService/DeleteActorResponse")]
        void DeleteActor(Client.PeopleService.Actor a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/DeleteActor", ReplyAction="http://tempuri.org/IPeopleService/DeleteActorResponse")]
        System.Threading.Tasks.Task DeleteActorAsync(Client.PeopleService.Actor a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/DeleteDirector", ReplyAction="http://tempuri.org/IPeopleService/DeleteDirectorResponse")]
        void DeleteDirector(Client.PeopleService.Director d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/DeleteDirector", ReplyAction="http://tempuri.org/IPeopleService/DeleteDirectorResponse")]
        System.Threading.Tasks.Task DeleteDirectorAsync(Client.PeopleService.Director d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/UpdateActor", ReplyAction="http://tempuri.org/IPeopleService/UpdateActorResponse")]
        bool UpdateActor(Client.PeopleService.Actor a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/UpdateActor", ReplyAction="http://tempuri.org/IPeopleService/UpdateActorResponse")]
        System.Threading.Tasks.Task<bool> UpdateActorAsync(Client.PeopleService.Actor a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/UpdateDirector", ReplyAction="http://tempuri.org/IPeopleService/UpdateDirectorResponse")]
        bool UpdateDirector(Client.PeopleService.Director d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/UpdateDirector", ReplyAction="http://tempuri.org/IPeopleService/UpdateDirectorResponse")]
        System.Threading.Tasks.Task<bool> UpdateDirectorAsync(Client.PeopleService.Director d);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetActorsByName", ReplyAction="http://tempuri.org/IPeopleService/GetActorsByNameResponse")]
        Client.PeopleService.Actor[] GetActorsByName(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetActorsByName", ReplyAction="http://tempuri.org/IPeopleService/GetActorsByNameResponse")]
        System.Threading.Tasks.Task<Client.PeopleService.Actor[]> GetActorsByNameAsync(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetDirectorsByName", ReplyAction="http://tempuri.org/IPeopleService/GetDirectorsByNameResponse")]
        Client.PeopleService.Director[] GetDirectorsByName(string s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeopleService/GetDirectorsByName", ReplyAction="http://tempuri.org/IPeopleService/GetDirectorsByNameResponse")]
        System.Threading.Tasks.Task<Client.PeopleService.Director[]> GetDirectorsByNameAsync(string s);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPeopleServiceChannel : Client.PeopleService.IPeopleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeopleServiceClient : System.ServiceModel.ClientBase<Client.PeopleService.IPeopleService>, Client.PeopleService.IPeopleService {
        
        public PeopleServiceClient() {
        }
        
        public PeopleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeopleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.PeopleService.Actor[] GetActors() {
            return base.Channel.GetActors();
        }
        
        public System.Threading.Tasks.Task<Client.PeopleService.Actor[]> GetActorsAsync() {
            return base.Channel.GetActorsAsync();
        }
        
        public Client.PeopleService.Director GetDirector(int id) {
            return base.Channel.GetDirector(id);
        }
        
        public System.Threading.Tasks.Task<Client.PeopleService.Director> GetDirectorAsync(int id) {
            return base.Channel.GetDirectorAsync(id);
        }
        
        public Client.PeopleService.Actor GetActor(int id) {
            return base.Channel.GetActor(id);
        }
        
        public System.Threading.Tasks.Task<Client.PeopleService.Actor> GetActorAsync(int id) {
            return base.Channel.GetActorAsync(id);
        }
        
        public Client.PeopleService.Director[] GetDirectors() {
            return base.Channel.GetDirectors();
        }
        
        public System.Threading.Tasks.Task<Client.PeopleService.Director[]> GetDirectorsAsync() {
            return base.Channel.GetDirectorsAsync();
        }
        
        public Client.PeopleService.Actor AddActor(Client.PeopleService.Actor a) {
            return base.Channel.AddActor(a);
        }
        
        public System.Threading.Tasks.Task<Client.PeopleService.Actor> AddActorAsync(Client.PeopleService.Actor a) {
            return base.Channel.AddActorAsync(a);
        }
        
        public Client.PeopleService.Director AddDirector(Client.PeopleService.Director d) {
            return base.Channel.AddDirector(d);
        }
        
        public System.Threading.Tasks.Task<Client.PeopleService.Director> AddDirectorAsync(Client.PeopleService.Director d) {
            return base.Channel.AddDirectorAsync(d);
        }
        
        public void DeleteActor(Client.PeopleService.Actor a) {
            base.Channel.DeleteActor(a);
        }
        
        public System.Threading.Tasks.Task DeleteActorAsync(Client.PeopleService.Actor a) {
            return base.Channel.DeleteActorAsync(a);
        }
        
        public void DeleteDirector(Client.PeopleService.Director d) {
            base.Channel.DeleteDirector(d);
        }
        
        public System.Threading.Tasks.Task DeleteDirectorAsync(Client.PeopleService.Director d) {
            return base.Channel.DeleteDirectorAsync(d);
        }
        
        public bool UpdateActor(Client.PeopleService.Actor a) {
            return base.Channel.UpdateActor(a);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateActorAsync(Client.PeopleService.Actor a) {
            return base.Channel.UpdateActorAsync(a);
        }
        
        public bool UpdateDirector(Client.PeopleService.Director d) {
            return base.Channel.UpdateDirector(d);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateDirectorAsync(Client.PeopleService.Director d) {
            return base.Channel.UpdateDirectorAsync(d);
        }
        
        public Client.PeopleService.Actor[] GetActorsByName(string s) {
            return base.Channel.GetActorsByName(s);
        }
        
        public System.Threading.Tasks.Task<Client.PeopleService.Actor[]> GetActorsByNameAsync(string s) {
            return base.Channel.GetActorsByNameAsync(s);
        }
        
        public Client.PeopleService.Director[] GetDirectorsByName(string s) {
            return base.Channel.GetDirectorsByName(s);
        }
        
        public System.Threading.Tasks.Task<Client.PeopleService.Director[]> GetDirectorsByNameAsync(string s) {
            return base.Channel.GetDirectorsByNameAsync(s);
        }
    }
}
