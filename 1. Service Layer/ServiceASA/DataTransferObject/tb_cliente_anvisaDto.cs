using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_cliente_anvisa")]
    public partial class tb_cliente_anvisaDto
    {  
        #region Primitive Properties
        [DataMember]
        public virtual String cli_anv_num_documento { get; set; }
        [DataMember]
        public virtual String cli_anv_orgao_expedidor { get; set; }
        [DataMember]
        public virtual String cli_anv_nome { get; set; }
        [DataMember]
        public virtual String cli_anv_telefone { get; set; }
        [DataMember]
        public virtual DateTime cli_anv_data_cadastro { get; set; }
        [DataMember]
        public virtual Int32 usr_id { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_ufDto tb_uf { get; set; }

        #endregion
    }
}
