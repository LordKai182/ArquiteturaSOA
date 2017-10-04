using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_entrega_endereco
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 end_pdv { get; set; }

        public virtual Int32 end_id { get; set; }

        public virtual DateTime end_data { get; set; }

        public virtual Int64 end_telefone { get; set; }

        public virtual Nullable<Int32> end_cep { get; set; }

        public virtual String end_tp_logradouro { get; set; }

        public virtual String end_nm_logradouro { get; set; }

        public virtual Nullable<Int32> end_numero { get; set; }

        public virtual String end_complemento { get; set; }

        public virtual String end_bairro { get; set; }

        public virtual String end_cidade { get; set; }

        public virtual String end_referencia { get; set; }

        public virtual String end_tipo { get; set; }

        public virtual String end_latitude_decimais { get; set; }

        public virtual String end_longitude_decimais { get; set; }

        public virtual String end_situacao { get; set; }

        public virtual Nullable<DateTime> end_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> end_dt_alteracao { get; set; }

        public virtual String end_cpf_alteracao { get; set; }

        public virtual Nullable<Int32> uf_id { get; set; }

        public virtual Nullable<Int64> ibge_codigo { get; set; }

        public virtual Nullable<Int32> polo_id { get; set; }

        public virtual String end_contato { get; set; }

        public virtual Nullable<Boolean> end_uso_continuo { get; set; }

        public virtual String end_obs { get; set; }

        public virtual Nullable<DateTime> end_dt_ultima_compra { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        #endregion
    }
}
