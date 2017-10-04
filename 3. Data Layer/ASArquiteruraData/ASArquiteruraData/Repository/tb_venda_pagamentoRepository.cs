using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;
namespace ASArquiteruraData.Repository
{
  public  class tb_venda_pagamentoRepository : Repository<tb_venda_pagamento> , Itb_venda_pagamentoRepository
    {
    }
}
