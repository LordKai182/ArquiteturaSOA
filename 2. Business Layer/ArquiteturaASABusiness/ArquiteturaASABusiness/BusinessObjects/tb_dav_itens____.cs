using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_dav_itens____
    {
        #region Primitive Properties
        public virtual Int32 davi_id { get; set; }

        public virtual String davi_codigo { get; set; }

        public virtual String davi_descricao { get; set; }

        public virtual Decimal davi_quantidade { get; set; }

        public virtual String davi_embalagem { get; set; }

        public virtual Decimal davi_valor_unitario { get; set; }

        public virtual Decimal davi_valor_desconto { get; set; }

        public virtual Decimal davi_valor_acrescimo { get; set; }

        public virtual Decimal davi_total_liquido { get; set; }

        public virtual String davi_situacao_tributaria { get; set; }

        public virtual Int32 davi_aliquota { get; set; }

        public virtual String davi_indicador_cancelamento { get; set; }

        public virtual Int32 davi_decimais_quantidade { get; set; }

        public virtual Int32 davi_decimais_vlr_unitario { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_dav tb_dav { get; set; }

        #endregion
    }
}
