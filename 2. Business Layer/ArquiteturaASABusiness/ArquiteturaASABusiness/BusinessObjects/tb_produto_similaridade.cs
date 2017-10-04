using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_produto_similaridade
    {
        #region Primitive Properties
        public virtual Int32 sim_id { get; set; }

        public virtual String sim_descricao { get; set; }

        public virtual String sim_situacao { get; set; }

        public virtual Nullable<DateTime> sim_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> sim_dt_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_parametro_comissao> _tb_parametro_comissao;
        public virtual ICollection<tb_parametro_comissao> tb_parametro_comissao
        {
            get
            {
                if (_tb_parametro_comissao == null)
                    _tb_parametro_comissao = new List<tb_parametro_comissao>();
                return _tb_parametro_comissao;
            }
            set { _tb_parametro_comissao = value; }
        }

        private ICollection<tb_parametro_descconv> _tb_parametro_descconv;
        public virtual ICollection<tb_parametro_descconv> tb_parametro_descconv
        {
            get
            {
                if (_tb_parametro_descconv == null)
                    _tb_parametro_descconv = new List<tb_parametro_descconv>();
                return _tb_parametro_descconv;
            }
            set { _tb_parametro_descconv = value; }
        }

        private ICollection<tb_parametro_descmax> _tb_parametro_descmax;
        public virtual ICollection<tb_parametro_descmax> tb_parametro_descmax
        {
            get
            {
                if (_tb_parametro_descmax == null)
                    _tb_parametro_descmax = new List<tb_parametro_descmax>();
                return _tb_parametro_descmax;
            }
            set { _tb_parametro_descmax = value; }
        }

        private ICollection<tb_parametro_descprod> _tb_parametro_descprod;
        public virtual ICollection<tb_parametro_descprod> tb_parametro_descprod
        {
            get
            {
                if (_tb_parametro_descprod == null)
                    _tb_parametro_descprod = new List<tb_parametro_descprod>();
                return _tb_parametro_descprod;
            }
            set { _tb_parametro_descprod = value; }
        }

        private ICollection<tb_parametro_descvend> _tb_parametro_descvend;
        public virtual ICollection<tb_parametro_descvend> tb_parametro_descvend
        {
            get
            {
                if (_tb_parametro_descvend == null)
                    _tb_parametro_descvend = new List<tb_parametro_descvend>();
                return _tb_parametro_descvend;
            }
            set { _tb_parametro_descvend = value; }
        }

        private ICollection<tb_parametro_markup> _tb_parametro_markup;
        public virtual ICollection<tb_parametro_markup> tb_parametro_markup
        {
            get
            {
                if (_tb_parametro_markup == null)
                    _tb_parametro_markup = new List<tb_parametro_markup>();
                return _tb_parametro_markup;
            }
            set { _tb_parametro_markup = value; }
        }

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

        #endregion
    }
    
}
