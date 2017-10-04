using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_produto_linha")]
    public partial class tb_produto_linhaDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 lin_id { get; set; }
        [DataMember]
        public virtual String lin_descricao { get; set; }
        [DataMember]
        public virtual String lin_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> lin_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> lin_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_parametro_comissaoDto> tb_parametro_comissao;
        //public virtual ICollection<tb_parametro_comissao> tb_parametro_comissao
        //{
        //    get
        //    {
        //        if (_tb_parametro_comissao == null)
        //            _tb_parametro_comissao = new List<tb_parametro_comissao>();
        //        return _tb_parametro_comissao;
        //    }
        //    set { _tb_parametro_comissao = value; }
        //}

        private IList<tb_parametro_descconvDto> tb_parametro_descconv;
        //public virtual ICollection<tb_parametro_descconv> tb_parametro_descconv
        //{
        //    get
        //    {
        //        if (_tb_parametro_descconv == null)
        //            _tb_parametro_descconv = new List<tb_parametro_descconv>();
        //        return _tb_parametro_descconv;
        //    }
        //    set { _tb_parametro_descconv = value; }
        //}

        private IList<tb_parametro_descmaxDto> tb_parametro_descmax;
        //public virtual ICollection<tb_parametro_descmax> tb_parametro_descmax
        //{
        //    get
        //    {
        //        if (_tb_parametro_descmax == null)
        //            _tb_parametro_descmax = new List<tb_parametro_descmax>();
        //        return _tb_parametro_descmax;
        //    }
        //    set { _tb_parametro_descmax = value; }
        //}

        private IList<tb_parametro_descprodDto> tb_parametro_descprod;
        //public virtual ICollection<tb_parametro_descprod> tb_parametro_descprod
        //{
        //    get
        //    {
        //        if (_tb_parametro_descprod == null)
        //            _tb_parametro_descprod = new List<tb_parametro_descprod>();
        //        return _tb_parametro_descprod;
        //    }
        //    set { _tb_parametro_descprod = value; }
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

        private IList<tb_parametro_markupDto> tb_parametro_markup;
        //public virtual ICollection<tb_parametro_markup> tb_parametro_markup
        //{
        //    get
        //    {
        //        if (_tb_parametro_markup == null)
        //            _tb_parametro_markup = new List<tb_parametro_markup>();
        //        return _tb_parametro_markup;
        //    }
        //    set { _tb_parametro_markup = value; }
        //}

        private IList<tb_produtoDto> tb_produto;
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

        #endregion
    }
}
