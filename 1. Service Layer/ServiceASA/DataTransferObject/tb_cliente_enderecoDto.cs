using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_cliente_endereco")]
    public partial class tb_cliente_enderecoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int64 cli_id { get; set; }
        [DataMember]
        public virtual Int32 end_id { get; set; }
        [DataMember]
        public virtual String end_cep { get; set; }
        [DataMember]
        public virtual String end_tp_logradouro { get; set; }
        [DataMember]
        public virtual String end_nm_logradouro { get; set; }
        [DataMember]
        public virtual Nullable<Int32> end_numero { get; set; }
        [DataMember]
        public virtual String end_complemento { get; set; }
        [DataMember]
        public virtual String end_bairro { get; set; }
        [DataMember]
        public virtual String end_cidade { get; set; }
        [DataMember]
        public virtual String end_referencia { get; set; }
        [DataMember]
        public virtual String end_tipo { get; set; }
        [DataMember]
        public virtual String end_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> end_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> end_dt_alteracao { get; set; }
        [DataMember]
        public virtual String end_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_clienteDto tb_cliente { get; set; }
        [DataMember]
        public virtual tb_ufDto tb_uf { get; set; }

        #endregion
    }
}
