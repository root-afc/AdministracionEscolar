//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServicioGeneroAlumnoActivos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GeneroAlumnoActivo", Namespace="http://schemas.datacontract.org/2004/07/WCF_Notas")]
    [System.SerializableAttribute()]
    public partial class GeneroAlumnoActivo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ActivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneroField;
        
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
        public int Activo {
            get {
                return this.ActivoField;
            }
            set {
                if ((this.ActivoField.Equals(value) != true)) {
                    this.ActivoField = value;
                    this.RaisePropertyChanged("Activo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genero {
            get {
                return this.GeneroField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneroField, value) != true)) {
                    this.GeneroField = value;
                    this.RaisePropertyChanged("Genero");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioGeneroAlumnoActivos.IServicioGeneroAlumnoActivo")]
    public interface IServicioGeneroAlumnoActivo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGeneroAlumnoActivo/GetGeneroAlumnoActivos", ReplyAction="http://tempuri.org/IServicioGeneroAlumnoActivo/GetGeneroAlumnoActivosResponse")]
        Client.ServicioGeneroAlumnoActivos.GeneroAlumnoActivo[] GetGeneroAlumnoActivos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioGeneroAlumnoActivo/GetGeneroAlumnoActivos", ReplyAction="http://tempuri.org/IServicioGeneroAlumnoActivo/GetGeneroAlumnoActivosResponse")]
        System.Threading.Tasks.Task<Client.ServicioGeneroAlumnoActivos.GeneroAlumnoActivo[]> GetGeneroAlumnoActivosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioGeneroAlumnoActivoChannel : Client.ServicioGeneroAlumnoActivos.IServicioGeneroAlumnoActivo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioGeneroAlumnoActivoClient : System.ServiceModel.ClientBase<Client.ServicioGeneroAlumnoActivos.IServicioGeneroAlumnoActivo>, Client.ServicioGeneroAlumnoActivos.IServicioGeneroAlumnoActivo {
        
        public ServicioGeneroAlumnoActivoClient() {
        }
        
        public ServicioGeneroAlumnoActivoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioGeneroAlumnoActivoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioGeneroAlumnoActivoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioGeneroAlumnoActivoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.ServicioGeneroAlumnoActivos.GeneroAlumnoActivo[] GetGeneroAlumnoActivos() {
            return base.Channel.GetGeneroAlumnoActivos();
        }
        
        public System.Threading.Tasks.Task<Client.ServicioGeneroAlumnoActivos.GeneroAlumnoActivo[]> GetGeneroAlumnoActivosAsync() {
            return base.Channel.GetGeneroAlumnoActivosAsync();
        }
    }
}
