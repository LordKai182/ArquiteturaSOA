using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_promocao
    {
        #region Primitive Properties
        public virtual Int32 prm_id { get; set; }

        public virtual String prm_observacao { get; set; }

        public virtual Nullable<DateTime> prm_dt_inicio { get; set; }

        public virtual Nullable<DateTime> prm_dt_fim { get; set; }

        public virtual String prm_tip_aplicacao { get; set; }

        public virtual String prm_situacao { get; set; }

        public virtual Nullable<DateTime> prm_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> prm_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> prm_cpf_alteracao { get; set; }

        public virtual Nullable<Int32> tippro_id { get; set; }

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

        private ICollection<tbr_promocao_produto> _tbr_promocao_produto;
        public virtual ICollection<tbr_promocao_produto> tbr_promocao_produto
        {
            get
            {
                if (_tbr_promocao_produto == null)
                    _tbr_promocao_produto = new List<tbr_promocao_produto>();
                return _tbr_promocao_produto;
            }
            set { _tbr_promocao_produto = value; }
        }

        private ICollection<tb_convenio> _tb_convenio;
        public virtual ICollection<tb_convenio> tb_convenio
        {
            get
            {
                if (_tb_convenio == null)
                    _tb_convenio = new List<tb_convenio>();
                return _tb_convenio;
            }
            set { _tb_convenio = value; }
        }

        private ICollection<tb_unid_negocio> _tb_unid_negocio;
        public virtual ICollection<tb_unid_negocio> tb_unid_negocio
        {
            get
            {
                if (_tb_unid_negocio == null)
                    _tb_unid_negocio = new List<tb_unid_negocio>();
                return _tb_unid_negocio;
            }
            set { _tb_unid_negocio = value; }
        }

        #endregion
    }
}
