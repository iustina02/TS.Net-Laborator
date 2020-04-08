using ModelMyPhotos;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePhoto
    {
        [OperationContract]
        bool AddPhoto(Photos newPhoto);

        [OperationContract]
        Photos UpdatePhoto(Photos newPhoto);

        [OperationContract]
        int DeletePhoto(int id);

        [OperationContract]
        List<Photos> GetPhotoByDate(DateTime date);

        [OperationContract]
        List<Photos> GetPhotoByEvent(string eveniment);

        [OperationContract]
        List<Photos> GetPhotoByLandscape(string landscape);

        [OperationContract]
        Photos GetPhotoByPath(string path);
    }

    [ServiceContract]
    interface InterfaceFilm
    {
        [OperationContract]
        bool AddFilm(Films newFilm);

        [OperationContract]
        Films UpdateFilm(Films newFilm);

        [OperationContract]
        int DeleteFilm(int id);

        [OperationContract]
        List<Films> GetFilmByDate(DateTime date);

        [OperationContract]
        List<Films> GetFilmByEvent(string eveniment);

        [OperationContract]
        List<Films> GetFilmByLandscape(string landscape);
    }

    [ServiceContract]
    interface InterfacePersons
    {
        [OperationContract]
        List<Photos> GetPhotosByPersonName(string personName);

        [OperationContract]
        List<Photos> GetPhotosByPersonDescription(string personDescription);

        [OperationContract]
        List<Films> GetFilmsByPersonName(string personName);

        [OperationContract]
        List<Films> GetFilmsByPersonDescription(string personDescription);
    }

    [ServiceContract]
    interface InterfacePlaces
    {
        [OperationContract]
        List<Photos> GetPhotosByCountry(string country);

        [OperationContract]
        List<Photos> GetPhotosByCity(string city);

        [OperationContract]
        List<Photos> GetPhotosByRegion(string region);

        [OperationContract]
        List<Films> GetFilmsByCountry(string country);

        [OperationContract]
        List<Films> GetFilmsByCity(string city);

        [OperationContract]
        List<Films> GetFilmssByRegion(string region);
    }

    [ServiceContract]
    interface IModelMyPhotos : InterfacePhoto, InterfaceFilm, InterfacePersons, InterfacePlaces
    {
    }

}