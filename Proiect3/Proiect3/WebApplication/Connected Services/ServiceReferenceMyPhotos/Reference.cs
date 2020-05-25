﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferenceMyPhotos
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Photos", Namespace="http://schemas.datacontract.org/2004/07/ModelMyPhotos", IsReference=true)]
    public partial class Photos : object
    {
        
        private System.Nullable<System.DateTime> DateField;
        
        private string EventField;
        
        private string LandscapeField;
        
        private string PathField;
        
        private System.Collections.Generic.List<ServiceReferenceMyPhotos.Persons> Persons_PhotoField;
        
        private int Photo_IdField;
        
        private ServiceReferenceMyPhotos.Places Places_PhotoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Landscape
        {
            get
            {
                return this.LandscapeField;
            }
            set
            {
                this.LandscapeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceMyPhotos.Persons> Persons_Photo
        {
            get
            {
                return this.Persons_PhotoField;
            }
            set
            {
                this.Persons_PhotoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Photo_Id
        {
            get
            {
                return this.Photo_IdField;
            }
            set
            {
                this.Photo_IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceReferenceMyPhotos.Places Places_Photo
        {
            get
            {
                return this.Places_PhotoField;
            }
            set
            {
                this.Places_PhotoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Places", Namespace="http://schemas.datacontract.org/2004/07/ModelMyPhotos", IsReference=true)]
    public partial class Places : object
    {
        
        private string CityField;
        
        private string CountryField;
        
        private System.Collections.Generic.List<ServiceReferenceMyPhotos.Films> FilmsField;
        
        private System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos> PhotosField;
        
        private int Place_IdField;
        
        private string RegionField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country
        {
            get
            {
                return this.CountryField;
            }
            set
            {
                this.CountryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceMyPhotos.Films> Films
        {
            get
            {
                return this.FilmsField;
            }
            set
            {
                this.FilmsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos> Photos
        {
            get
            {
                return this.PhotosField;
            }
            set
            {
                this.PhotosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Place_Id
        {
            get
            {
                return this.Place_IdField;
            }
            set
            {
                this.Place_IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Region
        {
            get
            {
                return this.RegionField;
            }
            set
            {
                this.RegionField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persons", Namespace="http://schemas.datacontract.org/2004/07/ModelMyPhotos", IsReference=true)]
    public partial class Persons : object
    {
        
        private string DescriptionField;
        
        private System.Collections.Generic.List<ServiceReferenceMyPhotos.Films> FilmsField;
        
        private string NameField;
        
        private int Person_IdField;
        
        private System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos> PhotosField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceMyPhotos.Films> Films
        {
            get
            {
                return this.FilmsField;
            }
            set
            {
                this.FilmsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Person_Id
        {
            get
            {
                return this.Person_IdField;
            }
            set
            {
                this.Person_IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos> Photos
        {
            get
            {
                return this.PhotosField;
            }
            set
            {
                this.PhotosField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Films", Namespace="http://schemas.datacontract.org/2004/07/ModelMyPhotos", IsReference=true)]
    public partial class Films : object
    {
        
        private System.Nullable<System.DateTime> DateField;
        
        private string EventField;
        
        private int Film_IdField;
        
        private string LandscapeField;
        
        private string PathField;
        
        private System.Collections.Generic.List<ServiceReferenceMyPhotos.Persons> PersonsField;
        
        private System.Collections.Generic.List<ServiceReferenceMyPhotos.Places> Places_PhotoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Film_Id
        {
            get
            {
                return this.Film_IdField;
            }
            set
            {
                this.Film_IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Landscape
        {
            get
            {
                return this.LandscapeField;
            }
            set
            {
                this.LandscapeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceMyPhotos.Persons> Persons
        {
            get
            {
                return this.PersonsField;
            }
            set
            {
                this.PersonsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<ServiceReferenceMyPhotos.Places> Places_Photo
        {
            get
            {
                return this.Places_PhotoField;
            }
            set
            {
                this.Places_PhotoField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceMyPhotos.IModelMyPhotos")]
    public interface IModelMyPhotos
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhoto/AddPhoto", ReplyAction="http://tempuri.org/InterfacePhoto/AddPhotoResponse")]
        System.Threading.Tasks.Task<bool> AddPhotoAsync(ServiceReferenceMyPhotos.Photos newPhoto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhoto/UpdatePhoto", ReplyAction="http://tempuri.org/InterfacePhoto/UpdatePhotoResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Photos> UpdatePhotoAsync(ServiceReferenceMyPhotos.Photos newPhoto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhoto/DeletePhoto", ReplyAction="http://tempuri.org/InterfacePhoto/DeletePhotoResponse")]
        System.Threading.Tasks.Task<int> DeletePhotoAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhoto/GetPhotoByDate", ReplyAction="http://tempuri.org/InterfacePhoto/GetPhotoByDateResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotoByDateAsync(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhoto/GetPhotoByEvent", ReplyAction="http://tempuri.org/InterfacePhoto/GetPhotoByEventResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotoByEventAsync(string eveniment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhoto/GetPhotoByLandscape", ReplyAction="http://tempuri.org/InterfacePhoto/GetPhotoByLandscapeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotoByLandscapeAsync(string landscape);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhoto/GetPhotoByPath", ReplyAction="http://tempuri.org/InterfacePhoto/GetPhotoByPathResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Photos> GetPhotoByPathAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePhoto/GetAllPhotos", ReplyAction="http://tempuri.org/InterfacePhoto/GetAllPhotosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetAllPhotosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFilm/AddFilm", ReplyAction="http://tempuri.org/InterfaceFilm/AddFilmResponse")]
        System.Threading.Tasks.Task<bool> AddFilmAsync(ServiceReferenceMyPhotos.Films newFilm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFilm/UpdateFilm", ReplyAction="http://tempuri.org/InterfaceFilm/UpdateFilmResponse")]
        System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Films> UpdateFilmAsync(ServiceReferenceMyPhotos.Films newFilm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFilm/DeleteFilm", ReplyAction="http://tempuri.org/InterfaceFilm/DeleteFilmResponse")]
        System.Threading.Tasks.Task<int> DeleteFilmAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFilm/GetFilmByDate", ReplyAction="http://tempuri.org/InterfaceFilm/GetFilmByDateResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmByDateAsync(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFilm/GetFilmByEvent", ReplyAction="http://tempuri.org/InterfaceFilm/GetFilmByEventResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmByEventAsync(string eveniment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFilm/GetFilmByLandscape", ReplyAction="http://tempuri.org/InterfaceFilm/GetFilmByLandscapeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmByLandscapeAsync(string landscape);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFilm/GetAllFilms", ReplyAction="http://tempuri.org/InterfaceFilm/GetAllFilmsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetAllFilmsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePersons/GetPhotosByPersonName", ReplyAction="http://tempuri.org/InterfacePersons/GetPhotosByPersonNameResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotosByPersonNameAsync(string personName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePersons/GetPhotosByPersonDescription", ReplyAction="http://tempuri.org/InterfacePersons/GetPhotosByPersonDescriptionResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotosByPersonDescriptionAsync(string personDescription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePersons/GetFilmsByPersonName", ReplyAction="http://tempuri.org/InterfacePersons/GetFilmsByPersonNameResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmsByPersonNameAsync(string personName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePersons/GetFilmsByPersonDescription", ReplyAction="http://tempuri.org/InterfacePersons/GetFilmsByPersonDescriptionResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmsByPersonDescriptionAsync(string personDescription);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePersons/GetAllPersonsPhoto", ReplyAction="http://tempuri.org/InterfacePersons/GetAllPersonsPhotoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Persons>> GetAllPersonsPhotoAsync(int photo_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePersons/GetAllPersonsFilm", ReplyAction="http://tempuri.org/InterfacePersons/GetAllPersonsFilmResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Persons>> GetAllPersonsFilmAsync(int film_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePlaces/GetPhotosByCountry", ReplyAction="http://tempuri.org/InterfacePlaces/GetPhotosByCountryResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotosByCountryAsync(string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePlaces/GetPhotosByCity", ReplyAction="http://tempuri.org/InterfacePlaces/GetPhotosByCityResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotosByCityAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePlaces/GetPhotosByRegion", ReplyAction="http://tempuri.org/InterfacePlaces/GetPhotosByRegionResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotosByRegionAsync(string region);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePlaces/GetFilmsByCountry", ReplyAction="http://tempuri.org/InterfacePlaces/GetFilmsByCountryResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmsByCountryAsync(string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePlaces/GetFilmsByCity", ReplyAction="http://tempuri.org/InterfacePlaces/GetFilmsByCityResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmsByCityAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePlaces/GetFilmssByRegion", ReplyAction="http://tempuri.org/InterfacePlaces/GetFilmssByRegionResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmssByRegionAsync(string region);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePlaces/GetAllPlacesPhoto", ReplyAction="http://tempuri.org/InterfacePlaces/GetAllPlacesPhotoResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Places>> GetAllPlacesPhotoAsync(int photo_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePlaces/GetAllPlacesFilm", ReplyAction="http://tempuri.org/InterfacePlaces/GetAllPlacesFilmResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Places>> GetAllPlacesFilmAsync(int film_id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IModelMyPhotosChannel : ServiceReferenceMyPhotos.IModelMyPhotos, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ModelMyPhotosClient : System.ServiceModel.ClientBase<ServiceReferenceMyPhotos.IModelMyPhotos>, ServiceReferenceMyPhotos.IModelMyPhotos
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ModelMyPhotosClient() : 
                base(ModelMyPhotosClient.GetDefaultBinding(), ModelMyPhotosClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.netTcpBinding_IModelMyPhotos.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ModelMyPhotosClient(EndpointConfiguration endpointConfiguration) : 
                base(ModelMyPhotosClient.GetBindingForEndpoint(endpointConfiguration), ModelMyPhotosClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ModelMyPhotosClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ModelMyPhotosClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ModelMyPhotosClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ModelMyPhotosClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ModelMyPhotosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<bool> AddPhotoAsync(ServiceReferenceMyPhotos.Photos newPhoto)
        {
            return base.Channel.AddPhotoAsync(newPhoto);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Photos> UpdatePhotoAsync(ServiceReferenceMyPhotos.Photos newPhoto)
        {
            return base.Channel.UpdatePhotoAsync(newPhoto);
        }
        
        public System.Threading.Tasks.Task<int> DeletePhotoAsync(int id)
        {
            return base.Channel.DeletePhotoAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotoByDateAsync(System.DateTime date)
        {
            return base.Channel.GetPhotoByDateAsync(date);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotoByEventAsync(string eveniment)
        {
            return base.Channel.GetPhotoByEventAsync(eveniment);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotoByLandscapeAsync(string landscape)
        {
            return base.Channel.GetPhotoByLandscapeAsync(landscape);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Photos> GetPhotoByPathAsync(string path)
        {
            return base.Channel.GetPhotoByPathAsync(path);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetAllPhotosAsync()
        {
            return base.Channel.GetAllPhotosAsync();
        }
        
        public System.Threading.Tasks.Task<bool> AddFilmAsync(ServiceReferenceMyPhotos.Films newFilm)
        {
            return base.Channel.AddFilmAsync(newFilm);
        }
        
        public System.Threading.Tasks.Task<ServiceReferenceMyPhotos.Films> UpdateFilmAsync(ServiceReferenceMyPhotos.Films newFilm)
        {
            return base.Channel.UpdateFilmAsync(newFilm);
        }
        
        public System.Threading.Tasks.Task<int> DeleteFilmAsync(int id)
        {
            return base.Channel.DeleteFilmAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmByDateAsync(System.DateTime date)
        {
            return base.Channel.GetFilmByDateAsync(date);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmByEventAsync(string eveniment)
        {
            return base.Channel.GetFilmByEventAsync(eveniment);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmByLandscapeAsync(string landscape)
        {
            return base.Channel.GetFilmByLandscapeAsync(landscape);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetAllFilmsAsync()
        {
            return base.Channel.GetAllFilmsAsync();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotosByPersonNameAsync(string personName)
        {
            return base.Channel.GetPhotosByPersonNameAsync(personName);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotosByPersonDescriptionAsync(string personDescription)
        {
            return base.Channel.GetPhotosByPersonDescriptionAsync(personDescription);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmsByPersonNameAsync(string personName)
        {
            return base.Channel.GetFilmsByPersonNameAsync(personName);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmsByPersonDescriptionAsync(string personDescription)
        {
            return base.Channel.GetFilmsByPersonDescriptionAsync(personDescription);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Persons>> GetAllPersonsPhotoAsync(int photo_id)
        {
            return base.Channel.GetAllPersonsPhotoAsync(photo_id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Persons>> GetAllPersonsFilmAsync(int film_id)
        {
            return base.Channel.GetAllPersonsFilmAsync(film_id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotosByCountryAsync(string country)
        {
            return base.Channel.GetPhotosByCountryAsync(country);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotosByCityAsync(string city)
        {
            return base.Channel.GetPhotosByCityAsync(city);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Photos>> GetPhotosByRegionAsync(string region)
        {
            return base.Channel.GetPhotosByRegionAsync(region);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmsByCountryAsync(string country)
        {
            return base.Channel.GetFilmsByCountryAsync(country);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmsByCityAsync(string city)
        {
            return base.Channel.GetFilmsByCityAsync(city);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Films>> GetFilmssByRegionAsync(string region)
        {
            return base.Channel.GetFilmssByRegionAsync(region);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Places>> GetAllPlacesPhotoAsync(int photo_id)
        {
            return base.Channel.GetAllPlacesPhotoAsync(photo_id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ServiceReferenceMyPhotos.Places>> GetAllPlacesFilmAsync(int film_id)
        {
            return base.Channel.GetAllPlacesFilmAsync(film_id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.netTcpBinding_IModelMyPhotos))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.netTcpBinding_IModelMyPhotos))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ModelMyPhotosClient.GetBindingForEndpoint(EndpointConfiguration.netTcpBinding_IModelMyPhotos);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ModelMyPhotosClient.GetEndpointAddress(EndpointConfiguration.netTcpBinding_IModelMyPhotos);
        }
        
        public enum EndpointConfiguration
        {
            
            netTcpBinding_IModelMyPhotos,
        }
    }
}
