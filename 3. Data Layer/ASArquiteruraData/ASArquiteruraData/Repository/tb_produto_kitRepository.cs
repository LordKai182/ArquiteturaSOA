﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;

namespace ASArquiteruraData.Repository
{
public  class tb_produto_kitRepository : Repository<tb_produto_kit> ,Itb_produto_kitRepository
    {
    }
}
