using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_cfop")]
    public partial class tb_cfopDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cfop_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> cfop_codigo { get; set; }
        [DataMember]
        public virtual String cfop_descricao { get; set; }
        [DataMember]
        public virtual String cfop_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cfop_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cfop_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties

        private IList<tb_mvto_compra_item____Dto> tb_mvto_compra_item____;
        //public virtual ICollection<tb_mvto_compra_item____> tb_mvto_compra_item____
        //{
        //    get
        //    {
        //        if (_tb_mvto_compra_item____ == null)
        //            _tb_mvto_compra_item____ = new List<tb_mvto_compra_item____>();
        //        return _tb_mvto_compra_item____;
        //    }
        //    set { _tb_mvto_compra_item____ = value; }
        //}

        private IList<tb_nfe_itemDto> tb_nfe_item;
        //public virtual ICollection<tb_nfe_item> tb_nfe_item
        //{
        //    get
        //    {
        //        if (_tb_nfe_item == null)
        //            _tb_nfe_item = new List<tb_nfe_item>();
        //        return _tb_nfe_item;
        //    }
        //    set { _tb_nfe_item = value; }
        //}

        private IList<tb_tipo_notaDto> tb_tipo_nota;
        //public virtual ICollection<tb_tipo_nota> tb_tipo_nota
        //{
        //    get
        //    {
        //        if (_tb_tipo_nota == null)
        //            _tb_tipo_nota = new List<tb_tipo_nota>();
        //        return _tb_tipo_nota;
        //    }
        //    set { _tb_tipo_nota = value; }
        //}

        private IList<tbr_mvto_compra_cfop____Dto> tbr_mvto_compra_cfop____;
        //public virtual ICollection<tbr_mvto_compra_cfop____> tbr_mvto_compra_cfop____
        //{
        //    get
        //    {
        //        if (_tbr_mvto_compra_cfop____ == null)
        //            _tbr_mvto_compra_cfop____ = new List<tbr_mvto_compra_cfop____>();
        //        return _tbr_mvto_compra_cfop____;
        //    }
        //    set { _tbr_mvto_compra_cfop____ = value; }
        //}

        private IList<tb_nfe_cfopDto> tb_nfe_cfop;
        //public virtual ICollection<tb_nfe_cfop> tb_nfe_cfop
        //{
        //    get
        //    {
        //        if (_tb_nfe_cfop == null)
        //            _tb_nfe_cfop = new List<tb_nfe_cfop>();
        //        return _tb_nfe_cfop;
        //    }
        //    set { _tb_nfe_cfop = value; }
        //}

        #endregion
    }
}
