using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_cfop
    {
        #region Primitive Properties
        public virtual Int32 cfop_id { get; set; }

        public virtual Nullable<Decimal> cfop_codigo { get; set; }

        public virtual String cfop_descricao { get; set; }

        public virtual String cfop_situacao { get; set; }

        public virtual Nullable<DateTime> cfop_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> cfop_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_mvto_compra_item____> _tb_mvto_compra_item____;
        public virtual ICollection<tb_mvto_compra_item____> tb_mvto_compra_item____
        {
            get
            {
                if (_tb_mvto_compra_item____ == null)
                    _tb_mvto_compra_item____ = new List<tb_mvto_compra_item____>();
                return _tb_mvto_compra_item____;
            }
            set { _tb_mvto_compra_item____ = value; }
        }

        private ICollection<tb_nfe_item> _tb_nfe_item;
        public virtual ICollection<tb_nfe_item> tb_nfe_item
        {
            get
            {
                if (_tb_nfe_item == null)
                    _tb_nfe_item = new List<tb_nfe_item>();
                return _tb_nfe_item;
            }
            set { _tb_nfe_item = value; }
        }

        private ICollection<tb_tipo_nota> _tb_tipo_nota;
        public virtual ICollection<tb_tipo_nota> tb_tipo_nota
        {
            get
            {
                if (_tb_tipo_nota == null)
                    _tb_tipo_nota = new List<tb_tipo_nota>();
                return _tb_tipo_nota;
            }
            set { _tb_tipo_nota = value; }
        }

        private ICollection<tbr_mvto_compra_cfop____> _tbr_mvto_compra_cfop____;
        public virtual ICollection<tbr_mvto_compra_cfop____> tbr_mvto_compra_cfop____
        {
            get
            {
                if (_tbr_mvto_compra_cfop____ == null)
                    _tbr_mvto_compra_cfop____ = new List<tbr_mvto_compra_cfop____>();
                return _tbr_mvto_compra_cfop____;
            }
            set { _tbr_mvto_compra_cfop____ = value; }
        }

        private ICollection<tb_nfe_cfop> _tb_nfe_cfop;
        public virtual ICollection<tb_nfe_cfop> tb_nfe_cfop
        {
            get
            {
                if (_tb_nfe_cfop == null)
                    _tb_nfe_cfop = new List<tb_nfe_cfop>();
                return _tb_nfe_cfop;
            }
            set { _tb_nfe_cfop = value; }
        }

        #endregion
    }
}
