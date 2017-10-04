using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tbr_convenio_cliente
    {
        #region Primitive Properties
        public virtual Int32 cnv_id { get; set; }

        public virtual Int64 cli_id { get; set; }

        public virtual Nullable<Decimal> clicnv_vlr_limite { get; set; }

        public virtual Nullable<Decimal> clicnv_vlr_acumulado { get; set; }

        public virtual String clicnv_nu_matricula { get; set; }

        public virtual String clicnv_situacao { get; set; }

        public virtual Nullable<DateTime> clicnv_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> clicnv_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_cliente_bloqueio tb_cliente_bloqueio { get; set; }

        public virtual tb_convenio tb_convenio { get; set; }

        public virtual tb_financeiro_prazo tb_financeiro_prazo { get; set; }

        #endregion
    }
}
