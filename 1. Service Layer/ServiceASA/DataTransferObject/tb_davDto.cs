using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_dav")]
    public partial class tb_davDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 dav_id { get; set; }
        [DataMember]
        public virtual DateTime dav_data { get; set; }
        [DataMember]
        public virtual DateTime dav_data_emissao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> dav_numero { get; set; }
        [DataMember]
        public virtual Nullable<Int32> dav_numero_controle { get; set; }
        [DataMember]
        public virtual String ecf_numero_serie_emissao { get; set; }
        [DataMember]
        public virtual Int32 dav_coo_emissao { get; set; }
        [DataMember]
        public virtual Int32 dav_gnf_emissao { get; set; }
        [DataMember]
        public virtual String dav_cpf_cnpj { get; set; }
        [DataMember]
        public virtual String dav_nome_adquirente { get; set; }
        [DataMember]
        public virtual Nullable<Int32> dav_num_ecf_venda { get; set; }
        [DataMember]
        public virtual Nullable<Int32> dav_coo_venda { get; set; }
        [DataMember]
        public virtual Nullable<Int32> dav_coo_cupom_vinculado_venda { get; set; }
        [DataMember]
        public virtual String dav_titulo { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> dav_valor_total { get; set; }
        [DataMember]
        public virtual String dav_status { get; set; }
        [DataMember]
        public virtual String ecf_numero_serie_fechamento_cupom { get; set; }
        [DataMember]
        public virtual String dav_md5 { get; set; }

        #endregion

        #region Navigation Properties

        private IList<tb_dav_itens____Dto> tb_dav_itens____;
        //public virtual ICollection<tb_dav_itens____> tb_dav_itens____
        //{
        //    get
        //    {
        //        if (_tb_dav_itens____ == null)
        //            _tb_dav_itens____ = new List<tb_dav_itens____>();
        //        return _tb_dav_itens____;
        //    }
        //    set { _tb_dav_itens____ = value; }
        //}
        [DataMember]
        public virtual tb_vendaDto tb_venda { get; set; }

        #endregion
    }
}
