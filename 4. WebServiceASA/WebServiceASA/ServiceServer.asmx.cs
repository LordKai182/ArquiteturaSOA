using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebServiceASA
{
    /// <summary>
    /// Summary description for ServiceServer
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceServer : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

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

        #endregion
    }
}
