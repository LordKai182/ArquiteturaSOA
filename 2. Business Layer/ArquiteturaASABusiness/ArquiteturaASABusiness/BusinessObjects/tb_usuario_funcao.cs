using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{

    public partial class tb_usuario_funcao
    {
        #region Primitive Properties
        public virtual Int32 funcao_id { get; set; }

        public virtual String funcao_descricao { get; set; }

        public virtual Nullable<Boolean> funcao_param_lj_ponto { get; set; }

        public virtual String funcao_situacao { get; set; }

        public virtual Nullable<Boolean> funcao_cancela_venda { get; set; }

        public virtual Nullable<Boolean> funcao_cancela_vendaItem { get; set; }

        public virtual Nullable<Boolean> funcao_desconto_vendaItem { get; set; }

        public virtual Nullable<Boolean> funcao_desconto_venda { get; set; }

        public virtual Nullable<Boolean> funcao_gerenciar_ponto { get; set; }

        public virtual Nullable<Boolean> funcao_reiniciar_setup { get; set; }

        public virtual Nullable<Boolean> funcao_menu_gerencial { get; set; }

        public virtual Nullable<Boolean> funcao_fundo_caixa { get; set; }

        public virtual Nullable<Boolean> funcao_sangria { get; set; }

        public virtual Nullable<Boolean> funcao_despesa { get; set; }

        public virtual Nullable<DateTime> funcao_dt_cadastro { get; set; }

        public virtual Nullable<DateTime> funcao_dt_alteracao { get; set; }

        public virtual Nullable<Boolean> funcao_vendaItem_semCodBarra { get; set; }

        public virtual Nullable<Boolean> funcao_libera_lote { get; set; }

        #endregion

        #region Navigation Properties
        private ICollection<tb_parametro_descvend> _tb_parametro_descvend;
        public virtual ICollection<tb_parametro_descvend> tb_parametro_descvend
        {
            get
            {
                if (_tb_parametro_descvend == null)
                    _tb_parametro_descvend = new List<tb_parametro_descvend>();
                return _tb_parametro_descvend;
            }
            set { _tb_parametro_descvend = value; }
        }

        private ICollection<tb_usuario> _tb_usuario;
        public virtual ICollection<tb_usuario> tb_usuario
        {
            get
            {
                if (_tb_usuario == null)
                    _tb_usuario = new List<tb_usuario>();
                return _tb_usuario;
            }
            set { _tb_usuario = value; }
        }

        #endregion
    }
}
