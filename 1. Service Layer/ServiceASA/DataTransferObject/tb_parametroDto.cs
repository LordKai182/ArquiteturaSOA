using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_parametro")]
    public partial class tb_parametroDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 par_loja { get; set; }
        [DataMember]
        public virtual Int32 par_pdv { get; set; }
        [DataMember]
        public virtual String par_msgRodape { get; set; }
        [DataMember]
        public virtual Int32 par_ponto_tempoSeguranca { get; set; }
        [DataMember]
        public virtual Int32 par_ponto_tempoAprovGerenteEntrada { get; set; }
        [DataMember]
        public virtual Int32 par_ponto_tempoAprovGerenteAlmoco { get; set; }
        [DataMember]
        public virtual Int32 par_ponto_tempoAprovGerenteVoltaAlmoco { get; set; }
        [DataMember]
        public virtual Int32 par_ponto_tempoAprovGerenteSaida { get; set; }
        [DataMember]
        public virtual Nullable<Int32> par_ponto_meridianoMinutos { get; set; }

        #endregion

    }
}
