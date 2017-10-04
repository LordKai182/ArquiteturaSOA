using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASArquiteruraData;
using ASArquiteruraData.DataContextInterface;
using ASArquiteruraData.DataContext;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.Repository;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Data.Objects;
using System.Text;
using System.Net;
using System.Xml;
using ASAsysFwSiTef;
using Rest;
using System.Data.SqlClient;
using ASArquiteruraData.GenericRepositoryInterface;
using System.Xml.Serialization;

namespace ArquiteturaTesteASA
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod, Description("TESTEXML")]
        public void TESTEXML()
        {
            Util.ClassesObj.NfeObj.det item = new Util.ClassesObj.NfeObj.det()
            {
                nItem  = "1",
                prod = new List<Util.ClassesObj.NfeObj.pra>()
                {
                   
                    new Util.ClassesObj.NfeObj.pra{cProd = "123456789",xProd ="teste de descricao" },
                     new Util.ClassesObj.NfeObj.pra{cProd = "oososososos",xProd ="teste de descricao2" } 
                }
            };
           
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            XmlSerializer ser = new XmlSerializer(typeof(Util.ClassesObj.NfeObj.det));
            using (XmlWriter writer = XmlWriter.Create(@"C:/Teste/test.xml"))
            {
                ser.Serialize(writer, item, ns); 
            }
        }

        [TestMethod, Description("TESTERR")]
        public void TESTERR()
        {
            //Itb_promocaoRepository PromocaoResp = new tb_promocaoRepository();

            //PromocaoResp.AddAllList(JsonConvert.DeserializeObject<List<tb_promocao>>(Resp("SyncServidorTerminalPromocao", "?data=2016-01-01 16:37:32")), true);
            //Itbr_promocao_produtoRepository PromProRep = new tbr_promocao_produtoRepository();

            //PromProRep.AddAllList(JsonConvert.DeserializeObject<List<tbr_promocao_produto>>(Resp("SyncServidorTerminalPromocaoProduto", "?data=2016-01-01 16:37:32")), true);
           
            //ADICIONA<SPtbr_promocao_uneg_Result>.AdicionaPorFora(JsonConvert.DeserializeObject<List<SPtbr_promocao_uneg_Result>>(Resp("SyncServidorTerminalPromocaoUneg", "?data=2016-01-01 16:37:32")), "tbr_promocao_uneg", true);
            //ADICIONA<tbr_promocao_convenio_Result>.AdicionaPorFora(JsonConvert.DeserializeObject<List<tbr_promocao_convenio_Result>>(Resp("SyncServidorTerminalPromocaoConvenio", "?data=2016-01-01 16:37:32")), "tbr_promocao_convenio", true);

           
            Itb_produtoRepository ParDescVenRep = new tb_produtoRepository();
            
            List<tb_produto> lst = new List<tb_produto>(ParDescVenRep.GetAll());
          

          //  var cli = ParDescVenRep.Find(s => s.cli_id.Equals(210691743));
        }


        [TestMethod, Description("TESTER")]
        public void TESTER()
        {
            DateTime data = DateTime.Now;
            var context = new db_lojaEntities2();
            ObjectResult<SPtbr_promocao_convenio_Result> orderDetailEnumerable = context.SPtbr_promocao_convenio(data, 16);
            List<SPtbr_promocao_convenio_Result> details = orderDetailEnumerable.ToList();
            var output = JsonConvert.SerializeObject(details);
        
        }


        [TestMethod, Description("PromocaoUneg")]
        public static String TestSyncServidorTerminalPromocaoUneg()
        {
            DateTime data = DateTime.Now;
            var context = new db_lojaEntities2();
            ObjectResult<SPtbr_promocao_uneg_Result1> orderDetailEnumerable = context.SPtbr_promocao_uneg(data, 6);
            List<SPtbr_promocao_uneg_Result1> details = orderDetailEnumerable.ToList();
            var output = JsonConvert.SerializeObject(details);
            return output;
        
        }
        [TestMethod, Description("PromocaoConvenio")]
        public static String TestSyncServidorTerminalPromocaoConvenio()
        {
            DateTime data = DateTime.Now;
            var context = new db_lojaEntities2();
            ObjectResult<SPtbr_promocao_convenio_Result> orderDetailEnumerable = context.SPtbr_promocao_convenio(data, 16);
            List<SPtbr_promocao_convenio_Result> details = orderDetailEnumerable.ToList();
            var output = JsonConvert.SerializeObject(details);
            return output;

        }
       


        [TestMethod, Description("PromocaoUneg")]
        public void PromocaoUneg()
        {
            DateTime data = DateTime.Now;
            var context = new db_lojaEntities2();
            ObjectResult<SPtbr_promocao_uneg_Result1> orderDetailEnumerable = context.SPtbr_promocao_uneg(data, 6);
            List<SPtbr_promocao_uneg_Result1> details = orderDetailEnumerable.ToList();
            var output = JsonConvert.SerializeObject(details);
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;" +
            "Initial Catalog=db_loja;" +
            "User id=sa;" +
            "Password=VQXsSf7Z1NKV.qXGZsX7Z1Be.;";
            BULK.TESTE.staticfunc<SPtbr_promocao_uneg_Result1>(conn.ConnectionString, "tbr_promocao_uneg", details,true);
            
        }




        [TestMethod, Description("TESTA RECEBE VENDA PAGAMENTO")]
        public void TESTAUPSERT()
        {
            Itb_produtoRepository vendaResp = new tb_produtoRepository();


            List<tb_produto> lst = new List<tb_produto>(vendaResp.GetAll());


            TestSyncTerminalServidorVenda(JsonConvert.SerializeObject(vendaResp.GetAll()));






        }




           #region TESTESITEF
        [TestMethod, Description("TESTA PIN PAD")]
        public void TestaTEF()
        {

            Sitef sitef = new Sitef("201.49.221.59:61888", "00000000", 1);

            int retorno = sitef.ConfiguraIntSiTefInterativoEx("201.49.221.59:61888", "00000000", "SW000001",0, string.Empty);
            bool teste = sitef.VerificaPresencaPinPad();
            sitef.EscreveMensagemPermanentePinPad("OIIIII");
           
        }
        #endregion

           #region TESTE WEB SERVICE

        public String Resp(string Servico, string argumentos)
        {

            Stream requestStream = null;
            WebResponse response = null;
            StreamReader reader = null;
            var url = "http://Servidor/Teste/Service1.asmx/" + Servico + argumentos;
            WebRequest request = WebRequest.Create(url);
            request.Method = WebRequestMethods.Http.Get;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Timeout = 60000;
            response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            System.Text.Encoding encoding = System.Text.Encoding.Default;
            reader = new StreamReader(responseStream, encoding);
            Char[] charBuffer = new Char[256];
            int count = reader.Read(charBuffer, 0, charBuffer.Length);

            StringBuilder Dados = new StringBuilder();
            while (count > 0)
            {
                Dados.Append(new String(charBuffer, 0, count));
                count = reader.Read(charBuffer, 0, charBuffer.Length);
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(Dados.ToString());
            string xmlRetorno2 = xDoc.GetElementsByTagName("string").Item(0).InnerText;

            return xmlRetorno2;
        }
        [TestMethod, Description("ADDLIST")]
        public void sincro()
        {

            DateTime dataImport = new DateTime();

            dataImport = Convert.ToDateTime("2015-01-01");

            string DtImport = dataImport.Year + "-" + dataImport.Month + "-" + dataImport.Day + " " + dataImport.Hour + ":" + dataImport.Minute + ":" + dataImport.Second;
            Itb_produtoRepository ProdResp = new tb_produtoRepository();

            int inicio = 0;
            int fim = 3000;
            int totalRegistros = Convert.ToInt32(Resp("SyncServidorTerminalProdutoContar", "?data=" + DtImport));
            while (inicio < totalRegistros)
            {
                ProdResp.AddAllList(JsonConvert.DeserializeObject<List<tb_produto>>(Resp("SyncServidorTerminalProduto", "?data=" + DtImport + "&inicio=" + inicio + "&fim=" + fim)),true);
                inicio = inicio + fim;

            }
          
               
            

              
            
           
            #endregion


            //

            #region TB_PRODUTO

            //Itb_produtoRepository FuncResp = new tb_produtoRepository();
            //int id = FuncResp.GetAll().Count();
            //int inicio = 0;
            //int fim = 3000;
            //int totalRegistros = Convert.ToInt32(Resp("SyncServidorTerminalProdutoContar", ""));

            //while (inicio <= totalRegistros)
            //{

            //   FuncResp.AddAllList(JsonConvert.DeserializeObject<List<tb_produto>>(Resp("SyncServidorTerminalProduto", "?data=" + data + "&inicio=" + inicio + "&fim=" + fim)));


            //    inicio = inicio + fim;


            //}
            #endregion

        }
        [TestMethod, Description("TESTA RECEBE VENDA PAGAMENTO")]
        public void RecebeVendaPag()
        {

            //Itb_promocaoRepository pro = new tb_promocaoRepository();
          
            //pro.Limpar("tb_promocao");

            


            //Itb_vendaRepository UnegResp = new tb_vendaRepository();
            //UnegResp.Limpar("tbr_promocao_uneg");
           
            //var client = new RestClient();
            //client.EndPoint = @"http://Servidor/Teste/Service1.asmx/SyncTerminalServidorVendaItem";
            //client.Method = HttpVerb.GET;
            //client.PostData = "?obj="+JsonConvert.SerializeObject(UnegResp.GetAll());
            //var json = client.MakeRequest(client.PostData);

          //  UnegResp.BulkUpSertList(JsonConvert.DeserializeObject<List<tb_unid_negocio>>(sincronia.SyncServidorTerminalUneg(DateTime.Now)));


            //Itb_venda_pagamentoRepository vendapagResp = new tb_venda_pagamentoRepository();
            //string output = JsonConvert.SerializeObject(vendapagResp.GetAll());
            //List<tb_venda_pagamento> obj =  JsonConvert.DeserializeObject<List<tb_venda_pagamento>>(output);
            //ServiceReference1.Service1SoapClient servico = new ServiceReference1.Service1SoapClient();
              //vendapagResp.AddAllList(obj);
            //foreach (var item in obj)
            //{
            //    vendapagResp.Update(item);
            //}


           //servico.SyncTerminalServidorVendaPagamento(output);


           Itb_promocaoRepository prot = new tb_promocaoRepository();

            prot.Limpar("tb_promocao");
            
            prot.AddAllList(JsonConvert.DeserializeObject<List<tb_promocao>>(Resp("SyncServidorTerminalPromocao", "?data=2016-01-01 16:37:32")),true);

            ADICIONA<SPtbr_promocao_uneg_Result>.AdicionaPorFora(JsonConvert.DeserializeObject<List<SPtbr_promocao_uneg_Result>>(Resp("SyncServidorTerminalPromocaoUneg", "?data=2016-01-01 16:37:32")), "tbr_promocao_uneg",true);

            ADICIONA<tbr_promocao_convenio_Result>.AdicionaPorFora(JsonConvert.DeserializeObject<List<tbr_promocao_convenio_Result>>(Resp("SyncServidorTerminalPromocaoConvenio", "?data=2016-01-01 16:37:32")), "tbr_promocao_convenio",true);

        }


        [TestMethod, Description("TESTA RECEBE VENDA")]
        public void RecebeVenda() 
        {
            Itb_vendaRepository vendaResp = new tb_vendaRepository();
            string output = JsonConvert.SerializeObject(vendaResp.GetAll());
           
            vendaResp.BulkUpSertList(JsonConvert.DeserializeObject<List<tb_venda>>(output));
            
        
        }

        [TestMethod, Description("ADD")]
        public void Add()
        {
            DateTime data = Convert.ToDateTime("2015-01-01");
            Itb_funcionarioRepository FuncResp = new tb_funcionarioRepository();
            int id = FuncResp.GetAll().Count();

            try
            {
                FuncResp.AddAllList(JsonConvert.DeserializeObject<List<tb_funcionario>>(Resp("SyncServidorTerminalFuncionario", "?data=" + data)),false);
            }
            catch (Exception)
            {

                FuncResp.BulkUpSertList(JsonConvert.DeserializeObject<List<tb_funcionario>>(Resp("SyncServidorTerminalFuncionario", "?data=" + data)));
            }
           

           
        }
         
         
         
         #region SYNC SERVIDOR TERMINAL

        [TestMethod, Description("SyncServidorTerminalProdutoContar")]
        public static String TestSyncServidorTerminalProdutoContar()
        {
            Itb_produtoRepository prodRep = new tb_produtoRepository();

            return prodRep.GetAll().Count().ToString();

        }

        [TestMethod, Description("SyncServidorTerminalUneg")]
         public static String TestSyncServidorTerminalUneg(DateTime data)
         {
             Itb_unid_negocioRepository unegRep = new tb_unid_negocioRepository();
             string retorno = string.Empty;
             string output = JsonConvert.SerializeObject(unegRep.GetAll());
             return output; 
          
         }

         [TestMethod, Description("SyncServidorTerminalProdutoFamilia")]
         public static String TestSyncServidorTerminalProdutoFamilia(DateTime data)
         {
             Itb_produto_familiaRepository proFamRep = new tb_produto_familiaRepository();

             string output = JsonConvert.SerializeObject(proFamRep.Find(s => s.fam_dt_alteracao >= data || s.fam_dt_cadastro >= data));
             return output; 
         }

         [TestMethod, Description("SyncServidorTerminalProdutoFamiliaGrupo")]
         public static String TestSyncServidorTerminalProdutoFamiliaGrupo(DateTime data)
         {
             Itb_produto_fam_grupoRepository proFamGruRep = new tb_produto_fam_grupoRepository();
             string output = JsonConvert.SerializeObject(proFamGruRep.Find(s => s.grp_dt_alteracao >= data || s.grp_dt_cadastro >= data));
             return output; 
         }

         [TestMethod, Description("SyncServidorTerminalProdutoFamiliaCategoria")]
         public static String TestSyncServidorTerminalProdutoFamiliaCategoria(DateTime data)
         {
             Itb_produto_fam_categoriaRepository proFamCatRep = new tb_produto_fam_categoriaRepository();
             string output = JsonConvert.SerializeObject(proFamCatRep.Find(s => s.cat_dt_alteracao >= data || s.cat_dt_cadastro >= data));
             return output; 
         }

         [TestMethod, Description("SyncServidorTerminalProdutoFamiliaCategoriaSub")]
         public static String TestSyncServidorTerminalProdutoFamiliaCategoriaSub(DateTime data)
         {
             Itb_produto_fam_categ_subRepository  proFamCatSubRep = new tb_produto_fam_categ_subRepository();
             string output = JsonConvert.SerializeObject(proFamCatSubRep.Find(s => s.scat_dt_alteracao >= data || s.scat_dt_cadastro >= data));
             return output; 
         }

         [TestMethod, Description("SyncServidorTerminalUsuarioFuncao")]
         public static String TestSyncServidorTerminalUsuarioFuncao(DateTime data)
         {
             Itb_usuario_funcaoRepository UsuFuncRep = new tb_usuario_funcaoRepository();
             string output = JsonConvert.SerializeObject(UsuFuncRep.Find(s => s.funcao_dt_alteracao >= data || s.funcao_dt_cadastro >= data));
             return output;   
          
         }

         [TestMethod, Description("SyncServidorTerminalFuncionario")]
         public static String TestSyncServidorTerminalFuncionario(DateTime data)
         {
             Itb_funcionarioRepository FuncRep = new tb_funcionarioRepository();
             string output = JsonConvert.SerializeObject(FuncRep.Find(s => s.func_dt_alteracao >= data || s.func_dt_cadastro >= data));
             return output;
          }

         [TestMethod, Description("SyncServidorTerminalUsuario")]
         public static String TestSyncServidorTerminalUsuario(DateTime data)
         {
             Itb_usuarioRepository UsuRep = new tb_usuarioRepository();
             string output = JsonConvert.SerializeObject(UsuRep.Find(s => s.usr_dt_alteracao >= data || s.usr_dt_cadastro >= data));
             return output;
         }

         [TestMethod, Description("SyncServidorTerminalTributacao")]
         public static String TestSyncServidorTerminalTributacao(DateTime data)
         {
             Itb_tributacaoRepository TribRep = new tb_tributacaoRepository();
             string output = JsonConvert.SerializeObject(TribRep.Find(s => s.trb_dt_alteracao >= data || s.trb_dt_cadastro >= data));
             return output;
         }

         [TestMethod, Description("SyncServidorTerminalProduto")]
         public static String TestSyncServidorTerminalProduto(DateTime data,int inicio, int fim)
         {   
            
             Itb_produtoRepository ProdRep = new tb_produtoRepository();
             string output = JsonConvert.SerializeObject(ProdRep.Find(s => s.pro_dt_cadastro > data ||  s.pro_dt_alteracao > data).Skip(inicio).Take(fim) );
             
             return output;
         }

         [TestMethod, Description("SyncServidorTerminalProdutoBarra")]
         public static String TestSyncServidorTerminalProdutoBarra(DateTime data)
         {
             Itb_produto_barraRepository ProdBarRep = new tb_produto_barraRepository();
             string output = JsonConvert.SerializeObject(ProdBarRep.Find(s => s.barra_dt_alteracao >= data || s.barra_dt_cadastro >= data));
             return output;
         }

         [TestMethod, Description("SyncServidorTerminalProdutoTributacao")]
         public static String TestSyncServidorTerminalProdutoTributacao(DateTime data)
         {
             Itbr_produto_tributacaoRepository ProdTribRep = new tbr_produto_tributacaoRepository();
             string output = JsonConvert.SerializeObject(ProdTribRep.Find(s => s.protrb_dt_alteracao >= data || s.protrb_dt_cadastro >= data));
             return output;
         }

         [TestMethod, Description("SyncServidorTerminalProdutoUneg")]
         public static String TestSyncServidorTerminalProdutoUneg(DateTime data)
         {
             Itbr_produto_unegRepository ProUngRep = new tbr_produto_unegRepository();
             string output = JsonConvert.SerializeObject(ProUngRep.Find(s => s.proun_dt_alteracao >= data || s.proun_dt_cadastro >= data));
             return output;
         }

         [TestMethod, Description("SyncServidorTerminalProdutoEstoqueDia")]
         public static String TestSyncServidorTerminalProdutoEstoqueDia(DateTime data)
         {
             Itbr_produto_estoque_diaRepository ProEstDiaRep = new tbr_produto_estoque_diaRepository();
             string output = JsonConvert.SerializeObject(ProEstDiaRep.Find(s => s.proes_dt_alteracao >= data || s.proes_dt_cadastro >= data));
             return output;

         }

         [TestMethod, Description("SyncServidorTerminalProdutoEstoqueLote")]
         public static String TestSyncServidorTerminalProdutoEstoqueLote(DateTime data)
         {
             Itbr_produto_estoque_loteRepository ProEstLotRep = new tbr_produto_estoque_loteRepository();
             string output = JsonConvert.SerializeObject(ProEstLotRep.Find(s => s.lote_dt_alteracao >= data));
             return output;
         }

         [TestMethod, Description("SyncServidorTerminalCrmEspecialidade")]
         public static String TestSyncServidorTerminalCrmEspecialidade(DateTime data)
         {
             Itb_crm_especialidadeRepository CrmEspRep = new tb_crm_especialidadeRepository();
             string output = JsonConvert.SerializeObject(CrmEspRep.Find(s => s.esp_dt_alteracao >= data || s.esp_dt_cadastro >= data));
             return output;

         }

         [TestMethod, Description("SyncServidorTerminalCrm")]
         public static String TestSyncServidorTerminalCrm(DateTime data)
         {
             Itb_crmRepository CrmRep = new tb_crmRepository();
             string output = JsonConvert.SerializeObject(CrmRep.Find(s => s.crm_dt_alteracao >= data || s.crm_dt_cadastro >= data));
             return output;
             
         }

         [TestMethod, Description("SyncServidorTerminalCrmEndereco")]
         public static String TestSyncServidorTerminalCrmEndereco(DateTime data)
         {
             Itb_crm_enderecoRepository CrmEndRep = new tb_crm_enderecoRepository();
             string output = JsonConvert.SerializeObject(CrmEndRep.Find(s => s.crm_end_dt_alteracao >= data || s.crm_end_dt_cadastro >= data));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminalCliente")]
         public static String TestSyncServidorTerminalCliente(DateTime data)
         {
             Itb_clienteRepository clienteRep = new tb_clienteRepository();
             string output = JsonConvert.SerializeObject(clienteRep.Find(s => s.cli_dt_alteracao >= data || s.cli_dt_cadastro >= data));
             return output;

         }

         [TestMethod, Description("SyncServidorTerminalClienteEndereco")]
         public static String TestSyncServidorTerminalClienteEndereco(DateTime data)
         {
             Itb_cliente_enderecoRepository cliEndRep = new tb_cliente_enderecoRepository();
             string output = JsonConvert.SerializeObject(cliEndRep.Find(s => s.end_dt_alteracao >= data || s.end_dt_cadastro >= data));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminalClienteTelefone")]
         public static String TestSyncServidorTerminalClienteTelefone(DateTime data)
         {
             Itb_cliente_telefoneRepository cliTelRep = new tb_cliente_telefoneRepository();
             string output = JsonConvert.SerializeObject(cliTelRep.Find(s => s.tel_dt_alteracao >= data || s.tel_dt_cadastro >= data));
             return output;

         }

         [TestMethod, Description("SyncServidorTerminalFornecedor")]
         public static String TestSyncServidorTerminalFornecedor(DateTime data)
         {
             Itb_fornecedorRepository ForRep = new tb_fornecedorRepository();
             string output = JsonConvert.SerializeObject(ForRep.Find(s => s.fab_dt_alteracao >= data || s.fab_dt_cadastro >= data));
             return output;
           

         }

         [TestMethod, Description("SyncServidorTerminalBanco")]
         public static String TestSyncServidorTerminalBanco(DateTime data)
         {
             Itb_bancoRepository BancRep = new tb_bancoRepository();
             string output = JsonConvert.SerializeObject(BancRep.Find(s => s.banco_dt_alteracao >= data || s.banco_dt_cadastro >= data));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminalFinanceiroEvento")]
         public static String TestSyncServidorTerminalFinanceiroEvento(DateTime data)
         {
             Itb_financeiro_eventoRepository FinEveRep = new tb_financeiro_eventoRepository();
             string output = JsonConvert.SerializeObject(FinEveRep.Find(s => s.eventf_dt_alteracao >= data || s.eventf_dt_cadastro >= data));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminalFinanceiroPrazo")]
         public static String TestSyncServidorTerminalFinanceiroPrazo(DateTime data)
         {
             Itb_financeiro_prazoRepository FinPraRep = new tb_financeiro_prazoRepository();
             string output = JsonConvert.SerializeObject(FinPraRep.Find(s => s.prazo_dt_alteracao >= data || s.prazo_dt_cadastro >= data));
             return output;
             

         }

         [TestMethod, Description("SyncServidorTerminalFinalizadoraSub")]
         public static String TestSyncServidorTerminalFinalizadoraSub(DateTime data)
         {
             Itb_finalizadora_subRepository FinSubRep = new tb_finalizadora_subRepository();
             string output = JsonConvert.SerializeObject(FinSubRep.Find(s => s.finsub_dt_alteracao >= data || s.finsub_dt_cadastro >= data));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminalFinanceiroAdministradora")]
         public static String TestSyncServidorTerminalFinanceiroAdministradora(DateTime data)
         {
             Itb_financeiro_administradoraRepository FinAdmRep = new tb_financeiro_administradoraRepository();
             string output = JsonConvert.SerializeObject(FinAdmRep.Find(s => s.adm_dt_alteracao >= data || s.adm_dt_cadastro >= data));
             return output;

         }

         [TestMethod, Description("SyncServidorTerminalFinalizadora")]
         public static String TestSyncServidorTerminalFinalizadora(DateTime data)
         {
             Itb_finalizadoraRepository FinRep = new tb_finalizadoraRepository();
             string output = JsonConvert.SerializeObject(FinRep.Find(s => s.final_dt_alteracao >= data || s.final_dt_cadastro >= data));
             return output;

         }

         [TestMethod, Description("SyncServidorTerminalIbptAx")]
         public static String TestSyncServidorTerminalIbptAx(DateTime data)
         {
             Itb_ibpt_axRepository ibpAxRep = new tb_ibpt_axRepository();
             string output = JsonConvert.SerializeObject(ibpAxRep.Find(s => s.iax_data_alteracao >= data));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminalNegocioParametro")]
         public static String TestSyncServidorTerminalNegocioParametro(DateTime data)
         {
             Itb_unid_negocio_parametroRepository UneParRep = new tb_unid_negocio_parametroRepository();
             string output = JsonConvert.SerializeObject(UneParRep.Find(s => s.par_dt_alteracao >= data  || s.par_dt_alteracao.Equals(null)));
             return output;

         }

         [TestMethod, Description("SyncServidorTerminalParametroMarkup")]
         public static String TestSyncServidorTerminalParametroMarkup(DateTime data)
         {
             Itb_parametro_markupRepository ParMarkRep = new tb_parametro_markupRepository();
             string output = JsonConvert.SerializeObject(ParMarkRep.Find(s => s.par_dt_alteracao >= data || s.par_dt_cadastro >= data));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminalParametroComissao")]
         public static String TestSyncServidorTerminalParametroComissao(DateTime data)
         {
             Itb_parametro_comissaoRepository ParComRep = new tb_parametro_comissaoRepository();
             string output = JsonConvert.SerializeObject(ParComRep.Find(s => s.par_dt_alteracao >= data || s.par_dt_cadastro >= data));
             return output;
             

         }

         [TestMethod, Description("SyncServidorTerminalAbcFarma")]
         public static String TestSyncServidorTerminalAbcFarma(DateTime data)
         {
             Itb_abcfarmaReporitory AbcFarRep = new tb_abcfarmaReporitory();
             string output = JsonConvert.SerializeObject(AbcFarRep.Find(s => s.abcf_dt_alteracao >= data || s.abcf_dt_alteracao.Equals(null)));
             return output;
             

         }

         [TestMethod, Description("SyncServidorTerminalAbcFarmaPeriodo")]
         public static String TestSyncServidorTerminalAbcFarmaPeriodo(DateTime data)
         {
             Itb_abcfarma_periodoRepository AbcFarPerRep = new tb_abcfarma_periodoRepository();
             string output = JsonConvert.SerializeObject(AbcFarPerRep.Find(s => s.per_dt_alteracao >= data || s.per_dt_alteracao.Equals(null)));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminalProdutoPrincAtivo")]
         public static String TestSyncServidorTerminalProdutoPrincAtivo(DateTime data)
         {
             Itb_produto_princativoRepository AbcFarPerRep = new tb_produto_princativoRepository();
             string output = JsonConvert.SerializeObject(AbcFarPerRep.Find(s => s.pat_dt_alteracao >= data || s.pat_dt_cadastro >= data));
             return output;
             

         }

         [TestMethod, Description("SyncServidorTerminalClienteFiscal")]
         public static String TestSyncServidorTerminalClienteFiscal(DateTime data)
         {
             Itb_cliente_fiscalRepository CliFisRep = new tb_cliente_fiscalRepository();
             string output = JsonConvert.SerializeObject(CliFisRep.Find(s => s.cli_fisc_data_cadastro >= data));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminaConvenio")]
         public static String TestSyncServidorTerminalConvenio(DateTime data)
         {
             Itb_convenioRepository ConvRep = new tb_convenioRepository();
             string output = JsonConvert.SerializeObject(ConvRep.Find(s => s.cnv_dt_alteracao >= data || s.cnv_dt_cadastro >= data));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminaConvenioCliente")]
         public static String TestSyncServidorTerminalConvenioCliente(DateTime data)
         {
             Itbr_convenio_clienteRepository ConvRep = new tbr_convenio_clienteRepository();
             string output = JsonConvert.SerializeObject(ConvRep.Find(s => s.clicnv_dt_alteracao >= data || s.clicnv_dt_cadastro >= data));
             return output;
             
         }

         [TestMethod, Description("SyncServidorTerminaPromocaoTipo")]
         public static String TestSyncServidorTerminalPromocaoTipo(DateTime data)
         {
             Itb_promocao_tipoRepository ProTipRep = new tb_promocao_tipoRepository();
             string output = JsonConvert.SerializeObject(ProTipRep.Find(s => s.tippro_dt_alteracao >= data || s.tippro_dt_cadastro >= data));
             return output;
            

         }

         [TestMethod, Description("SyncServidorTerminaPromocao")]
         public static String TestSyncServidorTerminalPromocao(DateTime data)
         {
             Itb_promocaoRepository ProRep = new tb_promocaoRepository();
             string output = JsonConvert.SerializeObject(ProRep.Find(s => s.prm_dt_alteracao >= data || s.prm_dt_cadastro >= data));
             return output;
             

         }

         [TestMethod, Description("SyncServidorTerminaPromocaoProduto")]
         public static String TestSyncServidorTerminalPromocaoProduto(DateTime data)
         {
             Itbr_promocao_produtoRepository PromProRep = new tbr_promocao_produtoRepository();
             string output = JsonConvert.SerializeObject(PromProRep.Find(s => s.prom_dt_alteracao >= data || s.prom_dt_cadastro >= data));
             return output;
             

         }

         [TestMethod, Description("SyncServidorTerminaParametroDescConv")]
         public static String TestSyncServidorTerminalParametroDescConv(DateTime data)
         {
             Itb_parametro_descconvRepository ParDesConRep = new tb_parametro_descconvRepository();
             string output = JsonConvert.SerializeObject(ParDesConRep.GetAll());
             return output;
              

         }

         [TestMethod, Description("SyncServidorTerminaParametroDescProd")]
         public static String TestSyncServidorTerminalParametroDescProd(DateTime data)
         {
             Itb_parametro_descprodRepository ParDesProdRep = new tb_parametro_descprodRepository();
             string output = JsonConvert.SerializeObject(ParDesProdRep.Find(s => s.par_dt_alteracao >= data || s.par_dt_cadastro >= data));
             return output;
           

         }

         [TestMethod, Description("SyncServidorTerminaConvenioFinalizadoraSub")]
         public static String TestSyncServidorTerminalConvenioFinalizadoraSub(DateTime data)
         {
             Itbr_convenio_finalizadora_subRepository ConFinRep = new tbr_convenio_finalizadora_subRepository();
             string output = JsonConvert.SerializeObject(ConFinRep.Find(s => s.cfinaliza_dt_alteracao >= data || s.cfinaliza_dt_cadastro >= data));
             return output;
         }

         [TestMethod, Description("SyncServidorTerminaParametroDescProdUneg")]
         public static  String TestSyncServidorTerminalParametroDescProdUneg()
         {
             Itbr_parametro_descprod_unegRepository ParDesUneRep = new tbr_parametro_descprod_unegRepository();
             string output = JsonConvert.SerializeObject(ParDesUneRep.GetAll());
             return output;
            
         }

         [TestMethod, Description("SyncServidorTerminaParametroDescVendUneg")]
         public static String TestSyncServidorTerminalParametroDescVendUneg()
         {
             Itbr_parametro_descvend_unegRepository ParDesVenRep = new tbr_parametro_descvend_unegRepository();
             string output = JsonConvert.SerializeObject(ParDesVenRep.GetAll());
             return output;
             

         }

         [TestMethod, Description("SyncServidorTerminaEntregaEndereco")]
         public static  String TestSyncServidorTerminalEntregaEndereco(DateTime data)
         {
             Itb_entrega_enderecoRepository EntEndRep = new tb_entrega_enderecoRepository();
             string output = JsonConvert.SerializeObject(EntEndRep.Find(s => s.end_dt_alteracao >= data || s.end_dt_cadastro >= data));
             return output;

         }

         [TestMethod, Description("SyncServidorTerminaFinalizadoraUn")]
         public static String TestSyncServidorTerminalFinalizadoraUn(DateTime data)
         {
             Itbr_finalizadora_unRepository FinUnRep = new tbr_finalizadora_unRepository();
             string output = JsonConvert.SerializeObject(FinUnRep.Find(s => s.finalun_dt_alteracao >= data || s.finalun_dt_cadastro >= data));
             return output;
         }

         [TestMethod, Description("SyncServidorTerminaFinalizadoraSubUn")]
         public static String TestSyncServidorTerminalFinalizadoraSubUn(DateTime data)
         {
             Itbr_finalizadora_sub_unRepository FinSubUnRep = new tbr_finalizadora_sub_unRepository();
             string output = JsonConvert.SerializeObject(FinSubUnRep.Find(s => s.finsubun_dt_alteracao >= data || s.finsubun_dt_cadastro >= data));
             return output;
             

         }

         [TestMethod, Description("SyncServidorTerminaParametroDescVend")]
         public static String TestSyncServidorTerminalParametroDescVend(DateTime data)
         {
             Itb_parametro_descvendRepository ParDescVenRep = new tb_parametro_descvendRepository();
             string output = JsonConvert.SerializeObject(ParDescVenRep.GetAll());
             return output;
             

         }

        #endregion
         
         #region SYNC TERMINAL SERVIDOR
         [TestMethod, Description("Pega a data de ultima importação Servidor Web")]
         public static String  TestSyncTerminalServidorDataDeimport()
         {
             Itb_terminalRepository TermResp = new tb_terminalRepository();
           
             try
             {


                tb_terminal gg = new tb_terminal();
                gg = TermResp.First(s => s.te_servidor_loja == true);
                string output = gg.te_data_ult_imp_srv_web.ToString();
                //JsonConvert.SerializeObject(gg);

                return output;
                
                 
             }

             catch
             {

                return "Não Ha um Servidor.";
             }

         }

         [TestMethod, Description("SyncTerminalServidorDanfe")]
         public static String TestSyncTerminalServidorDanfe(string obj)
         {
             Itb_nfe_danfeRepository CrmResp = new tb_nfe_danfeRepository();
              try 
	          {
                  List<tb_nfe_danfe> lista = new List<tb_nfe_danfe>(JsonConvert.DeserializeObject<List<tb_nfe_danfe>>(obj));
                  CrmResp.AddAllList(lista, false);
               
               return "true";
	           }

	        catch
	        {

                return "false";
	        }

         }

         [TestMethod, Description("SyncTerminalServidorCrmEndereco")]
         public static String TestSyncTerminalServidorCrmEndereco(string obj)
         {
             Itb_crm_enderecoRepository CrmResp = new tb_crm_enderecoRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_crm_endereco>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorCliente")]
         public static String TestSyncTerminalServidorCliente(string obj)
         {
             Itb_clienteRepository CrmResp = new tb_clienteRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_cliente>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorClienteEndereco")]
         public static String TestSyncTerminalServidorClienteEndereco(string obj)
         {
             Itb_cliente_enderecoRepository CrmResp = new tb_cliente_enderecoRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_cliente_endereco>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorClienteTelefone")]
         public static String TestSyncTerminalServidorClienteTelefone(string obj)
         {
             Itb_cliente_telefoneRepository CrmResp = new tb_cliente_telefoneRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_cliente_telefone>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorClienteAnvisa")]
         public static String TestSyncTerminalServidorClienteAnvisa(string obj)
         {
             Itb_cliente_anvisaRepository CrmResp = new tb_cliente_anvisaRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_cliente_anvisa>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorClienteFiscal")]
         public static String TestSyncTerminalServidorClienteFiscal(string obj)
         {
             Itb_cliente_fiscalRepository CrmResp = new tb_cliente_fiscalRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_cliente_fiscal>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorPacienteAnvisa")]
         public static String TestSyncTerminalServidorPacienteAnvisa(string obj)
         {
             Itb_paciente_anvisaRepository CrmResp = new tb_paciente_anvisaRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_paciente_anvisa>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorCrediario")]
         public static String TestSyncTerminalServidorCrediario(string obj)
         {
             Itb_crediarioRepository CrmResp = new tb_crediarioRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_crediario>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorCrediarioFinalizadora")]
         public static String TestSyncTerminalServidorCrediarioFinalizadora(string obj)
         {
             Itb_crediario_finalizadoraRepository CrmResp = new tb_crediario_finalizadoraRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_crediario_finalizadora>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorEcf")]
         public static String TestSyncTerminalServidorEcf(string obj)
         {
             Itb_ecfRepository CrmResp = new tb_ecfRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_ecf>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorEcfDd")]
         public static String TestSyncTerminalServidorEcfDd(string obj)
         {
             Itb_ecf_ddRepository CrmResp = new tb_ecf_ddRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_ecf_dd>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorReducaoZ")]
         public static String TestSyncTerminalServidorReducaoZ(string obj)
         {
             Itb_reducao_zRepository CrmResp = new tb_reducao_zRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_reducao_z>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorReducaoZItens")]
         public static String TestSyncTerminalServidorReducaoZItens(string obj)
         {
             Itb_reducao_z_itensRepository CrmResp = new tb_reducao_z_itensRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_reducao_z_itens>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorRecarga")]
         public static String TestSyncTerminalServidorRecarga(string obj)
         {
             Itb_recargaRepository CrmResp = new tb_recargaRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_recarga>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorRecargaFinalizadora")]
         public static String TestSyncTerminalServidorRecargaFinalizadora(string obj)
         {
             Itb_recarga_finalizadoraRepository CrmResp = new tb_recarga_finalizadoraRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_recarga_finalizadora>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorPrivateLabel")]
         public static String TestSyncTerminalServidorPrivateLabel(string obj)
         {
             Itb_privatelabelRepository CrmResp = new tb_privatelabelRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_privatelabel>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorPrivateLabelFinalizadora")]
         public static String TestSyncTerminalServidorPrivateLabelFinalizadora(string obj)
         {
             Itb_privatelabel_finalizadoraRepository CrmResp = new tb_privatelabel_finalizadoraRepository();
             try
             {

                 CrmResp.AddAllList(JsonConvert.DeserializeObject<List<tb_privatelabel_finalizadora>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorCheckin")]
         public static String TestSyncTerminalServidorCheckin(string obj)
         {
             Itb_checkinRepository Resp = new tb_checkinRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_checkin>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorCheckinItem")]
         public static String TestSyncTerminalServidorCheckinItem(string obj)
         {
             Itb_checkin_itemRepository Resp = new tb_checkin_itemRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_checkin_item>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorCheckout")]
         public static String TestSyncTerminalServidorCheckout(string obj)
         {
             Itb_checkoutRepository Resp = new tb_checkoutRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_checkout>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorCheckoutItem")]
         public static String TestSyncTerminalServidorCheckoutItem(string obj)
         {
             Itb_checkout_itemRepository Resp = new tb_checkout_itemRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_checkout_item>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }
         [TestMethod, Description("SyncServidorTerminalAberturaCaixa")]
         public static String TestSyncServidorTerminalAberturaCaixa()
         {
             Itb_abertura_caixaRepository AbeCaiResp = new tb_abertura_caixaRepository();
             try
             {
                 string output = JsonConvert.SerializeObject(AbeCaiResp.GetAll());
                 return output;
                

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorAberturaCaixa")]
         public static String TestSyncTerminalServidorAberturaCaixa(string obj)
         {
             Itb_abertura_caixaRepository Resp = new tb_abertura_caixaRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_abertura_caixa>>(obj), false); 

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorAgendaProduto")]
         public static String TestSyncTerminalServidorAgendaProduto(string obj)
         {
             Itb_agenda_produtoRepository Resp = new tb_agenda_produtoRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_agenda_produto>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorLanctoFinanceiro")]
         public static String TestSyncTerminalServidorLanctoFinanceiro(string obj)
         {
             Itb_lancto_financeiroRepository Resp = new tb_lancto_financeiroRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_lancto_financeiro>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorNfe")]
         public static String TestSyncTerminalServidorNfe(string obj)
         {
             Itb_nfeRepository Resp = new tb_nfeRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_nfe>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }
        //TALIGADO
         [TestMethod, Description("SyncTerminalServidorNfeCfop")]
         public static String TestSyncTerminalServidorNfeCfop(string obj)
         {
             Itb_nfe_cfopRepository Resp = new tb_nfe_cfopRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_nfe_cfop>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorNfeDanfe")]
         public static String TestSyncTerminalServidorNfeDanfe(string obj)
         {
             Itb_nfe_danfeRepository Resp = new tb_nfe_danfeRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_nfe_danfe>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorNfeFinalizadora")]
         public static String TestSyncTerminalServidorNfeFinalizadora(string obj)
         {
             Itb_nfe_finalizadoraRepository Resp = new tb_nfe_finalizadoraRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_nfe_finalizadora>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorNfeItem")]
         public static String TestSyncTerminalServidorNfeItem(string obj)
         {
             Itb_nfe_itemRepository Resp = new tb_nfe_itemRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_nfe_item>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorPonto")]
         public static String TestSyncTerminalServidorPonto(string obj)
         {
             Itb_pontoRepository Resp = new tb_pontoRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_ponto>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorSangria")]
         public static String TestSyncTerminalServidorSangria(string obj)
         {
             Itb_sangriasRepository Resp = new tb_sangriasRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_sangrias>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorSuprimento")]
         public static String TestSyncTerminalServidorSuprimento(string obj)
         {
             Itb_suprimentosRepository Resp = new tb_suprimentosRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_suprimentos>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorVenda")]
         public static  String TestSyncTerminalServidorVenda(string obj)
         {
             Itb_vendaRepository Resp = new tb_vendaRepository();
             try
             {


                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_venda>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorVendaItem")]
         public static String TestSyncTerminalServidorVendaItem(string obj)
         {
             Itb_venda_itemRepository  Resp = new tb_venda_itemRepository();
             try
             {

                 Resp.AddAllList(JsonConvert.DeserializeObject<List<tb_venda_item>>(obj), false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }

         [TestMethod, Description("SyncTerminalServidorVendaPagamento")]
         public static String TestSyncTerminalServidorVendaPagamento(string obj)
         {
             Itb_venda_pagamentoRepository Resp = new tb_venda_pagamentoRepository();
             try
             {
                 List<tb_venda_pagamento> objeto = JsonConvert.DeserializeObject<List<tb_venda_pagamento>>(obj);

                 Resp.AddAllList(objeto, false);

                 return "true";
             }

             catch
             {

                 return "false";
             }

         }
         
         #endregion
         
         #region SERVIÇOS DE INSTALAÇÃO

         [TestMethod, Description("Identifica Terminal")]
         public static String IdentificaTerminal(string SerieHD)
         {
             Itb_terminalRepository TermRep = new tb_terminalRepository();
             Itb_ecfRepository TermRep2 = new tb_ecfRepository();
             TermRep2.GetAll().Count();
             string output = JsonConvert.SerializeObject(TermRep.Find(s => s.te_serie_hd.Equals(SerieHD)));
             return output; 
            
         }
         [TestMethod, Description("Identifica ECF")]
         public static String IdentificaEcf(string ecfm_id_marca, string ecfm_id_versao, string ecfm_id_modelo)
         {
             Itb_ecfRepository EcfRep = new tb_ecfRepository();
             string output = JsonConvert.SerializeObject(EcfRep.Find(s => s.ecfm_id_marca.Equals(ecfm_id_marca) && s.ecfm_id_versao.Equals(ecfm_id_versao) && s.ecfm_id_modelo.Equals(ecfm_id_modelo)));
             return output;

         }
         [TestMethod, Description("Identifica Finalizadoras")]
         public static String IdentificaFinalizadoras(string ecf_numero_serie)
         {
             Itbr_ecf_finalizadoraRepository EcfFinRep = new tbr_ecf_finalizadoraRepository();
             string output = JsonConvert.SerializeObject(EcfFinRep.Find(s => s.ecf_numero_serie.Equals(ecf_numero_serie)));
             return output;

         }
         [TestMethod, Description("Insere Terminal no Servidor")]
         public static bool IserirTerminal(string terminal)
         {
            

             Itb_terminalRepository TermRep = new tb_terminalRepository();
           
            try
             {
                
                 TermRep.BulkUpSertList(JsonConvert.DeserializeObject<List<tb_terminal>>(terminal));
                 return true;

             }
             catch
             {
                 return false;
             }

         }

         [TestMethod, Description("ContaMaquina")]
         public static string ContaMaquina()
         {
             Itb_terminalRepository terRep = new tb_terminalRepository();
             int retorno = 0;
             foreach (var item in terRep.GetAll())
             {
                 retorno++;
             }
             return retorno.ToString();
         }
        
        
        
        

        
        #endregion
         
         #region METODOS PREVENDA

         [TestMethod, Description("InsereVenda")]
         public static void InsereVenda(tb_venda_prevenda pre, tb_venda_prevenda_pgto PrePgto)
         {
             Itb_vendaRepository VendaRep = new tb_vendaRepository();
             Itb_venda_itemRepository VendaItemResp = new tb_venda_itemRepository();
             Itb_venda_prevenda_itemRepository PreVendaItem = new tb_venda_prevenda_itemRepository();
             var outpt = JsonConvert.SerializeObject(PreVendaItem.Find(s => s.uneg_id.Equals(pre.uneg_id) && s.venda_id.Equals(pre.venda_id) && s.venda_pdv.Equals(pre.venda_pdv) && s.vendaPv_id.Equals(pre.vendaPv_id)));
             var VendaItem = JsonConvert.DeserializeObject<List<tb_venda_prevenda_item>>(outpt);
             #region INSERE VENDA
             tb_venda venda = new tb_venda()
             {
                 venda_id = Convert.ToInt32(pre.venda_id),
                 uneg_id = pre.uneg_id,
                 venda_pdv = pre.venda_pdv,
                 venda_data = DateTime.Now,
                 ecf_numero_serie = "1",
                 ecf_numero_ecf = 1,
                 venda_vendedor_id = pre.vendaPv_vendedor_id,
                 venda_prevenda_pdv = pre.venda_pdv,
                 venda_tot_quant = pre.vendaPv_valorTotal,
               
                 venda_tot_preco = pre.vendaPv_valorTotal,
                 venda_status = "FN"
             };
             #endregion
             VendaRep.Add(venda);

             foreach (var item in VendaItem)
             {
                 tb_venda_item ItemVenda = new tb_venda_item()
                 {
                     uneg_id = item.uneg_id,
                     venda_id = Convert.ToInt32(item.venda_id),
                     venda_pdv = item.venda_pdv,
                     venda_data = item.vendaPv_data_preVenda,
                     vitem_id = (VendaItemResp.GetAll().Sum(s => s.vitem_id) + 1),
                     vitem_sequencia_impressora = (VendaItemResp.GetAll().Sum(s => s.vitem_sequencia_impressora) + 1),
                     vitem_descricao = item.vendaPv_item_descricao,
                     vitem_qtde = item.vendaPv_item_quantidade,
                     vitem_preco = item.vendaPv_item_preco,
                     vitem_preco_padrao = item.vendaPv_item_preco,
                     vitem_tot_preco_praticado = item.vendaPv_item_preco,
                     vitem_tot_preco_real = item.vendaPv_item_preco,
                     vitem_tot_preco_Reembolso = item.vendaPv_item_preco,
                     vitem_vendedor_id = item.vendaPv_item_vendedor_id,
                     vitem_ean_pistolado = Convert.ToDecimal(item.vendaPv_item_ean13),
                     vitem_sit_trib = "f1",
                     vitem_situacao = "AT",
                     pro_id = item.pro_id,
                 };
                 VendaItemResp.Add(ItemVenda);

             }
             VendaPagamento(pre, PrePgto);
         }

         [TestMethod, Description("VendaPagamento")]
         public static void VendaPagamento(tb_venda_prevenda pre, tb_venda_prevenda_pgto PrePgto)
         {
             Itb_venda_pagamentoRepository pagVendResp = new tb_venda_pagamentoRepository();
             tb_venda_pagamento pgto = new tb_venda_pagamento()
             {
                 uneg_id = pre.uneg_id,
                 venda_id = Convert.ToInt32(pre.venda_id),
                 venda_pdv = pre.venda_pdv,
                 venda_data = pre.vendaPv_data_preVenda,
                 vpag_id = 3,
                 finsub_id = 3,
                 final_id = 3,
                 vpag_valor = Convert.ToDecimal(pre.vendaPv_valorTotal),
                 vpag_vendatef = true,
                 vpag_status = "PE",
                 vpag_valor_compra_saque = Convert.ToDecimal(pre.vendaPv_valorTotal),
                 vpag_tef_nsu_venda = PrePgto.vpag_tef_nsu_venda,
                 vpag_tef_nsu_host = PrePgto.vpag_tef_nsu_host,
                 vpag_comprovante_cliente = PrePgto.vpag_comprovante_cliente,
                 vpag_comprovante_loja = PrePgto.vpag_comprovante_loja,
             };

             pagVendResp.Add(pgto);

         }

         [TestMethod, Description("PRE VENDA")]
         public void InserirPrevenda()
         {
             Itb_venda_prevendaRepository preVenResp = new tb_venda_prevendaRepository();
             int count = (preVenResp.GetAll().Count() + 1);
             #region PREVENDA
             try
             {
                 tb_venda_prevenda preVenda = new tb_venda_prevenda()
                 {
                     venda_id = 1,
                     venda_data = DateTime.Now,
                     vendaPv_data_preVenda = DateTime.Now,
                     venda_pdv = 1,
                     vendaPv_num_preVenda = "060649",
                     vendaPv_num_comanda = "0000000000",
                     vendaPv_valorTotal = 5,
                     vendaPv_valorTroco = 0,
                     vendaPv_paf_numero = "000000000",
                     vendaPv_vendedor_id = 8888,
                     vendaPv_status = "FN",
                     vendaPv_tip_faturamento = "CF",
                     uneg_id = 1,
                     vendaPv_situacao = "PE",
                     cnv_id = null,
                     cli_id = null,
                     end_telefone = null
                 };
             #endregion

                 preVenResp.Add(preVenda);

             }
             catch (Exception Exce)
             {
                 throw Exce;
             }

         }

         public IList<dynamic> resumoPreVenda()
         {
             IList<dynamic> lista = new List<dynamic>();
             Itb_venda_prevenda_itemRepository PreVendaItem = new tb_venda_prevenda_itemRepository();
             Itb_venda_prevendaRepository Prevenda = new tb_venda_prevendaRepository();
             var query = from employee in Prevenda.GetAll()
                         join student in PreVendaItem.GetAll()
                         on new { employee.vendaPv_id, employee.venda_id, employee.venda_pdv }
                         equals new { student.vendaPv_id, student.venda_id, student.venda_pdv }
                         select new { tb_venda_prevenda = employee, tb_venda_prevenda_item = student };

             foreach (var item in query)
             {
                 lista.Add(item);
             }
             return lista.ToList();

         }

         [TestMethod, Description("SyncMobile")]
         public static String SyncMobile(DateTime data)
         {
             var context = new db_lojaEntities2();
             ObjectResult<Mobile_Result> orderDetailEnumerable = context.Mobile(data, 63);
             List<Mobile_Result> details = orderDetailEnumerable.ToList();
             var output = JsonConvert.SerializeObject(details);
             return output;
         }

         [TestMethod, Description("SyncMobilePag")]
         public void PrevendaPagamento()
         {
             StreamReader ler = new StreamReader("C:/Teste/issoai.txt");


             string PreVendaPgto = ler.ReadToEnd();

             string[] DadosColetados = PreVendaPgto.Split('|');
             Itb_venda_prevenda_pgtoRepository PreVendaPgtResp = new tb_venda_prevenda_pgtoRepository();
             Itb_venda_prevendaRepository preVenResp = new tb_venda_prevendaRepository();
             tb_venda_prevenda Pre = new tb_venda_prevenda();

             var outpt = JsonConvert.SerializeObject(preVenResp.Find(s => s.vendaPv_num_preVenda.Equals(DadosColetados[1])));
             Pre = JsonConvert.DeserializeObject<List<tb_venda_prevenda>>(outpt)[0];

             #region POPULAR PAGAMENTO
             tb_venda_prevenda_pgto pgt = new tb_venda_prevenda_pgto()
             {
                 vendaPv_id = Pre.vendaPv_id,
                 vendaPv_data_preVenda = Pre.vendaPv_data_preVenda,
                 uneg_id = Pre.uneg_id,
                 venda_pdv = Pre.venda_pdv,

                 final_id = 3,
                 subfin_id = 3,
                 vpag_num_referencia = null,
                 vpag_valor = Convert.ToDecimal(DadosColetados[9]),
                 vpag_troco = Convert.ToInt32(DadosColetados[10]),
                 vpag_vendatef = true,
                 vpag_valor_compra_saque = Convert.ToDecimal(DadosColetados[12]),
                 vpag_tef_nsu_venda = DadosColetados[13],
                 vpag_tef_nsu_host = DadosColetados[14],
                 //vpag_tipo_cartao = DadosColetados[15],
                 vpag_comprovante_cliente = DadosColetados[16],
                 vpag_comprovante_loja = DadosColetados[17],
                 vpag_status = "FN",
                 vpag_cli_data_ch = DateTime.Now,
                 vpag_cli_banco_id_ch = null,
                 vpag_cli_agencia_ch = null,
                 vpag_cli_c1_ch = null,
                 vpag_cli_conta_corrente_ch = null,
                 vpag_cli_c2_ch = null,
                 vpag_cli_numero_ch = null,
                 vpag_cli_c3_ch = null,
                 vpag_cli_doc_troca = null,
                 prazo_id = null,
                 cli_id = null

             };
             #endregion

             try
             {
                 PreVendaPgtResp.Add(pgt);
                 InsereVenda(Pre, pgt);
             }
             catch (Exception erro)
             {

                 throw erro;
             }




         }

         [TestMethod, Description("TESTE")]
         public void OLHAAA()
         {
             #region LISTA LOCAL
             Itb_venda_prevenda_itemRepository PreVendaItem = new tb_venda_prevenda_itemRepository();
             Itb_venda_prevendaRepository Prevenda = new tb_venda_prevendaRepository();
             var query = from employee in Prevenda.GetAll()
                         join student in PreVendaItem.GetAll()
                         on new { employee.vendaPv_id, employee.venda_id, employee.venda_pdv }
                         equals new { student.vendaPv_id, student.venda_id, student.venda_pdv }
                         select new { tb_venda_prevenda = employee, tb_venda_prevenda_item = student };
             foreach (var item in query)
             {
                 string ter = item.tb_venda_prevenda.vendaPv_num_preVenda;
                 string ter2 = item.tb_venda_prevenda_item.vendaPv_item_descricao;
             }
             #endregion

         
         }
        
         [TestMethod, Description("PRE VENDA ITEM")]
         public void InserirPrevendaItem()
         {
             Itb_venda_prevenda_itemRepository preVenItemResp = new tb_venda_prevenda_itemRepository();
            
            
             #region PREVENDA ITEM
             tb_venda_prevenda_item preVenda = new tb_venda_prevenda_item()
             {
                 uneg_id = 1,
                 vendaPv_item_id = 1,
                 vendaPv_data_preVenda = Convert.ToDateTime("2016-03-11 14:04:59.033"),
                 vendaPv_id = 1,
                 venda_pdv = 1,
                 vendaPv_item_autorizacao = null,
                 vendaPv_item_codigo = 1111,
                 //vendaPv_item_cpfCnpj,
                 vendaPv_item_descricao = "TESTE ASA",
                 vendaPv_item_ean13 = "54545454545",
                 vendaPv_item_preco = 5,
                 //vendaPv_item_precoReembolso,
                 vendaPv_item_precoVista = 5,
                 vendaPv_item_quantidade = 1,
                 vendaPv_item_totalValor = 5,
                 vendaPv_item_valorDesconto = 0,
                 vendaPv_item_vendedor_id = 8888,
                 vendaPv_item_status = "FN",
                 vendaPv_item_vidaLink = null,
                 vendaPv_item_receita_data = null,
                 vendaPv_item_receita_notificacao_num = null,
                 vendaPv_item_receita_notificacao_tipo = null,
                 vendaPv_item_comprador_oexped = null,
                 vendaPv_item_lote_numero = null,
                 vendaPv_item_fpop_qtde_Diaria = null,
                 vendaPv_item_fpop_qtde_Unitaria = null,
                 //vendaPv_item_precoPadrao = 5,
                 vendaPv_item_precoPraticado = 5,
                 //vendaPv_item_precoReal = 5,
                 //crm_id,
                 //vendaPv_item_comprador_doc,
                 //vendaPv_item_agenda_marca_puc,
                 //vendaPv_item_paciente_doc   


             };
             #endregion
             
             try
             {
                 preVenItemResp.Add(preVenda);
                
             }
             catch(Exception erro)
             {
                 throw erro;
             }


         }

         #endregion



    }


    public class ADICIONA<T>: IRepository<T> where T : class
    {
        public static bool AdicionaPorFora(List<T> details,string tabela,bool deletaData)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=localhost\SQLEXPRESS;" +
                "Initial Catalog=db_loja;" +
                "User id=sa;" +
                "Password=VQXsSf7Z1NKV.qXGZsX7Z1Be.;";
                BULK.TESTE.staticfunc<T>(conn.ConnectionString, tabela, details, deletaData);
                return true;
            }
            catch
            {
                return false;

            }


        }


        public IQueryable<T> GetQuery()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Func<T, bool> where)
        {
            throw new NotImplementedException();
        }

        public T Single(Func<T, bool> where)
        {
            throw new NotImplementedException();
        }

        public T First(Func<T, bool> where)
        {
            throw new NotImplementedException();
        }

        public void AddAllList(IList<T> lis, bool deleteData)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges(SaveOptions saveOptions)
        {
            throw new NotImplementedException();
        }

        public void BulkUpSertList(List<T> list)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public void Limpar(string tabela)
        {
            throw new NotImplementedException();
        }
    }
}
