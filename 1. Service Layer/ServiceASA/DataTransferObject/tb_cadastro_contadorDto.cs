using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_cadastro_contador")]
    public partial class tb_cadastro_contadorDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 cadcont_id { get; set; }
        [DataMember]
        public virtual String cadcont_nome { get; set; }
        [DataMember]
        public virtual String cadcont_cpf { get; set; }
        [DataMember]
        public virtual String cadcont_crc { get; set; }
        [DataMember]
        public virtual String cadcont_email { get; set; }
        [DataMember]
        public virtual String cadcont_status { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> cadcont_data_modificacao { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_cnpj { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_inscricao_estadual { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_inscricao_municipal { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_razao_social { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_nome_fantasia { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_endereco { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_numero { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_complemento { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_bairro { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_cep { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cadcont_escritorio_ddd { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_telefone { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cadcont_escritorio_ddd_fax { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_fax { get; set; }
        [DataMember]
        public virtual String cadcont_escritorio_email { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_ibgeDto tb_ibge { get; set; }
        
        private IList<tb_unid_negocioDto> _tb_unid_negocio;
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
