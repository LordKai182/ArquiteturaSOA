using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_cliente_fiscal")]
    public partial class tb_cliente_fiscalDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual String cli_fisc_cpf_cnpj { get; set; }
        [DataMember]
        public virtual String cli_fisc_nome { get; set; }
        [DataMember]
        public virtual String cli_fisc_email { get; set; }
        [DataMember]
        public virtual String cli_fisc_endereco { get; set; }
        [DataMember]
        public virtual String cli_fisc_tp_logradouro { get; set; }
        [DataMember]
        public virtual Nullable<Int32> cli_fisc_numero { get; set; }
        [DataMember]
        public virtual String cli_fisc_complemento { get; set; }
        [DataMember]
        public virtual String cli_fisc_bairro { get; set; }
        [DataMember]
        public virtual String cli_fisc_cidade { get; set; }
        [DataMember]
        public virtual String cli_fisc_uf { get; set; }
        [DataMember]
        public virtual String cli_fisc_cep { get; set; }
        [DataMember]
        public virtual DateTime cli_fisc_data_cadastro { get; set; }
        [DataMember]
        public virtual String cli_fisc_ibge_codigo { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_unid_negocioDto tb_unid_negocio { get; set; }
        [DataMember]
        public virtual tb_usuarioDto tb_usuario { get; set; }

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

        #endregion
    }
}
