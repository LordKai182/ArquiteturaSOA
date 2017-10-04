using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_tipo_logradouro
    {
        #region Primitive Properties
        public virtual Int32 tiplog_id { get; set; }

        public virtual String tiplog_abreviatura { get; set; }

        public virtual String tiplog_descricao { get; set; }

        public virtual String tiplog_situacao { get; set; }

        public virtual Nullable<DateTime> tiplog_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> tiplog_dt_alteracao { get; set; }

        public virtual String tiplog_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
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
