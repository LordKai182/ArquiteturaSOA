using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_parametro_limpezas")]
    public partial class tb_parametro_limpezasDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 tb_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> tb_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> tb_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> tb_data_exec { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_abertura_caixa { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_checkin { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_checkout { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_abcfarma_periodo { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_sangrias { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_suprimentos { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_reducao_z { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_venda { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_promocao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_ponto { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_nfe { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_privatelabel { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_recarga { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_lancto_financeiro { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_agenda_produto { get; set; }
        [DataMember]
        public virtual Nullable<Int32> LJ_tb_crediario { get; set; }

        #endregion

    }
}
