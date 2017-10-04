using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_finalizadora
    {
        #region Primitive Properties
        public virtual Int32 final_id { get; set; }

        public virtual String final_descricao { get; set; }

        public virtual Nullable<Boolean> final_permite_troco { get; set; }

        public virtual Nullable<Boolean> final_permite_sangria { get; set; }

        public virtual Nullable<Decimal> final_vlr_sangria_aviso { get; set; }

        public virtual Nullable<Decimal> final_vlr_sangria_bloqueio { get; set; }

        public virtual Nullable<Boolean> final_consulta_cli_tef { get; set; }

        public virtual Nullable<Boolean> final_venda_tef { get; set; }

        public virtual Nullable<Boolean> final_obriga_cliente { get; set; }

        public virtual Nullable<Boolean> final_solicita_dados_ch { get; set; }

        public virtual Nullable<Boolean> final_tipo_convenio { get; set; }

        public virtual Nullable<Boolean> final_obriga_autenticacao { get; set; }

        public virtual String final_tecla_atalho { get; set; }

        public virtual Nullable<Boolean> final_db_folha { get; set; }

        public virtual Nullable<Int32> final_emite_recibo { get; set; }

        public virtual String final_situacao { get; set; }

        public virtual String final_imagem { get; set; }

        public virtual Nullable<DateTime> final_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> final_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_ecf_dd> _tb_ecf_dd;
        public virtual ICollection<tb_ecf_dd> tb_ecf_dd
        {
            get
            {
                if (_tb_ecf_dd == null)
                    _tb_ecf_dd = new List<tb_ecf_dd>();
                return _tb_ecf_dd;
            }
            set { _tb_ecf_dd = value; }
        }

        private ICollection<tb_finalizadora_sub> _tb_finalizadora_sub;
        public virtual ICollection<tb_finalizadora_sub> tb_finalizadora_sub
        {
            get
            {
                if (_tb_finalizadora_sub == null)
                    _tb_finalizadora_sub = new List<tb_finalizadora_sub>();
                return _tb_finalizadora_sub;
            }
            set { _tb_finalizadora_sub = value; }
        }

        private ICollection<tb_financeiro_sangria> _tb_financeiro_sangria;
        public virtual ICollection<tb_financeiro_sangria> tb_financeiro_sangria
        {
            get
            {
                if (_tb_financeiro_sangria == null)
                    _tb_financeiro_sangria = new List<tb_financeiro_sangria>();
                return _tb_financeiro_sangria;
            }
            set { _tb_financeiro_sangria = value; }
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

        private ICollection<tbr_ecf_finalizadora> _tbr_ecf_finalizadora;
        public virtual ICollection<tbr_ecf_finalizadora> tbr_ecf_finalizadora
        {
            get
            {
                if (_tbr_ecf_finalizadora == null)
                    _tbr_ecf_finalizadora = new List<tbr_ecf_finalizadora>();
                return _tbr_ecf_finalizadora;
            }
            set { _tbr_ecf_finalizadora = value; }
        }

        private ICollection<tbr_finalizadora_un> _tbr_finalizadora_un;
        public virtual ICollection<tbr_finalizadora_un> tbr_finalizadora_un
        {
            get
            {
                if (_tbr_finalizadora_un == null)
                    _tbr_finalizadora_un = new List<tbr_finalizadora_un>();
                return _tbr_finalizadora_un;
            }
            set { _tbr_finalizadora_un = value; }
        }

        #endregion
    }
    
}
