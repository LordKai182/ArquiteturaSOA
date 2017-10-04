using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_entrega_endereco")]
    public partial class tb_entrega_enderecoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 end_pdv { get; set; }
        [DataMember]
        public virtual Int32 end_id { get; set; }
        [DataMember]
        public virtual DateTime end_data { get; set; }
        [DataMember]
        public virtual Int64 end_telefone { get; set; }
        [DataMember]
        public virtual Nullable<Int32> end_cep { get; set; }
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
        public virtual String end_latitude_decimais { get; set; }
        [DataMember]
        public virtual String end_longitude_decimais { get; set; }
        [DataMember]
        public virtual String end_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> end_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> end_dt_alteracao { get; set; }
        [DataMember]
        public virtual String end_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> uf_id { get; set; }
        [DataMember]
        public virtual Nullable<Int64> ibge_codigo { get; set; }
        [DataMember]
        public virtual Nullable<Int32> polo_id { get; set; }
        [DataMember]
        public virtual String end_contato { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> end_uso_continuo { get; set; }
        [DataMember]
        public virtual String end_obs { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> end_dt_ultima_compra { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }

        #endregion
    }
}
