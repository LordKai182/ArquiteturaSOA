using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_usuario_funcao")]
    public partial class tb_usuario_funcaoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 funcao_id { get; set; }
        [DataMember]
        public virtual String funcao_descricao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_param_lj_ponto { get; set; }
        [DataMember]
        public virtual String funcao_situacao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_cancela_venda { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_cancela_vendaItem { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_desconto_vendaItem { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_desconto_venda { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_gerenciar_ponto { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_reiniciar_setup { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_menu_gerencial { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_fundo_caixa { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_sangria { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_despesa { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> funcao_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> funcao_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_vendaItem_semCodBarra { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> funcao_libera_lote { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_parametro_descvendDto> tb_parametro_descvend;
        //public virtual ICollection<tb_parametro_descvend> tb_parametro_descvend
        //{
        //    get
        //    {
        //        if (_tb_parametro_descvend == null)
        //            _tb_parametro_descvend = new List<tb_parametro_descvend>();
        //        return _tb_parametro_descvend;
        //    }
        //    set { _tb_parametro_descvend = value; }
        //}

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

        #endregion
    }
}
