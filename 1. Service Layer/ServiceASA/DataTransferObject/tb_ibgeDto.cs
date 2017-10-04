using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_ibge")]
    public partial class tb_ibgeDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 ibge_codigo { get; set; }
        [DataMember]
        public virtual String ibge_municipio { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_cadastro_contadorDto> tb_cadastro_contador;
        //public virtual ICollection<tb_cadastro_contador> tb_cadastro_contador
        //{
        //    get
        //    {
        //        if (_tb_cadastro_contador == null)
        //            _tb_cadastro_contador = new List<tb_cadastro_contador>();
        //        return _tb_cadastro_contador;
        //    }
        //    set { _tb_cadastro_contador = value; }
        //}
        [DataMember]
        public virtual tb_ufDto tb_uf { get; set; }

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
