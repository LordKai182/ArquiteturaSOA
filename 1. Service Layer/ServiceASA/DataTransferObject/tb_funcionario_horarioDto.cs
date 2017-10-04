using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_funcionario_horario")]
    public partial class tb_funcionario_horarioDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 hora_id { get; set; }
        [DataMember]
        public virtual String hora_titulo { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> hora_desc_dom { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> hora_desc_seg { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> hora_desc_ter { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> hora_desc_qua { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> hora_desc_qui { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> hora_desc_sex { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> hora_desc_sab { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> hora_desc_feriado { get; set; }
        [DataMember]
        public virtual String hora_situacao { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> hora_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> hora_dt_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> hora_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private IList<tb_funcionarioDto> tb_funcionario;
        //public virtual ICollection<tb_funcionario> tb_funcionario
        //{
        //    get
        //    {
        //        if (_tb_funcionario == null)
        //            _tb_funcionario = new List<tb_funcionario>();
        //        return _tb_funcionario;
        //    }
        //    set { _tb_funcionario = value; }
        //}

        private IList<tb_funcionarioDto> tb_funcionario1;
        //public virtual ICollection<tb_funcionario> tb_funcionario1
        //{
        //    get
        //    {
        //        if (_tb_funcionario1 == null)
        //            _tb_funcionario1 = new List<tb_funcionario>();
        //        return _tb_funcionario1;
        //    }
        //    set { _tb_funcionario1 = value; }
        //}

        private IList<tb_funcionario_horario_itemDto> tb_funcionario_horario_item;
        //public virtual ICollection<tb_funcionario_horario_item> tb_funcionario_horario_item
        //{
        //    get
        //    {
        //        if (_tb_funcionario_horario_item == null)
        //            _tb_funcionario_horario_item = new List<tb_funcionario_horario_item>();
        //        return _tb_funcionario_horario_item;
        //    }
        //    set { _tb_funcionario_horario_item = value; }
        //}

        #endregion
    }
}
