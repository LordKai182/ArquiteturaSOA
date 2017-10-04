using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;

namespace ASArquiteruraData.Repository
{
    public class tb_checkin_itemRepository : Repository<tb_checkin_item>, Itb_checkin_itemRepository
    {
    }
}
