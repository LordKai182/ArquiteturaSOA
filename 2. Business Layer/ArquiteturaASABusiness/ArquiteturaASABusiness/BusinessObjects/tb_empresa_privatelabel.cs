using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_empresa_privatelabel
    {
        #region Primitive Properties
        public virtual Int32 emplabel_id { get; set; }

        public virtual String emplabel_nome { get; set; }

        public virtual String emplabel_contato { get; set; }

        public virtual String emplabel_telefones { get; set; }

        public virtual Nullable<Decimal> emplabel_perc_comissao { get; set; }

        public virtual String emplabel_situacao { get; set; }

        public virtual Nullable<DateTime> emplabel_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> emplabel_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> emplabel_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_financeiro_prazo tb_financeiro_prazo { get; set; }

        public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

        private ICollection<tb_privatelabel> _tb_privatelabel;
        public virtual ICollection<tb_privatelabel> tb_privatelabel
        {
            get
            {
                if (_tb_privatelabel == null)
                    _tb_privatelabel = new List<tb_privatelabel>();
                return _tb_privatelabel;
            }
            set { _tb_privatelabel = value; }
        }

        #endregion
    }
}
