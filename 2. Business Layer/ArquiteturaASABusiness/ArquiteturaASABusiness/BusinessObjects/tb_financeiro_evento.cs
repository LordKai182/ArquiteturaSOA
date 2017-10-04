using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{

    public partial class tb_financeiro_evento
    {
        #region Primitive Properties
        public virtual Int32 eventf_id { get; set; }

        public virtual String eventf_descricao { get; set; }

        public virtual String eventf_tip_lancto { get; set; }

        public virtual Nullable<Boolean> eventf_lanc_manual { get; set; }

        public virtual Nullable<Boolean> eventf_exportar_uneg { get; set; }

        public virtual String eventf_situacao { get; set; }

        public virtual Nullable<DateTime> eventf_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> eventf_dt_alteracao { get; set; }

        public virtual String eventf_cpf_alteracao { get; set; }

        public virtual Nullable<Int32> grau1_id { get; set; }

        public virtual Nullable<Int32> grau2_id { get; set; }

        public virtual Nullable<Int32> grau3_id { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_finalizadora_sub> _tb_finalizadora_sub;
        public virtual ICollection<tb_finalizadora_sub> tb_finalizadora_sub
        {
            get
            {
                if (_tb_finalizadora_sub == null)
                    _tb_finalizadora_sub = new List<tb_finalizadora_sub>();
                return _tb_finalizadora_sub;
            }
            set { _tb_finalizadora_sub = value; }
        }

        private ICollection<tb_lancto_financeiro> _tb_lancto_financeiro;
        public virtual ICollection<tb_lancto_financeiro> tb_lancto_financeiro
        {
            get
            {
                if (_tb_lancto_financeiro == null)
                    _tb_lancto_financeiro = new List<tb_lancto_financeiro>();
                return _tb_lancto_financeiro;
            }
            set { _tb_lancto_financeiro = value; }
        }

        private ICollection<tb_tipo_nota> _tb_tipo_nota;
        public virtual ICollection<tb_tipo_nota> tb_tipo_nota
        {
            get
            {
                if (_tb_tipo_nota == null)
                    _tb_tipo_nota = new List<tb_tipo_nota>();
                return _tb_tipo_nota;
            }
            set { _tb_tipo_nota = value; }
        }

        #endregion
    }
}
