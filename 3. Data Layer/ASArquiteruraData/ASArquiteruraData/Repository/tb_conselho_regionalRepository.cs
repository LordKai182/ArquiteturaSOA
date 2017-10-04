using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;
namespace ASArquiteruraData.Repository
{
  public  class tb_conselho_regionalRepository : Repository<tb_conselho_regional> , Itb_conselho_regionalRepository
    {
    }
}
