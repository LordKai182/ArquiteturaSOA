using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;
namespace ASArquiteruraData.Repository
{
   public class tb_liquidacao_motivoRepository : Repository<tb_liquidacao_motivo> , Itb_liquidacao_motivoRepository
    {
    }
}
