using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_ecf")]
    public partial class tb_ecfDto
    {   
        #region Primitive Properties
        [DataMember]
        public virtual String ecf_numero_serie { get; set; }
        [DataMember]
        public virtual Int32 ecf_numero_ecf { get; set; }
        [DataMember]
        public virtual String ecf_versao_firmware { get; set; }
        [DataMember]
        public virtual DateTime ecf_data_instalacao_software_basico { get; set; }
        [DataMember]
        public virtual String ecf_numero_usuario_atual { get; set; }
        [DataMember]
        public virtual Nullable<Int32> ecf_qtdlinhas_guilhotina { get; set; }
        [DataMember]
        public virtual Nullable<Int32> ecf_velocidade_porta { get; set; }
        [DataMember]
        public virtual String ecf_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ecf_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> ecf_dt_alteracao { get; set; }
        [DataMember]
        public virtual String ecf_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> uneg_id { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_ecf_ddDto> tb_ecf_dd;
        //public virtual ICollection<tb_ecf_dd> tb_ecf_dd
        //{
        //    get
        //    {
        //        if (_tb_ecf_dd == null)
        //            _tb_ecf_dd = new List<tb_ecf_dd>();
        //        return _tb_ecf_dd;
        //    }
        //    set { _tb_ecf_dd = value; }
        //}
        [DataMember]
        public virtual tb_ecf_modeloDto tb_ecf_modelo { get; set; }

        private IList<tb_reducao_zDto> tb_reducao_z;
        //public virtual ICollection<tb_reducao_z> tb_reducao_z
        //{
        //    get
        //    {
        //        if (_tb_reducao_z == null)
        //            _tb_reducao_z = new List<tb_reducao_z>();
        //        return _tb_reducao_z;
        //    }
        //    set { _tb_reducao_z = value; }
        //}

        private IList<tb_vendaDto> tb_venda;
        //public virtual ICollection<tb_venda> tb_venda
        //{
        //    get
        //    {
        //        if (_tb_venda == null)
        //            _tb_venda = new List<tb_venda>();
        //        return _tb_venda;
        //    }
        //    set { _tb_venda = value; }
        //}

        private IList<tbr_ecf_finalizadoraDto> tbr_ecf_finalizadora;
        //public virtual ICollection<tbr_ecf_finalizadora> tbr_ecf_finalizadora
        //{
        //    get
        //    {
        //        if (_tbr_ecf_finalizadora == null)
        //            _tbr_ecf_finalizadora = new List<tbr_ecf_finalizadora>();
        //        return _tbr_ecf_finalizadora;
        //    }
        //    set { _tbr_ecf_finalizadora = value; }
        //}

        private IList<tbr_ecf_tributacaoDto> tbr_ecf_tributacao;
        //public virtual ICollection<tbr_ecf_tributacao> tbr_ecf_tributacao
        //{
        //    get
        //    {
        //        if (_tbr_ecf_tributacao == null)
        //            _tbr_ecf_tributacao = new List<tbr_ecf_tributacao>();
        //        return _tbr_ecf_tributacao;
        //    }
        //    set { _tbr_ecf_tributacao = value; }
        //}

        #endregion
    }
}
