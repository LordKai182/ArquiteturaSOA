using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_fornecedor")]
    public partial class tb_fornecedorDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 fab_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> fab_codigo { get; set; }
        [DataMember]
        public virtual String fab_razao { get; set; }
        [DataMember]
        public virtual String fab_fantasia { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> fab_fabricante { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> fab_tipo { get; set; }
        [DataMember]
        public virtual String fab_nm_arq_envio { get; set; }
        [DataMember]
        public virtual String fab_nm_arq_retorno { get; set; }
        [DataMember]
        public virtual String fab_tip_prc_desc { get; set; }
        [DataMember]
        public virtual String fab_layout_pedido { get; set; }
        [DataMember]
        public virtual String fab_layout_dicionario { get; set; }
        [DataMember]
        public virtual String fab_layout_preco { get; set; }
        [DataMember]
        public virtual String fab_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> fab_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> fab_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_fornecedor_divisaoDto> tb_fornecedor_divisao;
        //public virtual ICollection<tb_fornecedor_divisao> tb_fornecedor_divisao
        //{
        //    get
        //    {
        //        if (_tb_fornecedor_divisao == null)
        //            _tb_fornecedor_divisao = new List<tb_fornecedor_divisao>();
        //        return _tb_fornecedor_divisao;
        //    }
        //    set { _tb_fornecedor_divisao = value; }
        //}

        private IList<tb_parametro_descvendDto> tb_parametro_descvend;
        //public virtual ICollection<tb_parametro_descvend> tb_parametro_descvend
        //{
        //    get
        //    {
        //        if (_tb_parametro_descvend == null)
        //            _tb_parametro_descvend = new List<tb_parametro_descvend>();
        //        return _tb_parametro_descvend;
        //    }
        //    set { _tb_parametro_descvend = value; }
        //}

        private IList<tbr_dicionario_produtoDto> tbr_dicionario_produto;
        //public virtual ICollection<tbr_dicionario_produto> tbr_dicionario_produto
        //{
        //    get
        //    {
        //        if (_tbr_dicionario_produto == null)
        //            _tbr_dicionario_produto = new List<tbr_dicionario_produto>();
        //        return _tbr_dicionario_produto;
        //    }
        //    set { _tbr_dicionario_produto = value; }
        //}

        #endregion
    }
}
