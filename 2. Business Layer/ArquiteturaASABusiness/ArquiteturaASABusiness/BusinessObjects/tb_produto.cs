using ArquiteturaASABusiness.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_produto
    {
        #region Primitive Properties
        public virtual Int32 pro_id { get; set; }

        public virtual Nullable<Decimal> pro_codigo { get; set; }

        public virtual String pro_descricao { get; set; }

        public virtual String pro_nome { get; set; }

        public virtual String pro_dosagem { get; set; }

        public virtual Nullable<Decimal> pro_qtd_embalagem { get; set; }

        public virtual String pro_embalagem { get; set; }

        public virtual String pro_apresentacao { get; set; }

        public virtual String pro_unidade_venda { get; set; }

        public virtual String pro_situacao { get; set; }

        public virtual Nullable<Decimal> pro_ipi { get; set; }

        public virtual Nullable<Decimal> pro_ncm { get; set; }

        public virtual Nullable<Decimal> pro_tip_etiqueta { get; set; }

        public virtual String pro_tip_compra { get; set; }

        public virtual String pro_tip_preco { get; set; }

        public virtual String pro_tip_produto { get; set; }

        public virtual Nullable<Decimal> pro_cod_ms { get; set; }

        public virtual Nullable<Boolean> pro_uso_continuo { get; set; }

        public virtual Nullable<Decimal> pro_desc_max { get; set; }

        public virtual Nullable<Boolean> pro_composto { get; set; }

        public virtual Nullable<Boolean> pro_peso_variavel { get; set; }

        public virtual Nullable<Decimal> pro_validade_perec { get; set; }

        public virtual Nullable<DateTime> pro_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> pro_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> pro_cod_genero { get; set; }

        public virtual Nullable<Decimal> pro_qtde_m2 { get; set; }

        public virtual Nullable<Boolean> pro_marca_crm { get; set; }

        public virtual Nullable<Boolean> pro_fracionado { get; set; }

        public virtual Nullable<Decimal> pro_peso { get; set; }

        public virtual Nullable<Decimal> pro_pei { get; set; }

        public virtual String pro_tb_balanca { get; set; }

        public virtual Nullable<Boolean> pro_encarte { get; set; }

        public virtual Nullable<Decimal> pro_cod_dcb { get; set; }

        public virtual Nullable<Boolean> pro_marca_propaganda { get; set; }

        public virtual Nullable<Int32> pro_link_propaganda_1 { get; set; }

        public virtual Nullable<Int32> pro_link_propaganda_2 { get; set; }

        public virtual Nullable<Int32> pro_link_propaganda_3 { get; set; }

        public virtual Nullable<Int32> pro_link_propaganda_4 { get; set; }

        public virtual Nullable<Int32> pro_link_propaganda_5 { get; set; }

        public virtual String pro_dados_adicionais { get; set; }

        public virtual String pro_lista_icms_medic { get; set; }

        public virtual Nullable<Decimal> pro_mva { get; set; }

        public virtual Nullable<Decimal> pro_cod_origem { get; set; }

        public virtual Nullable<Decimal> pro_cod_cst_icms { get; set; }

        public virtual Nullable<Decimal> pro_cod_csosn_icms { get; set; }

        public virtual String pro_class_trib_piscofins { get; set; }

        public virtual Nullable<Decimal> pro_cod_cst_piscofins { get; set; }

        public virtual String campo_busca_prod { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_abcfarma tb_abcfarma { get; set; }

        private ICollection<tb_agenda_produto> _tb_agenda_produto;
        public virtual ICollection<tb_agenda_produto> tb_agenda_produto
        {
            get
            {
                if (_tb_agenda_produto == null)
                    _tb_agenda_produto = new List<tb_agenda_produto>();
                return _tb_agenda_produto;
            }
            set { _tb_agenda_produto = value; }
        }

        private ICollection<tb_checkin_item_tmp> _tb_checkin_item_tmp;
        public virtual ICollection<tb_checkin_item_tmp> tb_checkin_item_tmp
        {
            get
            {
                if (_tb_checkin_item_tmp == null)
                    _tb_checkin_item_tmp = new List<tb_checkin_item_tmp>();
                return _tb_checkin_item_tmp;
            }
            set { _tb_checkin_item_tmp = value; }
        }

        private ICollection<tb_entrega_prod_continuo> _tb_entrega_prod_continuo;
        public virtual ICollection<tb_entrega_prod_continuo> tb_entrega_prod_continuo
        {
            get
            {
                if (_tb_entrega_prod_continuo == null)
                    _tb_entrega_prod_continuo = new List<tb_entrega_prod_continuo>();
                return _tb_entrega_prod_continuo;
            }
            set { _tb_entrega_prod_continuo = value; }
        }

        public virtual tb_fornecedor_divisao tb_fornecedor_divisao { get; set; }

        private ICollection<tb_mvto_compra_item____> _tb_mvto_compra_item____;
        public virtual ICollection<tb_mvto_compra_item____> tb_mvto_compra_item____
        {
            get
            {
                if (_tb_mvto_compra_item____ == null)
                    _tb_mvto_compra_item____ = new List<tb_mvto_compra_item____>();
                return _tb_mvto_compra_item____;
            }
            set { _tb_mvto_compra_item____ = value; }
        }

        private ICollection<tb_nfe_item> _tb_nfe_item;
        public virtual ICollection<tb_nfe_item> tb_nfe_item
        {
            get
            {
                if (_tb_nfe_item == null)
                    _tb_nfe_item = new List<tb_nfe_item>();
                return _tb_nfe_item;
            }
            set { _tb_nfe_item = value; }
        }

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

        private ICollection<tbr_produto_estoque_lote> _tbr_produto_estoque_lote;
        public virtual ICollection<tbr_produto_estoque_lote> tbr_produto_estoque_lote
        {
            get
            {
                if (_tbr_produto_estoque_lote == null)
                    _tbr_produto_estoque_lote = new List<tbr_produto_estoque_lote>();
                return _tbr_produto_estoque_lote;
            }
            set { _tbr_produto_estoque_lote = value; }
        }

        private ICollection<tb_produto_barra> _tb_produto_barra;
        public virtual ICollection<tb_produto_barra> tb_produto_barra
        {
            get
            {
                if (_tb_produto_barra == null)
                    _tb_produto_barra = new List<tb_produto_barra>();
                return _tb_produto_barra;
            }
            set { _tb_produto_barra = value; }
        }

        private ICollection<tbr_produto_estoque_dia> _tbr_produto_estoque_dia;
        public virtual ICollection<tbr_produto_estoque_dia> tbr_produto_estoque_dia
        {
            get
            {
                if (_tbr_produto_estoque_dia == null)
                    _tbr_produto_estoque_dia = new List<tbr_produto_estoque_dia>();
                return _tbr_produto_estoque_dia;
            }
            set { _tbr_produto_estoque_dia = value; }
        }

        public virtual tb_produto_piscofins tb_produto_piscofins { get; set; }

        public virtual tb_produto_fam_categ_sub tb_produto_fam_categ_sub { get; set; }

        public virtual tb_produto_similaridade tb_produto_similaridade { get; set; }

        public virtual tb_produto_classe tb_produto_classe { get; set; }

        public virtual tb_produto_princativo tb_produto_princativo { get; set; }

        public virtual tb_produto_linha tb_produto_linha { get; set; }

        public virtual tb_produto_receituario tb_produto_receituario { get; set; }

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

        private ICollection<tb_venda_item> _tb_venda_item;
        public virtual ICollection<tb_venda_item> tb_venda_item
        {
            get
            {
                if (_tb_venda_item == null)
                    _tb_venda_item = new List<tb_venda_item>();
                return _tb_venda_item;
            }
            set { _tb_venda_item = value; }
        }

        private ICollection<tb_venda_prevenda_item> _tb_venda_prevenda_item;
        public virtual ICollection<tb_venda_prevenda_item> tb_venda_prevenda_item
        {
            get
            {
                if (_tb_venda_prevenda_item == null)
                    _tb_venda_prevenda_item = new List<tb_venda_prevenda_item>();
                return _tb_venda_prevenda_item;
            }
            set { _tb_venda_prevenda_item = value; }
        }

        private ICollection<tbr_dicionario_produto> _tbr_dicionario_produto;
        public virtual ICollection<tbr_dicionario_produto> tbr_dicionario_produto
        {
            get
            {
                if (_tbr_dicionario_produto == null)
                    _tbr_dicionario_produto = new List<tbr_dicionario_produto>();
                return _tbr_dicionario_produto;
            }
            set { _tbr_dicionario_produto = value; }
        }

        private ICollection<tbr_produto_tributacao> _tbr_produto_tributacao;
        public virtual ICollection<tbr_produto_tributacao> tbr_produto_tributacao
        {
            get
            {
                if (_tbr_produto_tributacao == null)
                    _tbr_produto_tributacao = new List<tbr_produto_tributacao>();
                return _tbr_produto_tributacao;
            }
            set { _tbr_produto_tributacao = value; }
        }

        private ICollection<tbr_produto_uneg> _tbr_produto_uneg;
        public virtual ICollection<tbr_produto_uneg> tbr_produto_uneg
        {
            get
            {
                if (_tbr_produto_uneg == null)
                    _tbr_produto_uneg = new List<tbr_produto_uneg>();
                return _tbr_produto_uneg;
            }
            set { _tbr_produto_uneg = value; }
        }

        #endregion
    }
}
