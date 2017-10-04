using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.GenericRepository;

namespace ASArquiteruraData.Repository
{
public    class tb_usuario_grupoRepository : Repository<tb_usuario_grupo> , Itb_usuario_grupoRepository
    {
    }
}
