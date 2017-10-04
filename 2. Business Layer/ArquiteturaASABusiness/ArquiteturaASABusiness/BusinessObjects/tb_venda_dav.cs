using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_venda_dav
    {
        #region Primitive Properties
        public virtual Int32 venda_dav_id { get; set; }

        public virtual DateTime venda_dav_data_preVenda { get; set; }

        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 venda_pdv { get; set; }

        public virtual Nullable<Int32> venda_id { get; set; }

        public virtual Nullable<DateTime> venda_data { get; set; }

        public virtual String venda_dav_num_preVenda { get; set; }

        public virtual String venda_dav_num_comanda { get; set; }

        public virtual String venda_dav_status { get; set; }

        public virtual Nullable<Decimal> venda_dav_valorTotal { get; set; }

        public virtual String venda_dav_paf_numero { get; set; }

        public virtual Nullable<DateTime> venda_dav_data_alteracao { get; set; }

        public virtual Nullable<Int32> venda_dav_id_origem { get; set; }

        public virtual Nullable<Int32> uneg_id_origem { get; set; }

        public virtual Nullable<DateTime> venda_dav_data_preVenda_origem { get; set; }

        public virtual Nullable<Int32> venda_pdv_origem { get; set; }

        public virtual String venda_dav_nome_arquivo { get; set; }

        public virtual Nullable<Int32> venda_dav_cancela_vendedor_id { get; set; }

        public virtual Nullable<Int32> venda_dav_itens { get; set; }

        public virtual Nullable<Decimal> venda_dav_desconto_final { get; set; }

        public virtual Nullable<DateTime> venda_dav_data_emissao { get; set; }

        public virtual Nullable<Int32> venda_dav_numero_controle { get; set; }

        public virtual String ecf_numero_serie_emissao { get; set; }

        public virtual Nullable<Int32> venda_dav_coo_emissao { get; set; }

        public virtual Nullable<Int32> venda_dav_gnf_emissao { get; set; }

        public virtual String venda_dav_nome_adquirente { get; set; }

        public virtual Nullable<Int32> venda_dav_num_ecf_venda { get; set; }

        public virtual Nullable<Int32> venda_dav_coo_venda { get; set; }

        public virtual Nullable<Int32> venda_dav_coo_cupom_vinculado_venda { get; set; }

        public virtual String venda_dav_titulo { get; set; }

        public virtual String vendaPv_chave_acesso_nfe { get; set; }

        public virtual String cli_fisc_cpf_cnpj { get; set; }

        public virtual String ecf_numero_serie_fechamento_cupom { get; set; }

        public virtual String venda_dav_md5 { get; set; }

        public virtual String dav_status { get; set; }

        public virtual Nullable<Int32> cnv_id { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_cliente tb_cliente { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        private ICollection<tb_venda_dav_item> _tb_venda_dav_item;
        public virtual ICollection<tb_venda_dav_item> tb_venda_dav_item
        {
            get
            {
                if (_tb_venda_dav_item == null)
                    _tb_venda_dav_item = new List<tb_venda_dav_item>();
                return _tb_venda_dav_item;
            }
            set { _tb_venda_dav_item = value; }
        }

        #endregion
    }
}
