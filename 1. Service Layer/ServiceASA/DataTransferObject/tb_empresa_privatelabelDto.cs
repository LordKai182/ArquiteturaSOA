using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_empresa_privatelabel")]
    public partial class tb_empresa_privatelabelDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 emplabel_id { get; set; }
        [DataMember]
        public virtual String emplabel_nome { get; set; }
        [DataMember]
        public virtual String emplabel_contato { get; set; }
        [DataMember]
        public virtual String emplabel_telefones { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> emplabel_perc_comissao { get; set; }
        [DataMember]
        public virtual String emplabel_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> emplabel_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> emplabel_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> emplabel_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_financeiro_prazoDto tb_financeiro_prazo { get; set; }
        [DataMember]
        public virtual tb_fornecedor_divisaoDto tb_fornecedor_divisao { get; set; }

        private IList<tb_privatelabelDto> tb_privatelabel;
        //public virtual ICollection<tb_privatelabel> tb_privatelabel
        //{
        //    get
        //    {
        //        if (_tb_privatelabel == null)
        //            _tb_privatelabel = new List<tb_privatelabel>();
        //        return _tb_privatelabel;
        //    }
        //    set { _tb_privatelabel = value; }
        //}

        #endregion
    }
}
