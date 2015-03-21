using Loteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Loteria
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ILoteriaNacional
    {
        [OperationContract]
        int NumeroGanador();

        [OperationContract]
        Premio PremioMayor();

        [OperationContract]
        void AgregarPremio(Premio premio);

        [OperationContract]
        double TipoCambio();
    }
}
