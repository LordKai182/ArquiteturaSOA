using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_financeiro_bancos
    {
        #region Primitive Properties
        public virtual Int32 banco_id { get; set; }

        public virtual Nullable<Decimal> banco_codigo { get; set; }

        public virtual String banco_nome { get; set; }

        public virtual String banco_tipo { get; set; }

        public virtual String banco_situacao { get; set; }

        public virtual Nullable<DateTime> banco_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> banco_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_funcionario> _tb_funcionario;
        public virtual ICollection<tb_funcionario> tb_funcionario
        {
            get
            {
                if (_tb_funcionario == null)
                    _tb_funcionario = new List<tb_funcionario>();
                return _tb_funcionario;
            }
            set { _tb_funcionario = value; }
        }

        private ICollection<tb_venda_pagamento> _tb_venda_pagamento;
        public virtual ICollection<tb_venda_pagamento> tb_venda_pagamento
        {
            get
            {
                if (_tb_venda_pagamento == null)
                    _tb_venda_pagamento = new List<tb_venda_pagamento>();
                return _tb_venda_pagamento;
            }
            set { _tb_venda_pagamento = value; }
        }

        private ICollection<tbr_finalizadora_sub_un> _tbr_finalizadora_sub_un;
        public virtual ICollection<tbr_finalizadora_sub_un> tbr_finalizadora_sub_un
        {
            get
            {
                if (_tbr_finalizadora_sub_un == null)
                    _tbr_finalizadora_sub_un = new List<tbr_finalizadora_sub_un>();
                return _tbr_finalizadora_sub_un;
            }
            set { _tbr_finalizadora_sub_un = value; }
        }

        #endregion
    }
    
}
