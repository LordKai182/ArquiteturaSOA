using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ASArquiteruraData;
using ASArquiteruraData.DataContextInterface;
using ASArquiteruraData.DataContext;
using ASArquiteruraData.RepositoryInterfaces;
using ASArquiteruraData.Repository;
using System.Web.Script.Services;
using Newtonsoft.Json;
using System.Data.Objects;
using System.IO;

namespace WebServiceASA
{
    /// <summary>
    /// Summary description for MobileService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MobileService : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public bool CadastraTerminal(string te_mobile_mac)
        {
            Itb_terminal_mobileRepository termMobResp = new tb_terminal_mobileRepository();
            tb_terminal_mobile te = new tb_terminal_mobile()
            {   
                te_mobile_id =  (termMobResp.GetAll().Count() + 1),
                te_mobile_mac = te_mobile_mac
            };
            try
            {
                termMobResp.Add(te);
                return true;

            }
            catch (Exception)
            {

                return false;
            }



        }


        [ScriptMethod(UseHttpGet = true)]
        [WebMethod(Description = "Cadastro de Terminais Mobile no Servidor")]
        public string HelloWorld(string te_mobile_mac)
        {
            #region IDMOBILE
            tb_terminal_mobile teMob = new tb_terminal_mobile();
            Itb_terminal_mobileRepository terMob = new tb_terminal_mobileRepository();

            #endregion
           
            Itb_unid_negocioRepository unegResp = new tb_unid_negocioRepository();
            tb_unid_negocio uneg = new tb_unid_negocio();
           
            if (LogarMobile(te_mobile_mac))
            {
                var retornoMobile = JsonConvert.SerializeObject(terMob.Find(s => s.te_mobile_mac.Equals(te_mobile_mac)));
                teMob = JsonConvert.DeserializeObject<List<tb_terminal_mobile>>(retornoMobile)[0];
                var retorno = JsonConvert.SerializeObject(unegResp.Find(s => s.uneg_id.Equals(1)));
                uneg = JsonConvert.DeserializeObject<List<tb_unid_negocio>>(retorno)[0];
                return "|" + uneg.uneg_nome + "|" + uneg.uneg_cnpj + "|" + teMob.te_mobile_id+"|"+uneg.uneg_tef_idLoja+"|"+uneg.uneg_tef_IP;
            }
            else
            {
                try
                {
                    CadastraTerminal(te_mobile_mac);

                    var retornoMobile = JsonConvert.SerializeObject(terMob.Find(s => s.te_mobile_mac.Equals(te_mobile_mac)));
                    teMob = JsonConvert.DeserializeObject<List<tb_terminal_mobile>>(retornoMobile)[0];
                    var retorno = JsonConvert.SerializeObject(unegResp.Find(s => s.uneg_id.Equals(1)));
                    uneg = JsonConvert.DeserializeObject<List<tb_unid_negocio>>(retorno)[0];
                    return "|" + uneg.uneg_nome + "|" + uneg.uneg_cnpj + "|" + teMob.te_mobile_id + "|" + uneg.uneg_tef_idLoja + "|" + uneg.uneg_tef_IP;
                }
                catch
                {

                    return "Terminal mobile nao cadastrado.";
                }


            }
            }

        [WebMethod(Description = "Sincronia de Produtos do Servidor com o Terminal Mobile")]
        [ScriptMethod(UseHttpGet = true)]
        public String SyncMobile(DateTime data)
        {

            return ArquiteturaTesteASA.UnitTest1.SyncMobile(data);
        }

        [WebMethod(Description = " Insere PrevendaItens")]
        [ScriptMethod(UseHttpGet = true)]
        public bool InserirPrevendaItem(
        int venda_pdv, 
        string vendaPv_num_preVenda,
        int vendaPv_vendedor_id, 
        int vendaPv_item_codigo, 
        string vendaPv_item_descricao, 
        string vendaPv_item_ean13,
        string vendaPv_item_preco,
        int vendaPv_item_quantidade,
        string vendaPv_item_totalValor
            )
        {
            Itb_venda_prevenda_itemRepository preVenItemResp = new tb_venda_prevenda_itemRepository();
            Itb_venda_prevendaRepository preVenResp = new tb_venda_prevendaRepository();
   
            tb_venda_prevenda Pre = new tb_venda_prevenda();
            try
            {
                var outpt = JsonConvert.SerializeObject(preVenResp.Find(s => s.vendaPv_num_preVenda.Equals(vendaPv_num_preVenda)));
                Pre = JsonConvert.DeserializeObject<List<tb_venda_prevenda>>(outpt)[0];
               
            
            }
            catch (Exception)
            {

                return false;
            }
          
            
            int count = (preVenItemResp.GetAll().Count() + 1);
            #region PREVENDA ITEM
            tb_venda_prevenda_item preVenda = new tb_venda_prevenda_item()
            { 
                uneg_id = 1,
                vendaPv_item_id = count,
                vendaPv_data_preVenda = Pre.vendaPv_data_preVenda,
                vendaPv_id = Pre.vendaPv_id,
                venda_id = Pre.venda_id,
                venda_pdv = Pre.venda_pdv,
                vendaPv_item_codigo = vendaPv_item_codigo,
                vendaPv_item_descricao = vendaPv_item_descricao,
                vendaPv_item_ean13 = vendaPv_item_ean13,
                vendaPv_item_preco = Convert.ToDecimal(vendaPv_item_preco),
                vendaPv_item_precoVista = Convert.ToDecimal(vendaPv_item_preco),
                vendaPv_item_quantidade = vendaPv_item_quantidade,
                vendaPv_item_totalValor = Convert.ToDecimal(vendaPv_item_totalValor),
                vendaPv_item_precoPadrao = Convert.ToDecimal(vendaPv_item_preco),
                vendaPv_item_vendedor_id = Pre.vendaPv_id,
                vendaPv_item_status = "FN",
            
                vendaPv_item_precoPraticado = Convert.ToDecimal(vendaPv_item_preco)
              
            };
            #endregion
            try
            {
                preVenItemResp.Add(preVenda);
                return true;
            }
            catch
            {
                return false;
            }

        }

        [WebMethod(Description = " Insere PrevendaPagamento")]
        [ScriptMethod(UseHttpGet = true)]
        public bool PrevendaPagamento(string PreVendaPgto)
        {
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
                //vpag_id = 3,
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
                Pre.vendaPv_status = "EA";
                preVenResp.Update(Pre);
                ArquiteturaTesteASA.UnitTest1.InsereVenda(Pre,pgt);
                return true;
            }
            catch (Exception erro)
            {

                throw erro;
                return false;
            }

        }


  

        [WebMethod(Description = " Insere Prevenda")]
        [ScriptMethod(UseHttpGet = true)]
        public bool InserirPrevenda(int venda_pdv,string vendaPv_valorTotal,string vendaPv_num_preVenda, decimal vendaPv_valorTroco, int vendaPv_vendedor_id)
        {   Itb_venda_prevendaRepository preVenResp = new tb_venda_prevendaRepository();
            int count = (preVenResp.GetAll().Count() + 1);
        
            #region PREVENDA
         tb_venda_prevenda preVenda = new tb_venda_prevenda()
            {   vendaPv_id = count,
                venda_id = count,
                venda_data = DateTime.Now,
                vendaPv_data_preVenda = DateTime.Now,
                venda_pdv = venda_pdv,
                vendaPv_num_preVenda = vendaPv_num_preVenda,
                vendaPv_num_comanda = "0000000000",
                vendaPv_valorTotal =Convert.ToDecimal(vendaPv_valorTotal),
                vendaPv_valorTroco = vendaPv_valorTroco,
                vendaPv_paf_numero = "000000000",
                vendaPv_vendedor_id = vendaPv_vendedor_id,
                vendaPv_status = "FN",
                vendaPv_tip_faturamento =  "CF",
                uneg_id = 1,
                vendaPv_situacao = "PE",
                cnv_id = null,
                cli_id = null,
                end_telefone = null
             };
        #endregion
            try
            {
                preVenResp.Add(preVenda);
                return true;
            }
            catch 
            {
                return false;  
            }
            
        }

        [WebMethod(Description = " Log de Usuario em Terminais Mobile")]
        [ScriptMethod(UseHttpGet = true)]
        public String LogarUsuario(string usuario, string senha)
        {   

           
            Itb_usuarioRepository usuResp = new tb_usuarioRepository();
            string output = JsonConvert.SerializeObject(usuResp.Find( s => s.usr_senha_local.Equals(senha) && s.usr_cpf.Equals(usuario)));

            if (output == "[]")
                return "false";
            else
            {
             var user = JsonConvert.DeserializeObject<List<tb_usuario>>(output)[0];
                return user.usr_nome;
            }
        }

        public bool LogarMobile(string te_mobile_mac)
        {
            
            Itb_terminal_mobileRepository TerMob = new tb_terminal_mobileRepository();
             string output = JsonConvert.SerializeObject(TerMob.Find(s => s.te_mobile_mac.Equals(te_mobile_mac)));
            if(output != "[]")   
            return true;
            else
            return false;

        }

       

    }
}
