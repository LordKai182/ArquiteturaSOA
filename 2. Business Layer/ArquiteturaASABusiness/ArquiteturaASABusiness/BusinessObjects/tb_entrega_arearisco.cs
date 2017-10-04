using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_entrega_arearisco
    {
        #region Primitive Properties
        public virtual Int32 arearisco_id { get; set; }

        public virtual String arearisco_descricao { get; set; }

        public virtual Nullable<Decimal> arearisco_cep_inicial { get; set; }

        public virtual Nullable<Decimal> arearisco_cep_final { get; set; }

        public virtual Nullable<Decimal> arearisco_nu_inicial { get; set; }

        public virtual Nullable<Decimal> arearisco_nu_final { get; set; }

        public virtual String arearisco_mensagem { get; set; }

        public virtual Nullable<Decimal> arearisco_acao { get; set; }

        public virtual String arearisco_situacao { get; set; }

        public virtual Nullable<DateTime> arearisco_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> arearisco_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> arearisco_cpf_alteracao { get; set; }

        #endregion

    }
}
