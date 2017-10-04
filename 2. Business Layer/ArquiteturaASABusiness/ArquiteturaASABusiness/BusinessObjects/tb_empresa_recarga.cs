using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_empresa_recarga
    {
        #region Primitive Properties
        public virtual Int32 emprec_id { get; set; }

        public virtual String emprec_nome { get; set; }

        public virtual String emprec_contato { get; set; }

        public virtual String emprec_telefones { get; set; }

        public virtual Nullable<Decimal> emprec_perc_comissao { get; set; }

        public virtual String emprec_situacao { get; set; }

        public virtual Nullable<DateTime> emprec_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> emprec_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> emprec_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_financeiro_prazo tb_financeiro_prazo { get; set; }

        public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

        private ICollection<tb_recarga> _tb_recarga;
        public virtual ICollection<tb_recarga> tb_recarga
        {
            get
            {
                if (_tb_recarga == null)
                    _tb_recarga = new List<tb_recarga>();
                return _tb_recarga;
            }
            set { _tb_recarga = value; }
        }

        #endregion
    }
    
}
