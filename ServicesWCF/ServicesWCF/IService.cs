using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServicesWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetUsers(int usersId);

       
    }

  
    [DataContract]
    public class Users
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido { get; set; }
    }
    public class Service : IService
    {
        public string GetUsers(int usersId)
        {
            return  Users
            {
                Nombre = "Ivan",
                Apellido = "Pereya"
            };

        }
    }
}
