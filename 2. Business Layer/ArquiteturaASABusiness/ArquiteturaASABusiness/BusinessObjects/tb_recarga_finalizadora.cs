using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_recarga_finalizadora
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 pin_pdv { get; set; }

        public virtual DateTime pin_data { get; set; }

        public virtual Int32 pin_id { get; set; }

        public virtual String vpag_id { get; set; }

        public virtual Int32 final_id { get; set; }

        public virtual Int32 subfin_id { get; set; }

        public virtual Nullable<Int32> vpag_num_referencia { get; set; }

        public virtual Decimal vpag_valor { get; set; }

        public virtual Nullable<Decimal> vpag_troco { get; set; }

        public virtual Nullable<Boolean> vpag_vendatef { get; set; }

        public virtual String vpag_tef_nsu_venda { get; set; }

        public virtual String vpag_tef_nsu_host { get; set; }

        public virtual String vpag_tipo_cartao { get; set; }

        public virtual String vpag_comprovante_cliente { get; set; }

        public virtual String vpag_comprovante_loja { get; set; }

        public virtual String vpag_status { get; set; }

        public virtual Nullable<Int32> cli_id { get; set; }

        public virtual Nullable<Int32> bcaixa_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_financeiro_prazo tb_financeiro_prazo { get; set; }

        public virtual tb_recarga tb_recarga { get; set; }

        #endregion
    }
    
}
