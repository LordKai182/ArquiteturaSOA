using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;
namespace ASArquiteruraData.Repository
{
 public   class tb_cliente_telefoneRepository :Repository<tb_cliente_telefone> , Itb_cliente_telefoneRepository
    {
    }
}
