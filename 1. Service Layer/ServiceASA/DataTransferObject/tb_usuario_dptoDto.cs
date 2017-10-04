using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_usuario_dpto")]
    public partial class tb_usuario_dptoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 dpto_id { get; set; }
        [DataMember]
        public virtual String dpto_nome { get; set; }
        [DataMember]
        public virtual String dpto_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> dpto_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> dpto_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> dpto_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_planilha { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_checkin { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_entrada_nf { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_consulta_preco { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_alteracao_preco { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_vnd_balcao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_pdv { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_vnd_callcenter { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_supervisor_callcenter { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_etiquetas_loja { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_vnd_atacado { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_checkout_atacado { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_fat_atacado { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_etiquetas_atacado { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> dpto_apl_supervisor_atacado { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_usuarioDto> tb_usuario;
        //public virtual ICollection<tb_usuario> tb_usuario
        //{
        //    get
        //    {
        //        if (_tb_usuario == null)
        //            _tb_usuario = new List<tb_usuario>();
        //        return _tb_usuario;
        //    }
        //    set { _tb_usuario = value; }
        //}

        private IList<tbr_dpto_aplicativoDto> tbr_dpto_aplicativo;
        //public virtual ICollection<tbr_dpto_aplicativo> tbr_dpto_aplicativo
        //{
        //    get
        //    {
        //        if (_tbr_dpto_aplicativo == null)
        //            _tbr_dpto_aplicativo = new List<tbr_dpto_aplicativo>();
        //        return _tbr_dpto_aplicativo;
        //    }
        //    set { _tbr_dpto_aplicativo = value; }
        //}

        #endregion
    }
}
