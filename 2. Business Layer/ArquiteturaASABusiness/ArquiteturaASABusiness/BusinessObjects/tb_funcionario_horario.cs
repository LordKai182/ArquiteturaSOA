using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_funcionario_horario
    {
        #region Primitive Properties
        public virtual Int32 hora_id { get; set; }

        public virtual String hora_titulo { get; set; }

        public virtual Nullable<Boolean> hora_desc_dom { get; set; }

        public virtual Nullable<Boolean> hora_desc_seg { get; set; }

        public virtual Nullable<Boolean> hora_desc_ter { get; set; }

        public virtual Nullable<Boolean> hora_desc_qua { get; set; }

        public virtual Nullable<Boolean> hora_desc_qui { get; set; }

        public virtual Nullable<Boolean> hora_desc_sex { get; set; }

        public virtual Nullable<Boolean> hora_desc_sab { get; set; }

        public virtual Nullable<Boolean> hora_desc_feriado { get; set; }

        public virtual String hora_situacao { get; set; }

        public virtual Nullable<DateTime> hora_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> hora_dt_alteracao { get; set; }

        public virtual Nullable<Decimal> hora_cpf_alteracao { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_funcionario> _tb_funcionario;
        public virtual ICollection<tb_funcionario> tb_funcionario
        {
            get
            {
                if (_tb_funcionario == null)
                    _tb_funcionario = new List<tb_funcionario>();
                return _tb_funcionario;
            }
            set { _tb_funcionario = value; }
        }

        private ICollection<tb_funcionario> _tb_funcionario1;
        public virtual ICollection<tb_funcionario> tb_funcionario1
        {
            get
            {
                if (_tb_funcionario1 == null)
                    _tb_funcionario1 = new List<tb_funcionario>();
                return _tb_funcionario1;
            }
            set { _tb_funcionario1 = value; }
        }

        private ICollection<tb_funcionario_horario_item> _tb_funcionario_horario_item;
        public virtual ICollection<tb_funcionario_horario_item> tb_funcionario_horario_item
        {
            get
            {
                if (_tb_funcionario_horario_item == null)
                    _tb_funcionario_horario_item = new List<tb_funcionario_horario_item>();
                return _tb_funcionario_horario_item;
            }
            set { _tb_funcionario_horario_item = value; }
        }

        #endregion
    }
}
