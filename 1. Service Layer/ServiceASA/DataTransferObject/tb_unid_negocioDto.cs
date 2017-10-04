using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_unid_negocio")]
    public partial class tb_unid_negocioDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 uneg_id { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> uneg_numero { get; set; }
        [DataMember]
        public virtual String uneg_cnpj { get; set; }
        [DataMember]
        public virtual String uneg_nome { get; set; }
        [DataMember]
        public virtual String uneg_razao_social { get; set; }
        [DataMember]
        public virtual String uneg_fantasia { get; set; }
        [DataMember]
        public virtual String uneg_inscricao_estadual { get; set; }
        [DataMember]
        public virtual String uneg_inscricao_municipal { get; set; }
        [DataMember]
        public virtual String uneg_situacao { get; set; }
        [DataMember]
        public virtual String uneg_loja { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> uneg_cnpj_local { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> uneg_obriga_justif_diverg { get; set; }
        [DataMember]
        public virtual Boolean uneg_epp { get; set; }
        [DataMember]
        public virtual Byte[] uneg_img_logo { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> uneg_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> uneg_dt_alteracao { get; set; }
        [DataMember]
        public virtual String uneg_cep { get; set; }
        [DataMember]
        public virtual String uneg_logradouro { get; set; }
        [DataMember]
        public virtual String uneg_endereco_numero { get; set; }
        [DataMember]
        public virtual String uneg_complemento { get; set; }
        [DataMember]
        public virtual String uneg_bairro { get; set; }
        [DataMember]
        public virtual String uneg_municipio { get; set; }
        [DataMember]
        public virtual String uneg_telefones { get; set; }
        [DataMember]
        public virtual String uneg_fax { get; set; }
        [DataMember]
        public virtual String uneg_email { get; set; }
        [DataMember]
        public virtual String uneg_regime { get; set; }
        [DataMember]
        public virtual String uneg_nfe_automacao { get; set; }
        [DataMember]
        public virtual String uneg_fid_login { get; set; }
        [DataMember]
        public virtual String uneg_fid_senha { get; set; }
        [DataMember]
        public virtual String uneg_cod_regime_fat { get; set; }
        [DataMember]
        public virtual String uneg_cli_asafisco { get; set; }
        [DataMember]
        public virtual String uneg_cli_ifarma { get; set; }
        [DataMember]
        public virtual String uneg_vazio { get; set; }
        [DataMember]
        public virtual String uneg_versao_banco { get; set; }
        [DataMember]
        public virtual String uneg_tef_idLoja { get; set; }
        [DataMember]
        public virtual String uneg_tef_IP { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_agenda_produtoDto> tb_agenda_produto;
        //public virtual ICollection<tb_agenda_produto> tb_agenda_produto
        //{
        //    get
        //    {
        //        if (_tb_agenda_produto == null)
        //            _tb_agenda_produto = new List<tb_agenda_produto>();
        //        return _tb_agenda_produto;
        //    }
        //    set { _tb_agenda_produto = value; }
        //}
        [DataMember]
        public virtual tb_cadastro_contadorDto tb_cadastro_contador { get; set; }

        private IList<tb_checkin_tmpDto> tb_checkin_tmp;
        //public virtual ICollection<tb_checkin_tmp> tb_checkin_tmp
        //{
        //    get
        //    {
        //        if (_tb_checkin_tmp == null)
        //            _tb_checkin_tmp = new List<tb_checkin_tmp>();
        //        return _tb_checkin_tmp;
        //    }
        //    set { _tb_checkin_tmp = value; }
        //}

        private IList<tb_clienteDto> tb_cliente;
        //public virtual ICollection<tb_cliente> tb_cliente
        //{
        //    get
        //    {
        //        if (_tb_cliente == null)
        //            _tb_cliente = new List<tb_cliente>();
        //        return _tb_cliente;
        //    }
        //    set { _tb_cliente = value; }
        //}

        private IList<tb_cliente_fiscalDto> tb_cliente_fiscal;
        //public virtual ICollection<tb_cliente_fiscal> tb_cliente_fiscal
        //{
        //    get
        //    {
        //        if (_tb_cliente_fiscal == null)
        //            _tb_cliente_fiscal = new List<tb_cliente_fiscal>();
        //        return _tb_cliente_fiscal;
        //    }
        //    set { _tb_cliente_fiscal = value; }
        //}

        private IList<tb_crediarioDto> tb_crediario;
        //public virtual ICollection<tb_crediario> tb_crediario
        //{
        //    get
        //    {
        //        if (_tb_crediario == null)
        //            _tb_crediario = new List<tb_crediario>();
        //        return _tb_crediario;
        //    }
        //    set { _tb_crediario = value; }
        //}

        private IList<tb_entrega_enderecoDto> tb_entrega_endereco;
        //public virtual ICollection<tb_entrega_endereco> tb_entrega_endereco
        //{
        //    get
        //    {
        //        if (_tb_entrega_endereco == null)
        //            _tb_entrega_endereco = new List<tb_entrega_endereco>();
        //        return _tb_entrega_endereco;
        //    }
        //    set { _tb_entrega_endereco = value; }
        //}

        private IList<tb_entrega_poloDto> tb_entrega_polo;
        //public virtual ICollection<tb_entrega_polo> tb_entrega_polo
        //{
        //    get
        //    {
        //        if (_tb_entrega_polo == null)
        //            _tb_entrega_polo = new List<tb_entrega_polo>();
        //        return _tb_entrega_polo;
        //    }
        //    set { _tb_entrega_polo = value; }
        //}

        private IList<tb_funcionarioDto> tb_funcionario;
        //public virtual ICollection<tb_funcionario> tb_funcionario
        //{
        //    get
        //    {
        //        if (_tb_funcionario == null)
        //            _tb_funcionario = new List<tb_funcionario>();
        //        return _tb_funcionario;
        //    }
        //    set { _tb_funcionario = value; }
        //}

        private IList<tb_funcionarioDto> tb_funcionario1;
        //public virtual ICollection<tb_funcionario> tb_funcionario1
        //{
        //    get
        //    {
        //        if (_tb_funcionario1 == null)
        //            _tb_funcionario1 = new List<tb_funcionario>();
        //        return _tb_funcionario1;
        //    }
        //    set { _tb_funcionario1 = value; }
        //}

        private IList<tb_funcionario_visitanteDto> tb_funcionario_visitante;
        //public virtual ICollection<tb_funcionario_visitante> tb_funcionario_visitante
        //{
        //    get
        //    {
        //        if (_tb_funcionario_visitante == null)
        //            _tb_funcionario_visitante = new List<tb_funcionario_visitante>();
        //        return _tb_funcionario_visitante;
        //    }
        //    set { _tb_funcionario_visitante = value; }
        //}
        [DataMember]
        public virtual tb_ibgeDto tb_ibge { get; set; }

        private IList<tb_lancto_financeiroDto> tb_lancto_financeiro;
        //public virtual ICollection<tb_lancto_financeiro> tb_lancto_financeiro
        //{
        //    get
        //    {
        //        if (_tb_lancto_financeiro == null)
        //            _tb_lancto_financeiro = new List<tb_lancto_financeiro>();
        //        return _tb_lancto_financeiro;
        //    }
        //    set { _tb_lancto_financeiro = value; }
        //}

        private IList<tb_mvto_compra____Dto> tb_mvto_compra____;
        //public virtual ICollection<tb_mvto_compra____> tb_mvto_compra____
        //{
        //    get
        //    {
        //        if (_tb_mvto_compra____ == null)
        //            _tb_mvto_compra____ = new List<tb_mvto_compra____>();
        //        return _tb_mvto_compra____;
        //    }
        //    set { _tb_mvto_compra____ = value; }
        //}

        private IList<tb_pedido_compra____Dto> tb_pedido_compra____;
        //public virtual ICollection<tb_pedido_compra____> tb_pedido_compra____
        //{
        //    get
        //    {
        //        if (_tb_pedido_compra____ == null)
        //            _tb_pedido_compra____ = new List<tb_pedido_compra____>();
        //        return _tb_pedido_compra____;
        //    }
        //    set { _tb_pedido_compra____ = value; }
        //}

        private IList<tb_terminalDto> tb_terminal;
        //public virtual ICollection<tb_terminal> tb_terminal
        //{
        //    get
        //    {
        //        if (_tb_terminal == null)
        //            _tb_terminal = new List<tb_terminal>();
        //        return _tb_terminal;
        //    }
        //    set { _tb_terminal = value; }
        //}
        [DataMember]
        public virtual tb_tipo_logradouroDto tb_tipo_logradouro { get; set; }
        [DataMember]
        public virtual tb_ufDto tb_uf { get; set; }

        private IList<tbr_produto_estoque_loteDto> tbr_produto_estoque_lote;
        //public virtual ICollection<tbr_produto_estoque_lote> tbr_produto_estoque_lote
        //{
        //    get
        //    {
        //        if (_tbr_produto_estoque_lote == null)
        //            _tbr_produto_estoque_lote = new List<tbr_produto_estoque_lote>();
        //        return _tbr_produto_estoque_lote;
        //    }
        //    set { _tbr_produto_estoque_lote = value; }
        //}

        private IList<tbr_produto_estoque_diaDto> tbr_produto_estoque_dia;
        //public virtual ICollection<tbr_produto_estoque_dia> tbr_produto_estoque_dia
        //{
        //    get
        //    {
        //        if (_tbr_produto_estoque_dia == null)
        //            _tbr_produto_estoque_dia = new List<tbr_produto_estoque_dia>();
        //        return _tbr_produto_estoque_dia;
        //    }
        //    set { _tbr_produto_estoque_dia = value; }
        //}

        private IList<tb_venda_prevenda_itemDto> tb_venda_prevenda_item;
        //public virtual ICollection<tb_venda_prevenda_item> tb_venda_prevenda_item
        //{
        //    get
        //    {
        //        if (_tb_venda_prevenda_item == null)
        //            _tb_venda_prevenda_item = new List<tb_venda_prevenda_item>();
        //        return _tb_venda_prevenda_item;
        //    }
        //    set { _tb_venda_prevenda_item = value; }
        //}

        private IList<tbr_convenio_unDto> tbr_convenio_un;
        //public virtual ICollection<tbr_convenio_un> tbr_convenio_un
        //{
        //    get
        //    {
        //        if (_tbr_convenio_un == null)
        //            _tbr_convenio_un = new List<tbr_convenio_un>();
        //        return _tbr_convenio_un;
        //    }
        //    set { _tbr_convenio_un = value; }
        //}

        private IList<tbr_finalizadora_sub_unDto> tbr_finalizadora_sub_un;
        //public virtual ICollection<tbr_finalizadora_sub_un> tbr_finalizadora_sub_un
        //{
        //    get
        //    {
        //        if (_tbr_finalizadora_sub_un == null)
        //            _tbr_finalizadora_sub_un = new List<tbr_finalizadora_sub_un>();
        //        return _tbr_finalizadora_sub_un;
        //    }
        //    set { _tbr_finalizadora_sub_un = value; }
        //}

        private IList<tbr_finalizadora_unDto> tbr_finalizadora_un;
        //public virtual ICollection<tbr_finalizadora_un> tbr_finalizadora_un
        //{
        //    get
        //    {
        //        if (_tbr_finalizadora_un == null)
        //            _tbr_finalizadora_un = new List<tbr_finalizadora_un>();
        //        return _tbr_finalizadora_un;
        //    }
        //    set { _tbr_finalizadora_un = value; }
        //}

        private IList<tbr_parametro_descprod_unegDto> tbr_parametro_descprod_uneg;
        //public virtual ICollection<tbr_parametro_descprod_uneg> tbr_parametro_descprod_uneg
        //{
        //    get
        //    {
        //        if (_tbr_parametro_descprod_uneg == null)
        //            _tbr_parametro_descprod_uneg = new List<tbr_parametro_descprod_uneg>();
        //        return _tbr_parametro_descprod_uneg;
        //    }
        //    set { _tbr_parametro_descprod_uneg = value; }
        //}

        private IList<tbr_parametro_descvend_unegDto> tbr_parametro_descvend_uneg;
        //public virtual ICollection<tbr_parametro_descvend_uneg> tbr_parametro_descvend_uneg
        //{
        //    get
        //    {
        //        if (_tbr_parametro_descvend_uneg == null)
        //            _tbr_parametro_descvend_uneg = new List<tbr_parametro_descvend_uneg>();
        //        return _tbr_parametro_descvend_uneg;
        //    }
        //    set { _tbr_parametro_descvend_uneg = value; }
        //}

        private IList<tbr_parametro_markup_unegDto> tbr_parametro_markup_uneg;
        //public virtual ICollection<tbr_parametro_markup_uneg> tbr_parametro_markup_uneg
        //{
        //    get
        //    {
        //        if (_tbr_parametro_markup_uneg == null)
        //            _tbr_parametro_markup_uneg = new List<tbr_parametro_markup_uneg>();
        //        return _tbr_parametro_markup_uneg;
        //    }
        //    set { _tbr_parametro_markup_uneg = value; }
        //}

        private IList<tbr_produto_unegDto> tbr_produto_uneg;
        //public virtual ICollection<tbr_produto_uneg> tbr_produto_uneg
        //{
        //    get
        //    {
        //        if (_tbr_produto_uneg == null)
        //            _tbr_produto_uneg = new List<tbr_produto_uneg>();
        //        return _tbr_produto_uneg;
        //    }
        //    set { _tbr_produto_uneg = value; }
        //}

        private IList<tb_promocaoDto> tb_promocao;
        //public virtual ICollection<tb_promocao> tb_promocao
        //{
        //    get
        //    {
        //        if (_tb_promocao == null)
        //            _tb_promocao = new List<tb_promocao>();
        //        return _tb_promocao;
        //    }
        //    set { _tb_promocao = value; }
        //}

        #endregion
    }
    
}
