using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_cadastro_contador
    {
        #region Primitive Properties
        public virtual Int32 cadcont_id { get; set; }

        public virtual String cadcont_nome { get; set; }

        public virtual String cadcont_cpf { get; set; }

        public virtual String cadcont_crc { get; set; }

        public virtual String cadcont_email { get; set; }

        public virtual String cadcont_status { get; set; }

        public virtual Nullable<DateTime> cadcont_data_modificacao { get; set; }

        public virtual String cadcont_escritorio_cnpj { get; set; }

        public virtual String cadcont_escritorio_inscricao_estadual { get; set; }

        public virtual String cadcont_escritorio_inscricao_municipal { get; set; }

        public virtual String cadcont_escritorio_razao_social { get; set; }

        public virtual String cadcont_escritorio_nome_fantasia { get; set; }

        public virtual String cadcont_escritorio_endereco { get; set; }

        public virtual String cadcont_escritorio_numero { get; set; }

        public virtual String cadcont_escritorio_complemento { get; set; }

        public virtual String cadcont_escritorio_bairro { get; set; }

        public virtual String cadcont_escritorio_cep { get; set; }

        public virtual Nullable<Int32> cadcont_escritorio_ddd { get; set; }

        public virtual String cadcont_escritorio_telefone { get; set; }

        public virtual Nullable<Int32> cadcont_escritorio_ddd_fax { get; set; }

        public virtual String cadcont_escritorio_fax { get; set; }

        public virtual String cadcont_escritorio_email { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_ibge tb_ibge { get; set; }

        private ICollection<tb_unid_negocio> _tb_unid_negocio;
        public virtual ICollection<tb_unid_negocio> tb_unid_negocio
        {
            get
            {
                if (_tb_unid_negocio == null)
                    _tb_unid_negocio = new List<tb_unid_negocio>();
                return _tb_unid_negocio;
            }
            set { _tb_unid_negocio = value; }
        }

        #endregion
    }
}
