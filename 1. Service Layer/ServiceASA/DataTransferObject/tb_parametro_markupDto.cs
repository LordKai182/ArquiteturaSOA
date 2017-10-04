using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_parametro_markup")]
    public partial class tb_parametro_markupDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 par_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> par_objeto { get; set; }
        [DataMember]
        public virtual String par_situacao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> par_tp_regra { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> par_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> par_dt_alteracao { get; set; }
        [DataMember]
        public virtual String par_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_markup { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_fornecedor_divisaoDto tb_fornecedor_divisao { get; set; }
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }
        [DataMember]
        public virtual tb_produto_classeDto tb_produto_classe { get; set; }
        [DataMember]
        public virtual tb_produto_fam_categ_subDto tb_produto_fam_categ_sub { get; set; }
        [DataMember]
        public virtual tb_produto_linhaDto tb_produto_linha { get; set; }
        [DataMember]
        public virtual tb_produto_similaridadeDto tb_produto_similaridade { get; set; }

        private IList<tbr_parametro_markup_unegDto> tbr_parametro_markup_uneg;
        //public virtual ICollection<tbr_parametro_markup_uneg> tbr_parametro_markup_uneg
        //{
        //    get
        //    {
        //        if (_tbr_parametro_markup_uneg == null)
        //            _tbr_parametro_markup_uneg = new List<tbr_parametro_markup_uneg>();
        //        return _tbr_parametro_markup_uneg;
        //    }
        //    set { _tbr_parametro_markup_uneg = value; }
        //}

        #endregion
    }
}
