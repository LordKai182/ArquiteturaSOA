using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_tributacao")]
    public partial class tb_tributacaoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 trb_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> trb_aliquota { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> trb_servico { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> trb_subst_trib { get; set; }
        [DataMember]
        public virtual String trb_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> trb_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> trb_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tbr_ecf_tributacaoDto> tbr_ecf_tributacao;
        //public virtual ICollection<tbr_ecf_tributacao> tbr_ecf_tributacao
        //{
        //    get
        //    {
        //        if (_tbr_ecf_tributacao == null)
        //            _tbr_ecf_tributacao = new List<tbr_ecf_tributacao>();
        //        return _tbr_ecf_tributacao;
        //    }
        //    set { _tbr_ecf_tributacao = value; }
        //}

        private IList<tbr_produto_tributacaoDto> tbr_produto_tributacao;
        //public virtual ICollection<tbr_produto_tributacao> tbr_produto_tributacao
        //{
        //    get
        //    {
        //        if (_tbr_produto_tributacao == null)
        //            _tbr_produto_tributacao = new List<tbr_produto_tributacao>();
        //        return _tbr_produto_tributacao;
        //    }
        //    set { _tbr_produto_tributacao = value; }
        //}

        private IList<tbr_produto_tributacaoDto> tbr_produto_tributacao1;
        //public virtual ICollection<tbr_produto_tributacao> tbr_produto_tributacao1
        //{
        //    get
        //    {
        //        if (_tbr_produto_tributacao1 == null)
        //            _tbr_produto_tributacao1 = new List<tbr_produto_tributacao>();
        //        return _tbr_produto_tributacao1;
        //    }
        //    set { _tbr_produto_tributacao1 = value; }
        //}

        #endregion
    }
}
