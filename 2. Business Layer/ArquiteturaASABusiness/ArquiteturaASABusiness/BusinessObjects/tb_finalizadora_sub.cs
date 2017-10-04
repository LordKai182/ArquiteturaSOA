using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_finalizadora_sub
    {
        #region Primitive Properties
        public virtual Int32 finsub_id { get; set; }

        public virtual Int32 final_id { get; set; }

        public virtual String finsub_descricao { get; set; }

        public virtual Nullable<Boolean> finsub_pratica_pmc { get; set; }

        public virtual Nullable<Boolean> finsub_inibir_desconto { get; set; }

        public virtual Nullable<Decimal> finsub_desc_maximo { get; set; }

        public virtual Nullable<Decimal> finsub_tolerancia_dia { get; set; }

        public virtual Nullable<Decimal> finsub_mora_diaria { get; set; }

        public virtual Nullable<Decimal> finsub_taxa { get; set; }

        public virtual String finsub_situacao { get; set; }

        public virtual Nullable<DateTime> finsub_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> finsub_dt_alteracao { get; set; }

        public virtual Nullable<Int32> finsub_taxa_evento { get; set; }

        public virtual String finsub_tef_descricao { get; set; }

        public virtual Nullable<Boolean> finsub_obriga_supervisor { get; set; }

        public virtual Nullable<Boolean> finsub_permite_compra_saque { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_finalizadora tb_finalizadora { get; set; }

        public virtual tb_financeiro_administradora tb_financeiro_administradora { get; set; }

        public virtual tb_financeiro_evento tb_financeiro_evento { get; set; }

        public virtual tb_financeiro_prazo tb_financeiro_prazo { get; set; }

        private ICollection<tbr_finalizadora_sub_un> _tbr_finalizadora_sub_un;
        public virtual ICollection<tbr_finalizadora_sub_un> tbr_finalizadora_sub_un
        {
            get
            {
                if (_tbr_finalizadora_sub_un == null)
                    _tbr_finalizadora_sub_un = new List<tbr_finalizadora_sub_un>();
                return _tbr_finalizadora_sub_un;
            }
            set { _tbr_finalizadora_sub_un = value; }
        }

        #endregion
    }
    
}
