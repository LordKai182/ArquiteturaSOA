﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;
using ArquiteturaASABusiness.BusinessObjects;

namespace ASArquiteruraData.Repository
{
 public   class tb_pontoRepository : Repository<tb_ponto> , Itb_pontoRepository
    {
    }
}
