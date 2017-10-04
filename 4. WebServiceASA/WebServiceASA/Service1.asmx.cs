using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using ASArquiteruraData;
using ASArquiteruraData.DataContextInterface;
using ASArquiteruraData.DataContext;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.Repository;
using System.Web.Script.Services;
using System.Data.Objects;
using Newtonsoft.Json;

namespace WebServiceASA
{  
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    public class SecuredWebServiceHeader : System.Web.Services.Protocols.SoapHeader
    {
        public string Username;
        public string Password;
        public string AuthenticatedToken;
    }
    
    [WebService(Namespace = "http://ServiceServidor/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
       
        
        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public string HelloWorld(string traz)
        {

            return "Hello " + traz;
        }

        #region SYNC SERVIDOR TERMINAL
        [WebMethod(Description = "SyncServidorTerminalUneg")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalUneg(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalUneg(data);
        }
        [WebMethod(Description = "SyncServidorTerminalAberturaCaixa")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalAberturaCaixa()
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalAberturaCaixa();
        }
       
        [WebMethod(Description = "SyncServidorTerminalPromocaoConvenio")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalPromocaoConvenio(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalPromocaoConvenio();
        }
        [WebMethod(Description = "SyncServidorTerminalPromocaoUneg")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalPromocaoUneg(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalPromocaoUneg();
        }
        [WebMethod(Description = "SyncServidorTerminaEntregaEndereco")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminaEntregaEndereco(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalEntregaEndereco(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoFamilia")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoFamilia(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoFamilia(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoFamiliaGrupo")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoFamiliaGrupo(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoFamiliaGrupo(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoFamiliaCategoria")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoFamiliaCategoria(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoFamiliaCategoria(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoFamiliaCategoriaSub")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoFamiliaCategoriaSub(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoFamiliaCategoriaSub(data);
        }

        [WebMethod(Description = "SyncServidorTerminalUsuarioFuncao")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalUsuarioFuncao(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalUsuarioFuncao(data);
        }

        [WebMethod(Description = "SyncServidorTerminalFuncionario")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalFuncionario(DateTime data)
        {
            
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalFuncionario(data);
        }

        [WebMethod(Description = "SyncServidorTerminalUsuario")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalUsuario(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalUsuario(data);
        }

        [WebMethod(Description = "SyncServidorTerminalTributacao")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalTributacao(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalTributacao(data);
        }
        [WebMethod(Description = "SyncServidorTerminalProduto")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProduto(DateTime data, int inicio, int fim)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProduto(data, inicio, fim);
        }

        [WebMethod(Description = "SyncServidorTerminalConvenio")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalConvenio(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalConvenio(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoBarra")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoBarra(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoBarra(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoTributacao")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoTributacao(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoTributacao(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoUneg")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoUneg(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoUneg(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoEstoqueDia")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoEstoqueDia(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoEstoqueDia(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoEstoqueLote")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoEstoqueLote(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoEstoqueLote(data);
        }

        [WebMethod(Description = "SyncServidorTerminalCrmEspecialidade")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalCrmEspecialidade(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalCrmEspecialidade(data);
        }

        [WebMethod(Description = "SyncServidorTerminalCrm")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalCrm(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalCrm(data);
        }
        [WebMethod(Description = "SyncServidorTerminalCrmEndereco")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalCrmEndereco(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalCrmEndereco(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoContar")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoContar(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoContar();
        }

        [WebMethod(Description = "SyncServidorTerminalCliente")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalCliente(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalCliente(data);
        }

        [WebMethod(Description = "SyncServidorTerminalClienteEndereco")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalClienteEndereco(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalClienteEndereco(data);
        }
        [WebMethod(Description = "SyncServidorTerminalClienteTelefone")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalClienteTelefone(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalClienteTelefone(data);
        }

        [WebMethod(Description = "SyncServidorTerminalFornecedor")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalFornecedor(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalFornecedor(data);
        }

        [WebMethod(Description = "SyncServidorTerminalBanco")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalBanco(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalBanco(data);
        }

        [WebMethod(Description = "SyncServidorTerminalFinanceiroEvento")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalFinanceiroEvento(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalFinanceiroEvento(data);
        }

        [WebMethod(Description = "SyncServidorTerminalFinanceiroPrazo")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalFinanceiroPrazo(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalFinanceiroPrazo(data);
        }

        [WebMethod(Description = "SyncServidorTerminalFinalizadoraSub")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalFinalizadoraSub(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalFinalizadoraSub(data);
        }

        [WebMethod(Description = "SyncServidorTerminalFinanceiroAdministradora")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalFinanceiroAdministradora(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalFinanceiroAdministradora(data);
        }

        [WebMethod(Description = "TestSyncServidorTerminalFinalizadora")]
        [ScriptMethod(UseHttpGet = true)]
        public String TestSyncServidorTerminalFinalizadora(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalFinalizadora(data);
        }

        [WebMethod(Description = "SyncServidorTerminalIbptAx")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalIbptAx(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalIbptAx(data);
        }

        [WebMethod(Description = "SyncServidorTerminalNegocioParametro")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalNegocioParametro(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalNegocioParametro(data);
        }

        [WebMethod(Description = "SyncServidorTerminalParametroMarkup")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalParametroMarkup(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalParametroMarkup(data);
        }

        [WebMethod(Description = "SyncServidorTerminalParametroComissao")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalParametroComissao(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalParametroComissao(data);
        }

        [WebMethod(Description = "SyncServidorTerminalAbcFarma")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalAbcFarma(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalAbcFarma(data);
        }

        [WebMethod(Description = "SyncServidorTerminalAbcFarmaPeriodo")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalAbcFarmaPeriodo(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalAbcFarmaPeriodo(data);
        }

        [WebMethod(Description = "SyncServidorTerminalProdutoPrincAtivo")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalProdutoPrincAtivo(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalProdutoPrincAtivo(data);
        }

        [WebMethod(Description = "SyncServidorTerminalClienteFiscal")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalClienteFiscal(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalClienteFiscal(data);
        }

        [WebMethod(Description = "SyncServidorTerminalConvenioCliente")]
       
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalConvenioCliente(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalConvenioCliente(data);
        }

        [WebMethod(Description = "SyncServidorTerminalPromocaoTipo")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalPromocaoTipo(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalPromocaoTipo(data);
        }

        [WebMethod(Description = "SyncServidorTerminalPromocao")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalPromocao(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalPromocao(data);
        }

        [WebMethod(Description = "SyncServidorTerminalPromocaoProduto")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalPromocaoProduto(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalPromocaoProduto(data);
        }

        [WebMethod(Description = "SyncServidorTerminalParametroDescConv")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalParametroDescConv(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalParametroDescConv(data);
        }

        [WebMethod(Description = "SyncServidorTerminalParametroDescProd")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalParametroDescProd(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalParametroDescProd(data);
        }

        [WebMethod(Description = "SyncServidorTerminalConvenioFinalizadoraSub")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalConvenioFinalizadoraSub(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalConvenioFinalizadoraSub(data);
        }

        [WebMethod(Description = "SyncServidorTerminalParametroDescProdUneg")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalParametroDescProdUneg()
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalParametroDescProdUneg();
        }

        [WebMethod(Description = "SyncServidorTerminalParametroDescVendUneg")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalParametroDescVendUneg()
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalParametroDescVendUneg();
        }


        [WebMethod(Description = "SyncServidorTerminalFinalizadoraUn")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalFinalizadoraUn(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalFinalizadoraUn(data);
        }

        [WebMethod(Description = "SyncServidorTerminalFinalizadoraSubUn")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalFinalizadoraSubUn(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalFinalizadoraSubUn(data);
        }

        [WebMethod(Description = "SyncServidorTerminalParametroDescVend")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncServidorTerminalParametroDescVend(DateTime data)
        {
            return ArquiteturaTesteASA.UnitTest1.TestSyncServidorTerminalParametroDescVend(data);
        }
        #endregion

        #region SERVIÇOS DE INSTALAÇÃO
        [WebMethod(Description = "Identifica Terminal no Servidor")]
        [ScriptMethod(UseHttpGet = true)]
        public String ServiceIdentificaTerminal(string SerieHD)
        {
            return ArquiteturaTesteASA.UnitTest1.IdentificaTerminal(SerieHD);
        }

        [WebMethod(Description = "Inserrir Terminal no Servidor")]
        [ScriptMethod(UseHttpGet = true)]
        public Boolean ServiceInserirTerminal(string terminal)
        {
            return ArquiteturaTesteASA.UnitTest1.IserirTerminal(terminal);
        }

        [WebMethod(Description = "Identifica ECF")]
        [ScriptMethod(UseHttpGet = true)]
        public String IdentificaEcf(string ecfm_id_marca, string ecfm_id_versao, string ecfm_id_modelo)
        {
            return ArquiteturaTesteASA.UnitTest1.IdentificaEcf(ecfm_id_marca, ecfm_id_versao, ecfm_id_modelo);
        }

        [WebMethod(Description = "Identifica Finalizadoras")]
        [ScriptMethod(UseHttpGet = true)]
        public String IdentificaFinalizadoras(string ecf_numero_serie)
        {
            return ArquiteturaTesteASA.UnitTest1.IdentificaFinalizadoras(ecf_numero_serie);
        }
        [WebMethod(Description = "Conta Maquina")]
        public string ContaMaquina()
        {
            return ArquiteturaTesteASA.UnitTest1.ContaMaquina();
        }
        #endregion

        #region SYNC TERMINAL SERVIDOR

        [WebMethod(Description = "Pega a data de ultima importação Servidor Web")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncTerminalServidorDataDeimport()
        {
          
          return  ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorDataDeimport();
              
         

        }

        [WebMethod(Description = "SyncTerminalServidorDanfe")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorDanfe(string obj)
        {
            try
            {   
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorDanfe(obj);
                return "true";
            }
            catch
            {

                return "false";
            }
         
        }

        [WebMethod(Description = "SyncTerminalServidorCrmEndereco")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorCrmEndereco(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorCrmEndereco(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorCliente")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorCliente(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorCliente(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorClienteEndereco")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorClienteEndereco(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorClienteEndereco(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorClienteTelefone")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorClienteTelefone(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorClienteTelefone(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorClienteAnvisa")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorClienteAnvisa(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorClienteAnvisa(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorClienteFiscal")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorClienteFiscal(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorClienteFiscal(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorPacienteAnvisa")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorPacienteAnvisa(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorPacienteAnvisa(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorCrediario")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorCrediario(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorCrediario(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorCrediarioFinalizadora")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorCrediarioFinalizadora(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorCrediarioFinalizadora(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorEcf")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorEcf(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorEcf(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorEcfDd")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorEcfDd(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorEcfDd(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorReducaoZ")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorReducaoZ(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorReducaoZ(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorReducaoZItens")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorReducaoZItens(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorReducaoZItens(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorRecarga")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorRecarga(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorRecarga(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorRecargaFinalizadora")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorRecargaFinalizadora(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorRecargaFinalizadora(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorPrivateLabel")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorPrivateLabel(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorPrivateLabel(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorPrivateLabelFinalizadora")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorPrivateLabelFinalizadora(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorPrivateLabelFinalizadora(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorCheckin")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorCheckin(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorCheckin(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorCheckin")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorCheckinItem(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorCheckinItem(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorCheckout")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorCheckout(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorCheckout(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorCheckoutItem")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorCheckoutItem(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorCheckoutItem(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorAberturaCaixa")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorAberturaCaixa(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorAberturaCaixa(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorAgendaProduto")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorAgendaProduto(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorAgendaProduto(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorLanctoFinanceiro")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorLanctoFinanceiro(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorLanctoFinanceiro(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorNfe")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorNfe(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorNfe(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorNfeCfop")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorNfeCfop(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorNfeCfop(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorNfeDanfe")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorNfeDanfe(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorNfeDanfe(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorNfeFinalizadora")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorNfeFinalizadora(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorNfeFinalizadora(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorNfeItem")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorNfeItem(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorNfeItem(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorPonto")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorPonto(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorPonto(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorSangria")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorSangria(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorSangria(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorSuprimento")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorSuprimento(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorSuprimento(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorVenda")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorVenda(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorVenda(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorVendaItem")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorVendaItem(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorVendaItem(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }

        [WebMethod(Description = "SyncTerminalServidorVendaPagamento")]
        [ScriptMethod(UseHttpGet = true)]
        public string SyncTerminalServidorVendaPagamento(string obj)
        {
            try
            {
                ArquiteturaTesteASA.UnitTest1.TestSyncTerminalServidorVendaPagamento(obj);
                return "true";
            }
            catch
            {

                return "false";
            }

        }
        
        
        
        #endregion

    }
}