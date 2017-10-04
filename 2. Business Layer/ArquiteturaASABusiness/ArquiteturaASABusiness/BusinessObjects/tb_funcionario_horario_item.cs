using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{

    public partial class tb_funcionario_horario_item
    {
        #region Primitive Properties
        public virtual Int32 hora_id { get; set; }

        public virtual String ihora_dia { get; set; }

        public virtual String ihora_entrada { get; set; }

        public virtual String ihora_almoco_saida { get; set; }

        public virtual String ihora_almoco_retorno { get; set; }

        public virtual String ihora_saida { get; set; }

        public virtual String ihora_situacao { get; set; }

        public virtual Nullable<DateTime> ihora_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> ihora_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> ihora_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_funcionario_horario tb_funcionario_horario { get; set; }

        #endregion
    }
}
