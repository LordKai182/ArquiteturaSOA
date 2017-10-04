using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;
namespace ASArquiteruraData.Repository
{
   public class tb_cliente_fiscalRepository :Repository<tb_cliente_fiscal> , Itb_cliente_fiscalRepository
    {
    }
}
