using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_ecf_modelo
    {
        #region Primitive Properties
        public virtual Int32 ecfm_id_marca { get; set; }

        public virtual Int32 ecfm_id_modelo { get; set; }

        public virtual Int32 ecfm_id_versao { get; set; }

        public virtual String ecfm_tipo_ecf { get; set; }

        public virtual String ecfm_desc_marca { get; set; }

        public virtual String ecfm_desc_modelo { get; set; }

        public virtual String ecfm_versao { get; set; }

        public virtual Int32 ecfm_qtd_lacre_sl { get; set; }

        public virtual Int32 ecfm_qtd_lacre_fab { get; set; }

        public virtual Boolean ecfm_mfd { get; set; }

        public virtual Boolean ecfm_lacre_mfd { get; set; }

        public virtual String ecfm_ato_aprovacao { get; set; }

        public virtual String ecfm_ato_registro { get; set; }

        public virtual String ecfm_formato_num_fabricacao { get; set; }

        public virtual Nullable<DateTime> ecfm_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> ecfm_dt_alteracao { get; set; }

        public virtual String ecfm_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_ecf> _tb_ecf;
        public virtual ICollection<tb_ecf> tb_ecf
        {
            get
            {
                if (_tb_ecf == null)
                    _tb_ecf = new List<tb_ecf>();
                return _tb_ecf;
            }
            set { _tb_ecf = value; }
        }

        private ICollection<tb_terminal> _tb_terminal;
        public virtual ICollection<tb_terminal> tb_terminal
        {
            get
            {
                if (_tb_terminal == null)
                    _tb_terminal = new List<tb_terminal>();
                return _tb_terminal;
            }
            set { _tb_terminal = value; }
        }

        #endregion
    }
}
