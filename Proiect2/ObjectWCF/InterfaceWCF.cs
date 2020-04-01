using ModelMyPhotos;
using System.Collections.Generic;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePhoto
    {
        [OperationContract]
        void AddPhoto(Photos newPhoto);
    }
}