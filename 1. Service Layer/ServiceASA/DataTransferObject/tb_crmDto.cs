using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_crm")]
    public partial class tb_crmDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 crm_id { get; set; }
        [DataMember]
        public virtual String crm_tipo { get; set; }
        [DataMember]
        public virtual Int32 uf_id { get; set; }
        [DataMember]
        public virtual String crm_nome { get; set; }
        [DataMember]
        public virtual String crm_crm { get; set; }
        [DataMember]
        public virtual String crm_email { get; set; }
        [DataMember]
        public virtual String crm_sexo { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> crm_dt_nascimento { get; set; }
        [DataMember]
        public virtual String crm_celular { get; set; }
        [DataMember]
        public virtual String crm_obs { get; set; }
        [DataMember]
        public virtual String crm_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> crm_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> crm_dt_alteracao { get; set; }
        [DataMember]
        public virtual String crm_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Int32> esp_id { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_crm_enderecoDto> tb_crm_endereco;
        //public virtual ICollection<tb_crm_endereco> tb_crm_endereco
        //{
        //    get
        //    {
        //        if (_tb_crm_endereco == null)
        //            _tb_crm_endereco = new List<tb_crm_endereco>();
        //        return _tb_crm_endereco;
        //    }
        //    set { _tb_crm_endereco = value; }
        //}
        [DataMember]
        public virtual tb_ufDto tb_uf { get; set; }

        #endregion
    }
    
}
