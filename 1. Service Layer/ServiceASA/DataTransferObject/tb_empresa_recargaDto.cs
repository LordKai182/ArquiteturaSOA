using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_empresa_recarga")]
    public partial class tb_empresa_recargaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 emprec_id { get; set; }
        [DataMember]
        public virtual String emprec_nome { get; set; }
        [DataMember]
        public virtual String emprec_contato { get; set; }
        [DataMember]
        public virtual String emprec_telefones { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> emprec_perc_comissao { get; set; }
        [DataMember]
        public virtual String emprec_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> emprec_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> emprec_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> emprec_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_financeiro_prazoDto tb_financeiro_prazo { get; set; }
        [DataMember]
        public virtual tb_fornecedor_divisaoDto tb_fornecedor_divisao { get; set; }

        private IList<tb_recargaDto> tb_recarga;
        //public virtual ICollection<tb_recarga> tb_recarga
        //{
        //    get
        //    {
        //        if (_tb_recarga == null)
        //            _tb_recarga = new List<tb_recarga>();
        //        return _tb_recarga;
        //    }
        //    set { _tb_recarga = value; }
        //}

        #endregion
    }
}
