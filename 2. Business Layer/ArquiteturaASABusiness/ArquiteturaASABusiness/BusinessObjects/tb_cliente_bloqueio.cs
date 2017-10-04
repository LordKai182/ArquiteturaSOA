using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_cliente_bloqueio
    {
        #region Primitive Properties
        public virtual Int32 bloq_id { get; set; }

        public virtual String bloq_descricao { get; set; }

        public virtual Nullable<Decimal> bloq_tip_acao { get; set; }

        public virtual String bloq_situacao { get; set; }

        public virtual Nullable<DateTime> bloq_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> bloq_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_cliente> _tb_cliente;
        public virtual ICollection<tb_cliente> tb_cliente
        {
            get
            {
                if (_tb_cliente == null)
                    _tb_cliente = new List<tb_cliente>();
                return _tb_cliente;
            }
            set { _tb_cliente = value; }
        }

        private ICollection<tbr_convenio_cliente> _tbr_convenio_cliente;
        public virtual ICollection<tbr_convenio_cliente> tbr_convenio_cliente
        {
            get
            {
                if (_tbr_convenio_cliente == null)
                    _tbr_convenio_cliente = new List<tbr_convenio_cliente>();
                return _tbr_convenio_cliente;
            }
            set { _tbr_convenio_cliente = value; }
        }

        #endregion
    }
    
}
