using ASArquiteruraData;
using ASArquiteruraData.Repository;
using ASArquiteruraData.RepositoryInterfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ArquiteturaTesteASA;

namespace ClienteWebServiceASA
{
    public partial class Form1 : Form
    {
       // ServiceReference1.Service1SoapClient sicronia = new ServiceReference1.Service1SoapClient();
        Itb_produtoRepository prodresp = new tb_produtoRepository();
        DateTime data = Convert.ToDateTime("2010-01-01");
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }
     

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.Itb_clienteServiceClient cliente = new ServiceReference1.Itb_clienteServiceClient();

           // var yt = cliente.GetAll();

            tb_cliente cli = new tb_cliente();
            cli.cli_nome = "HENRIQUE223";

            List<tb_cliente> sltcli = new List<tb_cliente>();
            sltcli.Add(cli);
           // tb_cliente[] re;
            cliente.AddBulk(sltcli.ToArray(), true);

            cliente.Close();

        }
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
        private void button1_Click(object sender, EventArgs e)
        {
           caipaDento();
        }

        public void caipaDento()
        {
            label1.Text = (count = count + 1).ToString();
            Itb_promocaoRepository prot = new tb_promocaoRepository();

            try
            {
                prot.Limpar("tb_promocao");

                prot.AddAllList(JsonConvert.DeserializeObject<List<tb_promocao>>(Resp("SyncServidorTerminalPromocao", "?data=2016-01-01 16:37:32")), true);

                Itbr_promocao_produtoRepository PromProRep = new tbr_promocao_produtoRepository();

                PromProRep.AddAllList(JsonConvert.DeserializeObject<List<tbr_promocao_produto>>(Resp("SyncServidorTerminalPromocaoProduto", "?data=2016-01-01 16:37:32")), true);

                ArquiteturaTesteASA.ADICIONA<SPtbr_promocao_uneg_Result>.AdicionaPorFora(JsonConvert.DeserializeObject<List<SPtbr_promocao_uneg_Result>>(Resp("SyncServidorTerminalPromocaoUneg", "?data=2016-01-01 16:37:32")), "tbr_promocao_uneg",true);

                ArquiteturaTesteASA.ADICIONA<tbr_promocao_convenio_Result>.AdicionaPorFora(JsonConvert.DeserializeObject<List<tbr_promocao_convenio_Result>>(Resp("SyncServidorTerminalPromocaoConvenio", "?data=2016-01-01 16:37:32")), "tbr_promocao_convenio",true);

               // MessageBox.Show("TA LIGADO");
               
            }
            catch (Exception)
            {

                MessageBox.Show("DEU RUIM!!");
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            caipaDento();
        }
    }
}
