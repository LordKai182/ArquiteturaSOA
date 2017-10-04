using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_ibpt_ax")]
    public partial class tb_ibpt_axDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int64 iax_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> iax_tabela { get; set; }
        [DataMember]
        public virtual Nullable<Int32> iax_excecoes { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> iax_ncm { get; set; }
        [DataMember]
        public virtual String iax_ncm_descricao_reduz { get; set; }
        [DataMember]
        public virtual String iax_ncm_descricao { get; set; }
        [DataMember]
        public virtual String iax_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> iax_data_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> iax_aliq_nacional { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> iax_aliq_importado { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> iax_aliq_estadual { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> iax_aliq_municipal { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> iax_vigencia_inicio { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> iax_vigencia_fim { get; set; }
        [DataMember]
        public virtual String iax_fonte { get; set; }
        [DataMember]
        public virtual String iax_chave { get; set; }
        [DataMember]
        public virtual String iax_versao { get; set; }

        #endregion

    }
}
