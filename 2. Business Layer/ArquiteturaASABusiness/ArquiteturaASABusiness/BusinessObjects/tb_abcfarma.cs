using ArquiteturaASABusiness.BusinessObjects;
using ArquiteturaASABusiness.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_abcfarma
    {
        #region Primitive Properties
        public virtual Int32 abcf_id { get; set; }

        public virtual Nullable<Decimal> abcf_codigo { get; set; }

        public virtual Nullable<Decimal> abcf_cd_barra { get; set; }

        public virtual Nullable<Decimal> abcf_preco_fabrica { get; set; }

        public virtual Nullable<Decimal> abcf_pmc { get; set; }

        public virtual Nullable<Decimal> abcf_pmc_fracao { get; set; }

        public virtual String abcf_descricao1 { get; set; }

        public virtual String abcf_descricao2 { get; set; }

        public virtual Nullable<Decimal> abcf_cod_fabricante { get; set; }

        public virtual String abcf_fabricante { get; set; }

        public virtual String abcf_tip_produto { get; set; }

        public virtual String abcf_prod_novo { get; set; }

        public virtual String abcf_generico { get; set; }

        public virtual String abcf_princativo { get; set; }

        public virtual String abcf_tip_lista { get; set; }

        public virtual Nullable<Decimal> abcf_qtd_caixa { get; set; }

        public virtual Nullable<Decimal> abcf_ipi { get; set; }

        public virtual Nullable<DateTime> abcf_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> abcf_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_produto> _tb_produto;
        public virtual ICollection<tb_produto> tb_produto
        {
            get
            {
                if (_tb_produto == null)
                    _tb_produto = new List<tb_produto>();
                return _tb_produto;
            }
            set { _tb_produto = value; }
        }

        private ICollection<tbr_abcfarma_uf> _tbr_abcfarma_uf;
        public virtual ICollection<tbr_abcfarma_uf> tbr_abcfarma_uf
        {
            get
            {
                if (_tbr_abcfarma_uf == null)
                    _tbr_abcfarma_uf = new List<tbr_abcfarma_uf>();
                return _tbr_abcfarma_uf;
            }
            set { _tbr_abcfarma_uf = value; }
        }

        #endregion
       
    }
}
