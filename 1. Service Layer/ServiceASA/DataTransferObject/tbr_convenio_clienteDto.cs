using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{   [DataContract]
    public partial class tbr_convenio_clienteDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cnv_id { get; set; }
        [DataMember]
        public virtual Int64 cli_id { get; set; }
    [DataMember]
        public virtual Nullable<Decimal> clicnv_vlr_limite { get; set; }
    [DataMember]
        public virtual Nullable<Decimal> clicnv_vlr_acumulado { get; set; }
    [DataMember]
        public virtual String clicnv_nu_matricula { get; set; }
    [DataMember]
        public virtual String clicnv_situacao { get; set; }
    [DataMember]
        public virtual Nullable<DateTime> clicnv_dt_cadastro { get; set; }
    [DataMember]
        public virtual Nullable<DateTime> clicnv_dt_alteracao { get; set; }
    
        #endregion

        #region Navigation Properties
    [DataMember]
    public virtual tb_clienteDto tb_cliente { get; set; }

    [DataMember]
        public virtual tb_cliente_bloqueioDto tb_cliente_bloqueio { get; set; }
    [DataMember]
        public virtual tb_convenioDto tb_convenio { get; set; }
    [DataMember]
        public virtual tb_financeiro_prazoDto tb_financeiro_prazo { get; set; }

        #endregion
    }
}
