using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArquiteturaASABusiness.BusinessObjects
{
    public partial class tb_agenda_produto
    {
        #region Primitive Properties
        public virtual Int32 uneg_id { get; set; }

        public virtual Int32 agen_pdv { get; set; }

        public virtual Int32 agen_id { get; set; }

        public virtual DateTime agen_dt_agenda { get; set; }

        public virtual Nullable<DateTime> agen_dt_vencimento { get; set; }

        public virtual Nullable<DateTime> agen_dt_start { get; set; }

        public virtual Nullable<DateTime> agen_dt_venda { get; set; }

        public virtual String agen_status { get; set; }

        public virtual Nullable<DateTime> agen_status_data { get; set; }

        public virtual String agen_status_obs { get; set; }

        public virtual Nullable<DateTime> agen_dt_alteracao { get; set; }

        public virtual Nullable<Int32> agen_qtde_embalagem { get; set; }

        public virtual Nullable<Int32> agen_atde_compra { get; set; }

        public virtual Nullable<Int32> agen_tmp_consumo_hora { get; set; }

        public virtual Nullable<Int32> agen_tmp_consumo_diario { get; set; }

        public virtual Nullable<Int32> agen_tmp_consumo_dia { get; set; }

        public virtual Nullable<Int32> agen_tmp_consumo_mes { get; set; }

        public virtual Nullable<Int32> agen_qtde_consumo { get; set; }

        public virtual String agen_nome_contato { get; set; }

        public virtual Nullable<Int64> agen_tel_residencial { get; set; }

        public virtual Nullable<Int64> agen_tel_comercial { get; set; }

        public virtual Nullable<Int64> agen_tel_celular { get; set; }

        public virtual String agen_observacao { get; set; }

        public virtual Nullable<Decimal> agen_preco_custo { get; set; }

        public virtual Nullable<Decimal> agen_preco_venda { get; set; }

        public virtual Nullable<Int64> end_telefone { get; set; }

        #endregion

        #region Navigation Properties
        public virtual tb_produto tb_produto { get; set; }

        public virtual tb_unid_negocio tb_unid_negocio { get; set; }

        public virtual tb_usuario tb_usuario { get; set; }

        public virtual tb_usuario tb_usuario1 { get; set; }

        #endregion
    }
    
}
