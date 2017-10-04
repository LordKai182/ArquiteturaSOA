using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_parametro
    {
        #region Primitive Properties
        public virtual Int32 par_loja { get; set; }

        public virtual Int32 par_pdv { get; set; }

        public virtual String par_msgRodape { get; set; }

        public virtual Int32 par_ponto_tempoSeguranca { get; set; }

        public virtual Int32 par_ponto_tempoAprovGerenteEntrada { get; set; }

        public virtual Int32 par_ponto_tempoAprovGerenteAlmoco { get; set; }

        public virtual Int32 par_ponto_tempoAprovGerenteVoltaAlmoco { get; set; }

        public virtual Int32 par_ponto_tempoAprovGerenteSaida { get; set; }

        public virtual Nullable<Int32> par_ponto_meridianoMinutos { get; set; }

        #endregion

    }
}
