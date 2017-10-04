using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;
namespace ASArquiteruraData.Repository
{
  public  class tb_cliente_enderecoRepository : Repository<tb_cliente_endereco> , Itb_cliente_enderecoRepository
    {
    }
}
