using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_ecf_modelo")]
    public partial class tb_ecf_modeloDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 ecfm_id_marca { get; set; }
        [DataMember]
        public virtual Int32 ecfm_id_modelo { get; set; }
        [DataMember]
        public virtual Int32 ecfm_id_versao { get; set; }
        [DataMember]
        public virtual String ecfm_tipo_ecf { get; set; }
        [DataMember]
        public virtual String ecfm_desc_marca { get; set; }
        [DataMember]
        public virtual String ecfm_desc_modelo { get; set; }
        [DataMember]
        public virtual String ecfm_versao { get; set; }
        [DataMember]
        public virtual Int32 ecfm_qtd_lacre_sl { get; set; }
        [DataMember]
        public virtual Int32 ecfm_qtd_lacre_fab { get; set; }
        [DataMember]
        public virtual Boolean ecfm_mfd { get; set; }
        [DataMember]
        public virtual Boolean ecfm_lacre_mfd { get; set; }
        [DataMember]
        public virtual String ecfm_ato_aprovacao { get; set; }
        [DataMember]
        public virtual String ecfm_ato_registro { get; set; }
        [DataMember]
        public virtual String ecfm_formato_num_fabricacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ecfm_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ecfm_dt_alteracao { get; set; }
        [DataMember]
        public virtual String ecfm_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_ecfDto> tb_ecf;
        //public virtual ICollection<tb_ecf> tb_ecf
        //{
        //    get
        //    {
        //        if (_tb_ecf == null)
        //            _tb_ecf = new List<tb_ecf>();
        //        return _tb_ecf;
        //    }
        //    set { _tb_ecf = value; }
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

        #endregion
    }
}
