using ServiceASA.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceASA.DataTransferObject;
using AutoMapper;

using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.Repository;
using ASArquiteruraData;

namespace ServiceASA.ServiceImplementation
{
    public class tb_clienteService : Itb_clienteService
    {

        #region Properties
        private static Itb_clienteRepository tb_clienteRepository { get; set; }
        #endregion

        #region Constructor
        static tb_clienteService()
        {

            Mapper.CreateMap<tb_cliente, tb_clienteDto>();
            Mapper.CreateMap<tb_clienteDto, tb_cliente>();


            tb_clienteRepository = new tb_clienteRepository();
        }
        #endregion


        public void Add(tb_cliente cliente)
        {
            tb_clienteRepository.Add(cliente);
        }

       

        public tb_clienteDto FindById(int id)
        {
            tb_cliente cat =  tb_clienteRepository.First(s => s.cli_id.Equals(id));
          

            return Mapper.Map<tb_cliente, tb_clienteDto>(cat);
        }

        public IList<tb_clienteDto> GetAll()
        {
           
             return Mapper.Map<IList<tb_cliente>, IList<tb_clienteDto>>(tb_clienteRepository.GetAll().ToList());

        }

        public void Update(tb_clienteDto cliente)
        {
            try
            {
                tb_clienteRepository.Update(Mapper.Map<tb_clienteDto, tb_cliente>(cliente));
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }





        public void Delete(tb_clienteDto cliente)
        {
            tb_clienteRepository.Delete(Mapper.Map<tb_clienteDto, tb_cliente>(cliente));
        }

   


        public void AddBulk(List<tb_cliente> cliente, bool deleteData)
        {
            tb_clienteRepository.AddAllList(cliente, false);
        }


      
    }
}
