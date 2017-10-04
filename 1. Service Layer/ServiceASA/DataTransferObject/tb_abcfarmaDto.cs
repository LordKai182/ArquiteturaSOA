using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_abcfarma")]
    public partial class tb_abcfarmaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 abcf_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> abcf_codigo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> abcf_cd_barra { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> abcf_preco_fabrica { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> abcf_pmc { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> abcf_pmc_fracao { get; set; }
        [DataMember]
        public virtual String abcf_descricao1 { get; set; }
        [DataMember]
        public virtual String abcf_descricao2 { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> abcf_cod_fabricante { get; set; }
        [DataMember]
        public virtual String abcf_fabricante { get; set; }
        [DataMember]
        public virtual String abcf_tip_produto { get; set; }
        [DataMember]
        public virtual String abcf_prod_novo { get; set; }
        [DataMember]
        public virtual String abcf_generico { get; set; }
        [DataMember]
        public virtual String abcf_princativo { get; set; }
        [DataMember]
        public virtual String abcf_tip_lista { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> abcf_qtd_caixa { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> abcf_ipi { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> abcf_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> abcf_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
    //   [DataMember]
        private ICollection<tb_produtoDto> tb_produto;
        //public virtual ICollection<tb_produto> tb_produto
        //{
        //    get
        //    {
        //        if (_tb_produto == null)
        //            _tb_produto = new List<tb_produto>();
        //        return _tb_produto;
        //    }
        //    set { _tb_produto = value; }
        //}

        //private ICollection<tbr_abcfarma_uf> _tbr_abcfarma_uf;
        //public virtual ICollection<tbr_abcfarma_uf> tbr_abcfarma_uf
        //{
        //    get
        //    {
        //        if (_tbr_abcfarma_uf == null)
        //            _tbr_abcfarma_uf = new List<tbr_abcfarma_uf>();
        //        return _tbr_abcfarma_uf;
        //    }
        //    set { _tbr_abcfarma_uf = value; }
        //}

        #endregion
    }
}
