using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_agenda_produto")]
    public partial class tb_agenda_produtoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 agen_pdv { get; set; }
        [DataMember]
        public virtual Int32 agen_id { get; set; }
        [DataMember]
        public virtual DateTime agen_dt_agenda { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> agen_dt_vencimento { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> agen_dt_start { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> agen_dt_venda { get; set; }
        [DataMember]
        public virtual String agen_status { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> agen_status_data { get; set; }
        [DataMember]
        public virtual String agen_status_obs { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> agen_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> agen_qtde_embalagem { get; set; }
        [DataMember]
        public virtual Nullable<Int32> agen_atde_compra { get; set; }
        [DataMember]
        public virtual Nullable<Int32> agen_tmp_consumo_hora { get; set; }
        [DataMember]
        public virtual Nullable<Int32> agen_tmp_consumo_diario { get; set; }
        [DataMember]
        public virtual Nullable<Int32> agen_tmp_consumo_dia { get; set; }
        [DataMember]
        public virtual Nullable<Int32> agen_tmp_consumo_mes { get; set; }
        [DataMember]
        public virtual Nullable<Int32> agen_qtde_consumo { get; set; }
        [DataMember]
        public virtual String agen_nome_contato { get; set; }
        [DataMember]
        public virtual Nullable<Int64> agen_tel_residencial { get; set; }
        [DataMember]
        public virtual Nullable<Int64> agen_tel_comercial { get; set; }
        [DataMember]
        public virtual Nullable<Int64> agen_tel_celular { get; set; }
        [DataMember]
        public virtual String agen_observacao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> agen_preco_custo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> agen_preco_venda { get; set; }
        [DataMember]
        public virtual Nullable<Int64> end_telefone { get; set; }
        
        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }
        [DataMember]
        public virtual tb_usuarioDto tb_usuario { get; set; }
        [DataMember]
        public virtual tb_usuarioDto tb_usuario1 { get; set; }

        #endregion
    }
}
