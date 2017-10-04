using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_usuario_dpto
    {
        #region Primitive Properties
        public virtual Int32 dpto_id { get; set; }

        public virtual String dpto_nome { get; set; }

        public virtual String dpto_situacao { get; set; }

        public virtual Nullable<DateTime> dpto_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> dpto_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> dpto_cpf_alteracao { get; set; }

        public virtual Nullable<Boolean> dpto_apl_planilha { get; set; }

        public virtual Nullable<Boolean> dpto_apl_checkin { get; set; }

        public virtual Nullable<Boolean> dpto_apl_entrada_nf { get; set; }

        public virtual Nullable<Boolean> dpto_apl_consulta_preco { get; set; }

        public virtual Nullable<Boolean> dpto_apl_alteracao_preco { get; set; }

        public virtual Nullable<Boolean> dpto_apl_vnd_balcao { get; set; }

        public virtual Nullable<Boolean> dpto_apl_pdv { get; set; }

        public virtual Nullable<Boolean> dpto_apl_vnd_callcenter { get; set; }

        public virtual Nullable<Boolean> dpto_apl_supervisor_callcenter { get; set; }

        public virtual Nullable<Boolean> dpto_apl_etiquetas_loja { get; set; }

        public virtual Nullable<Boolean> dpto_apl_vnd_atacado { get; set; }

        public virtual Nullable<Boolean> dpto_apl_checkout_atacado { get; set; }

        public virtual Nullable<Boolean> dpto_apl_fat_atacado { get; set; }

        public virtual Nullable<Boolean> dpto_apl_etiquetas_atacado { get; set; }

        public virtual Nullable<Boolean> dpto_apl_supervisor_atacado { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_usuario> _tb_usuario;
        public virtual ICollection<tb_usuario> tb_usuario
        {
            get
            {
                if (_tb_usuario == null)
                    _tb_usuario = new List<tb_usuario>();
                return _tb_usuario;
            }
            set { _tb_usuario = value; }
        }

        private ICollection<tbr_dpto_aplicativo> _tbr_dpto_aplicativo;
        public virtual ICollection<tbr_dpto_aplicativo> tbr_dpto_aplicativo
        {
            get
            {
                if (_tbr_dpto_aplicativo == null)
                    _tbr_dpto_aplicativo = new List<tbr_dpto_aplicativo>();
                return _tbr_dpto_aplicativo;
            }
            set { _tbr_dpto_aplicativo = value; }
        }

        #endregion
    }
    
}
