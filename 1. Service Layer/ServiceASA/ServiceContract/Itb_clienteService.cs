
using ASArquiteruraData;
using ServiceASA.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ServiceASA.ServiceContract
{   [ServiceContract]
   public interface Itb_clienteService
    {

        [OperationContract]
        IList<tb_clienteDto> GetAll();

        [OperationContract]
        tb_clienteDto FindById(Int32 id);

        [OperationContract]
        void Delete(tb_clienteDto cliente);

        [OperationContract]
        void Update(tb_clienteDto cliente);

        [OperationContract]
        void Add(tb_cliente cliente);

        [OperationContract]
        void AddBulk(List<tb_cliente> cliente,bool deleteData);
    }
}
