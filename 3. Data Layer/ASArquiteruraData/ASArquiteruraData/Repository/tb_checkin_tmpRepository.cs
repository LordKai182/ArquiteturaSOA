using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;

namespace ASArquiteruraData.Repository
{
 public class tb_checkin_tmpRepository :Repository<tb_checkin_tmp>, Itb_checkin_tmpRepository
    {
    }
}
