using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_dav
    {
        #region Primitive Properties
        public virtual Int32 dav_id { get; set; }

        public virtual DateTime dav_data { get; set; }

        public virtual DateTime dav_data_emissao { get; set; }

        public virtual Nullable<Int32> dav_numero { get; set; }

        public virtual Nullable<Int32> dav_numero_controle { get; set; }

        public virtual String ecf_numero_serie_emissao { get; set; }

        public virtual Int32 dav_coo_emissao { get; set; }

        public virtual Int32 dav_gnf_emissao { get; set; }

        public virtual String dav_cpf_cnpj { get; set; }

        public virtual String dav_nome_adquirente { get; set; }

        public virtual Nullable<Int32> dav_num_ecf_venda { get; set; }

        public virtual Nullable<Int32> dav_coo_venda { get; set; }

        public virtual Nullable<Int32> dav_coo_cupom_vinculado_venda { get; set; }

        public virtual String dav_titulo { get; set; }

        public virtual Nullable<Decimal> dav_valor_total { get; set; }

        public virtual String dav_status { get; set; }

        public virtual String ecf_numero_serie_fechamento_cupom { get; set; }

        public virtual String dav_md5 { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_dav_itens____> _tb_dav_itens____;
        public virtual ICollection<tb_dav_itens____> tb_dav_itens____
        {
            get
            {
                if (_tb_dav_itens____ == null)
                    _tb_dav_itens____ = new List<tb_dav_itens____>();
                return _tb_dav_itens____;
            }
            set { _tb_dav_itens____ = value; }
        }

        public virtual tb_venda tb_venda { get; set; }

        #endregion
    }
}
