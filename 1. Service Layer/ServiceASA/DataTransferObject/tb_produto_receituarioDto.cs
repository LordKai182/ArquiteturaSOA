using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_produto_receituario")]
    public partial class tb_produto_receituarioDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 rec_id { get; set; }
        [DataMember]
        public virtual String rec_lista { get; set; }
        [DataMember]
        public virtual String rec_lista_descricao { get; set; }
        [DataMember]
        public virtual String rec_receita_descricao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> rec_reter_receita { get; set; }
        [DataMember]
        public virtual String rec_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> rec_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> rec_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
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
