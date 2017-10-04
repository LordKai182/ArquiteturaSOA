using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_ibge
    {
        #region Primitive Properties
        public virtual Int32 ibge_codigo { get; set; }

        public virtual String ibge_municipio { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_cadastro_contador> _tb_cadastro_contador;
        public virtual ICollection<tb_cadastro_contador> tb_cadastro_contador
        {
            get
            {
                if (_tb_cadastro_contador == null)
                    _tb_cadastro_contador = new List<tb_cadastro_contador>();
                return _tb_cadastro_contador;
            }
            set { _tb_cadastro_contador = value; }
        }

        public virtual tb_uf tb_uf { get; set; }

        private ICollection<tb_unid_negocio> _tb_unid_negocio;
        public virtual ICollection<tb_unid_negocio> tb_unid_negocio
        {
            get
            {
                if (_tb_unid_negocio == null)
                    _tb_unid_negocio = new List<tb_unid_negocio>();
                return _tb_unid_negocio;
            }
            set { _tb_unid_negocio = value; }
        }

        #endregion
    }
}
