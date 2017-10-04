using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_recarga
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 pin_pdv { get; set; }

        public virtual DateTime pin_data { get; set; }

        public virtual Int32 pin_id { get; set; }

        public virtual String pin_cod_convenio { get; set; }

        public virtual String pin_nome_convenio { get; set; }

        public virtual String pin_tipo_credito { get; set; }

        public virtual String pin_nome_credito { get; set; }

        public virtual Nullable<Decimal> pin_qtde { get; set; }

        public virtual Nullable<Decimal> pin_preco { get; set; }

        public virtual Nullable<Decimal> pin_tot_pgto { get; set; }

        public virtual String pin_ddd { get; set; }

        public virtual String pin_telefone { get; set; }

        public virtual Nullable<Int32> pin_operado_cx { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_empresa_recarga tb_empresa_recarga { get; set; }

        private ICollection<tb_recarga_finalizadora> _tb_recarga_finalizadora;
        public virtual ICollection<tb_recarga_finalizadora> tb_recarga_finalizadora
        {
            get
            {
                if (_tb_recarga_finalizadora == null)
                    _tb_recarga_finalizadora = new List<tb_recarga_finalizadora>();
                return _tb_recarga_finalizadora;
            }
            set { _tb_recarga_finalizadora = value; }
        }

        #endregion
    }
}
