using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_crm_especialidade
    {
        #region Primitive Properties
        public virtual Int32 esp_id { get; set; }

        public virtual String esp_descricao { get; set; }

        public virtual String esp_situacao { get; set; }

        public virtual Nullable<DateTime> esp_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> esp_dt_alteracao { get; set; }

        #endregion

    }
}
