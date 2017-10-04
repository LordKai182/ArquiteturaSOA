using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_promocao")]
    public partial class tb_promocaoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 prm_id { get; set; }
        [DataMember]
        public virtual String prm_observacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> prm_dt_inicio { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> prm_dt_fim { get; set; }
        [DataMember]
        public virtual String prm_tip_aplicacao { get; set; }
        [DataMember]
        public virtual String prm_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> prm_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> prm_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> prm_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> tippro_id { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_clienteDto> tb_cliente;
        //public virtual ICollection<tb_cliente> tb_cliente
        //{
        //    get
        //    {
        //        if (_tb_cliente == null)
        //            _tb_cliente = new List<tb_cliente>();
        //        return _tb_cliente;
        //    }
        //    set { _tb_cliente = value; }
        //}

        private IList<tbr_promocao_produtoDto> tbr_promocao_produto;
        //public virtual ICollection<tbr_promocao_produto> tbr_promocao_produto
        //{
        //    get
        //    {
        //        if (_tbr_promocao_produto == null)
        //            _tbr_promocao_produto = new List<tbr_promocao_produto>();
        //        return _tbr_promocao_produto;
        //    }
        //    set { _tbr_promocao_produto = value; }
        //}

        private IList<tb_convenioDto> tb_convenio;
        //public virtual ICollection<tb_convenio> tb_convenio
        //{
        //    get
        //    {
        //        if (_tb_convenio == null)
        //            _tb_convenio = new List<tb_convenio>();
        //        return _tb_convenio;
        //    }
        //    set { _tb_convenio = value; }
        //}

        private IList<tb_unid_negocioDto> tb_unid_negocio;
        //public virtual ICollection<tb_unid_negocio> tb_unid_negocio
        //{
        //    get
        //    {
        //        if (_tb_unid_negocio == null)
        //            _tb_unid_negocio = new List<tb_unid_negocio>();
        //        return _tb_unid_negocio;
        //    }
        //    set { _tb_unid_negocio = value; }
        //}

        #endregion
    }
}
