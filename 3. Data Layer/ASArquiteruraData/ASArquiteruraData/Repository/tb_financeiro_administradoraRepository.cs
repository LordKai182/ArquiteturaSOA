using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;
namespace ASArquiteruraData.Repository
{
  public  class tb_financeiro_administradoraRepository : Repository<tb_financeiro_administradora> , Itb_financeiro_administradoraRepository
    {
    }
}
