using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_finalizadora_sub")]
    public partial class tb_finalizadora_subDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 finsub_id { get; set; }
        [DataMember]
        public virtual Int32 final_id { get; set; }
        [DataMember]
        public virtual String finsub_descricao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> finsub_pratica_pmc { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> finsub_inibir_desconto { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> finsub_desc_maximo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> finsub_tolerancia_dia { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> finsub_mora_diaria { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> finsub_taxa { get; set; }
        [DataMember]
        public virtual String finsub_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> finsub_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> finsub_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> finsub_taxa_evento { get; set; }
        [DataMember]
        public virtual String finsub_tef_descricao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> finsub_obriga_supervisor { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> finsub_permite_compra_saque { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_finalizadoraDto tb_finalizadora { get; set; }
        [DataMember]
        public virtual tb_financeiro_administradoraDto tb_financeiro_administradora { get; set; }
        [DataMember]
        public virtual tb_financeiro_eventoDto tb_financeiro_evento { get; set; }
        [DataMember]
        public virtual tb_financeiro_prazoDto tb_financeiro_prazo { get; set; }

        private IList<tbr_finalizadora_sub_unDto> tbr_finalizadora_sub_un;
        //public virtual ICollection<tbr_finalizadora_sub_un> tbr_finalizadora_sub_un
        //{
        //    get
        //    {
        //        if (_tbr_finalizadora_sub_un == null)
        //            _tbr_finalizadora_sub_un = new List<tbr_finalizadora_sub_un>();
        //        return _tbr_finalizadora_sub_un;
        //    }
        //    set { _tbr_finalizadora_sub_un = value; }
        //}

        #endregion
    }
}
