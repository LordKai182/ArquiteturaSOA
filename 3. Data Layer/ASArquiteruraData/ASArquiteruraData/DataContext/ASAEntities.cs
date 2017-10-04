using ArquiteturaASABusiness.BusinessObjects;

using ASArquiteruraData.DataContextInterface;
using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace ASArquiteruraData.DataContext
{
    public partial class ASAEntities : ObjectContext, IASAEntities
    {
        #region Constructors
        /// <summary>
        /// Initializes a new ASAEntities object using the connection string found in the 'ASAEntities' section of the application configuration file.
        /// </summary>
        public ASAEntities()
            : base("name=db_lojaEntities2", "db_lojaEntities2")
        {
            ContextOptions.LazyLoadingEnabled = false;
            OnContextCreated();
            
        }

        /// <summary>
        /// Initialize a new ASAEntities object.
        /// </summary>
        public ASAEntities(string connectionString)
            : base(connectionString, "ASAEntities")
        {
            ContextOptions.LazyLoadingEnabled = false;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new ASAEntities object.
        /// </summary>
        public ASAEntities(EntityConnection connection)
            : base(connection, "ASAEntities")
        {
            ContextOptions.LazyLoadingEnabled = false;
            OnContextCreated();
        }
        #endregion

        #region Partial Methods
        partial void OnContextCreated();
        #endregion

        #region ObjectSet Properties
        public ObjectSet<tb_abcfarma> tb_abcfarma
        {
            get
            {
                if (_tb_abcfarma == null)
                    _tb_abcfarma = CreateObjectSet<tb_abcfarma>("tb_abcfarma");
                return _tb_abcfarma;
            }
        }
        private ObjectSet<tb_abcfarma> _tb_abcfarma;
        IObjectSet<tb_abcfarma> IASAEntities.tb_abcfarma { get { return tb_abcfarma; } }

        public ObjectSet<tb_abcfarma_periodo> tb_abcfarma_periodo
        {
            get
            {
                if (_tb_abcfarma_periodo == null)
                    _tb_abcfarma_periodo = CreateObjectSet<tb_abcfarma_periodo>("tb_abcfarma_periodo");
                return _tb_abcfarma_periodo;
            }
        }
        private ObjectSet<tb_abcfarma_periodo> _tb_abcfarma_periodo;
        IObjectSet<tb_abcfarma_periodo> IASAEntities.tb_abcfarma_periodo { get { return tb_abcfarma_periodo; } }

        public ObjectSet<tb_abertura_caixa> tb_abertura_caixa
        {
            get
            {
                if (_tb_abertura_caixa == null)
                    _tb_abertura_caixa = CreateObjectSet<tb_abertura_caixa>("tb_abertura_caixa");
                return _tb_abertura_caixa;
            }
        }
        private ObjectSet<tb_abertura_caixa> _tb_abertura_caixa;
        IObjectSet<tb_abertura_caixa> IASAEntities.tb_abertura_caixa { get { return tb_abertura_caixa; } }

        public ObjectSet<tb_agenda_produto> tb_agenda_produto
        {
            get
            {
                if (_tb_agenda_produto == null)
                    _tb_agenda_produto = CreateObjectSet<tb_agenda_produto>("tb_agenda_produto");
                return _tb_agenda_produto;
            }
        }
        private ObjectSet<tb_agenda_produto> _tb_agenda_produto;
        IObjectSet<tb_agenda_produto> IASAEntities.tb_agenda_produto { get { return tb_agenda_produto; } }

        public ObjectSet<tb_banco> tb_banco
        {
            get
            {
                if (_tb_banco == null)
                    _tb_banco = CreateObjectSet<tb_banco>("tb_banco");
                return _tb_banco;
            }
        }
        private ObjectSet<tb_banco> _tb_banco;
        IObjectSet<tb_banco> IASAEntities.tb_banco { get { return tb_banco; } }

        public ObjectSet<tb_cadastro_contador> tb_cadastro_contador
        {
            get
            {
                if (_tb_cadastro_contador == null)
                    _tb_cadastro_contador = CreateObjectSet<tb_cadastro_contador>("tb_cadastro_contador");
                return _tb_cadastro_contador;
            }
        }
        private ObjectSet<tb_cadastro_contador> _tb_cadastro_contador;
        IObjectSet<tb_cadastro_contador> IASAEntities.tb_cadastro_contador { get { return tb_cadastro_contador; } }

        public ObjectSet<tb_cargo> tb_cargo
        {
            get
            {
                if (_tb_cargo == null)
                    _tb_cargo = CreateObjectSet<tb_cargo>("tb_cargo");
                return _tb_cargo;
            }
        }
        private ObjectSet<tb_cargo> _tb_cargo;
        IObjectSet<tb_cargo> IASAEntities.tb_cargo { get { return tb_cargo; } }

        public ObjectSet<tb_ceps> tb_ceps
        {
            get
            {
                if (_tb_ceps == null)
                    _tb_ceps = CreateObjectSet<tb_ceps>("tb_ceps");
                return _tb_ceps;
            }
        }
        private ObjectSet<tb_ceps> _tb_ceps;
        IObjectSet<tb_ceps> IASAEntities.tb_ceps { get { return tb_ceps; } }

        public ObjectSet<tb_cfop> tb_cfop
        {
            get
            {
                if (_tb_cfop == null)
                    _tb_cfop = CreateObjectSet<tb_cfop>("tb_cfop");
                return _tb_cfop;
            }
        }
        private ObjectSet<tb_cfop> _tb_cfop;
        IObjectSet<tb_cfop> IASAEntities.tb_cfop { get { return tb_cfop; } }

        public ObjectSet<tb_checkin> tb_checkin
        {
            get
            {
                if (_tb_checkin == null)
                    _tb_checkin = CreateObjectSet<tb_checkin>("tb_checkin");
                return _tb_checkin;
            }
        }
        private ObjectSet<tb_checkin> _tb_checkin;
        IObjectSet<tb_checkin> IASAEntities.tb_checkin { get { return tb_checkin; } }

        public ObjectSet<tb_checkin_item> tb_checkin_item
        {
            get
            {
                if (_tb_checkin_item == null)
                    _tb_checkin_item = CreateObjectSet<tb_checkin_item>("tb_checkin_item");
                return _tb_checkin_item;
            }
        }
        private ObjectSet<tb_checkin_item> _tb_checkin_item;
        IObjectSet<tb_checkin_item> IASAEntities.tb_checkin_item { get { return tb_checkin_item; } }

        public ObjectSet<tb_checkin_item_tmp> tb_checkin_item_tmp
        {
            get
            {
                if (_tb_checkin_item_tmp == null)
                    _tb_checkin_item_tmp = CreateObjectSet<tb_checkin_item_tmp>("tb_checkin_item_tmp");
                return _tb_checkin_item_tmp;
            }
        }
        private ObjectSet<tb_checkin_item_tmp> _tb_checkin_item_tmp;
        IObjectSet<tb_checkin_item_tmp> IASAEntities.tb_checkin_item_tmp { get { return tb_checkin_item_tmp; } }

        public ObjectSet<tb_checkin_tmp> tb_checkin_tmp
        {
            get
            {
                if (_tb_checkin_tmp == null)
                    _tb_checkin_tmp = CreateObjectSet<tb_checkin_tmp>("tb_checkin_tmp");
                return _tb_checkin_tmp;
            }
        }
        private ObjectSet<tb_checkin_tmp> _tb_checkin_tmp;
        IObjectSet<tb_checkin_tmp> IASAEntities.tb_checkin_tmp { get { return tb_checkin_tmp; } }

        public ObjectSet<tb_checkout> tb_checkout
        {
            get
            {
                if (_tb_checkout == null)
                    _tb_checkout = CreateObjectSet<tb_checkout>("tb_checkout");
                return _tb_checkout;
            }
        }
        private ObjectSet<tb_checkout> _tb_checkout;
        IObjectSet<tb_checkout> IASAEntities.tb_checkout { get { return tb_checkout; } }

        public ObjectSet<tb_checkout_item> tb_checkout_item
        {
            get
            {
                if (_tb_checkout_item == null)
                    _tb_checkout_item = CreateObjectSet<tb_checkout_item>("tb_checkout_item");
                return _tb_checkout_item;
            }
        }
        private ObjectSet<tb_checkout_item> _tb_checkout_item;
        IObjectSet<tb_checkout_item> IASAEntities.tb_checkout_item { get { return tb_checkout_item; } }

        public ObjectSet<tb_cliente> tb_cliente
        {
            get
            {
                if (_tb_cliente == null)
                    _tb_cliente = CreateObjectSet<tb_cliente>("tb_cliente");
                return _tb_cliente;
            }
        }
        private ObjectSet<tb_cliente> _tb_cliente;
        IObjectSet<tb_cliente> IASAEntities.tb_cliente { get { return tb_cliente; } }

        public ObjectSet<tb_cliente_anvisa> tb_cliente_anvisa
        {
            get
            {
                if (_tb_cliente_anvisa == null)
                    _tb_cliente_anvisa = CreateObjectSet<tb_cliente_anvisa>("tb_cliente_anvisa");
                return _tb_cliente_anvisa;
            }
        }
        private ObjectSet<tb_cliente_anvisa> _tb_cliente_anvisa;
        IObjectSet<tb_cliente_anvisa> IASAEntities.tb_cliente_anvisa { get { return tb_cliente_anvisa; } }

        public ObjectSet<tb_cliente_bloqueio> tb_cliente_bloqueio
        {
            get
            {
                if (_tb_cliente_bloqueio == null)
                    _tb_cliente_bloqueio = CreateObjectSet<tb_cliente_bloqueio>("tb_cliente_bloqueio");
                return _tb_cliente_bloqueio;
            }
        }
        private ObjectSet<tb_cliente_bloqueio> _tb_cliente_bloqueio;
        IObjectSet<tb_cliente_bloqueio> IASAEntities.tb_cliente_bloqueio { get { return tb_cliente_bloqueio; } }

        public ObjectSet<tb_cliente_endereco> tb_cliente_endereco
        {
            get
            {
                if (_tb_cliente_endereco == null)
                    _tb_cliente_endereco = CreateObjectSet<tb_cliente_endereco>("tb_cliente_endereco");
                return _tb_cliente_endereco;
            }
        }
        private ObjectSet<tb_cliente_endereco> _tb_cliente_endereco;
        IObjectSet<tb_cliente_endereco> IASAEntities.tb_cliente_endereco { get { return tb_cliente_endereco; } }

        public ObjectSet<tb_cliente_fiscal> tb_cliente_fiscal
        {
            get
            {
                if (_tb_cliente_fiscal == null)
                    _tb_cliente_fiscal = CreateObjectSet<tb_cliente_fiscal>("tb_cliente_fiscal");
                return _tb_cliente_fiscal;
            }
        }
        private ObjectSet<tb_cliente_fiscal> _tb_cliente_fiscal;
        IObjectSet<tb_cliente_fiscal> IASAEntities.tb_cliente_fiscal { get { return tb_cliente_fiscal; } }

        public ObjectSet<tb_cliente_telefone> tb_cliente_telefone
        {
            get
            {
                if (_tb_cliente_telefone == null)
                    _tb_cliente_telefone = CreateObjectSet<tb_cliente_telefone>("tb_cliente_telefone");
                return _tb_cliente_telefone;
            }
        }
        private ObjectSet<tb_cliente_telefone> _tb_cliente_telefone;
        IObjectSet<tb_cliente_telefone> IASAEntities.tb_cliente_telefone { get { return tb_cliente_telefone; } }

        public ObjectSet<tb_conselho> tb_conselho
        {
            get
            {
                if (_tb_conselho == null)
                    _tb_conselho = CreateObjectSet<tb_conselho>("tb_conselho");
                return _tb_conselho;
            }
        }
        private ObjectSet<tb_conselho> _tb_conselho;
        IObjectSet<tb_conselho> IASAEntities.tb_conselho { get { return tb_conselho; } }

        public ObjectSet<tb_conselho_regional> tb_conselho_regional
        {
            get
            {
                if (_tb_conselho_regional == null)
                    _tb_conselho_regional = CreateObjectSet<tb_conselho_regional>("tb_conselho_regional");
                return _tb_conselho_regional;
            }
        }
        private ObjectSet<tb_conselho_regional> _tb_conselho_regional;
        IObjectSet<tb_conselho_regional> IASAEntities.tb_conselho_regional { get { return tb_conselho_regional; } }

        public ObjectSet<tb_conta> tb_conta
        {
            get
            {
                if (_tb_conta == null)
                    _tb_conta = CreateObjectSet<tb_conta>("tb_conta");
                return _tb_conta;
            }
        }
        private ObjectSet<tb_conta> _tb_conta;
        IObjectSet<tb_conta> IASAEntities.tb_conta { get { return tb_conta; } }

        public ObjectSet<tb_convenio> tb_convenio
        {
            get
            {
                if (_tb_convenio == null)
                    _tb_convenio = CreateObjectSet<tb_convenio>("tb_convenio");
                return _tb_convenio;
            }
        }
        private ObjectSet<tb_convenio> _tb_convenio;
        IObjectSet<tb_convenio> IASAEntities.tb_convenio { get { return tb_convenio; } }

        public ObjectSet<tb_crediario> tb_crediario
        {
            get
            {
                if (_tb_crediario == null)
                    _tb_crediario = CreateObjectSet<tb_crediario>("tb_crediario");
                return _tb_crediario;
            }
        }
        private ObjectSet<tb_crediario> _tb_crediario;
        IObjectSet<tb_crediario> IASAEntities.tb_crediario { get { return tb_crediario; } }

        public ObjectSet<tb_crediario_finalizadora> tb_crediario_finalizadora
        {
            get
            {
                if (_tb_crediario_finalizadora == null)
                    _tb_crediario_finalizadora = CreateObjectSet<tb_crediario_finalizadora>("tb_crediario_finalizadora");
                return _tb_crediario_finalizadora;
            }
        }
        private ObjectSet<tb_crediario_finalizadora> _tb_crediario_finalizadora;
        IObjectSet<tb_crediario_finalizadora> IASAEntities.tb_crediario_finalizadora { get { return tb_crediario_finalizadora; } }

        public ObjectSet<tb_crm> tb_crm
        {
            get
            {
                if (_tb_crm == null)
                    _tb_crm = CreateObjectSet<tb_crm>("tb_crm");
                return _tb_crm;
            }
        }
        private ObjectSet<tb_crm> _tb_crm;
        IObjectSet<tb_crm> IASAEntities.tb_crm { get { return tb_crm; } }

        public ObjectSet<tb_crm_endereco> tb_crm_endereco
        {
            get
            {
                if (_tb_crm_endereco == null)
                    _tb_crm_endereco = CreateObjectSet<tb_crm_endereco>("tb_crm_endereco");
                return _tb_crm_endereco;
            }
        }
        private ObjectSet<tb_crm_endereco> _tb_crm_endereco;
        IObjectSet<tb_crm_endereco> IASAEntities.tb_crm_endereco { get { return tb_crm_endereco; } }

        public ObjectSet<tb_crm_especialidade> tb_crm_especialidade
        {
            get
            {
                if (_tb_crm_especialidade == null)
                    _tb_crm_especialidade = CreateObjectSet<tb_crm_especialidade>("tb_crm_especialidade");
                return _tb_crm_especialidade;
            }
        }
        private ObjectSet<tb_crm_especialidade> _tb_crm_especialidade;
        IObjectSet<tb_crm_especialidade> IASAEntities.tb_crm_especialidade { get { return tb_crm_especialidade; } }

        public ObjectSet<tb_dav> tb_dav
        {
            get
            {
                if (_tb_dav == null)
                    _tb_dav = CreateObjectSet<tb_dav>("tb_dav");
                return _tb_dav;
            }
        }
        private ObjectSet<tb_dav> _tb_dav;
        IObjectSet<tb_dav> IASAEntities.tb_dav { get { return tb_dav; } }

        public ObjectSet<tb_dav_itens____> tb_dav_itens____
        {
            get
            {
                if (_tb_dav_itens____ == null)
                    _tb_dav_itens____ = CreateObjectSet<tb_dav_itens____>("tb_dav_itens____");
                return _tb_dav_itens____;
            }
        }
        private ObjectSet<tb_dav_itens____> _tb_dav_itens____;
        IObjectSet<tb_dav_itens____> IASAEntities.tb_dav_itens____ { get { return tb_dav_itens____; } }

        public ObjectSet<tb_ecf> tb_ecf
        {
            get
            {
                if (_tb_ecf == null)
                    _tb_ecf = CreateObjectSet<tb_ecf>("tb_ecf");
                return _tb_ecf;
            }
        }
        private ObjectSet<tb_ecf> _tb_ecf;
        IObjectSet<tb_ecf> IASAEntities.tb_ecf { get { return tb_ecf; } }

        public ObjectSet<tb_ecf_dd> tb_ecf_dd
        {
            get
            {
                if (_tb_ecf_dd == null)
                    _tb_ecf_dd = CreateObjectSet<tb_ecf_dd>("tb_ecf_dd");
                return _tb_ecf_dd;
            }
        }
        private ObjectSet<tb_ecf_dd> _tb_ecf_dd;
        IObjectSet<tb_ecf_dd> IASAEntities.tb_ecf_dd { get { return tb_ecf_dd; } }

        public ObjectSet<tb_ecf_modelo> tb_ecf_modelo
        {
            get
            {
                if (_tb_ecf_modelo == null)
                    _tb_ecf_modelo = CreateObjectSet<tb_ecf_modelo>("tb_ecf_modelo");
                return _tb_ecf_modelo;
            }
        }
        private ObjectSet<tb_ecf_modelo> _tb_ecf_modelo;
        IObjectSet<tb_ecf_modelo> IASAEntities.tb_ecf_modelo { get { return tb_ecf_modelo; } }

        public ObjectSet<tb_empresa_privatelabel> tb_empresa_privatelabel
        {
            get
            {
                if (_tb_empresa_privatelabel == null)
                    _tb_empresa_privatelabel = CreateObjectSet<tb_empresa_privatelabel>("tb_empresa_privatelabel");
                return _tb_empresa_privatelabel;
            }
        }
        private ObjectSet<tb_empresa_privatelabel> _tb_empresa_privatelabel;
        IObjectSet<tb_empresa_privatelabel> IASAEntities.tb_empresa_privatelabel { get { return tb_empresa_privatelabel; } }

        public ObjectSet<tb_empresa_recarga> tb_empresa_recarga
        {
            get
            {
                if (_tb_empresa_recarga == null)
                    _tb_empresa_recarga = CreateObjectSet<tb_empresa_recarga>("tb_empresa_recarga");
                return _tb_empresa_recarga;
            }
        }
        private ObjectSet<tb_empresa_recarga> _tb_empresa_recarga;
        IObjectSet<tb_empresa_recarga> IASAEntities.tb_empresa_recarga { get { return tb_empresa_recarga; } }

        public ObjectSet<tb_entrega_arearisco> tb_entrega_arearisco
        {
            get
            {
                if (_tb_entrega_arearisco == null)
                    _tb_entrega_arearisco = CreateObjectSet<tb_entrega_arearisco>("tb_entrega_arearisco");
                return _tb_entrega_arearisco;
            }
        }
        private ObjectSet<tb_entrega_arearisco> _tb_entrega_arearisco;
        IObjectSet<tb_entrega_arearisco> IASAEntities.tb_entrega_arearisco { get { return tb_entrega_arearisco; } }

        public ObjectSet<tb_entrega_endereco> tb_entrega_endereco
        {
            get
            {
                if (_tb_entrega_endereco == null)
                    _tb_entrega_endereco = CreateObjectSet<tb_entrega_endereco>("tb_entrega_endereco");
                return _tb_entrega_endereco;
            }
        }
        private ObjectSet<tb_entrega_endereco> _tb_entrega_endereco;
        IObjectSet<tb_entrega_endereco> IASAEntities.tb_entrega_endereco { get { return tb_entrega_endereco; } }

        public ObjectSet<tb_entrega_polo> tb_entrega_polo
        {
            get
            {
                if (_tb_entrega_polo == null)
                    _tb_entrega_polo = CreateObjectSet<tb_entrega_polo>("tb_entrega_polo");
                return _tb_entrega_polo;
            }
        }
        private ObjectSet<tb_entrega_polo> _tb_entrega_polo;
        IObjectSet<tb_entrega_polo> IASAEntities.tb_entrega_polo { get { return tb_entrega_polo; } }

        public ObjectSet<tb_entrega_polo_bairro> tb_entrega_polo_bairro
        {
            get
            {
                if (_tb_entrega_polo_bairro == null)
                    _tb_entrega_polo_bairro = CreateObjectSet<tb_entrega_polo_bairro>("tb_entrega_polo_bairro");
                return _tb_entrega_polo_bairro;
            }
        }
        private ObjectSet<tb_entrega_polo_bairro> _tb_entrega_polo_bairro;
        IObjectSet<tb_entrega_polo_bairro> IASAEntities.tb_entrega_polo_bairro { get { return tb_entrega_polo_bairro; } }

        public ObjectSet<tb_entrega_prod_continuo> tb_entrega_prod_continuo
        {
            get
            {
                if (_tb_entrega_prod_continuo == null)
                    _tb_entrega_prod_continuo = CreateObjectSet<tb_entrega_prod_continuo>("tb_entrega_prod_continuo");
                return _tb_entrega_prod_continuo;
            }
        }
        private ObjectSet<tb_entrega_prod_continuo> _tb_entrega_prod_continuo;
        IObjectSet<tb_entrega_prod_continuo> IASAEntities.tb_entrega_prod_continuo { get { return tb_entrega_prod_continuo; } }

        public ObjectSet<tb_entrega_quadrante> tb_entrega_quadrante
        {
            get
            {
                if (_tb_entrega_quadrante == null)
                    _tb_entrega_quadrante = CreateObjectSet<tb_entrega_quadrante>("tb_entrega_quadrante");
                return _tb_entrega_quadrante;
            }
        }
        private ObjectSet<tb_entrega_quadrante> _tb_entrega_quadrante;
        IObjectSet<tb_entrega_quadrante> IASAEntities.tb_entrega_quadrante { get { return tb_entrega_quadrante; } }

        public ObjectSet<tb_entrega_rota> tb_entrega_rota
        {
            get
            {
                if (_tb_entrega_rota == null)
                    _tb_entrega_rota = CreateObjectSet<tb_entrega_rota>("tb_entrega_rota");
                return _tb_entrega_rota;
            }
        }
        private ObjectSet<tb_entrega_rota> _tb_entrega_rota;
        IObjectSet<tb_entrega_rota> IASAEntities.tb_entrega_rota { get { return tb_entrega_rota; } }

        public ObjectSet<tb_entrega_rota_cep> tb_entrega_rota_cep
        {
            get
            {
                if (_tb_entrega_rota_cep == null)
                    _tb_entrega_rota_cep = CreateObjectSet<tb_entrega_rota_cep>("tb_entrega_rota_cep");
                return _tb_entrega_rota_cep;
            }
        }
        private ObjectSet<tb_entrega_rota_cep> _tb_entrega_rota_cep;
        IObjectSet<tb_entrega_rota_cep> IASAEntities.tb_entrega_rota_cep { get { return tb_entrega_rota_cep; } }

        public ObjectSet<tb_finalizadora> tb_finalizadora
        {
            get
            {
                if (_tb_finalizadora == null)
                    _tb_finalizadora = CreateObjectSet<tb_finalizadora>("tb_finalizadora");
                return _tb_finalizadora;
            }
        }
        private ObjectSet<tb_finalizadora> _tb_finalizadora;
        IObjectSet<tb_finalizadora> IASAEntities.tb_finalizadora { get { return tb_finalizadora; } }

        public ObjectSet<tb_finalizadora_sub> tb_finalizadora_sub
        {
            get
            {
                if (_tb_finalizadora_sub == null)
                    _tb_finalizadora_sub = CreateObjectSet<tb_finalizadora_sub>("tb_finalizadora_sub");
                return _tb_finalizadora_sub;
            }
        }
        private ObjectSet<tb_finalizadora_sub> _tb_finalizadora_sub;
        IObjectSet<tb_finalizadora_sub> IASAEntities.tb_finalizadora_sub { get { return tb_finalizadora_sub; } }

        public ObjectSet<tb_financeiro_administradora> tb_financeiro_administradora
        {
            get
            {
                if (_tb_financeiro_administradora == null)
                    _tb_financeiro_administradora = CreateObjectSet<tb_financeiro_administradora>("tb_financeiro_administradora");
                return _tb_financeiro_administradora;
            }
        }
        private ObjectSet<tb_financeiro_administradora> _tb_financeiro_administradora;
        IObjectSet<tb_financeiro_administradora> IASAEntities.tb_financeiro_administradora { get { return tb_financeiro_administradora; } }

        public ObjectSet<tb_financeiro_bancos> tb_financeiro_bancos
        {
            get
            {
                if (_tb_financeiro_bancos == null)
                    _tb_financeiro_bancos = CreateObjectSet<tb_financeiro_bancos>("tb_financeiro_bancos");
                return _tb_financeiro_bancos;
            }
        }
        private ObjectSet<tb_financeiro_bancos> _tb_financeiro_bancos;
        IObjectSet<tb_financeiro_bancos> IASAEntities.tb_financeiro_bancos { get { return tb_financeiro_bancos; } }

        public ObjectSet<tb_financeiro_evento> tb_financeiro_evento
        {
            get
            {
                if (_tb_financeiro_evento == null)
                    _tb_financeiro_evento = CreateObjectSet<tb_financeiro_evento>("tb_financeiro_evento");
                return _tb_financeiro_evento;
            }
        }
        private ObjectSet<tb_financeiro_evento> _tb_financeiro_evento;
        IObjectSet<tb_financeiro_evento> IASAEntities.tb_financeiro_evento { get { return tb_financeiro_evento; } }

        public ObjectSet<tb_financeiro_prazo> tb_financeiro_prazo
        {
            get
            {
                if (_tb_financeiro_prazo == null)
                    _tb_financeiro_prazo = CreateObjectSet<tb_financeiro_prazo>("tb_financeiro_prazo");
                return _tb_financeiro_prazo;
            }
        }
        private ObjectSet<tb_financeiro_prazo> _tb_financeiro_prazo;
        IObjectSet<tb_financeiro_prazo> IASAEntities.tb_financeiro_prazo { get { return tb_financeiro_prazo; } }

        public ObjectSet<tb_financeiro_sangria> tb_financeiro_sangria
        {
            get
            {
                if (_tb_financeiro_sangria == null)
                    _tb_financeiro_sangria = CreateObjectSet<tb_financeiro_sangria>("tb_financeiro_sangria");
                return _tb_financeiro_sangria;
            }
        }
        private ObjectSet<tb_financeiro_sangria> _tb_financeiro_sangria;
        IObjectSet<tb_financeiro_sangria> IASAEntities.tb_financeiro_sangria { get { return tb_financeiro_sangria; } }

        public ObjectSet<tb_financeiro_suprimento> tb_financeiro_suprimento
        {
            get
            {
                if (_tb_financeiro_suprimento == null)
                    _tb_financeiro_suprimento = CreateObjectSet<tb_financeiro_suprimento>("tb_financeiro_suprimento");
                return _tb_financeiro_suprimento;
            }
        }
        private ObjectSet<tb_financeiro_suprimento> _tb_financeiro_suprimento;
        IObjectSet<tb_financeiro_suprimento> IASAEntities.tb_financeiro_suprimento { get { return tb_financeiro_suprimento; } }

        public ObjectSet<tb_fornecedor> tb_fornecedor
        {
            get
            {
                if (_tb_fornecedor == null)
                    _tb_fornecedor = CreateObjectSet<tb_fornecedor>("tb_fornecedor");
                return _tb_fornecedor;
            }
        }
        private ObjectSet<tb_fornecedor> _tb_fornecedor;
        IObjectSet<tb_fornecedor> IASAEntities.tb_fornecedor { get { return tb_fornecedor; } }

        public ObjectSet<tb_fornecedor_divisao> tb_fornecedor_divisao
        {
            get
            {
                if (_tb_fornecedor_divisao == null)
                    _tb_fornecedor_divisao = CreateObjectSet<tb_fornecedor_divisao>("tb_fornecedor_divisao");
                return _tb_fornecedor_divisao;
            }
        }
        private ObjectSet<tb_fornecedor_divisao> _tb_fornecedor_divisao;
        IObjectSet<tb_fornecedor_divisao> IASAEntities.tb_fornecedor_divisao { get { return tb_fornecedor_divisao; } }

        public ObjectSet<tb_funcionario> tb_funcionario
        {
            get
            {
                if (_tb_funcionario == null)
                    _tb_funcionario = CreateObjectSet<tb_funcionario>("tb_funcionario");
                return _tb_funcionario;
            }
        }
        private ObjectSet<tb_funcionario> _tb_funcionario;
        IObjectSet<tb_funcionario> IASAEntities.tb_funcionario { get { return tb_funcionario; } }

        public ObjectSet<tb_funcionario_horario> tb_funcionario_horario
        {
            get
            {
                if (_tb_funcionario_horario == null)
                    _tb_funcionario_horario = CreateObjectSet<tb_funcionario_horario>("tb_funcionario_horario");
                return _tb_funcionario_horario;
            }
        }
        private ObjectSet<tb_funcionario_horario> _tb_funcionario_horario;
        IObjectSet<tb_funcionario_horario> IASAEntities.tb_funcionario_horario { get { return tb_funcionario_horario; } }

        public ObjectSet<tb_funcionario_horario_item> tb_funcionario_horario_item
        {
            get
            {
                if (_tb_funcionario_horario_item == null)
                    _tb_funcionario_horario_item = CreateObjectSet<tb_funcionario_horario_item>("tb_funcionario_horario_item");
                return _tb_funcionario_horario_item;
            }
        }
        private ObjectSet<tb_funcionario_horario_item> _tb_funcionario_horario_item;
        IObjectSet<tb_funcionario_horario_item> IASAEntities.tb_funcionario_horario_item { get { return tb_funcionario_horario_item; } }

        public ObjectSet<tb_funcionario_visitante> tb_funcionario_visitante
        {
            get
            {
                if (_tb_funcionario_visitante == null)
                    _tb_funcionario_visitante = CreateObjectSet<tb_funcionario_visitante>("tb_funcionario_visitante");
                return _tb_funcionario_visitante;
            }
        }
        private ObjectSet<tb_funcionario_visitante> _tb_funcionario_visitante;
        IObjectSet<tb_funcionario_visitante> IASAEntities.tb_funcionario_visitante { get { return tb_funcionario_visitante; } }

        public ObjectSet<tb_hist_sangria____> tb_hist_sangria____
        {
            get
            {
                if (_tb_hist_sangria____ == null)
                    _tb_hist_sangria____ = CreateObjectSet<tb_hist_sangria____>("tb_hist_sangria____");
                return _tb_hist_sangria____;
            }
        }
        private ObjectSet<tb_hist_sangria____> _tb_hist_sangria____;
        IObjectSet<tb_hist_sangria____> IASAEntities.tb_hist_sangria____ { get { return tb_hist_sangria____; } }

        public ObjectSet<tb_ibge> tb_ibge
        {
            get
            {
                if (_tb_ibge == null)
                    _tb_ibge = CreateObjectSet<tb_ibge>("tb_ibge");
                return _tb_ibge;
            }
        }
        private ObjectSet<tb_ibge> _tb_ibge;
        IObjectSet<tb_ibge> IASAEntities.tb_ibge { get { return tb_ibge; } }

        public ObjectSet<tb_ibpt_ax> tb_ibpt_ax
        {
            get
            {
                if (_tb_ibpt_ax == null)
                    _tb_ibpt_ax = CreateObjectSet<tb_ibpt_ax>("tb_ibpt_ax");
                return _tb_ibpt_ax;
            }
        }
        private ObjectSet<tb_ibpt_ax> _tb_ibpt_ax;
        IObjectSet<tb_ibpt_ax> IASAEntities.tb_ibpt_ax { get { return tb_ibpt_ax; } }

        public ObjectSet<tb_lancto_financeiro> tb_lancto_financeiro
        {
            get
            {
                if (_tb_lancto_financeiro == null)
                    _tb_lancto_financeiro = CreateObjectSet<tb_lancto_financeiro>("tb_lancto_financeiro");
                return _tb_lancto_financeiro;
            }
        }
        private ObjectSet<tb_lancto_financeiro> _tb_lancto_financeiro;
        IObjectSet<tb_lancto_financeiro> IASAEntities.tb_lancto_financeiro { get { return tb_lancto_financeiro; } }

        public ObjectSet<tb_liquidacao_forma> tb_liquidacao_forma
        {
            get
            {
                if (_tb_liquidacao_forma == null)
                    _tb_liquidacao_forma = CreateObjectSet<tb_liquidacao_forma>("tb_liquidacao_forma");
                return _tb_liquidacao_forma;
            }
        }
        private ObjectSet<tb_liquidacao_forma> _tb_liquidacao_forma;
        IObjectSet<tb_liquidacao_forma> IASAEntities.tb_liquidacao_forma { get { return tb_liquidacao_forma; } }

        public ObjectSet<tb_liquidacao_motivo> tb_liquidacao_motivo
        {
            get
            {
                if (_tb_liquidacao_motivo == null)
                    _tb_liquidacao_motivo = CreateObjectSet<tb_liquidacao_motivo>("tb_liquidacao_motivo");
                return _tb_liquidacao_motivo;
            }
        }
        private ObjectSet<tb_liquidacao_motivo> _tb_liquidacao_motivo;
        IObjectSet<tb_liquidacao_motivo> IASAEntities.tb_liquidacao_motivo { get { return tb_liquidacao_motivo; } }

        public ObjectSet<tb_mvto_compra____> tb_mvto_compra____
        {
            get
            {
                if (_tb_mvto_compra____ == null)
                    _tb_mvto_compra____ = CreateObjectSet<tb_mvto_compra____>("tb_mvto_compra____");
                return _tb_mvto_compra____;
            }
        }
        private ObjectSet<tb_mvto_compra____> _tb_mvto_compra____;
        IObjectSet<tb_mvto_compra____> IASAEntities.tb_mvto_compra____ { get { return tb_mvto_compra____; } }

        public ObjectSet<tb_mvto_compra_dup____> tb_mvto_compra_dup____
        {
            get
            {
                if (_tb_mvto_compra_dup____ == null)
                    _tb_mvto_compra_dup____ = CreateObjectSet<tb_mvto_compra_dup____>("tb_mvto_compra_dup____");
                return _tb_mvto_compra_dup____;
            }
        }
        private ObjectSet<tb_mvto_compra_dup____> _tb_mvto_compra_dup____;
        IObjectSet<tb_mvto_compra_dup____> IASAEntities.tb_mvto_compra_dup____ { get { return tb_mvto_compra_dup____; } }

        public ObjectSet<tb_mvto_compra_item____> tb_mvto_compra_item____
        {
            get
            {
                if (_tb_mvto_compra_item____ == null)
                    _tb_mvto_compra_item____ = CreateObjectSet<tb_mvto_compra_item____>("tb_mvto_compra_item____");
                return _tb_mvto_compra_item____;
            }
        }
        private ObjectSet<tb_mvto_compra_item____> _tb_mvto_compra_item____;
        IObjectSet<tb_mvto_compra_item____> IASAEntities.tb_mvto_compra_item____ { get { return tb_mvto_compra_item____; } }

        public ObjectSet<tb_mvto_compra_item_divergencia____> tb_mvto_compra_item_divergencia____
        {
            get
            {
                if (_tb_mvto_compra_item_divergencia____ == null)
                    _tb_mvto_compra_item_divergencia____ = CreateObjectSet<tb_mvto_compra_item_divergencia____>("tb_mvto_compra_item_divergencia____");
                return _tb_mvto_compra_item_divergencia____;
            }
        }
        private ObjectSet<tb_mvto_compra_item_divergencia____> _tb_mvto_compra_item_divergencia____;
        IObjectSet<tb_mvto_compra_item_divergencia____> IASAEntities.tb_mvto_compra_item_divergencia____ { get { return tb_mvto_compra_item_divergencia____; } }

        public ObjectSet<tb_mvto_compra_item_lote____> tb_mvto_compra_item_lote____
        {
            get
            {
                if (_tb_mvto_compra_item_lote____ == null)
                    _tb_mvto_compra_item_lote____ = CreateObjectSet<tb_mvto_compra_item_lote____>("tb_mvto_compra_item_lote____");
                return _tb_mvto_compra_item_lote____;
            }
        }
        private ObjectSet<tb_mvto_compra_item_lote____> _tb_mvto_compra_item_lote____;
        IObjectSet<tb_mvto_compra_item_lote____> IASAEntities.tb_mvto_compra_item_lote____ { get { return tb_mvto_compra_item_lote____; } }

        public ObjectSet<tb_mvto_fin____> tb_mvto_fin____
        {
            get
            {
                if (_tb_mvto_fin____ == null)
                    _tb_mvto_fin____ = CreateObjectSet<tb_mvto_fin____>("tb_mvto_fin____");
                return _tb_mvto_fin____;
            }
        }
        private ObjectSet<tb_mvto_fin____> _tb_mvto_fin____;
        IObjectSet<tb_mvto_fin____> IASAEntities.tb_mvto_fin____ { get { return tb_mvto_fin____; } }

        public ObjectSet<tb_nfe> tb_nfe
        {
            get
            {
                if (_tb_nfe == null)
                    _tb_nfe = CreateObjectSet<tb_nfe>("tb_nfe");
                return _tb_nfe;
            }
        }
        private ObjectSet<tb_nfe> _tb_nfe;
        IObjectSet<tb_nfe> IASAEntities.tb_nfe { get { return tb_nfe; } }

        public ObjectSet<tb_nfe_cfop> tb_nfe_cfop
        {
            get
            {
                if (_tb_nfe_cfop == null)
                    _tb_nfe_cfop = CreateObjectSet<tb_nfe_cfop>("tb_nfe_cfop");
                return _tb_nfe_cfop;
            }
        }
        private ObjectSet<tb_nfe_cfop> _tb_nfe_cfop;
        IObjectSet<tb_nfe_cfop> IASAEntities.tb_nfe_cfop { get { return tb_nfe_cfop; } }

        public ObjectSet<tb_nfe_danfe> tb_nfe_danfe
        {
            get
            {
                if (_tb_nfe_danfe == null)
                    _tb_nfe_danfe = CreateObjectSet<tb_nfe_danfe>("tb_nfe_danfe");
                return _tb_nfe_danfe;
            }
        }
        private ObjectSet<tb_nfe_danfe> _tb_nfe_danfe;
        IObjectSet<tb_nfe_danfe> IASAEntities.tb_nfe_danfe { get { return tb_nfe_danfe; } }

        public ObjectSet<tb_nfe_finalizadora> tb_nfe_finalizadora
        {
            get
            {
                if (_tb_nfe_finalizadora == null)
                    _tb_nfe_finalizadora = CreateObjectSet<tb_nfe_finalizadora>("tb_nfe_finalizadora");
                return _tb_nfe_finalizadora;
            }
        }
        private ObjectSet<tb_nfe_finalizadora> _tb_nfe_finalizadora;
        IObjectSet<tb_nfe_finalizadora> IASAEntities.tb_nfe_finalizadora { get { return tb_nfe_finalizadora; } }

        public ObjectSet<tb_nfe_item> tb_nfe_item
        {
            get
            {
                if (_tb_nfe_item == null)
                    _tb_nfe_item = CreateObjectSet<tb_nfe_item>("tb_nfe_item");
                return _tb_nfe_item;
            }
        }
        private ObjectSet<tb_nfe_item> _tb_nfe_item;
        IObjectSet<tb_nfe_item> IASAEntities.tb_nfe_item { get { return tb_nfe_item; } }

        public ObjectSet<tb_paciente_anvisa> tb_paciente_anvisa
        {
            get
            {
                if (_tb_paciente_anvisa == null)
                    _tb_paciente_anvisa = CreateObjectSet<tb_paciente_anvisa>("tb_paciente_anvisa");
                return _tb_paciente_anvisa;
            }
        }
        private ObjectSet<tb_paciente_anvisa> _tb_paciente_anvisa;
        IObjectSet<tb_paciente_anvisa> IASAEntities.tb_paciente_anvisa { get { return tb_paciente_anvisa; } }

        public ObjectSet<tb_paf_numero> tb_paf_numero
        {
            get
            {
                if (_tb_paf_numero == null)
                    _tb_paf_numero = CreateObjectSet<tb_paf_numero>("tb_paf_numero");
                return _tb_paf_numero;
            }
        }
        private ObjectSet<tb_paf_numero> _tb_paf_numero;
        IObjectSet<tb_paf_numero> IASAEntities.tb_paf_numero { get { return tb_paf_numero; } }

        public ObjectSet<tb_parametro> tb_parametro
        {
            get
            {
                if (_tb_parametro == null)
                    _tb_parametro = CreateObjectSet<tb_parametro>("tb_parametro");
                return _tb_parametro;
            }
        }
        private ObjectSet<tb_parametro> _tb_parametro;
        IObjectSet<tb_parametro> IASAEntities.tb_parametro { get { return tb_parametro; } }

        public ObjectSet<tb_parametro_comissao> tb_parametro_comissao
        {
            get
            {
                if (_tb_parametro_comissao == null)
                    _tb_parametro_comissao = CreateObjectSet<tb_parametro_comissao>("tb_parametro_comissao");
                return _tb_parametro_comissao;
            }
        }
        private ObjectSet<tb_parametro_comissao> _tb_parametro_comissao;
        IObjectSet<tb_parametro_comissao> IASAEntities.tb_parametro_comissao { get { return tb_parametro_comissao; } }

        public ObjectSet<tb_parametro_descconv> tb_parametro_descconv
        {
            get
            {
                if (_tb_parametro_descconv == null)
                    _tb_parametro_descconv = CreateObjectSet<tb_parametro_descconv>("tb_parametro_descconv");
                return _tb_parametro_descconv;
            }
        }
        private ObjectSet<tb_parametro_descconv> _tb_parametro_descconv;
        IObjectSet<tb_parametro_descconv> IASAEntities.tb_parametro_descconv { get { return tb_parametro_descconv; } }

        public ObjectSet<tb_parametro_descmax> tb_parametro_descmax
        {
            get
            {
                if (_tb_parametro_descmax == null)
                    _tb_parametro_descmax = CreateObjectSet<tb_parametro_descmax>("tb_parametro_descmax");
                return _tb_parametro_descmax;
            }
        }
        private ObjectSet<tb_parametro_descmax> _tb_parametro_descmax;
        IObjectSet<tb_parametro_descmax> IASAEntities.tb_parametro_descmax { get { return tb_parametro_descmax; } }

        public ObjectSet<tb_parametro_descprod> tb_parametro_descprod
        {
            get
            {
                if (_tb_parametro_descprod == null)
                    _tb_parametro_descprod = CreateObjectSet<tb_parametro_descprod>("tb_parametro_descprod");
                return _tb_parametro_descprod;
            }
        }
        private ObjectSet<tb_parametro_descprod> _tb_parametro_descprod;
        IObjectSet<tb_parametro_descprod> IASAEntities.tb_parametro_descprod { get { return tb_parametro_descprod; } }

        public ObjectSet<tb_parametro_descvend> tb_parametro_descvend
        {
            get
            {
                if (_tb_parametro_descvend == null)
                    _tb_parametro_descvend = CreateObjectSet<tb_parametro_descvend>("tb_parametro_descvend");
                return _tb_parametro_descvend;
            }
        }
        private ObjectSet<tb_parametro_descvend> _tb_parametro_descvend;
        IObjectSet<tb_parametro_descvend> IASAEntities.tb_parametro_descvend { get { return tb_parametro_descvend; } }

        public ObjectSet<tb_parametro_limpezas> tb_parametro_limpezas
        {
            get
            {
                if (_tb_parametro_limpezas == null)
                    _tb_parametro_limpezas = CreateObjectSet<tb_parametro_limpezas>("tb_parametro_limpezas");
                return _tb_parametro_limpezas;
            }
        }
        private ObjectSet<tb_parametro_limpezas> _tb_parametro_limpezas;
        IObjectSet<tb_parametro_limpezas> IASAEntities.tb_parametro_limpezas { get { return tb_parametro_limpezas; } }

        public ObjectSet<tb_parametro_markup> tb_parametro_markup
        {
            get
            {
                if (_tb_parametro_markup == null)
                    _tb_parametro_markup = CreateObjectSet<tb_parametro_markup>("tb_parametro_markup");
                return _tb_parametro_markup;
            }
        }
        private ObjectSet<tb_parametro_markup> _tb_parametro_markup;
        IObjectSet<tb_parametro_markup> IASAEntities.tb_parametro_markup { get { return tb_parametro_markup; } }

        public ObjectSet<tb_pbm> tb_pbm
        {
            get
            {
                if (_tb_pbm == null)
                    _tb_pbm = CreateObjectSet<tb_pbm>("tb_pbm");
                return _tb_pbm;
            }
        }
        private ObjectSet<tb_pbm> _tb_pbm;
        IObjectSet<tb_pbm> IASAEntities.tb_pbm { get { return tb_pbm; } }

        public ObjectSet<tb_pedido_compra____> tb_pedido_compra____
        {
            get
            {
                if (_tb_pedido_compra____ == null)
                    _tb_pedido_compra____ = CreateObjectSet<tb_pedido_compra____>("tb_pedido_compra____");
                return _tb_pedido_compra____;
            }
        }
        private ObjectSet<tb_pedido_compra____> _tb_pedido_compra____;
        IObjectSet<tb_pedido_compra____> IASAEntities.tb_pedido_compra____ { get { return tb_pedido_compra____; } }

        public ObjectSet<tb_pedido_compra_item____> tb_pedido_compra_item____
        {
            get
            {
                if (_tb_pedido_compra_item____ == null)
                    _tb_pedido_compra_item____ = CreateObjectSet<tb_pedido_compra_item____>("tb_pedido_compra_item____");
                return _tb_pedido_compra_item____;
            }
        }
        private ObjectSet<tb_pedido_compra_item____> _tb_pedido_compra_item____;
        IObjectSet<tb_pedido_compra_item____> IASAEntities.tb_pedido_compra_item____ { get { return tb_pedido_compra_item____; } }

        public ObjectSet<tb_piscofins> tb_piscofins
        {
            get
            {
                if (_tb_piscofins == null)
                    _tb_piscofins = CreateObjectSet<tb_piscofins>("tb_piscofins");
                return _tb_piscofins;
            }
        }
        private ObjectSet<tb_piscofins> _tb_piscofins;
        IObjectSet<tb_piscofins> IASAEntities.tb_piscofins { get { return tb_piscofins; } }

        public ObjectSet<tb_ponto> tb_ponto
        {
            get
            {
                if (_tb_ponto == null)
                    _tb_ponto = CreateObjectSet<tb_ponto>("tb_ponto");
                return _tb_ponto;
            }
        }
        private ObjectSet<tb_ponto> _tb_ponto;
        IObjectSet<tb_ponto> IASAEntities.tb_ponto { get { return tb_ponto; } }

        public ObjectSet<tb_ponto_motivo> tb_ponto_motivo
        {
            get
            {
                if (_tb_ponto_motivo == null)
                    _tb_ponto_motivo = CreateObjectSet<tb_ponto_motivo>("tb_ponto_motivo");
                return _tb_ponto_motivo;
            }
        }
        private ObjectSet<tb_ponto_motivo> _tb_ponto_motivo;
        IObjectSet<tb_ponto_motivo> IASAEntities.tb_ponto_motivo { get { return tb_ponto_motivo; } }

        public ObjectSet<tb_princ_ativo> tb_princ_ativo
        {
            get
            {
                if (_tb_princ_ativo == null)
                    _tb_princ_ativo = CreateObjectSet<tb_princ_ativo>("tb_princ_ativo");
                return _tb_princ_ativo;
            }
        }
        private ObjectSet<tb_princ_ativo> _tb_princ_ativo;
        IObjectSet<tb_princ_ativo> IASAEntities.tb_princ_ativo { get { return tb_princ_ativo; } }

        public ObjectSet<tb_privatelabel> tb_privatelabel
        {
            get
            {
                if (_tb_privatelabel == null)
                    _tb_privatelabel = CreateObjectSet<tb_privatelabel>("tb_privatelabel");
                return _tb_privatelabel;
            }
        }
        private ObjectSet<tb_privatelabel> _tb_privatelabel;
        IObjectSet<tb_privatelabel> IASAEntities.tb_privatelabel { get { return tb_privatelabel; } }

        public ObjectSet<tb_privatelabel_finalizadora> tb_privatelabel_finalizadora
        {
            get
            {
                if (_tb_privatelabel_finalizadora == null)
                    _tb_privatelabel_finalizadora = CreateObjectSet<tb_privatelabel_finalizadora>("tb_privatelabel_finalizadora");
                return _tb_privatelabel_finalizadora;
            }
        }
        private ObjectSet<tb_privatelabel_finalizadora> _tb_privatelabel_finalizadora;
        IObjectSet<tb_privatelabel_finalizadora> IASAEntities.tb_privatelabel_finalizadora { get { return tb_privatelabel_finalizadora; } }

        public ObjectSet<tb_produto> tb_produto
        {
            get
            {
                if (_tb_produto == null)
                    _tb_produto = CreateObjectSet<tb_produto>("tb_produto");
                return _tb_produto;
            }
        }
        private ObjectSet<tb_produto> _tb_produto;
        IObjectSet<tb_produto> IASAEntities.tb_produto { get { return tb_produto; } }

        public ObjectSet<tb_produto_barra> tb_produto_barra
        {
            get
            {
                if (_tb_produto_barra == null)
                    _tb_produto_barra = CreateObjectSet<tb_produto_barra>("tb_produto_barra");
                return _tb_produto_barra;
            }
        }
        private ObjectSet<tb_produto_barra> _tb_produto_barra;
        IObjectSet<tb_produto_barra> IASAEntities.tb_produto_barra { get { return tb_produto_barra; } }

        public ObjectSet<tb_produto_classe> tb_produto_classe
        {
            get
            {
                if (_tb_produto_classe == null)
                    _tb_produto_classe = CreateObjectSet<tb_produto_classe>("tb_produto_classe");
                return _tb_produto_classe;
            }
        }
        private ObjectSet<tb_produto_classe> _tb_produto_classe;
        IObjectSet<tb_produto_classe> IASAEntities.tb_produto_classe { get { return tb_produto_classe; } }

        public ObjectSet<tb_produto_fam_categ_sub> tb_produto_fam_categ_sub
        {
            get
            {
                if (_tb_produto_fam_categ_sub == null)
                    _tb_produto_fam_categ_sub = CreateObjectSet<tb_produto_fam_categ_sub>("tb_produto_fam_categ_sub");
                return _tb_produto_fam_categ_sub;
            }
        }
        private ObjectSet<tb_produto_fam_categ_sub> _tb_produto_fam_categ_sub;
        IObjectSet<tb_produto_fam_categ_sub> IASAEntities.tb_produto_fam_categ_sub { get { return tb_produto_fam_categ_sub; } }

        public ObjectSet<tb_produto_fam_categoria> tb_produto_fam_categoria
        {
            get
            {
                if (_tb_produto_fam_categoria == null)
                    _tb_produto_fam_categoria = CreateObjectSet<tb_produto_fam_categoria>("tb_produto_fam_categoria");
                return _tb_produto_fam_categoria;
            }
        }
        private ObjectSet<tb_produto_fam_categoria> _tb_produto_fam_categoria;
        IObjectSet<tb_produto_fam_categoria> IASAEntities.tb_produto_fam_categoria { get { return tb_produto_fam_categoria; } }

        public ObjectSet<tb_produto_fam_grupo> tb_produto_fam_grupo
        {
            get
            {
                if (_tb_produto_fam_grupo == null)
                    _tb_produto_fam_grupo = CreateObjectSet<tb_produto_fam_grupo>("tb_produto_fam_grupo");
                return _tb_produto_fam_grupo;
            }
        }
        private ObjectSet<tb_produto_fam_grupo> _tb_produto_fam_grupo;
        IObjectSet<tb_produto_fam_grupo> IASAEntities.tb_produto_fam_grupo { get { return tb_produto_fam_grupo; } }

        public ObjectSet<tb_produto_familia> tb_produto_familia
        {
            get
            {
                if (_tb_produto_familia == null)
                    _tb_produto_familia = CreateObjectSet<tb_produto_familia>("tb_produto_familia");
                return _tb_produto_familia;
            }
        }
        private ObjectSet<tb_produto_familia> _tb_produto_familia;
        IObjectSet<tb_produto_familia> IASAEntities.tb_produto_familia { get { return tb_produto_familia; } }

        public ObjectSet<tb_produto_kit> tb_produto_kit
        {
            get
            {
                if (_tb_produto_kit == null)
                    _tb_produto_kit = CreateObjectSet<tb_produto_kit>("tb_produto_kit");
                return _tb_produto_kit;
            }
        }
        private ObjectSet<tb_produto_kit> _tb_produto_kit;
        IObjectSet<tb_produto_kit> IASAEntities.tb_produto_kit { get { return tb_produto_kit; } }

        public ObjectSet<tb_produto_linha> tb_produto_linha
        {
            get
            {
                if (_tb_produto_linha == null)
                    _tb_produto_linha = CreateObjectSet<tb_produto_linha>("tb_produto_linha");
                return _tb_produto_linha;
            }
        }
        private ObjectSet<tb_produto_linha> _tb_produto_linha;
        IObjectSet<tb_produto_linha> IASAEntities.tb_produto_linha { get { return tb_produto_linha; } }

        public ObjectSet<tb_produto_piscofins> tb_produto_piscofins
        {
            get
            {
                if (_tb_produto_piscofins == null)
                    _tb_produto_piscofins = CreateObjectSet<tb_produto_piscofins>("tb_produto_piscofins");
                return _tb_produto_piscofins;
            }
        }
        private ObjectSet<tb_produto_piscofins> _tb_produto_piscofins;
        IObjectSet<tb_produto_piscofins> IASAEntities.tb_produto_piscofins { get { return tb_produto_piscofins; } }

        public ObjectSet<tb_produto_princativo> tb_produto_princativo
        {
            get
            {
                if (_tb_produto_princativo == null)
                    _tb_produto_princativo = CreateObjectSet<tb_produto_princativo>("tb_produto_princativo");
                return _tb_produto_princativo;
            }
        }
        private ObjectSet<tb_produto_princativo> _tb_produto_princativo;
        IObjectSet<tb_produto_princativo> IASAEntities.tb_produto_princativo { get { return tb_produto_princativo; } }

        public ObjectSet<tb_produto_receituario> tb_produto_receituario
        {
            get
            {
                if (_tb_produto_receituario == null)
                    _tb_produto_receituario = CreateObjectSet<tb_produto_receituario>("tb_produto_receituario");
                return _tb_produto_receituario;
            }
        }
        private ObjectSet<tb_produto_receituario> _tb_produto_receituario;
        IObjectSet<tb_produto_receituario> IASAEntities.tb_produto_receituario { get { return tb_produto_receituario; } }

        public ObjectSet<tb_produto_similaridade> tb_produto_similaridade
        {
            get
            {
                if (_tb_produto_similaridade == null)
                    _tb_produto_similaridade = CreateObjectSet<tb_produto_similaridade>("tb_produto_similaridade");
                return _tb_produto_similaridade;
            }
        }
        private ObjectSet<tb_produto_similaridade> _tb_produto_similaridade;
        IObjectSet<tb_produto_similaridade> IASAEntities.tb_produto_similaridade { get { return tb_produto_similaridade; } }

        public ObjectSet<tb_promocao> tb_promocao
        {
            get
            {
                if (_tb_promocao == null)
                    _tb_promocao = CreateObjectSet<tb_promocao>("tb_promocao");
                return _tb_promocao;
            }
        }
        private ObjectSet<tb_promocao> _tb_promocao;
        IObjectSet<tb_promocao> IASAEntities.tb_promocao { get { return tb_promocao; } }

        public ObjectSet<tb_promocao_tipo> tb_promocao_tipo
        {
            get
            {
                if (_tb_promocao_tipo == null)
                    _tb_promocao_tipo = CreateObjectSet<tb_promocao_tipo>("tb_promocao_tipo");
                return _tb_promocao_tipo;
            }
        }
        private ObjectSet<tb_promocao_tipo> _tb_promocao_tipo;
        IObjectSet<tb_promocao_tipo> IASAEntities.tb_promocao_tipo { get { return tb_promocao_tipo; } }

        public ObjectSet<tb_recarga> tb_recarga
        {
            get
            {
                if (_tb_recarga == null)
                    _tb_recarga = CreateObjectSet<tb_recarga>("tb_recarga");
                return _tb_recarga;
            }
        }
        private ObjectSet<tb_recarga> _tb_recarga;
        IObjectSet<tb_recarga> IASAEntities.tb_recarga { get { return tb_recarga; } }

        public ObjectSet<tb_recarga_finalizadora> tb_recarga_finalizadora
        {
            get
            {
                if (_tb_recarga_finalizadora == null)
                    _tb_recarga_finalizadora = CreateObjectSet<tb_recarga_finalizadora>("tb_recarga_finalizadora");
                return _tb_recarga_finalizadora;
            }
        }
        private ObjectSet<tb_recarga_finalizadora> _tb_recarga_finalizadora;
        IObjectSet<tb_recarga_finalizadora> IASAEntities.tb_recarga_finalizadora { get { return tb_recarga_finalizadora; } }

        public ObjectSet<tb_reducao_z> tb_reducao_z
        {
            get
            {
                if (_tb_reducao_z == null)
                    _tb_reducao_z = CreateObjectSet<tb_reducao_z>("tb_reducao_z");
                return _tb_reducao_z;
            }
        }
        private ObjectSet<tb_reducao_z> _tb_reducao_z;
        IObjectSet<tb_reducao_z> IASAEntities.tb_reducao_z { get { return tb_reducao_z; } }

        public ObjectSet<tb_reducao_z_itens> tb_reducao_z_itens
        {
            get
            {
                if (_tb_reducao_z_itens == null)
                    _tb_reducao_z_itens = CreateObjectSet<tb_reducao_z_itens>("tb_reducao_z_itens");
                return _tb_reducao_z_itens;
            }
        }
        private ObjectSet<tb_reducao_z_itens> _tb_reducao_z_itens;
        IObjectSet<tb_reducao_z_itens> IASAEntities.tb_reducao_z_itens { get { return tb_reducao_z_itens; } }

        public ObjectSet<tb_sangrias> tb_sangrias
        {
            get
            {
                if (_tb_sangrias == null)
                    _tb_sangrias = CreateObjectSet<tb_sangrias>("tb_sangrias");
                return _tb_sangrias;
            }
        }
        private ObjectSet<tb_sangrias> _tb_sangrias;
        IObjectSet<tb_sangrias> IASAEntities.tb_sangrias { get { return tb_sangrias; } }

        public ObjectSet<tb_serie_nota> tb_serie_nota
        {
            get
            {
                if (_tb_serie_nota == null)
                    _tb_serie_nota = CreateObjectSet<tb_serie_nota>("tb_serie_nota");
                return _tb_serie_nota;
            }
        }
        private ObjectSet<tb_serie_nota> _tb_serie_nota;
        IObjectSet<tb_serie_nota> IASAEntities.tb_serie_nota { get { return tb_serie_nota; } }

        public ObjectSet<tb_sincronizacao> tb_sincronizacao
        {
            get
            {
                if (_tb_sincronizacao == null)
                    _tb_sincronizacao = CreateObjectSet<tb_sincronizacao>("tb_sincronizacao");
                return _tb_sincronizacao;
            }
        }
        private ObjectSet<tb_sincronizacao> _tb_sincronizacao;
        IObjectSet<tb_sincronizacao> IASAEntities.tb_sincronizacao { get { return tb_sincronizacao; } }

        public ObjectSet<tb_suprimentos> tb_suprimentos
        {
            get
            {
                if (_tb_suprimentos == null)
                    _tb_suprimentos = CreateObjectSet<tb_suprimentos>("tb_suprimentos");
                return _tb_suprimentos;
            }
        }
        private ObjectSet<tb_suprimentos> _tb_suprimentos;
        IObjectSet<tb_suprimentos> IASAEntities.tb_suprimentos { get { return tb_suprimentos; } }

        public ObjectSet<tb_terminal> tb_terminal
        {
            get
            {
                if (_tb_terminal == null)
                    _tb_terminal = CreateObjectSet<tb_terminal>("tb_terminal");
                return _tb_terminal;
            }
        }
        private ObjectSet<tb_terminal> _tb_terminal;
        IObjectSet<tb_terminal> IASAEntities.tb_terminal { get { return tb_terminal; } }

        public ObjectSet<tb_terminal_mobile> tb_terminal_mobile
        {
            get
            {
                if (_tb_terminal_mobile == null)
                    _tb_terminal_mobile = CreateObjectSet<tb_terminal_mobile>("tb_terminal_mobile");
                return _tb_terminal_mobile;
            }
        }
        private ObjectSet<tb_terminal_mobile> _tb_terminal_mobile;
        IObjectSet<tb_terminal_mobile> IASAEntities.tb_terminal_mobile { get { return tb_terminal_mobile; } }

        public ObjectSet<tb_tipo_logradouro> tb_tipo_logradouro
        {
            get
            {
                if (_tb_tipo_logradouro == null)
                    _tb_tipo_logradouro = CreateObjectSet<tb_tipo_logradouro>("tb_tipo_logradouro");
                return _tb_tipo_logradouro;
            }
        }
        private ObjectSet<tb_tipo_logradouro> _tb_tipo_logradouro;
        IObjectSet<tb_tipo_logradouro> IASAEntities.tb_tipo_logradouro { get { return tb_tipo_logradouro; } }

        public ObjectSet<tb_tipo_mvto_produto> tb_tipo_mvto_produto
        {
            get
            {
                if (_tb_tipo_mvto_produto == null)
                    _tb_tipo_mvto_produto = CreateObjectSet<tb_tipo_mvto_produto>("tb_tipo_mvto_produto");
                return _tb_tipo_mvto_produto;
            }
        }
        private ObjectSet<tb_tipo_mvto_produto> _tb_tipo_mvto_produto;
        IObjectSet<tb_tipo_mvto_produto> IASAEntities.tb_tipo_mvto_produto { get { return tb_tipo_mvto_produto; } }

        public ObjectSet<tb_tipo_nota> tb_tipo_nota
        {
            get
            {
                if (_tb_tipo_nota == null)
                    _tb_tipo_nota = CreateObjectSet<tb_tipo_nota>("tb_tipo_nota");
                return _tb_tipo_nota;
            }
        }
        private ObjectSet<tb_tipo_nota> _tb_tipo_nota;
        IObjectSet<tb_tipo_nota> IASAEntities.tb_tipo_nota { get { return tb_tipo_nota; } }

        public ObjectSet<tb_transportadora> tb_transportadora
        {
            get
            {
                if (_tb_transportadora == null)
                    _tb_transportadora = CreateObjectSet<tb_transportadora>("tb_transportadora");
                return _tb_transportadora;
            }
        }
        private ObjectSet<tb_transportadora> _tb_transportadora;
        IObjectSet<tb_transportadora> IASAEntities.tb_transportadora { get { return tb_transportadora; } }

        public ObjectSet<tb_tributacao> tb_tributacao
        {
            get
            {
                if (_tb_tributacao == null)
                    _tb_tributacao = CreateObjectSet<tb_tributacao>("tb_tributacao");
                return _tb_tributacao;
            }
        }
        private ObjectSet<tb_tributacao> _tb_tributacao;
        IObjectSet<tb_tributacao> IASAEntities.tb_tributacao { get { return tb_tributacao; } }

        public ObjectSet<tb_uf> tb_uf
        {
            get
            {
                if (_tb_uf == null)
                    _tb_uf = CreateObjectSet<tb_uf>("tb_uf");
                return _tb_uf;
            }
        }
        private ObjectSet<tb_uf> _tb_uf;
        IObjectSet<tb_uf> IASAEntities.tb_uf { get { return tb_uf; } }

        public ObjectSet<tb_unid_negocio> tb_unid_negocio
        {
            get
            {
                if (_tb_unid_negocio == null)
                    _tb_unid_negocio = CreateObjectSet<tb_unid_negocio>("tb_unid_negocio");
                return _tb_unid_negocio;
            }
        }
        private ObjectSet<tb_unid_negocio> _tb_unid_negocio;
        IObjectSet<tb_unid_negocio> IASAEntities.tb_unid_negocio { get { return tb_unid_negocio; } }

        public ObjectSet<tb_unid_negocio_grupo> tb_unid_negocio_grupo
        {
            get
            {
                if (_tb_unid_negocio_grupo == null)
                    _tb_unid_negocio_grupo = CreateObjectSet<tb_unid_negocio_grupo>("tb_unid_negocio_grupo");
                return _tb_unid_negocio_grupo;
            }
        }
        private ObjectSet<tb_unid_negocio_grupo> _tb_unid_negocio_grupo;
        IObjectSet<tb_unid_negocio_grupo> IASAEntities.tb_unid_negocio_grupo { get { return tb_unid_negocio_grupo; } }

        public ObjectSet<tb_unid_negocio_parametro> tb_unid_negocio_parametro
        {
            get
            {
                if (_tb_unid_negocio_parametro == null)
                    _tb_unid_negocio_parametro = CreateObjectSet<tb_unid_negocio_parametro>("tb_unid_negocio_parametro");
                return _tb_unid_negocio_parametro;
            }
        }
        private ObjectSet<tb_unid_negocio_parametro> _tb_unid_negocio_parametro;
        IObjectSet<tb_unid_negocio_parametro> IASAEntities.tb_unid_negocio_parametro { get { return tb_unid_negocio_parametro; } }

        public ObjectSet<tb_usuario> tb_usuario
        {
            get
            {
                if (_tb_usuario == null)
                    _tb_usuario = CreateObjectSet<tb_usuario>("tb_usuario");
                return _tb_usuario;
            }
        }
        private ObjectSet<tb_usuario> _tb_usuario;
        IObjectSet<tb_usuario> IASAEntities.tb_usuario { get { return tb_usuario; } }

        public ObjectSet<tb_usuario_bloqueio> tb_usuario_bloqueio
        {
            get
            {
                if (_tb_usuario_bloqueio == null)
                    _tb_usuario_bloqueio = CreateObjectSet<tb_usuario_bloqueio>("tb_usuario_bloqueio");
                return _tb_usuario_bloqueio;
            }
        }
        private ObjectSet<tb_usuario_bloqueio> _tb_usuario_bloqueio;
        IObjectSet<tb_usuario_bloqueio> IASAEntities.tb_usuario_bloqueio { get { return tb_usuario_bloqueio; } }

        public ObjectSet<tb_usuario_dpto> tb_usuario_dpto
        {
            get
            {
                if (_tb_usuario_dpto == null)
                    _tb_usuario_dpto = CreateObjectSet<tb_usuario_dpto>("tb_usuario_dpto");
                return _tb_usuario_dpto;
            }
        }
        private ObjectSet<tb_usuario_dpto> _tb_usuario_dpto;
        IObjectSet<tb_usuario_dpto> IASAEntities.tb_usuario_dpto { get { return tb_usuario_dpto; } }

        public ObjectSet<tb_usuario_funcao> tb_usuario_funcao
        {
            get
            {
                if (_tb_usuario_funcao == null)
                    _tb_usuario_funcao = CreateObjectSet<tb_usuario_funcao>("tb_usuario_funcao");
                return _tb_usuario_funcao;
            }
        }
        private ObjectSet<tb_usuario_funcao> _tb_usuario_funcao;
        IObjectSet<tb_usuario_funcao> IASAEntities.tb_usuario_funcao { get { return tb_usuario_funcao; } }

        public ObjectSet<tb_usuario_grupo> tb_usuario_grupo
        {
            get
            {
                if (_tb_usuario_grupo == null)
                    _tb_usuario_grupo = CreateObjectSet<tb_usuario_grupo>("tb_usuario_grupo");
                return _tb_usuario_grupo;
            }
        }
        private ObjectSet<tb_usuario_grupo> _tb_usuario_grupo;
        IObjectSet<tb_usuario_grupo> IASAEntities.tb_usuario_grupo { get { return tb_usuario_grupo; } }

        public ObjectSet<tb_venda> tb_venda
        {
            get
            {
                if (_tb_venda == null)
                    _tb_venda = CreateObjectSet<tb_venda>("tb_venda");
                return _tb_venda;
            }
        }
        private ObjectSet<tb_venda> _tb_venda;
        IObjectSet<tb_venda> IASAEntities.tb_venda { get { return tb_venda; } }

        public ObjectSet<tb_venda_dav> tb_venda_dav
        {
            get
            {
                if (_tb_venda_dav == null)
                    _tb_venda_dav = CreateObjectSet<tb_venda_dav>("tb_venda_dav");
                return _tb_venda_dav;
            }
        }
        private ObjectSet<tb_venda_dav> _tb_venda_dav;
        IObjectSet<tb_venda_dav> IASAEntities.tb_venda_dav { get { return tb_venda_dav; } }

        public ObjectSet<tb_venda_dav_item> tb_venda_dav_item
        {
            get
            {
                if (_tb_venda_dav_item == null)
                    _tb_venda_dav_item = CreateObjectSet<tb_venda_dav_item>("tb_venda_dav_item");
                return _tb_venda_dav_item;
            }
        }
        private ObjectSet<tb_venda_dav_item> _tb_venda_dav_item;
        IObjectSet<tb_venda_dav_item> IASAEntities.tb_venda_dav_item { get { return tb_venda_dav_item; } }

        public ObjectSet<tb_venda_estorno_tef> tb_venda_estorno_tef
        {
            get
            {
                if (_tb_venda_estorno_tef == null)
                    _tb_venda_estorno_tef = CreateObjectSet<tb_venda_estorno_tef>("tb_venda_estorno_tef");
                return _tb_venda_estorno_tef;
            }
        }
        private ObjectSet<tb_venda_estorno_tef> _tb_venda_estorno_tef;
        IObjectSet<tb_venda_estorno_tef> IASAEntities.tb_venda_estorno_tef { get { return tb_venda_estorno_tef; } }

        public ObjectSet<tb_venda_item> tb_venda_item
        {
            get
            {
                if (_tb_venda_item == null)
                    _tb_venda_item = CreateObjectSet<tb_venda_item>("tb_venda_item");
                return _tb_venda_item;
            }
        }
        private ObjectSet<tb_venda_item> _tb_venda_item;
        IObjectSet<tb_venda_item> IASAEntities.tb_venda_item { get { return tb_venda_item; } }

        public ObjectSet<tb_venda_pagamento> tb_venda_pagamento
        {
            get
            {
                if (_tb_venda_pagamento == null)
                    _tb_venda_pagamento = CreateObjectSet<tb_venda_pagamento>("tb_venda_pagamento");
                return _tb_venda_pagamento;
            }
        }
        private ObjectSet<tb_venda_pagamento> _tb_venda_pagamento;
        IObjectSet<tb_venda_pagamento> IASAEntities.tb_venda_pagamento { get { return tb_venda_pagamento; } }

        public ObjectSet<tb_venda_prevenda> tb_venda_prevenda
        {
            get
            {
                if (_tb_venda_prevenda == null)
                    _tb_venda_prevenda = CreateObjectSet<tb_venda_prevenda>("tb_venda_prevenda");
                return _tb_venda_prevenda;
            }
        }
        private ObjectSet<tb_venda_prevenda> _tb_venda_prevenda;
        IObjectSet<tb_venda_prevenda> IASAEntities.tb_venda_prevenda { get { return tb_venda_prevenda; } }

        public ObjectSet<tb_venda_prevenda_item> tb_venda_prevenda_item
        {
            get
            {
                if (_tb_venda_prevenda_item == null)
                    _tb_venda_prevenda_item = CreateObjectSet<tb_venda_prevenda_item>("tb_venda_prevenda_item");
                return _tb_venda_prevenda_item;
            }
        }
        private ObjectSet<tb_venda_prevenda_item> _tb_venda_prevenda_item;
        IObjectSet<tb_venda_prevenda_item> IASAEntities.tb_venda_prevenda_item { get { return tb_venda_prevenda_item; } }

        public ObjectSet<tb_venda_prevenda_pgto> tb_venda_prevenda_pgto
        {
            get
            {
                if (_tb_venda_prevenda_pgto == null)
                    _tb_venda_prevenda_pgto = CreateObjectSet<tb_venda_prevenda_pgto>("tb_venda_prevenda_pgto");
                return _tb_venda_prevenda_pgto;
            }
        }
        private ObjectSet<tb_venda_prevenda_pgto> _tb_venda_prevenda_pgto;
        IObjectSet<tb_venda_prevenda_pgto> IASAEntities.tb_venda_prevenda_pgto { get { return tb_venda_prevenda_pgto; } }

        public ObjectSet<tbManagerUpdate> tbManagerUpdates
        {
            get
            {
                if (_tbManagerUpdates == null)
                    _tbManagerUpdates = CreateObjectSet<tbManagerUpdate>("tbManagerUpdates");
                return _tbManagerUpdates;
            }
        }
        private ObjectSet<tbManagerUpdate> _tbManagerUpdates;
        IObjectSet<tbManagerUpdate> IASAEntities.tbManagerUpdates { get { return tbManagerUpdates; } }

        public ObjectSet<tbr_abcfarma_uf> tbr_abcfarma_uf
        {
            get
            {
                if (_tbr_abcfarma_uf == null)
                    _tbr_abcfarma_uf = CreateObjectSet<tbr_abcfarma_uf>("tbr_abcfarma_uf");
                return _tbr_abcfarma_uf;
            }
        }
        private ObjectSet<tbr_abcfarma_uf> _tbr_abcfarma_uf;
        IObjectSet<tbr_abcfarma_uf> IASAEntities.tbr_abcfarma_uf { get { return tbr_abcfarma_uf; } }

        public ObjectSet<tbr_convenio_cliente> tbr_convenio_cliente
        {
            get
            {
                if (_tbr_convenio_cliente == null)
                    _tbr_convenio_cliente = CreateObjectSet<tbr_convenio_cliente>("tbr_convenio_cliente");
                return _tbr_convenio_cliente;
            }
        }
        private ObjectSet<tbr_convenio_cliente> _tbr_convenio_cliente;
        IObjectSet<tbr_convenio_cliente> IASAEntities.tbr_convenio_cliente { get { return tbr_convenio_cliente; } }

        public ObjectSet<tbr_convenio_finalizadora_sub> tbr_convenio_finalizadora_sub
        {
            get
            {
                if (_tbr_convenio_finalizadora_sub == null)
                    _tbr_convenio_finalizadora_sub = CreateObjectSet<tbr_convenio_finalizadora_sub>("tbr_convenio_finalizadora_sub");
                return _tbr_convenio_finalizadora_sub;
            }
        }
        private ObjectSet<tbr_convenio_finalizadora_sub> _tbr_convenio_finalizadora_sub;
        IObjectSet<tbr_convenio_finalizadora_sub> IASAEntities.tbr_convenio_finalizadora_sub { get { return tbr_convenio_finalizadora_sub; } }

        public ObjectSet<tbr_convenio_un> tbr_convenio_un
        {
            get
            {
                if (_tbr_convenio_un == null)
                    _tbr_convenio_un = CreateObjectSet<tbr_convenio_un>("tbr_convenio_un");
                return _tbr_convenio_un;
            }
        }
        private ObjectSet<tbr_convenio_un> _tbr_convenio_un;
        IObjectSet<tbr_convenio_un> IASAEntities.tbr_convenio_un { get { return tbr_convenio_un; } }

        public ObjectSet<tbr_dicionario_produto> tbr_dicionario_produto
        {
            get
            {
                if (_tbr_dicionario_produto == null)
                    _tbr_dicionario_produto = CreateObjectSet<tbr_dicionario_produto>("tbr_dicionario_produto");
                return _tbr_dicionario_produto;
            }
        }
        private ObjectSet<tbr_dicionario_produto> _tbr_dicionario_produto;
        IObjectSet<tbr_dicionario_produto> IASAEntities.tbr_dicionario_produto { get { return tbr_dicionario_produto; } }

        public ObjectSet<tbr_dicionario_un> tbr_dicionario_un
        {
            get
            {
                if (_tbr_dicionario_un == null)
                    _tbr_dicionario_un = CreateObjectSet<tbr_dicionario_un>("tbr_dicionario_un");
                return _tbr_dicionario_un;
            }
        }
        private ObjectSet<tbr_dicionario_un> _tbr_dicionario_un;
        IObjectSet<tbr_dicionario_un> IASAEntities.tbr_dicionario_un { get { return tbr_dicionario_un; } }

        public ObjectSet<tbr_dpto_aplicativo> tbr_dpto_aplicativo
        {
            get
            {
                if (_tbr_dpto_aplicativo == null)
                    _tbr_dpto_aplicativo = CreateObjectSet<tbr_dpto_aplicativo>("tbr_dpto_aplicativo");
                return _tbr_dpto_aplicativo;
            }
        }
        private ObjectSet<tbr_dpto_aplicativo> _tbr_dpto_aplicativo;
        IObjectSet<tbr_dpto_aplicativo> IASAEntities.tbr_dpto_aplicativo { get { return tbr_dpto_aplicativo; } }

        public ObjectSet<tbr_ecf_finalizadora> tbr_ecf_finalizadora
        {
            get
            {
                if (_tbr_ecf_finalizadora == null)
                    _tbr_ecf_finalizadora = CreateObjectSet<tbr_ecf_finalizadora>("tbr_ecf_finalizadora");
                return _tbr_ecf_finalizadora;
            }
        }
        private ObjectSet<tbr_ecf_finalizadora> _tbr_ecf_finalizadora;
        IObjectSet<tbr_ecf_finalizadora> IASAEntities.tbr_ecf_finalizadora { get { return tbr_ecf_finalizadora; } }

        public ObjectSet<tbr_ecf_tributacao> tbr_ecf_tributacao
        {
            get
            {
                if (_tbr_ecf_tributacao == null)
                    _tbr_ecf_tributacao = CreateObjectSet<tbr_ecf_tributacao>("tbr_ecf_tributacao");
                return _tbr_ecf_tributacao;
            }
        }
        private ObjectSet<tbr_ecf_tributacao> _tbr_ecf_tributacao;
        IObjectSet<tbr_ecf_tributacao> IASAEntities.tbr_ecf_tributacao { get { return tbr_ecf_tributacao; } }

        public ObjectSet<tbr_finalizadora_sub_un> tbr_finalizadora_sub_un
        {
            get
            {
                if (_tbr_finalizadora_sub_un == null)
                    _tbr_finalizadora_sub_un = CreateObjectSet<tbr_finalizadora_sub_un>("tbr_finalizadora_sub_un");
                return _tbr_finalizadora_sub_un;
            }
        }
        private ObjectSet<tbr_finalizadora_sub_un> _tbr_finalizadora_sub_un;
        IObjectSet<tbr_finalizadora_sub_un> IASAEntities.tbr_finalizadora_sub_un { get { return tbr_finalizadora_sub_un; } }

        public ObjectSet<tbr_finalizadora_un> tbr_finalizadora_un
        {
            get
            {
                if (_tbr_finalizadora_un == null)
                    _tbr_finalizadora_un = CreateObjectSet<tbr_finalizadora_un>("tbr_finalizadora_un");
                return _tbr_finalizadora_un;
            }
        }
        private ObjectSet<tbr_finalizadora_un> _tbr_finalizadora_un;
        IObjectSet<tbr_finalizadora_un> IASAEntities.tbr_finalizadora_un { get { return tbr_finalizadora_un; } }

        public ObjectSet<tbr_mvto_compra_cfop____> tbr_mvto_compra_cfop____
        {
            get
            {
                if (_tbr_mvto_compra_cfop____ == null)
                    _tbr_mvto_compra_cfop____ = CreateObjectSet<tbr_mvto_compra_cfop____>("tbr_mvto_compra_cfop____");
                return _tbr_mvto_compra_cfop____;
            }
        }
        private ObjectSet<tbr_mvto_compra_cfop____> _tbr_mvto_compra_cfop____;
        IObjectSet<tbr_mvto_compra_cfop____> IASAEntities.tbr_mvto_compra_cfop____ { get { return tbr_mvto_compra_cfop____; } }

        public ObjectSet<tbr_mvto_compra_dup____> tbr_mvto_compra_dup____
        {
            get
            {
                if (_tbr_mvto_compra_dup____ == null)
                    _tbr_mvto_compra_dup____ = CreateObjectSet<tbr_mvto_compra_dup____>("tbr_mvto_compra_dup____");
                return _tbr_mvto_compra_dup____;
            }
        }
        private ObjectSet<tbr_mvto_compra_dup____> _tbr_mvto_compra_dup____;
        IObjectSet<tbr_mvto_compra_dup____> IASAEntities.tbr_mvto_compra_dup____ { get { return tbr_mvto_compra_dup____; } }

        public ObjectSet<tbr_parametro_descprod_uneg> tbr_parametro_descprod_uneg
        {
            get
            {
                if (_tbr_parametro_descprod_uneg == null)
                    _tbr_parametro_descprod_uneg = CreateObjectSet<tbr_parametro_descprod_uneg>("tbr_parametro_descprod_uneg");
                return _tbr_parametro_descprod_uneg;
            }
        }
        private ObjectSet<tbr_parametro_descprod_uneg> _tbr_parametro_descprod_uneg;
        IObjectSet<tbr_parametro_descprod_uneg> IASAEntities.tbr_parametro_descprod_uneg { get { return tbr_parametro_descprod_uneg; } }

        public ObjectSet<tbr_parametro_descvend_uneg> tbr_parametro_descvend_uneg
        {
            get
            {
                if (_tbr_parametro_descvend_uneg == null)
                    _tbr_parametro_descvend_uneg = CreateObjectSet<tbr_parametro_descvend_uneg>("tbr_parametro_descvend_uneg");
                return _tbr_parametro_descvend_uneg;
            }
        }
        private ObjectSet<tbr_parametro_descvend_uneg> _tbr_parametro_descvend_uneg;
        IObjectSet<tbr_parametro_descvend_uneg> IASAEntities.tbr_parametro_descvend_uneg { get { return tbr_parametro_descvend_uneg; } }

        public ObjectSet<tbr_parametro_markup_uneg> tbr_parametro_markup_uneg
        {
            get
            {
                if (_tbr_parametro_markup_uneg == null)
                    _tbr_parametro_markup_uneg = CreateObjectSet<tbr_parametro_markup_uneg>("tbr_parametro_markup_uneg");
                return _tbr_parametro_markup_uneg;
            }
        }
        private ObjectSet<tbr_parametro_markup_uneg> _tbr_parametro_markup_uneg;
        IObjectSet<tbr_parametro_markup_uneg> IASAEntities.tbr_parametro_markup_uneg { get { return tbr_parametro_markup_uneg; } }

        public ObjectSet<tbr_produto_estoque_dia> tbr_produto_estoque_dia
        {
            get
            {
                if (_tbr_produto_estoque_dia == null)
                    _tbr_produto_estoque_dia = CreateObjectSet<tbr_produto_estoque_dia>("tbr_produto_estoque_dia");
                return _tbr_produto_estoque_dia;
            }
        }
        private ObjectSet<tbr_produto_estoque_dia> _tbr_produto_estoque_dia;
        IObjectSet<tbr_produto_estoque_dia> IASAEntities.tbr_produto_estoque_dia { get { return tbr_produto_estoque_dia; } }

        public ObjectSet<tbr_produto_estoque_lote> tbr_produto_estoque_lote
        {
            get
            {
                if (_tbr_produto_estoque_lote == null)
                    _tbr_produto_estoque_lote = CreateObjectSet<tbr_produto_estoque_lote>("tbr_produto_estoque_lote");
                return _tbr_produto_estoque_lote;
            }
        }
        private ObjectSet<tbr_produto_estoque_lote> _tbr_produto_estoque_lote;
        IObjectSet<tbr_produto_estoque_lote> IASAEntities.tbr_produto_estoque_lote { get { return tbr_produto_estoque_lote; } }

        public ObjectSet<tbr_produto_tributacao> tbr_produto_tributacao
        {
            get
            {
                if (_tbr_produto_tributacao == null)
                    _tbr_produto_tributacao = CreateObjectSet<tbr_produto_tributacao>("tbr_produto_tributacao");
                return _tbr_produto_tributacao;
            }
        }
        private ObjectSet<tbr_produto_tributacao> _tbr_produto_tributacao;
        IObjectSet<tbr_produto_tributacao> IASAEntities.tbr_produto_tributacao { get { return tbr_produto_tributacao; } }

        public ObjectSet<tbr_produto_uneg> tbr_produto_uneg
        {
            get
            {
                if (_tbr_produto_uneg == null)
                    _tbr_produto_uneg = CreateObjectSet<tbr_produto_uneg>("tbr_produto_uneg");
                return _tbr_produto_uneg;
            }
        }
        private ObjectSet<tbr_produto_uneg> _tbr_produto_uneg;
        IObjectSet<tbr_produto_uneg> IASAEntities.tbr_produto_uneg { get { return tbr_produto_uneg; } }

        public ObjectSet<tbr_promocao_produto> tbr_promocao_produto
        {
            get
            {
                if (_tbr_promocao_produto == null)
                    _tbr_promocao_produto = CreateObjectSet<tbr_promocao_produto>("tbr_promocao_produto");
                return _tbr_promocao_produto;
            }
        }
        private ObjectSet<tbr_promocao_produto> _tbr_promocao_produto;
        IObjectSet<tbr_promocao_produto> IASAEntities.tbr_promocao_produto { get { return tbr_promocao_produto; } }

        #endregion

        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_abcfarma EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_abcfarma(tb_abcfarma tb_abcfarma)
        {
            base.AddObject("tb_abcfarma", tb_abcfarma);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_abcfarma_periodo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_abcfarma_periodo(tb_abcfarma_periodo tb_abcfarma_periodo)
        {
            base.AddObject("tb_abcfarma_periodo", tb_abcfarma_periodo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_abertura_caixa EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_abertura_caixa(tb_abertura_caixa tb_abertura_caixa)
        {
            base.AddObject("tb_abertura_caixa", tb_abertura_caixa);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_agenda_produto EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_agenda_produto(tb_agenda_produto tb_agenda_produto)
        {
            base.AddObject("tb_agenda_produto", tb_agenda_produto);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_banco EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_banco(tb_banco tb_banco)
        {
            base.AddObject("tb_banco", tb_banco);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_cadastro_contador EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_cadastro_contador(tb_cadastro_contador tb_cadastro_contador)
        {
            base.AddObject("tb_cadastro_contador", tb_cadastro_contador);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_cargo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_cargo(tb_cargo tb_cargo)
        {
            base.AddObject("tb_cargo", tb_cargo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_ceps EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_ceps(tb_ceps tb_ceps)
        {
            base.AddObject("tb_ceps", tb_ceps);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_cfop EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_cfop(tb_cfop tb_cfop)
        {
            base.AddObject("tb_cfop", tb_cfop);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_checkin EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_checkin(tb_checkin tb_checkin)
        {
            base.AddObject("tb_checkin", tb_checkin);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_checkin_item EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_checkin_item(tb_checkin_item tb_checkin_item)
        {
            base.AddObject("tb_checkin_item", tb_checkin_item);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_checkin_item_tmp EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_checkin_item_tmp(tb_checkin_item_tmp tb_checkin_item_tmp)
        {
            base.AddObject("tb_checkin_item_tmp", tb_checkin_item_tmp);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_checkin_tmp EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_checkin_tmp(tb_checkin_tmp tb_checkin_tmp)
        {
            base.AddObject("tb_checkin_tmp", tb_checkin_tmp);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_checkout EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_checkout(tb_checkout tb_checkout)
        {
            base.AddObject("tb_checkout", tb_checkout);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_checkout_item EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_checkout_item(tb_checkout_item tb_checkout_item)
        {
            base.AddObject("tb_checkout_item", tb_checkout_item);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_cliente EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_cliente(tb_cliente tb_cliente)
        {
            base.AddObject("tb_cliente", tb_cliente);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_cliente_anvisa EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_cliente_anvisa(tb_cliente_anvisa tb_cliente_anvisa)
        {
            base.AddObject("tb_cliente_anvisa", tb_cliente_anvisa);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_cliente_bloqueio EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_cliente_bloqueio(tb_cliente_bloqueio tb_cliente_bloqueio)
        {
            base.AddObject("tb_cliente_bloqueio", tb_cliente_bloqueio);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_cliente_endereco EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_cliente_endereco(tb_cliente_endereco tb_cliente_endereco)
        {
            base.AddObject("tb_cliente_endereco", tb_cliente_endereco);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_cliente_fiscal EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_cliente_fiscal(tb_cliente_fiscal tb_cliente_fiscal)
        {
            base.AddObject("tb_cliente_fiscal", tb_cliente_fiscal);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_cliente_telefone EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_cliente_telefone(tb_cliente_telefone tb_cliente_telefone)
        {
            base.AddObject("tb_cliente_telefone", tb_cliente_telefone);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_conselho EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_conselho(tb_conselho tb_conselho)
        {
            base.AddObject("tb_conselho", tb_conselho);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_conselho_regional EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_conselho_regional(tb_conselho_regional tb_conselho_regional)
        {
            base.AddObject("tb_conselho_regional", tb_conselho_regional);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_conta EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_conta(tb_conta tb_conta)
        {
            base.AddObject("tb_conta", tb_conta);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_convenio EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_convenio(tb_convenio tb_convenio)
        {
            base.AddObject("tb_convenio", tb_convenio);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_crediario EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_crediario(tb_crediario tb_crediario)
        {
            base.AddObject("tb_crediario", tb_crediario);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_crediario_finalizadora EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_crediario_finalizadora(tb_crediario_finalizadora tb_crediario_finalizadora)
        {
            base.AddObject("tb_crediario_finalizadora", tb_crediario_finalizadora);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_crm EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_crm(tb_crm tb_crm)
        {
            base.AddObject("tb_crm", tb_crm);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_crm_endereco EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_crm_endereco(tb_crm_endereco tb_crm_endereco)
        {
            base.AddObject("tb_crm_endereco", tb_crm_endereco);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_crm_especialidade EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_crm_especialidade(tb_crm_especialidade tb_crm_especialidade)
        {
            base.AddObject("tb_crm_especialidade", tb_crm_especialidade);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_dav EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_dav(tb_dav tb_dav)
        {
            base.AddObject("tb_dav", tb_dav);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_dav_itens____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_dav_itens____(tb_dav_itens____ tb_dav_itens____)
        {
            base.AddObject("tb_dav_itens____", tb_dav_itens____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_ecf EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_ecf(tb_ecf tb_ecf)
        {
            base.AddObject("tb_ecf", tb_ecf);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_ecf_dd EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_ecf_dd(tb_ecf_dd tb_ecf_dd)
        {
            base.AddObject("tb_ecf_dd", tb_ecf_dd);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_ecf_modelo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_ecf_modelo(tb_ecf_modelo tb_ecf_modelo)
        {
            base.AddObject("tb_ecf_modelo", tb_ecf_modelo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_empresa_privatelabel EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_empresa_privatelabel(tb_empresa_privatelabel tb_empresa_privatelabel)
        {
            base.AddObject("tb_empresa_privatelabel", tb_empresa_privatelabel);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_empresa_recarga EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_empresa_recarga(tb_empresa_recarga tb_empresa_recarga)
        {
            base.AddObject("tb_empresa_recarga", tb_empresa_recarga);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_entrega_arearisco EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_entrega_arearisco(tb_entrega_arearisco tb_entrega_arearisco)
        {
            base.AddObject("tb_entrega_arearisco", tb_entrega_arearisco);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_entrega_endereco EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_entrega_endereco(tb_entrega_endereco tb_entrega_endereco)
        {
            base.AddObject("tb_entrega_endereco", tb_entrega_endereco);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_entrega_polo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_entrega_polo(tb_entrega_polo tb_entrega_polo)
        {
            base.AddObject("tb_entrega_polo", tb_entrega_polo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_entrega_polo_bairro EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_entrega_polo_bairro(tb_entrega_polo_bairro tb_entrega_polo_bairro)
        {
            base.AddObject("tb_entrega_polo_bairro", tb_entrega_polo_bairro);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_entrega_prod_continuo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_entrega_prod_continuo(tb_entrega_prod_continuo tb_entrega_prod_continuo)
        {
            base.AddObject("tb_entrega_prod_continuo", tb_entrega_prod_continuo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_entrega_quadrante EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_entrega_quadrante(tb_entrega_quadrante tb_entrega_quadrante)
        {
            base.AddObject("tb_entrega_quadrante", tb_entrega_quadrante);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_entrega_rota EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_entrega_rota(tb_entrega_rota tb_entrega_rota)
        {
            base.AddObject("tb_entrega_rota", tb_entrega_rota);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_entrega_rota_cep EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_entrega_rota_cep(tb_entrega_rota_cep tb_entrega_rota_cep)
        {
            base.AddObject("tb_entrega_rota_cep", tb_entrega_rota_cep);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_finalizadora EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_finalizadora(tb_finalizadora tb_finalizadora)
        {
            base.AddObject("tb_finalizadora", tb_finalizadora);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_finalizadora_sub EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_finalizadora_sub(tb_finalizadora_sub tb_finalizadora_sub)
        {
            base.AddObject("tb_finalizadora_sub", tb_finalizadora_sub);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_financeiro_administradora EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_financeiro_administradora(tb_financeiro_administradora tb_financeiro_administradora)
        {
            base.AddObject("tb_financeiro_administradora", tb_financeiro_administradora);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_financeiro_bancos EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_financeiro_bancos(tb_financeiro_bancos tb_financeiro_bancos)
        {
            base.AddObject("tb_financeiro_bancos", tb_financeiro_bancos);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_financeiro_evento EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_financeiro_evento(tb_financeiro_evento tb_financeiro_evento)
        {
            base.AddObject("tb_financeiro_evento", tb_financeiro_evento);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_financeiro_prazo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_financeiro_prazo(tb_financeiro_prazo tb_financeiro_prazo)
        {
            base.AddObject("tb_financeiro_prazo", tb_financeiro_prazo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_financeiro_sangria EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_financeiro_sangria(tb_financeiro_sangria tb_financeiro_sangria)
        {
            base.AddObject("tb_financeiro_sangria", tb_financeiro_sangria);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_financeiro_suprimento EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_financeiro_suprimento(tb_financeiro_suprimento tb_financeiro_suprimento)
        {
            base.AddObject("tb_financeiro_suprimento", tb_financeiro_suprimento);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_fornecedor EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_fornecedor(tb_fornecedor tb_fornecedor)
        {
            base.AddObject("tb_fornecedor", tb_fornecedor);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_fornecedor_divisao EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_fornecedor_divisao(tb_fornecedor_divisao tb_fornecedor_divisao)
        {
            base.AddObject("tb_fornecedor_divisao", tb_fornecedor_divisao);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_funcionario EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_funcionario(tb_funcionario tb_funcionario)
        {
            base.AddObject("tb_funcionario", tb_funcionario);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_funcionario_horario EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_funcionario_horario(tb_funcionario_horario tb_funcionario_horario)
        {
            base.AddObject("tb_funcionario_horario", tb_funcionario_horario);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_funcionario_horario_item EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_funcionario_horario_item(tb_funcionario_horario_item tb_funcionario_horario_item)
        {
            base.AddObject("tb_funcionario_horario_item", tb_funcionario_horario_item);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_funcionario_visitante EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_funcionario_visitante(tb_funcionario_visitante tb_funcionario_visitante)
        {
            base.AddObject("tb_funcionario_visitante", tb_funcionario_visitante);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_hist_sangria____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_hist_sangria____(tb_hist_sangria____ tb_hist_sangria____)
        {
            base.AddObject("tb_hist_sangria____", tb_hist_sangria____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_ibge EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_ibge(tb_ibge tb_ibge)
        {
            base.AddObject("tb_ibge", tb_ibge);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_ibpt_ax EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_ibpt_ax(tb_ibpt_ax tb_ibpt_ax)
        {
            base.AddObject("tb_ibpt_ax", tb_ibpt_ax);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_lancto_financeiro EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_lancto_financeiro(tb_lancto_financeiro tb_lancto_financeiro)
        {
            base.AddObject("tb_lancto_financeiro", tb_lancto_financeiro);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_liquidacao_forma EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_liquidacao_forma(tb_liquidacao_forma tb_liquidacao_forma)
        {
            base.AddObject("tb_liquidacao_forma", tb_liquidacao_forma);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_liquidacao_motivo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_liquidacao_motivo(tb_liquidacao_motivo tb_liquidacao_motivo)
        {
            base.AddObject("tb_liquidacao_motivo", tb_liquidacao_motivo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_mvto_compra____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_mvto_compra____(tb_mvto_compra____ tb_mvto_compra____)
        {
            base.AddObject("tb_mvto_compra____", tb_mvto_compra____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_mvto_compra_dup____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_mvto_compra_dup____(tb_mvto_compra_dup____ tb_mvto_compra_dup____)
        {
            base.AddObject("tb_mvto_compra_dup____", tb_mvto_compra_dup____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_mvto_compra_item____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_mvto_compra_item____(tb_mvto_compra_item____ tb_mvto_compra_item____)
        {
            base.AddObject("tb_mvto_compra_item____", tb_mvto_compra_item____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_mvto_compra_item_divergencia____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_mvto_compra_item_divergencia____(tb_mvto_compra_item_divergencia____ tb_mvto_compra_item_divergencia____)
        {
            base.AddObject("tb_mvto_compra_item_divergencia____", tb_mvto_compra_item_divergencia____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_mvto_compra_item_lote____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_mvto_compra_item_lote____(tb_mvto_compra_item_lote____ tb_mvto_compra_item_lote____)
        {
            base.AddObject("tb_mvto_compra_item_lote____", tb_mvto_compra_item_lote____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_mvto_fin____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_mvto_fin____(tb_mvto_fin____ tb_mvto_fin____)
        {
            base.AddObject("tb_mvto_fin____", tb_mvto_fin____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_nfe EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_nfe(tb_nfe tb_nfe)
        {
            base.AddObject("tb_nfe", tb_nfe);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_nfe_cfop EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_nfe_cfop(tb_nfe_cfop tb_nfe_cfop)
        {
            base.AddObject("tb_nfe_cfop", tb_nfe_cfop);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_nfe_danfe EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_nfe_danfe(tb_nfe_danfe tb_nfe_danfe)
        {
            base.AddObject("tb_nfe_danfe", tb_nfe_danfe);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_nfe_finalizadora EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_nfe_finalizadora(tb_nfe_finalizadora tb_nfe_finalizadora)
        {
            base.AddObject("tb_nfe_finalizadora", tb_nfe_finalizadora);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_nfe_item EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_nfe_item(tb_nfe_item tb_nfe_item)
        {
            base.AddObject("tb_nfe_item", tb_nfe_item);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_paciente_anvisa EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_paciente_anvisa(tb_paciente_anvisa tb_paciente_anvisa)
        {
            base.AddObject("tb_paciente_anvisa", tb_paciente_anvisa);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_paf_numero EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_paf_numero(tb_paf_numero tb_paf_numero)
        {
            base.AddObject("tb_paf_numero", tb_paf_numero);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_parametro EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_parametro(tb_parametro tb_parametro)
        {
            base.AddObject("tb_parametro", tb_parametro);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_parametro_comissao EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_parametro_comissao(tb_parametro_comissao tb_parametro_comissao)
        {
            base.AddObject("tb_parametro_comissao", tb_parametro_comissao);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_parametro_descconv EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_parametro_descconv(tb_parametro_descconv tb_parametro_descconv)
        {
            base.AddObject("tb_parametro_descconv", tb_parametro_descconv);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_parametro_descmax EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_parametro_descmax(tb_parametro_descmax tb_parametro_descmax)
        {
            base.AddObject("tb_parametro_descmax", tb_parametro_descmax);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_parametro_descprod EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_parametro_descprod(tb_parametro_descprod tb_parametro_descprod)
        {
            base.AddObject("tb_parametro_descprod", tb_parametro_descprod);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_parametro_descvend EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_parametro_descvend(tb_parametro_descvend tb_parametro_descvend)
        {
            base.AddObject("tb_parametro_descvend", tb_parametro_descvend);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_parametro_limpezas EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_parametro_limpezas(tb_parametro_limpezas tb_parametro_limpezas)
        {
            base.AddObject("tb_parametro_limpezas", tb_parametro_limpezas);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_parametro_markup EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_parametro_markup(tb_parametro_markup tb_parametro_markup)
        {
            base.AddObject("tb_parametro_markup", tb_parametro_markup);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_pbm EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_pbm(tb_pbm tb_pbm)
        {
            base.AddObject("tb_pbm", tb_pbm);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_pedido_compra____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_pedido_compra____(tb_pedido_compra____ tb_pedido_compra____)
        {
            base.AddObject("tb_pedido_compra____", tb_pedido_compra____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_pedido_compra_item____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_pedido_compra_item____(tb_pedido_compra_item____ tb_pedido_compra_item____)
        {
            base.AddObject("tb_pedido_compra_item____", tb_pedido_compra_item____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_piscofins EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_piscofins(tb_piscofins tb_piscofins)
        {
            base.AddObject("tb_piscofins", tb_piscofins);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_ponto EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_ponto(tb_ponto tb_ponto)
        {
            base.AddObject("tb_ponto", tb_ponto);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_ponto_motivo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_ponto_motivo(tb_ponto_motivo tb_ponto_motivo)
        {
            base.AddObject("tb_ponto_motivo", tb_ponto_motivo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_princ_ativo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_princ_ativo(tb_princ_ativo tb_princ_ativo)
        {
            base.AddObject("tb_princ_ativo", tb_princ_ativo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_privatelabel EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_privatelabel(tb_privatelabel tb_privatelabel)
        {
            base.AddObject("tb_privatelabel", tb_privatelabel);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_privatelabel_finalizadora EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_privatelabel_finalizadora(tb_privatelabel_finalizadora tb_privatelabel_finalizadora)
        {
            base.AddObject("tb_privatelabel_finalizadora", tb_privatelabel_finalizadora);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto(tb_produto tb_produto)
        {
            base.AddObject("tb_produto", tb_produto);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_barra EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_barra(tb_produto_barra tb_produto_barra)
        {
            base.AddObject("tb_produto_barra", tb_produto_barra);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_classe EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_classe(tb_produto_classe tb_produto_classe)
        {
            base.AddObject("tb_produto_classe", tb_produto_classe);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_fam_categ_sub EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_fam_categ_sub(tb_produto_fam_categ_sub tb_produto_fam_categ_sub)
        {
            base.AddObject("tb_produto_fam_categ_sub", tb_produto_fam_categ_sub);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_fam_categoria EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_fam_categoria(tb_produto_fam_categoria tb_produto_fam_categoria)
        {
            base.AddObject("tb_produto_fam_categoria", tb_produto_fam_categoria);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_fam_grupo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_fam_grupo(tb_produto_fam_grupo tb_produto_fam_grupo)
        {
            base.AddObject("tb_produto_fam_grupo", tb_produto_fam_grupo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_familia EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_familia(tb_produto_familia tb_produto_familia)
        {
            base.AddObject("tb_produto_familia", tb_produto_familia);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_kit EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_kit(tb_produto_kit tb_produto_kit)
        {
            base.AddObject("tb_produto_kit", tb_produto_kit);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_linha EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_linha(tb_produto_linha tb_produto_linha)
        {
            base.AddObject("tb_produto_linha", tb_produto_linha);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_piscofins EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_piscofins(tb_produto_piscofins tb_produto_piscofins)
        {
            base.AddObject("tb_produto_piscofins", tb_produto_piscofins);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_princativo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_princativo(tb_produto_princativo tb_produto_princativo)
        {
            base.AddObject("tb_produto_princativo", tb_produto_princativo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_receituario EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_receituario(tb_produto_receituario tb_produto_receituario)
        {
            base.AddObject("tb_produto_receituario", tb_produto_receituario);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_produto_similaridade EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_produto_similaridade(tb_produto_similaridade tb_produto_similaridade)
        {
            base.AddObject("tb_produto_similaridade", tb_produto_similaridade);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_promocao EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_promocao(tb_promocao tb_promocao)
        {
            base.AddObject("tb_promocao", tb_promocao);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_promocao_tipo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_promocao_tipo(tb_promocao_tipo tb_promocao_tipo)
        {
            base.AddObject("tb_promocao_tipo", tb_promocao_tipo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_recarga EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_recarga(tb_recarga tb_recarga)
        {
            base.AddObject("tb_recarga", tb_recarga);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_recarga_finalizadora EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_recarga_finalizadora(tb_recarga_finalizadora tb_recarga_finalizadora)
        {
            base.AddObject("tb_recarga_finalizadora", tb_recarga_finalizadora);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_reducao_z EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_reducao_z(tb_reducao_z tb_reducao_z)
        {
            base.AddObject("tb_reducao_z", tb_reducao_z);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_reducao_z_itens EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_reducao_z_itens(tb_reducao_z_itens tb_reducao_z_itens)
        {
            base.AddObject("tb_reducao_z_itens", tb_reducao_z_itens);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_sangrias EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_sangrias(tb_sangrias tb_sangrias)
        {
            base.AddObject("tb_sangrias", tb_sangrias);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_serie_nota EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_serie_nota(tb_serie_nota tb_serie_nota)
        {
            base.AddObject("tb_serie_nota", tb_serie_nota);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_sincronizacao EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_sincronizacao(tb_sincronizacao tb_sincronizacao)
        {
            base.AddObject("tb_sincronizacao", tb_sincronizacao);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_suprimentos EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_suprimentos(tb_suprimentos tb_suprimentos)
        {
            base.AddObject("tb_suprimentos", tb_suprimentos);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_terminal EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_terminal(tb_terminal tb_terminal)
        {
            base.AddObject("tb_terminal", tb_terminal);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_terminal_mobile EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_terminal_mobile(tb_terminal_mobile tb_terminal_mobile)
        {
            base.AddObject("tb_terminal_mobile", tb_terminal_mobile);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_tipo_logradouro EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_tipo_logradouro(tb_tipo_logradouro tb_tipo_logradouro)
        {
            base.AddObject("tb_tipo_logradouro", tb_tipo_logradouro);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_tipo_mvto_produto EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_tipo_mvto_produto(tb_tipo_mvto_produto tb_tipo_mvto_produto)
        {
            base.AddObject("tb_tipo_mvto_produto", tb_tipo_mvto_produto);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_tipo_nota EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_tipo_nota(tb_tipo_nota tb_tipo_nota)
        {
            base.AddObject("tb_tipo_nota", tb_tipo_nota);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_transportadora EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_transportadora(tb_transportadora tb_transportadora)
        {
            base.AddObject("tb_transportadora", tb_transportadora);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_tributacao EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_tributacao(tb_tributacao tb_tributacao)
        {
            base.AddObject("tb_tributacao", tb_tributacao);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_uf EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_uf(tb_uf tb_uf)
        {
            base.AddObject("tb_uf", tb_uf);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_unid_negocio EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_unid_negocio(tb_unid_negocio tb_unid_negocio)
        {
            base.AddObject("tb_unid_negocio", tb_unid_negocio);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_unid_negocio_grupo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_unid_negocio_grupo(tb_unid_negocio_grupo tb_unid_negocio_grupo)
        {
            base.AddObject("tb_unid_negocio_grupo", tb_unid_negocio_grupo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_unid_negocio_parametro EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_unid_negocio_parametro(tb_unid_negocio_parametro tb_unid_negocio_parametro)
        {
            base.AddObject("tb_unid_negocio_parametro", tb_unid_negocio_parametro);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_usuario EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_usuario(tb_usuario tb_usuario)
        {
            base.AddObject("tb_usuario", tb_usuario);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_usuario_bloqueio EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_usuario_bloqueio(tb_usuario_bloqueio tb_usuario_bloqueio)
        {
            base.AddObject("tb_usuario_bloqueio", tb_usuario_bloqueio);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_usuario_dpto EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_usuario_dpto(tb_usuario_dpto tb_usuario_dpto)
        {
            base.AddObject("tb_usuario_dpto", tb_usuario_dpto);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_usuario_funcao EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_usuario_funcao(tb_usuario_funcao tb_usuario_funcao)
        {
            base.AddObject("tb_usuario_funcao", tb_usuario_funcao);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_usuario_grupo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_usuario_grupo(tb_usuario_grupo tb_usuario_grupo)
        {
            base.AddObject("tb_usuario_grupo", tb_usuario_grupo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_venda EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_venda(tb_venda tb_venda)
        {
            base.AddObject("tb_venda", tb_venda);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_venda_dav EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_venda_dav(tb_venda_dav tb_venda_dav)
        {
            base.AddObject("tb_venda_dav", tb_venda_dav);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_venda_dav_item EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_venda_dav_item(tb_venda_dav_item tb_venda_dav_item)
        {
            base.AddObject("tb_venda_dav_item", tb_venda_dav_item);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_venda_estorno_tef EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_venda_estorno_tef(tb_venda_estorno_tef tb_venda_estorno_tef)
        {
            base.AddObject("tb_venda_estorno_tef", tb_venda_estorno_tef);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_venda_item EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_venda_item(tb_venda_item tb_venda_item)
        {
            base.AddObject("tb_venda_item", tb_venda_item);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_venda_pagamento EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_venda_pagamento(tb_venda_pagamento tb_venda_pagamento)
        {
            base.AddObject("tb_venda_pagamento", tb_venda_pagamento);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_venda_prevenda EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_venda_prevenda(tb_venda_prevenda tb_venda_prevenda)
        {
            base.AddObject("tb_venda_prevenda", tb_venda_prevenda);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_venda_prevenda_item EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_venda_prevenda_item(tb_venda_prevenda_item tb_venda_prevenda_item)
        {
            base.AddObject("tb_venda_prevenda_item", tb_venda_prevenda_item);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tb_venda_prevenda_pgto EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_venda_prevenda_pgto(tb_venda_prevenda_pgto tb_venda_prevenda_pgto)
        {
            base.AddObject("tb_venda_prevenda_pgto", tb_venda_prevenda_pgto);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbManagerUpdates EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbManagerUpdates(tbManagerUpdate tbManagerUpdate)
        {
            base.AddObject("tbManagerUpdates", tbManagerUpdate);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_abcfarma_uf EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_abcfarma_uf(tbr_abcfarma_uf tbr_abcfarma_uf)
        {
            base.AddObject("tbr_abcfarma_uf", tbr_abcfarma_uf);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_convenio_cliente EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_convenio_cliente(tbr_convenio_cliente tbr_convenio_cliente)
        {
            base.AddObject("tbr_convenio_cliente", tbr_convenio_cliente);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_convenio_finalizadora_sub EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_convenio_finalizadora_sub(tbr_convenio_finalizadora_sub tbr_convenio_finalizadora_sub)
        {
            base.AddObject("tbr_convenio_finalizadora_sub", tbr_convenio_finalizadora_sub);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_convenio_un EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_convenio_un(tbr_convenio_un tbr_convenio_un)
        {
            base.AddObject("tbr_convenio_un", tbr_convenio_un);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_dicionario_produto EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_dicionario_produto(tbr_dicionario_produto tbr_dicionario_produto)
        {
            base.AddObject("tbr_dicionario_produto", tbr_dicionario_produto);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_dicionario_un EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_dicionario_un(tbr_dicionario_un tbr_dicionario_un)
        {
            base.AddObject("tbr_dicionario_un", tbr_dicionario_un);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_dpto_aplicativo EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_dpto_aplicativo(tbr_dpto_aplicativo tbr_dpto_aplicativo)
        {
            base.AddObject("tbr_dpto_aplicativo", tbr_dpto_aplicativo);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_ecf_finalizadora EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_ecf_finalizadora(tbr_ecf_finalizadora tbr_ecf_finalizadora)
        {
            base.AddObject("tbr_ecf_finalizadora", tbr_ecf_finalizadora);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_ecf_tributacao EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_ecf_tributacao(tbr_ecf_tributacao tbr_ecf_tributacao)
        {
            base.AddObject("tbr_ecf_tributacao", tbr_ecf_tributacao);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_finalizadora_sub_un EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_finalizadora_sub_un(tbr_finalizadora_sub_un tbr_finalizadora_sub_un)
        {
            base.AddObject("tbr_finalizadora_sub_un", tbr_finalizadora_sub_un);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_finalizadora_un EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_finalizadora_un(tbr_finalizadora_un tbr_finalizadora_un)
        {
            base.AddObject("tbr_finalizadora_un", tbr_finalizadora_un);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_mvto_compra_cfop____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_mvto_compra_cfop____(tbr_mvto_compra_cfop____ tbr_mvto_compra_cfop____)
        {
            base.AddObject("tbr_mvto_compra_cfop____", tbr_mvto_compra_cfop____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_mvto_compra_dup____ EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_mvto_compra_dup____(tbr_mvto_compra_dup____ tbr_mvto_compra_dup____)
        {
            base.AddObject("tbr_mvto_compra_dup____", tbr_mvto_compra_dup____);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_parametro_descprod_uneg EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_parametro_descprod_uneg(tbr_parametro_descprod_uneg tbr_parametro_descprod_uneg)
        {
            base.AddObject("tbr_parametro_descprod_uneg", tbr_parametro_descprod_uneg);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_parametro_descvend_uneg EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_parametro_descvend_uneg(tbr_parametro_descvend_uneg tbr_parametro_descvend_uneg)
        {
            base.AddObject("tbr_parametro_descvend_uneg", tbr_parametro_descvend_uneg);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_parametro_markup_uneg EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_parametro_markup_uneg(tbr_parametro_markup_uneg tbr_parametro_markup_uneg)
        {
            base.AddObject("tbr_parametro_markup_uneg", tbr_parametro_markup_uneg);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_produto_estoque_dia EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_produto_estoque_dia(tbr_produto_estoque_dia tbr_produto_estoque_dia)
        {
            base.AddObject("tbr_produto_estoque_dia", tbr_produto_estoque_dia);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_produto_estoque_lote EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_produto_estoque_lote(tbr_produto_estoque_lote tbr_produto_estoque_lote)
        {
            base.AddObject("tbr_produto_estoque_lote", tbr_produto_estoque_lote);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_produto_tributacao EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_produto_tributacao(tbr_produto_tributacao tbr_produto_tributacao)
        {
            base.AddObject("tbr_produto_tributacao", tbr_produto_tributacao);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_produto_uneg EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_produto_uneg(tbr_produto_uneg tbr_produto_uneg)
        {
            base.AddObject("tbr_produto_uneg", tbr_produto_uneg);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the tbr_promocao_produto EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbr_promocao_produto(tbr_promocao_produto tbr_promocao_produto)
        {
            base.AddObject("tbr_promocao_produto", tbr_promocao_produto);
        }
        #endregion

        #region CreateObject methods with initializer
        public tb_abcfarma Createtb_abcfarma(Int32? abcf_id = null, Nullable<Decimal> abcf_codigo = null, Nullable<Decimal> abcf_cd_barra = null, Nullable<Decimal> abcf_preco_fabrica = null, Nullable<Decimal> abcf_pmc = null, Nullable<Decimal> abcf_pmc_fracao = null, String abcf_descricao1 = null, String abcf_descricao2 = null, Nullable<Decimal> abcf_cod_fabricante = null, String abcf_fabricante = null, String abcf_tip_produto = null, String abcf_prod_novo = null, String abcf_generico = null, String abcf_princativo = null, String abcf_tip_lista = null, Nullable<Decimal> abcf_qtd_caixa = null, Nullable<Decimal> abcf_ipi = null, Nullable<DateTime> abcf_dt_alteracao = null, Nullable<Decimal> abcf_cpf_alteracao = null)
        {
            tb_abcfarma value = CreateObject<tb_abcfarma>();
            if (abcf_id != null)
                value.abcf_id = abcf_id.Value;
            if (abcf_codigo != null)
                value.abcf_codigo = abcf_codigo;
            if (abcf_cd_barra != null)
                value.abcf_cd_barra = abcf_cd_barra;
            if (abcf_preco_fabrica != null)
                value.abcf_preco_fabrica = abcf_preco_fabrica;
            if (abcf_pmc != null)
                value.abcf_pmc = abcf_pmc;
            if (abcf_pmc_fracao != null)
                value.abcf_pmc_fracao = abcf_pmc_fracao;
            if (abcf_descricao1 != null)
                value.abcf_descricao1 = abcf_descricao1;
            if (abcf_descricao2 != null)
                value.abcf_descricao2 = abcf_descricao2;
            if (abcf_cod_fabricante != null)
                value.abcf_cod_fabricante = abcf_cod_fabricante;
            if (abcf_fabricante != null)
                value.abcf_fabricante = abcf_fabricante;
            if (abcf_tip_produto != null)
                value.abcf_tip_produto = abcf_tip_produto;
            if (abcf_prod_novo != null)
                value.abcf_prod_novo = abcf_prod_novo;
            if (abcf_generico != null)
                value.abcf_generico = abcf_generico;
            if (abcf_princativo != null)
                value.abcf_princativo = abcf_princativo;
            if (abcf_tip_lista != null)
                value.abcf_tip_lista = abcf_tip_lista;
            if (abcf_qtd_caixa != null)
                value.abcf_qtd_caixa = abcf_qtd_caixa;
            if (abcf_ipi != null)
                value.abcf_ipi = abcf_ipi;
            if (abcf_dt_alteracao != null)
                value.abcf_dt_alteracao = abcf_dt_alteracao;
            if (abcf_cpf_alteracao != null)
                value.abcf_cpf_alteracao = abcf_cpf_alteracao;
            return value;
        }

        public tb_abcfarma_periodo Createtb_abcfarma_periodo(Int32? per_id = null, String per_periodo = null, Nullable<DateTime> per_dt_alteracao = null, Nullable<Decimal> per_cpf_alteracao = null)
        {
            tb_abcfarma_periodo value = CreateObject<tb_abcfarma_periodo>();
            if (per_id != null)
                value.per_id = per_id.Value;
            if (per_periodo != null)
                value.per_periodo = per_periodo;
            if (per_dt_alteracao != null)
                value.per_dt_alteracao = per_dt_alteracao;
            if (per_cpf_alteracao != null)
                value.per_cpf_alteracao = per_cpf_alteracao;
            return value;
        }

        public tb_abertura_caixa Createtb_abertura_caixa(Int32? uneg_id = null, Int32? aberturaCx_usr_id_operador = null, DateTime? aberturaCx_dt_abertura = null, Nullable<DateTime> aberturaCx_dt_fechamento = null, Nullable<Int32> aberturaCx_usr_id_fechamento = null, Nullable<Int32> aberturaCx_usr_id_conferente = null, Nullable<DateTime> aberturaCx_dt_conferencia = null, String aberturaCx_observacao = null, Nullable<DateTime> aberturaCx_dt_alteracao = null)
        {
            tb_abertura_caixa value = CreateObject<tb_abertura_caixa>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (aberturaCx_usr_id_operador != null)
                value.aberturaCx_usr_id_operador = aberturaCx_usr_id_operador.Value;
            if (aberturaCx_dt_abertura != null)
                value.aberturaCx_dt_abertura = aberturaCx_dt_abertura.Value;
            if (aberturaCx_dt_fechamento != null)
                value.aberturaCx_dt_fechamento = aberturaCx_dt_fechamento;
            if (aberturaCx_usr_id_fechamento != null)
                value.aberturaCx_usr_id_fechamento = aberturaCx_usr_id_fechamento;
            if (aberturaCx_usr_id_conferente != null)
                value.aberturaCx_usr_id_conferente = aberturaCx_usr_id_conferente;
            if (aberturaCx_dt_conferencia != null)
                value.aberturaCx_dt_conferencia = aberturaCx_dt_conferencia;
            if (aberturaCx_observacao != null)
                value.aberturaCx_observacao = aberturaCx_observacao;
            if (aberturaCx_dt_alteracao != null)
                value.aberturaCx_dt_alteracao = aberturaCx_dt_alteracao;
            return value;
        }

        public tb_agenda_produto Createtb_agenda_produto(Int32? uneg_id = null, Int32? agen_pdv = null, Int32? agen_id = null, DateTime? agen_dt_agenda = null, Nullable<DateTime> agen_dt_vencimento = null, Nullable<DateTime> agen_dt_start = null, Nullable<DateTime> agen_dt_venda = null, String agen_status = null, Nullable<DateTime> agen_status_data = null, String agen_status_obs = null, Nullable<DateTime> agen_dt_alteracao = null, Nullable<Int32> agen_qtde_embalagem = null, Nullable<Int32> agen_atde_compra = null, Nullable<Int32> agen_tmp_consumo_hora = null, Nullable<Int32> agen_tmp_consumo_diario = null, Nullable<Int32> agen_tmp_consumo_dia = null, Nullable<Int32> agen_tmp_consumo_mes = null, Nullable<Int32> agen_qtde_consumo = null, String agen_nome_contato = null, Nullable<Int64> agen_tel_residencial = null, Nullable<Int64> agen_tel_comercial = null, Nullable<Int64> agen_tel_celular = null, String agen_observacao = null, Nullable<Decimal> agen_preco_custo = null, Nullable<Decimal> agen_preco_venda = null, Nullable<Int64> end_telefone = null)
        {
            tb_agenda_produto value = CreateObject<tb_agenda_produto>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (agen_pdv != null)
                value.agen_pdv = agen_pdv.Value;
            if (agen_id != null)
                value.agen_id = agen_id.Value;
            if (agen_dt_agenda != null)
                value.agen_dt_agenda = agen_dt_agenda.Value;
            if (agen_dt_vencimento != null)
                value.agen_dt_vencimento = agen_dt_vencimento;
            if (agen_dt_start != null)
                value.agen_dt_start = agen_dt_start;
            if (agen_dt_venda != null)
                value.agen_dt_venda = agen_dt_venda;
            if (agen_status != null)
                value.agen_status = agen_status;
            if (agen_status_data != null)
                value.agen_status_data = agen_status_data;
            if (agen_status_obs != null)
                value.agen_status_obs = agen_status_obs;
            if (agen_dt_alteracao != null)
                value.agen_dt_alteracao = agen_dt_alteracao;
            if (agen_qtde_embalagem != null)
                value.agen_qtde_embalagem = agen_qtde_embalagem;
            if (agen_atde_compra != null)
                value.agen_atde_compra = agen_atde_compra;
            if (agen_tmp_consumo_hora != null)
                value.agen_tmp_consumo_hora = agen_tmp_consumo_hora;
            if (agen_tmp_consumo_diario != null)
                value.agen_tmp_consumo_diario = agen_tmp_consumo_diario;
            if (agen_tmp_consumo_dia != null)
                value.agen_tmp_consumo_dia = agen_tmp_consumo_dia;
            if (agen_tmp_consumo_mes != null)
                value.agen_tmp_consumo_mes = agen_tmp_consumo_mes;
            if (agen_qtde_consumo != null)
                value.agen_qtde_consumo = agen_qtde_consumo;
            if (agen_nome_contato != null)
                value.agen_nome_contato = agen_nome_contato;
            if (agen_tel_residencial != null)
                value.agen_tel_residencial = agen_tel_residencial;
            if (agen_tel_comercial != null)
                value.agen_tel_comercial = agen_tel_comercial;
            if (agen_tel_celular != null)
                value.agen_tel_celular = agen_tel_celular;
            if (agen_observacao != null)
                value.agen_observacao = agen_observacao;
            if (agen_preco_custo != null)
                value.agen_preco_custo = agen_preco_custo;
            if (agen_preco_venda != null)
                value.agen_preco_venda = agen_preco_venda;
            if (end_telefone != null)
                value.end_telefone = end_telefone;
            return value;
        }

        public tb_banco Createtb_banco(Int32? banco_id = null, Nullable<Decimal> banco_codigo = null, String banco_nome = null, String banco_tipo = null, String banco_situacao = null, Nullable<DateTime> banco_dt_cadastro = null, Nullable<DateTime> banco_dt_alteracao = null, Nullable<Decimal> banco_cpf_alteracao = null)
        {
            tb_banco value = CreateObject<tb_banco>();
            if (banco_id != null)
                value.banco_id = banco_id.Value;
            if (banco_codigo != null)
                value.banco_codigo = banco_codigo;
            if (banco_nome != null)
                value.banco_nome = banco_nome;
            if (banco_tipo != null)
                value.banco_tipo = banco_tipo;
            if (banco_situacao != null)
                value.banco_situacao = banco_situacao;
            if (banco_dt_cadastro != null)
                value.banco_dt_cadastro = banco_dt_cadastro;
            if (banco_dt_alteracao != null)
                value.banco_dt_alteracao = banco_dt_alteracao;
            if (banco_cpf_alteracao != null)
                value.banco_cpf_alteracao = banco_cpf_alteracao;
            return value;
        }

        public tb_cadastro_contador Createtb_cadastro_contador(Int32? cadcont_id = null, String cadcont_nome = null, String cadcont_cpf = null, String cadcont_crc = null, String cadcont_email = null, String cadcont_status = null, Nullable<DateTime> cadcont_data_modificacao = null, String cadcont_escritorio_cnpj = null, String cadcont_escritorio_inscricao_estadual = null, String cadcont_escritorio_inscricao_municipal = null, String cadcont_escritorio_razao_social = null, String cadcont_escritorio_nome_fantasia = null, String cadcont_escritorio_endereco = null, String cadcont_escritorio_numero = null, String cadcont_escritorio_complemento = null, String cadcont_escritorio_bairro = null, String cadcont_escritorio_cep = null, Nullable<Int32> cadcont_escritorio_ddd = null, String cadcont_escritorio_telefone = null, Nullable<Int32> cadcont_escritorio_ddd_fax = null, String cadcont_escritorio_fax = null, String cadcont_escritorio_email = null)
        {
            tb_cadastro_contador value = CreateObject<tb_cadastro_contador>();
            if (cadcont_id != null)
                value.cadcont_id = cadcont_id.Value;
            if (cadcont_nome != null)
                value.cadcont_nome = cadcont_nome;
            if (cadcont_cpf != null)
                value.cadcont_cpf = cadcont_cpf;
            if (cadcont_crc != null)
                value.cadcont_crc = cadcont_crc;
            if (cadcont_email != null)
                value.cadcont_email = cadcont_email;
            if (cadcont_status != null)
                value.cadcont_status = cadcont_status;
            if (cadcont_data_modificacao != null)
                value.cadcont_data_modificacao = cadcont_data_modificacao;
            if (cadcont_escritorio_cnpj != null)
                value.cadcont_escritorio_cnpj = cadcont_escritorio_cnpj;
            if (cadcont_escritorio_inscricao_estadual != null)
                value.cadcont_escritorio_inscricao_estadual = cadcont_escritorio_inscricao_estadual;
            if (cadcont_escritorio_inscricao_municipal != null)
                value.cadcont_escritorio_inscricao_municipal = cadcont_escritorio_inscricao_municipal;
            if (cadcont_escritorio_razao_social != null)
                value.cadcont_escritorio_razao_social = cadcont_escritorio_razao_social;
            if (cadcont_escritorio_nome_fantasia != null)
                value.cadcont_escritorio_nome_fantasia = cadcont_escritorio_nome_fantasia;
            if (cadcont_escritorio_endereco != null)
                value.cadcont_escritorio_endereco = cadcont_escritorio_endereco;
            if (cadcont_escritorio_numero != null)
                value.cadcont_escritorio_numero = cadcont_escritorio_numero;
            if (cadcont_escritorio_complemento != null)
                value.cadcont_escritorio_complemento = cadcont_escritorio_complemento;
            if (cadcont_escritorio_bairro != null)
                value.cadcont_escritorio_bairro = cadcont_escritorio_bairro;
            if (cadcont_escritorio_cep != null)
                value.cadcont_escritorio_cep = cadcont_escritorio_cep;
            if (cadcont_escritorio_ddd != null)
                value.cadcont_escritorio_ddd = cadcont_escritorio_ddd;
            if (cadcont_escritorio_telefone != null)
                value.cadcont_escritorio_telefone = cadcont_escritorio_telefone;
            if (cadcont_escritorio_ddd_fax != null)
                value.cadcont_escritorio_ddd_fax = cadcont_escritorio_ddd_fax;
            if (cadcont_escritorio_fax != null)
                value.cadcont_escritorio_fax = cadcont_escritorio_fax;
            if (cadcont_escritorio_email != null)
                value.cadcont_escritorio_email = cadcont_escritorio_email;
            return value;
        }

        public tb_cargo Createtb_cargo(Int32? cargo_id = null, String cargo_descricao = null, String cargo_situacao = null, Nullable<DateTime> cargo_dt_cadastro = null, Nullable<DateTime> cargo_dt_alteracao = null)
        {
            tb_cargo value = CreateObject<tb_cargo>();
            if (cargo_id != null)
                value.cargo_id = cargo_id.Value;
            if (cargo_descricao != null)
                value.cargo_descricao = cargo_descricao;
            if (cargo_situacao != null)
                value.cargo_situacao = cargo_situacao;
            if (cargo_dt_cadastro != null)
                value.cargo_dt_cadastro = cargo_dt_cadastro;
            if (cargo_dt_alteracao != null)
                value.cargo_dt_alteracao = cargo_dt_alteracao;
            return value;
        }

        public tb_ceps Createtb_ceps(Int32? polo_id = null, Int32? quadra_id = null, Int32? rota_id = null, Int32? cep_id = null, Nullable<Decimal> cep_inicial = null, Nullable<Decimal> cep_final = null, Nullable<Decimal> cep_nu_inicial = null, Nullable<Decimal> cep_nu_final = null, String cep_situacao = null, Nullable<DateTime> cep_dt_cadastro = null, Nullable<DateTime> cep_dt_alteracao = null)
        {
            tb_ceps value = CreateObject<tb_ceps>();
            if (polo_id != null)
                value.polo_id = polo_id.Value;
            if (quadra_id != null)
                value.quadra_id = quadra_id.Value;
            if (rota_id != null)
                value.rota_id = rota_id.Value;
            if (cep_id != null)
                value.cep_id = cep_id.Value;
            if (cep_inicial != null)
                value.cep_inicial = cep_inicial;
            if (cep_final != null)
                value.cep_final = cep_final;
            if (cep_nu_inicial != null)
                value.cep_nu_inicial = cep_nu_inicial;
            if (cep_nu_final != null)
                value.cep_nu_final = cep_nu_final;
            if (cep_situacao != null)
                value.cep_situacao = cep_situacao;
            if (cep_dt_cadastro != null)
                value.cep_dt_cadastro = cep_dt_cadastro;
            if (cep_dt_alteracao != null)
                value.cep_dt_alteracao = cep_dt_alteracao;
            return value;
        }

        public tb_cfop Createtb_cfop(Int32? cfop_id = null, Nullable<Decimal> cfop_codigo = null, String cfop_descricao = null, String cfop_situacao = null, Nullable<DateTime> cfop_dt_cadastro = null, Nullable<DateTime> cfop_dt_alteracao = null)
        {
            tb_cfop value = CreateObject<tb_cfop>();
            if (cfop_id != null)
                value.cfop_id = cfop_id.Value;
            if (cfop_codigo != null)
                value.cfop_codigo = cfop_codigo;
            if (cfop_descricao != null)
                value.cfop_descricao = cfop_descricao;
            if (cfop_situacao != null)
                value.cfop_situacao = cfop_situacao;
            if (cfop_dt_cadastro != null)
                value.cfop_dt_cadastro = cfop_dt_cadastro;
            if (cfop_dt_alteracao != null)
                value.cfop_dt_alteracao = cfop_dt_alteracao;
            return value;
        }

        public tb_checkin Createtb_checkin(Int32? uneg_id = null, Int32? chkin_pdv = null, Int32? chkin_id = null, DateTime? chkin_data = null, Nullable<Decimal> chkin_num_nf = null, Nullable<Int32> chkin_operador_id = null, Nullable<Int32> cmp_id = null, Nullable<Int32> pedc_id = null, Nullable<Int32> fab_id = null, Nullable<Int32> div_id = null)
        {
            tb_checkin value = CreateObject<tb_checkin>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (chkin_pdv != null)
                value.chkin_pdv = chkin_pdv.Value;
            if (chkin_id != null)
                value.chkin_id = chkin_id.Value;
            if (chkin_data != null)
                value.chkin_data = chkin_data.Value;
            if (chkin_num_nf != null)
                value.chkin_num_nf = chkin_num_nf;
            if (chkin_operador_id != null)
                value.chkin_operador_id = chkin_operador_id;
            if (cmp_id != null)
                value.cmp_id = cmp_id;
            if (pedc_id != null)
                value.pedc_id = pedc_id;
            if (fab_id != null)
                value.fab_id = fab_id;
            if (div_id != null)
                value.div_id = div_id;
            return value;
        }

        public tb_checkin_item Createtb_checkin_item(Int32? uneg_id = null, Int32? chkin_pdv = null, Int32? chkin_id = null, DateTime? chkin_data = null, Int32? ickin_id = null, Nullable<Int32> pro_id = null, Nullable<Decimal> ickin_cd_barra_lido = null, Nullable<Decimal> ickin_quantidade = null, String ickin_nu_lote = null, Nullable<DateTime> ickin_val_lote = null, Nullable<Boolean> ickin_conciliacao_nf = null)
        {
            tb_checkin_item value = CreateObject<tb_checkin_item>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (chkin_pdv != null)
                value.chkin_pdv = chkin_pdv.Value;
            if (chkin_id != null)
                value.chkin_id = chkin_id.Value;
            if (chkin_data != null)
                value.chkin_data = chkin_data.Value;
            if (ickin_id != null)
                value.ickin_id = ickin_id.Value;
            if (pro_id != null)
                value.pro_id = pro_id;
            if (ickin_cd_barra_lido != null)
                value.ickin_cd_barra_lido = ickin_cd_barra_lido;
            if (ickin_quantidade != null)
                value.ickin_quantidade = ickin_quantidade;
            if (ickin_nu_lote != null)
                value.ickin_nu_lote = ickin_nu_lote;
            if (ickin_val_lote != null)
                value.ickin_val_lote = ickin_val_lote;
            if (ickin_conciliacao_nf != null)
                value.ickin_conciliacao_nf = ickin_conciliacao_nf;
            return value;
        }

        public tb_checkin_item_tmp Createtb_checkin_item_tmp(Int32? chkin_id = null, Int32? ickin_id = null, Nullable<Decimal> ickin_quantidade = null, String ickin_nu_lote = null, Nullable<DateTime> ickin_val_lote = null)
        {
            tb_checkin_item_tmp value = CreateObject<tb_checkin_item_tmp>();
            if (chkin_id != null)
                value.chkin_id = chkin_id.Value;
            if (ickin_id != null)
                value.ickin_id = ickin_id.Value;
            if (ickin_quantidade != null)
                value.ickin_quantidade = ickin_quantidade;
            if (ickin_nu_lote != null)
                value.ickin_nu_lote = ickin_nu_lote;
            if (ickin_val_lote != null)
                value.ickin_val_lote = ickin_val_lote;
            return value;
        }

        public tb_checkin_tmp Createtb_checkin_tmp(Int32? chkin_id = null, Nullable<Decimal> chkin_num_nf = null, Nullable<DateTime> chkin_data = null, Nullable<Decimal> chkin_cpf_usuario = null, Nullable<DateTime> chkin_dt_alteracao = null)
        {
            tb_checkin_tmp value = CreateObject<tb_checkin_tmp>();
            if (chkin_id != null)
                value.chkin_id = chkin_id.Value;
            if (chkin_num_nf != null)
                value.chkin_num_nf = chkin_num_nf;
            if (chkin_data != null)
                value.chkin_data = chkin_data;
            if (chkin_cpf_usuario != null)
                value.chkin_cpf_usuario = chkin_cpf_usuario;
            if (chkin_dt_alteracao != null)
                value.chkin_dt_alteracao = chkin_dt_alteracao;
            return value;
        }

        public tb_checkout Createtb_checkout(Int32? uneg_id = null, Int32? chkout_pdv = null, Int32? chkout_id = null, DateTime? chkout_data = null, Nullable<Decimal> chkout_num_nf = null, Nullable<Int32> chkout_operador_id = null, Nullable<Int32> cli_id = null, Nullable<Int32> pedv_id = null)
        {
            tb_checkout value = CreateObject<tb_checkout>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (chkout_pdv != null)
                value.chkout_pdv = chkout_pdv.Value;
            if (chkout_id != null)
                value.chkout_id = chkout_id.Value;
            if (chkout_data != null)
                value.chkout_data = chkout_data.Value;
            if (chkout_num_nf != null)
                value.chkout_num_nf = chkout_num_nf;
            if (chkout_operador_id != null)
                value.chkout_operador_id = chkout_operador_id;
            if (cli_id != null)
                value.cli_id = cli_id;
            if (pedv_id != null)
                value.pedv_id = pedv_id;
            return value;
        }

        public tb_checkout_item Createtb_checkout_item(Int32? uneg_id = null, Int32? chkout_pdv = null, Int32? chkout_id = null, DateTime? chkout_data = null, Int32? ickout_id = null, Nullable<Int32> pro_id = null, Nullable<Decimal> ickout_cd_barra_lido = null, Nullable<Decimal> ickout_quantidade = null, String ickout_nu_lote = null, Nullable<DateTime> ickout_val_lote = null, Nullable<Boolean> ickout_conciliacao_nf = null)
        {
            tb_checkout_item value = CreateObject<tb_checkout_item>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (chkout_pdv != null)
                value.chkout_pdv = chkout_pdv.Value;
            if (chkout_id != null)
                value.chkout_id = chkout_id.Value;
            if (chkout_data != null)
                value.chkout_data = chkout_data.Value;
            if (ickout_id != null)
                value.ickout_id = ickout_id.Value;
            if (pro_id != null)
                value.pro_id = pro_id;
            if (ickout_cd_barra_lido != null)
                value.ickout_cd_barra_lido = ickout_cd_barra_lido;
            if (ickout_quantidade != null)
                value.ickout_quantidade = ickout_quantidade;
            if (ickout_nu_lote != null)
                value.ickout_nu_lote = ickout_nu_lote;
            if (ickout_val_lote != null)
                value.ickout_val_lote = ickout_val_lote;
            if (ickout_conciliacao_nf != null)
                value.ickout_conciliacao_nf = ickout_conciliacao_nf;
            return value;
        }

        public tb_cliente Createtb_cliente(Int64? cli_id = null, String cli_email = null, Nullable<Decimal> cli_limite_compra = null, Nullable<Decimal> cli_compra_acumulada = null, Nullable<DateTime> cli_dt_bloqueio = null, Nullable<Decimal> cli_qtd_bloqueio = null, String cli_obs = null, Nullable<DateTime> cli_dt_ultima_compra = null, String cli_cpf_alteracao = null, String cli_tip_pessoa = null, Nullable<Int32> cli_titular_id = null, String cli_cpf = null, String cli_nome = null, String cli_id_numero = null, String cli_id_orgao_expedidor = null, Nullable<DateTime> cli_id_dt_expedicao = null, Nullable<DateTime> cli_dt_nascimento = null, String cli_sexo = null, String cli_estado_civil = null, Nullable<Decimal> cli_nu_filhos = null, String cli_nm_pai = null, String cli_nm_mae = null, String cli_cnpj = null, Nullable<Decimal> cli_insc_estadual = null, String cli_razao_social = null, String cli_nome_fantasia = null, String cli_cnpj_rede = null, Nullable<Decimal> cli_vlr_credito = null, Nullable<Decimal> cli_polo_distribuidor = null, Nullable<Decimal> cli_perc_csub = null, Nullable<Decimal> cli_perc_ssub = null, Nullable<Boolean> cli_venda_imp_fracionada = null, Nullable<Boolean> cli_venda_imp_princativo = null, String cli_nm_contato = null, String cli_situacao = null, Nullable<DateTime> cli_dt_cadastro = null, Nullable<DateTime> cli_dt_alteracao = null, Nullable<Int32> final_id = null, Nullable<Int32> subfin_id = null)
        {
            tb_cliente value = CreateObject<tb_cliente>();
            if (cli_id != null)
                value.cli_id = cli_id.Value;
            if (cli_email != null)
                value.cli_email = cli_email;
            if (cli_limite_compra != null)
                value.cli_limite_compra = cli_limite_compra;
            if (cli_compra_acumulada != null)
                value.cli_compra_acumulada = cli_compra_acumulada;
            if (cli_dt_bloqueio != null)
                value.cli_dt_bloqueio = cli_dt_bloqueio;
            if (cli_qtd_bloqueio != null)
                value.cli_qtd_bloqueio = cli_qtd_bloqueio;
            if (cli_obs != null)
                value.cli_obs = cli_obs;
            if (cli_dt_ultima_compra != null)
                value.cli_dt_ultima_compra = cli_dt_ultima_compra;
            if (cli_cpf_alteracao != null)
                value.cli_cpf_alteracao = cli_cpf_alteracao;
            if (cli_tip_pessoa != null)
                value.cli_tip_pessoa = cli_tip_pessoa;
            if (cli_titular_id != null)
                value.cli_titular_id = cli_titular_id;
            if (cli_cpf != null)
                value.cli_cpf = cli_cpf;
            if (cli_nome != null)
                value.cli_nome = cli_nome;
            if (cli_id_numero != null)
                value.cli_id_numero = cli_id_numero;
            if (cli_id_orgao_expedidor != null)
                value.cli_id_orgao_expedidor = cli_id_orgao_expedidor;
            if (cli_id_dt_expedicao != null)
                value.cli_id_dt_expedicao = cli_id_dt_expedicao;
            if (cli_dt_nascimento != null)
                value.cli_dt_nascimento = cli_dt_nascimento;
            if (cli_sexo != null)
                value.cli_sexo = cli_sexo;
            if (cli_estado_civil != null)
                value.cli_estado_civil = cli_estado_civil;
            if (cli_nu_filhos != null)
                value.cli_nu_filhos = cli_nu_filhos;
            if (cli_nm_pai != null)
                value.cli_nm_pai = cli_nm_pai;
            if (cli_nm_mae != null)
                value.cli_nm_mae = cli_nm_mae;
            if (cli_cnpj != null)
                value.cli_cnpj = cli_cnpj;
            if (cli_insc_estadual != null)
                value.cli_insc_estadual = cli_insc_estadual;
            if (cli_razao_social != null)
                value.cli_razao_social = cli_razao_social;
            if (cli_nome_fantasia != null)
                value.cli_nome_fantasia = cli_nome_fantasia;
            if (cli_cnpj_rede != null)
                value.cli_cnpj_rede = cli_cnpj_rede;
            if (cli_vlr_credito != null)
                value.cli_vlr_credito = cli_vlr_credito;
            if (cli_polo_distribuidor != null)
                value.cli_polo_distribuidor = cli_polo_distribuidor;
            if (cli_perc_csub != null)
                value.cli_perc_csub = cli_perc_csub;
            if (cli_perc_ssub != null)
                value.cli_perc_ssub = cli_perc_ssub;
            if (cli_venda_imp_fracionada != null)
                value.cli_venda_imp_fracionada = cli_venda_imp_fracionada;
            if (cli_venda_imp_princativo != null)
                value.cli_venda_imp_princativo = cli_venda_imp_princativo;
            if (cli_nm_contato != null)
                value.cli_nm_contato = cli_nm_contato;
            if (cli_situacao != null)
                value.cli_situacao = cli_situacao;
            if (cli_dt_cadastro != null)
                value.cli_dt_cadastro = cli_dt_cadastro;
            if (cli_dt_alteracao != null)
                value.cli_dt_alteracao = cli_dt_alteracao;
            if (final_id != null)
                value.final_id = final_id;
            if (subfin_id != null)
                value.subfin_id = subfin_id;
            return value;
        }

        public tb_cliente_anvisa Createtb_cliente_anvisa(String cli_anv_num_documento = null, String cli_anv_orgao_expedidor = null, String cli_anv_nome = null, String cli_anv_telefone = null, DateTime? cli_anv_data_cadastro = null, Int32? usr_id = null, Int32? uneg_id = null)
        {
            tb_cliente_anvisa value = CreateObject<tb_cliente_anvisa>();
            if (cli_anv_num_documento != null)
                value.cli_anv_num_documento = cli_anv_num_documento;
            if (cli_anv_orgao_expedidor != null)
                value.cli_anv_orgao_expedidor = cli_anv_orgao_expedidor;
            if (cli_anv_nome != null)
                value.cli_anv_nome = cli_anv_nome;
            if (cli_anv_telefone != null)
                value.cli_anv_telefone = cli_anv_telefone;
            if (cli_anv_data_cadastro != null)
                value.cli_anv_data_cadastro = cli_anv_data_cadastro.Value;
            if (usr_id != null)
                value.usr_id = usr_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            return value;
        }

        public tb_cliente_bloqueio Createtb_cliente_bloqueio(Int32? bloq_id = null, String bloq_descricao = null, Nullable<Decimal> bloq_tip_acao = null, String bloq_situacao = null, Nullable<DateTime> bloq_dt_cadastro = null, Nullable<DateTime> bloq_dt_alteracao = null)
        {
            tb_cliente_bloqueio value = CreateObject<tb_cliente_bloqueio>();
            if (bloq_id != null)
                value.bloq_id = bloq_id.Value;
            if (bloq_descricao != null)
                value.bloq_descricao = bloq_descricao;
            if (bloq_tip_acao != null)
                value.bloq_tip_acao = bloq_tip_acao;
            if (bloq_situacao != null)
                value.bloq_situacao = bloq_situacao;
            if (bloq_dt_cadastro != null)
                value.bloq_dt_cadastro = bloq_dt_cadastro;
            if (bloq_dt_alteracao != null)
                value.bloq_dt_alteracao = bloq_dt_alteracao;
            return value;
        }

        public tb_cliente_endereco Createtb_cliente_endereco(Int64? cli_id = null, Int32? end_id = null, String end_cep = null, String end_tp_logradouro = null, String end_nm_logradouro = null, Nullable<Int32> end_numero = null, String end_complemento = null, String end_bairro = null, String end_cidade = null, String end_referencia = null, String end_tipo = null, String end_situacao = null, Nullable<DateTime> end_dt_cadastro = null, Nullable<DateTime> end_dt_alteracao = null, String end_cpf_alteracao = null)
        {
            tb_cliente_endereco value = CreateObject<tb_cliente_endereco>();
            if (cli_id != null)
                value.cli_id = cli_id.Value;
            if (end_id != null)
                value.end_id = end_id.Value;
            if (end_cep != null)
                value.end_cep = end_cep;
            if (end_tp_logradouro != null)
                value.end_tp_logradouro = end_tp_logradouro;
            if (end_nm_logradouro != null)
                value.end_nm_logradouro = end_nm_logradouro;
            if (end_numero != null)
                value.end_numero = end_numero;
            if (end_complemento != null)
                value.end_complemento = end_complemento;
            if (end_bairro != null)
                value.end_bairro = end_bairro;
            if (end_cidade != null)
                value.end_cidade = end_cidade;
            if (end_referencia != null)
                value.end_referencia = end_referencia;
            if (end_tipo != null)
                value.end_tipo = end_tipo;
            if (end_situacao != null)
                value.end_situacao = end_situacao;
            if (end_dt_cadastro != null)
                value.end_dt_cadastro = end_dt_cadastro;
            if (end_dt_alteracao != null)
                value.end_dt_alteracao = end_dt_alteracao;
            if (end_cpf_alteracao != null)
                value.end_cpf_alteracao = end_cpf_alteracao;
            return value;
        }

        public tb_cliente_fiscal Createtb_cliente_fiscal(String cli_fisc_cpf_cnpj = null, String cli_fisc_nome = null, String cli_fisc_email = null, String cli_fisc_endereco = null, String cli_fisc_tp_logradouro = null, Nullable<Int32> cli_fisc_numero = null, String cli_fisc_complemento = null, String cli_fisc_bairro = null, String cli_fisc_cidade = null, String cli_fisc_uf = null, String cli_fisc_cep = null, DateTime? cli_fisc_data_cadastro = null, String cli_fisc_ibge_codigo = null)
        {
            tb_cliente_fiscal value = CreateObject<tb_cliente_fiscal>();
            if (cli_fisc_cpf_cnpj != null)
                value.cli_fisc_cpf_cnpj = cli_fisc_cpf_cnpj;
            if (cli_fisc_nome != null)
                value.cli_fisc_nome = cli_fisc_nome;
            if (cli_fisc_email != null)
                value.cli_fisc_email = cli_fisc_email;
            if (cli_fisc_endereco != null)
                value.cli_fisc_endereco = cli_fisc_endereco;
            if (cli_fisc_tp_logradouro != null)
                value.cli_fisc_tp_logradouro = cli_fisc_tp_logradouro;
            if (cli_fisc_numero != null)
                value.cli_fisc_numero = cli_fisc_numero;
            if (cli_fisc_complemento != null)
                value.cli_fisc_complemento = cli_fisc_complemento;
            if (cli_fisc_bairro != null)
                value.cli_fisc_bairro = cli_fisc_bairro;
            if (cli_fisc_cidade != null)
                value.cli_fisc_cidade = cli_fisc_cidade;
            if (cli_fisc_uf != null)
                value.cli_fisc_uf = cli_fisc_uf;
            if (cli_fisc_cep != null)
                value.cli_fisc_cep = cli_fisc_cep;
            if (cli_fisc_data_cadastro != null)
                value.cli_fisc_data_cadastro = cli_fisc_data_cadastro.Value;
            if (cli_fisc_ibge_codigo != null)
                value.cli_fisc_ibge_codigo = cli_fisc_ibge_codigo;
            return value;
        }

        public tb_cliente_telefone Createtb_cliente_telefone(Int64? cli_id = null, Int32? tel_id = null, Nullable<Decimal> tel_tipo = null, Nullable<Decimal> tel_cod_area = null, Nullable<Decimal> tel_numero = null, String tel_situacao = null, Nullable<DateTime> tel_dt_cadastro = null, Nullable<DateTime> tel_dt_alteracao = null, String tel_cpf_alteracao = null)
        {
            tb_cliente_telefone value = CreateObject<tb_cliente_telefone>();
            if (cli_id != null)
                value.cli_id = cli_id.Value;
            if (tel_id != null)
                value.tel_id = tel_id.Value;
            if (tel_tipo != null)
                value.tel_tipo = tel_tipo;
            if (tel_cod_area != null)
                value.tel_cod_area = tel_cod_area;
            if (tel_numero != null)
                value.tel_numero = tel_numero;
            if (tel_situacao != null)
                value.tel_situacao = tel_situacao;
            if (tel_dt_cadastro != null)
                value.tel_dt_cadastro = tel_dt_cadastro;
            if (tel_dt_alteracao != null)
                value.tel_dt_alteracao = tel_dt_alteracao;
            if (tel_cpf_alteracao != null)
                value.tel_cpf_alteracao = tel_cpf_alteracao;
            return value;
        }

        public tb_conselho Createtb_conselho(Int16? cs_id = null, String cs_descricao = null)
        {
            tb_conselho value = CreateObject<tb_conselho>();
            if (cs_id != null)
                value.cs_id = cs_id.Value;
            if (cs_descricao != null)
                value.cs_descricao = cs_descricao;
            return value;
        }

        public tb_conselho_regional Createtb_conselho_regional(Int32? cr_id = null, Decimal? cr_numero = null, String cr_nome = null, String cr_cons_uf = null, Nullable<Decimal> cr_especialidade_id = null)
        {
            tb_conselho_regional value = CreateObject<tb_conselho_regional>();
            if (cr_id != null)
                value.cr_id = cr_id.Value;
            if (cr_numero != null)
                value.cr_numero = cr_numero.Value;
            if (cr_nome != null)
                value.cr_nome = cr_nome;
            if (cr_cons_uf != null)
                value.cr_cons_uf = cr_cons_uf;
            if (cr_especialidade_id != null)
                value.cr_especialidade_id = cr_especialidade_id;
            return value;
        }

        public tb_conta Createtb_conta(Int32? grau_id = null, String grau_1 = null, String grau_2 = null, String grau_3 = null, String grau_descricao = null)
        {
            tb_conta value = CreateObject<tb_conta>();
            if (grau_id != null)
                value.grau_id = grau_id.Value;
            if (grau_1 != null)
                value.grau_1 = grau_1;
            if (grau_2 != null)
                value.grau_2 = grau_2;
            if (grau_3 != null)
                value.grau_3 = grau_3;
            if (grau_descricao != null)
                value.grau_descricao = grau_descricao;
            return value;
        }

        public tb_convenio Createtb_convenio(Int32? cnv_id = null, String cnv_titulo = null, Nullable<Decimal> cnv_dia_fechamento = null, Nullable<Decimal> cnv_tipo = null, String cnv_tipo_pagamento = null, String cnv_situacao = null, Nullable<DateTime> cnv_dt_cadastro = null, Nullable<DateTime> cnv_dt_alteracao = null)
        {
            tb_convenio value = CreateObject<tb_convenio>();
            if (cnv_id != null)
                value.cnv_id = cnv_id.Value;
            if (cnv_titulo != null)
                value.cnv_titulo = cnv_titulo;
            if (cnv_dia_fechamento != null)
                value.cnv_dia_fechamento = cnv_dia_fechamento;
            if (cnv_tipo != null)
                value.cnv_tipo = cnv_tipo;
            if (cnv_tipo_pagamento != null)
                value.cnv_tipo_pagamento = cnv_tipo_pagamento;
            if (cnv_situacao != null)
                value.cnv_situacao = cnv_situacao;
            if (cnv_dt_cadastro != null)
                value.cnv_dt_cadastro = cnv_dt_cadastro;
            if (cnv_dt_alteracao != null)
                value.cnv_dt_alteracao = cnv_dt_alteracao;
            return value;
        }

        public tb_crediario Createtb_crediario(Int32? cred_id = null, Nullable<DateTime> cred_dt_entrada = null, Nullable<DateTime> cred_dt_vencimento = null, Nullable<Decimal> cred_vlr_documento = null, Nullable<Decimal> cred_vlr_pago = null, Nullable<DateTime> cred_dt_liquidacao = null, Nullable<Decimal> cred_vlr_liquidacao = null, Nullable<Decimal> cred_desconto_liq = null, Nullable<Decimal> cred_juros_liq = null, Nullable<Decimal> cred_taxa_liq = null, String cred_situacao = null, Nullable<Decimal> cred_cpf_cadastro = null, Nullable<DateTime> cred_dt_alteracao = null, Nullable<Decimal> cred_cpf_alteracao = null, Nullable<Int32> venda_pdv = null, Nullable<Int32> venda_id = null, Nullable<DateTime> venda_data = null, Int32? rec_id = null)
        {
            tb_crediario value = CreateObject<tb_crediario>();
            if (cred_id != null)
                value.cred_id = cred_id.Value;
            if (cred_dt_entrada != null)
                value.cred_dt_entrada = cred_dt_entrada;
            if (cred_dt_vencimento != null)
                value.cred_dt_vencimento = cred_dt_vencimento;
            if (cred_vlr_documento != null)
                value.cred_vlr_documento = cred_vlr_documento;
            if (cred_vlr_pago != null)
                value.cred_vlr_pago = cred_vlr_pago;
            if (cred_dt_liquidacao != null)
                value.cred_dt_liquidacao = cred_dt_liquidacao;
            if (cred_vlr_liquidacao != null)
                value.cred_vlr_liquidacao = cred_vlr_liquidacao;
            if (cred_desconto_liq != null)
                value.cred_desconto_liq = cred_desconto_liq;
            if (cred_juros_liq != null)
                value.cred_juros_liq = cred_juros_liq;
            if (cred_taxa_liq != null)
                value.cred_taxa_liq = cred_taxa_liq;
            if (cred_situacao != null)
                value.cred_situacao = cred_situacao;
            if (cred_cpf_cadastro != null)
                value.cred_cpf_cadastro = cred_cpf_cadastro;
            if (cred_dt_alteracao != null)
                value.cred_dt_alteracao = cred_dt_alteracao;
            if (cred_cpf_alteracao != null)
                value.cred_cpf_alteracao = cred_cpf_alteracao;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv;
            if (venda_id != null)
                value.venda_id = venda_id;
            if (venda_data != null)
                value.venda_data = venda_data;
            if (rec_id != null)
                value.rec_id = rec_id.Value;
            return value;
        }

        public tb_crediario_finalizadora Createtb_crediario_finalizadora(Int32? cred_id = null, Int32? uneg_id = null, Int32? venda_pdv = null, Int32? crpgto_id = null, DateTime? crpgto_data = null, Nullable<Decimal> crpgto_valor = null, Nullable<Int32> crpgto_atendente = null, Nullable<Int32> crpgto_operadorCX = null, Nullable<Int32> final_id = null, Nullable<Int32> subfin_id = null, Nullable<Decimal> crpgto_troco = null, Nullable<DateTime> crpgto_cli_data_ch = null, Nullable<Int32> crpgto_cli_banco_id_ch = null, Nullable<Decimal> crpgto_cli_agencia_ch = null, Nullable<Decimal> crpgto_cli_c1_ch = null, Nullable<Decimal> crpgto_cli_conta_corrente_ch = null, Nullable<Decimal> crpgto_cli_c2_ch = null, Nullable<Decimal> crpgto_cli_numero_ch = null, Nullable<Decimal> crpgto_cli_c3_ch = null, Nullable<Int32> prazo_id = null, Nullable<Int32> cheqrec_id = null, Nullable<Int32> bcaixa_id = null)
        {
            tb_crediario_finalizadora value = CreateObject<tb_crediario_finalizadora>();
            if (cred_id != null)
                value.cred_id = cred_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv.Value;
            if (crpgto_id != null)
                value.crpgto_id = crpgto_id.Value;
            if (crpgto_data != null)
                value.crpgto_data = crpgto_data.Value;
            if (crpgto_valor != null)
                value.crpgto_valor = crpgto_valor;
            if (crpgto_atendente != null)
                value.crpgto_atendente = crpgto_atendente;
            if (crpgto_operadorCX != null)
                value.crpgto_operadorCX = crpgto_operadorCX;
            if (final_id != null)
                value.final_id = final_id;
            if (subfin_id != null)
                value.subfin_id = subfin_id;
            if (crpgto_troco != null)
                value.crpgto_troco = crpgto_troco;
            if (crpgto_cli_data_ch != null)
                value.crpgto_cli_data_ch = crpgto_cli_data_ch;
            if (crpgto_cli_banco_id_ch != null)
                value.crpgto_cli_banco_id_ch = crpgto_cli_banco_id_ch;
            if (crpgto_cli_agencia_ch != null)
                value.crpgto_cli_agencia_ch = crpgto_cli_agencia_ch;
            if (crpgto_cli_c1_ch != null)
                value.crpgto_cli_c1_ch = crpgto_cli_c1_ch;
            if (crpgto_cli_conta_corrente_ch != null)
                value.crpgto_cli_conta_corrente_ch = crpgto_cli_conta_corrente_ch;
            if (crpgto_cli_c2_ch != null)
                value.crpgto_cli_c2_ch = crpgto_cli_c2_ch;
            if (crpgto_cli_numero_ch != null)
                value.crpgto_cli_numero_ch = crpgto_cli_numero_ch;
            if (crpgto_cli_c3_ch != null)
                value.crpgto_cli_c3_ch = crpgto_cli_c3_ch;
            if (prazo_id != null)
                value.prazo_id = prazo_id;
            if (cheqrec_id != null)
                value.cheqrec_id = cheqrec_id;
            if (bcaixa_id != null)
                value.bcaixa_id = bcaixa_id;
            return value;
        }

        public tb_crm Createtb_crm(Int32? crm_id = null, String crm_tipo = null, Int32? uf_id = null, String crm_nome = null, String crm_crm = null, String crm_email = null, String crm_sexo = null, Nullable<DateTime> crm_dt_nascimento = null, String crm_celular = null, String crm_obs = null, String crm_situacao = null, Nullable<DateTime> crm_dt_cadastro = null, Nullable<DateTime> crm_dt_alteracao = null, String crm_cpf_alteracao = null, Nullable<Int32> esp_id = null)
        {
            tb_crm value = CreateObject<tb_crm>();
            if (crm_id != null)
                value.crm_id = crm_id.Value;
            if (crm_tipo != null)
                value.crm_tipo = crm_tipo;
            if (uf_id != null)
                value.uf_id = uf_id.Value;
            if (crm_nome != null)
                value.crm_nome = crm_nome;
            if (crm_crm != null)
                value.crm_crm = crm_crm;
            if (crm_email != null)
                value.crm_email = crm_email;
            if (crm_sexo != null)
                value.crm_sexo = crm_sexo;
            if (crm_dt_nascimento != null)
                value.crm_dt_nascimento = crm_dt_nascimento;
            if (crm_celular != null)
                value.crm_celular = crm_celular;
            if (crm_obs != null)
                value.crm_obs = crm_obs;
            if (crm_situacao != null)
                value.crm_situacao = crm_situacao;
            if (crm_dt_cadastro != null)
                value.crm_dt_cadastro = crm_dt_cadastro;
            if (crm_dt_alteracao != null)
                value.crm_dt_alteracao = crm_dt_alteracao;
            if (crm_cpf_alteracao != null)
                value.crm_cpf_alteracao = crm_cpf_alteracao;
            if (esp_id != null)
                value.esp_id = esp_id;
            return value;
        }

        public tb_crm_endereco Createtb_crm_endereco(Int32? crm_end_id = null, Int32? crm_id = null, Int32? uf_id = null, String crm_tipo = null, String crm_end_tel = null, String crm_end_cep = null, String crm_end_tp_logradouro = null, String crm_end_nm_logradouro = null, Nullable<Int32> crm_end_numero = null, String crm_end_complemento = null, String crm_end_bairro = null, String crm_end_referencia = null, String crm_end_cidade = null, String crm_end_situacao = null, Nullable<DateTime> crm_end_dt_cadastro = null, Nullable<DateTime> crm_end_dt_alteracao = null, String crm_end_cpf_alteracao = null)
        {
            tb_crm_endereco value = CreateObject<tb_crm_endereco>();
            if (crm_end_id != null)
                value.crm_end_id = crm_end_id.Value;
            if (crm_id != null)
                value.crm_id = crm_id.Value;
            if (uf_id != null)
                value.uf_id = uf_id.Value;
            if (crm_tipo != null)
                value.crm_tipo = crm_tipo;
            if (crm_end_tel != null)
                value.crm_end_tel = crm_end_tel;
            if (crm_end_cep != null)
                value.crm_end_cep = crm_end_cep;
            if (crm_end_tp_logradouro != null)
                value.crm_end_tp_logradouro = crm_end_tp_logradouro;
            if (crm_end_nm_logradouro != null)
                value.crm_end_nm_logradouro = crm_end_nm_logradouro;
            if (crm_end_numero != null)
                value.crm_end_numero = crm_end_numero;
            if (crm_end_complemento != null)
                value.crm_end_complemento = crm_end_complemento;
            if (crm_end_bairro != null)
                value.crm_end_bairro = crm_end_bairro;
            if (crm_end_referencia != null)
                value.crm_end_referencia = crm_end_referencia;
            if (crm_end_cidade != null)
                value.crm_end_cidade = crm_end_cidade;
            if (crm_end_situacao != null)
                value.crm_end_situacao = crm_end_situacao;
            if (crm_end_dt_cadastro != null)
                value.crm_end_dt_cadastro = crm_end_dt_cadastro;
            if (crm_end_dt_alteracao != null)
                value.crm_end_dt_alteracao = crm_end_dt_alteracao;
            if (crm_end_cpf_alteracao != null)
                value.crm_end_cpf_alteracao = crm_end_cpf_alteracao;
            return value;
        }

        public tb_crm_especialidade Createtb_crm_especialidade(Int32? esp_id = null, String esp_descricao = null, String esp_situacao = null, Nullable<DateTime> esp_dt_cadastro = null, Nullable<DateTime> esp_dt_alteracao = null)
        {
            tb_crm_especialidade value = CreateObject<tb_crm_especialidade>();
            if (esp_id != null)
                value.esp_id = esp_id.Value;
            if (esp_descricao != null)
                value.esp_descricao = esp_descricao;
            if (esp_situacao != null)
                value.esp_situacao = esp_situacao;
            if (esp_dt_cadastro != null)
                value.esp_dt_cadastro = esp_dt_cadastro;
            if (esp_dt_alteracao != null)
                value.esp_dt_alteracao = esp_dt_alteracao;
            return value;
        }

        public tb_dav Createtb_dav(Int32? dav_id = null, DateTime? dav_data = null, DateTime? dav_data_emissao = null, Nullable<Int32> dav_numero = null, Nullable<Int32> dav_numero_controle = null, String ecf_numero_serie_emissao = null, Int32? dav_coo_emissao = null, Int32? dav_gnf_emissao = null, String dav_cpf_cnpj = null, String dav_nome_adquirente = null, Nullable<Int32> dav_num_ecf_venda = null, Nullable<Int32> dav_coo_venda = null, Nullable<Int32> dav_coo_cupom_vinculado_venda = null, String dav_titulo = null, Nullable<Decimal> dav_valor_total = null, String dav_status = null, String ecf_numero_serie_fechamento_cupom = null, String dav_md5 = null)
        {
            tb_dav value = CreateObject<tb_dav>();
            if (dav_id != null)
                value.dav_id = dav_id.Value;
            if (dav_data != null)
                value.dav_data = dav_data.Value;
            if (dav_data_emissao != null)
                value.dav_data_emissao = dav_data_emissao.Value;
            if (dav_numero != null)
                value.dav_numero = dav_numero;
            if (dav_numero_controle != null)
                value.dav_numero_controle = dav_numero_controle;
            if (ecf_numero_serie_emissao != null)
                value.ecf_numero_serie_emissao = ecf_numero_serie_emissao;
            if (dav_coo_emissao != null)
                value.dav_coo_emissao = dav_coo_emissao.Value;
            if (dav_gnf_emissao != null)
                value.dav_gnf_emissao = dav_gnf_emissao.Value;
            if (dav_cpf_cnpj != null)
                value.dav_cpf_cnpj = dav_cpf_cnpj;
            if (dav_nome_adquirente != null)
                value.dav_nome_adquirente = dav_nome_adquirente;
            if (dav_num_ecf_venda != null)
                value.dav_num_ecf_venda = dav_num_ecf_venda;
            if (dav_coo_venda != null)
                value.dav_coo_venda = dav_coo_venda;
            if (dav_coo_cupom_vinculado_venda != null)
                value.dav_coo_cupom_vinculado_venda = dav_coo_cupom_vinculado_venda;
            if (dav_titulo != null)
                value.dav_titulo = dav_titulo;
            if (dav_valor_total != null)
                value.dav_valor_total = dav_valor_total;
            if (dav_status != null)
                value.dav_status = dav_status;
            if (ecf_numero_serie_fechamento_cupom != null)
                value.ecf_numero_serie_fechamento_cupom = ecf_numero_serie_fechamento_cupom;
            if (dav_md5 != null)
                value.dav_md5 = dav_md5;
            return value;
        }

        public tb_dav_itens____ Createtb_dav_itens____(Int32? davi_id = null, String davi_codigo = null, String davi_descricao = null, Decimal? davi_quantidade = null, String davi_embalagem = null, Decimal? davi_valor_unitario = null, Decimal? davi_valor_desconto = null, Decimal? davi_valor_acrescimo = null, Decimal? davi_total_liquido = null, String davi_situacao_tributaria = null, Int32? davi_aliquota = null, String davi_indicador_cancelamento = null, Int32? davi_decimais_quantidade = null, Int32? davi_decimais_vlr_unitario = null)
        {
            tb_dav_itens____ value = CreateObject<tb_dav_itens____>();
            if (davi_id != null)
                value.davi_id = davi_id.Value;
            if (davi_codigo != null)
                value.davi_codigo = davi_codigo;
            if (davi_descricao != null)
                value.davi_descricao = davi_descricao;
            if (davi_quantidade != null)
                value.davi_quantidade = davi_quantidade.Value;
            if (davi_embalagem != null)
                value.davi_embalagem = davi_embalagem;
            if (davi_valor_unitario != null)
                value.davi_valor_unitario = davi_valor_unitario.Value;
            if (davi_valor_desconto != null)
                value.davi_valor_desconto = davi_valor_desconto.Value;
            if (davi_valor_acrescimo != null)
                value.davi_valor_acrescimo = davi_valor_acrescimo.Value;
            if (davi_total_liquido != null)
                value.davi_total_liquido = davi_total_liquido.Value;
            if (davi_situacao_tributaria != null)
                value.davi_situacao_tributaria = davi_situacao_tributaria;
            if (davi_aliquota != null)
                value.davi_aliquota = davi_aliquota.Value;
            if (davi_indicador_cancelamento != null)
                value.davi_indicador_cancelamento = davi_indicador_cancelamento;
            if (davi_decimais_quantidade != null)
                value.davi_decimais_quantidade = davi_decimais_quantidade.Value;
            if (davi_decimais_vlr_unitario != null)
                value.davi_decimais_vlr_unitario = davi_decimais_vlr_unitario.Value;
            return value;
        }

        public tb_ecf Createtb_ecf(String ecf_numero_serie = null, Int32? ecf_numero_ecf = null, String ecf_versao_firmware = null, DateTime? ecf_data_instalacao_software_basico = null, String ecf_numero_usuario_atual = null, Nullable<Int32> ecf_qtdlinhas_guilhotina = null, Nullable<Int32> ecf_velocidade_porta = null, String ecf_situacao = null, Nullable<DateTime> ecf_dt_cadastro = null, Nullable<DateTime> ecf_dt_alteracao = null, String ecf_cpf_alteracao = null, Nullable<Int32> uneg_id = null)
        {
            tb_ecf value = CreateObject<tb_ecf>();
            if (ecf_numero_serie != null)
                value.ecf_numero_serie = ecf_numero_serie;
            if (ecf_numero_ecf != null)
                value.ecf_numero_ecf = ecf_numero_ecf.Value;
            if (ecf_versao_firmware != null)
                value.ecf_versao_firmware = ecf_versao_firmware;
            if (ecf_data_instalacao_software_basico != null)
                value.ecf_data_instalacao_software_basico = ecf_data_instalacao_software_basico.Value;
            if (ecf_numero_usuario_atual != null)
                value.ecf_numero_usuario_atual = ecf_numero_usuario_atual;
            if (ecf_qtdlinhas_guilhotina != null)
                value.ecf_qtdlinhas_guilhotina = ecf_qtdlinhas_guilhotina;
            if (ecf_velocidade_porta != null)
                value.ecf_velocidade_porta = ecf_velocidade_porta;
            if (ecf_situacao != null)
                value.ecf_situacao = ecf_situacao;
            if (ecf_dt_cadastro != null)
                value.ecf_dt_cadastro = ecf_dt_cadastro;
            if (ecf_dt_alteracao != null)
                value.ecf_dt_alteracao = ecf_dt_alteracao;
            if (ecf_cpf_alteracao != null)
                value.ecf_cpf_alteracao = ecf_cpf_alteracao;
            if (uneg_id != null)
                value.uneg_id = uneg_id;
            return value;
        }

        public tb_ecf_dd Createtb_ecf_dd(Int32? ecfd_id = null, DateTime? ecfd_dt_movimento = null, String ecfd_coo = null, String ecfd_gnf = null, String ecfd_grg = null, String ecfd_cdc = null, String ecfd_tipo = null, Decimal? ecfd_valor_pago = null, String ecfd_tipos_lancamento = null)
        {
            tb_ecf_dd value = CreateObject<tb_ecf_dd>();
            if (ecfd_id != null)
                value.ecfd_id = ecfd_id.Value;
            if (ecfd_dt_movimento != null)
                value.ecfd_dt_movimento = ecfd_dt_movimento.Value;
            if (ecfd_coo != null)
                value.ecfd_coo = ecfd_coo;
            if (ecfd_gnf != null)
                value.ecfd_gnf = ecfd_gnf;
            if (ecfd_grg != null)
                value.ecfd_grg = ecfd_grg;
            if (ecfd_cdc != null)
                value.ecfd_cdc = ecfd_cdc;
            if (ecfd_tipo != null)
                value.ecfd_tipo = ecfd_tipo;
            if (ecfd_valor_pago != null)
                value.ecfd_valor_pago = ecfd_valor_pago.Value;
            if (ecfd_tipos_lancamento != null)
                value.ecfd_tipos_lancamento = ecfd_tipos_lancamento;
            return value;
        }

        public tb_ecf_modelo Createtb_ecf_modelo(Int32? ecfm_id_marca = null, Int32? ecfm_id_modelo = null, Int32? ecfm_id_versao = null, String ecfm_tipo_ecf = null, String ecfm_desc_marca = null, String ecfm_desc_modelo = null, String ecfm_versao = null, Int32? ecfm_qtd_lacre_sl = null, Int32? ecfm_qtd_lacre_fab = null, Boolean? ecfm_mfd = null, Boolean? ecfm_lacre_mfd = null, String ecfm_ato_aprovacao = null, String ecfm_ato_registro = null, String ecfm_formato_num_fabricacao = null, Nullable<DateTime> ecfm_dt_cadastro = null, Nullable<DateTime> ecfm_dt_alteracao = null, String ecfm_cpf_alteracao = null)
        {
            tb_ecf_modelo value = CreateObject<tb_ecf_modelo>();
            if (ecfm_id_marca != null)
                value.ecfm_id_marca = ecfm_id_marca.Value;
            if (ecfm_id_modelo != null)
                value.ecfm_id_modelo = ecfm_id_modelo.Value;
            if (ecfm_id_versao != null)
                value.ecfm_id_versao = ecfm_id_versao.Value;
            if (ecfm_tipo_ecf != null)
                value.ecfm_tipo_ecf = ecfm_tipo_ecf;
            if (ecfm_desc_marca != null)
                value.ecfm_desc_marca = ecfm_desc_marca;
            if (ecfm_desc_modelo != null)
                value.ecfm_desc_modelo = ecfm_desc_modelo;
            if (ecfm_versao != null)
                value.ecfm_versao = ecfm_versao;
            if (ecfm_qtd_lacre_sl != null)
                value.ecfm_qtd_lacre_sl = ecfm_qtd_lacre_sl.Value;
            if (ecfm_qtd_lacre_fab != null)
                value.ecfm_qtd_lacre_fab = ecfm_qtd_lacre_fab.Value;
            if (ecfm_mfd != null)
                value.ecfm_mfd = ecfm_mfd.Value;
            if (ecfm_lacre_mfd != null)
                value.ecfm_lacre_mfd = ecfm_lacre_mfd.Value;
            if (ecfm_ato_aprovacao != null)
                value.ecfm_ato_aprovacao = ecfm_ato_aprovacao;
            if (ecfm_ato_registro != null)
                value.ecfm_ato_registro = ecfm_ato_registro;
            if (ecfm_formato_num_fabricacao != null)
                value.ecfm_formato_num_fabricacao = ecfm_formato_num_fabricacao;
            if (ecfm_dt_cadastro != null)
                value.ecfm_dt_cadastro = ecfm_dt_cadastro;
            if (ecfm_dt_alteracao != null)
                value.ecfm_dt_alteracao = ecfm_dt_alteracao;
            if (ecfm_cpf_alteracao != null)
                value.ecfm_cpf_alteracao = ecfm_cpf_alteracao;
            return value;
        }

        public tb_empresa_privatelabel Createtb_empresa_privatelabel(Int32? emplabel_id = null, String emplabel_nome = null, String emplabel_contato = null, String emplabel_telefones = null, Nullable<Decimal> emplabel_perc_comissao = null, String emplabel_situacao = null, Nullable<DateTime> emplabel_dt_cadastro = null, Nullable<DateTime> emplabel_dt_alteracao = null, Nullable<Decimal> emplabel_cpf_alteracao = null)
        {
            tb_empresa_privatelabel value = CreateObject<tb_empresa_privatelabel>();
            if (emplabel_id != null)
                value.emplabel_id = emplabel_id.Value;
            if (emplabel_nome != null)
                value.emplabel_nome = emplabel_nome;
            if (emplabel_contato != null)
                value.emplabel_contato = emplabel_contato;
            if (emplabel_telefones != null)
                value.emplabel_telefones = emplabel_telefones;
            if (emplabel_perc_comissao != null)
                value.emplabel_perc_comissao = emplabel_perc_comissao;
            if (emplabel_situacao != null)
                value.emplabel_situacao = emplabel_situacao;
            if (emplabel_dt_cadastro != null)
                value.emplabel_dt_cadastro = emplabel_dt_cadastro;
            if (emplabel_dt_alteracao != null)
                value.emplabel_dt_alteracao = emplabel_dt_alteracao;
            if (emplabel_cpf_alteracao != null)
                value.emplabel_cpf_alteracao = emplabel_cpf_alteracao;
            return value;
        }

        public tb_empresa_recarga Createtb_empresa_recarga(Int32? emprec_id = null, String emprec_nome = null, String emprec_contato = null, String emprec_telefones = null, Nullable<Decimal> emprec_perc_comissao = null, String emprec_situacao = null, Nullable<DateTime> emprec_dt_cadastro = null, Nullable<DateTime> emprec_dt_alteracao = null, Nullable<Decimal> emprec_cpf_alteracao = null)
        {
            tb_empresa_recarga value = CreateObject<tb_empresa_recarga>();
            if (emprec_id != null)
                value.emprec_id = emprec_id.Value;
            if (emprec_nome != null)
                value.emprec_nome = emprec_nome;
            if (emprec_contato != null)
                value.emprec_contato = emprec_contato;
            if (emprec_telefones != null)
                value.emprec_telefones = emprec_telefones;
            if (emprec_perc_comissao != null)
                value.emprec_perc_comissao = emprec_perc_comissao;
            if (emprec_situacao != null)
                value.emprec_situacao = emprec_situacao;
            if (emprec_dt_cadastro != null)
                value.emprec_dt_cadastro = emprec_dt_cadastro;
            if (emprec_dt_alteracao != null)
                value.emprec_dt_alteracao = emprec_dt_alteracao;
            if (emprec_cpf_alteracao != null)
                value.emprec_cpf_alteracao = emprec_cpf_alteracao;
            return value;
        }

        public tb_entrega_arearisco Createtb_entrega_arearisco(Int32? arearisco_id = null, String arearisco_descricao = null, Nullable<Decimal> arearisco_cep_inicial = null, Nullable<Decimal> arearisco_cep_final = null, Nullable<Decimal> arearisco_nu_inicial = null, Nullable<Decimal> arearisco_nu_final = null, String arearisco_mensagem = null, Nullable<Decimal> arearisco_acao = null, String arearisco_situacao = null, Nullable<DateTime> arearisco_dt_cadastro = null, Nullable<DateTime> arearisco_dt_alteracao = null, Nullable<Decimal> arearisco_cpf_alteracao = null)
        {
            tb_entrega_arearisco value = CreateObject<tb_entrega_arearisco>();
            if (arearisco_id != null)
                value.arearisco_id = arearisco_id.Value;
            if (arearisco_descricao != null)
                value.arearisco_descricao = arearisco_descricao;
            if (arearisco_cep_inicial != null)
                value.arearisco_cep_inicial = arearisco_cep_inicial;
            if (arearisco_cep_final != null)
                value.arearisco_cep_final = arearisco_cep_final;
            if (arearisco_nu_inicial != null)
                value.arearisco_nu_inicial = arearisco_nu_inicial;
            if (arearisco_nu_final != null)
                value.arearisco_nu_final = arearisco_nu_final;
            if (arearisco_mensagem != null)
                value.arearisco_mensagem = arearisco_mensagem;
            if (arearisco_acao != null)
                value.arearisco_acao = arearisco_acao;
            if (arearisco_situacao != null)
                value.arearisco_situacao = arearisco_situacao;
            if (arearisco_dt_cadastro != null)
                value.arearisco_dt_cadastro = arearisco_dt_cadastro;
            if (arearisco_dt_alteracao != null)
                value.arearisco_dt_alteracao = arearisco_dt_alteracao;
            if (arearisco_cpf_alteracao != null)
                value.arearisco_cpf_alteracao = arearisco_cpf_alteracao;
            return value;
        }

        public tb_entrega_endereco Createtb_entrega_endereco(Int32? uneg_id = null, Int32? end_pdv = null, Int32? end_id = null, DateTime? end_data = null, Int64? end_telefone = null, Nullable<Int32> end_cep = null, String end_tp_logradouro = null, String end_nm_logradouro = null, Nullable<Int32> end_numero = null, String end_complemento = null, String end_bairro = null, String end_cidade = null, String end_referencia = null, String end_tipo = null, String end_latitude_decimais = null, String end_longitude_decimais = null, String end_situacao = null, Nullable<DateTime> end_dt_cadastro = null, Nullable<DateTime> end_dt_alteracao = null, String end_cpf_alteracao = null, Nullable<Int32> uf_id = null, Nullable<Int64> ibge_codigo = null, Nullable<Int32> polo_id = null, String end_contato = null, Nullable<Boolean> end_uso_continuo = null, String end_obs = null, Nullable<DateTime> end_dt_ultima_compra = null)
        {
            tb_entrega_endereco value = CreateObject<tb_entrega_endereco>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (end_pdv != null)
                value.end_pdv = end_pdv.Value;
            if (end_id != null)
                value.end_id = end_id.Value;
            if (end_data != null)
                value.end_data = end_data.Value;
            if (end_telefone != null)
                value.end_telefone = end_telefone.Value;
            if (end_cep != null)
                value.end_cep = end_cep;
            if (end_tp_logradouro != null)
                value.end_tp_logradouro = end_tp_logradouro;
            if (end_nm_logradouro != null)
                value.end_nm_logradouro = end_nm_logradouro;
            if (end_numero != null)
                value.end_numero = end_numero;
            if (end_complemento != null)
                value.end_complemento = end_complemento;
            if (end_bairro != null)
                value.end_bairro = end_bairro;
            if (end_cidade != null)
                value.end_cidade = end_cidade;
            if (end_referencia != null)
                value.end_referencia = end_referencia;
            if (end_tipo != null)
                value.end_tipo = end_tipo;
            if (end_latitude_decimais != null)
                value.end_latitude_decimais = end_latitude_decimais;
            if (end_longitude_decimais != null)
                value.end_longitude_decimais = end_longitude_decimais;
            if (end_situacao != null)
                value.end_situacao = end_situacao;
            if (end_dt_cadastro != null)
                value.end_dt_cadastro = end_dt_cadastro;
            if (end_dt_alteracao != null)
                value.end_dt_alteracao = end_dt_alteracao;
            if (end_cpf_alteracao != null)
                value.end_cpf_alteracao = end_cpf_alteracao;
            if (uf_id != null)
                value.uf_id = uf_id;
            if (ibge_codigo != null)
                value.ibge_codigo = ibge_codigo;
            if (polo_id != null)
                value.polo_id = polo_id;
            if (end_contato != null)
                value.end_contato = end_contato;
            if (end_uso_continuo != null)
                value.end_uso_continuo = end_uso_continuo;
            if (end_obs != null)
                value.end_obs = end_obs;
            if (end_dt_ultima_compra != null)
                value.end_dt_ultima_compra = end_dt_ultima_compra;
            return value;
        }

        public tb_entrega_polo Createtb_entrega_polo(Int32? polo_id = null, String polo_descricao = null, String polo_localizacao = null, String polo_situacao = null, Nullable<DateTime> polo_dt_cadastro = null, Nullable<DateTime> polo_dt_alteracao = null, Nullable<Decimal> polo_cpf_alteracao = null)
        {
            tb_entrega_polo value = CreateObject<tb_entrega_polo>();
            if (polo_id != null)
                value.polo_id = polo_id.Value;
            if (polo_descricao != null)
                value.polo_descricao = polo_descricao;
            if (polo_localizacao != null)
                value.polo_localizacao = polo_localizacao;
            if (polo_situacao != null)
                value.polo_situacao = polo_situacao;
            if (polo_dt_cadastro != null)
                value.polo_dt_cadastro = polo_dt_cadastro;
            if (polo_dt_alteracao != null)
                value.polo_dt_alteracao = polo_dt_alteracao;
            if (polo_cpf_alteracao != null)
                value.polo_cpf_alteracao = polo_cpf_alteracao;
            return value;
        }

        public tb_entrega_polo_bairro Createtb_entrega_polo_bairro(Int32? bairro_id = null, Int32? polo_id = null, String bairro_bairro = null, String bairro_municipio = null, String bairro_estado = null, String bairro_situacao = null, Nullable<DateTime> bairro_dt_cadastro = null, Nullable<DateTime> bairro_dt_alteracao = null, Nullable<Decimal> bairro_cpf_alteracao = null, Nullable<Int32> rota_id = null)
        {
            tb_entrega_polo_bairro value = CreateObject<tb_entrega_polo_bairro>();
            if (bairro_id != null)
                value.bairro_id = bairro_id.Value;
            if (polo_id != null)
                value.polo_id = polo_id.Value;
            if (bairro_bairro != null)
                value.bairro_bairro = bairro_bairro;
            if (bairro_municipio != null)
                value.bairro_municipio = bairro_municipio;
            if (bairro_estado != null)
                value.bairro_estado = bairro_estado;
            if (bairro_situacao != null)
                value.bairro_situacao = bairro_situacao;
            if (bairro_dt_cadastro != null)
                value.bairro_dt_cadastro = bairro_dt_cadastro;
            if (bairro_dt_alteracao != null)
                value.bairro_dt_alteracao = bairro_dt_alteracao;
            if (bairro_cpf_alteracao != null)
                value.bairro_cpf_alteracao = bairro_cpf_alteracao;
            if (rota_id != null)
                value.rota_id = rota_id;
            return value;
        }

        public tb_entrega_prod_continuo Createtb_entrega_prod_continuo(Int32? uneg_id = null, Int32? end_pdv = null, Int32? end_id = null, DateTime? end_data = null, Int32? pro_id = null, Nullable<DateTime> proc_dt_ultima_compra = null, Nullable<Decimal> proc_qt_ultima_compra = null, Nullable<Decimal> proc_pr_ultima_compra = null)
        {
            tb_entrega_prod_continuo value = CreateObject<tb_entrega_prod_continuo>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (end_pdv != null)
                value.end_pdv = end_pdv.Value;
            if (end_id != null)
                value.end_id = end_id.Value;
            if (end_data != null)
                value.end_data = end_data.Value;
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (proc_dt_ultima_compra != null)
                value.proc_dt_ultima_compra = proc_dt_ultima_compra;
            if (proc_qt_ultima_compra != null)
                value.proc_qt_ultima_compra = proc_qt_ultima_compra;
            if (proc_pr_ultima_compra != null)
                value.proc_pr_ultima_compra = proc_pr_ultima_compra;
            return value;
        }

        public tb_entrega_quadrante Createtb_entrega_quadrante(Int32? quadra_id = null, String quadra_coordenada = null, String quadra_situacao = null, Nullable<DateTime> quadra_dt_cadastro = null, Nullable<DateTime> quadra_dt_alteracao = null, Nullable<Decimal> quadra_cpf_alteracao = null)
        {
            tb_entrega_quadrante value = CreateObject<tb_entrega_quadrante>();
            if (quadra_id != null)
                value.quadra_id = quadra_id.Value;
            if (quadra_coordenada != null)
                value.quadra_coordenada = quadra_coordenada;
            if (quadra_situacao != null)
                value.quadra_situacao = quadra_situacao;
            if (quadra_dt_cadastro != null)
                value.quadra_dt_cadastro = quadra_dt_cadastro;
            if (quadra_dt_alteracao != null)
                value.quadra_dt_alteracao = quadra_dt_alteracao;
            if (quadra_cpf_alteracao != null)
                value.quadra_cpf_alteracao = quadra_cpf_alteracao;
            return value;
        }

        public tb_entrega_rota Createtb_entrega_rota(Int32? rota_id = null, Int32? quadra_id = null, String rota_descricao = null, String rota_situacao = null, Nullable<DateTime> rota_dt_cadastro = null, Nullable<DateTime> rota_dt_alteracao = null, Nullable<Decimal> rota_cpf_alteracao = null)
        {
            tb_entrega_rota value = CreateObject<tb_entrega_rota>();
            if (rota_id != null)
                value.rota_id = rota_id.Value;
            if (quadra_id != null)
                value.quadra_id = quadra_id.Value;
            if (rota_descricao != null)
                value.rota_descricao = rota_descricao;
            if (rota_situacao != null)
                value.rota_situacao = rota_situacao;
            if (rota_dt_cadastro != null)
                value.rota_dt_cadastro = rota_dt_cadastro;
            if (rota_dt_alteracao != null)
                value.rota_dt_alteracao = rota_dt_alteracao;
            if (rota_cpf_alteracao != null)
                value.rota_cpf_alteracao = rota_cpf_alteracao;
            return value;
        }

        public tb_entrega_rota_cep Createtb_entrega_rota_cep(Int32? cep_id = null, Int32? rota_id = null, Nullable<Decimal> cep_inicial = null, Nullable<Decimal> cep_final = null, Nullable<Decimal> cep_nu_inicial = null, Nullable<Decimal> cep_nu_final = null, String cep_situacao = null, Nullable<DateTime> cep_dt_cadastro = null, Nullable<DateTime> cep_dt_alteracao = null, Nullable<Decimal> cep_cpf_alteracao = null)
        {
            tb_entrega_rota_cep value = CreateObject<tb_entrega_rota_cep>();
            if (cep_id != null)
                value.cep_id = cep_id.Value;
            if (rota_id != null)
                value.rota_id = rota_id.Value;
            if (cep_inicial != null)
                value.cep_inicial = cep_inicial;
            if (cep_final != null)
                value.cep_final = cep_final;
            if (cep_nu_inicial != null)
                value.cep_nu_inicial = cep_nu_inicial;
            if (cep_nu_final != null)
                value.cep_nu_final = cep_nu_final;
            if (cep_situacao != null)
                value.cep_situacao = cep_situacao;
            if (cep_dt_cadastro != null)
                value.cep_dt_cadastro = cep_dt_cadastro;
            if (cep_dt_alteracao != null)
                value.cep_dt_alteracao = cep_dt_alteracao;
            if (cep_cpf_alteracao != null)
                value.cep_cpf_alteracao = cep_cpf_alteracao;
            return value;
        }

        public tb_finalizadora Createtb_finalizadora(Int32? final_id = null, String final_descricao = null, Nullable<Boolean> final_permite_troco = null, Nullable<Boolean> final_permite_sangria = null, Nullable<long> final_vlr_sangria_aviso = null, Nullable<Decimal> final_vlr_sangria_bloqueio = null, Nullable<Boolean> final_consulta_cli_tef = null, Nullable<Boolean> final_venda_tef = null, Nullable<Boolean> final_obriga_cliente = null, Nullable<Boolean> final_solicita_dados_ch = null, Nullable<Boolean> final_tipo_convenio = null, Nullable<Boolean> final_obriga_autenticacao = null, String final_tecla_atalho = null, Nullable<Boolean> final_db_folha = null, Nullable<Int32> final_emite_recibo = null, String final_situacao = null, String final_imagem = null, Nullable<DateTime> final_dt_cadastro = null, Nullable<DateTime> final_dt_alteracao = null)
        {
            tb_finalizadora value = CreateObject<tb_finalizadora>();
            if (final_id != null)
                value.final_id = final_id.Value;
            if (final_descricao != null)
                value.final_descricao = final_descricao;
            if (final_permite_troco != null)
                value.final_permite_troco = final_permite_troco;
            if (final_permite_sangria != null)
                value.final_permite_sangria = final_permite_sangria;
            if (final_vlr_sangria_aviso != null)
                value.final_vlr_sangria_aviso = final_vlr_sangria_aviso;
            if (final_vlr_sangria_bloqueio != null)
                value.final_vlr_sangria_bloqueio = final_vlr_sangria_bloqueio;
            if (final_consulta_cli_tef != null)
                value.final_consulta_cli_tef = final_consulta_cli_tef;
            if (final_venda_tef != null)
                value.final_venda_tef = final_venda_tef;
            if (final_obriga_cliente != null)
                value.final_obriga_cliente = final_obriga_cliente;
            if (final_solicita_dados_ch != null)
                value.final_solicita_dados_ch = final_solicita_dados_ch;
            if (final_tipo_convenio != null)
                value.final_tipo_convenio = final_tipo_convenio;
            if (final_obriga_autenticacao != null)
                value.final_obriga_autenticacao = final_obriga_autenticacao;
            if (final_tecla_atalho != null)
                value.final_tecla_atalho = final_tecla_atalho;
            if (final_db_folha != null)
                value.final_db_folha = final_db_folha;
            if (final_emite_recibo != null)
                value.final_emite_recibo = final_emite_recibo;
            if (final_situacao != null)
                value.final_situacao = final_situacao;
            if (final_imagem != null)
                value.final_imagem = final_imagem;
            if (final_dt_cadastro != null)
                value.final_dt_cadastro = final_dt_cadastro;
            if (final_dt_alteracao != null)
                value.final_dt_alteracao = final_dt_alteracao;
            return value;
        }

        public tb_finalizadora_sub Createtb_finalizadora_sub(Int32? finsub_id = null, Int32? final_id = null, String finsub_descricao = null, Nullable<Boolean> finsub_pratica_pmc = null, Nullable<Boolean> finsub_inibir_desconto = null, Nullable<Decimal> finsub_desc_maximo = null, Nullable<Decimal> finsub_tolerancia_dia = null, Nullable<Decimal> finsub_mora_diaria = null, Nullable<Decimal> finsub_taxa = null, String finsub_situacao = null, Nullable<DateTime> finsub_dt_cadastro = null, Nullable<DateTime> finsub_dt_alteracao = null, Nullable<Int32> finsub_taxa_evento = null, String finsub_tef_descricao = null, Nullable<Boolean> finsub_obriga_supervisor = null, Nullable<Boolean> finsub_permite_compra_saque = null)
        {
            tb_finalizadora_sub value = CreateObject<tb_finalizadora_sub>();
            if (finsub_id != null)
                value.finsub_id = finsub_id.Value;
            if (final_id != null)
                value.final_id = final_id.Value;
            if (finsub_descricao != null)
                value.finsub_descricao = finsub_descricao;
            if (finsub_pratica_pmc != null)
                value.finsub_pratica_pmc = finsub_pratica_pmc;
            if (finsub_inibir_desconto != null)
                value.finsub_inibir_desconto = finsub_inibir_desconto;
            if (finsub_desc_maximo != null)
                value.finsub_desc_maximo = finsub_desc_maximo;
            if (finsub_tolerancia_dia != null)
                value.finsub_tolerancia_dia = finsub_tolerancia_dia;
            if (finsub_mora_diaria != null)
                value.finsub_mora_diaria = finsub_mora_diaria;
            if (finsub_taxa != null)
                value.finsub_taxa = finsub_taxa;
            if (finsub_situacao != null)
                value.finsub_situacao = finsub_situacao;
            if (finsub_dt_cadastro != null)
                value.finsub_dt_cadastro = finsub_dt_cadastro;
            if (finsub_dt_alteracao != null)
                value.finsub_dt_alteracao = finsub_dt_alteracao;
            if (finsub_taxa_evento != null)
                value.finsub_taxa_evento = finsub_taxa_evento;
            if (finsub_tef_descricao != null)
                value.finsub_tef_descricao = finsub_tef_descricao;
            if (finsub_obriga_supervisor != null)
                value.finsub_obriga_supervisor = finsub_obriga_supervisor;
            if (finsub_permite_compra_saque != null)
                value.finsub_permite_compra_saque = finsub_permite_compra_saque;
            return value;
        }

        public tb_financeiro_administradora Createtb_financeiro_administradora(Int32? adm_id = null, String adm_nome = null, String adm_situacao = null, Nullable<DateTime> adm_dt_cadastro = null, Nullable<DateTime> adm_dt_alteracao = null)
        {
            tb_financeiro_administradora value = CreateObject<tb_financeiro_administradora>();
            if (adm_id != null)
                value.adm_id = adm_id.Value;
            if (adm_nome != null)
                value.adm_nome = adm_nome;
            if (adm_situacao != null)
                value.adm_situacao = adm_situacao;
            if (adm_dt_cadastro != null)
                value.adm_dt_cadastro = adm_dt_cadastro;
            if (adm_dt_alteracao != null)
                value.adm_dt_alteracao = adm_dt_alteracao;
            return value;
        }

        public tb_financeiro_bancos Createtb_financeiro_bancos(Int32? banco_id = null, Nullable<Decimal> banco_codigo = null, String banco_nome = null, String banco_tipo = null, String banco_situacao = null, Nullable<DateTime> banco_dt_cadastro = null, Nullable<DateTime> banco_dt_alteracao = null)
        {
            tb_financeiro_bancos value = CreateObject<tb_financeiro_bancos>();
            if (banco_id != null)
                value.banco_id = banco_id.Value;
            if (banco_codigo != null)
                value.banco_codigo = banco_codigo;
            if (banco_nome != null)
                value.banco_nome = banco_nome;
            if (banco_tipo != null)
                value.banco_tipo = banco_tipo;
            if (banco_situacao != null)
                value.banco_situacao = banco_situacao;
            if (banco_dt_cadastro != null)
                value.banco_dt_cadastro = banco_dt_cadastro;
            if (banco_dt_alteracao != null)
                value.banco_dt_alteracao = banco_dt_alteracao;
            return value;
        }

        public tb_financeiro_evento Createtb_financeiro_evento(Int32? eventf_id = null, String eventf_descricao = null, String eventf_tip_lancto = null, Nullable<Boolean> eventf_lanc_manual = null, Nullable<Boolean> eventf_exportar_uneg = null, String eventf_situacao = null, Nullable<DateTime> eventf_dt_cadastro = null, Nullable<DateTime> eventf_dt_alteracao = null, String eventf_cpf_alteracao = null, Nullable<Int32> grau1_id = null, Nullable<Int32> grau2_id = null, Nullable<Int32> grau3_id = null)
        {
            tb_financeiro_evento value = CreateObject<tb_financeiro_evento>();
            if (eventf_id != null)
                value.eventf_id = eventf_id.Value;
            if (eventf_descricao != null)
                value.eventf_descricao = eventf_descricao;
            if (eventf_tip_lancto != null)
                value.eventf_tip_lancto = eventf_tip_lancto;
            if (eventf_lanc_manual != null)
                value.eventf_lanc_manual = eventf_lanc_manual;
            if (eventf_exportar_uneg != null)
                value.eventf_exportar_uneg = eventf_exportar_uneg;
            if (eventf_situacao != null)
                value.eventf_situacao = eventf_situacao;
            if (eventf_dt_cadastro != null)
                value.eventf_dt_cadastro = eventf_dt_cadastro;
            if (eventf_dt_alteracao != null)
                value.eventf_dt_alteracao = eventf_dt_alteracao;
            if (eventf_cpf_alteracao != null)
                value.eventf_cpf_alteracao = eventf_cpf_alteracao;
            if (grau1_id != null)
                value.grau1_id = grau1_id;
            if (grau2_id != null)
                value.grau2_id = grau2_id;
            if (grau3_id != null)
                value.grau3_id = grau3_id;
            return value;
        }

        public tb_financeiro_prazo Createtb_financeiro_prazo(Int32? prazo_id = null, String prazo_titulo = null, Nullable<Decimal> prazo_tipo = null, Nullable<Decimal> prazo_qtd_meses = null, Nullable<Decimal> prazo_qtd_dias = null, Nullable<Decimal> prazo_fora_a = null, Nullable<Decimal> prazo_nu_parcelas = null, Nullable<Boolean> prazo_entrada = null, Nullable<Decimal> prazo_intervalo_dias = null, Nullable<Decimal> prazo_nu_retorno_tef = null, Nullable<Boolean> prazo_inibe_promocao = null, Nullable<Boolean> prazo_pratica_pmc = null, String prazo_situacao = null, Nullable<DateTime> prazo_dt_cadastro = null, Nullable<DateTime> prazo_dt_alteracao = null)
        {
            tb_financeiro_prazo value = CreateObject<tb_financeiro_prazo>();
            if (prazo_id != null)
                value.prazo_id = prazo_id.Value;
            if (prazo_titulo != null)
                value.prazo_titulo = prazo_titulo;
            if (prazo_tipo != null)
                value.prazo_tipo = prazo_tipo;
            if (prazo_qtd_meses != null)
                value.prazo_qtd_meses = prazo_qtd_meses;
            if (prazo_qtd_dias != null)
                value.prazo_qtd_dias = prazo_qtd_dias;
            if (prazo_fora_a != null)
                value.prazo_fora_a = prazo_fora_a;
            if (prazo_nu_parcelas != null)
                value.prazo_nu_parcelas = prazo_nu_parcelas;
            if (prazo_entrada != null)
                value.prazo_entrada = prazo_entrada;
            if (prazo_intervalo_dias != null)
                value.prazo_intervalo_dias = prazo_intervalo_dias;
            if (prazo_nu_retorno_tef != null)
                value.prazo_nu_retorno_tef = prazo_nu_retorno_tef;
            if (prazo_inibe_promocao != null)
                value.prazo_inibe_promocao = prazo_inibe_promocao;
            if (prazo_pratica_pmc != null)
                value.prazo_pratica_pmc = prazo_pratica_pmc;
            if (prazo_situacao != null)
                value.prazo_situacao = prazo_situacao;
            if (prazo_dt_cadastro != null)
                value.prazo_dt_cadastro = prazo_dt_cadastro;
            if (prazo_dt_alteracao != null)
                value.prazo_dt_alteracao = prazo_dt_alteracao;
            return value;
        }

        public tb_financeiro_sangria Createtb_financeiro_sangria(Int32? sangriaf_id = null, DateTime? sangriaf_data = null, Decimal? sangriaf_valor = null, String sangriaf_observacao = null, String sangriaf_cpf_responsavel = null, String sangriaf_status = null, String sangriaf_cpf_funcionario = null, Nullable<DateTime> sangriaf_dt_alteracao = null, String sangriaf_cpf_alteracao = null, String sangriaf_md5 = null)
        {
            tb_financeiro_sangria value = CreateObject<tb_financeiro_sangria>();
            if (sangriaf_id != null)
                value.sangriaf_id = sangriaf_id.Value;
            if (sangriaf_data != null)
                value.sangriaf_data = sangriaf_data.Value;
            if (sangriaf_valor != null)
                value.sangriaf_valor = sangriaf_valor.Value;
            if (sangriaf_observacao != null)
                value.sangriaf_observacao = sangriaf_observacao;
            if (sangriaf_cpf_responsavel != null)
                value.sangriaf_cpf_responsavel = sangriaf_cpf_responsavel;
            if (sangriaf_status != null)
                value.sangriaf_status = sangriaf_status;
            if (sangriaf_cpf_funcionario != null)
                value.sangriaf_cpf_funcionario = sangriaf_cpf_funcionario;
            if (sangriaf_dt_alteracao != null)
                value.sangriaf_dt_alteracao = sangriaf_dt_alteracao;
            if (sangriaf_cpf_alteracao != null)
                value.sangriaf_cpf_alteracao = sangriaf_cpf_alteracao;
            if (sangriaf_md5 != null)
                value.sangriaf_md5 = sangriaf_md5;
            return value;
        }

        public tb_financeiro_suprimento Createtb_financeiro_suprimento(Int32? suprimentof_id = null, DateTime? suprimentof_data = null, Decimal? suprimentof_valor = null, String suprimentof_observacao = null, String suprimentof_cpf_responsavel = null, String suprimentof_status = null, String suprimentof_cpf_funcionario = null, Nullable<DateTime> suprimentof_dt_alteracao = null, String suprimentof_cpf_alteracao = null, String suprimentof_md5 = null)
        {
            tb_financeiro_suprimento value = CreateObject<tb_financeiro_suprimento>();
            if (suprimentof_id != null)
                value.suprimentof_id = suprimentof_id.Value;
            if (suprimentof_data != null)
                value.suprimentof_data = suprimentof_data.Value;
            if (suprimentof_valor != null)
                value.suprimentof_valor = suprimentof_valor.Value;
            if (suprimentof_observacao != null)
                value.suprimentof_observacao = suprimentof_observacao;
            if (suprimentof_cpf_responsavel != null)
                value.suprimentof_cpf_responsavel = suprimentof_cpf_responsavel;
            if (suprimentof_status != null)
                value.suprimentof_status = suprimentof_status;
            if (suprimentof_cpf_funcionario != null)
                value.suprimentof_cpf_funcionario = suprimentof_cpf_funcionario;
            if (suprimentof_dt_alteracao != null)
                value.suprimentof_dt_alteracao = suprimentof_dt_alteracao;
            if (suprimentof_cpf_alteracao != null)
                value.suprimentof_cpf_alteracao = suprimentof_cpf_alteracao;
            if (suprimentof_md5 != null)
                value.suprimentof_md5 = suprimentof_md5;
            return value;
        }

        public tb_fornecedor Createtb_fornecedor(Int32? fab_id = null, Nullable<Decimal> fab_codigo = null, String fab_razao = null, String fab_fantasia = null, Nullable<Decimal> fab_fabricante = null, Nullable<Decimal> fab_tipo = null, String fab_nm_arq_envio = null, String fab_nm_arq_retorno = null, String fab_tip_prc_desc = null, String fab_layout_pedido = null, String fab_layout_dicionario = null, String fab_layout_preco = null, String fab_situacao = null, Nullable<DateTime> fab_dt_cadastro = null, Nullable<DateTime> fab_dt_alteracao = null)
        {
            tb_fornecedor value = CreateObject<tb_fornecedor>();
            if (fab_id != null)
                value.fab_id = fab_id.Value;
            if (fab_codigo != null)
                value.fab_codigo = fab_codigo;
            if (fab_razao != null)
                value.fab_razao = fab_razao;
            if (fab_fantasia != null)
                value.fab_fantasia = fab_fantasia;
            if (fab_fabricante != null)
                value.fab_fabricante = fab_fabricante;
            if (fab_tipo != null)
                value.fab_tipo = fab_tipo;
            if (fab_nm_arq_envio != null)
                value.fab_nm_arq_envio = fab_nm_arq_envio;
            if (fab_nm_arq_retorno != null)
                value.fab_nm_arq_retorno = fab_nm_arq_retorno;
            if (fab_tip_prc_desc != null)
                value.fab_tip_prc_desc = fab_tip_prc_desc;
            if (fab_layout_pedido != null)
                value.fab_layout_pedido = fab_layout_pedido;
            if (fab_layout_dicionario != null)
                value.fab_layout_dicionario = fab_layout_dicionario;
            if (fab_layout_preco != null)
                value.fab_layout_preco = fab_layout_preco;
            if (fab_situacao != null)
                value.fab_situacao = fab_situacao;
            if (fab_dt_cadastro != null)
                value.fab_dt_cadastro = fab_dt_cadastro;
            if (fab_dt_alteracao != null)
                value.fab_dt_alteracao = fab_dt_alteracao;
            return value;
        }

        public tb_fornecedor_divisao Createtb_fornecedor_divisao(Int32? fab_id = null, Int32? div_id = null, String div_nome = null, String div_tip_logradouro = null, String div_logradouro = null, Nullable<Decimal> div_numero = null, String div_complemento = null, String div_bairro = null, String div_cidade = null, Nullable<Decimal> div_cod_municipio = null, String div_cep = null, String div_uf = null, String div_ddd = null, String div_telefone = null, String div_ramal = null, String div_fax = null, String div_faxramal = null, String div_cnpj = null, Nullable<Decimal> div_insc_est = null, String div_nm_represent = null, String div_tel_represent = null, String div_email_represent = null, String div_nm_ger_regional = null, String div_tel_ger_regional = null, String div_email_ger_regional = null, String div_nm_ger_nacional = null, String div_tel_ger_nacional = null, String div_email_ger_nacional = null, String div_tipo_frete = null, Nullable<Decimal> div_cond_pgto = null, Nullable<Decimal> div_prazo_entrega = null, Nullable<Decimal> div_pedido_min = null, Nullable<Decimal> div_freq_compra = null, String div_situacao = null, Nullable<DateTime> div_dt_cadastro = null, Nullable<DateTime> div_dt_alteracao = null)
        {
            tb_fornecedor_divisao value = CreateObject<tb_fornecedor_divisao>();
            if (fab_id != null)
                value.fab_id = fab_id.Value;
            if (div_id != null)
                value.div_id = div_id.Value;
            if (div_nome != null)
                value.div_nome = div_nome;
            if (div_tip_logradouro != null)
                value.div_tip_logradouro = div_tip_logradouro;
            if (div_logradouro != null)
                value.div_logradouro = div_logradouro;
            if (div_numero != null)
                value.div_numero = div_numero;
            if (div_complemento != null)
                value.div_complemento = div_complemento;
            if (div_bairro != null)
                value.div_bairro = div_bairro;
            if (div_cidade != null)
                value.div_cidade = div_cidade;
            if (div_cod_municipio != null)
                value.div_cod_municipio = div_cod_municipio;
            if (div_cep != null)
                value.div_cep = div_cep;
            if (div_uf != null)
                value.div_uf = div_uf;
            if (div_ddd != null)
                value.div_ddd = div_ddd;
            if (div_telefone != null)
                value.div_telefone = div_telefone;
            if (div_ramal != null)
                value.div_ramal = div_ramal;
            if (div_fax != null)
                value.div_fax = div_fax;
            if (div_faxramal != null)
                value.div_faxramal = div_faxramal;
            if (div_cnpj != null)
                value.div_cnpj = div_cnpj;
            if (div_insc_est != null)
                value.div_insc_est = div_insc_est;
            if (div_nm_represent != null)
                value.div_nm_represent = div_nm_represent;
            if (div_tel_represent != null)
                value.div_tel_represent = div_tel_represent;
            if (div_email_represent != null)
                value.div_email_represent = div_email_represent;
            if (div_nm_ger_regional != null)
                value.div_nm_ger_regional = div_nm_ger_regional;
            if (div_tel_ger_regional != null)
                value.div_tel_ger_regional = div_tel_ger_regional;
            if (div_email_ger_regional != null)
                value.div_email_ger_regional = div_email_ger_regional;
            if (div_nm_ger_nacional != null)
                value.div_nm_ger_nacional = div_nm_ger_nacional;
            if (div_tel_ger_nacional != null)
                value.div_tel_ger_nacional = div_tel_ger_nacional;
            if (div_email_ger_nacional != null)
                value.div_email_ger_nacional = div_email_ger_nacional;
            if (div_tipo_frete != null)
                value.div_tipo_frete = div_tipo_frete;
            if (div_cond_pgto != null)
                value.div_cond_pgto = div_cond_pgto;
            if (div_prazo_entrega != null)
                value.div_prazo_entrega = div_prazo_entrega;
            if (div_pedido_min != null)
                value.div_pedido_min = div_pedido_min;
            if (div_freq_compra != null)
                value.div_freq_compra = div_freq_compra;
            if (div_situacao != null)
                value.div_situacao = div_situacao;
            if (div_dt_cadastro != null)
                value.div_dt_cadastro = div_dt_cadastro;
            if (div_dt_alteracao != null)
                value.div_dt_alteracao = div_dt_alteracao;
            return value;
        }

        public tb_funcionario Createtb_funcionario(Int32? func_id = null, String func_nome = null, Int32? func_matricula = null, String func_filiacao_mae = null, String func_filiacao_pai = null, Nullable<DateTime> func_dt_nascimento = null, String func_sexo = null, String func_estado_civil = null, Nullable<Decimal> func_nu_filhos = null, String func_cpf = null, String func_ident_numero = null, String func_ident_orgao_expedidor = null, Nullable<DateTime> func_ident_dt_expedicao = null, String func_ctps = null, String func_ctps_serie = null, Nullable<Decimal> func_pis_pasep = null, Nullable<DateTime> func_dt_admissao = null, Nullable<DateTime> func_dt_demissao = null, Nullable<Decimal> func_parente = null, String func_parente_nome = null, String func_end_cep = null, String func_end_tip_logradouro = null, String func_end_nm_logradouro = null, Nullable<Decimal> func_end_numero = null, String func_end_complemento = null, String func_end_bairro = null, String func_end_cidade = null, String func_end_uf = null, String func_end_referencia = null, Nullable<Decimal> func_tel_residen_area = null, Nullable<Decimal> func_tel_residen = null, Nullable<Decimal> func_tel_celular_area = null, Nullable<Decimal> func_tel_celular = null, String func_email = null, Nullable<Decimal> func_escolaridade = null, String func_cursos = null, String func_obs = null, Nullable<DateTime> func_ferias_contab_dt_inicial = null, Nullable<DateTime> func_ferias_contab_dt_final = null, Nullable<DateTime> func_ferias_real_dt_inicial = null, Nullable<DateTime> func_ferias_real_dt_final = null, Nullable<Decimal> func_cc_agencia = null, Nullable<Decimal> func_cc_numero = null, Nullable<Decimal> func_salario = null, Nullable<Decimal> func_quinzena = null, Nullable<Decimal> func_deducao_fixa = null, Nullable<Decimal> func_saldo_devedor = null, Nullable<Decimal> func_vale_limite = null, Nullable<Decimal> func_vale_acumulado = null, Nullable<Boolean> func_biometria_confirm = null, Byte[] func_biometria_image = null, Byte[] func_image = null, Byte[] func_biometria = null, Nullable<DateTime> func_dt_alteracao_sync = null, Nullable<DateTime> func_afastado_dt_inicial = null, Nullable<DateTime> func_afastado_dt_final = null, String func_situacao = null, Nullable<DateTime> func_dt_cadastro = null, Nullable<DateTime> func_dt_alteracao = null, Nullable<Boolean> func_biometria_nao = null)
        {
            tb_funcionario value = CreateObject<tb_funcionario>();
            if (func_id != null)
                value.func_id = func_id.Value;
            if (func_nome != null)
                value.func_nome = func_nome;
            if (func_matricula != null)
                value.func_matricula = func_matricula.Value;
            if (func_filiacao_mae != null)
                value.func_filiacao_mae = func_filiacao_mae;
            if (func_filiacao_pai != null)
                value.func_filiacao_pai = func_filiacao_pai;
            if (func_dt_nascimento != null)
                value.func_dt_nascimento = func_dt_nascimento;
            if (func_sexo != null)
                value.func_sexo = func_sexo;
            if (func_estado_civil != null)
                value.func_estado_civil = func_estado_civil;
            if (func_nu_filhos != null)
                value.func_nu_filhos = func_nu_filhos;
            if (func_cpf != null)
                value.func_cpf = func_cpf;
            if (func_ident_numero != null)
                value.func_ident_numero = func_ident_numero;
            if (func_ident_orgao_expedidor != null)
                value.func_ident_orgao_expedidor = func_ident_orgao_expedidor;
            if (func_ident_dt_expedicao != null)
                value.func_ident_dt_expedicao = func_ident_dt_expedicao;
            if (func_ctps != null)
                value.func_ctps = func_ctps;
            if (func_ctps_serie != null)
                value.func_ctps_serie = func_ctps_serie;
            if (func_pis_pasep != null)
                value.func_pis_pasep = func_pis_pasep;
            if (func_dt_admissao != null)
                value.func_dt_admissao = func_dt_admissao;
            if (func_dt_demissao != null)
                value.func_dt_demissao = func_dt_demissao;
            if (func_parente != null)
                value.func_parente = func_parente;
            if (func_parente_nome != null)
                value.func_parente_nome = func_parente_nome;
            if (func_end_cep != null)
                value.func_end_cep = func_end_cep;
            if (func_end_tip_logradouro != null)
                value.func_end_tip_logradouro = func_end_tip_logradouro;
            if (func_end_nm_logradouro != null)
                value.func_end_nm_logradouro = func_end_nm_logradouro;
            if (func_end_numero != null)
                value.func_end_numero = func_end_numero;
            if (func_end_complemento != null)
                value.func_end_complemento = func_end_complemento;
            if (func_end_bairro != null)
                value.func_end_bairro = func_end_bairro;
            if (func_end_cidade != null)
                value.func_end_cidade = func_end_cidade;
            if (func_end_uf != null)
                value.func_end_uf = func_end_uf;
            if (func_end_referencia != null)
                value.func_end_referencia = func_end_referencia;
            if (func_tel_residen_area != null)
                value.func_tel_residen_area = func_tel_residen_area;
            if (func_tel_residen != null)
                value.func_tel_residen = func_tel_residen;
            if (func_tel_celular_area != null)
                value.func_tel_celular_area = func_tel_celular_area;
            if (func_tel_celular != null)
                value.func_tel_celular = func_tel_celular;
            if (func_email != null)
                value.func_email = func_email;
            if (func_escolaridade != null)
                value.func_escolaridade = func_escolaridade;
            if (func_cursos != null)
                value.func_cursos = func_cursos;
            if (func_obs != null)
                value.func_obs = func_obs;
            if (func_ferias_contab_dt_inicial != null)
                value.func_ferias_contab_dt_inicial = func_ferias_contab_dt_inicial;
            if (func_ferias_contab_dt_final != null)
                value.func_ferias_contab_dt_final = func_ferias_contab_dt_final;
            if (func_ferias_real_dt_inicial != null)
                value.func_ferias_real_dt_inicial = func_ferias_real_dt_inicial;
            if (func_ferias_real_dt_final != null)
                value.func_ferias_real_dt_final = func_ferias_real_dt_final;
            if (func_cc_agencia != null)
                value.func_cc_agencia = func_cc_agencia;
            if (func_cc_numero != null)
                value.func_cc_numero = func_cc_numero;
            if (func_salario != null)
                value.func_salario = func_salario;
            if (func_quinzena != null)
                value.func_quinzena = func_quinzena;
            if (func_deducao_fixa != null)
                value.func_deducao_fixa = func_deducao_fixa;
            if (func_saldo_devedor != null)
                value.func_saldo_devedor = func_saldo_devedor;
            if (func_vale_limite != null)
                value.func_vale_limite = func_vale_limite;
            if (func_vale_acumulado != null)
                value.func_vale_acumulado = func_vale_acumulado;
            if (func_biometria_confirm != null)
                value.func_biometria_confirm = func_biometria_confirm;
            if (func_biometria_image != null)
                value.func_biometria_image = func_biometria_image;
            if (func_image != null)
                value.func_image = func_image;
            if (func_biometria != null)
                value.func_biometria = func_biometria;
            if (func_dt_alteracao_sync != null)
                value.func_dt_alteracao_sync = func_dt_alteracao_sync;
            if (func_afastado_dt_inicial != null)
                value.func_afastado_dt_inicial = func_afastado_dt_inicial;
            if (func_afastado_dt_final != null)
                value.func_afastado_dt_final = func_afastado_dt_final;
            if (func_situacao != null)
                value.func_situacao = func_situacao;
            if (func_dt_cadastro != null)
                value.func_dt_cadastro = func_dt_cadastro;
            if (func_dt_alteracao != null)
                value.func_dt_alteracao = func_dt_alteracao;
            if (func_biometria_nao != null)
                value.func_biometria_nao = func_biometria_nao;
            return value;
        }

        public tb_funcionario_horario Createtb_funcionario_horario(Int32? hora_id = null, String hora_titulo = null, Nullable<Boolean> hora_desc_dom = null, Nullable<Boolean> hora_desc_seg = null, Nullable<Boolean> hora_desc_ter = null, Nullable<Boolean> hora_desc_qua = null, Nullable<Boolean> hora_desc_qui = null, Nullable<Boolean> hora_desc_sex = null, Nullable<Boolean> hora_desc_sab = null, Nullable<Boolean> hora_desc_feriado = null, String hora_situacao = null, Nullable<DateTime> hora_dt_cadastro = null, Nullable<DateTime> hora_dt_alteracao = null, Nullable<Decimal> hora_cpf_alteracao = null)
        {
            tb_funcionario_horario value = CreateObject<tb_funcionario_horario>();
            if (hora_id != null)
                value.hora_id = hora_id.Value;
            if (hora_titulo != null)
                value.hora_titulo = hora_titulo;
            if (hora_desc_dom != null)
                value.hora_desc_dom = hora_desc_dom;
            if (hora_desc_seg != null)
                value.hora_desc_seg = hora_desc_seg;
            if (hora_desc_ter != null)
                value.hora_desc_ter = hora_desc_ter;
            if (hora_desc_qua != null)
                value.hora_desc_qua = hora_desc_qua;
            if (hora_desc_qui != null)
                value.hora_desc_qui = hora_desc_qui;
            if (hora_desc_sex != null)
                value.hora_desc_sex = hora_desc_sex;
            if (hora_desc_sab != null)
                value.hora_desc_sab = hora_desc_sab;
            if (hora_desc_feriado != null)
                value.hora_desc_feriado = hora_desc_feriado;
            if (hora_situacao != null)
                value.hora_situacao = hora_situacao;
            if (hora_dt_cadastro != null)
                value.hora_dt_cadastro = hora_dt_cadastro;
            if (hora_dt_alteracao != null)
                value.hora_dt_alteracao = hora_dt_alteracao;
            if (hora_cpf_alteracao != null)
                value.hora_cpf_alteracao = hora_cpf_alteracao;
            return value;
        }

        public tb_funcionario_horario_item Createtb_funcionario_horario_item(Int32? hora_id = null, String ihora_dia = null, String ihora_entrada = null, String ihora_almoco_saida = null, String ihora_almoco_retorno = null, String ihora_saida = null, String ihora_situacao = null, Nullable<DateTime> ihora_dt_cadastro = null, Nullable<DateTime> ihora_dt_alteracao = null, Nullable<Decimal> ihora_cpf_alteracao = null)
        {
            tb_funcionario_horario_item value = CreateObject<tb_funcionario_horario_item>();
            if (hora_id != null)
                value.hora_id = hora_id.Value;
            if (ihora_dia != null)
                value.ihora_dia = ihora_dia;
            if (ihora_entrada != null)
                value.ihora_entrada = ihora_entrada;
            if (ihora_almoco_saida != null)
                value.ihora_almoco_saida = ihora_almoco_saida;
            if (ihora_almoco_retorno != null)
                value.ihora_almoco_retorno = ihora_almoco_retorno;
            if (ihora_saida != null)
                value.ihora_saida = ihora_saida;
            if (ihora_situacao != null)
                value.ihora_situacao = ihora_situacao;
            if (ihora_dt_cadastro != null)
                value.ihora_dt_cadastro = ihora_dt_cadastro;
            if (ihora_dt_alteracao != null)
                value.ihora_dt_alteracao = ihora_dt_alteracao;
            if (ihora_cpf_alteracao != null)
                value.ihora_cpf_alteracao = ihora_cpf_alteracao;
            return value;
        }

        public tb_funcionario_visitante Createtb_funcionario_visitante(Int32? funcvisit_id = null, Nullable<DateTime> funcvisit_dt_visita = null, String funcvisit_situacao = null, Nullable<DateTime> funcvisit_dt_cadastro = null, Nullable<DateTime> funcvisit_dt_alteracao = null, Nullable<Int32> func_id = null)
        {
            tb_funcionario_visitante value = CreateObject<tb_funcionario_visitante>();
            if (funcvisit_id != null)
                value.funcvisit_id = funcvisit_id.Value;
            if (funcvisit_dt_visita != null)
                value.funcvisit_dt_visita = funcvisit_dt_visita;
            if (funcvisit_situacao != null)
                value.funcvisit_situacao = funcvisit_situacao;
            if (funcvisit_dt_cadastro != null)
                value.funcvisit_dt_cadastro = funcvisit_dt_cadastro;
            if (funcvisit_dt_alteracao != null)
                value.funcvisit_dt_alteracao = funcvisit_dt_alteracao;
            if (func_id != null)
                value.func_id = func_id;
            return value;
        }

        public tb_hist_sangria____ Createtb_hist_sangria____(Int32? hsang_id = null, DateTime? hsang_data = null, Decimal? hsang_cod_caixa = null, Nullable<Decimal> hsang_fund_dinh = null, Nullable<Decimal> hsang_sang_dinh = null, Nullable<Decimal> hsang_sang_cheq = null, Nullable<Decimal> hsang_sang_cheP = null, Nullable<Decimal> hsang_sang_carv = null, Nullable<Decimal> hsang_sang_carp = null, Nullable<Decimal> hsang_sang_dev = null, Nullable<Decimal> hsang_sang_canc = null, Nullable<Decimal> hsang_sang_cext = null, Nullable<Decimal> hsang_sang_desp = null, Nullable<Decimal> hsang_sang_conv = null, Nullable<Decimal> hsang_sang_outr = null, Nullable<Decimal> hsang_usr_respons = null)
        {
            tb_hist_sangria____ value = CreateObject<tb_hist_sangria____>();
            if (hsang_id != null)
                value.hsang_id = hsang_id.Value;
            if (hsang_data != null)
                value.hsang_data = hsang_data.Value;
            if (hsang_cod_caixa != null)
                value.hsang_cod_caixa = hsang_cod_caixa.Value;
            if (hsang_fund_dinh != null)
                value.hsang_fund_dinh = hsang_fund_dinh;
            if (hsang_sang_dinh != null)
                value.hsang_sang_dinh = hsang_sang_dinh;
            if (hsang_sang_cheq != null)
                value.hsang_sang_cheq = hsang_sang_cheq;
            if (hsang_sang_cheP != null)
                value.hsang_sang_cheP = hsang_sang_cheP;
            if (hsang_sang_carv != null)
                value.hsang_sang_carv = hsang_sang_carv;
            if (hsang_sang_carp != null)
                value.hsang_sang_carp = hsang_sang_carp;
            if (hsang_sang_dev != null)
                value.hsang_sang_dev = hsang_sang_dev;
            if (hsang_sang_canc != null)
                value.hsang_sang_canc = hsang_sang_canc;
            if (hsang_sang_cext != null)
                value.hsang_sang_cext = hsang_sang_cext;
            if (hsang_sang_desp != null)
                value.hsang_sang_desp = hsang_sang_desp;
            if (hsang_sang_conv != null)
                value.hsang_sang_conv = hsang_sang_conv;
            if (hsang_sang_outr != null)
                value.hsang_sang_outr = hsang_sang_outr;
            if (hsang_usr_respons != null)
                value.hsang_usr_respons = hsang_usr_respons;
            return value;
        }

        public tb_ibge Createtb_ibge(Int32? ibge_codigo = null, String ibge_municipio = null)
        {
            tb_ibge value = CreateObject<tb_ibge>();
            if (ibge_codigo != null)
                value.ibge_codigo = ibge_codigo.Value;
            if (ibge_municipio != null)
                value.ibge_municipio = ibge_municipio;
            return value;
        }

        public tb_ibpt_ax Createtb_ibpt_ax(Int64? iax_id = null, Nullable<Int32> iax_tabela = null, Nullable<Int32> iax_excecoes = null, Nullable<Decimal> iax_ncm = null, String iax_ncm_descricao_reduz = null, String iax_ncm_descricao = null, String iax_situacao = null, Nullable<DateTime> iax_data_alteracao = null, Nullable<long> iax_aliq_nacional = null, Nullable<long> iax_aliq_importado = null, Nullable<long> iax_aliq_estadual = null, Nullable<long> iax_aliq_municipal = null, Nullable<DateTime> iax_vigencia_inicio = null, Nullable<DateTime> iax_vigencia_fim = null, String iax_fonte = null, String iax_chave = null, String iax_versao = null)
        {
            tb_ibpt_ax value = CreateObject<tb_ibpt_ax>();
            if (iax_id != null)
                value.iax_id = iax_id.Value;
            if (iax_tabela != null)
                value.iax_tabela = iax_tabela;
            if (iax_excecoes != null)
                value.iax_excecoes = iax_excecoes;
            if (iax_ncm != null)
                value.iax_ncm = iax_ncm;
            if (iax_ncm_descricao_reduz != null)
                value.iax_ncm_descricao_reduz = iax_ncm_descricao_reduz;
            if (iax_ncm_descricao != null)
                value.iax_ncm_descricao = iax_ncm_descricao;
            if (iax_situacao != null)
                value.iax_situacao = iax_situacao;
            if (iax_data_alteracao != null)
                value.iax_data_alteracao = iax_data_alteracao;
            if (iax_aliq_nacional != null)
                value.iax_aliq_nacional = iax_aliq_nacional;
            if (iax_aliq_importado != null)
                value.iax_aliq_importado = iax_aliq_importado;
            if (iax_aliq_estadual != null)
                value.iax_aliq_estadual = iax_aliq_estadual;
            if (iax_aliq_municipal != null)
                value.iax_aliq_municipal = iax_aliq_municipal;
            if (iax_vigencia_inicio != null)
                value.iax_vigencia_inicio = iax_vigencia_inicio;
            if (iax_vigencia_fim != null)
                value.iax_vigencia_fim = iax_vigencia_fim;
            if (iax_fonte != null)
                value.iax_fonte = iax_fonte;
            if (iax_chave != null)
                value.iax_chave = iax_chave;
            if (iax_versao != null)
                value.iax_versao = iax_versao;
            return value;
        }

        public tb_lancto_financeiro Createtb_lancto_financeiro(Int32? uneg_id = null, Int32? lanctof_pdv = null, DateTime? lanctof_data = null, Int32? lanctof_id = null, Nullable<Decimal> lanctof_valor = null, String lanctof_observacao = null, Nullable<Decimal> lanctof_num_documento = null, Nullable<Int32> lanctof_responsavel = null, String lanctof_tipo_movimento = null, String lanctof_tipo_operacao = null, Nullable<Int32> lanctof_funcionario_id = null, Nullable<Int32> bancocx_id = null, Nullable<Int32> lanctof_operadorCX = null, String lanctof_md5 = null)
        {
            tb_lancto_financeiro value = CreateObject<tb_lancto_financeiro>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (lanctof_pdv != null)
                value.lanctof_pdv = lanctof_pdv.Value;
            if (lanctof_data != null)
                value.lanctof_data = lanctof_data.Value;
            if (lanctof_id != null)
                value.lanctof_id = lanctof_id.Value;
            if (lanctof_valor != null)
                value.lanctof_valor = lanctof_valor;
            if (lanctof_observacao != null)
                value.lanctof_observacao = lanctof_observacao;
            if (lanctof_num_documento != null)
                value.lanctof_num_documento = lanctof_num_documento;
            if (lanctof_responsavel != null)
                value.lanctof_responsavel = lanctof_responsavel;
            if (lanctof_tipo_movimento != null)
                value.lanctof_tipo_movimento = lanctof_tipo_movimento;
            if (lanctof_tipo_operacao != null)
                value.lanctof_tipo_operacao = lanctof_tipo_operacao;
            if (lanctof_funcionario_id != null)
                value.lanctof_funcionario_id = lanctof_funcionario_id;
            if (bancocx_id != null)
                value.bancocx_id = bancocx_id;
            if (lanctof_operadorCX != null)
                value.lanctof_operadorCX = lanctof_operadorCX;
            if (lanctof_md5 != null)
                value.lanctof_md5 = lanctof_md5;
            return value;
        }

        public tb_liquidacao_forma Createtb_liquidacao_forma(Int32? formaliq_id = null, String formaliq_descricao = null, Nullable<Decimal> formaliq_cpmf = null, String formaliq_tipo = null, String formaliq_infor_cheque = null, String formaliq_situacao = null, Nullable<DateTime> formaliq_dt_cadastro = null, Nullable<DateTime> formaliq_dt_alteracao = null)
        {
            tb_liquidacao_forma value = CreateObject<tb_liquidacao_forma>();
            if (formaliq_id != null)
                value.formaliq_id = formaliq_id.Value;
            if (formaliq_descricao != null)
                value.formaliq_descricao = formaliq_descricao;
            if (formaliq_cpmf != null)
                value.formaliq_cpmf = formaliq_cpmf;
            if (formaliq_tipo != null)
                value.formaliq_tipo = formaliq_tipo;
            if (formaliq_infor_cheque != null)
                value.formaliq_infor_cheque = formaliq_infor_cheque;
            if (formaliq_situacao != null)
                value.formaliq_situacao = formaliq_situacao;
            if (formaliq_dt_cadastro != null)
                value.formaliq_dt_cadastro = formaliq_dt_cadastro;
            if (formaliq_dt_alteracao != null)
                value.formaliq_dt_alteracao = formaliq_dt_alteracao;
            return value;
        }

        public tb_liquidacao_motivo Createtb_liquidacao_motivo(Int32? motivoliq_id = null, String motivoliq_descricao = null, String motivoliq_situacao = null, Nullable<DateTime> motivoliq_dt_cadastro = null, Nullable<DateTime> motivoliq_dt_alteracao = null)
        {
            tb_liquidacao_motivo value = CreateObject<tb_liquidacao_motivo>();
            if (motivoliq_id != null)
                value.motivoliq_id = motivoliq_id.Value;
            if (motivoliq_descricao != null)
                value.motivoliq_descricao = motivoliq_descricao;
            if (motivoliq_situacao != null)
                value.motivoliq_situacao = motivoliq_situacao;
            if (motivoliq_dt_cadastro != null)
                value.motivoliq_dt_cadastro = motivoliq_dt_cadastro;
            if (motivoliq_dt_alteracao != null)
                value.motivoliq_dt_alteracao = motivoliq_dt_alteracao;
            return value;
        }

        public tb_mvto_compra____ Createtb_mvto_compra____(Int32? cmp_id = null, Nullable<Decimal> cmp_num_nf = null, Nullable<DateTime> cmp_dt_entrada = null, Nullable<DateTime> cmp_dt_emissao = null, Nullable<Decimal> cmp_vlr_produtos = null, Nullable<Decimal> cmp_vlr_nota = null, Nullable<Decimal> cmp_vlr_informado = null, Nullable<Decimal> cmp_desc_comercial = null, Nullable<Decimal> cmp_desc_financeiro = null, Nullable<Decimal> cmp_vlr_frete = null, Nullable<Decimal> cmp_vlr_seguro = null, Nullable<Decimal> cmp_vlr_ipi = null, Nullable<Decimal> cmp_base_icms_st = null, Nullable<Decimal> cmp_vlr_icms_st = null, Nullable<Decimal> cmp_vlr_icms = null, Nullable<Decimal> cmp_base_icms = null, Nullable<Decimal> cmp_vlr_repasse = null, Nullable<Decimal> cmp_vlr_encargos = null, Nullable<Decimal> cmp_vlr_bonificacao = null, String cmp_observacao = null, Nullable<Boolean> cmp_duplicata = null, Nullable<Decimal> cmp_qtde_itens = null, Nullable<Decimal> cmp_cd_operador = null, String cmp_situacao = null, Nullable<DateTime> cmp_dt_alteracao = null, Nullable<Decimal> cmp_cpf_alteracao = null, Nullable<Int32> chkin_id = null)
        {
            tb_mvto_compra____ value = CreateObject<tb_mvto_compra____>();
            if (cmp_id != null)
                value.cmp_id = cmp_id.Value;
            if (cmp_num_nf != null)
                value.cmp_num_nf = cmp_num_nf;
            if (cmp_dt_entrada != null)
                value.cmp_dt_entrada = cmp_dt_entrada;
            if (cmp_dt_emissao != null)
                value.cmp_dt_emissao = cmp_dt_emissao;
            if (cmp_vlr_produtos != null)
                value.cmp_vlr_produtos = cmp_vlr_produtos;
            if (cmp_vlr_nota != null)
                value.cmp_vlr_nota = cmp_vlr_nota;
            if (cmp_vlr_informado != null)
                value.cmp_vlr_informado = cmp_vlr_informado;
            if (cmp_desc_comercial != null)
                value.cmp_desc_comercial = cmp_desc_comercial;
            if (cmp_desc_financeiro != null)
                value.cmp_desc_financeiro = cmp_desc_financeiro;
            if (cmp_vlr_frete != null)
                value.cmp_vlr_frete = cmp_vlr_frete;
            if (cmp_vlr_seguro != null)
                value.cmp_vlr_seguro = cmp_vlr_seguro;
            if (cmp_vlr_ipi != null)
                value.cmp_vlr_ipi = cmp_vlr_ipi;
            if (cmp_base_icms_st != null)
                value.cmp_base_icms_st = cmp_base_icms_st;
            if (cmp_vlr_icms_st != null)
                value.cmp_vlr_icms_st = cmp_vlr_icms_st;
            if (cmp_vlr_icms != null)
                value.cmp_vlr_icms = cmp_vlr_icms;
            if (cmp_base_icms != null)
                value.cmp_base_icms = cmp_base_icms;
            if (cmp_vlr_repasse != null)
                value.cmp_vlr_repasse = cmp_vlr_repasse;
            if (cmp_vlr_encargos != null)
                value.cmp_vlr_encargos = cmp_vlr_encargos;
            if (cmp_vlr_bonificacao != null)
                value.cmp_vlr_bonificacao = cmp_vlr_bonificacao;
            if (cmp_observacao != null)
                value.cmp_observacao = cmp_observacao;
            if (cmp_duplicata != null)
                value.cmp_duplicata = cmp_duplicata;
            if (cmp_qtde_itens != null)
                value.cmp_qtde_itens = cmp_qtde_itens;
            if (cmp_cd_operador != null)
                value.cmp_cd_operador = cmp_cd_operador;
            if (cmp_situacao != null)
                value.cmp_situacao = cmp_situacao;
            if (cmp_dt_alteracao != null)
                value.cmp_dt_alteracao = cmp_dt_alteracao;
            if (cmp_cpf_alteracao != null)
                value.cmp_cpf_alteracao = cmp_cpf_alteracao;
            if (chkin_id != null)
                value.chkin_id = chkin_id;
            return value;
        }

        public tb_mvto_compra_dup____ Createtb_mvto_compra_dup____(Int32? cmpdup_id = null, Nullable<Int32> cmpdup_numero = null, Nullable<DateTime> cmpdup_vencimento = null, Nullable<Decimal> cmpdup_valor = null, Nullable<Decimal> cmpdup_mora_dia = null, Nullable<Decimal> cmpdup_taxa = null, Nullable<DateTime> cmpdup_dt_antecipacao = null, Nullable<Decimal> cmpdup_vl_antecipacao = null, Nullable<Int64> cmpdup_NossoNumero = null)
        {
            tb_mvto_compra_dup____ value = CreateObject<tb_mvto_compra_dup____>();
            if (cmpdup_id != null)
                value.cmpdup_id = cmpdup_id.Value;
            if (cmpdup_numero != null)
                value.cmpdup_numero = cmpdup_numero;
            if (cmpdup_vencimento != null)
                value.cmpdup_vencimento = cmpdup_vencimento;
            if (cmpdup_valor != null)
                value.cmpdup_valor = cmpdup_valor;
            if (cmpdup_mora_dia != null)
                value.cmpdup_mora_dia = cmpdup_mora_dia;
            if (cmpdup_taxa != null)
                value.cmpdup_taxa = cmpdup_taxa;
            if (cmpdup_dt_antecipacao != null)
                value.cmpdup_dt_antecipacao = cmpdup_dt_antecipacao;
            if (cmpdup_vl_antecipacao != null)
                value.cmpdup_vl_antecipacao = cmpdup_vl_antecipacao;
            if (cmpdup_NossoNumero != null)
                value.cmpdup_NossoNumero = cmpdup_NossoNumero;
            return value;
        }

        public tb_mvto_compra_item____ Createtb_mvto_compra_item____(Int32? cmp_id = null, Int32? icmp_id = null, Nullable<Decimal> icmp_qtd_checkin = null, Nullable<Decimal> icmp_qtd_pedida = null, Nullable<Decimal> icmp_qtd_nota = null, Nullable<Decimal> icmp_custo_unit_ped = null, Nullable<Decimal> icmp_custo_unit_prod = null, Nullable<Decimal> icmp_custo_unit_nota = null, Nullable<Decimal> icmp_tot_custo_ped = null, Nullable<Decimal> icmp_tot_custo_prod = null, Nullable<Decimal> icmp_tot_custo_nota = null, Nullable<Decimal> icmp_qtd_bonificacao = null, Nullable<Decimal> icmp_vlr_bonificacao = null, Nullable<Decimal> icmp_aliq_ipi = null, Nullable<Decimal> icmp_vlr_ipi = null, Nullable<Decimal> icmp_base_icms = null, Nullable<Decimal> icmp_aliq_icms = null, Nullable<Decimal> icmp_vlr_icms = null, Nullable<Decimal> icmp_perc_encfin = null, Nullable<Decimal> icmp_vlr_encfin = null, Nullable<Decimal> icmp_perc_desconto = null, Nullable<Decimal> icmp_vlr_desconto = null, Nullable<Decimal> icmp_mar_icmsst = null, Nullable<Decimal> icmp_base_icmsst = null, Nullable<Decimal> icmp_aliq_icmsst = null, Nullable<Decimal> icmp_vlr_icmsst = null, Nullable<Decimal> icmp_vlr_frete = null, Nullable<Decimal> icmp_perc_descfin = null, Nullable<Decimal> icmp_vlr_descfin = null, Nullable<Decimal> icmp_perc_repassse = null, Nullable<Decimal> icmp_vlr_repassse = null, Nullable<Decimal> icmp_preco_sugerido = null, Nullable<Decimal> icmp_preco_alterado = null, Nullable<Int32> icmp_Num_Pedido = null)
        {
            tb_mvto_compra_item____ value = CreateObject<tb_mvto_compra_item____>();
            if (cmp_id != null)
                value.cmp_id = cmp_id.Value;
            if (icmp_id != null)
                value.icmp_id = icmp_id.Value;
            if (icmp_qtd_checkin != null)
                value.icmp_qtd_checkin = icmp_qtd_checkin;
            if (icmp_qtd_pedida != null)
                value.icmp_qtd_pedida = icmp_qtd_pedida;
            if (icmp_qtd_nota != null)
                value.icmp_qtd_nota = icmp_qtd_nota;
            if (icmp_custo_unit_ped != null)
                value.icmp_custo_unit_ped = icmp_custo_unit_ped;
            if (icmp_custo_unit_prod != null)
                value.icmp_custo_unit_prod = icmp_custo_unit_prod;
            if (icmp_custo_unit_nota != null)
                value.icmp_custo_unit_nota = icmp_custo_unit_nota;
            if (icmp_tot_custo_ped != null)
                value.icmp_tot_custo_ped = icmp_tot_custo_ped;
            if (icmp_tot_custo_prod != null)
                value.icmp_tot_custo_prod = icmp_tot_custo_prod;
            if (icmp_tot_custo_nota != null)
                value.icmp_tot_custo_nota = icmp_tot_custo_nota;
            if (icmp_qtd_bonificacao != null)
                value.icmp_qtd_bonificacao = icmp_qtd_bonificacao;
            if (icmp_vlr_bonificacao != null)
                value.icmp_vlr_bonificacao = icmp_vlr_bonificacao;
            if (icmp_aliq_ipi != null)
                value.icmp_aliq_ipi = icmp_aliq_ipi;
            if (icmp_vlr_ipi != null)
                value.icmp_vlr_ipi = icmp_vlr_ipi;
            if (icmp_base_icms != null)
                value.icmp_base_icms = icmp_base_icms;
            if (icmp_aliq_icms != null)
                value.icmp_aliq_icms = icmp_aliq_icms;
            if (icmp_vlr_icms != null)
                value.icmp_vlr_icms = icmp_vlr_icms;
            if (icmp_perc_encfin != null)
                value.icmp_perc_encfin = icmp_perc_encfin;
            if (icmp_vlr_encfin != null)
                value.icmp_vlr_encfin = icmp_vlr_encfin;
            if (icmp_perc_desconto != null)
                value.icmp_perc_desconto = icmp_perc_desconto;
            if (icmp_vlr_desconto != null)
                value.icmp_vlr_desconto = icmp_vlr_desconto;
            if (icmp_mar_icmsst != null)
                value.icmp_mar_icmsst = icmp_mar_icmsst;
            if (icmp_base_icmsst != null)
                value.icmp_base_icmsst = icmp_base_icmsst;
            if (icmp_aliq_icmsst != null)
                value.icmp_aliq_icmsst = icmp_aliq_icmsst;
            if (icmp_vlr_icmsst != null)
                value.icmp_vlr_icmsst = icmp_vlr_icmsst;
            if (icmp_vlr_frete != null)
                value.icmp_vlr_frete = icmp_vlr_frete;
            if (icmp_perc_descfin != null)
                value.icmp_perc_descfin = icmp_perc_descfin;
            if (icmp_vlr_descfin != null)
                value.icmp_vlr_descfin = icmp_vlr_descfin;
            if (icmp_perc_repassse != null)
                value.icmp_perc_repassse = icmp_perc_repassse;
            if (icmp_vlr_repassse != null)
                value.icmp_vlr_repassse = icmp_vlr_repassse;
            if (icmp_preco_sugerido != null)
                value.icmp_preco_sugerido = icmp_preco_sugerido;
            if (icmp_preco_alterado != null)
                value.icmp_preco_alterado = icmp_preco_alterado;
            if (icmp_Num_Pedido != null)
                value.icmp_Num_Pedido = icmp_Num_Pedido;
            return value;
        }

        public tb_mvto_compra_item_divergencia____ Createtb_mvto_compra_item_divergencia____(Int32? divicmp_id = null, Int32? pro_id = null, String divicmp_tipo = null, Nullable<Decimal> divicmp_qtde = null, Nullable<Decimal> divicmp_custo = null, String divicmp_justificativa = null)
        {
            tb_mvto_compra_item_divergencia____ value = CreateObject<tb_mvto_compra_item_divergencia____>();
            if (divicmp_id != null)
                value.divicmp_id = divicmp_id.Value;
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (divicmp_tipo != null)
                value.divicmp_tipo = divicmp_tipo;
            if (divicmp_qtde != null)
                value.divicmp_qtde = divicmp_qtde;
            if (divicmp_custo != null)
                value.divicmp_custo = divicmp_custo;
            if (divicmp_justificativa != null)
                value.divicmp_justificativa = divicmp_justificativa;
            return value;
        }

        public tb_mvto_compra_item_lote____ Createtb_mvto_compra_item_lote____(Int32? cmp_id = null, Int32? icmp_id = null, Int32? loteicmp_id = null, String loteicmp_numero = null, Nullable<Decimal> loteicmp_qtde = null, Nullable<DateTime> loteicmp_validade = null)
        {
            tb_mvto_compra_item_lote____ value = CreateObject<tb_mvto_compra_item_lote____>();
            if (cmp_id != null)
                value.cmp_id = cmp_id.Value;
            if (icmp_id != null)
                value.icmp_id = icmp_id.Value;
            if (loteicmp_id != null)
                value.loteicmp_id = loteicmp_id.Value;
            if (loteicmp_numero != null)
                value.loteicmp_numero = loteicmp_numero;
            if (loteicmp_qtde != null)
                value.loteicmp_qtde = loteicmp_qtde;
            if (loteicmp_validade != null)
                value.loteicmp_validade = loteicmp_validade;
            return value;
        }

        public tb_mvto_fin____ Createtb_mvto_fin____(Int32? mvtof_id = null, DateTime? mvtof_data = null, Decimal? mvtof_cod_caixa = null, Nullable<Decimal> mvtof_valor = null, Nullable<Decimal> mvtof_usr_respons = null, String mvtof_historico = null, Nullable<Decimal> mvtof_usr_mat = null)
        {
            tb_mvto_fin____ value = CreateObject<tb_mvto_fin____>();
            if (mvtof_id != null)
                value.mvtof_id = mvtof_id.Value;
            if (mvtof_data != null)
                value.mvtof_data = mvtof_data.Value;
            if (mvtof_cod_caixa != null)
                value.mvtof_cod_caixa = mvtof_cod_caixa.Value;
            if (mvtof_valor != null)
                value.mvtof_valor = mvtof_valor;
            if (mvtof_usr_respons != null)
                value.mvtof_usr_respons = mvtof_usr_respons;
            if (mvtof_historico != null)
                value.mvtof_historico = mvtof_historico;
            if (mvtof_usr_mat != null)
                value.mvtof_usr_mat = mvtof_usr_mat;
            return value;
        }

        public tb_nfe Createtb_nfe(Int32? uneg_id = null, Int32? nfe_pdv = null, Int32? nfe_id = null, DateTime? nfe_data = null, Nullable<Int32> nfe_id_vendedor = null, Nullable<Int32> nfe_id_atendente = null, Nullable<Int32> nfe_id_cancelado = null, String nfe_chave_acesso = null, String nfe_situacao = null, String nfe_uf_origem = null, String nfe_uf_destino = null, Nullable<Decimal> nfe_numero = null, Nullable<Decimal> nfe_cfop = null, Nullable<Decimal> nfe_nat_operacao = null, String nfe_modelo = null, Nullable<Decimal> nfe_serie = null, String nfe_tipo = null, Nullable<Decimal> nfe_cod_municipio = null, String nfe_data_saida = null, String nfe_hora_saida = null, Nullable<Int32> nfe_itens_produto = null, Nullable<Decimal> nfe_qtd_produto = null, Nullable<Decimal> nfe_total_venda = null, Nullable<Decimal> nfe_total_venda_padrao = null, Nullable<Decimal> nfe_total_venda_praticado = null, Nullable<Decimal> nfe_total_venda_real = null, Nullable<Decimal> nfe_total_custo = null, Nullable<Decimal> nfe_total_bonificado = null, Nullable<Decimal> nfe_total_comissao = null, Nullable<Decimal> nfe_desc_comercial = null, Nullable<Decimal> nfe_desc_financeiro = null, Nullable<Decimal> nfe_icmstot_vbc = null, Nullable<Decimal> nfe_icmstot_vicms = null, Nullable<Decimal> nfe_icmstot_vst = null, Nullable<Decimal> nfe_icmstot_vprod = null, Nullable<Decimal> nfe_icmstot_vfrete = null, Nullable<Decimal> nfe_icmstot_vseg = null, Nullable<Decimal> nfe_icmstot_vdesc = null, Nullable<Decimal> nfe_icmstot_vii = null, Nullable<Decimal> nfe_icmstot_vipi = null, Nullable<Decimal> nfe_icmstot_vpis = null, Nullable<Decimal> nfe_icmstot_vcofins = null, Nullable<Decimal> nfe_icmstot_voutros = null, Nullable<Decimal> nfe_icmstot_vnf = null, Nullable<Decimal> nfe_vlr_totaltrib = null, Nullable<Decimal> nfe_issqntot_vserv = null, Nullable<Decimal> nfe_issqntot_vbc = null, Nullable<Decimal> nfe_issqntot_viss = null, Nullable<Decimal> nfe_issqntot_vpis = null, Nullable<Decimal> nfe_issqntot_vcofins = null, Nullable<Decimal> nfe_rettrib_vretpis = null, Nullable<Decimal> nfe_rettrib_vretcofins = null, Nullable<Decimal> nfe_rettrib_vretcsll = null, Nullable<Decimal> nfe_rettrib_vbcirrf = null, Nullable<Decimal> nfe_rettrib_virrf = null, Nullable<Decimal> nfe_rettrib_vbcretprev = null, Nullable<Decimal> nfe_rettrib_vretprev = null, Nullable<Decimal> nfe_vlr_isento = null, String nfe_nf_obs = null, String nfe_tip_frete = null, String nfe_destino = null, Nullable<Decimal> nfe_peso_l = null, Nullable<Decimal> nfe_peso_b = null, String nfe_placa_veiculo = null, Nullable<Decimal> nfe_transportadora = null, String nfe_dispositivo = null, String nfe_refecf_mod = null, Nullable<Int32> nfe_refecf_necf = null, Nullable<Int32> nfe_refecf_coo = null, Nullable<Int32> transp_id = null, Nullable<Int32> pedv_id = null, Nullable<Int64> cli_id = null, Nullable<Int32> cnv_id = null, Nullable<Int32> serient_id = null, Nullable<Int32> enft_id = null, Nullable<Int32> venda_ecf_pdv = null, Nullable<Int32> venda_ecf_id = null, Nullable<DateTime> venda_ecf_data = null)
        {
            tb_nfe value = CreateObject<tb_nfe>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (nfe_pdv != null)
                value.nfe_pdv = nfe_pdv.Value;
            if (nfe_id != null)
                value.nfe_id = nfe_id.Value;
            if (nfe_data != null)
                value.nfe_data = nfe_data.Value;
            if (nfe_id_vendedor != null)
                value.nfe_id_vendedor = nfe_id_vendedor;
            if (nfe_id_atendente != null)
                value.nfe_id_atendente = nfe_id_atendente;
            if (nfe_id_cancelado != null)
                value.nfe_id_cancelado = nfe_id_cancelado;
            if (nfe_chave_acesso != null)
                value.nfe_chave_acesso = nfe_chave_acesso;
            if (nfe_situacao != null)
                value.nfe_situacao = nfe_situacao;
            if (nfe_uf_origem != null)
                value.nfe_uf_origem = nfe_uf_origem;
            if (nfe_uf_destino != null)
                value.nfe_uf_destino = nfe_uf_destino;
            if (nfe_numero != null)
                value.nfe_numero = nfe_numero;
            if (nfe_cfop != null)
                value.nfe_cfop = nfe_cfop;
            if (nfe_nat_operacao != null)
                value.nfe_nat_operacao = nfe_nat_operacao;
            if (nfe_modelo != null)
                value.nfe_modelo = nfe_modelo;
            if (nfe_serie != null)
                value.nfe_serie = nfe_serie;
            if (nfe_tipo != null)
                value.nfe_tipo = nfe_tipo;
            if (nfe_cod_municipio != null)
                value.nfe_cod_municipio = nfe_cod_municipio;
            if (nfe_data_saida != null)
                value.nfe_data_saida = nfe_data_saida;
            if (nfe_hora_saida != null)
                value.nfe_hora_saida = nfe_hora_saida;
            if (nfe_itens_produto != null)
                value.nfe_itens_produto = nfe_itens_produto;
            if (nfe_qtd_produto != null)
                value.nfe_qtd_produto = nfe_qtd_produto;
            if (nfe_total_venda != null)
                value.nfe_total_venda = nfe_total_venda;
            if (nfe_total_venda_padrao != null)
                value.nfe_total_venda_padrao = nfe_total_venda_padrao;
            if (nfe_total_venda_praticado != null)
                value.nfe_total_venda_praticado = nfe_total_venda_praticado;
            if (nfe_total_venda_real != null)
                value.nfe_total_venda_real = nfe_total_venda_real;
            if (nfe_total_custo != null)
                value.nfe_total_custo = nfe_total_custo;
            if (nfe_total_bonificado != null)
                value.nfe_total_bonificado = nfe_total_bonificado;
            if (nfe_total_comissao != null)
                value.nfe_total_comissao = nfe_total_comissao;
            if (nfe_desc_comercial != null)
                value.nfe_desc_comercial = nfe_desc_comercial;
            if (nfe_desc_financeiro != null)
                value.nfe_desc_financeiro = nfe_desc_financeiro;
            if (nfe_icmstot_vbc != null)
                value.nfe_icmstot_vbc = nfe_icmstot_vbc;
            if (nfe_icmstot_vicms != null)
                value.nfe_icmstot_vicms = nfe_icmstot_vicms;
            if (nfe_icmstot_vst != null)
                value.nfe_icmstot_vst = nfe_icmstot_vst;
            if (nfe_icmstot_vprod != null)
                value.nfe_icmstot_vprod = nfe_icmstot_vprod;
            if (nfe_icmstot_vfrete != null)
                value.nfe_icmstot_vfrete = nfe_icmstot_vfrete;
            if (nfe_icmstot_vseg != null)
                value.nfe_icmstot_vseg = nfe_icmstot_vseg;
            if (nfe_icmstot_vdesc != null)
                value.nfe_icmstot_vdesc = nfe_icmstot_vdesc;
            if (nfe_icmstot_vii != null)
                value.nfe_icmstot_vii = nfe_icmstot_vii;
            if (nfe_icmstot_vipi != null)
                value.nfe_icmstot_vipi = nfe_icmstot_vipi;
            if (nfe_icmstot_vpis != null)
                value.nfe_icmstot_vpis = nfe_icmstot_vpis;
            if (nfe_icmstot_vcofins != null)
                value.nfe_icmstot_vcofins = nfe_icmstot_vcofins;
            if (nfe_icmstot_voutros != null)
                value.nfe_icmstot_voutros = nfe_icmstot_voutros;
            if (nfe_icmstot_vnf != null)
                value.nfe_icmstot_vnf = nfe_icmstot_vnf;
            if (nfe_vlr_totaltrib != null)
                value.nfe_vlr_totaltrib = nfe_vlr_totaltrib;
            if (nfe_issqntot_vserv != null)
                value.nfe_issqntot_vserv = nfe_issqntot_vserv;
            if (nfe_issqntot_vbc != null)
                value.nfe_issqntot_vbc = nfe_issqntot_vbc;
            if (nfe_issqntot_viss != null)
                value.nfe_issqntot_viss = nfe_issqntot_viss;
            if (nfe_issqntot_vpis != null)
                value.nfe_issqntot_vpis = nfe_issqntot_vpis;
            if (nfe_issqntot_vcofins != null)
                value.nfe_issqntot_vcofins = nfe_issqntot_vcofins;
            if (nfe_rettrib_vretpis != null)
                value.nfe_rettrib_vretpis = nfe_rettrib_vretpis;
            if (nfe_rettrib_vretcofins != null)
                value.nfe_rettrib_vretcofins = nfe_rettrib_vretcofins;
            if (nfe_rettrib_vretcsll != null)
                value.nfe_rettrib_vretcsll = nfe_rettrib_vretcsll;
            if (nfe_rettrib_vbcirrf != null)
                value.nfe_rettrib_vbcirrf = nfe_rettrib_vbcirrf;
            if (nfe_rettrib_virrf != null)
                value.nfe_rettrib_virrf = nfe_rettrib_virrf;
            if (nfe_rettrib_vbcretprev != null)
                value.nfe_rettrib_vbcretprev = nfe_rettrib_vbcretprev;
            if (nfe_rettrib_vretprev != null)
                value.nfe_rettrib_vretprev = nfe_rettrib_vretprev;
            if (nfe_vlr_isento != null)
                value.nfe_vlr_isento = nfe_vlr_isento;
            if (nfe_nf_obs != null)
                value.nfe_nf_obs = nfe_nf_obs;
            if (nfe_tip_frete != null)
                value.nfe_tip_frete = nfe_tip_frete;
            if (nfe_destino != null)
                value.nfe_destino = nfe_destino;
            if (nfe_peso_l != null)
                value.nfe_peso_l = nfe_peso_l;
            if (nfe_peso_b != null)
                value.nfe_peso_b = nfe_peso_b;
            if (nfe_placa_veiculo != null)
                value.nfe_placa_veiculo = nfe_placa_veiculo;
            if (nfe_transportadora != null)
                value.nfe_transportadora = nfe_transportadora;
            if (nfe_dispositivo != null)
                value.nfe_dispositivo = nfe_dispositivo;
            if (nfe_refecf_mod != null)
                value.nfe_refecf_mod = nfe_refecf_mod;
            if (nfe_refecf_necf != null)
                value.nfe_refecf_necf = nfe_refecf_necf;
            if (nfe_refecf_coo != null)
                value.nfe_refecf_coo = nfe_refecf_coo;
            if (transp_id != null)
                value.transp_id = transp_id;
            if (pedv_id != null)
                value.pedv_id = pedv_id;
            if (cli_id != null)
                value.cli_id = cli_id;
            if (cnv_id != null)
                value.cnv_id = cnv_id;
            if (serient_id != null)
                value.serient_id = serient_id;
            if (enft_id != null)
                value.enft_id = enft_id;
            if (venda_ecf_pdv != null)
                value.venda_ecf_pdv = venda_ecf_pdv;
            if (venda_ecf_id != null)
                value.venda_ecf_id = venda_ecf_id;
            if (venda_ecf_data != null)
                value.venda_ecf_data = venda_ecf_data;
            return value;
        }

        public tb_nfe_cfop Createtb_nfe_cfop(Int32? uneg_id = null, Int32? nfe_pdv = null, Int32? nfe_id = null, DateTime? nfe_data = null, Int32? cfop_id = null, Nullable<Decimal> cfop_base_icms = null, Nullable<Decimal> cfop_aliq_icms = null, Nullable<Decimal> cfop_valor_icms = null)
        {
            tb_nfe_cfop value = CreateObject<tb_nfe_cfop>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (nfe_pdv != null)
                value.nfe_pdv = nfe_pdv.Value;
            if (nfe_id != null)
                value.nfe_id = nfe_id.Value;
            if (nfe_data != null)
                value.nfe_data = nfe_data.Value;
            if (cfop_id != null)
                value.cfop_id = cfop_id.Value;
            if (cfop_base_icms != null)
                value.cfop_base_icms = cfop_base_icms;
            if (cfop_aliq_icms != null)
                value.cfop_aliq_icms = cfop_aliq_icms;
            if (cfop_valor_icms != null)
                value.cfop_valor_icms = cfop_valor_icms;
            return value;
        }

        public tb_nfe_danfe Createtb_nfe_danfe(Int32? uneg_id = null, Int32? nfe_pdv = null, Int32? nfe_id = null, DateTime? nfe_data = null, String danfe_chave_acesso = null, String danfe_xml = null, String danfe_txt = null)
        {
            tb_nfe_danfe value = CreateObject<tb_nfe_danfe>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (nfe_pdv != null)
                value.nfe_pdv = nfe_pdv.Value;
            if (nfe_id != null)
                value.nfe_id = nfe_id.Value;
            if (nfe_data != null)
                value.nfe_data = nfe_data.Value;
            if (danfe_chave_acesso != null)
                value.danfe_chave_acesso = danfe_chave_acesso;
            if (danfe_xml != null)
                value.danfe_xml = danfe_xml;
            if (danfe_txt != null)
                value.danfe_txt = danfe_txt;
            return value;
        }

        public tb_nfe_finalizadora Createtb_nfe_finalizadora(Int32? uneg_id = null, Int32? nfe_pdv = null, Int32? nfe_id = null, DateTime? nfe_data = null, Int32? final_seq = null, Int32? final_id = null, Int32? subfin_id = null, Nullable<Int32> vpag_num_referencia = null, Nullable<Decimal> vpag_valor = null, Nullable<Decimal> vpag_troco = null, Nullable<Boolean> vpag_vendatef = null, Nullable<Decimal> vpag_valor_compra_saque = null, String vpag_tef_nsu_venda = null, String vpag_tef_nsu_host = null, String vpag_tipo_cartao = null, String vpag_comprovante_cliente = null, String vpag_comprovante_loja = null, String vpag_status = null, Nullable<DateTime> vpag_cli_data_ch = null, Nullable<Int32> vpag_cli_banco_id_ch = null, Nullable<Decimal> vpag_cli_agencia_ch = null, Nullable<Decimal> vpag_cli_c1_ch = null, Nullable<Decimal> vpag_cli_conta_corrente_ch = null, Nullable<Decimal> vpag_cli_c2_ch = null, Nullable<Decimal> vpag_cli_numero_ch = null, Nullable<Decimal> vpag_cli_c3_ch = null, String vpag_cli_doc_troca = null, Nullable<Int32> prazo_id = null, Nullable<Int32> cheqrec_id = null, Nullable<Int64> cli_id = null, Nullable<Int32> boleto_id = null, Nullable<Int32> bcaixa_id = null)
        {
            tb_nfe_finalizadora value = CreateObject<tb_nfe_finalizadora>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (nfe_pdv != null)
                value.nfe_pdv = nfe_pdv.Value;
            if (nfe_id != null)
                value.nfe_id = nfe_id.Value;
            if (nfe_data != null)
                value.nfe_data = nfe_data.Value;
            if (final_seq != null)
                value.final_seq = final_seq.Value;
            if (final_id != null)
                value.final_id = final_id.Value;
            if (subfin_id != null)
                value.subfin_id = subfin_id.Value;
            if (vpag_num_referencia != null)
                value.vpag_num_referencia = vpag_num_referencia;
            if (vpag_valor != null)
                value.vpag_valor = vpag_valor;
            if (vpag_troco != null)
                value.vpag_troco = vpag_troco;
            if (vpag_vendatef != null)
                value.vpag_vendatef = vpag_vendatef;
            if (vpag_valor_compra_saque != null)
                value.vpag_valor_compra_saque = vpag_valor_compra_saque;
            if (vpag_tef_nsu_venda != null)
                value.vpag_tef_nsu_venda = vpag_tef_nsu_venda;
            if (vpag_tef_nsu_host != null)
                value.vpag_tef_nsu_host = vpag_tef_nsu_host;
            if (vpag_tipo_cartao != null)
                value.vpag_tipo_cartao = vpag_tipo_cartao;
            if (vpag_comprovante_cliente != null)
                value.vpag_comprovante_cliente = vpag_comprovante_cliente;
            if (vpag_comprovante_loja != null)
                value.vpag_comprovante_loja = vpag_comprovante_loja;
            if (vpag_status != null)
                value.vpag_status = vpag_status;
            if (vpag_cli_data_ch != null)
                value.vpag_cli_data_ch = vpag_cli_data_ch;
            if (vpag_cli_banco_id_ch != null)
                value.vpag_cli_banco_id_ch = vpag_cli_banco_id_ch;
            if (vpag_cli_agencia_ch != null)
                value.vpag_cli_agencia_ch = vpag_cli_agencia_ch;
            if (vpag_cli_c1_ch != null)
                value.vpag_cli_c1_ch = vpag_cli_c1_ch;
            if (vpag_cli_conta_corrente_ch != null)
                value.vpag_cli_conta_corrente_ch = vpag_cli_conta_corrente_ch;
            if (vpag_cli_c2_ch != null)
                value.vpag_cli_c2_ch = vpag_cli_c2_ch;
            if (vpag_cli_numero_ch != null)
                value.vpag_cli_numero_ch = vpag_cli_numero_ch;
            if (vpag_cli_c3_ch != null)
                value.vpag_cli_c3_ch = vpag_cli_c3_ch;
            if (vpag_cli_doc_troca != null)
                value.vpag_cli_doc_troca = vpag_cli_doc_troca;
            if (prazo_id != null)
                value.prazo_id = prazo_id;
            if (cheqrec_id != null)
                value.cheqrec_id = cheqrec_id;
            if (cli_id != null)
                value.cli_id = cli_id;
            if (boleto_id != null)
                value.boleto_id = boleto_id;
            if (bcaixa_id != null)
                value.bcaixa_id = bcaixa_id;
            return value;
        }

        public tb_nfe_item Createtb_nfe_item(Int32? uneg_id = null, Int32? nfe_pdv = null, Int32? nfe_id = null, DateTime? nfe_data = null, Int32? infe_id = null, Nullable<Decimal> infe_qtd_checkin = null, Nullable<Decimal> infe_qtd_pedida = null, Nullable<Decimal> infe_qtd_nota = null, String infe_lote_numero = null, Nullable<DateTime> infe_lote_validade = null, Nullable<DateTime> infe_lote_fabricacao = null, Nullable<Decimal> infe_lote_vlr_pmc = null, Nullable<Decimal> infe_custo_unit_ped = null, Nullable<Decimal> infe_custo_unit_prod = null, Nullable<Decimal> infe_custo_unit_nota = null, Nullable<Decimal> infe_custo_unit_cont = null, Nullable<Decimal> infe_preco_padrao = null, Nullable<Decimal> infe_preco_praticado = null, Nullable<Decimal> infe_custo_medio = null, Nullable<Decimal> infe_tot_custo_ped = null, Nullable<Decimal> infe_tot_custo_prod = null, Nullable<Decimal> infe_tot_custo_nota = null, Nullable<Decimal> infe_tot_custo_cont = null, Nullable<Decimal> infe_tot_preco_padrao = null, Nullable<Decimal> infe_tot_preco_praticado = null, Nullable<Decimal> infe_tot_custo_medio = null, Nullable<Decimal> infe_qtd_bonificacao = null, Nullable<Decimal> infe_vlr_bonificacao = null, Nullable<Decimal> infe_vlr_encfin = null, Nullable<Decimal> infe_vlr_desconto = null, Nullable<Decimal> infe_vlr_frete = null, Nullable<Decimal> infe_vlr_descfin = null, Nullable<Decimal> infe_vlr_repassse = null, Nullable<Decimal> infe_vlr_comissao = null, Nullable<Int32> infe_Num_Pedido = null, Nullable<Int32> infe_icms_orig = null, Nullable<Int32> infe_icms_cst = null, Nullable<Int32> infe_icms_modbc = null, Nullable<Decimal> infe_icms_predbc = null, Nullable<Decimal> infe_icms_vbc = null, Nullable<Decimal> infe_icms_picms = null, Nullable<Decimal> infe_icms_vicms = null, Nullable<Int32> infe_icms_modbst = null, Nullable<Decimal> infe_icms_pmvast = null, Nullable<Decimal> infe_icms_predbcst = null, Nullable<Decimal> infe_icms_vbcst = null, Nullable<Decimal> infe_icms_picmsst = null, Nullable<Decimal> infe_icms_vicmsst = null, Nullable<Decimal> infe_icms_vbstret = null, Nullable<Decimal> infe_icms_vicmsstret = null, Nullable<Decimal> infe_qcom = null, Nullable<Decimal> infe_vuncom = null, Nullable<Decimal> infe_vprod = null, Nullable<Decimal> infe_vdesc = null, Nullable<Decimal> infe_vprodcont = null, Nullable<Int32> infe_ipi_cenq = null, Nullable<Int32> infe_ipi_cst = null, Nullable<Decimal> infe_ipi_pipi = null, Nullable<Decimal> infe_ipi_vipi = null, Nullable<Int32> infe_pis_cst = null, Nullable<Decimal> infe_pis_vbcpis = null, Nullable<Decimal> infe_pis_ppis = null, Nullable<Decimal> infe_pis_vpis = null, Nullable<Int32> infe_cofins_cst = null, Nullable<Decimal> infe_cofins_vbccofins = null, Nullable<Decimal> infe_cofins_pcofins = null, Nullable<Decimal> infe_cofins_vcofiins = null, Nullable<Decimal> infe_voutro = null, Nullable<Decimal> infe_vdescfin = null)
        {
            tb_nfe_item value = CreateObject<tb_nfe_item>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (nfe_pdv != null)
                value.nfe_pdv = nfe_pdv.Value;
            if (nfe_id != null)
                value.nfe_id = nfe_id.Value;
            if (nfe_data != null)
                value.nfe_data = nfe_data.Value;
            if (infe_id != null)
                value.infe_id = infe_id.Value;
            if (infe_qtd_checkin != null)
                value.infe_qtd_checkin = infe_qtd_checkin;
            if (infe_qtd_pedida != null)
                value.infe_qtd_pedida = infe_qtd_pedida;
            if (infe_qtd_nota != null)
                value.infe_qtd_nota = infe_qtd_nota;
            if (infe_lote_numero != null)
                value.infe_lote_numero = infe_lote_numero;
            if (infe_lote_validade != null)
                value.infe_lote_validade = infe_lote_validade;
            if (infe_lote_fabricacao != null)
                value.infe_lote_fabricacao = infe_lote_fabricacao;
            if (infe_lote_vlr_pmc != null)
                value.infe_lote_vlr_pmc = infe_lote_vlr_pmc;
            if (infe_custo_unit_ped != null)
                value.infe_custo_unit_ped = infe_custo_unit_ped;
            if (infe_custo_unit_prod != null)
                value.infe_custo_unit_prod = infe_custo_unit_prod;
            if (infe_custo_unit_nota != null)
                value.infe_custo_unit_nota = infe_custo_unit_nota;
            if (infe_custo_unit_cont != null)
                value.infe_custo_unit_cont = infe_custo_unit_cont;
            if (infe_preco_padrao != null)
                value.infe_preco_padrao = infe_preco_padrao;
            if (infe_preco_praticado != null)
                value.infe_preco_praticado = infe_preco_praticado;
            if (infe_custo_medio != null)
                value.infe_custo_medio = infe_custo_medio;
            if (infe_tot_custo_ped != null)
                value.infe_tot_custo_ped = infe_tot_custo_ped;
            if (infe_tot_custo_prod != null)
                value.infe_tot_custo_prod = infe_tot_custo_prod;
            if (infe_tot_custo_nota != null)
                value.infe_tot_custo_nota = infe_tot_custo_nota;
            if (infe_tot_custo_cont != null)
                value.infe_tot_custo_cont = infe_tot_custo_cont;
            if (infe_tot_preco_padrao != null)
                value.infe_tot_preco_padrao = infe_tot_preco_padrao;
            if (infe_tot_preco_praticado != null)
                value.infe_tot_preco_praticado = infe_tot_preco_praticado;
            if (infe_tot_custo_medio != null)
                value.infe_tot_custo_medio = infe_tot_custo_medio;
            if (infe_qtd_bonificacao != null)
                value.infe_qtd_bonificacao = infe_qtd_bonificacao;
            if (infe_vlr_bonificacao != null)
                value.infe_vlr_bonificacao = infe_vlr_bonificacao;
            if (infe_vlr_encfin != null)
                value.infe_vlr_encfin = infe_vlr_encfin;
            if (infe_vlr_desconto != null)
                value.infe_vlr_desconto = infe_vlr_desconto;
            if (infe_vlr_frete != null)
                value.infe_vlr_frete = infe_vlr_frete;
            if (infe_vlr_descfin != null)
                value.infe_vlr_descfin = infe_vlr_descfin;
            if (infe_vlr_repassse != null)
                value.infe_vlr_repassse = infe_vlr_repassse;
            if (infe_vlr_comissao != null)
                value.infe_vlr_comissao = infe_vlr_comissao;
            if (infe_Num_Pedido != null)
                value.infe_Num_Pedido = infe_Num_Pedido;
            if (infe_icms_orig != null)
                value.infe_icms_orig = infe_icms_orig;
            if (infe_icms_cst != null)
                value.infe_icms_cst = infe_icms_cst;
            if (infe_icms_modbc != null)
                value.infe_icms_modbc = infe_icms_modbc;
            if (infe_icms_predbc != null)
                value.infe_icms_predbc = infe_icms_predbc;
            if (infe_icms_vbc != null)
                value.infe_icms_vbc = infe_icms_vbc;
            if (infe_icms_picms != null)
                value.infe_icms_picms = infe_icms_picms;
            if (infe_icms_vicms != null)
                value.infe_icms_vicms = infe_icms_vicms;
            if (infe_icms_modbst != null)
                value.infe_icms_modbst = infe_icms_modbst;
            if (infe_icms_pmvast != null)
                value.infe_icms_pmvast = infe_icms_pmvast;
            if (infe_icms_predbcst != null)
                value.infe_icms_predbcst = infe_icms_predbcst;
            if (infe_icms_vbcst != null)
                value.infe_icms_vbcst = infe_icms_vbcst;
            if (infe_icms_picmsst != null)
                value.infe_icms_picmsst = infe_icms_picmsst;
            if (infe_icms_vicmsst != null)
                value.infe_icms_vicmsst = infe_icms_vicmsst;
            if (infe_icms_vbstret != null)
                value.infe_icms_vbstret = infe_icms_vbstret;
            if (infe_icms_vicmsstret != null)
                value.infe_icms_vicmsstret = infe_icms_vicmsstret;
            if (infe_qcom != null)
                value.infe_qcom = infe_qcom;
            if (infe_vuncom != null)
                value.infe_vuncom = infe_vuncom;
            if (infe_vprod != null)
                value.infe_vprod = infe_vprod;
            if (infe_vdesc != null)
                value.infe_vdesc = infe_vdesc;
            if (infe_vprodcont != null)
                value.infe_vprodcont = infe_vprodcont;
            if (infe_ipi_cenq != null)
                value.infe_ipi_cenq = infe_ipi_cenq;
            if (infe_ipi_cst != null)
                value.infe_ipi_cst = infe_ipi_cst;
            if (infe_ipi_pipi != null)
                value.infe_ipi_pipi = infe_ipi_pipi;
            if (infe_ipi_vipi != null)
                value.infe_ipi_vipi = infe_ipi_vipi;
            if (infe_pis_cst != null)
                value.infe_pis_cst = infe_pis_cst;
            if (infe_pis_vbcpis != null)
                value.infe_pis_vbcpis = infe_pis_vbcpis;
            if (infe_pis_ppis != null)
                value.infe_pis_ppis = infe_pis_ppis;
            if (infe_pis_vpis != null)
                value.infe_pis_vpis = infe_pis_vpis;
            if (infe_cofins_cst != null)
                value.infe_cofins_cst = infe_cofins_cst;
            if (infe_cofins_vbccofins != null)
                value.infe_cofins_vbccofins = infe_cofins_vbccofins;
            if (infe_cofins_pcofins != null)
                value.infe_cofins_pcofins = infe_cofins_pcofins;
            if (infe_cofins_vcofiins != null)
                value.infe_cofins_vcofiins = infe_cofins_vcofiins;
            if (infe_voutro != null)
                value.infe_voutro = infe_voutro;
            if (infe_vdescfin != null)
                value.infe_vdescfin = infe_vdescfin;
            return value;
        }

        public tb_paciente_anvisa Createtb_paciente_anvisa(Int64? paciente_id = null, String paciente_nome = null, String paciente_sexo = null, Nullable<DateTime> paciente_dt_nascimento = null, Nullable<DateTime> paciente_dt_modific = null)
        {
            tb_paciente_anvisa value = CreateObject<tb_paciente_anvisa>();
            if (paciente_id != null)
                value.paciente_id = paciente_id.Value;
            if (paciente_nome != null)
                value.paciente_nome = paciente_nome;
            if (paciente_sexo != null)
                value.paciente_sexo = paciente_sexo;
            if (paciente_dt_nascimento != null)
                value.paciente_dt_nascimento = paciente_dt_nascimento;
            if (paciente_dt_modific != null)
                value.paciente_dt_modific = paciente_dt_modific;
            return value;
        }

        public tb_paf_numero Createtb_paf_numero(String paf_ult_pv = null, String paf_ult_dav = null)
        {
            tb_paf_numero value = CreateObject<tb_paf_numero>();
            if (paf_ult_pv != null)
                value.paf_ult_pv = paf_ult_pv;
            if (paf_ult_dav != null)
                value.paf_ult_dav = paf_ult_dav;
            return value;
        }

        public tb_parametro Createtb_parametro(Int32? par_loja = null, Int32? par_pdv = null, String par_msgRodape = null, Int32? par_ponto_tempoSeguranca = null, Int32? par_ponto_tempoAprovGerenteEntrada = null, Int32? par_ponto_tempoAprovGerenteAlmoco = null, Int32? par_ponto_tempoAprovGerenteVoltaAlmoco = null, Int32? par_ponto_tempoAprovGerenteSaida = null, Nullable<Int32> par_ponto_meridianoMinutos = null)
        {
            tb_parametro value = CreateObject<tb_parametro>();
            if (par_loja != null)
                value.par_loja = par_loja.Value;
            if (par_pdv != null)
                value.par_pdv = par_pdv.Value;
            if (par_msgRodape != null)
                value.par_msgRodape = par_msgRodape;
            if (par_ponto_tempoSeguranca != null)
                value.par_ponto_tempoSeguranca = par_ponto_tempoSeguranca.Value;
            if (par_ponto_tempoAprovGerenteEntrada != null)
                value.par_ponto_tempoAprovGerenteEntrada = par_ponto_tempoAprovGerenteEntrada.Value;
            if (par_ponto_tempoAprovGerenteAlmoco != null)
                value.par_ponto_tempoAprovGerenteAlmoco = par_ponto_tempoAprovGerenteAlmoco.Value;
            if (par_ponto_tempoAprovGerenteVoltaAlmoco != null)
                value.par_ponto_tempoAprovGerenteVoltaAlmoco = par_ponto_tempoAprovGerenteVoltaAlmoco.Value;
            if (par_ponto_tempoAprovGerenteSaida != null)
                value.par_ponto_tempoAprovGerenteSaida = par_ponto_tempoAprovGerenteSaida.Value;
            if (par_ponto_meridianoMinutos != null)
                value.par_ponto_meridianoMinutos = par_ponto_meridianoMinutos;
            return value;
        }

        public tb_parametro_comissao Createtb_parametro_comissao(Int32? par_id = null, String par_objeto = null, String par_tipo = null, String par_situacao = null, Nullable<Boolean> par_aplicar = null, Nullable<Boolean> par_tp_regra = null, String par_locked = null, Nullable<DateTime> par_dt_cadastro = null, Nullable<DateTime> par_dt_alteracao = null, String par_cpf_alteracao = null, Nullable<Decimal> par_desconto_ate_1 = null, Nullable<Decimal> par_percentual_1 = null, Nullable<Decimal> par_desconto_ate_2 = null, Nullable<Decimal> par_percentual_2 = null, Nullable<Decimal> par_desconto_ate_3 = null, Nullable<Decimal> par_percentual_3 = null, Nullable<Decimal> par_desconto_ate_4 = null, Nullable<Decimal> par_percentual_4 = null, Nullable<Decimal> par_desconto_ate_5 = null, Nullable<Decimal> par_percentual_5 = null, Nullable<Int32> funcao_id = null, Nullable<Int32> usr_id = null)
        {
            tb_parametro_comissao value = CreateObject<tb_parametro_comissao>();
            if (par_id != null)
                value.par_id = par_id.Value;
            if (par_objeto != null)
                value.par_objeto = par_objeto;
            if (par_tipo != null)
                value.par_tipo = par_tipo;
            if (par_situacao != null)
                value.par_situacao = par_situacao;
            if (par_aplicar != null)
                value.par_aplicar = par_aplicar;
            if (par_tp_regra != null)
                value.par_tp_regra = par_tp_regra;
            if (par_locked != null)
                value.par_locked = par_locked;
            if (par_dt_cadastro != null)
                value.par_dt_cadastro = par_dt_cadastro;
            if (par_dt_alteracao != null)
                value.par_dt_alteracao = par_dt_alteracao;
            if (par_cpf_alteracao != null)
                value.par_cpf_alteracao = par_cpf_alteracao;
            if (par_desconto_ate_1 != null)
                value.par_desconto_ate_1 = par_desconto_ate_1;
            if (par_percentual_1 != null)
                value.par_percentual_1 = par_percentual_1;
            if (par_desconto_ate_2 != null)
                value.par_desconto_ate_2 = par_desconto_ate_2;
            if (par_percentual_2 != null)
                value.par_percentual_2 = par_percentual_2;
            if (par_desconto_ate_3 != null)
                value.par_desconto_ate_3 = par_desconto_ate_3;
            if (par_percentual_3 != null)
                value.par_percentual_3 = par_percentual_3;
            if (par_desconto_ate_4 != null)
                value.par_desconto_ate_4 = par_desconto_ate_4;
            if (par_percentual_4 != null)
                value.par_percentual_4 = par_percentual_4;
            if (par_desconto_ate_5 != null)
                value.par_desconto_ate_5 = par_desconto_ate_5;
            if (par_percentual_5 != null)
                value.par_percentual_5 = par_percentual_5;
            if (funcao_id != null)
                value.funcao_id = funcao_id;
            if (usr_id != null)
                value.usr_id = usr_id;
            return value;
        }

        public tb_parametro_descconv Createtb_parametro_descconv(Int32? par_id = null, String par_objeto = null, String par_situacao = null, Nullable<Boolean> par_tp_regra = null, String par_locked = null, Nullable<DateTime> par_dt_cadastro = null, Nullable<DateTime> par_dt_alteracao = null, Nullable<Decimal> par_cpf_alteracao = null, String par_app_alteracao = null, Nullable<Decimal> par_preco_ate_1 = null, Nullable<Decimal> par_percentual_1 = null, Nullable<Decimal> par_preco_ate_2 = null, Nullable<Decimal> par_percentual_2 = null, Nullable<Decimal> par_preco_ate_3 = null, Nullable<Decimal> par_percentual_3 = null, Nullable<Decimal> par_preco_ate_4 = null, Nullable<Decimal> par_percentual_4 = null, Nullable<Decimal> par_preco_ate_5 = null, Nullable<Decimal> par_percentual_5 = null)
        {
            tb_parametro_descconv value = CreateObject<tb_parametro_descconv>();
            if (par_id != null)
                value.par_id = par_id.Value;
            if (par_objeto != null)
                value.par_objeto = par_objeto;
            if (par_situacao != null)
                value.par_situacao = par_situacao;
            if (par_tp_regra != null)
                value.par_tp_regra = par_tp_regra;
            if (par_locked != null)
                value.par_locked = par_locked;
            if (par_dt_cadastro != null)
                value.par_dt_cadastro = par_dt_cadastro;
            if (par_dt_alteracao != null)
                value.par_dt_alteracao = par_dt_alteracao;
            if (par_cpf_alteracao != null)
                value.par_cpf_alteracao = par_cpf_alteracao;
            if (par_app_alteracao != null)
                value.par_app_alteracao = par_app_alteracao;
            if (par_preco_ate_1 != null)
                value.par_preco_ate_1 = par_preco_ate_1;
            if (par_percentual_1 != null)
                value.par_percentual_1 = par_percentual_1;
            if (par_preco_ate_2 != null)
                value.par_preco_ate_2 = par_preco_ate_2;
            if (par_percentual_2 != null)
                value.par_percentual_2 = par_percentual_2;
            if (par_preco_ate_3 != null)
                value.par_preco_ate_3 = par_preco_ate_3;
            if (par_percentual_3 != null)
                value.par_percentual_3 = par_percentual_3;
            if (par_preco_ate_4 != null)
                value.par_preco_ate_4 = par_preco_ate_4;
            if (par_percentual_4 != null)
                value.par_percentual_4 = par_percentual_4;
            if (par_preco_ate_5 != null)
                value.par_preco_ate_5 = par_preco_ate_5;
            if (par_percentual_5 != null)
                value.par_percentual_5 = par_percentual_5;
            return value;
        }

        public tb_parametro_descmax Createtb_parametro_descmax(Int32? par_id = null, String par_objeto = null, Nullable<Boolean> par_todos_usuarios = null, Nullable<Boolean> par_todas_funcoes = null, Nullable<Boolean> par_desconto_sobre_desconto = null, Nullable<Decimal> par_preco_ate_1 = null, Nullable<Decimal> par_percentual_1 = null, Nullable<Decimal> par_preco_ate_2 = null, Nullable<Decimal> par_percentual_2 = null, Nullable<Decimal> par_preco_ate_3 = null, Nullable<Decimal> par_percentual_3 = null, Nullable<Decimal> par_preco_ate_4 = null, Nullable<Decimal> par_percentual_4 = null, Nullable<Decimal> par_preco_ate_5 = null, Nullable<Decimal> par_percentual_5 = null, String par_situacao = null, Nullable<DateTime> par_dt_cadastro = null, Nullable<DateTime> par_dt_alteracao = null, String par_md5 = null)
        {
            tb_parametro_descmax value = CreateObject<tb_parametro_descmax>();
            if (par_id != null)
                value.par_id = par_id.Value;
            if (par_objeto != null)
                value.par_objeto = par_objeto;
            if (par_todos_usuarios != null)
                value.par_todos_usuarios = par_todos_usuarios;
            if (par_todas_funcoes != null)
                value.par_todas_funcoes = par_todas_funcoes;
            if (par_desconto_sobre_desconto != null)
                value.par_desconto_sobre_desconto = par_desconto_sobre_desconto;
            if (par_preco_ate_1 != null)
                value.par_preco_ate_1 = par_preco_ate_1;
            if (par_percentual_1 != null)
                value.par_percentual_1 = par_percentual_1;
            if (par_preco_ate_2 != null)
                value.par_preco_ate_2 = par_preco_ate_2;
            if (par_percentual_2 != null)
                value.par_percentual_2 = par_percentual_2;
            if (par_preco_ate_3 != null)
                value.par_preco_ate_3 = par_preco_ate_3;
            if (par_percentual_3 != null)
                value.par_percentual_3 = par_percentual_3;
            if (par_preco_ate_4 != null)
                value.par_preco_ate_4 = par_preco_ate_4;
            if (par_percentual_4 != null)
                value.par_percentual_4 = par_percentual_4;
            if (par_preco_ate_5 != null)
                value.par_preco_ate_5 = par_preco_ate_5;
            if (par_percentual_5 != null)
                value.par_percentual_5 = par_percentual_5;
            if (par_situacao != null)
                value.par_situacao = par_situacao;
            if (par_dt_cadastro != null)
                value.par_dt_cadastro = par_dt_cadastro;
            if (par_dt_alteracao != null)
                value.par_dt_alteracao = par_dt_alteracao;
            if (par_md5 != null)
                value.par_md5 = par_md5;
            return value;
        }

        public tb_parametro_descprod Createtb_parametro_descprod(Int32? par_id = null, String par_objeto = null, String par_situacao = null, Nullable<Boolean> par_tp_regra = null, String par_locked = null, Nullable<DateTime> par_dt_cadastro = null, Nullable<DateTime> par_dt_alteracao = null, Nullable<Decimal> par_cpf_alteracao = null, String par_app_alteracao = null, Nullable<Decimal> par_preco_ate_1 = null, Nullable<Decimal> par_percentual_1 = null, Nullable<Decimal> par_preco_ate_2 = null, Nullable<Decimal> par_percentual_2 = null, Nullable<Decimal> par_preco_ate_3 = null, Nullable<Decimal> par_percentual_3 = null, Nullable<Decimal> par_preco_ate_4 = null, Nullable<Decimal> par_percentual_4 = null, Nullable<Decimal> par_preco_ate_5 = null, Nullable<Decimal> par_percentual_5 = null)
        {
            tb_parametro_descprod value = CreateObject<tb_parametro_descprod>();
            if (par_id != null)
                value.par_id = par_id.Value;
            if (par_objeto != null)
                value.par_objeto = par_objeto;
            if (par_situacao != null)
                value.par_situacao = par_situacao;
            if (par_tp_regra != null)
                value.par_tp_regra = par_tp_regra;
            if (par_locked != null)
                value.par_locked = par_locked;
            if (par_dt_cadastro != null)
                value.par_dt_cadastro = par_dt_cadastro;
            if (par_dt_alteracao != null)
                value.par_dt_alteracao = par_dt_alteracao;
            if (par_cpf_alteracao != null)
                value.par_cpf_alteracao = par_cpf_alteracao;
            if (par_app_alteracao != null)
                value.par_app_alteracao = par_app_alteracao;
            if (par_preco_ate_1 != null)
                value.par_preco_ate_1 = par_preco_ate_1;
            if (par_percentual_1 != null)
                value.par_percentual_1 = par_percentual_1;
            if (par_preco_ate_2 != null)
                value.par_preco_ate_2 = par_preco_ate_2;
            if (par_percentual_2 != null)
                value.par_percentual_2 = par_percentual_2;
            if (par_preco_ate_3 != null)
                value.par_preco_ate_3 = par_preco_ate_3;
            if (par_percentual_3 != null)
                value.par_percentual_3 = par_percentual_3;
            if (par_preco_ate_4 != null)
                value.par_preco_ate_4 = par_preco_ate_4;
            if (par_percentual_4 != null)
                value.par_percentual_4 = par_percentual_4;
            if (par_preco_ate_5 != null)
                value.par_preco_ate_5 = par_preco_ate_5;
            if (par_percentual_5 != null)
                value.par_percentual_5 = par_percentual_5;
            return value;
        }

        public tb_parametro_descvend Createtb_parametro_descvend(Int32? par_id = null, String par_objeto = null, Nullable<Boolean> par_desconto_sobre_desconto = null, String par_situacao = null, Nullable<Boolean> par_aplicar = null, Nullable<Boolean> par_tp_regra = null, String par_locked = null, Nullable<DateTime> par_dt_cadastro = null, Nullable<DateTime> par_dt_alteracao = null, Nullable<Decimal> par_cpf_alteracao = null, String par_app_alteracao = null, Nullable<Decimal> par_margem_ate_1 = null, Nullable<Decimal> par_percentual_1 = null, Nullable<Decimal> par_margem_ate_2 = null, Nullable<Decimal> par_percentual_2 = null, Nullable<Decimal> par_margem_ate_3 = null, Nullable<Decimal> par_percentual_3 = null, Nullable<Decimal> par_margem_ate_4 = null, Nullable<Decimal> par_percentual_4 = null, Nullable<Decimal> par_margem_ate_5 = null, Nullable<Decimal> par_percentual_5 = null, Nullable<Int32> div_id = null)
        {
            tb_parametro_descvend value = CreateObject<tb_parametro_descvend>();
            if (par_id != null)
                value.par_id = par_id.Value;
            if (par_objeto != null)
                value.par_objeto = par_objeto;
            if (par_desconto_sobre_desconto != null)
                value.par_desconto_sobre_desconto = par_desconto_sobre_desconto;
            if (par_situacao != null)
                value.par_situacao = par_situacao;
            if (par_aplicar != null)
                value.par_aplicar = par_aplicar;
            if (par_tp_regra != null)
                value.par_tp_regra = par_tp_regra;
            if (par_locked != null)
                value.par_locked = par_locked;
            if (par_dt_cadastro != null)
                value.par_dt_cadastro = par_dt_cadastro;
            if (par_dt_alteracao != null)
                value.par_dt_alteracao = par_dt_alteracao;
            if (par_cpf_alteracao != null)
                value.par_cpf_alteracao = par_cpf_alteracao;
            if (par_app_alteracao != null)
                value.par_app_alteracao = par_app_alteracao;
            if (par_margem_ate_1 != null)
                value.par_margem_ate_1 = par_margem_ate_1;
            if (par_percentual_1 != null)
                value.par_percentual_1 = par_percentual_1;
            if (par_margem_ate_2 != null)
                value.par_margem_ate_2 = par_margem_ate_2;
            if (par_percentual_2 != null)
                value.par_percentual_2 = par_percentual_2;
            if (par_margem_ate_3 != null)
                value.par_margem_ate_3 = par_margem_ate_3;
            if (par_percentual_3 != null)
                value.par_percentual_3 = par_percentual_3;
            if (par_margem_ate_4 != null)
                value.par_margem_ate_4 = par_margem_ate_4;
            if (par_percentual_4 != null)
                value.par_percentual_4 = par_percentual_4;
            if (par_margem_ate_5 != null)
                value.par_margem_ate_5 = par_margem_ate_5;
            if (par_percentual_5 != null)
                value.par_percentual_5 = par_percentual_5;
            if (div_id != null)
                value.div_id = div_id;
            return value;
        }

        public tb_parametro_limpezas Createtb_parametro_limpezas(Int32? tb_id = null, Nullable<DateTime> tb_dt_alteracao = null, Nullable<Decimal> tb_cpf_alteracao = null, Nullable<DateTime> tb_data_exec = null, Nullable<Int32> lJ_tb_abertura_caixa = null, Nullable<Int32> lJ_tb_checkin = null, Nullable<Int32> lJ_tb_checkout = null, Nullable<Int32> lJ_tb_abcfarma_periodo = null, Nullable<Int32> lJ_tb_sangrias = null, Nullable<Int32> lJ_tb_suprimentos = null, Nullable<Int32> lJ_tb_reducao_z = null, Nullable<Int32> lJ_tb_venda = null, Nullable<Int32> lJ_tb_promocao = null, Nullable<Int32> lJ_tb_ponto = null, Nullable<Int32> lJ_tb_nfe = null, Nullable<Int32> lJ_tb_privatelabel = null, Nullable<Int32> lJ_tb_recarga = null, Nullable<Int32> lJ_tb_lancto_financeiro = null, Nullable<Int32> lJ_tb_agenda_produto = null, Nullable<Int32> lJ_tb_crediario = null)
        {
            tb_parametro_limpezas value = CreateObject<tb_parametro_limpezas>();
            if (tb_id != null)
                value.tb_id = tb_id.Value;
            if (tb_dt_alteracao != null)
                value.tb_dt_alteracao = tb_dt_alteracao;
            if (tb_cpf_alteracao != null)
                value.tb_cpf_alteracao = tb_cpf_alteracao;
            if (tb_data_exec != null)
                value.tb_data_exec = tb_data_exec;
            if (lJ_tb_abertura_caixa != null)
                value.LJ_tb_abertura_caixa = lJ_tb_abertura_caixa;
            if (lJ_tb_checkin != null)
                value.LJ_tb_checkin = lJ_tb_checkin;
            if (lJ_tb_checkout != null)
                value.LJ_tb_checkout = lJ_tb_checkout;
            if (lJ_tb_abcfarma_periodo != null)
                value.LJ_tb_abcfarma_periodo = lJ_tb_abcfarma_periodo;
            if (lJ_tb_sangrias != null)
                value.LJ_tb_sangrias = lJ_tb_sangrias;
            if (lJ_tb_suprimentos != null)
                value.LJ_tb_suprimentos = lJ_tb_suprimentos;
            if (lJ_tb_reducao_z != null)
                value.LJ_tb_reducao_z = lJ_tb_reducao_z;
            if (lJ_tb_venda != null)
                value.LJ_tb_venda = lJ_tb_venda;
            if (lJ_tb_promocao != null)
                value.LJ_tb_promocao = lJ_tb_promocao;
            if (lJ_tb_ponto != null)
                value.LJ_tb_ponto = lJ_tb_ponto;
            if (lJ_tb_nfe != null)
                value.LJ_tb_nfe = lJ_tb_nfe;
            if (lJ_tb_privatelabel != null)
                value.LJ_tb_privatelabel = lJ_tb_privatelabel;
            if (lJ_tb_recarga != null)
                value.LJ_tb_recarga = lJ_tb_recarga;
            if (lJ_tb_lancto_financeiro != null)
                value.LJ_tb_lancto_financeiro = lJ_tb_lancto_financeiro;
            if (lJ_tb_agenda_produto != null)
                value.LJ_tb_agenda_produto = lJ_tb_agenda_produto;
            if (lJ_tb_crediario != null)
                value.LJ_tb_crediario = lJ_tb_crediario;
            return value;
        }

        public tb_parametro_markup Createtb_parametro_markup(Int32? par_id = null, Nullable<Int32> par_objeto = null, String par_situacao = null, Nullable<Boolean> par_tp_regra = null, Nullable<DateTime> par_dt_cadastro = null, Nullable<DateTime> par_dt_alteracao = null, String par_cpf_alteracao = null, Nullable<Decimal> par_markup = null)
        {
            tb_parametro_markup value = CreateObject<tb_parametro_markup>();
            if (par_id != null)
                value.par_id = par_id.Value;
            if (par_objeto != null)
                value.par_objeto = par_objeto;
            if (par_situacao != null)
                value.par_situacao = par_situacao;
            if (par_tp_regra != null)
                value.par_tp_regra = par_tp_regra;
            if (par_dt_cadastro != null)
                value.par_dt_cadastro = par_dt_cadastro;
            if (par_dt_alteracao != null)
                value.par_dt_alteracao = par_dt_alteracao;
            if (par_cpf_alteracao != null)
                value.par_cpf_alteracao = par_cpf_alteracao;
            if (par_markup != null)
                value.par_markup = par_markup;
            return value;
        }

        public tb_pbm Createtb_pbm(Int32? pbm_id = null, String pbm_descricao = null)
        {
            tb_pbm value = CreateObject<tb_pbm>();
            if (pbm_id != null)
                value.pbm_id = pbm_id.Value;
            if (pbm_descricao != null)
                value.pbm_descricao = pbm_descricao;
            return value;
        }

        public tb_pedido_compra____ Createtb_pedido_compra____(Int32? pedc_id = null, Nullable<Decimal> pedc_nu_nf = null, Nullable<DateTime> pedc_dt_pedido = null, Nullable<DateTime> pedc_dt_emissao = null, Nullable<DateTime> pedc_dt_vencimento = null, Nullable<Decimal> pedc_vlr_total = null, Nullable<Decimal> pedc_qtd_itens = null, Nullable<Decimal> pedc_vlr_desconto = null, String pedc_situacao = null, Nullable<Int32> ped_id = null, Nullable<DateTime> pedc_dt_alteracao = null)
        {
            tb_pedido_compra____ value = CreateObject<tb_pedido_compra____>();
            if (pedc_id != null)
                value.pedc_id = pedc_id.Value;
            if (pedc_nu_nf != null)
                value.pedc_nu_nf = pedc_nu_nf;
            if (pedc_dt_pedido != null)
                value.pedc_dt_pedido = pedc_dt_pedido;
            if (pedc_dt_emissao != null)
                value.pedc_dt_emissao = pedc_dt_emissao;
            if (pedc_dt_vencimento != null)
                value.pedc_dt_vencimento = pedc_dt_vencimento;
            if (pedc_vlr_total != null)
                value.pedc_vlr_total = pedc_vlr_total;
            if (pedc_qtd_itens != null)
                value.pedc_qtd_itens = pedc_qtd_itens;
            if (pedc_vlr_desconto != null)
                value.pedc_vlr_desconto = pedc_vlr_desconto;
            if (pedc_situacao != null)
                value.pedc_situacao = pedc_situacao;
            if (ped_id != null)
                value.ped_id = ped_id;
            if (pedc_dt_alteracao != null)
                value.pedc_dt_alteracao = pedc_dt_alteracao;
            return value;
        }

        public tb_pedido_compra_item____ Createtb_pedido_compra_item____(Int32? pedc_id = null, Int32? ipedc_id = null, Nullable<Decimal> ipedc_qtd_atendida = null, Nullable<Decimal> ipedv_qtd_embalagem = null, Nullable<Decimal> ipedc_custo_unitario = null, Nullable<Decimal> ipedc_perc_desconto = null, Nullable<Int32> pro_id = null, String ipedc_situacao = null)
        {
            tb_pedido_compra_item____ value = CreateObject<tb_pedido_compra_item____>();
            if (pedc_id != null)
                value.pedc_id = pedc_id.Value;
            if (ipedc_id != null)
                value.ipedc_id = ipedc_id.Value;
            if (ipedc_qtd_atendida != null)
                value.ipedc_qtd_atendida = ipedc_qtd_atendida;
            if (ipedv_qtd_embalagem != null)
                value.ipedv_qtd_embalagem = ipedv_qtd_embalagem;
            if (ipedc_custo_unitario != null)
                value.ipedc_custo_unitario = ipedc_custo_unitario;
            if (ipedc_perc_desconto != null)
                value.ipedc_perc_desconto = ipedc_perc_desconto;
            if (pro_id != null)
                value.pro_id = pro_id;
            if (ipedc_situacao != null)
                value.ipedc_situacao = ipedc_situacao;
            return value;
        }

        public tb_piscofins Createtb_piscofins(Int32? piscofins_id = null, Nullable<Decimal> piscofins_cst = null, Nullable<Decimal> piscofins_aliq_LP_pis = null, Nullable<Decimal> piscofins_aliq_LP_cofins = null, Nullable<Decimal> piscofins_aliq_LR_pis = null, Nullable<Decimal> piscofins_aliq_LR_cofins = null, String piscofins_situacao = null, Nullable<DateTime> piscofins_dt_cadastro = null, Nullable<DateTime> piscofins_dt_alteracao = null, Nullable<Decimal> piscofins_cpf_alteracao = null)
        {
            tb_piscofins value = CreateObject<tb_piscofins>();
            if (piscofins_id != null)
                value.piscofins_id = piscofins_id.Value;
            if (piscofins_cst != null)
                value.piscofins_cst = piscofins_cst;
            if (piscofins_aliq_LP_pis != null)
                value.piscofins_aliq_LP_pis = piscofins_aliq_LP_pis;
            if (piscofins_aliq_LP_cofins != null)
                value.piscofins_aliq_LP_cofins = piscofins_aliq_LP_cofins;
            if (piscofins_aliq_LR_pis != null)
                value.piscofins_aliq_LR_pis = piscofins_aliq_LR_pis;
            if (piscofins_aliq_LR_cofins != null)
                value.piscofins_aliq_LR_cofins = piscofins_aliq_LR_cofins;
            if (piscofins_situacao != null)
                value.piscofins_situacao = piscofins_situacao;
            if (piscofins_dt_cadastro != null)
                value.piscofins_dt_cadastro = piscofins_dt_cadastro;
            if (piscofins_dt_alteracao != null)
                value.piscofins_dt_alteracao = piscofins_dt_alteracao;
            if (piscofins_cpf_alteracao != null)
                value.piscofins_cpf_alteracao = piscofins_cpf_alteracao;
            return value;
        }

        public tb_ponto Createtb_ponto(Int32? ponto_id = null, DateTime? ponto_dt_ponto = null, Nullable<DateTime> ponto_hr_entrada = null, Nullable<DateTime> ponto_hr_almoco_inicio = null, Nullable<DateTime> ponto_hr_almoco_fim = null, Nullable<DateTime> ponto_hr_saida = null, Int32? func_id = null, String ponto_situacao = null)
        {
            tb_ponto value = CreateObject<tb_ponto>();
            if (ponto_id != null)
                value.ponto_id = ponto_id.Value;
            if (ponto_dt_ponto != null)
                value.ponto_dt_ponto = ponto_dt_ponto.Value;
            if (ponto_hr_entrada != null)
                value.ponto_hr_entrada = ponto_hr_entrada;
            if (ponto_hr_almoco_inicio != null)
                value.ponto_hr_almoco_inicio = ponto_hr_almoco_inicio;
            if (ponto_hr_almoco_fim != null)
                value.ponto_hr_almoco_fim = ponto_hr_almoco_fim;
            if (ponto_hr_saida != null)
                value.ponto_hr_saida = ponto_hr_saida;
            if (func_id != null)
                value.func_id = func_id.Value;
            if (ponto_situacao != null)
                value.ponto_situacao = ponto_situacao;
            return value;
        }

        public tb_ponto_motivo Createtb_ponto_motivo(Int32? motivo_id = null, String motivo_descricao = null, String motivo_situacao = null)
        {
            tb_ponto_motivo value = CreateObject<tb_ponto_motivo>();
            if (motivo_id != null)
                value.motivo_id = motivo_id.Value;
            if (motivo_descricao != null)
                value.motivo_descricao = motivo_descricao;
            if (motivo_situacao != null)
                value.motivo_situacao = motivo_situacao;
            return value;
        }

        public tb_princ_ativo Createtb_princ_ativo(Int32? pat_id = null, String pat_descricao = null, DateTime? pat_dt_alteracao = null)
        {
            tb_princ_ativo value = CreateObject<tb_princ_ativo>();
            if (pat_id != null)
                value.pat_id = pat_id.Value;
            if (pat_descricao != null)
                value.pat_descricao = pat_descricao;
            if (pat_dt_alteracao != null)
                value.pat_dt_alteracao = pat_dt_alteracao.Value;
            return value;
        }

        public tb_privatelabel Createtb_privatelabel(Int32? uneg_id = null, Int32? plabel_pdv = null, DateTime? plabel_data = null, Int32? plabel_id = null, String plabel_nsu = null, String plabel_nome_rec = null, Nullable<Decimal> plabel_tipo_rec = null, Nullable<Decimal> plabel_tot_rec = null, Nullable<Int32> plabel_operado_cx = null)
        {
            tb_privatelabel value = CreateObject<tb_privatelabel>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (plabel_pdv != null)
                value.plabel_pdv = plabel_pdv.Value;
            if (plabel_data != null)
                value.plabel_data = plabel_data.Value;
            if (plabel_id != null)
                value.plabel_id = plabel_id.Value;
            if (plabel_nsu != null)
                value.plabel_nsu = plabel_nsu;
            if (plabel_nome_rec != null)
                value.plabel_nome_rec = plabel_nome_rec;
            if (plabel_tipo_rec != null)
                value.plabel_tipo_rec = plabel_tipo_rec;
            if (plabel_tot_rec != null)
                value.plabel_tot_rec = plabel_tot_rec;
            if (plabel_operado_cx != null)
                value.plabel_operado_cx = plabel_operado_cx;
            return value;
        }

        public tb_privatelabel_finalizadora Createtb_privatelabel_finalizadora(Int32? uneg_id = null, Int32? plabel_pdv = null, DateTime? plabel_data = null, Int32? plabel_id = null, String vpag_id = null, Int32? final_id = null, Int32? subfin_id = null, Nullable<Int32> vpag_num_referencia = null, Decimal? vpag_valor = null, Nullable<Decimal> vpag_troco = null, Nullable<Boolean> vpag_vendatef = null, String vpag_tef_nsu_venda = null, String vpag_tef_nsu_host = null, String vpag_tipo_cartao = null, String vpag_comprovante_cliente = null, String vpag_comprovante_loja = null, String vpag_status = null, Nullable<Int32> cli_id = null, Nullable<Int32> bcaixa_id = null)
        {
            tb_privatelabel_finalizadora value = CreateObject<tb_privatelabel_finalizadora>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (plabel_pdv != null)
                value.plabel_pdv = plabel_pdv.Value;
            if (plabel_data != null)
                value.plabel_data = plabel_data.Value;
            if (plabel_id != null)
                value.plabel_id = plabel_id.Value;
            if (vpag_id != null)
                value.vpag_id = vpag_id;
            if (final_id != null)
                value.final_id = final_id.Value;
            if (subfin_id != null)
                value.subfin_id = subfin_id.Value;
            if (vpag_num_referencia != null)
                value.vpag_num_referencia = vpag_num_referencia;
            if (vpag_valor != null)
                value.vpag_valor = vpag_valor.Value;
            if (vpag_troco != null)
                value.vpag_troco = vpag_troco;
            if (vpag_vendatef != null)
                value.vpag_vendatef = vpag_vendatef;
            if (vpag_tef_nsu_venda != null)
                value.vpag_tef_nsu_venda = vpag_tef_nsu_venda;
            if (vpag_tef_nsu_host != null)
                value.vpag_tef_nsu_host = vpag_tef_nsu_host;
            if (vpag_tipo_cartao != null)
                value.vpag_tipo_cartao = vpag_tipo_cartao;
            if (vpag_comprovante_cliente != null)
                value.vpag_comprovante_cliente = vpag_comprovante_cliente;
            if (vpag_comprovante_loja != null)
                value.vpag_comprovante_loja = vpag_comprovante_loja;
            if (vpag_status != null)
                value.vpag_status = vpag_status;
            if (cli_id != null)
                value.cli_id = cli_id;
            if (bcaixa_id != null)
                value.bcaixa_id = bcaixa_id;
            return value;
        }

        public tb_produto Createtb_produto(Int32? pro_id = null, Nullable<long> pro_codigo = null, String pro_descricao = null, String pro_nome = null, String pro_dosagem = null, Nullable<Decimal> pro_qtd_embalagem = null, String pro_embalagem = null, String pro_apresentacao = null, String pro_unidade_venda = null, String pro_situacao = null, Nullable<long> pro_ipi = null, long? pro_ncm = null, Nullable<long> pro_tip_etiqueta = null, String pro_tip_compra = null, String pro_tip_preco = null, String pro_tip_produto = null, Nullable<Decimal> pro_cod_ms = null, Nullable<Boolean> pro_uso_continuo = null, Nullable<Decimal> pro_desc_max = null, Nullable<Boolean> pro_composto = null, Nullable<Boolean> pro_peso_variavel = null, Nullable<Decimal> pro_validade_perec = null, Nullable<DateTime> pro_dt_cadastro = null, Nullable<DateTime> pro_dt_alteracao = null, Nullable<Decimal> pro_cod_genero = null, Nullable<Decimal> pro_qtde_m2 = null, Nullable<Boolean> pro_marca_crm = null, Nullable<Boolean> pro_fracionado = null, Nullable<Decimal> pro_peso = null, Nullable<Decimal> pro_pei = null, String pro_tb_balanca = null, Nullable<Boolean> pro_encarte = null, Nullable<Decimal> pro_cod_dcb = null, Nullable<Boolean> pro_marca_propaganda = null, Nullable<Int32> pro_link_propaganda_1 = null, Nullable<Int32> pro_link_propaganda_2 = null, Nullable<Int32> pro_link_propaganda_3 = null, Nullable<Int32> pro_link_propaganda_4 = null, Nullable<Int32> pro_link_propaganda_5 = null, String pro_dados_adicionais = null, String pro_lista_icms_medic = null, Nullable<Decimal> pro_mva = null, Nullable<Decimal> pro_cod_origem = null, Nullable<Decimal> pro_cod_cst_icms = null, Nullable<Decimal> pro_cod_csosn_icms = null, String pro_class_trib_piscofins = null, Nullable<Decimal> pro_cod_cst_piscofins = null, String campo_busca_prod = null)
        {
            tb_produto value = CreateObject<tb_produto>();
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (pro_codigo != null)
                value.pro_codigo = pro_codigo;
            if (pro_descricao != null)
                value.pro_descricao = pro_descricao;
            if (pro_nome != null)
                value.pro_nome = pro_nome;
            if (pro_dosagem != null)
                value.pro_dosagem = pro_dosagem;
            if (pro_qtd_embalagem != null)
                value.pro_qtd_embalagem = pro_qtd_embalagem;
            if (pro_embalagem != null)
                value.pro_embalagem = pro_embalagem;
            if (pro_apresentacao != null)
                value.pro_apresentacao = pro_apresentacao;
            if (pro_unidade_venda != null)
                value.pro_unidade_venda = pro_unidade_venda;
            if (pro_situacao != null)
                value.pro_situacao = pro_situacao;
            if (pro_ipi != null)
                value.pro_ipi = pro_ipi;
            if (pro_ncm != null)
                value.pro_ncm = pro_ncm;
            if (pro_tip_etiqueta != null)
                value.pro_tip_etiqueta = pro_tip_etiqueta;
            if (pro_tip_compra != null)
                value.pro_tip_compra = pro_tip_compra;
            if (pro_tip_preco != null)
                value.pro_tip_preco = pro_tip_preco;
            if (pro_tip_produto != null)
                value.pro_tip_produto = pro_tip_produto;
            if (pro_cod_ms != null)
                value.pro_cod_ms = pro_cod_ms;
            if (pro_uso_continuo != null)
                value.pro_uso_continuo = pro_uso_continuo;
            if (pro_desc_max != null)
                value.pro_desc_max = pro_desc_max;
            if (pro_composto != null)
                value.pro_composto = pro_composto;
            if (pro_peso_variavel != null)
                value.pro_peso_variavel = pro_peso_variavel;
            if (pro_validade_perec != null)
                value.pro_validade_perec = pro_validade_perec;
            if (pro_dt_cadastro != null)
                value.pro_dt_cadastro = pro_dt_cadastro;
            if (pro_dt_alteracao != null)
                value.pro_dt_alteracao = pro_dt_alteracao;
            if (pro_cod_genero != null)
                value.pro_cod_genero = pro_cod_genero;
            if (pro_qtde_m2 != null)
                value.pro_qtde_m2 = pro_qtde_m2;
            if (pro_marca_crm != null)
                value.pro_marca_crm = pro_marca_crm;
            if (pro_fracionado != null)
                value.pro_fracionado = pro_fracionado;
            if (pro_peso != null)
                value.pro_peso = pro_peso;
            if (pro_pei != null)
                value.pro_pei = pro_pei;
            if (pro_tb_balanca != null)
                value.pro_tb_balanca = pro_tb_balanca;
            if (pro_encarte != null)
                value.pro_encarte = pro_encarte;
            if (pro_cod_dcb != null)
                value.pro_cod_dcb = pro_cod_dcb;
            if (pro_marca_propaganda != null)
                value.pro_marca_propaganda = pro_marca_propaganda;
            if (pro_link_propaganda_1 != null)
                value.pro_link_propaganda_1 = pro_link_propaganda_1;
            if (pro_link_propaganda_2 != null)
                value.pro_link_propaganda_2 = pro_link_propaganda_2;
            if (pro_link_propaganda_3 != null)
                value.pro_link_propaganda_3 = pro_link_propaganda_3;
            if (pro_link_propaganda_4 != null)
                value.pro_link_propaganda_4 = pro_link_propaganda_4;
            if (pro_link_propaganda_5 != null)
                value.pro_link_propaganda_5 = pro_link_propaganda_5;
            if (pro_dados_adicionais != null)
                value.pro_dados_adicionais = pro_dados_adicionais;
            if (pro_lista_icms_medic != null)
                value.pro_lista_icms_medic = pro_lista_icms_medic;
            if (pro_mva != null)
                value.pro_mva = pro_mva;
            if (pro_cod_origem != null)
                value.pro_cod_origem = pro_cod_origem;
            if (pro_cod_cst_icms != null)
                value.pro_cod_cst_icms = pro_cod_cst_icms;
            if (pro_cod_csosn_icms != null)
                value.pro_cod_csosn_icms = pro_cod_csosn_icms;
            if (pro_class_trib_piscofins != null)
                value.pro_class_trib_piscofins = pro_class_trib_piscofins;
            if (pro_cod_cst_piscofins != null)
                value.pro_cod_cst_piscofins = pro_cod_cst_piscofins;

            return value;
        }

        public tb_produto_barra Createtb_produto_barra(Int32? pro_id = null, Decimal? barra_codigo = null, String barra_tip_embalagem = null, Nullable<Decimal> barra_qtd_embalagem = null, String barra_situacao = null, Nullable<DateTime> barra_dt_cadastro = null, Nullable<DateTime> barra_dt_alteracao = null, String barra_cpf_alteracao = null)
        {
            tb_produto_barra value = CreateObject<tb_produto_barra>();
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (barra_codigo != null)
                value.barra_codigo = barra_codigo.Value;
            if (barra_tip_embalagem != null)
                value.barra_tip_embalagem = barra_tip_embalagem;
            if (barra_qtd_embalagem != null)
                value.barra_qtd_embalagem = barra_qtd_embalagem;
            if (barra_situacao != null)
                value.barra_situacao = barra_situacao;
            if (barra_dt_cadastro != null)
                value.barra_dt_cadastro = barra_dt_cadastro;
            if (barra_dt_alteracao != null)
                value.barra_dt_alteracao = barra_dt_alteracao;
            if (barra_cpf_alteracao != null)
                value.barra_cpf_alteracao = barra_cpf_alteracao;
            return value;
        }

        public tb_produto_classe Createtb_produto_classe(Int32? cla_id = null, String cla_descricao = null, String cla_situacao = null, Nullable<DateTime> cla_dt_cadastro = null, Nullable<DateTime> cla_dt_alteracao = null)
        {
            tb_produto_classe value = CreateObject<tb_produto_classe>();
            if (cla_id != null)
                value.cla_id = cla_id.Value;
            if (cla_descricao != null)
                value.cla_descricao = cla_descricao;
            if (cla_situacao != null)
                value.cla_situacao = cla_situacao;
            if (cla_dt_cadastro != null)
                value.cla_dt_cadastro = cla_dt_cadastro;
            if (cla_dt_alteracao != null)
                value.cla_dt_alteracao = cla_dt_alteracao;
            return value;
        }

        public tb_produto_fam_categ_sub Createtb_produto_fam_categ_sub(Int32? fam_id = null, Int32? grp_id = null, Int32? cat_id = null, Int32? scat_id = null, String scat_descricao = null, String scat_situacao = null, Nullable<DateTime> scat_dt_cadastro = null, Nullable<DateTime> scat_dt_alteracao = null)
        {
            tb_produto_fam_categ_sub value = CreateObject<tb_produto_fam_categ_sub>();
            if (fam_id != null)
                value.fam_id = fam_id.Value;
            if (grp_id != null)
                value.grp_id = grp_id.Value;
            if (cat_id != null)
                value.cat_id = cat_id.Value;
            if (scat_id != null)
                value.scat_id = scat_id.Value;
            if (scat_descricao != null)
                value.scat_descricao = scat_descricao;
            if (scat_situacao != null)
                value.scat_situacao = scat_situacao;
            if (scat_dt_cadastro != null)
                value.scat_dt_cadastro = scat_dt_cadastro;
            if (scat_dt_alteracao != null)
                value.scat_dt_alteracao = scat_dt_alteracao;
            return value;
        }

        public tb_produto_fam_categoria Createtb_produto_fam_categoria(Int32? fam_id = null, Int32? grp_id = null, Int32? cat_id = null, String cat_descricao = null, String cat_situacao = null, Nullable<DateTime> cat_dt_cadastro = null, Nullable<DateTime> cat_dt_alteracao = null)
        {
            tb_produto_fam_categoria value = CreateObject<tb_produto_fam_categoria>();
            if (fam_id != null)
                value.fam_id = fam_id.Value;
            if (grp_id != null)
                value.grp_id = grp_id.Value;
            if (cat_id != null)
                value.cat_id = cat_id.Value;
            if (cat_descricao != null)
                value.cat_descricao = cat_descricao;
            if (cat_situacao != null)
                value.cat_situacao = cat_situacao;
            if (cat_dt_cadastro != null)
                value.cat_dt_cadastro = cat_dt_cadastro;
            if (cat_dt_alteracao != null)
                value.cat_dt_alteracao = cat_dt_alteracao;
            return value;
        }

        public tb_produto_fam_grupo Createtb_produto_fam_grupo(Int32? fam_id = null, Int32? grp_id = null, String grp_descricao = null, String grp_situacao = null, Nullable<DateTime> grp_dt_cadastro = null, Nullable<DateTime> grp_dt_alteracao = null)
        {
            tb_produto_fam_grupo value = CreateObject<tb_produto_fam_grupo>();
            if (fam_id != null)
                value.fam_id = fam_id.Value;
            if (grp_id != null)
                value.grp_id = grp_id.Value;
            if (grp_descricao != null)
                value.grp_descricao = grp_descricao;
            if (grp_situacao != null)
                value.grp_situacao = grp_situacao;
            if (grp_dt_cadastro != null)
                value.grp_dt_cadastro = grp_dt_cadastro;
            if (grp_dt_alteracao != null)
                value.grp_dt_alteracao = grp_dt_alteracao;
            return value;
        }

        public tb_produto_familia Createtb_produto_familia(Int32? fam_id = null, String fam_descricao = null, String fam_situacao = null, Nullable<DateTime> fam_dt_cadastro = null, Nullable<DateTime> fam_dt_alteracao = null)
        {
            tb_produto_familia value = CreateObject<tb_produto_familia>();
            if (fam_id != null)
                value.fam_id = fam_id.Value;
            if (fam_descricao != null)
                value.fam_descricao = fam_descricao;
            if (fam_situacao != null)
                value.fam_situacao = fam_situacao;
            if (fam_dt_cadastro != null)
                value.fam_dt_cadastro = fam_dt_cadastro;
            if (fam_dt_alteracao != null)
                value.fam_dt_alteracao = fam_dt_alteracao;
            return value;
        }

        public tb_produto_kit Createtb_produto_kit(Int32? pro_id = null, Int32? kitpro_produto = null, Nullable<Decimal> kitpro_quantidade = null, String kitpro_situacao = null, Nullable<DateTime> kitpro_dt_cadastro = null, Nullable<DateTime> kitpro_dt_alteracao = null)
        {
            tb_produto_kit value = CreateObject<tb_produto_kit>();
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (kitpro_produto != null)
                value.kitpro_produto = kitpro_produto.Value;
            if (kitpro_quantidade != null)
                value.kitpro_quantidade = kitpro_quantidade;
            if (kitpro_situacao != null)
                value.kitpro_situacao = kitpro_situacao;
            if (kitpro_dt_cadastro != null)
                value.kitpro_dt_cadastro = kitpro_dt_cadastro;
            if (kitpro_dt_alteracao != null)
                value.kitpro_dt_alteracao = kitpro_dt_alteracao;
            return value;
        }

        public tb_produto_linha Createtb_produto_linha(Int32? lin_id = null, String lin_descricao = null, String lin_situacao = null, Nullable<DateTime> lin_dt_cadastro = null, Nullable<DateTime> lin_dt_alteracao = null)
        {
            tb_produto_linha value = CreateObject<tb_produto_linha>();
            if (lin_id != null)
                value.lin_id = lin_id.Value;
            if (lin_descricao != null)
                value.lin_descricao = lin_descricao;
            if (lin_situacao != null)
                value.lin_situacao = lin_situacao;
            if (lin_dt_cadastro != null)
                value.lin_dt_cadastro = lin_dt_cadastro;
            if (lin_dt_alteracao != null)
                value.lin_dt_alteracao = lin_dt_alteracao;
            return value;
        }

        public tb_produto_piscofins Createtb_produto_piscofins(String piscofins_cod = null, String piscofins_legenda = null, String piscofins_situacao = null, Nullable<DateTime> piscofins_dt_cadastro = null, Nullable<DateTime> piscofins_dt_alteracao = null)
        {
            tb_produto_piscofins value = CreateObject<tb_produto_piscofins>();
            if (piscofins_cod != null)
                value.piscofins_cod = piscofins_cod;
            if (piscofins_legenda != null)
                value.piscofins_legenda = piscofins_legenda;
            if (piscofins_situacao != null)
                value.piscofins_situacao = piscofins_situacao;
            if (piscofins_dt_cadastro != null)
                value.piscofins_dt_cadastro = piscofins_dt_cadastro;
            if (piscofins_dt_alteracao != null)
                value.piscofins_dt_alteracao = piscofins_dt_alteracao;
            return value;
        }

        public tb_produto_princativo Createtb_produto_princativo(Int32? pat_id = null, String pat_descricao = null, String pat_situacao = null, Nullable<DateTime> pat_dt_cadastro = null, Nullable<DateTime> pat_dt_alteracao = null, Nullable<Decimal> pat_cpf_alteracao = null)
        {
            tb_produto_princativo value = CreateObject<tb_produto_princativo>();
            if (pat_id != null)
                value.pat_id = pat_id.Value;
            if (pat_descricao != null)
                value.pat_descricao = pat_descricao;
            if (pat_situacao != null)
                value.pat_situacao = pat_situacao;
            if (pat_dt_cadastro != null)
                value.pat_dt_cadastro = pat_dt_cadastro;
            if (pat_dt_alteracao != null)
                value.pat_dt_alteracao = pat_dt_alteracao;
            if (pat_cpf_alteracao != null)
                value.pat_cpf_alteracao = pat_cpf_alteracao;
            return value;
        }

        public tb_produto_receituario Createtb_produto_receituario(Int32? rec_id = null, String rec_lista = null, String rec_lista_descricao = null, String rec_receita_descricao = null, Nullable<Decimal> rec_reter_receita = null, String rec_situacao = null, Nullable<DateTime> rec_dt_cadastro = null, Nullable<DateTime> rec_dt_alteracao = null)
        {
            tb_produto_receituario value = CreateObject<tb_produto_receituario>();
            if (rec_id != null)
                value.rec_id = rec_id.Value;
            if (rec_lista != null)
                value.rec_lista = rec_lista;
            if (rec_lista_descricao != null)
                value.rec_lista_descricao = rec_lista_descricao;
            if (rec_receita_descricao != null)
                value.rec_receita_descricao = rec_receita_descricao;
            if (rec_reter_receita != null)
                value.rec_reter_receita = rec_reter_receita;
            if (rec_situacao != null)
                value.rec_situacao = rec_situacao;
            if (rec_dt_cadastro != null)
                value.rec_dt_cadastro = rec_dt_cadastro;
            if (rec_dt_alteracao != null)
                value.rec_dt_alteracao = rec_dt_alteracao;
            return value;
        }

        public tb_produto_similaridade Createtb_produto_similaridade(Int32? sim_id = null, String sim_descricao = null, String sim_situacao = null, Nullable<DateTime> sim_dt_cadastro = null, Nullable<DateTime> sim_dt_alteracao = null)
        {
            tb_produto_similaridade value = CreateObject<tb_produto_similaridade>();
            if (sim_id != null)
                value.sim_id = sim_id.Value;
            if (sim_descricao != null)
                value.sim_descricao = sim_descricao;
            if (sim_situacao != null)
                value.sim_situacao = sim_situacao;
            if (sim_dt_cadastro != null)
                value.sim_dt_cadastro = sim_dt_cadastro;
            if (sim_dt_alteracao != null)
                value.sim_dt_alteracao = sim_dt_alteracao;
            return value;
        }

        public tb_promocao Createtb_promocao(Int32? prm_id = null, String prm_observacao = null, Nullable<DateTime> prm_dt_inicio = null, Nullable<DateTime> prm_dt_fim = null, String prm_tip_aplicacao = null, String prm_situacao = null, Nullable<DateTime> prm_dt_cadastro = null, Nullable<DateTime> prm_dt_alteracao = null, Nullable<Decimal> prm_cpf_alteracao = null, Nullable<Int32> tippro_id = null)
        {
            tb_promocao value = CreateObject<tb_promocao>();
            if (prm_id != null)
                value.prm_id = prm_id.Value;
            if (prm_observacao != null)
                value.prm_observacao = prm_observacao;
            if (prm_dt_inicio != null)
                value.prm_dt_inicio = prm_dt_inicio;
            if (prm_dt_fim != null)
                value.prm_dt_fim = prm_dt_fim;
            if (prm_tip_aplicacao != null)
                value.prm_tip_aplicacao = prm_tip_aplicacao;
            if (prm_situacao != null)
                value.prm_situacao = prm_situacao;
            if (prm_dt_cadastro != null)
                value.prm_dt_cadastro = prm_dt_cadastro;
            if (prm_dt_alteracao != null)
                value.prm_dt_alteracao = prm_dt_alteracao;
            if (prm_cpf_alteracao != null)
                value.prm_cpf_alteracao = prm_cpf_alteracao;
            if (tippro_id != null)
                value.tippro_id = tippro_id;
            return value;
        }

        public tb_promocao_tipo Createtb_promocao_tipo(Int32? tippro_id = null, String tippro_descricao = null, String tippro_situacao = null, Nullable<DateTime> tippro_dt_cadastro = null, Nullable<DateTime> tippro_dt_alteracao = null, Nullable<Decimal> tippro_cpf_alteracao = null)
        {
            tb_promocao_tipo value = CreateObject<tb_promocao_tipo>();
            if (tippro_id != null)
                value.tippro_id = tippro_id.Value;
            if (tippro_descricao != null)
                value.tippro_descricao = tippro_descricao;
            if (tippro_situacao != null)
                value.tippro_situacao = tippro_situacao;
            if (tippro_dt_cadastro != null)
                value.tippro_dt_cadastro = tippro_dt_cadastro;
            if (tippro_dt_alteracao != null)
                value.tippro_dt_alteracao = tippro_dt_alteracao;
            if (tippro_cpf_alteracao != null)
                value.tippro_cpf_alteracao = tippro_cpf_alteracao;
            return value;
        }

        public tb_recarga Createtb_recarga(Int32? uneg_id = null, Int32? pin_pdv = null, DateTime? pin_data = null, Int32? pin_id = null, String pin_cod_convenio = null, String pin_nome_convenio = null, String pin_tipo_credito = null, String pin_nome_credito = null, Nullable<Decimal> pin_qtde = null, Nullable<Decimal> pin_preco = null, Nullable<Decimal> pin_tot_pgto = null, String pin_ddd = null, String pin_telefone = null, Nullable<Int32> pin_operado_cx = null)
        {
            tb_recarga value = CreateObject<tb_recarga>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (pin_pdv != null)
                value.pin_pdv = pin_pdv.Value;
            if (pin_data != null)
                value.pin_data = pin_data.Value;
            if (pin_id != null)
                value.pin_id = pin_id.Value;
            if (pin_cod_convenio != null)
                value.pin_cod_convenio = pin_cod_convenio;
            if (pin_nome_convenio != null)
                value.pin_nome_convenio = pin_nome_convenio;
            if (pin_tipo_credito != null)
                value.pin_tipo_credito = pin_tipo_credito;
            if (pin_nome_credito != null)
                value.pin_nome_credito = pin_nome_credito;
            if (pin_qtde != null)
                value.pin_qtde = pin_qtde;
            if (pin_preco != null)
                value.pin_preco = pin_preco;
            if (pin_tot_pgto != null)
                value.pin_tot_pgto = pin_tot_pgto;
            if (pin_ddd != null)
                value.pin_ddd = pin_ddd;
            if (pin_telefone != null)
                value.pin_telefone = pin_telefone;
            if (pin_operado_cx != null)
                value.pin_operado_cx = pin_operado_cx;
            return value;
        }

        public tb_recarga_finalizadora Createtb_recarga_finalizadora(Int32? uneg_id = null, Int32? pin_pdv = null, DateTime? pin_data = null, Int32? pin_id = null, String vpag_id = null, Int32? final_id = null, Int32? subfin_id = null, Nullable<Int32> vpag_num_referencia = null, Decimal? vpag_valor = null, Nullable<Decimal> vpag_troco = null, Nullable<Boolean> vpag_vendatef = null, String vpag_tef_nsu_venda = null, String vpag_tef_nsu_host = null, String vpag_tipo_cartao = null, String vpag_comprovante_cliente = null, String vpag_comprovante_loja = null, String vpag_status = null, Nullable<Int32> cli_id = null, Nullable<Int32> bcaixa_id = null)
        {
            tb_recarga_finalizadora value = CreateObject<tb_recarga_finalizadora>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (pin_pdv != null)
                value.pin_pdv = pin_pdv.Value;
            if (pin_data != null)
                value.pin_data = pin_data.Value;
            if (pin_id != null)
                value.pin_id = pin_id.Value;
            if (vpag_id != null)
                value.vpag_id = vpag_id;
            if (final_id != null)
                value.final_id = final_id.Value;
            if (subfin_id != null)
                value.subfin_id = subfin_id.Value;
            if (vpag_num_referencia != null)
                value.vpag_num_referencia = vpag_num_referencia;
            if (vpag_valor != null)
                value.vpag_valor = vpag_valor.Value;
            if (vpag_troco != null)
                value.vpag_troco = vpag_troco;
            if (vpag_vendatef != null)
                value.vpag_vendatef = vpag_vendatef;
            if (vpag_tef_nsu_venda != null)
                value.vpag_tef_nsu_venda = vpag_tef_nsu_venda;
            if (vpag_tef_nsu_host != null)
                value.vpag_tef_nsu_host = vpag_tef_nsu_host;
            if (vpag_tipo_cartao != null)
                value.vpag_tipo_cartao = vpag_tipo_cartao;
            if (vpag_comprovante_cliente != null)
                value.vpag_comprovante_cliente = vpag_comprovante_cliente;
            if (vpag_comprovante_loja != null)
                value.vpag_comprovante_loja = vpag_comprovante_loja;
            if (vpag_status != null)
                value.vpag_status = vpag_status;
            if (cli_id != null)
                value.cli_id = cli_id;
            if (bcaixa_id != null)
                value.bcaixa_id = bcaixa_id;
            return value;
        }

        public tb_reducao_z Createtb_reducao_z(String ecf_numero_serie = null, DateTime? reduz_data_movimento = null, Int32? reduz_crz = null, Int32? reduz_coo = null, Int32? reduz_cro = null, DateTime? reduz_data_emissao = null, Decimal? reduz_venda_bruta = null, Decimal? reduz_gt = null, String reduz_md5 = null, Nullable<Int32> uneg_id = null, Nullable<Int32> ecf_id = null)
        {
            tb_reducao_z value = CreateObject<tb_reducao_z>();
            if (ecf_numero_serie != null)
                value.ecf_numero_serie = ecf_numero_serie;
            if (reduz_data_movimento != null)
                value.reduz_data_movimento = reduz_data_movimento.Value;
            if (reduz_crz != null)
                value.reduz_crz = reduz_crz.Value;
            if (reduz_coo != null)
                value.reduz_coo = reduz_coo.Value;
            if (reduz_cro != null)
                value.reduz_cro = reduz_cro.Value;
            if (reduz_data_emissao != null)
                value.reduz_data_emissao = reduz_data_emissao.Value;
            if (reduz_venda_bruta != null)
                value.reduz_venda_bruta = reduz_venda_bruta.Value;
            if (reduz_gt != null)
                value.reduz_gt = reduz_gt.Value;
            if (reduz_md5 != null)
                value.reduz_md5 = reduz_md5;
            if (uneg_id != null)
                value.uneg_id = uneg_id;
            if (ecf_id != null)
                value.ecf_id = ecf_id;
            return value;
        }

        public tb_reducao_z_itens Createtb_reducao_z_itens(Int32? reduz_itens_id = null, String ecf_numero_serie = null, DateTime? reduz_data_movimento = null, String reduz_itens_sequencia = null, String reduz_itens_tipo = null, Nullable<Decimal> reduz_itens_valor = null, Nullable<Decimal> reduz_itens_total = null, String reduz_itens_md5 = null)
        {
            tb_reducao_z_itens value = CreateObject<tb_reducao_z_itens>();
            if (reduz_itens_id != null)
                value.reduz_itens_id = reduz_itens_id.Value;
            if (ecf_numero_serie != null)
                value.ecf_numero_serie = ecf_numero_serie;
            if (reduz_data_movimento != null)
                value.reduz_data_movimento = reduz_data_movimento.Value;
            if (reduz_itens_sequencia != null)
                value.reduz_itens_sequencia = reduz_itens_sequencia;
            if (reduz_itens_tipo != null)
                value.reduz_itens_tipo = reduz_itens_tipo;
            if (reduz_itens_valor != null)
                value.reduz_itens_valor = reduz_itens_valor;
            if (reduz_itens_total != null)
                value.reduz_itens_total = reduz_itens_total;
            if (reduz_itens_md5 != null)
                value.reduz_itens_md5 = reduz_itens_md5;
            return value;
        }

        public tb_sangrias Createtb_sangrias(Int32? uneg_id = null, Int32? sangriafl_pdv = null, DateTime? sangriaf_data = null, Int32? sangriaf_id = null, Nullable<Decimal> sangriaf_valor = null, Nullable<Int32> sangriaf_operadorCx = null, String sangriaf_observacao = null, Nullable<Int32> sangriaf_responsavel = null, String sangriaf_status = null, Nullable<Int32> sangriaf_funcionario = null, Nullable<DateTime> sangriaf_dt_alteracao = null, String sangriaf_cpf_alteracao = null, Nullable<Int32> final_id = null, String sangriaf_md5 = null, Nullable<Int32> bcaixa_id = null)
        {
            tb_sangrias value = CreateObject<tb_sangrias>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (sangriafl_pdv != null)
                value.sangriafl_pdv = sangriafl_pdv.Value;
            if (sangriaf_data != null)
                value.sangriaf_data = sangriaf_data.Value;
            if (sangriaf_id != null)
                value.sangriaf_id = sangriaf_id.Value;
            if (sangriaf_valor != null)
                value.sangriaf_valor = sangriaf_valor;
            if (sangriaf_operadorCx != null)
                value.sangriaf_operadorCx = sangriaf_operadorCx;
            if (sangriaf_observacao != null)
                value.sangriaf_observacao = sangriaf_observacao;
            if (sangriaf_responsavel != null)
                value.sangriaf_responsavel = sangriaf_responsavel;
            if (sangriaf_status != null)
                value.sangriaf_status = sangriaf_status;
            if (sangriaf_funcionario != null)
                value.sangriaf_funcionario = sangriaf_funcionario;
            if (sangriaf_dt_alteracao != null)
                value.sangriaf_dt_alteracao = sangriaf_dt_alteracao;
            if (sangriaf_cpf_alteracao != null)
                value.sangriaf_cpf_alteracao = sangriaf_cpf_alteracao;
            if (final_id != null)
                value.final_id = final_id;
            if (sangriaf_md5 != null)
                value.sangriaf_md5 = sangriaf_md5;
            if (bcaixa_id != null)
                value.bcaixa_id = bcaixa_id;
            return value;
        }

        public tb_serie_nota Createtb_serie_nota(Int32? serient_id = null, String serient_serie = null, String serient_descricao = null, String serient_situacao = null, Nullable<DateTime> serient_dt_cadastro = null, Nullable<DateTime> serient_dt_alteracao = null)
        {
            tb_serie_nota value = CreateObject<tb_serie_nota>();
            if (serient_id != null)
                value.serient_id = serient_id.Value;
            if (serient_serie != null)
                value.serient_serie = serient_serie;
            if (serient_descricao != null)
                value.serient_descricao = serient_descricao;
            if (serient_situacao != null)
                value.serient_situacao = serient_situacao;
            if (serient_dt_cadastro != null)
                value.serient_dt_cadastro = serient_dt_cadastro;
            if (serient_dt_alteracao != null)
                value.serient_dt_alteracao = serient_dt_alteracao;
            return value;
        }

        public tb_sincronizacao Createtb_sincronizacao(Int32? id_sincronizacao = null, Nullable<Int32> id_registro = null, String entidade_registro = null, Nullable<DateTime> dt_alteracao = null, Nullable<DateTime> dt_inclusao = null, Nullable<Int32> status = null)
        {
            tb_sincronizacao value = CreateObject<tb_sincronizacao>();
            if (id_sincronizacao != null)
                value.id_sincronizacao = id_sincronizacao.Value;
            if (id_registro != null)
                value.id_registro = id_registro;
            if (entidade_registro != null)
                value.entidade_registro = entidade_registro;
            if (dt_alteracao != null)
                value.dt_alteracao = dt_alteracao;
            if (dt_inclusao != null)
                value.dt_inclusao = dt_inclusao;
            if (status != null)
                value.status = status;
            return value;
        }

        public tb_suprimentos Createtb_suprimentos(Int32? uneg_id = null, Int32? suprimentof_pdv = null, DateTime? suprimentof_data = null, Int32? suprimentof_id = null, Decimal? suprimentof_valor = null, Int32? suprimentof_operadorCx = null, String suprimentof_observacao = null, Int32? suprimentof_responsavel = null, String suprimentof_status = null, Nullable<Int32> suprimentof_funcionario = null, Nullable<DateTime> suprimentof_dt_alteracao = null, String suprimentof_cpf_alteracao = null, Nullable<Int32> final_id = null, String suprimentof_md5 = null, Nullable<Int32> bcaixa_id = null)
        {
            tb_suprimentos value = CreateObject<tb_suprimentos>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (suprimentof_pdv != null)
                value.suprimentof_pdv = suprimentof_pdv.Value;
            if (suprimentof_data != null)
                value.suprimentof_data = suprimentof_data.Value;
            if (suprimentof_id != null)
                value.suprimentof_id = suprimentof_id.Value;
            if (suprimentof_valor != null)
                value.suprimentof_valor = suprimentof_valor.Value;
            if (suprimentof_operadorCx != null)
                value.suprimentof_operadorCx = suprimentof_operadorCx.Value;
            if (suprimentof_observacao != null)
                value.suprimentof_observacao = suprimentof_observacao;
            if (suprimentof_responsavel != null)
                value.suprimentof_responsavel = suprimentof_responsavel.Value;
            if (suprimentof_status != null)
                value.suprimentof_status = suprimentof_status;
            if (suprimentof_funcionario != null)
                value.suprimentof_funcionario = suprimentof_funcionario;
            if (suprimentof_dt_alteracao != null)
                value.suprimentof_dt_alteracao = suprimentof_dt_alteracao;
            if (suprimentof_cpf_alteracao != null)
                value.suprimentof_cpf_alteracao = suprimentof_cpf_alteracao;
            if (final_id != null)
                value.final_id = final_id;
            if (suprimentof_md5 != null)
                value.suprimentof_md5 = suprimentof_md5;
            if (bcaixa_id != null)
                value.bcaixa_id = bcaixa_id;
            return value;
        }

        public tb_terminal Createtb_terminal(Int32? te_id_terminal = null, String te_nome = null, String te_nome_rede = null, String te_database = null, String te_tipo = null, Nullable<DateTime> te_dt_alteracao = null, Nullable<DateTime> te_dt_inclusao = null, String te_status = null, String te_acbr_ecf_marca = null, String te_acbr_ecf_porta = null, Nullable<Int32> te_acbr_ecf_velocidade_porta = null, Nullable<Int32> te_acbr_ecf_timeout = null, Nullable<Int32> te_acbr_ecf_intervalo_apos_comando = null, Nullable<Boolean> te_acbr_ecf_controla_gaveta = null, Nullable<Boolean> te_acbr_ecf_gaveta_sinal_invertido = null, Nullable<Boolean> te_acbr_ecf_descricao_grande = null, String te_acbr_caminho_log = null, String te_caminho_servidor = null, String te_caminho_preVenda = null, Nullable<Boolean> te_balanca = null, String te_acbr_bal_marca = null, String te_acbr_bal_porta = null, Nullable<Boolean> te_imprimir_dav = null, Nullable<DateTime> te_data_ult_imp_srv_web = null, Nullable<DateTime> te_data_ult_imp_srv_loja = null, Nullable<DateTime> te_data_ult_imp_pdv = null, Nullable<Boolean> te_servidor_loja = null, Nullable<Int32> te_percentual_importacao = null, Nullable<Boolean> te_nfce = null, String te_certificado = null, Nullable<Boolean> te_sat = null, String te_num_ativacao_aparelho = null, String te_ambiente_sefaz = null, String te_drive_rede = null, String te_id_token_sefaz = null, String te_token_sefaz = null, String te_debug = null, String te_serie_hd = null, String te_serie_placa_mae = null, Nullable<Boolean> te_terminal_atualizado = null, Nullable<Int32> te_serie_nfce = null, Nullable<Int32> te_numero_nfce = null, String te_aparelho_sat = null)
        {
            tb_terminal value = CreateObject<tb_terminal>();
            if (te_id_terminal != null)
                value.te_id_terminal = te_id_terminal.Value;
            if (te_nome != null)
                value.te_nome = te_nome;
            if (te_nome_rede != null)
                value.te_nome_rede = te_nome_rede;
            if (te_database != null)
                value.te_database = te_database;
            if (te_tipo != null)
                value.te_tipo = te_tipo;
            if (te_dt_alteracao != null)
                value.te_dt_alteracao = te_dt_alteracao;
            if (te_dt_inclusao != null)
                value.te_dt_inclusao = te_dt_inclusao;
            if (te_status != null)
                value.te_status = te_status;
            if (te_acbr_ecf_marca != null)
                value.te_acbr_ecf_marca = te_acbr_ecf_marca;
            if (te_acbr_ecf_porta != null)
                value.te_acbr_ecf_porta = te_acbr_ecf_porta;
            if (te_acbr_ecf_velocidade_porta != null)
                value.te_acbr_ecf_velocidade_porta = te_acbr_ecf_velocidade_porta;
            if (te_acbr_ecf_timeout != null)
                value.te_acbr_ecf_timeout = te_acbr_ecf_timeout;
            if (te_acbr_ecf_intervalo_apos_comando != null)
                value.te_acbr_ecf_intervalo_apos_comando = te_acbr_ecf_intervalo_apos_comando;
            if (te_acbr_ecf_controla_gaveta != null)
                value.te_acbr_ecf_controla_gaveta = te_acbr_ecf_controla_gaveta;
            if (te_acbr_ecf_gaveta_sinal_invertido != null)
                value.te_acbr_ecf_gaveta_sinal_invertido = te_acbr_ecf_gaveta_sinal_invertido;
            if (te_acbr_ecf_descricao_grande != null)
                value.te_acbr_ecf_descricao_grande = te_acbr_ecf_descricao_grande;
            if (te_acbr_caminho_log != null)
                value.te_acbr_caminho_log = te_acbr_caminho_log;
            if (te_caminho_servidor != null)
                value.te_caminho_servidor = te_caminho_servidor;
            if (te_caminho_preVenda != null)
                value.te_caminho_preVenda = te_caminho_preVenda;
            if (te_balanca != null)
                value.te_balanca = te_balanca;
            if (te_acbr_bal_marca != null)
                value.te_acbr_bal_marca = te_acbr_bal_marca;
            if (te_acbr_bal_porta != null)
                value.te_acbr_bal_porta = te_acbr_bal_porta;
            if (te_imprimir_dav != null)
                value.te_imprimir_dav = te_imprimir_dav;
            if (te_data_ult_imp_srv_web != null)
                value.te_data_ult_imp_srv_web = te_data_ult_imp_srv_web;
            if (te_data_ult_imp_srv_loja != null)
                value.te_data_ult_imp_srv_loja = te_data_ult_imp_srv_loja;
            if (te_data_ult_imp_pdv != null)
                value.te_data_ult_imp_pdv = te_data_ult_imp_pdv;
            if (te_servidor_loja != null)
                value.te_servidor_loja = te_servidor_loja;
            if (te_percentual_importacao != null)
                value.te_percentual_importacao = te_percentual_importacao;
            if (te_nfce != null)
                value.te_nfce = te_nfce;
            if (te_certificado != null)
                value.te_certificado = te_certificado;
            if (te_sat != null)
                value.te_sat = te_sat;
            if (te_num_ativacao_aparelho != null)
                value.te_num_ativacao_aparelho = te_num_ativacao_aparelho;
            if (te_ambiente_sefaz != null)
                value.te_ambiente_sefaz = te_ambiente_sefaz;
            if (te_drive_rede != null)
                value.te_drive_rede = te_drive_rede;
            if (te_id_token_sefaz != null)
                value.te_id_token_sefaz = te_id_token_sefaz;
            if (te_token_sefaz != null)
                value.te_token_sefaz = te_token_sefaz;
            if (te_debug != null)
                value.te_debug = te_debug;
            if (te_serie_hd != null)
                value.te_serie_hd = te_serie_hd;
            if (te_serie_placa_mae != null)
                value.te_serie_placa_mae = te_serie_placa_mae;
            if (te_terminal_atualizado != null)
                value.te_terminal_atualizado = te_terminal_atualizado;
            if (te_serie_nfce != null)
                value.te_serie_nfce = te_serie_nfce;
            if (te_numero_nfce != null)
                value.te_numero_nfce = te_numero_nfce;
            if (te_aparelho_sat != null)
                value.te_aparelho_sat = te_aparelho_sat;
            return value;
        }

        public tb_terminal_mobile Createtb_terminal_mobile(Int32? te_mobile_id = null, String te_mobile_mac = null)
        {
            tb_terminal_mobile value = CreateObject<tb_terminal_mobile>();
            if (te_mobile_id != null)
                value.te_mobile_id = te_mobile_id.Value;
            if (te_mobile_mac != null)
                value.te_mobile_mac = te_mobile_mac;
            return value;
        }

        public tb_tipo_logradouro Createtb_tipo_logradouro(Int32? tiplog_id = null, String tiplog_abreviatura = null, String tiplog_descricao = null, String tiplog_situacao = null, Nullable<DateTime> tiplog_dt_cadastro = null, Nullable<DateTime> tiplog_dt_alteracao = null, String tiplog_cpf_alteracao = null)
        {
            tb_tipo_logradouro value = CreateObject<tb_tipo_logradouro>();
            if (tiplog_id != null)
                value.tiplog_id = tiplog_id.Value;
            if (tiplog_abreviatura != null)
                value.tiplog_abreviatura = tiplog_abreviatura;
            if (tiplog_descricao != null)
                value.tiplog_descricao = tiplog_descricao;
            if (tiplog_situacao != null)
                value.tiplog_situacao = tiplog_situacao;
            if (tiplog_dt_cadastro != null)
                value.tiplog_dt_cadastro = tiplog_dt_cadastro;
            if (tiplog_dt_alteracao != null)
                value.tiplog_dt_alteracao = tiplog_dt_alteracao;
            if (tiplog_cpf_alteracao != null)
                value.tiplog_cpf_alteracao = tiplog_cpf_alteracao;
            return value;
        }

        public tb_tipo_mvto_produto Createtb_tipo_mvto_produto(Int32? cdmvto_codigo = null, String cdmvto_descricao = null, String cdmvto_tipo = null, Nullable<Boolean> cdmvto_lanc_manual = null, String cdmvto_cd_anvisa = null, String cdmvto_situacao = null, Nullable<DateTime> cdmvto_dt_cadastro = null, Nullable<DateTime> cdmvto_dt_alteracao = null)
        {
            tb_tipo_mvto_produto value = CreateObject<tb_tipo_mvto_produto>();
            if (cdmvto_codigo != null)
                value.cdmvto_codigo = cdmvto_codigo.Value;
            if (cdmvto_descricao != null)
                value.cdmvto_descricao = cdmvto_descricao;
            if (cdmvto_tipo != null)
                value.cdmvto_tipo = cdmvto_tipo;
            if (cdmvto_lanc_manual != null)
                value.cdmvto_lanc_manual = cdmvto_lanc_manual;
            if (cdmvto_cd_anvisa != null)
                value.cdmvto_cd_anvisa = cdmvto_cd_anvisa;
            if (cdmvto_situacao != null)
                value.cdmvto_situacao = cdmvto_situacao;
            if (cdmvto_dt_cadastro != null)
                value.cdmvto_dt_cadastro = cdmvto_dt_cadastro;
            if (cdmvto_dt_alteracao != null)
                value.cdmvto_dt_alteracao = cdmvto_dt_alteracao;
            return value;
        }

        public tb_tipo_nota Createtb_tipo_nota(Int32? tipnota_id = null, String tipnota_descricao = null, String tipnota_tipo = null, Nullable<Boolean> tipnota_bonificado_alt_custo = null, String tipnota_tipo_aplicacao_financ = null, Nullable<Boolean> tipnota_romaneio = null, Nullable<Boolean> tipnota_obrigar_checkin = null, Nullable<Boolean> tipnota_obrigar_icms = null, Nullable<Boolean> tipnota_permitir_alterar_dic = null, Nullable<Boolean> tipnota_aplicar_preco_rede = null, Nullable<Boolean> tipnota_desprezar_sngpc = null, Nullable<Boolean> tipnota_nf_contabil = null, Nullable<Decimal> tipnota_ac_qtde_prod_fora_ped = null, String tipnota_acao_custo_maior_vend = null, String tipnota_acao_alterar_prec_vend = null, Nullable<Boolean> tipnota_obrigar_pedido_compra = null, Nullable<Decimal> tipnota_limite_acert_dif_fech = null, Nullable<Boolean> tipnota_ignora_justif_diverg = null, String tipnota_situacao = null, Nullable<DateTime> tipnota_dt_cadastro = null, Nullable<DateTime> tipnota_dt_alteracao = null)
        {
            tb_tipo_nota value = CreateObject<tb_tipo_nota>();
            if (tipnota_id != null)
                value.tipnota_id = tipnota_id.Value;
            if (tipnota_descricao != null)
                value.tipnota_descricao = tipnota_descricao;
            if (tipnota_tipo != null)
                value.tipnota_tipo = tipnota_tipo;
            if (tipnota_bonificado_alt_custo != null)
                value.tipnota_bonificado_alt_custo = tipnota_bonificado_alt_custo;
            if (tipnota_tipo_aplicacao_financ != null)
                value.tipnota_tipo_aplicacao_financ = tipnota_tipo_aplicacao_financ;
            if (tipnota_romaneio != null)
                value.tipnota_romaneio = tipnota_romaneio;
            if (tipnota_obrigar_checkin != null)
                value.tipnota_obrigar_checkin = tipnota_obrigar_checkin;
            if (tipnota_obrigar_icms != null)
                value.tipnota_obrigar_icms = tipnota_obrigar_icms;
            if (tipnota_permitir_alterar_dic != null)
                value.tipnota_permitir_alterar_dic = tipnota_permitir_alterar_dic;
            if (tipnota_aplicar_preco_rede != null)
                value.tipnota_aplicar_preco_rede = tipnota_aplicar_preco_rede;
            if (tipnota_desprezar_sngpc != null)
                value.tipnota_desprezar_sngpc = tipnota_desprezar_sngpc;
            if (tipnota_nf_contabil != null)
                value.tipnota_nf_contabil = tipnota_nf_contabil;
            if (tipnota_ac_qtde_prod_fora_ped != null)
                value.tipnota_ac_qtde_prod_fora_ped = tipnota_ac_qtde_prod_fora_ped;
            if (tipnota_acao_custo_maior_vend != null)
                value.tipnota_acao_custo_maior_vend = tipnota_acao_custo_maior_vend;
            if (tipnota_acao_alterar_prec_vend != null)
                value.tipnota_acao_alterar_prec_vend = tipnota_acao_alterar_prec_vend;
            if (tipnota_obrigar_pedido_compra != null)
                value.tipnota_obrigar_pedido_compra = tipnota_obrigar_pedido_compra;
            if (tipnota_limite_acert_dif_fech != null)
                value.tipnota_limite_acert_dif_fech = tipnota_limite_acert_dif_fech;
            if (tipnota_ignora_justif_diverg != null)
                value.tipnota_ignora_justif_diverg = tipnota_ignora_justif_diverg;
            if (tipnota_situacao != null)
                value.tipnota_situacao = tipnota_situacao;
            if (tipnota_dt_cadastro != null)
                value.tipnota_dt_cadastro = tipnota_dt_cadastro;
            if (tipnota_dt_alteracao != null)
                value.tipnota_dt_alteracao = tipnota_dt_alteracao;
            return value;
        }

        public tb_transportadora Createtb_transportadora(Int32? transp_id = null, String transp_nome = null, String transp_situacao = null, Nullable<DateTime> transp_dt_cadastro = null, Nullable<DateTime> transp_dt_alteracao = null)
        {
            tb_transportadora value = CreateObject<tb_transportadora>();
            if (transp_id != null)
                value.transp_id = transp_id.Value;
            if (transp_nome != null)
                value.transp_nome = transp_nome;
            if (transp_situacao != null)
                value.transp_situacao = transp_situacao;
            if (transp_dt_cadastro != null)
                value.transp_dt_cadastro = transp_dt_cadastro;
            if (transp_dt_alteracao != null)
                value.transp_dt_alteracao = transp_dt_alteracao;
            return value;
        }

        public tb_tributacao Createtb_tributacao(Int32? trb_id = null, Nullable<Decimal> trb_aliquota = null, Nullable<Boolean> trb_servico = null, Nullable<Boolean> trb_subst_trib = null, String trb_situacao = null, Nullable<DateTime> trb_dt_cadastro = null, Nullable<DateTime> trb_dt_alteracao = null)
        {
            tb_tributacao value = CreateObject<tb_tributacao>();
            if (trb_id != null)
                value.trb_id = trb_id.Value;
            if (trb_aliquota != null)
                value.trb_aliquota = trb_aliquota;
            if (trb_servico != null)
                value.trb_servico = trb_servico;
            if (trb_subst_trib != null)
                value.trb_subst_trib = trb_subst_trib;
            if (trb_situacao != null)
                value.trb_situacao = trb_situacao;
            if (trb_dt_cadastro != null)
                value.trb_dt_cadastro = trb_dt_cadastro;
            if (trb_dt_alteracao != null)
                value.trb_dt_alteracao = trb_dt_alteracao;
            return value;
        }

        public tb_uf Createtb_uf(Int32? uf_id = null, String uf_sigla = null, String uf_descricao = null, String uf_situacao = null, Nullable<DateTime> uf_dt_cadastro = null, Nullable<DateTime> uf_dt_alteracao = null)
        {
            tb_uf value = CreateObject<tb_uf>();
            if (uf_id != null)
                value.uf_id = uf_id.Value;
            if (uf_sigla != null)
                value.uf_sigla = uf_sigla;
            if (uf_descricao != null)
                value.uf_descricao = uf_descricao;
            if (uf_situacao != null)
                value.uf_situacao = uf_situacao;
            if (uf_dt_cadastro != null)
                value.uf_dt_cadastro = uf_dt_cadastro;
            if (uf_dt_alteracao != null)
                value.uf_dt_alteracao = uf_dt_alteracao;
            return value;
        }

        public tb_unid_negocio Createtb_unid_negocio(Int32? uneg_id = null, Nullable<Decimal> uneg_numero = null, String uneg_cnpj = null, String uneg_nome = null, String uneg_razao_social = null, String uneg_fantasia = null, String uneg_inscricao_estadual = null, String uneg_inscricao_municipal = null, String uneg_situacao = null, String uneg_loja = null, Nullable<Boolean> uneg_cnpj_local = null, Nullable<Boolean> uneg_obriga_justif_diverg = null, Boolean? uneg_epp = null, Byte[] uneg_img_logo = null, Nullable<DateTime> uneg_dt_cadastro = null, Nullable<DateTime> uneg_dt_alteracao = null, String uneg_cep = null, String uneg_logradouro = null, String uneg_endereco_numero = null, String uneg_complemento = null, String uneg_bairro = null, String uneg_municipio = null, String uneg_telefones = null, String uneg_fax = null, String uneg_email = null, String uneg_regime = null, String uneg_nfe_automacao = null, String uneg_fid_login = null, String uneg_fid_senha = null, String uneg_cod_regime_fat = null, String uneg_cli_asafisco = null, String uneg_cli_ifarma = null, String uneg_vazio = null, String uneg_versao_banco = null, String uneg_tef_idLoja = null, String uneg_tef_IP = null)
        {
            tb_unid_negocio value = CreateObject<tb_unid_negocio>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            //if (uneg_numero != null)
            //    value.uneg_numero = uneg_numero;
            if (uneg_cnpj != null)
                value.uneg_cnpj = uneg_cnpj;
            if (uneg_nome != null)
                value.uneg_nome = uneg_nome;
            if (uneg_razao_social != null)
                value.uneg_razao_social = uneg_razao_social;
            if (uneg_fantasia != null)
                value.uneg_fantasia = uneg_fantasia;
            if (uneg_inscricao_estadual != null)
                value.uneg_inscricao_estadual = uneg_inscricao_estadual;
            if (uneg_inscricao_municipal != null)
                value.uneg_inscricao_municipal = uneg_inscricao_municipal;
            if (uneg_situacao != null)
                value.uneg_situacao = uneg_situacao;
            if (uneg_loja != null)
                value.uneg_loja = uneg_loja;
            if (uneg_cnpj_local != null)
                value.uneg_cnpj_local = uneg_cnpj_local;
            if (uneg_obriga_justif_diverg != null)
                value.uneg_obriga_justif_diverg = uneg_obriga_justif_diverg;
            if (uneg_epp != null)
                value.uneg_epp = uneg_epp.Value;
            if (uneg_img_logo != null)
                value.uneg_img_logo = uneg_img_logo;
            if (uneg_dt_cadastro != null)
                value.uneg_dt_cadastro = uneg_dt_cadastro;
            if (uneg_dt_alteracao != null)
                value.uneg_dt_alteracao = uneg_dt_alteracao;
            if (uneg_cep != null)
                value.uneg_cep = uneg_cep;
            if (uneg_logradouro != null)
                value.uneg_logradouro = uneg_logradouro;
            if (uneg_endereco_numero != null)
                value.uneg_endereco_numero = uneg_endereco_numero;
            if (uneg_complemento != null)
                value.uneg_complemento = uneg_complemento;
            if (uneg_bairro != null)
                value.uneg_bairro = uneg_bairro;
            if (uneg_municipio != null)
                value.uneg_municipio = uneg_municipio;
            if (uneg_telefones != null)
                value.uneg_telefones = uneg_telefones;
            if (uneg_fax != null)
                value.uneg_fax = uneg_fax;
            if (uneg_email != null)
                value.uneg_email = uneg_email;
            if (uneg_regime != null)
                value.uneg_regime = uneg_regime;
            if (uneg_nfe_automacao != null)
                value.uneg_nfe_automacao = uneg_nfe_automacao;
            if (uneg_fid_login != null)
                value.uneg_fid_login = uneg_fid_login;
            if (uneg_fid_senha != null)
                value.uneg_fid_senha = uneg_fid_senha;
            if (uneg_cod_regime_fat != null)
                value.uneg_cod_regime_fat = uneg_cod_regime_fat;
            if (uneg_cli_asafisco != null)
                value.uneg_cli_asafisco = uneg_cli_asafisco;
            if (uneg_cli_ifarma != null)
                value.uneg_cli_ifarma = uneg_cli_ifarma;
            if (uneg_vazio != null)
                value.uneg_vazio = uneg_vazio;
            if (uneg_versao_banco != null)
                value.uneg_versao_banco = uneg_versao_banco;
            if (uneg_tef_idLoja != null)
                value.uneg_tef_idLoja = uneg_tef_idLoja;
            if (uneg_tef_IP != null)
                value.uneg_tef_IP = uneg_tef_IP;
            return value;
        }

        public tb_unid_negocio_grupo Createtb_unid_negocio_grupo(Int32? guneg_id = null, String guneg_descricao = null, String guneg_situacao = null, Nullable<DateTime> guneg_dt_cadastro = null, Nullable<DateTime> guneg_dt_alteracao = null, Nullable<Decimal> guneg_cpf_alteracao = null)
        {
            tb_unid_negocio_grupo value = CreateObject<tb_unid_negocio_grupo>();
            if (guneg_id != null)
                value.guneg_id = guneg_id.Value;
            if (guneg_descricao != null)
                value.guneg_descricao = guneg_descricao;
            if (guneg_situacao != null)
                value.guneg_situacao = guneg_situacao;
            if (guneg_dt_cadastro != null)
                value.guneg_dt_cadastro = guneg_dt_cadastro;
            if (guneg_dt_alteracao != null)
                value.guneg_dt_alteracao = guneg_dt_alteracao;
            if (guneg_cpf_alteracao != null)
                value.guneg_cpf_alteracao = guneg_cpf_alteracao;
            return value;
        }

        public tb_unid_negocio_parametro Createtb_unid_negocio_parametro(Int32? uneg_id = null, String par_msg_rodape = null, Nullable<Int32> par_ponto_tmp_seguranca = null, Nullable<Int32> par_ponto_tmp_apv_entrada = null, Nullable<Int32> par_ponto_tmp_apv_almoco_said = null, Nullable<Int32> par_ponto_tmp_apv_almoco_ret = null, Nullable<Int32> par_ponto_tmp_apv_saida = null, Nullable<Int32> par_ponto_meridiano_minutos = null, Nullable<DateTime> par_dt_alteracao = null, Nullable<Boolean> par_obriga_justif_diverg = null, Nullable<Boolean> par_obriga_anvisa = null, String par_obriga_comanda = null, String par_tef_IdLoja = null, String par_tef_IP = null, Nullable<Boolean> par_incluir_item_preVenda = null, Nullable<Boolean> par_vende_item_pdv = null, Nullable<Int32> par_metodo_resgate_preVenda = null, String par_venda_item_sem_cod_barra = null, Nullable<Int32> par_qtd_maxima_item = null, Nullable<Boolean> par_permite_qtd_fracionada = null, Nullable<Boolean> par_etiqueta_peso = null, Nullable<Boolean> par_altera_finalizadora_preVenda = null, String par_msg_livre_rodape_cupom_01 = null, String par_msg_livre_rodape_cupom_02 = null, String par_msg_livre_rodape_cupom_03 = null, String par_msg_livre_rodape_cupom_04 = null, String par_sistema_externo = null, String par_sistema_externo_ip_servidor = null, String par_sistema_externo_caminho_banco = null, Boolean? par_multi_vendedor = null, Nullable<Boolean> par_tem_preVenda = null, Nullable<Boolean> par_tem_dav = null, String par_aplica_desconto_cadastro = null, Nullable<Boolean> par_balcao_old = null, String par_controle_lote = null, Nullable<DateTime> par_data_ult_exp_cobol = null, Nullable<Boolean> par_mobile_dav = null)
        {
            tb_unid_negocio_parametro value = CreateObject<tb_unid_negocio_parametro>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (par_msg_rodape != null)
                value.par_msg_rodape = par_msg_rodape;
            if (par_ponto_tmp_seguranca != null)
                value.par_ponto_tmp_seguranca = par_ponto_tmp_seguranca;
            if (par_ponto_tmp_apv_entrada != null)
                value.par_ponto_tmp_apv_entrada = par_ponto_tmp_apv_entrada;
            if (par_ponto_tmp_apv_almoco_said != null)
                value.par_ponto_tmp_apv_almoco_said = par_ponto_tmp_apv_almoco_said;
            if (par_ponto_tmp_apv_almoco_ret != null)
                value.par_ponto_tmp_apv_almoco_ret = par_ponto_tmp_apv_almoco_ret;
            if (par_ponto_tmp_apv_saida != null)
                value.par_ponto_tmp_apv_saida = par_ponto_tmp_apv_saida;
            if (par_ponto_meridiano_minutos != null)
                value.par_ponto_meridiano_minutos = par_ponto_meridiano_minutos;
            if (par_dt_alteracao != null)
                value.par_dt_alteracao = par_dt_alteracao;
            if (par_obriga_justif_diverg != null)
                value.par_obriga_justif_diverg = par_obriga_justif_diverg;
            if (par_obriga_anvisa != null)
                value.par_obriga_anvisa = par_obriga_anvisa;
            if (par_obriga_comanda != null)
                value.par_obriga_comanda = par_obriga_comanda;
            if (par_tef_IdLoja != null)
                value.par_tef_IdLoja = par_tef_IdLoja;
            if (par_tef_IP != null)
                value.par_tef_IP = par_tef_IP;
            if (par_incluir_item_preVenda != null)
                value.par_incluir_item_preVenda = par_incluir_item_preVenda;
            if (par_vende_item_pdv != null)
                value.par_vende_item_pdv = par_vende_item_pdv;
            if (par_metodo_resgate_preVenda != null)
                value.par_metodo_resgate_preVenda = par_metodo_resgate_preVenda;
            if (par_venda_item_sem_cod_barra != null)
                value.par_venda_item_sem_cod_barra = par_venda_item_sem_cod_barra;
            if (par_qtd_maxima_item != null)
                value.par_qtd_maxima_item = par_qtd_maxima_item;
            if (par_permite_qtd_fracionada != null)
                value.par_permite_qtd_fracionada = par_permite_qtd_fracionada;
            if (par_etiqueta_peso != null)
                value.par_etiqueta_peso = par_etiqueta_peso;
            if (par_altera_finalizadora_preVenda != null)
                value.par_altera_finalizadora_preVenda = par_altera_finalizadora_preVenda;
            if (par_msg_livre_rodape_cupom_01 != null)
                value.par_msg_livre_rodape_cupom_01 = par_msg_livre_rodape_cupom_01;
            if (par_msg_livre_rodape_cupom_02 != null)
                value.par_msg_livre_rodape_cupom_02 = par_msg_livre_rodape_cupom_02;
            if (par_msg_livre_rodape_cupom_03 != null)
                value.par_msg_livre_rodape_cupom_03 = par_msg_livre_rodape_cupom_03;
            if (par_msg_livre_rodape_cupom_04 != null)
                value.par_msg_livre_rodape_cupom_04 = par_msg_livre_rodape_cupom_04;
            if (par_sistema_externo != null)
                value.par_sistema_externo = par_sistema_externo;
            if (par_sistema_externo_ip_servidor != null)
                value.par_sistema_externo_ip_servidor = par_sistema_externo_ip_servidor;
            if (par_sistema_externo_caminho_banco != null)
                value.par_sistema_externo_caminho_banco = par_sistema_externo_caminho_banco;
            if (par_multi_vendedor != null)
                value.par_multi_vendedor = par_multi_vendedor.Value;
            if (par_tem_preVenda != null)
                value.par_tem_preVenda = par_tem_preVenda;
            if (par_tem_dav != null)
                value.par_tem_dav = par_tem_dav;
            if (par_aplica_desconto_cadastro != null)
                value.par_aplica_desconto_cadastro = par_aplica_desconto_cadastro;
            if (par_balcao_old != null)
                value.par_balcao_old = par_balcao_old;
            if (par_controle_lote != null)
                value.par_controle_lote = par_controle_lote;
            if (par_data_ult_exp_cobol != null)
                value.par_data_ult_exp_cobol = par_data_ult_exp_cobol;
            if (par_mobile_dav != null)
                value.par_mobile_dav = par_mobile_dav;
            return value;
        }

        public tb_usuario Createtb_usuario(Int32? usr_id = null, String usr_cpf = null, String usr_nome = null, String usr_apelido = null, String usr_senha_local = null, Nullable<DateTime> usr_senha_tmp = null, Nullable<DateTime> usr_dt_alteracao_sync = null, String usr_situacao = null, Nullable<DateTime> usr_blq_dt_inicial = null, Nullable<DateTime> usr_blq_dt_final = null, Nullable<DateTime> usr_dt_cadastro = null, Nullable<DateTime> usr_dt_alteracao = null, Nullable<Boolean> usr_online = null, Nullable<Int32> func_id = null)
        {
            tb_usuario value = CreateObject<tb_usuario>();
            if (usr_id != null)
                value.usr_id = usr_id.Value;
            if (usr_cpf != null)
                value.usr_cpf = usr_cpf;
            if (usr_nome != null)
                value.usr_nome = usr_nome;
            if (usr_apelido != null)
                value.usr_apelido = usr_apelido;
            if (usr_senha_local != null)
                value.usr_senha_local = usr_senha_local;
            if (usr_senha_tmp != null)
                value.usr_senha_tmp = usr_senha_tmp;
            if (usr_dt_alteracao_sync != null)
                value.usr_dt_alteracao_sync = usr_dt_alteracao_sync;
            if (usr_situacao != null)
                value.usr_situacao = usr_situacao;
            if (usr_blq_dt_inicial != null)
                value.usr_blq_dt_inicial = usr_blq_dt_inicial;
            if (usr_blq_dt_final != null)
                value.usr_blq_dt_final = usr_blq_dt_final;
            if (usr_dt_cadastro != null)
                value.usr_dt_cadastro = usr_dt_cadastro;
            if (usr_dt_alteracao != null)
                value.usr_dt_alteracao = usr_dt_alteracao;
            if (usr_online != null)
                value.usr_online = usr_online;
            if (func_id != null)
                value.func_id = func_id;
            return value;
        }

        public tb_usuario_bloqueio Createtb_usuario_bloqueio(Int32? bloq_id = null, String bloq_descricao = null, String bloq_situacao = null, Nullable<DateTime> bloq_dt_cadastro = null, Nullable<DateTime> bloq_dt_alteracao = null)
        {
            tb_usuario_bloqueio value = CreateObject<tb_usuario_bloqueio>();
            if (bloq_id != null)
                value.bloq_id = bloq_id.Value;
            if (bloq_descricao != null)
                value.bloq_descricao = bloq_descricao;
            if (bloq_situacao != null)
                value.bloq_situacao = bloq_situacao;
            if (bloq_dt_cadastro != null)
                value.bloq_dt_cadastro = bloq_dt_cadastro;
            if (bloq_dt_alteracao != null)
                value.bloq_dt_alteracao = bloq_dt_alteracao;
            return value;
        }

        public tb_usuario_dpto Createtb_usuario_dpto(Int32? dpto_id = null, String dpto_nome = null, String dpto_situacao = null, Nullable<DateTime> dpto_dt_cadastro = null, Nullable<DateTime> dpto_dt_alteracao = null, Nullable<Decimal> dpto_cpf_alteracao = null, Nullable<Boolean> dpto_apl_planilha = null, Nullable<Boolean> dpto_apl_checkin = null, Nullable<Boolean> dpto_apl_entrada_nf = null, Nullable<Boolean> dpto_apl_consulta_preco = null, Nullable<Boolean> dpto_apl_alteracao_preco = null, Nullable<Boolean> dpto_apl_vnd_balcao = null, Nullable<Boolean> dpto_apl_pdv = null, Nullable<Boolean> dpto_apl_vnd_callcenter = null, Nullable<Boolean> dpto_apl_supervisor_callcenter = null, Nullable<Boolean> dpto_apl_etiquetas_loja = null, Nullable<Boolean> dpto_apl_vnd_atacado = null, Nullable<Boolean> dpto_apl_checkout_atacado = null, Nullable<Boolean> dpto_apl_fat_atacado = null, Nullable<Boolean> dpto_apl_etiquetas_atacado = null, Nullable<Boolean> dpto_apl_supervisor_atacado = null)
        {
            tb_usuario_dpto value = CreateObject<tb_usuario_dpto>();
            if (dpto_id != null)
                value.dpto_id = dpto_id.Value;
            if (dpto_nome != null)
                value.dpto_nome = dpto_nome;
            if (dpto_situacao != null)
                value.dpto_situacao = dpto_situacao;
            if (dpto_dt_cadastro != null)
                value.dpto_dt_cadastro = dpto_dt_cadastro;
            if (dpto_dt_alteracao != null)
                value.dpto_dt_alteracao = dpto_dt_alteracao;
            if (dpto_cpf_alteracao != null)
                value.dpto_cpf_alteracao = dpto_cpf_alteracao;
            if (dpto_apl_planilha != null)
                value.dpto_apl_planilha = dpto_apl_planilha;
            if (dpto_apl_checkin != null)
                value.dpto_apl_checkin = dpto_apl_checkin;
            if (dpto_apl_entrada_nf != null)
                value.dpto_apl_entrada_nf = dpto_apl_entrada_nf;
            if (dpto_apl_consulta_preco != null)
                value.dpto_apl_consulta_preco = dpto_apl_consulta_preco;
            if (dpto_apl_alteracao_preco != null)
                value.dpto_apl_alteracao_preco = dpto_apl_alteracao_preco;
            if (dpto_apl_vnd_balcao != null)
                value.dpto_apl_vnd_balcao = dpto_apl_vnd_balcao;
            if (dpto_apl_pdv != null)
                value.dpto_apl_pdv = dpto_apl_pdv;
            if (dpto_apl_vnd_callcenter != null)
                value.dpto_apl_vnd_callcenter = dpto_apl_vnd_callcenter;
            if (dpto_apl_supervisor_callcenter != null)
                value.dpto_apl_supervisor_callcenter = dpto_apl_supervisor_callcenter;
            if (dpto_apl_etiquetas_loja != null)
                value.dpto_apl_etiquetas_loja = dpto_apl_etiquetas_loja;
            if (dpto_apl_vnd_atacado != null)
                value.dpto_apl_vnd_atacado = dpto_apl_vnd_atacado;
            if (dpto_apl_checkout_atacado != null)
                value.dpto_apl_checkout_atacado = dpto_apl_checkout_atacado;
            if (dpto_apl_fat_atacado != null)
                value.dpto_apl_fat_atacado = dpto_apl_fat_atacado;
            if (dpto_apl_etiquetas_atacado != null)
                value.dpto_apl_etiquetas_atacado = dpto_apl_etiquetas_atacado;
            if (dpto_apl_supervisor_atacado != null)
                value.dpto_apl_supervisor_atacado = dpto_apl_supervisor_atacado;
            return value;
        }

        public tb_usuario_funcao Createtb_usuario_funcao(Int32? funcao_id = null, String funcao_descricao = null, Nullable<Boolean> funcao_param_lj_ponto = null, String funcao_situacao = null, Nullable<Boolean> funcao_cancela_venda = null, Nullable<Boolean> funcao_cancela_vendaItem = null, Nullable<Boolean> funcao_desconto_vendaItem = null, Nullable<Boolean> funcao_desconto_venda = null, Nullable<Boolean> funcao_gerenciar_ponto = null, Nullable<Boolean> funcao_reiniciar_setup = null, Nullable<Boolean> funcao_menu_gerencial = null, Nullable<Boolean> funcao_fundo_caixa = null, Nullable<Boolean> funcao_sangria = null, Nullable<Boolean> funcao_despesa = null, Nullable<DateTime> funcao_dt_cadastro = null, Nullable<DateTime> funcao_dt_alteracao = null, Nullable<Boolean> funcao_vendaItem_semCodBarra = null, Nullable<Boolean> funcao_libera_lote = null)
        {
            tb_usuario_funcao value = CreateObject<tb_usuario_funcao>();
            if (funcao_id != null)
                value.funcao_id = funcao_id.Value;
            if (funcao_descricao != null)
                value.funcao_descricao = funcao_descricao;
            if (funcao_param_lj_ponto != null)
                value.funcao_param_lj_ponto = funcao_param_lj_ponto;
            if (funcao_situacao != null)
                value.funcao_situacao = funcao_situacao;
            if (funcao_cancela_venda != null)
                value.funcao_cancela_venda = funcao_cancela_venda;
            if (funcao_cancela_vendaItem != null)
                value.funcao_cancela_vendaItem = funcao_cancela_vendaItem;
            if (funcao_desconto_vendaItem != null)
                value.funcao_desconto_vendaItem = funcao_desconto_vendaItem;
            if (funcao_desconto_venda != null)
                value.funcao_desconto_venda = funcao_desconto_venda;
            if (funcao_gerenciar_ponto != null)
                value.funcao_gerenciar_ponto = funcao_gerenciar_ponto;
            if (funcao_reiniciar_setup != null)
                value.funcao_reiniciar_setup = funcao_reiniciar_setup;
            if (funcao_menu_gerencial != null)
                value.funcao_menu_gerencial = funcao_menu_gerencial;
            if (funcao_fundo_caixa != null)
                value.funcao_fundo_caixa = funcao_fundo_caixa;
            if (funcao_sangria != null)
                value.funcao_sangria = funcao_sangria;
            if (funcao_despesa != null)
                value.funcao_despesa = funcao_despesa;
            if (funcao_dt_cadastro != null)
                value.funcao_dt_cadastro = funcao_dt_cadastro;
            if (funcao_dt_alteracao != null)
                value.funcao_dt_alteracao = funcao_dt_alteracao;
            if (funcao_vendaItem_semCodBarra != null)
                value.funcao_vendaItem_semCodBarra = funcao_vendaItem_semCodBarra;
            if (funcao_libera_lote != null)
                value.funcao_libera_lote = funcao_libera_lote;
            return value;
        }

        public tb_usuario_grupo Createtb_usuario_grupo(Int32? grp_id = null, String grp_nome = null, String grp_diautil = null, String grp_sabado = null, String grp_domingo = null, String grp_feriado = null, Nullable<Decimal> grp_tmp_senha = null, Nullable<Boolean> grp_acesso_filial_ilimitada = null, String grp_situacao = null, Nullable<DateTime> grp_dt_cadastro = null, Nullable<DateTime> grp_dt_alteracao = null)
        {
            tb_usuario_grupo value = CreateObject<tb_usuario_grupo>();
            if (grp_id != null)
                value.grp_id = grp_id.Value;
            if (grp_nome != null)
                value.grp_nome = grp_nome;
            if (grp_diautil != null)
                value.grp_diautil = grp_diautil;
            if (grp_sabado != null)
                value.grp_sabado = grp_sabado;
            if (grp_domingo != null)
                value.grp_domingo = grp_domingo;
            if (grp_feriado != null)
                value.grp_feriado = grp_feriado;
            if (grp_tmp_senha != null)
                value.grp_tmp_senha = grp_tmp_senha;
            if (grp_acesso_filial_ilimitada != null)
                value.grp_acesso_filial_ilimitada = grp_acesso_filial_ilimitada;
            if (grp_situacao != null)
                value.grp_situacao = grp_situacao;
            if (grp_dt_cadastro != null)
                value.grp_dt_cadastro = grp_dt_cadastro;
            if (grp_dt_alteracao != null)
                value.grp_dt_alteracao = grp_dt_alteracao;
            return value;
        }

        public tb_venda Createtb_venda(Int32? venda_id = null, Int32? uneg_id = null, Int32? venda_pdv = null, DateTime? venda_data = null, Nullable<Int32> ecf_numero_ecf = null, Nullable<Decimal> venda_num_cupom = null, String venda_tipo = null, Nullable<Int32> venda_vendedor_id = null, Nullable<Boolean> venda_cli_fidelizacao = null, Nullable<Int32> venda_prevenda_id = null, Nullable<DateTime> venda_prevenda_data = null, Nullable<Int32> venda_prevenda_uneg_id = null, Nullable<Int32> venda_prevenda_pdv = null, Nullable<Decimal> venda_tot_acrescimo = null, Nullable<Int32> venda_tot_itens = null, Nullable<Decimal> venda_tot_quant = null, Nullable<Decimal> venda_tot_valor = null, Nullable<Decimal> venda_tot_preco = null, Nullable<Decimal> venda_tot_preco_padrao = null, Nullable<Decimal> venda_tot_preco_praticado = null, Nullable<Decimal> venda_tot_preco_Reembolso = null, Nullable<Decimal> venda_tot_preco_avista = null, Nullable<Decimal> venda_tot_custo = null, Nullable<Decimal> venda_vlr_comissao = null, Nullable<Decimal> venda_vlr_desc = null, Nullable<Decimal> venda_vlr_desc_fin = null, Nullable<Int32> venda_vlr_desc_usr_id = null, Nullable<Boolean> venda_cancelada = null, Nullable<DateTime> venda_cancelada_data = null, Nullable<Int32> venda_cancelada_usr_id = null, Nullable<Decimal> venda_cancelada_coo = null, Boolean? venda_cancelamento_paf = null, String venda_ccf = null, String venda_coo_cupom_vinculado = null, Nullable<Boolean> venda_finalizada = null, String venda_obs = null, String venda_md5 = null, String venda_status = null, Nullable<DateTime> venda_data_fiscal = null, Nullable<DateTime> venda_data_cupom_ecf = null, String venda_pre_venda = null, String venda_num_paf = null, Nullable<Decimal> venda_operadorcx_id = null, Nullable<Int32> venda_atendente_id = null, Nullable<Int64> venda_fpop_autorizacao = null, Nullable<Int32> venda_telefone_id = null, Nullable<DateTime> venda_dt_entrega = null, String venda_observacao = null, String venda_entrega_situacao = null, Nullable<DateTime> venda_entrega_dt_separacao = null, Nullable<DateTime> venda_entrega_dt_retorno = null, Nullable<DateTime> venda_entrega_dt_saida = null, Nullable<Int32> venda_entrega_id_entregador = null, Nullable<Int32> venda_entrega_operadorcx_retorno = null, String venda_pbm_autorizacao_num = null, String venda_pbm_autorizacao_tipo = null, Nullable<Int64> venda_pbm_cpf = null, Nullable<Int64> venda_pbm_cnpj = null, Nullable<DateTime> venda_dt_alteracao = null, String venda_nfce_chave = null, String venda_nfce_protocolo = null, Nullable<Int32> venda_conferente_id = null, Nullable<Int32> cnv_id = null, Nullable<Int32> pbm_id = null, Nullable<Int64> end_telefone = null, Nullable<Int32> polo_id = null, Nullable<Int32> quadra_id = null, Nullable<Int32> rota_id = null, Nullable<Int32> arearisco_id = null)
        {
            tb_venda value = CreateObject<tb_venda>();
            if (venda_id != null)
                value.venda_id = venda_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv.Value;
            if (venda_data != null)
                value.venda_data = venda_data.Value;
            if (ecf_numero_ecf != null)
                value.ecf_numero_ecf = ecf_numero_ecf;
            if (venda_num_cupom != null)
                value.venda_num_cupom = venda_num_cupom;
            if (venda_tipo != null)
                value.venda_tipo = venda_tipo;
            if (venda_vendedor_id != null)
                value.venda_vendedor_id = venda_vendedor_id;
            if (venda_cli_fidelizacao != null)
                value.venda_cli_fidelizacao = venda_cli_fidelizacao;
            if (venda_prevenda_id != null)
                value.venda_prevenda_id = venda_prevenda_id;
            if (venda_prevenda_data != null)
                value.venda_prevenda_data = venda_prevenda_data;
            if (venda_prevenda_uneg_id != null)
                value.venda_prevenda_uneg_id = venda_prevenda_uneg_id;
            if (venda_prevenda_pdv != null)
                value.venda_prevenda_pdv = venda_prevenda_pdv;
            if (venda_tot_acrescimo != null)
                value.venda_tot_acrescimo = venda_tot_acrescimo;
            if (venda_tot_itens != null)
                value.venda_tot_itens = venda_tot_itens;
            if (venda_tot_quant != null)
                value.venda_tot_quant = venda_tot_quant;
            if (venda_tot_valor != null)
                value.venda_tot_valor = venda_tot_valor;
            if (venda_tot_preco != null)
                value.venda_tot_preco = venda_tot_preco;
            if (venda_tot_preco_padrao != null)
                value.venda_tot_preco_padrao = venda_tot_preco_padrao;
            if (venda_tot_preco_praticado != null)
                value.venda_tot_preco_praticado = venda_tot_preco_praticado;
            if (venda_tot_preco_Reembolso != null)
                value.venda_tot_preco_Reembolso = venda_tot_preco_Reembolso;
            if (venda_tot_preco_avista != null)
                value.venda_tot_preco_avista = venda_tot_preco_avista;
            if (venda_tot_custo != null)
                value.venda_tot_custo = venda_tot_custo;
            if (venda_vlr_comissao != null)
                value.venda_vlr_comissao = venda_vlr_comissao;
            if (venda_vlr_desc != null)
                value.venda_vlr_desc = venda_vlr_desc;
            if (venda_vlr_desc_fin != null)
                value.venda_vlr_desc_fin = venda_vlr_desc_fin;
            if (venda_vlr_desc_usr_id != null)
                value.venda_vlr_desc_usr_id = venda_vlr_desc_usr_id;
            if (venda_cancelada != null)
                value.venda_cancelada = venda_cancelada;
            if (venda_cancelada_data != null)
                value.venda_cancelada_data = venda_cancelada_data;
            if (venda_cancelada_usr_id != null)
                value.venda_cancelada_usr_id = venda_cancelada_usr_id;
            if (venda_cancelada_coo != null)
                value.venda_cancelada_coo = venda_cancelada_coo;
            if (venda_cancelamento_paf != null)
                value.venda_cancelamento_paf = venda_cancelamento_paf.Value;
            if (venda_ccf != null)
                value.venda_ccf = venda_ccf;
            if (venda_coo_cupom_vinculado != null)
                value.venda_coo_cupom_vinculado = venda_coo_cupom_vinculado;
            if (venda_finalizada != null)
                value.venda_finalizada = venda_finalizada;
            if (venda_obs != null)
                value.venda_obs = venda_obs;
            if (venda_md5 != null)
                value.venda_md5 = venda_md5;
            if (venda_status != null)
                value.venda_status = venda_status;
            if (venda_data_fiscal != null)
                value.venda_data_fiscal = venda_data_fiscal;
            if (venda_data_cupom_ecf != null)
                value.venda_data_cupom_ecf = venda_data_cupom_ecf;
            if (venda_pre_venda != null)
                value.venda_pre_venda = venda_pre_venda;
            if (venda_num_paf != null)
                value.venda_num_paf = venda_num_paf;
            if (venda_operadorcx_id != null)
                value.venda_operadorcx_id = venda_operadorcx_id;
            if (venda_atendente_id != null)
                value.venda_atendente_id = venda_atendente_id;
            if (venda_fpop_autorizacao != null)
                value.venda_fpop_autorizacao = venda_fpop_autorizacao;
            if (venda_telefone_id != null)
                value.venda_telefone_id = venda_telefone_id;
            if (venda_dt_entrega != null)
                value.venda_dt_entrega = venda_dt_entrega;
            if (venda_observacao != null)
                value.venda_observacao = venda_observacao;
            if (venda_entrega_situacao != null)
                value.venda_entrega_situacao = venda_entrega_situacao;
            if (venda_entrega_dt_separacao != null)
                value.venda_entrega_dt_separacao = venda_entrega_dt_separacao;
            if (venda_entrega_dt_retorno != null)
                value.venda_entrega_dt_retorno = venda_entrega_dt_retorno;
            if (venda_entrega_dt_saida != null)
                value.venda_entrega_dt_saida = venda_entrega_dt_saida;
            if (venda_entrega_id_entregador != null)
                value.venda_entrega_id_entregador = venda_entrega_id_entregador;
            if (venda_entrega_operadorcx_retorno != null)
                value.venda_entrega_operadorcx_retorno = venda_entrega_operadorcx_retorno;
            if (venda_pbm_autorizacao_num != null)
                value.venda_pbm_autorizacao_num = venda_pbm_autorizacao_num;
            if (venda_pbm_autorizacao_tipo != null)
                value.venda_pbm_autorizacao_tipo = venda_pbm_autorizacao_tipo;
            if (venda_pbm_cpf != null)
                value.venda_pbm_cpf = venda_pbm_cpf;
            if (venda_pbm_cnpj != null)
                value.venda_pbm_cnpj = venda_pbm_cnpj;
            if (venda_dt_alteracao != null)
                value.venda_dt_alteracao = venda_dt_alteracao;
            if (venda_nfce_chave != null)
                value.venda_nfce_chave = venda_nfce_chave;
            if (venda_nfce_protocolo != null)
                value.venda_nfce_protocolo = venda_nfce_protocolo;
            if (venda_conferente_id != null)
                value.venda_conferente_id = venda_conferente_id;
            if (cnv_id != null)
                value.cnv_id = cnv_id;
            if (pbm_id != null)
                value.pbm_id = pbm_id;
            if (end_telefone != null)
                value.end_telefone = end_telefone;
            if (polo_id != null)
                value.polo_id = polo_id;
            if (quadra_id != null)
                value.quadra_id = quadra_id;
            if (rota_id != null)
                value.rota_id = rota_id;
            if (arearisco_id != null)
                value.arearisco_id = arearisco_id;
            return value;
        }

        public tb_venda_dav Createtb_venda_dav(Int32? venda_dav_id = null, DateTime? venda_dav_data_preVenda = null, Int32? uneg_id = null, Int32? venda_pdv = null, Nullable<Int32> venda_id = null, Nullable<DateTime> venda_data = null, String venda_dav_num_preVenda = null, String venda_dav_num_comanda = null, String venda_dav_status = null, Nullable<Decimal> venda_dav_valorTotal = null, String venda_dav_paf_numero = null, Nullable<DateTime> venda_dav_data_alteracao = null, Nullable<Int32> venda_dav_id_origem = null, Nullable<Int32> uneg_id_origem = null, Nullable<DateTime> venda_dav_data_preVenda_origem = null, Nullable<Int32> venda_pdv_origem = null, String venda_dav_nome_arquivo = null, Nullable<Int32> venda_dav_cancela_vendedor_id = null, Nullable<Int32> venda_dav_itens = null, Nullable<Decimal> venda_dav_desconto_final = null, Nullable<DateTime> venda_dav_data_emissao = null, Nullable<Int32> venda_dav_numero_controle = null, String ecf_numero_serie_emissao = null, Nullable<Int32> venda_dav_coo_emissao = null, Nullable<Int32> venda_dav_gnf_emissao = null, String venda_dav_nome_adquirente = null, Nullable<Int32> venda_dav_num_ecf_venda = null, Nullable<Int32> venda_dav_coo_venda = null, Nullable<Int32> venda_dav_coo_cupom_vinculado_venda = null, String venda_dav_titulo = null, String vendaPv_chave_acesso_nfe = null, String cli_fisc_cpf_cnpj = null, String ecf_numero_serie_fechamento_cupom = null, String venda_dav_md5 = null, String dav_status = null, Nullable<Int32> cnv_id = null)
        {
            tb_venda_dav value = CreateObject<tb_venda_dav>();
            if (venda_dav_id != null)
                value.venda_dav_id = venda_dav_id.Value;
            if (venda_dav_data_preVenda != null)
                value.venda_dav_data_preVenda = venda_dav_data_preVenda.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv.Value;
            if (venda_id != null)
                value.venda_id = venda_id;
            if (venda_data != null)
                value.venda_data = venda_data;
            if (venda_dav_num_preVenda != null)
                value.venda_dav_num_preVenda = venda_dav_num_preVenda;
            if (venda_dav_num_comanda != null)
                value.venda_dav_num_comanda = venda_dav_num_comanda;
            if (venda_dav_status != null)
                value.venda_dav_status = venda_dav_status;
            if (venda_dav_valorTotal != null)
                value.venda_dav_valorTotal = venda_dav_valorTotal;
            if (venda_dav_paf_numero != null)
                value.venda_dav_paf_numero = venda_dav_paf_numero;
            if (venda_dav_data_alteracao != null)
                value.venda_dav_data_alteracao = venda_dav_data_alteracao;
            if (venda_dav_id_origem != null)
                value.venda_dav_id_origem = venda_dav_id_origem;
            if (uneg_id_origem != null)
                value.uneg_id_origem = uneg_id_origem;
            if (venda_dav_data_preVenda_origem != null)
                value.venda_dav_data_preVenda_origem = venda_dav_data_preVenda_origem;
            if (venda_pdv_origem != null)
                value.venda_pdv_origem = venda_pdv_origem;
            if (venda_dav_nome_arquivo != null)
                value.venda_dav_nome_arquivo = venda_dav_nome_arquivo;
            if (venda_dav_cancela_vendedor_id != null)
                value.venda_dav_cancela_vendedor_id = venda_dav_cancela_vendedor_id;
            if (venda_dav_itens != null)
                value.venda_dav_itens = venda_dav_itens;
            if (venda_dav_desconto_final != null)
                value.venda_dav_desconto_final = venda_dav_desconto_final;
            if (venda_dav_data_emissao != null)
                value.venda_dav_data_emissao = venda_dav_data_emissao;
            if (venda_dav_numero_controle != null)
                value.venda_dav_numero_controle = venda_dav_numero_controle;
            if (ecf_numero_serie_emissao != null)
                value.ecf_numero_serie_emissao = ecf_numero_serie_emissao;
            if (venda_dav_coo_emissao != null)
                value.venda_dav_coo_emissao = venda_dav_coo_emissao;
            if (venda_dav_gnf_emissao != null)
                value.venda_dav_gnf_emissao = venda_dav_gnf_emissao;
            if (venda_dav_nome_adquirente != null)
                value.venda_dav_nome_adquirente = venda_dav_nome_adquirente;
            if (venda_dav_num_ecf_venda != null)
                value.venda_dav_num_ecf_venda = venda_dav_num_ecf_venda;
            if (venda_dav_coo_venda != null)
                value.venda_dav_coo_venda = venda_dav_coo_venda;
            if (venda_dav_coo_cupom_vinculado_venda != null)
                value.venda_dav_coo_cupom_vinculado_venda = venda_dav_coo_cupom_vinculado_venda;
            if (venda_dav_titulo != null)
                value.venda_dav_titulo = venda_dav_titulo;
            if (vendaPv_chave_acesso_nfe != null)
                value.vendaPv_chave_acesso_nfe = vendaPv_chave_acesso_nfe;
            if (cli_fisc_cpf_cnpj != null)
                value.cli_fisc_cpf_cnpj = cli_fisc_cpf_cnpj;
            if (ecf_numero_serie_fechamento_cupom != null)
                value.ecf_numero_serie_fechamento_cupom = ecf_numero_serie_fechamento_cupom;
            if (venda_dav_md5 != null)
                value.venda_dav_md5 = venda_dav_md5;
            if (dav_status != null)
                value.dav_status = dav_status;
            if (cnv_id != null)
                value.cnv_id = cnv_id;
            return value;
        }

        public tb_venda_dav_item Createtb_venda_dav_item(Int32? venda_dav_item_id = null, DateTime? venda_dav_data_preVenda = null, Int32? venda_dav_id = null, Int32? uneg_id = null, Int32? venda_pdv = null, Nullable<Int32> venda_id = null, Nullable<Int64> venda_dav_item_autorizacao = null, Nullable<Int32> venda_dav_item_codigo = null, String venda_dav_item_cpfCnpj = null, String venda_dav_item_descricao = null, String venda_dav_item_ean13 = null, Nullable<Boolean> venda_dav_item_marcaAgpuc = null, Nullable<Decimal> venda_dav_item_preco = null, Nullable<Decimal> venda_dav_item_precoPraticado = null, Nullable<Decimal> venda_dav_item_precoPadrao = null, Nullable<Decimal> venda_dav_item_precoReal = null, Nullable<Decimal> venda_dav_item_precoReembolso = null, Nullable<Decimal> venda_dav_item_precoVista = null, Nullable<Int32> venda_dav_item_quantidade = null, Nullable<Decimal> venda_dav_item_totalValor = null, Nullable<Decimal> venda_dav_item_valorDesconto = null, Nullable<Int32> venda_dav_item_vendedor_id = null, Nullable<DateTime> venda_dav_item_data = null, String venda_dav_item_status = null, Nullable<Int64> venda_dav_item_cancela_vendedor_id = null, String venda_dav_item_vidaLink = null, Nullable<DateTime> venda_dav_item_receita_data = null, String venda_dav_item_receita_notificacao_num = null, String venda_dav_item_receita_notificacao_tipo = null, String venda_dav_item_comprador_nome = null, Nullable<Decimal> venda_dav_item_comprador_tipdoc = null, String venda_dav_item_comprador_doc = null, String venda_dav_item_comprador_oexped = null, String venda_dav_item_comprador_uf = null, String venda_dav_item_paciente_doc = null, String venda_dav_item_paciente_nome = null, String venda_dav_item_paciente_sexo = null, Nullable<DateTime> venda_dav_item_paciente_dt_nascimento = null, String venda_dav_item_paciente_cid = null, String venda_dav_item_lote_numero = null, Nullable<DateTime> venda_dav_item_lote_validade = null, Nullable<DateTime> venda_dav_item_lote_fabricacao = null, Nullable<Decimal> venda_dav_item_lote_vlr_pmc = null, Nullable<Int32> venda_dav_item_fpop_qtde_diaria = null, Nullable<Int32> venda_dav_item_fpop_qtde_unitaria = null, Nullable<Int32> crm_id = null, Nullable<Int32> treceita_id = null)
        {
            tb_venda_dav_item value = CreateObject<tb_venda_dav_item>();
            if (venda_dav_item_id != null)
                value.venda_dav_item_id = venda_dav_item_id.Value;
            if (venda_dav_data_preVenda != null)
                value.venda_dav_data_preVenda = venda_dav_data_preVenda.Value;
            if (venda_dav_id != null)
                value.venda_dav_id = venda_dav_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv.Value;
            if (venda_id != null)
                value.venda_id = venda_id;
            if (venda_dav_item_autorizacao != null)
                value.venda_dav_item_autorizacao = venda_dav_item_autorizacao;
            if (venda_dav_item_codigo != null)
                value.venda_dav_item_codigo = venda_dav_item_codigo;
            if (venda_dav_item_cpfCnpj != null)
                value.venda_dav_item_cpfCnpj = venda_dav_item_cpfCnpj;
            if (venda_dav_item_descricao != null)
                value.venda_dav_item_descricao = venda_dav_item_descricao;
            if (venda_dav_item_ean13 != null)
                value.venda_dav_item_ean13 = venda_dav_item_ean13;
            if (venda_dav_item_marcaAgpuc != null)
                value.venda_dav_item_marcaAgpuc = venda_dav_item_marcaAgpuc;
            if (venda_dav_item_preco != null)
                value.venda_dav_item_preco = venda_dav_item_preco;
            if (venda_dav_item_precoPraticado != null)
                value.venda_dav_item_precoPraticado = venda_dav_item_precoPraticado;
            if (venda_dav_item_precoPadrao != null)
                value.venda_dav_item_precoPadrao = venda_dav_item_precoPadrao;
            if (venda_dav_item_precoReal != null)
                value.venda_dav_item_precoReal = venda_dav_item_precoReal;
            if (venda_dav_item_precoReembolso != null)
                value.venda_dav_item_precoReembolso = venda_dav_item_precoReembolso;
            if (venda_dav_item_precoVista != null)
                value.venda_dav_item_precoVista = venda_dav_item_precoVista;
            if (venda_dav_item_quantidade != null)
                value.venda_dav_item_quantidade = venda_dav_item_quantidade;
            if (venda_dav_item_totalValor != null)
                value.venda_dav_item_totalValor = venda_dav_item_totalValor;
            if (venda_dav_item_valorDesconto != null)
                value.venda_dav_item_valorDesconto = venda_dav_item_valorDesconto;
            if (venda_dav_item_vendedor_id != null)
                value.venda_dav_item_vendedor_id = venda_dav_item_vendedor_id;
            if (venda_dav_item_data != null)
                value.venda_dav_item_data = venda_dav_item_data;
            if (venda_dav_item_status != null)
                value.venda_dav_item_status = venda_dav_item_status;
            if (venda_dav_item_cancela_vendedor_id != null)
                value.venda_dav_item_cancela_vendedor_id = venda_dav_item_cancela_vendedor_id;
            if (venda_dav_item_vidaLink != null)
                value.venda_dav_item_vidaLink = venda_dav_item_vidaLink;
            if (venda_dav_item_receita_data != null)
                value.venda_dav_item_receita_data = venda_dav_item_receita_data;
            if (venda_dav_item_receita_notificacao_num != null)
                value.venda_dav_item_receita_notificacao_num = venda_dav_item_receita_notificacao_num;
            if (venda_dav_item_receita_notificacao_tipo != null)
                value.venda_dav_item_receita_notificacao_tipo = venda_dav_item_receita_notificacao_tipo;
            if (venda_dav_item_comprador_nome != null)
                value.venda_dav_item_comprador_nome = venda_dav_item_comprador_nome;
            if (venda_dav_item_comprador_tipdoc != null)
                value.venda_dav_item_comprador_tipdoc = venda_dav_item_comprador_tipdoc;
            if (venda_dav_item_comprador_doc != null)
                value.venda_dav_item_comprador_doc = venda_dav_item_comprador_doc;
            if (venda_dav_item_comprador_oexped != null)
                value.venda_dav_item_comprador_oexped = venda_dav_item_comprador_oexped;
            if (venda_dav_item_comprador_uf != null)
                value.venda_dav_item_comprador_uf = venda_dav_item_comprador_uf;
            if (venda_dav_item_paciente_doc != null)
                value.venda_dav_item_paciente_doc = venda_dav_item_paciente_doc;
            if (venda_dav_item_paciente_nome != null)
                value.venda_dav_item_paciente_nome = venda_dav_item_paciente_nome;
            if (venda_dav_item_paciente_sexo != null)
                value.venda_dav_item_paciente_sexo = venda_dav_item_paciente_sexo;
            if (venda_dav_item_paciente_dt_nascimento != null)
                value.venda_dav_item_paciente_dt_nascimento = venda_dav_item_paciente_dt_nascimento;
            if (venda_dav_item_paciente_cid != null)
                value.venda_dav_item_paciente_cid = venda_dav_item_paciente_cid;
            if (venda_dav_item_lote_numero != null)
                value.venda_dav_item_lote_numero = venda_dav_item_lote_numero;
            if (venda_dav_item_lote_validade != null)
                value.venda_dav_item_lote_validade = venda_dav_item_lote_validade;
            if (venda_dav_item_lote_fabricacao != null)
                value.venda_dav_item_lote_fabricacao = venda_dav_item_lote_fabricacao;
            if (venda_dav_item_lote_vlr_pmc != null)
                value.venda_dav_item_lote_vlr_pmc = venda_dav_item_lote_vlr_pmc;
            if (venda_dav_item_fpop_qtde_diaria != null)
                value.venda_dav_item_fpop_qtde_diaria = venda_dav_item_fpop_qtde_diaria;
            if (venda_dav_item_fpop_qtde_unitaria != null)
                value.venda_dav_item_fpop_qtde_unitaria = venda_dav_item_fpop_qtde_unitaria;
            if (crm_id != null)
                value.crm_id = crm_id;
            if (treceita_id != null)
                value.treceita_id = treceita_id;
            return value;
        }

        public tb_venda_estorno_tef Createtb_venda_estorno_tef(Int32? vestef_id = null, Int32? uneg_id = null, Int32? venda_id = null, Int32? venda_pdv = null, DateTime? venda_data = null, Int32? vpag_id = null, Decimal? vestef_usr_mat = null, Decimal? vestef_vendedor_mat = null)
        {
            tb_venda_estorno_tef value = CreateObject<tb_venda_estorno_tef>();
            if (vestef_id != null)
                value.vestef_id = vestef_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (venda_id != null)
                value.venda_id = venda_id.Value;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv.Value;
            if (venda_data != null)
                value.venda_data = venda_data.Value;
            if (vpag_id != null)
                value.vpag_id = vpag_id.Value;
            if (vestef_usr_mat != null)
                value.vestef_usr_mat = vestef_usr_mat.Value;
            if (vestef_vendedor_mat != null)
                value.vestef_vendedor_mat = vestef_vendedor_mat.Value;
            return value;
        }

        public tb_venda_item Createtb_venda_item(Int32? uneg_id = null, Int32? venda_id = null, Int32? venda_pdv = null, DateTime? venda_data = null, Int32? vitem_id = null, Nullable<Int32> vitem_sequencia_impressora = null, String vitem_descricao = null, Nullable<Decimal> vitem_qtde = null, Nullable<Decimal> vitem_preco = null, Nullable<Decimal> vitem_preco_padrao = null, Nullable<Decimal> vitem_preco_praticado = null, Nullable<Decimal> vitem_preco_real = null, Nullable<Decimal> vitem_preco_reembolso = null, Nullable<Decimal> vitem_preco_a_vista = null, Nullable<Decimal> vitem_desconto = null, Nullable<Int32> vitem_desconto_percent = null, Nullable<Int32> vitem_desc_aut_usr_mat = null, Nullable<Decimal> vitem_desc_financ = null, Nullable<Decimal> vitem_custo_medio = null, Nullable<Decimal> vitem_comissao = null, Nullable<Int32> vitem_comissao_percent = null, Nullable<Int32> vitem_vendedor_id = null, Nullable<Decimal> vitem_ean_pistolado = null, String vitem_sit_trib = null, String vitem_situacao = null, Nullable<Int32> vitem_cancel_usr_mat = null, Nullable<DateTime> vitem_cancel_data = null, String vitem_md5 = null, Nullable<Int32> vitem_id_cancelado = null, Nullable<Decimal> barra_codigo = null, Nullable<Boolean> vitem_pre_venda = null, Nullable<Decimal> vitem_tot_preco = null, Nullable<Decimal> vitem_tot_preco_padrao = null, Nullable<Decimal> vitem_tot_preco_praticado = null, Nullable<Decimal> vitem_tot_preco_real = null, Nullable<Decimal> vitem_tot_preco_Reembolso = null, Nullable<Decimal> vitem_tot_preco_a_vista = null, Nullable<Decimal> vitem_tot_custo_medio = null, Nullable<Decimal> vitem_tot_comissao = null, Nullable<Decimal> vitem_tot_desconto = null, Nullable<Decimal> vitem_tot_desc_financ = null, String vitem_vidaLink = null, Nullable<DateTime> vitem_receita_data = null, String vitem_receita_notificacao_num = null, String vitem_receita_notificacao_tipo = null, String vitem_comprador_nome = null, Nullable<Decimal> vitem_comprador_tipdoc = null, String vitem_comprador_doc = null, String vitem_comprador_oexped = null, String vitem_comprador_uf = null, String vitem_paciente_oexped = null, String vitem_paciente_doc = null, String vitem_paciente_nome = null, String vitem_paciente_sexo = null, Nullable<DateTime> vitem_paciente_dt_nascimento = null, String vitem_paciente_cid = null, String vitem_lote_numero = null, Nullable<DateTime> vitem_lote_validade = null, Nullable<DateTime> vitem_lote_fabricacao = null, Nullable<Decimal> vitem_lote_vlr_pmc = null, Nullable<Int32> vitem_fpop_qtde_Diaria = null, Nullable<Int32> vitem_fpop_qtde_Unitaria = null, Nullable<Int32> treceita_id = null, Nullable<Int32> crm_id = null)
        {
            tb_venda_item value = CreateObject<tb_venda_item>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (venda_id != null)
                value.venda_id = venda_id.Value;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv.Value;
            if (venda_data != null)
                value.venda_data = venda_data.Value;
            if (vitem_id != null)
                value.vitem_id = vitem_id.Value;
            if (vitem_sequencia_impressora != null)
                value.vitem_sequencia_impressora = vitem_sequencia_impressora;
            if (vitem_descricao != null)
                value.vitem_descricao = vitem_descricao;
            if (vitem_qtde != null)
                value.vitem_qtde = vitem_qtde;
            if (vitem_preco != null)
                value.vitem_preco = vitem_preco;
            if (vitem_preco_padrao != null)
                value.vitem_preco_padrao = vitem_preco_padrao;
            if (vitem_preco_praticado != null)
                value.vitem_preco_praticado = vitem_preco_praticado;
            if (vitem_preco_real != null)
                value.vitem_preco_real = vitem_preco_real;
            if (vitem_preco_reembolso != null)
                value.vitem_preco_reembolso = vitem_preco_reembolso;
            if (vitem_preco_a_vista != null)
                value.vitem_preco_a_vista = vitem_preco_a_vista;
            if (vitem_desconto != null)
                value.vitem_desconto = vitem_desconto;
            if (vitem_desconto_percent != null)
                value.vitem_desconto_percent = vitem_desconto_percent;
            if (vitem_desc_aut_usr_mat != null)
                value.vitem_desc_aut_usr_mat = vitem_desc_aut_usr_mat;
            if (vitem_desc_financ != null)
                value.vitem_desc_financ = vitem_desc_financ;
            if (vitem_custo_medio != null)
                value.vitem_custo_medio = vitem_custo_medio;
            if (vitem_comissao != null)
                value.vitem_comissao = vitem_comissao;
            if (vitem_comissao_percent != null)
                value.vitem_comissao_percent = vitem_comissao_percent;
            if (vitem_vendedor_id != null)
                value.vitem_vendedor_id = vitem_vendedor_id;
            if (vitem_ean_pistolado != null)
                value.vitem_ean_pistolado = vitem_ean_pistolado;
            if (vitem_sit_trib != null)
                value.vitem_sit_trib = vitem_sit_trib;
            if (vitem_situacao != null)
                value.vitem_situacao = vitem_situacao;
            if (vitem_cancel_usr_mat != null)
                value.vitem_cancel_usr_mat = vitem_cancel_usr_mat;
            if (vitem_cancel_data != null)
                value.vitem_cancel_data = vitem_cancel_data;
            if (vitem_md5 != null)
                value.vitem_md5 = vitem_md5;
            if (vitem_id_cancelado != null)
                value.vitem_id_cancelado = vitem_id_cancelado;
            if (barra_codigo != null)
                value.barra_codigo = barra_codigo;
            if (vitem_pre_venda != null)
                value.vitem_pre_venda = vitem_pre_venda;
            if (vitem_tot_preco != null)
                value.vitem_tot_preco = vitem_tot_preco;
            if (vitem_tot_preco_padrao != null)
                value.vitem_tot_preco_padrao = vitem_tot_preco_padrao;
            if (vitem_tot_preco_praticado != null)
                value.vitem_tot_preco_praticado = vitem_tot_preco_praticado;
            if (vitem_tot_preco_real != null)
                value.vitem_tot_preco_real = vitem_tot_preco_real;
            if (vitem_tot_preco_Reembolso != null)
                value.vitem_tot_preco_Reembolso = vitem_tot_preco_Reembolso;
            if (vitem_tot_preco_a_vista != null)
                value.vitem_tot_preco_a_vista = vitem_tot_preco_a_vista;
            if (vitem_tot_custo_medio != null)
                value.vitem_tot_custo_medio = vitem_tot_custo_medio;
            if (vitem_tot_comissao != null)
                value.vitem_tot_comissao = vitem_tot_comissao;
            if (vitem_tot_desconto != null)
                value.vitem_tot_desconto = vitem_tot_desconto;
            if (vitem_tot_desc_financ != null)
                value.vitem_tot_desc_financ = vitem_tot_desc_financ;
            if (vitem_vidaLink != null)
                value.vitem_vidaLink = vitem_vidaLink;
            if (vitem_receita_data != null)
                value.vitem_receita_data = vitem_receita_data;
            if (vitem_receita_notificacao_num != null)
                value.vitem_receita_notificacao_num = vitem_receita_notificacao_num;
            if (vitem_receita_notificacao_tipo != null)
                value.vitem_receita_notificacao_tipo = vitem_receita_notificacao_tipo;
            if (vitem_comprador_nome != null)
                value.vitem_comprador_nome = vitem_comprador_nome;
            if (vitem_comprador_tipdoc != null)
                value.vitem_comprador_tipdoc = vitem_comprador_tipdoc;
            if (vitem_comprador_doc != null)
                value.vitem_comprador_doc = vitem_comprador_doc;
            if (vitem_comprador_oexped != null)
                value.vitem_comprador_oexped = vitem_comprador_oexped;
            if (vitem_comprador_uf != null)
                value.vitem_comprador_uf = vitem_comprador_uf;
            if (vitem_paciente_oexped != null)
                value.vitem_paciente_oexped = vitem_paciente_oexped;
            if (vitem_paciente_doc != null)
                value.vitem_paciente_doc = vitem_paciente_doc;
            if (vitem_paciente_nome != null)
                value.vitem_paciente_nome = vitem_paciente_nome;
            if (vitem_paciente_sexo != null)
                value.vitem_paciente_sexo = vitem_paciente_sexo;
            if (vitem_paciente_dt_nascimento != null)
                value.vitem_paciente_dt_nascimento = vitem_paciente_dt_nascimento;
            if (vitem_paciente_cid != null)
                value.vitem_paciente_cid = vitem_paciente_cid;
            if (vitem_lote_numero != null)
                value.vitem_lote_numero = vitem_lote_numero;
            if (vitem_lote_validade != null)
                value.vitem_lote_validade = vitem_lote_validade;
            if (vitem_lote_fabricacao != null)
                value.vitem_lote_fabricacao = vitem_lote_fabricacao;
            if (vitem_lote_vlr_pmc != null)
                value.vitem_lote_vlr_pmc = vitem_lote_vlr_pmc;
            if (vitem_fpop_qtde_Diaria != null)
                value.vitem_fpop_qtde_Diaria = vitem_fpop_qtde_Diaria;
            if (vitem_fpop_qtde_Unitaria != null)
                value.vitem_fpop_qtde_Unitaria = vitem_fpop_qtde_Unitaria;
            if (treceita_id != null)
                value.treceita_id = treceita_id;
            if (crm_id != null)
                value.crm_id = crm_id;
            return value;
        }

        public tb_venda_pagamento Createtb_venda_pagamento(Int32? uneg_id = null, Int32? venda_id = null, Int32? venda_pdv = null, DateTime? venda_data = null, Int32? vpag_id = null, Int32? finsub_id = null, Int32? final_id = null, Nullable<Int32> vpag_num_referencia = null, Decimal? vpag_valor = null, Nullable<Decimal> vpag_troco = null, Nullable<Boolean> vpag_vendatef = null, Decimal? vpag_valor_compra_saque = null, String vpag_tef_nsu_venda = null, String vpag_tef_nsu_host = null, String vpag_tipo_cartao = null, String vpag_comprovante_cliente = null, String vpag_comprovante_loja = null, String vpag_status = null, Nullable<DateTime> vpag_cli_data_ch = null, Nullable<Decimal> vpag_cli_agencia_ch = null, Nullable<Decimal> vpag_cli_c1_ch = null, Nullable<Decimal> vpag_cli_conta_corrente_ch = null, Nullable<Decimal> vpag_cli_c2_ch = null, Nullable<Decimal> vpag_cli_numero_ch = null, Nullable<Decimal> vpag_cli_c3_ch = null, String vpag_cli_doc_troca = null)
        {
            tb_venda_pagamento value = CreateObject<tb_venda_pagamento>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (venda_id != null)
                value.venda_id = venda_id.Value;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv.Value;
            if (venda_data != null)
                value.venda_data = venda_data.Value;
            if (vpag_id != null)
                value.vpag_id = vpag_id.Value;
            if (finsub_id != null)
                value.finsub_id = finsub_id.Value;
            if (final_id != null)
                value.final_id = final_id.Value;
            if (vpag_num_referencia != null)
                value.vpag_num_referencia = vpag_num_referencia;
            if (vpag_valor != null)
                value.vpag_valor = vpag_valor.Value;
            if (vpag_troco != null)
                value.vpag_troco = vpag_troco;
            if (vpag_vendatef != null)
                value.vpag_vendatef = vpag_vendatef;
            if (vpag_valor_compra_saque != null)
                value.vpag_valor_compra_saque = vpag_valor_compra_saque.Value;
            if (vpag_tef_nsu_venda != null)
                value.vpag_tef_nsu_venda = vpag_tef_nsu_venda;
            if (vpag_tef_nsu_host != null)
                value.vpag_tef_nsu_host = vpag_tef_nsu_host;
            if (vpag_tipo_cartao != null)
                value.vpag_tipo_cartao = vpag_tipo_cartao;
            if (vpag_comprovante_cliente != null)
                value.vpag_comprovante_cliente = vpag_comprovante_cliente;
            if (vpag_comprovante_loja != null)
                value.vpag_comprovante_loja = vpag_comprovante_loja;
            if (vpag_status != null)
                value.vpag_status = vpag_status;
            if (vpag_cli_data_ch != null)
                value.vpag_cli_data_ch = vpag_cli_data_ch;
            if (vpag_cli_agencia_ch != null)
                value.vpag_cli_agencia_ch = vpag_cli_agencia_ch;
            if (vpag_cli_c1_ch != null)
                value.vpag_cli_c1_ch = vpag_cli_c1_ch;
            if (vpag_cli_conta_corrente_ch != null)
                value.vpag_cli_conta_corrente_ch = vpag_cli_conta_corrente_ch;
            if (vpag_cli_c2_ch != null)
                value.vpag_cli_c2_ch = vpag_cli_c2_ch;
            if (vpag_cli_numero_ch != null)
                value.vpag_cli_numero_ch = vpag_cli_numero_ch;
            if (vpag_cli_c3_ch != null)
                value.vpag_cli_c3_ch = vpag_cli_c3_ch;
            if (vpag_cli_doc_troca != null)
                value.vpag_cli_doc_troca = vpag_cli_doc_troca;
            return value;
        }

        public tb_venda_prevenda Createtb_venda_prevenda(Int32? vendaPv_id = null, DateTime? vendaPv_data_preVenda = null, Int32? uneg_id = null, Int32? venda_pdv = null, Nullable<Int32> venda_id = null, Nullable<DateTime> venda_data = null, String vendaPv_num_preVenda = null, String vendaPv_num_comanda = null, Nullable<Decimal> vendaPv_valorTotal = null, Nullable<Decimal> vendaPv_valorTroco = null, Nullable<Decimal> vendaPv_vlr_creditos = null, Nullable<Decimal> vendaPv_desconto_final = null, Nullable<Int32> vendaPv_itens = null, Nullable<Int32> vendaPv_volmes = null, String vendaPv_observacao = null, Nullable<Int32> vendaPv_atendente_id = null, String vendaPv_situacao = null, String vendaPv_tip_pedido = null, String vendaPv_tip_faturamento = null, String vendaPv_dispositivo = null, Nullable<Int32> vendaPv_id_origem = null, Nullable<DateTime> vendaPv_data_preVenda_origem = null, Nullable<Int32> uneg_id_origem = null, Nullable<Int32> venda_pdv_origem = null, Nullable<Int32> vendaPv_end_cobranca = null, Nullable<DateTime> vendaPv_dt_entrega = null, Nullable<Int32> vendaPv_telefone_id = null, String vendaPv_paf_numero = null, String vendaPv_pbm_autorizacao_num = null, String vendaPv_pbm_autorizacao_tipo = null, Nullable<Int64> vendaPv_pbm_cpf = null, Nullable<Int64> vendaPv_pbm_cnpj = null, Nullable<Decimal> vendaPv_pbm_avista = null, Nullable<Decimal> vendaPv_pbm_reembolso = null, String vendaPv_pedido_compra_cliente = null, Nullable<Int32> vendaPv_cancela_vendedor_id = null, Nullable<DateTime> vendaPv_cancela_data = null, String vendaPv_cancela_motivo = null, Nullable<DateTime> vendaPv_entrega_dt_separacao = null, Nullable<DateTime> vendaPv_entrega_dt_retorno = null, Nullable<Int32> vendaPv_entrega_id_entregador = null, String vendaPv_status = null, Nullable<DateTime> vendaPv_data_alteracao = null, String vendaPv_nome_arquivo = null, String vendaPv_chave_acesso_nfe = null, String vendaPv_ecf_dv = null, String vendaPv_coo_dv = null, String vendaPv_chave_nfce_dv = null, String cli_fisc_cpf_cnpj = null, Nullable<Int32> cnv_id = null, Nullable<Int32> pbm_id = null, Nullable<Int64> end_telefone = null, Nullable<Int32> polo_id = null, Nullable<Int32> quadra_id = null, Nullable<Int32> rota_id = null, Nullable<Int32> arearisco_id = null)
        {
            tb_venda_prevenda value = CreateObject<tb_venda_prevenda>();
            if (vendaPv_id != null)
                value.vendaPv_id = vendaPv_id.Value;
            if (vendaPv_data_preVenda != null)
                value.vendaPv_data_preVenda = vendaPv_data_preVenda.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv.Value;
            if (venda_id != null)
                value.venda_id = venda_id;
            if (venda_data != null)
                value.venda_data = venda_data;
            if (vendaPv_num_preVenda != null)
                value.vendaPv_num_preVenda = vendaPv_num_preVenda;
            if (vendaPv_num_comanda != null)
                value.vendaPv_num_comanda = vendaPv_num_comanda;
            if (vendaPv_valorTotal != null)
                value.vendaPv_valorTotal = vendaPv_valorTotal;
            if (vendaPv_valorTroco != null)
                value.vendaPv_valorTroco = vendaPv_valorTroco;
            if (vendaPv_vlr_creditos != null)
                value.vendaPv_vlr_creditos = vendaPv_vlr_creditos;
            if (vendaPv_desconto_final != null)
                value.vendaPv_desconto_final = vendaPv_desconto_final;
            if (vendaPv_itens != null)
                value.vendaPv_itens = vendaPv_itens;
            if (vendaPv_volmes != null)
                value.vendaPv_volmes = vendaPv_volmes;
            if (vendaPv_observacao != null)
                value.vendaPv_observacao = vendaPv_observacao;
            if (vendaPv_atendente_id != null)
                value.vendaPv_atendente_id = vendaPv_atendente_id;
            if (vendaPv_situacao != null)
                value.vendaPv_situacao = vendaPv_situacao;
            if (vendaPv_tip_pedido != null)
                value.vendaPv_tip_pedido = vendaPv_tip_pedido;
            if (vendaPv_tip_faturamento != null)
                value.vendaPv_tip_faturamento = vendaPv_tip_faturamento;
            if (vendaPv_dispositivo != null)
                value.vendaPv_dispositivo = vendaPv_dispositivo;
            if (vendaPv_id_origem != null)
                value.vendaPv_id_origem = vendaPv_id_origem;
            if (vendaPv_data_preVenda_origem != null)
                value.vendaPv_data_preVenda_origem = vendaPv_data_preVenda_origem;
            if (uneg_id_origem != null)
                value.uneg_id_origem = uneg_id_origem;
            if (venda_pdv_origem != null)
                value.venda_pdv_origem = venda_pdv_origem;
            if (vendaPv_end_cobranca != null)
                value.vendaPv_end_cobranca = vendaPv_end_cobranca;
            if (vendaPv_dt_entrega != null)
                value.vendaPv_dt_entrega = vendaPv_dt_entrega;
            if (vendaPv_telefone_id != null)
                value.vendaPv_telefone_id = vendaPv_telefone_id;
            if (vendaPv_paf_numero != null)
                value.vendaPv_paf_numero = vendaPv_paf_numero;
            if (vendaPv_pbm_autorizacao_num != null)
                value.vendaPv_pbm_autorizacao_num = vendaPv_pbm_autorizacao_num;
            if (vendaPv_pbm_autorizacao_tipo != null)
                value.vendaPv_pbm_autorizacao_tipo = vendaPv_pbm_autorizacao_tipo;
            if (vendaPv_pbm_cpf != null)
                value.vendaPv_pbm_cpf = vendaPv_pbm_cpf;
            if (vendaPv_pbm_cnpj != null)
                value.vendaPv_pbm_cnpj = vendaPv_pbm_cnpj;
            if (vendaPv_pbm_avista != null)
                value.vendaPv_pbm_avista = vendaPv_pbm_avista;
            if (vendaPv_pbm_reembolso != null)
                value.vendaPv_pbm_reembolso = vendaPv_pbm_reembolso;
            if (vendaPv_pedido_compra_cliente != null)
                value.vendaPv_pedido_compra_cliente = vendaPv_pedido_compra_cliente;
            if (vendaPv_cancela_vendedor_id != null)
                value.vendaPv_cancela_vendedor_id = vendaPv_cancela_vendedor_id;
            if (vendaPv_cancela_data != null)
                value.vendaPv_cancela_data = vendaPv_cancela_data;
            if (vendaPv_cancela_motivo != null)
                value.vendaPv_cancela_motivo = vendaPv_cancela_motivo;
            if (vendaPv_entrega_dt_separacao != null)
                value.vendaPv_entrega_dt_separacao = vendaPv_entrega_dt_separacao;
            if (vendaPv_entrega_dt_retorno != null)
                value.vendaPv_entrega_dt_retorno = vendaPv_entrega_dt_retorno;
            if (vendaPv_entrega_id_entregador != null)
                value.vendaPv_entrega_id_entregador = vendaPv_entrega_id_entregador;
            if (vendaPv_status != null)
                value.vendaPv_status = vendaPv_status;
            if (vendaPv_data_alteracao != null)
                value.vendaPv_data_alteracao = vendaPv_data_alteracao;
            if (vendaPv_nome_arquivo != null)
                value.vendaPv_nome_arquivo = vendaPv_nome_arquivo;
            if (vendaPv_chave_acesso_nfe != null)
                value.vendaPv_chave_acesso_nfe = vendaPv_chave_acesso_nfe;
            if (vendaPv_ecf_dv != null)
                value.vendaPv_ecf_dv = vendaPv_ecf_dv;
            if (vendaPv_coo_dv != null)
                value.vendaPv_coo_dv = vendaPv_coo_dv;
            if (vendaPv_chave_nfce_dv != null)
                value.vendaPv_chave_nfce_dv = vendaPv_chave_nfce_dv;
            if (cli_fisc_cpf_cnpj != null)
                value.cli_fisc_cpf_cnpj = cli_fisc_cpf_cnpj;
            if (cnv_id != null)
                value.cnv_id = cnv_id;
            if (pbm_id != null)
                value.pbm_id = pbm_id;
            if (end_telefone != null)
                value.end_telefone = end_telefone;
            if (polo_id != null)
                value.polo_id = polo_id;
            if (quadra_id != null)
                value.quadra_id = quadra_id;
            if (rota_id != null)
                value.rota_id = rota_id;
            if (arearisco_id != null)
                value.arearisco_id = arearisco_id;
            return value;
        }

        public tb_venda_prevenda_item Createtb_venda_prevenda_item(Int32? vendaPv_item_id = null, DateTime? vendaPv_data_preVenda = null, Int32? vendaPv_id = null, Int32? uneg_id = null, Int32? venda_pdv = null, Nullable<Int32> venda_id = null, Nullable<Int64> vendaPv_item_autorizacao = null, Nullable<Int32> vendaPv_item_codigo = null, String vendaPv_item_cpfCnpj = null, String vendaPv_item_descricao = null, String vendaPv_item_ean13 = null, Nullable<Boolean> vendaPv_item_agenda_marca_puc = null, Nullable<Decimal> vendaPv_item_preco = null, Nullable<Decimal> vendaPv_item_precoPraticado = null, Nullable<Decimal> vendaPv_item_precoPadrao = null, Nullable<Decimal> vendaPv_item_precoReal = null, Nullable<Decimal> vendaPv_item_precoReembolso = null, Nullable<Decimal> vendaPv_item_precoVista = null, Nullable<Int32> vendaPv_item_quantidade = null, Nullable<Decimal> vendaPv_item_totalValor = null, Nullable<Decimal> vendaPv_item_valorDesconto = null, Nullable<DateTime> vendaPv_item_data = null, String vendaPv_item_status = null, Nullable<Int64> vendaPv_item_cancela_vendedor_id = null, String vendaPv_item_vidaLink = null, Nullable<DateTime> vendaPv_item_receita_data = null, String vendaPv_item_receita_notificacao_num = null, String vendaPv_item_receita_notificacao_tipo = null, String vendaPv_item_comprador_nome = null, Nullable<Decimal> vendaPv_item_comprador_tipdoc = null, String vendaPv_item_comprador_doc = null, String vendaPv_item_comprador_oexped = null, String vendaPv_item_comprador_uf = null, String vendaPv_item_paciente_doc = null, String vendaPv_item_paciente_nome = null, String vendaPv_item_paciente_sexo = null, Nullable<DateTime> vendaPv_item_paciente_dt_nascimento = null, String vendaPv_item_paciente_cid = null, String vendaPv_item_lote_numero = null, Nullable<DateTime> vendaPv_item_lote_validade = null, Nullable<DateTime> vendaPv_lote_fabricacao = null, Nullable<Decimal> vendaPv_item_lote_vlr_pmc = null, Nullable<Int32> vendaPv_item_fpop_qtde_Diaria = null, Nullable<Int32> vendaPv_item_fpop_qtde_Unitaria = null, Nullable<Int32> crm_id = null, Nullable<Int32> treceita_id = null)
        {
            tb_venda_prevenda_item value = CreateObject<tb_venda_prevenda_item>();
            if (vendaPv_item_id != null)
                value.vendaPv_item_id = vendaPv_item_id.Value;
            if (vendaPv_data_preVenda != null)
                value.vendaPv_data_preVenda = vendaPv_data_preVenda.Value;
            if (vendaPv_id != null)
                value.vendaPv_id = vendaPv_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv.Value;
            if (venda_id != null)
                value.venda_id = venda_id;
            if (vendaPv_item_autorizacao != null)
                value.vendaPv_item_autorizacao = vendaPv_item_autorizacao;
            if (vendaPv_item_codigo != null)
                value.vendaPv_item_codigo = vendaPv_item_codigo;
            if (vendaPv_item_cpfCnpj != null)
                value.vendaPv_item_cpfCnpj = vendaPv_item_cpfCnpj;
            if (vendaPv_item_descricao != null)
                value.vendaPv_item_descricao = vendaPv_item_descricao;
            if (vendaPv_item_ean13 != null)
                value.vendaPv_item_ean13 = vendaPv_item_ean13;
            if (vendaPv_item_agenda_marca_puc != null)
                value.vendaPv_item_agenda_marca_puc = vendaPv_item_agenda_marca_puc;
            if (vendaPv_item_preco != null)
                value.vendaPv_item_preco = vendaPv_item_preco;
            if (vendaPv_item_precoPraticado != null)
                value.vendaPv_item_precoPraticado = vendaPv_item_precoPraticado;
            if (vendaPv_item_precoPadrao != null)
                value.vendaPv_item_precoPadrao = vendaPv_item_precoPadrao;
            if (vendaPv_item_precoReal != null)
                value.vendaPv_item_precoReal = vendaPv_item_precoReal;
            if (vendaPv_item_precoReembolso != null)
                value.vendaPv_item_precoReembolso = vendaPv_item_precoReembolso;
            if (vendaPv_item_precoVista != null)
                value.vendaPv_item_precoVista = vendaPv_item_precoVista;
            if (vendaPv_item_quantidade != null)
                value.vendaPv_item_quantidade = vendaPv_item_quantidade;
            if (vendaPv_item_totalValor != null)
                value.vendaPv_item_totalValor = vendaPv_item_totalValor;
            if (vendaPv_item_valorDesconto != null)
                value.vendaPv_item_valorDesconto = vendaPv_item_valorDesconto;
            if (vendaPv_item_data != null)
                value.vendaPv_item_data = vendaPv_item_data;
            if (vendaPv_item_status != null)
                value.vendaPv_item_status = vendaPv_item_status;
            if (vendaPv_item_cancela_vendedor_id != null)
                value.vendaPv_item_cancela_vendedor_id = vendaPv_item_cancela_vendedor_id;
            if (vendaPv_item_vidaLink != null)
                value.vendaPv_item_vidaLink = vendaPv_item_vidaLink;
            if (vendaPv_item_receita_data != null)
                value.vendaPv_item_receita_data = vendaPv_item_receita_data;
            if (vendaPv_item_receita_notificacao_num != null)
                value.vendaPv_item_receita_notificacao_num = vendaPv_item_receita_notificacao_num;
            if (vendaPv_item_receita_notificacao_tipo != null)
                value.vendaPv_item_receita_notificacao_tipo = vendaPv_item_receita_notificacao_tipo;
            if (vendaPv_item_comprador_nome != null)
                value.vendaPv_item_comprador_nome = vendaPv_item_comprador_nome;
            if (vendaPv_item_comprador_tipdoc != null)
                value.vendaPv_item_comprador_tipdoc = vendaPv_item_comprador_tipdoc;
            if (vendaPv_item_comprador_doc != null)
                value.vendaPv_item_comprador_doc = vendaPv_item_comprador_doc;
            if (vendaPv_item_comprador_oexped != null)
                value.vendaPv_item_comprador_oexped = vendaPv_item_comprador_oexped;
            if (vendaPv_item_comprador_uf != null)
                value.vendaPv_item_comprador_uf = vendaPv_item_comprador_uf;
            if (vendaPv_item_paciente_doc != null)
                value.vendaPv_item_paciente_doc = vendaPv_item_paciente_doc;
            if (vendaPv_item_paciente_nome != null)
                value.vendaPv_item_paciente_nome = vendaPv_item_paciente_nome;
            if (vendaPv_item_paciente_sexo != null)
                value.vendaPv_item_paciente_sexo = vendaPv_item_paciente_sexo;
            if (vendaPv_item_paciente_dt_nascimento != null)
                value.vendaPv_item_paciente_dt_nascimento = vendaPv_item_paciente_dt_nascimento;
            if (vendaPv_item_paciente_cid != null)
                value.vendaPv_item_paciente_cid = vendaPv_item_paciente_cid;
            if (vendaPv_item_lote_numero != null)
                value.vendaPv_item_lote_numero = vendaPv_item_lote_numero;
            if (vendaPv_item_lote_validade != null)
                value.vendaPv_item_lote_validade = vendaPv_item_lote_validade;
            if (vendaPv_lote_fabricacao != null)
                value.vendaPv_lote_fabricacao = vendaPv_lote_fabricacao;
            if (vendaPv_item_lote_vlr_pmc != null)
                value.vendaPv_item_lote_vlr_pmc = vendaPv_item_lote_vlr_pmc;
            if (vendaPv_item_fpop_qtde_Diaria != null)
                value.vendaPv_item_fpop_qtde_Diaria = vendaPv_item_fpop_qtde_Diaria;
            if (vendaPv_item_fpop_qtde_Unitaria != null)
                value.vendaPv_item_fpop_qtde_Unitaria = vendaPv_item_fpop_qtde_Unitaria;
            if (crm_id != null)
                value.crm_id = crm_id;
            if (treceita_id != null)
                value.treceita_id = treceita_id;
            return value;
        }

        public tb_venda_prevenda_pgto Createtb_venda_prevenda_pgto(Int32? vendaPv_id = null, DateTime? vendaPv_data_preVenda = null, Int32? uneg_id = null, Int32? venda_pdv = null, Int32? vpag_seq = null, Int32? final_id = null, Int32? subfin_id = null, Nullable<Int32> vpag_num_referencia = null, Nullable<Decimal> vpag_valor = null, Nullable<Decimal> vpag_troco = null, Nullable<Boolean> vpag_vendatef = null, Nullable<Decimal> vpag_valor_compra_saque = null, String vpag_tef_nsu_venda = null, String vpag_tef_nsu_host = null, String vpag_tipo_cartao = null, String vpag_comprovante_cliente = null, String vpag_comprovante_loja = null, String vpag_status = null, Nullable<DateTime> vpag_cli_data_ch = null, Nullable<Int32> vpag_cli_banco_id_ch = null, Nullable<Decimal> vpag_cli_agencia_ch = null, Nullable<Decimal> vpag_cli_c1_ch = null, Nullable<Decimal> vpag_cli_conta_corrente_ch = null, Nullable<Decimal> vpag_cli_c2_ch = null, Nullable<Decimal> vpag_cli_numero_ch = null, Nullable<Decimal> vpag_cli_c3_ch = null, String vpag_cli_doc_troca = null, Nullable<Int32> prazo_id = null, Nullable<Int64> cli_id = null)
        {
            tb_venda_prevenda_pgto value = CreateObject<tb_venda_prevenda_pgto>();
            if (vendaPv_id != null)
                value.vendaPv_id = vendaPv_id.Value;
            if (vendaPv_data_preVenda != null)
                value.vendaPv_data_preVenda = vendaPv_data_preVenda.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (venda_pdv != null)
                value.venda_pdv = venda_pdv.Value;
          
            if (final_id != null)
                value.final_id = final_id.Value;
            if (subfin_id != null)
                value.subfin_id = subfin_id.Value;
            if (vpag_num_referencia != null)
                value.vpag_num_referencia = vpag_num_referencia;
            if (vpag_valor != null)
                value.vpag_valor = vpag_valor;
            if (vpag_troco != null)
                value.vpag_troco = vpag_troco;
            if (vpag_vendatef != null)
                value.vpag_vendatef = vpag_vendatef;
            if (vpag_valor_compra_saque != null)
                value.vpag_valor_compra_saque = vpag_valor_compra_saque;
            if (vpag_tef_nsu_venda != null)
                value.vpag_tef_nsu_venda = vpag_tef_nsu_venda;
            if (vpag_tef_nsu_host != null)
                value.vpag_tef_nsu_host = vpag_tef_nsu_host;
            if (vpag_tipo_cartao != null)
                value.vpag_tipo_cartao = vpag_tipo_cartao;
            if (vpag_comprovante_cliente != null)
                value.vpag_comprovante_cliente = vpag_comprovante_cliente;
            if (vpag_comprovante_loja != null)
                value.vpag_comprovante_loja = vpag_comprovante_loja;
            if (vpag_status != null)
                value.vpag_status = vpag_status;
            if (vpag_cli_data_ch != null)
                value.vpag_cli_data_ch = vpag_cli_data_ch;
            if (vpag_cli_banco_id_ch != null)
                value.vpag_cli_banco_id_ch = vpag_cli_banco_id_ch;
            if (vpag_cli_agencia_ch != null)
                value.vpag_cli_agencia_ch = vpag_cli_agencia_ch;
            if (vpag_cli_c1_ch != null)
                value.vpag_cli_c1_ch = vpag_cli_c1_ch;
            if (vpag_cli_conta_corrente_ch != null)
                value.vpag_cli_conta_corrente_ch = vpag_cli_conta_corrente_ch;
            if (vpag_cli_c2_ch != null)
                value.vpag_cli_c2_ch = vpag_cli_c2_ch;
            if (vpag_cli_numero_ch != null)
                value.vpag_cli_numero_ch = vpag_cli_numero_ch;
            if (vpag_cli_c3_ch != null)
                value.vpag_cli_c3_ch = vpag_cli_c3_ch;
            if (vpag_cli_doc_troca != null)
                value.vpag_cli_doc_troca = vpag_cli_doc_troca;
            if (prazo_id != null)
                value.prazo_id = prazo_id;
            if (cli_id != null)
                value.cli_id = cli_id;
            return value;
        }

        public tbManagerUpdate CreatetbManagerUpdate(Int32? managerUpdateID = null, String rotina = null, DateTime? createdOn = null)
        {
            tbManagerUpdate value = CreateObject<tbManagerUpdate>();
            if (managerUpdateID != null)
                value.ManagerUpdateID = managerUpdateID.Value;
            if (rotina != null)
                value.Rotina = rotina;
            if (createdOn != null)
                value.CreatedOn = createdOn.Value;
            return value;
        }

        public tbr_abcfarma_uf Createtbr_abcfarma_uf(Int32? per_id = null, Int32? abcf_id = null, Int32? uf_id = null, Nullable<Decimal> prouf_preco_fabrica = null, Nullable<Decimal> prouf_pmc = null, Nullable<Decimal> prouf_pmc_fracao = null, String prouf_situacao = null, Nullable<DateTime> prouf_dt_cadastro = null, Nullable<DateTime> prouf_dt_alteracao = null)
        {
            tbr_abcfarma_uf value = CreateObject<tbr_abcfarma_uf>();
            if (per_id != null)
                value.per_id = per_id.Value;
            if (abcf_id != null)
                value.abcf_id = abcf_id.Value;
            if (uf_id != null)
                value.uf_id = uf_id.Value;
            if (prouf_preco_fabrica != null)
                value.prouf_preco_fabrica = prouf_preco_fabrica;
            if (prouf_pmc != null)
                value.prouf_pmc = prouf_pmc;
            if (prouf_pmc_fracao != null)
                value.prouf_pmc_fracao = prouf_pmc_fracao;
            if (prouf_situacao != null)
                value.prouf_situacao = prouf_situacao;
            if (prouf_dt_cadastro != null)
                value.prouf_dt_cadastro = prouf_dt_cadastro;
            if (prouf_dt_alteracao != null)
                value.prouf_dt_alteracao = prouf_dt_alteracao;
            return value;
        }

        public tbr_convenio_cliente Createtbr_convenio_cliente(Int32? cnv_id = null, Int64? cli_id = null, Nullable<Decimal> clicnv_vlr_limite = null, Nullable<Decimal> clicnv_vlr_acumulado = null, String clicnv_nu_matricula = null, String clicnv_situacao = null, Nullable<DateTime> clicnv_dt_cadastro = null, Nullable<DateTime> clicnv_dt_alteracao = null)
        {
            tbr_convenio_cliente value = CreateObject<tbr_convenio_cliente>();
            if (cnv_id != null)
                value.cnv_id = cnv_id.Value;
            if (cli_id != null)
                value.cli_id = cli_id.Value;
            if (clicnv_vlr_limite != null)
                value.clicnv_vlr_limite = clicnv_vlr_limite;
            if (clicnv_vlr_acumulado != null)
                value.clicnv_vlr_acumulado = clicnv_vlr_acumulado;
            if (clicnv_nu_matricula != null)
                value.clicnv_nu_matricula = clicnv_nu_matricula;
            if (clicnv_situacao != null)
                value.clicnv_situacao = clicnv_situacao;
            if (clicnv_dt_cadastro != null)
                value.clicnv_dt_cadastro = clicnv_dt_cadastro;
            if (clicnv_dt_alteracao != null)
                value.clicnv_dt_alteracao = clicnv_dt_alteracao;
            return value;
        }

        public tbr_convenio_finalizadora_sub Createtbr_convenio_finalizadora_sub(Int32? cnv_id = null, Int32? final_id = null, Int32? subfin_id = null, String cfinaliza_situacao = null, Nullable<DateTime> cfinaliza_dt_cadastro = null, Nullable<DateTime> cfinaliza_dt_alteracao = null, Nullable<Decimal> cfinaliza_cpf_alteracao = null)
        {
            tbr_convenio_finalizadora_sub value = CreateObject<tbr_convenio_finalizadora_sub>();
            if (cnv_id != null)
                value.cnv_id = cnv_id.Value;
            if (final_id != null)
                value.final_id = final_id.Value;
            if (subfin_id != null)
                value.subfin_id = subfin_id.Value;
            if (cfinaliza_situacao != null)
                value.cfinaliza_situacao = cfinaliza_situacao;
            if (cfinaliza_dt_cadastro != null)
                value.cfinaliza_dt_cadastro = cfinaliza_dt_cadastro;
            if (cfinaliza_dt_alteracao != null)
                value.cfinaliza_dt_alteracao = cfinaliza_dt_alteracao;
            if (cfinaliza_cpf_alteracao != null)
                value.cfinaliza_cpf_alteracao = cfinaliza_cpf_alteracao;
            return value;
        }

        public tbr_convenio_un Createtbr_convenio_un(Int32? cnv_id = null, Int32? uneg_id = null, String convun_situacao = null, Nullable<DateTime> convun_dt_cadastro = null, Nullable<DateTime> convun_dt_alteracao = null, Nullable<Decimal> convun_cpf_alteracao = null)
        {
            tbr_convenio_un value = CreateObject<tbr_convenio_un>();
            if (cnv_id != null)
                value.cnv_id = cnv_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (convun_situacao != null)
                value.convun_situacao = convun_situacao;
            if (convun_dt_cadastro != null)
                value.convun_dt_cadastro = convun_dt_cadastro;
            if (convun_dt_alteracao != null)
                value.convun_dt_alteracao = convun_dt_alteracao;
            if (convun_cpf_alteracao != null)
                value.convun_cpf_alteracao = convun_cpf_alteracao;
            return value;
        }

        public tbr_dicionario_produto Createtbr_dicionario_produto(Int32? fab_id = null, Int32? pro_id = null, Nullable<Decimal> dicprod_qtde_embal = null, String dicprod_tipo_embal = null, String dicprod_codigo = null, String dicprod_situacao = null, Nullable<DateTime> dicprod_dt_cadastro = null, Nullable<DateTime> dicprod_dt_alteracao = null)
        {
            tbr_dicionario_produto value = CreateObject<tbr_dicionario_produto>();
            if (fab_id != null)
                value.fab_id = fab_id.Value;
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (dicprod_qtde_embal != null)
                value.dicprod_qtde_embal = dicprod_qtde_embal;
            if (dicprod_tipo_embal != null)
                value.dicprod_tipo_embal = dicprod_tipo_embal;
            if (dicprod_codigo != null)
                value.dicprod_codigo = dicprod_codigo;
            if (dicprod_situacao != null)
                value.dicprod_situacao = dicprod_situacao;
            if (dicprod_dt_cadastro != null)
                value.dicprod_dt_cadastro = dicprod_dt_cadastro;
            if (dicprod_dt_alteracao != null)
                value.dicprod_dt_alteracao = dicprod_dt_alteracao;
            return value;
        }

        public tbr_dicionario_un Createtbr_dicionario_un(Int32? uneg_id = null, Int32? fab_id = null, Int32? div_id = null, String dicun_codigo = null, String dicun_situacao = null, Nullable<DateTime> dicun_dt_cadastro = null, Nullable<DateTime> dicun_dt_alteracao = null)
        {
            tbr_dicionario_un value = CreateObject<tbr_dicionario_un>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (fab_id != null)
                value.fab_id = fab_id.Value;
            if (div_id != null)
                value.div_id = div_id.Value;
            if (dicun_codigo != null)
                value.dicun_codigo = dicun_codigo;
            if (dicun_situacao != null)
                value.dicun_situacao = dicun_situacao;
            if (dicun_dt_cadastro != null)
                value.dicun_dt_cadastro = dicun_dt_cadastro;
            if (dicun_dt_alteracao != null)
                value.dicun_dt_alteracao = dicun_dt_alteracao;
            return value;
        }

        public tbr_dpto_aplicativo Createtbr_dpto_aplicativo(Int32? dpto_id = null, Int32? apl_id = null, Nullable<Int32> dptapl_acesso = null, Nullable<Boolean> dptapl_inclusao = null, Nullable<Boolean> dptapl_alteracao = null, Nullable<Boolean> dptapl_exclusao = null, Nullable<Boolean> dptapl_impressao = null, Nullable<Boolean> dptapl_exp_xls = null, Nullable<Boolean> dptapl_exp_pdf = null, Nullable<Boolean> dptapl_exp_txt = null, Nullable<Boolean> dptapl_processo = null, Nullable<Boolean> dptapl_edicao = null, Nullable<DateTime> dptapl_dt_cadastro = null, Nullable<DateTime> dptapl_dt_alteracao = null, String dptapl_aplicacao = null)
        {
            tbr_dpto_aplicativo value = CreateObject<tbr_dpto_aplicativo>();
            if (dpto_id != null)
                value.dpto_id = dpto_id.Value;
            if (apl_id != null)
                value.apl_id = apl_id.Value;
            if (dptapl_acesso != null)
                value.dptapl_acesso = dptapl_acesso;
            if (dptapl_inclusao != null)
                value.dptapl_inclusao = dptapl_inclusao;
            if (dptapl_alteracao != null)
                value.dptapl_alteracao = dptapl_alteracao;
            if (dptapl_exclusao != null)
                value.dptapl_exclusao = dptapl_exclusao;
            if (dptapl_impressao != null)
                value.dptapl_impressao = dptapl_impressao;
            if (dptapl_exp_xls != null)
                value.dptapl_exp_xls = dptapl_exp_xls;
            if (dptapl_exp_pdf != null)
                value.dptapl_exp_pdf = dptapl_exp_pdf;
            if (dptapl_exp_txt != null)
                value.dptapl_exp_txt = dptapl_exp_txt;
            if (dptapl_processo != null)
                value.dptapl_processo = dptapl_processo;
            if (dptapl_edicao != null)
                value.dptapl_edicao = dptapl_edicao;
            if (dptapl_dt_cadastro != null)
                value.dptapl_dt_cadastro = dptapl_dt_cadastro;
            if (dptapl_dt_alteracao != null)
                value.dptapl_dt_alteracao = dptapl_dt_alteracao;
            if (dptapl_aplicacao != null)
                value.dptapl_aplicacao = dptapl_aplicacao;
            return value;
        }

        public tbr_ecf_finalizadora Createtbr_ecf_finalizadora(Int32? final_id = null, String ecf_numero_serie = null, String finalecf_codigo = null, Boolean? finalecf_cupom_vinculado = null, String finalecf_situacao = null, DateTime? finalecf_dt_cadastro = null, Nullable<DateTime> finalecf_dt_alteracao = null)
        {
            tbr_ecf_finalizadora value = CreateObject<tbr_ecf_finalizadora>();
            if (final_id != null)
                value.final_id = final_id.Value;
            if (ecf_numero_serie != null)
                value.ecf_numero_serie = ecf_numero_serie;
            if (finalecf_codigo != null)
                value.finalecf_codigo = finalecf_codigo;
            if (finalecf_cupom_vinculado != null)
                value.finalecf_cupom_vinculado = finalecf_cupom_vinculado.Value;
            if (finalecf_situacao != null)
                value.finalecf_situacao = finalecf_situacao;
            if (finalecf_dt_cadastro != null)
                value.finalecf_dt_cadastro = finalecf_dt_cadastro.Value;
            if (finalecf_dt_alteracao != null)
                value.finalecf_dt_alteracao = finalecf_dt_alteracao;
            return value;
        }

        public tbr_ecf_tributacao Createtbr_ecf_tributacao(Int32? trb_id = null, String ecf_numero_serie = null, String trbecf_codigo = null, String trbecf_situacao = null, Nullable<DateTime> trbecf_dt_cadastro = null, Nullable<DateTime> trbecf_dt_alteracao = null)
        {
            tbr_ecf_tributacao value = CreateObject<tbr_ecf_tributacao>();
            if (trb_id != null)
                value.trb_id = trb_id.Value;
            if (ecf_numero_serie != null)
                value.ecf_numero_serie = ecf_numero_serie;
            if (trbecf_codigo != null)
                value.trbecf_codigo = trbecf_codigo;
            if (trbecf_situacao != null)
                value.trbecf_situacao = trbecf_situacao;
            if (trbecf_dt_cadastro != null)
                value.trbecf_dt_cadastro = trbecf_dt_cadastro;
            if (trbecf_dt_alteracao != null)
                value.trbecf_dt_alteracao = trbecf_dt_alteracao;
            return value;
        }

        public tbr_finalizadora_sub_un Createtbr_finalizadora_sub_un(Int32? final_id = null, Int32? subfin_id = null, Int32? uneg_id = null, Nullable<Decimal> finsubun_taxa_adm = null, String finsubun_situacao = null, Nullable<DateTime> finsubun_dt_cadastro = null, Nullable<DateTime> finsubun_dt_alteracao = null, Nullable<Decimal> finsubun_cpf_alteracao = null)
        {
            tbr_finalizadora_sub_un value = CreateObject<tbr_finalizadora_sub_un>();
            if (final_id != null)
                value.final_id = final_id.Value;
            if (subfin_id != null)
                value.subfin_id = subfin_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (finsubun_taxa_adm != null)
                value.finsubun_taxa_adm = finsubun_taxa_adm;
            if (finsubun_situacao != null)
                value.finsubun_situacao = finsubun_situacao;
            if (finsubun_dt_cadastro != null)
                value.finsubun_dt_cadastro = finsubun_dt_cadastro;
            if (finsubun_dt_alteracao != null)
                value.finsubun_dt_alteracao = finsubun_dt_alteracao;
            if (finsubun_cpf_alteracao != null)
                value.finsubun_cpf_alteracao = finsubun_cpf_alteracao;
            return value;
        }

        public tbr_finalizadora_un Createtbr_finalizadora_un(Int32? uneg_id = null, Int32? final_id = null, String finalun_situacao = null, Nullable<DateTime> finalun_dt_cadastro = null, Nullable<DateTime> finalun_dt_alteracao = null, Nullable<Decimal> finalun_cpf_alteracao = null)
        {
            tbr_finalizadora_un value = CreateObject<tbr_finalizadora_un>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (final_id != null)
                value.final_id = final_id.Value;
            if (finalun_situacao != null)
                value.finalun_situacao = finalun_situacao;
            if (finalun_dt_cadastro != null)
                value.finalun_dt_cadastro = finalun_dt_cadastro;
            if (finalun_dt_alteracao != null)
                value.finalun_dt_alteracao = finalun_dt_alteracao;
            if (finalun_cpf_alteracao != null)
                value.finalun_cpf_alteracao = finalun_cpf_alteracao;
            return value;
        }

        public tbr_mvto_compra_cfop____ Createtbr_mvto_compra_cfop____(Int32? cmp_id = null, Int32? cfop_id = null, Nullable<Decimal> mvtoccfop_base_icms = null, Nullable<Decimal> mvtoccfop_aliq_icms = null, Nullable<Decimal> mvtoccfop_valor_icms = null, String mvtoccfop_situacao = null, Nullable<DateTime> mvtoccfop_dt_cadastro = null, Nullable<DateTime> mvtoccfop_dt_alteracao = null, Nullable<Decimal> mvtoccfop_cpf_alteracao = null)
        {
            tbr_mvto_compra_cfop____ value = CreateObject<tbr_mvto_compra_cfop____>();
            if (cmp_id != null)
                value.cmp_id = cmp_id.Value;
            if (cfop_id != null)
                value.cfop_id = cfop_id.Value;
            if (mvtoccfop_base_icms != null)
                value.mvtoccfop_base_icms = mvtoccfop_base_icms;
            if (mvtoccfop_aliq_icms != null)
                value.mvtoccfop_aliq_icms = mvtoccfop_aliq_icms;
            if (mvtoccfop_valor_icms != null)
                value.mvtoccfop_valor_icms = mvtoccfop_valor_icms;
            if (mvtoccfop_situacao != null)
                value.mvtoccfop_situacao = mvtoccfop_situacao;
            if (mvtoccfop_dt_cadastro != null)
                value.mvtoccfop_dt_cadastro = mvtoccfop_dt_cadastro;
            if (mvtoccfop_dt_alteracao != null)
                value.mvtoccfop_dt_alteracao = mvtoccfop_dt_alteracao;
            if (mvtoccfop_cpf_alteracao != null)
                value.mvtoccfop_cpf_alteracao = mvtoccfop_cpf_alteracao;
            return value;
        }

        public tbr_mvto_compra_dup____ Createtbr_mvto_compra_dup____(Int32? cmp_id = null, Int32? cmpdup_id = null, String mvtocdup_situacao = null, Nullable<DateTime> mvtocdup_dt_cadastro = null, Nullable<DateTime> mvtocdup_dt_alteracao = null, Nullable<Decimal> mvtocdup_cpf_alteracao = null)
        {
            tbr_mvto_compra_dup____ value = CreateObject<tbr_mvto_compra_dup____>();
            if (cmp_id != null)
                value.cmp_id = cmp_id.Value;
            if (cmpdup_id != null)
                value.cmpdup_id = cmpdup_id.Value;
            if (mvtocdup_situacao != null)
                value.mvtocdup_situacao = mvtocdup_situacao;
            if (mvtocdup_dt_cadastro != null)
                value.mvtocdup_dt_cadastro = mvtocdup_dt_cadastro;
            if (mvtocdup_dt_alteracao != null)
                value.mvtocdup_dt_alteracao = mvtocdup_dt_alteracao;
            if (mvtocdup_cpf_alteracao != null)
                value.mvtocdup_cpf_alteracao = mvtocdup_cpf_alteracao;
            return value;
        }

        public tbr_parametro_descprod_uneg Createtbr_parametro_descprod_uneg(Int32? par_id = null, Int32? uneg_id = null)
        {
            tbr_parametro_descprod_uneg value = CreateObject<tbr_parametro_descprod_uneg>();
            if (par_id != null)
                value.par_id = par_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            return value;
        }

        public tbr_parametro_descvend_uneg Createtbr_parametro_descvend_uneg(Int32? par_id = null, Int32? uneg_id = null)
        {
            tbr_parametro_descvend_uneg value = CreateObject<tbr_parametro_descvend_uneg>();
            if (par_id != null)
                value.par_id = par_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            return value;
        }

        public tbr_parametro_markup_uneg Createtbr_parametro_markup_uneg(Int32? par_id = null, Int32? uneg_id = null, Nullable<Decimal> par_percentual = null)
        {
            tbr_parametro_markup_uneg value = CreateObject<tbr_parametro_markup_uneg>();
            if (par_id != null)
                value.par_id = par_id.Value;
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (par_percentual != null)
                value.par_percentual = par_percentual;
            return value;
        }

        public tbr_produto_estoque_dia Createtbr_produto_estoque_dia(Int32? uneg_id = null, Int32? pro_id = null, DateTime? proes_dt_cadastro = null, Nullable<DateTime> proes_dt_alteracao = null, Nullable<DateTime> proes_dt_leiturax = null, Nullable<DateTime> proes_dt_update = null, Nullable<Decimal> proes_estoque = null, Decimal? proes_estoque_dia = null, Nullable<Decimal> proes_custo_nf = null, Nullable<Decimal> proes_custo_real = null, Nullable<Decimal> proes_custo_medio = null, Nullable<Decimal> proes_preco_venda = null, String ecf_numero_serie = null)
        {
            tbr_produto_estoque_dia value = CreateObject<tbr_produto_estoque_dia>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (proes_dt_cadastro != null)
                value.proes_dt_cadastro = proes_dt_cadastro.Value;
            if (proes_dt_alteracao != null)
                value.proes_dt_alteracao = proes_dt_alteracao;
            if (proes_dt_leiturax != null)
                value.proes_dt_leiturax = proes_dt_leiturax;
            if (proes_dt_update != null)
                value.proes_dt_update = proes_dt_update;
            if (proes_estoque != null)
                value.proes_estoque = proes_estoque;
            if (proes_estoque_dia != null)
                value.proes_estoque_dia = proes_estoque_dia.Value;
            if (proes_custo_nf != null)
                value.proes_custo_nf = proes_custo_nf;
            if (proes_custo_real != null)
                value.proes_custo_real = proes_custo_real;
            if (proes_custo_medio != null)
                value.proes_custo_medio = proes_custo_medio;
            if (proes_preco_venda != null)
                value.proes_preco_venda = proes_preco_venda;
            if (ecf_numero_serie != null)
                value.ecf_numero_serie = ecf_numero_serie;
            return value;
        }

        public tbr_produto_estoque_lote Createtbr_produto_estoque_lote(Int32? uneg_id = null, Int32? pro_id = null, String lote_numero = null, DateTime? lote_validade = null, Nullable<Decimal> lote_estoque = null, Nullable<DateTime> lote_fabricacao = null, Nullable<Decimal> lote_vlr_pmc = null, Nullable<DateTime> lote_dt_alteracao = null)
        {
            tbr_produto_estoque_lote value = CreateObject<tbr_produto_estoque_lote>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (lote_numero != null)
                value.lote_numero = lote_numero;
            if (lote_validade != null)
                value.lote_validade = lote_validade.Value;
            if (lote_estoque != null)
                value.lote_estoque = lote_estoque;
            if (lote_fabricacao != null)
                value.lote_fabricacao = lote_fabricacao;
            if (lote_vlr_pmc != null)
                value.lote_vlr_pmc = lote_vlr_pmc;
            if (lote_dt_alteracao != null)
                value.lote_dt_alteracao = lote_dt_alteracao;
            return value;
        }

        public tbr_produto_tributacao Createtbr_produto_tributacao(Int32? pro_id = null, Int32? uf_id = null, String protrb_class_tributaria = null, Nullable<Int32> protrb_origem_cst = null, String protrb_situacao = null, Nullable<DateTime> protrb_dt_cadastro = null, Nullable<DateTime> protrb_dt_alteracao = null)
        {
            tbr_produto_tributacao value = CreateObject<tbr_produto_tributacao>();
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (uf_id != null)
                value.uf_id = uf_id.Value;
            if (protrb_class_tributaria != null)
                value.protrb_class_tributaria = protrb_class_tributaria;
            if (protrb_origem_cst != null)
                value.protrb_origem_cst = protrb_origem_cst;
            if (protrb_situacao != null)
                value.protrb_situacao = protrb_situacao;
            if (protrb_dt_cadastro != null)
                value.protrb_dt_cadastro = protrb_dt_cadastro;
            if (protrb_dt_alteracao != null)
                value.protrb_dt_alteracao = protrb_dt_alteracao;
            return value;
        }

        public tbr_produto_uneg Createtbr_produto_uneg(Int32? uneg_id = null, Int32? pro_id = null, Nullable<Decimal> proun_preco_venda = null, String proun_situacao = null, Nullable<Decimal> proun_custo_nf = null, Nullable<Decimal> proun_encargos_nf = null, Nullable<Decimal> proun_descontos_nf = null, Nullable<Decimal> proun_custo_real = null, Nullable<Decimal> proun_custo_medio = null, Nullable<Decimal> proun_dia_min = null, Nullable<Decimal> proun_dia_max = null, Nullable<Decimal> proun_qtd_min = null, Nullable<Decimal> proun_qtd_max = null, Nullable<Boolean> proun_fixa_qtd_max = null, Nullable<Decimal> proun_vnd_media = null, Nullable<Boolean> proun_repos_auto = null, String proun_abc_qtde = null, String proun_abc_val = null, String proun_abc_mrg = null, Nullable<Decimal> proun_abc_qtde_rank = null, Nullable<Decimal> proun_abc_val_rank = null, Nullable<Decimal> proun_abc_mrg_rank = null, Nullable<Decimal> proun_qtd_estoque = null, Nullable<Decimal> proun_qtd_pedida = null, Nullable<Decimal> proun_qtd_transferida = null, Nullable<DateTime> proun_dt_ult_compra = null, Nullable<DateTime> proun_dt_ult_venda = null, Nullable<DateTime> proun_dt_ult_mvto = null, Nullable<DateTime> proun_dt_ult_preco = null, Nullable<DateTime> proun_dt_cadastro = null, Nullable<DateTime> proun_dt_alteracao = null, Nullable<Boolean> proun_bloq_compra = null, Nullable<DateTime> proun_dt_ult_inventario = null, Nullable<Int32> proun_id_ult_fornecedor = null)
        {
            tbr_produto_uneg value = CreateObject<tbr_produto_uneg>();
            if (uneg_id != null)
                value.uneg_id = uneg_id.Value;
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (proun_preco_venda != null)
                value.proun_preco_venda = proun_preco_venda;
            if (proun_situacao != null)
                value.proun_situacao = proun_situacao;
            if (proun_custo_nf != null)
                value.proun_custo_nf = proun_custo_nf;
            if (proun_encargos_nf != null)
                value.proun_encargos_nf = proun_encargos_nf;
            if (proun_descontos_nf != null)
                value.proun_descontos_nf = proun_descontos_nf;
            if (proun_custo_real != null)
                value.proun_custo_real = proun_custo_real;
            if (proun_custo_medio != null)
                value.proun_custo_medio = proun_custo_medio;
            if (proun_dia_min != null)
                value.proun_dia_min = proun_dia_min;
            if (proun_dia_max != null)
                value.proun_dia_max = proun_dia_max;
            if (proun_qtd_min != null)
                value.proun_qtd_min = proun_qtd_min;
            if (proun_qtd_max != null)
                value.proun_qtd_max = proun_qtd_max;
            if (proun_fixa_qtd_max != null)
                value.proun_fixa_qtd_max = proun_fixa_qtd_max;
            if (proun_vnd_media != null)
                value.proun_vnd_media = proun_vnd_media;
            if (proun_repos_auto != null)
                value.proun_repos_auto = proun_repos_auto;
            if (proun_abc_qtde != null)
                value.proun_abc_qtde = proun_abc_qtde;
            if (proun_abc_val != null)
                value.proun_abc_val = proun_abc_val;
            if (proun_abc_mrg != null)
                value.proun_abc_mrg = proun_abc_mrg;
            if (proun_abc_qtde_rank != null)
                value.proun_abc_qtde_rank = proun_abc_qtde_rank;
            if (proun_abc_val_rank != null)
                value.proun_abc_val_rank = proun_abc_val_rank;
            if (proun_abc_mrg_rank != null)
                value.proun_abc_mrg_rank = proun_abc_mrg_rank;
            if (proun_qtd_estoque != null)
                value.proun_qtd_estoque = proun_qtd_estoque;
            if (proun_qtd_pedida != null)
                value.proun_qtd_pedida = proun_qtd_pedida;
            if (proun_qtd_transferida != null)
                value.proun_qtd_transferida = proun_qtd_transferida;
            if (proun_dt_ult_compra != null)
                value.proun_dt_ult_compra = proun_dt_ult_compra;
            if (proun_dt_ult_venda != null)
                value.proun_dt_ult_venda = proun_dt_ult_venda;
            if (proun_dt_ult_mvto != null)
                value.proun_dt_ult_mvto = proun_dt_ult_mvto;
            if (proun_dt_ult_preco != null)
                value.proun_dt_ult_preco = proun_dt_ult_preco;
            if (proun_dt_cadastro != null)
                value.proun_dt_cadastro = proun_dt_cadastro;
            if (proun_dt_alteracao != null)
                value.proun_dt_alteracao = proun_dt_alteracao;
            if (proun_bloq_compra != null)
                value.proun_bloq_compra = proun_bloq_compra;
            if (proun_dt_ult_inventario != null)
                value.proun_dt_ult_inventario = proun_dt_ult_inventario;
            if (proun_id_ult_fornecedor != null)
                value.proun_id_ult_fornecedor = proun_id_ult_fornecedor;
            return value;
        }

        public tbr_promocao_produto Createtbr_promocao_produto(Int32? prm_id = null, Int32? pro_id = null, Nullable<Decimal> prom_preco = null, String prom_situacao = null, Nullable<DateTime> prom_dt_cadastro = null, Nullable<DateTime> prom_dt_alteracao = null, Nullable<Decimal> prom_cpf_alteracao = null, String prom_app_alteracao = null)
        {
            tbr_promocao_produto value = CreateObject<tbr_promocao_produto>();
            if (prm_id != null)
                value.prm_id = prm_id.Value;
            if (pro_id != null)
                value.pro_id = pro_id.Value;
            if (prom_preco != null)
                value.prom_preco = prom_preco;
            if (prom_situacao != null)
                value.prom_situacao = prom_situacao;
            if (prom_dt_cadastro != null)
                value.prom_dt_cadastro = prom_dt_cadastro;
            if (prom_dt_alteracao != null)
                value.prom_dt_alteracao = prom_dt_alteracao;
            if (prom_cpf_alteracao != null)
                value.prom_cpf_alteracao = prom_cpf_alteracao;
            if (prom_app_alteracao != null)
                value.prom_app_alteracao = prom_app_alteracao;
            return value;
        }

        #endregion
    }
    
}
