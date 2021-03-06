﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceASA.DataTransferObject
{
    [DataContract(Name = "tb_parametro_comissao")]
    public partial class tb_parametro_comissaoDto
    {
        #region Primitive Properties
        [DataMember]
        public virtual Int32 par_id { get; set; }
        [DataMember]
        public virtual String par_objeto { get; set; }
        [DataMember]
        public virtual String par_tipo { get; set; }
        [DataMember]
        public virtual String par_situacao { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> par_aplicar { get; set; }
        [DataMember]
        public virtual Nullable<Boolean> par_tp_regra { get; set; }
        [DataMember]
        public virtual String par_locked { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> par_dt_cadastro { get; set; }
        [DataMember]
        public virtual Nullable<DateTime> par_dt_alteracao { get; set; }
        [DataMember]
        public virtual String par_cpf_alteracao { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_desconto_ate_1 { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_percentual_1 { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_desconto_ate_2 { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_percentual_2 { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_desconto_ate_3 { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_percentual_3 { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_desconto_ate_4 { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_percentual_4 { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_desconto_ate_5 { get; set; }
        [DataMember]
        public virtual Nullable<Decimal> par_percentual_5 { get; set; }
        [DataMember]
        public virtual Nullable<Int32> funcao_id { get; set; }
        [DataMember]
        public virtual Nullable<Int32> usr_id { get; set; }

        #endregion

        #region Navigation Properties
        [DataMember]
        public virtual tb_fornecedor_divisaoDto tb_fornecedor_divisao { get; set; }
        [DataMember]
        public virtual tb_produtoDto tb_produto { get; set; }
        [DataMember]
        public virtual tb_parametro_comissaoDto tb_parametro_comissao1 { get; set; }
        [DataMember]
        public virtual tb_parametro_comissaoDto tb_parametro_comissao2 { get; set; }
        [DataMember]
        public virtual tb_produto_classeDto tb_produto_classe { get; set; }
        [DataMember]
        public virtual tb_produto_fam_categ_subDto tb_produto_fam_categ_sub { get; set; }
        [DataMember]
        public virtual tb_produto_linhaDto tb_produto_linha { get; set; }
        [DataMember]
        public virtual tb_produto_similaridadeDto tb_produto_similaridade { get; set; }

        #endregion
    }
}
