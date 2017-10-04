using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_financeiro_sangria")]
    public partial class tb_financeiro_sangriaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 sangriaf_id { get; set; }
        [DataMember]
        public virtual DateTime sangriaf_data { get; set; }
        [DataMember]
        public virtual Decimal sangriaf_valor { get; set; }
        [DataMember]
        public virtual String sangriaf_observacao { get; set; }
        [DataMember]
        public virtual String sangriaf_cpf_responsavel { get; set; }
        [DataMember]
        public virtual String sangriaf_status { get; set; }
        [DataMember]
        public virtual String sangriaf_cpf_funcionario { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> sangriaf_dt_alteracao { get; set; }
        [DataMember]
        public virtual String sangriaf_cpf_alteracao { get; set; }
        [DataMember]
        public virtual String sangriaf_md5 { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_finalizadoraDto tb_finalizadora { get; set; }
        [DataMember]
        public virtual tb_usuarioDto tb_usuario { get; set; }

        #endregion
    }
    
}
