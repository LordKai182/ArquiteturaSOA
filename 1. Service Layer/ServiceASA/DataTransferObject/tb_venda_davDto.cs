using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_venda_dav")]
    public partial class tb_venda_davDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 venda_dav_id { get; set; }
        [DataMember]
        public virtual DateTime venda_dav_data_preVenda { get; set; }
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Int32 venda_pdv { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_id { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_data { get; set; }
        [DataMember]
        public virtual String venda_dav_num_preVenda { get; set; }
        [DataMember]
        public virtual String venda_dav_num_comanda { get; set; }
        [DataMember]
        public virtual String venda_dav_status { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_valorTotal { get; set; }
        [DataMember]
        public virtual String venda_dav_paf_numero { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_dav_data_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_id_origem { get; set; }
        [DataMember]
        public virtual Nullable<Int32> uneg_id_origem { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_dav_data_preVenda_origem { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_pdv_origem { get; set; }
        [DataMember]
        public virtual String venda_dav_nome_arquivo { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_cancela_vendedor_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_itens { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> venda_dav_desconto_final { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> venda_dav_data_emissao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_numero_controle { get; set; }
        [DataMember]
        public virtual String ecf_numero_serie_emissao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_coo_emissao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_gnf_emissao { get; set; }
        [DataMember]
        public virtual String venda_dav_nome_adquirente { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_num_ecf_venda { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_coo_venda { get; set; }
        [DataMember]
        public virtual Nullable<Int32> venda_dav_coo_cupom_vinculado_venda { get; set; }
        [DataMember]
        public virtual String venda_dav_titulo { get; set; }
        [DataMember]
        public virtual String vendaPv_chave_acesso_nfe { get; set; }
        [DataMember]
        public virtual String cli_fisc_cpf_cnpj { get; set; }
        [DataMember]
        public virtual String ecf_numero_serie_fechamento_cupom { get; set; }
        [DataMember]
        public virtual String venda_dav_md5 { get; set; }
        [DataMember]
        public virtual String dav_status { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cnv_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_clienteDto tb_cliente { get; set; }
        [DataMember]
        public virtual tb_usuarioDto tb_usuario { get; set; }

        private IList<tb_venda_dav_itemDto> tb_venda_dav_item;
        //public virtual ICollection<tb_venda_dav_item> tb_venda_dav_item
        //{
        //    get
        //    {
        //        if (_tb_venda_dav_item == null)
        //            _tb_venda_dav_item = new List<tb_venda_dav_item>();
        //        return _tb_venda_dav_item;
        //    }
        //    set { _tb_venda_dav_item = value; }
        //}

        #endregion
    }
}
