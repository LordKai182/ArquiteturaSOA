using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;
namespace ASArquiteruraData.Repository
{
 public   class tb_checkout_itemRepository :Repository<tb_checkout_item> ,Itb_checkout_itemRepository
    {
    }
}
