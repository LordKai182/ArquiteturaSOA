using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_crm_endereco")]
    public partial class tb_crm_enderecoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 crm_end_id { get; set; }
        [DataMember]
        public virtual Int32 crm_id { get; set; }
        [DataMember]
        public virtual Int32 uf_id { get; set; }
        [DataMember]
        public virtual String crm_tipo { get; set; }
        [DataMember]
        public virtual String crm_end_tel { get; set; }
        [DataMember]
        public virtual String crm_end_cep { get; set; }
        [DataMember]
        public virtual String crm_end_tp_logradouro { get; set; }
        [DataMember]
        public virtual String crm_end_nm_logradouro { get; set; }
        [DataMember]
        public virtual Nullable<Int32> crm_end_numero { get; set; }
        [DataMember]
        public virtual String crm_end_complemento { get; set; }
        [DataMember]
        public virtual String crm_end_bairro { get; set; }
        [DataMember]
        public virtual String crm_end_referencia { get; set; }
        [DataMember]
        public virtual String crm_end_cidade { get; set; }
        [DataMember]
        public virtual String crm_end_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> crm_end_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> crm_end_dt_alteracao { get; set; }
        [DataMember]
        public virtual String crm_end_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_crmDto tb_crm { get; set; }

        #endregion
    }
}
