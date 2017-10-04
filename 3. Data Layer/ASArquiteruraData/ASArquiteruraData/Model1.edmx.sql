
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 08/02/2016 17:39:38
-- Generated from EDMX file: C:\HENRIQUE\ArquiteruraASA_SS\ArquiteruraASA\ArquiteruraASA\3. Data Layer\ASArquiteruraData\ASArquiteruraData\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [teste];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_tb_agenda_produto_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_agenda_produto] DROP CONSTRAINT [FK_tb_agenda_produto_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_agenda_produto_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_agenda_produto] DROP CONSTRAINT [FK_tb_agenda_produto_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_agenda_produto_tb_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_agenda_produto] DROP CONSTRAINT [FK_tb_agenda_produto_tb_usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_agenda_produto_tb_usuario1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_agenda_produto] DROP CONSTRAINT [FK_tb_agenda_produto_tb_usuario1];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_cadastro_contador_tb_ibge]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_cadastro_contador] DROP CONSTRAINT [FK_tb_cadastro_contador_tb_ibge];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_checkin_item_tmp_tb_checkin_tmp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_checkin_item_tmp] DROP CONSTRAINT [FK_tb_checkin_item_tmp_tb_checkin_tmp];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_checkin_item_tmp_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_checkin_item_tmp] DROP CONSTRAINT [FK_tb_checkin_item_tmp_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_checkin_tmp_tb_fornecedor_divisao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_checkin_tmp] DROP CONSTRAINT [FK_tb_checkin_tmp_tb_fornecedor_divisao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_checkin_tmp_tb_pe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_checkin_tmp] DROP CONSTRAINT [FK_tb_checkin_tmp_tb_pe];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_checkin_tmp_tb_un]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_checkin_tmp] DROP CONSTRAINT [FK_tb_checkin_tmp_tb_un];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_cliente_anvisa_tb_cliente_anvisa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_cliente_anvisa] DROP CONSTRAINT [FK_tb_cliente_anvisa_tb_cliente_anvisa];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_cliente_endereco_tb_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_cliente_endereco] DROP CONSTRAINT [FK_tb_cliente_endereco_tb_cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_cliente_endereco_tb_uf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_cliente_endereco] DROP CONSTRAINT [FK_tb_cliente_endereco_tb_uf];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_cliente_fiscal_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_cliente_fiscal] DROP CONSTRAINT [FK_tb_cliente_fiscal_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_cliente_fiscal_tb_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_cliente_fiscal] DROP CONSTRAINT [FK_tb_cliente_fiscal_tb_usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_cliente_tb_cliente_bloqueio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_cliente] DROP CONSTRAINT [FK_tb_cliente_tb_cliente_bloqueio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_cliente_tb_promocao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_cliente] DROP CONSTRAINT [FK_tb_cliente_tb_promocao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_cliente_tb_uf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_cliente] DROP CONSTRAINT [FK_tb_cliente_tb_uf];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_cliente_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_cliente] DROP CONSTRAINT [FK_tb_cliente_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_conselho_regional_tb_conselho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_conselho_regional] DROP CONSTRAINT [FK_tb_conselho_regional_tb_conselho];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_convenio_prazo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_convenio] DROP CONSTRAINT [FK_tb_convenio_prazo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_convenio_tb_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_convenio] DROP CONSTRAINT [FK_tb_convenio_tb_cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_crediario_tb_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_crediario] DROP CONSTRAINT [FK_tb_crediario_tb_cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_crediario_tb_convenio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_crediario] DROP CONSTRAINT [FK_tb_crediario_tb_convenio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_crediario_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_crediario] DROP CONSTRAINT [FK_tb_crediario_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_crm_endereco_crm_id_crm_tipo_uf_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_crm_endereco] DROP CONSTRAINT [FK_tb_crm_endereco_crm_id_crm_tipo_uf_id];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_crm_endereco_uf_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_crm_endereco] DROP CONSTRAINT [FK_tb_crm_endereco_uf_id];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_crm_tb_uf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_crm] DROP CONSTRAINT [FK_tb_crm_tb_uf];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_dav_itens_tb_dav]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_dav_itens ???] DROP CONSTRAINT [FK_tb_dav_itens_tb_dav];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_dav_tb_venda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_dav] DROP CONSTRAINT [FK_tb_dav_tb_venda];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_ecf_dd_tb_ecf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_ecf_dd] DROP CONSTRAINT [FK_tb_ecf_dd_tb_ecf];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_ecf_dd_tb_finalizadora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_ecf_dd] DROP CONSTRAINT [FK_tb_ecf_dd_tb_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_ecf_tb_ecf_modelo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_ecf] DROP CONSTRAINT [FK_tb_ecf_tb_ecf_modelo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_empresa_privatelabel_tb_financeiro_prazo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_empresa_privatelabel] DROP CONSTRAINT [FK_tb_empresa_privatelabel_tb_financeiro_prazo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_empresa_privatelabel_tb_fornecedor_divisao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_empresa_privatelabel] DROP CONSTRAINT [FK_tb_empresa_privatelabel_tb_fornecedor_divisao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_entrega_endereco_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_entrega_endereco] DROP CONSTRAINT [FK_tb_entrega_endereco_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_entrega_prod_continuo_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_entrega_prod_continuo] DROP CONSTRAINT [FK_tb_entrega_prod_continuo_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_estoque_lote_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_produto_estoque_lote] DROP CONSTRAINT [FK_tb_estoque_lote_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_estoque_lote_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_produto_estoque_lote] DROP CONSTRAINT [FK_tb_estoque_lote_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_finalizadora_sub_tb_finalizadora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_finalizadora_sub] DROP CONSTRAINT [FK_tb_finalizadora_sub_tb_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_finalizadora_sub_tb_financeiro_administradora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_finalizadora_sub] DROP CONSTRAINT [FK_tb_finalizadora_sub_tb_financeiro_administradora];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_finalizadora_sub_tb_financeiro_evento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_finalizadora_sub] DROP CONSTRAINT [FK_tb_finalizadora_sub_tb_financeiro_evento];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_finalizadora_sub_tb_financeiro_prazo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_finalizadora_sub] DROP CONSTRAINT [FK_tb_finalizadora_sub_tb_financeiro_prazo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_financeiro_lancto_tb_financeiro_evento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_lancto_financeiro] DROP CONSTRAINT [FK_tb_financeiro_lancto_tb_financeiro_evento];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_financeiro_sangria_tb_finalizadora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_financeiro_sangria] DROP CONSTRAINT [FK_tb_financeiro_sangria_tb_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_financeiro_sangria_tb_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_financeiro_sangria] DROP CONSTRAINT [FK_tb_financeiro_sangria_tb_usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_financeiro_suprimento_tb_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_financeiro_suprimento] DROP CONSTRAINT [FK_tb_financeiro_suprimento_tb_usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_fornecedor_divisao11282]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_fornecedor_divisao] DROP CONSTRAINT [FK_tb_fornecedor_divisao11282];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_funcionario_horario_item_tb_funcionario_horario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_funcionario_horario_item] DROP CONSTRAINT [FK_tb_funcionario_horario_item_tb_funcionario_horario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_funcionario_tb_cargo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_funcionario] DROP CONSTRAINT [FK_tb_funcionario_tb_cargo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_funcionario_tb_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_funcionario] DROP CONSTRAINT [FK_tb_funcionario_tb_cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_funcionario_tb_convenio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_funcionario] DROP CONSTRAINT [FK_tb_funcionario_tb_convenio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_funcionario_tb_financeiro_bancos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_funcionario] DROP CONSTRAINT [FK_tb_funcionario_tb_financeiro_bancos];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_funcionario_tb_funcionario_horario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_funcionario] DROP CONSTRAINT [FK_tb_funcionario_tb_funcionario_horario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_funcionario_tb_funcionario_horario1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_funcionario] DROP CONSTRAINT [FK_tb_funcionario_tb_funcionario_horario1];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_funcionario_uneg_locacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_funcionario] DROP CONSTRAINT [FK_tb_funcionario_uneg_locacao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_funcionario_uneg_registro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_funcionario] DROP CONSTRAINT [FK_tb_funcionario_uneg_registro];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_funcionario_visitante_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_funcionario_visitante] DROP CONSTRAINT [FK_tb_funcionario_visitante_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_ibge_tb_uf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_ibge] DROP CONSTRAINT [FK_tb_ibge_tb_uf];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_lancto_financeiro_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_lancto_financeiro] DROP CONSTRAINT [FK_tb_lancto_financeiro_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra_dup_tb_mvto_compra_dup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_dup_???] DROP CONSTRAINT [FK_tb_mvto_compra_dup_tb_mvto_compra_dup];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra_item_divergencia_tb_mvto_compra_item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_item_divergencia_???] DROP CONSTRAINT [FK_tb_mvto_compra_item_divergencia_tb_mvto_compra_item];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra_item_lote_tb_mvto_compra_item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_item_lote_???] DROP CONSTRAINT [FK_tb_mvto_compra_item_lote_tb_mvto_compra_item];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra_item_tb_cfop]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_item_???] DROP CONSTRAINT [FK_tb_mvto_compra_item_tb_cfop];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra_item_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_item_???] DROP CONSTRAINT [FK_tb_mvto_compra_item_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra_item1_t555]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_item_???] DROP CONSTRAINT [FK_tb_mvto_compra_item1_t555];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra_tb_financeiro_prazo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_???] DROP CONSTRAINT [FK_tb_mvto_compra_tb_financeiro_prazo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra_tb_serie_nt]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_???] DROP CONSTRAINT [FK_tb_mvto_compra_tb_serie_nt];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra_tb_uf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_???] DROP CONSTRAINT [FK_tb_mvto_compra_tb_uf];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra1_tb_un]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_???] DROP CONSTRAINT [FK_tb_mvto_compra1_tb_un];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra2_tb_ti]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_???] DROP CONSTRAINT [FK_tb_mvto_compra2_tb_ti];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra3_tb_tr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_???] DROP CONSTRAINT [FK_tb_mvto_compra3_tb_tr];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_mvto_compra4_tb_fo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_mvto_compra_???] DROP CONSTRAINT [FK_tb_mvto_compra4_tb_fo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_nfe_item_tb_cfop]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_nfe_item] DROP CONSTRAINT [FK_tb_nfe_item_tb_cfop];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_nfe_item_tb_nfe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_nfe_item] DROP CONSTRAINT [FK_tb_nfe_item_tb_nfe];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_nfe_item_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_nfe_item] DROP CONSTRAINT [FK_tb_nfe_item_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_paciente_anvisa_tb_paciente_anvisa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_paciente_anvisa] DROP CONSTRAINT [FK_tb_paciente_anvisa_tb_paciente_anvisa];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_comissao_tb_fornecedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_comissao] DROP CONSTRAINT [FK_tb_parametro_comissao_tb_fornecedor];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_comissao_tb_parametro_comissao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_comissao] DROP CONSTRAINT [FK_tb_parametro_comissao_tb_parametro_comissao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_comissao_tb_parametro_comissao1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_comissao] DROP CONSTRAINT [FK_tb_parametro_comissao_tb_parametro_comissao1];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_comissao_tb_produto_classe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_comissao] DROP CONSTRAINT [FK_tb_parametro_comissao_tb_produto_classe];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_comissao_tb_produto_fam_categ_sub]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_comissao] DROP CONSTRAINT [FK_tb_parametro_comissao_tb_produto_fam_categ_sub];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_comissao_tb_produto_linha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_comissao] DROP CONSTRAINT [FK_tb_parametro_comissao_tb_produto_linha];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_comissao_tb_produto_similaridade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_comissao] DROP CONSTRAINT [FK_tb_parametro_comissao_tb_produto_similaridade];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descconv_tb_convenio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descconv] DROP CONSTRAINT [FK_tb_parametro_descconv_tb_convenio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descconv_tb_fornecedor_divisao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descconv] DROP CONSTRAINT [FK_tb_parametro_descconv_tb_fornecedor_divisao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descconv_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descconv] DROP CONSTRAINT [FK_tb_parametro_descconv_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descconv_tb_produto_classe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descconv] DROP CONSTRAINT [FK_tb_parametro_descconv_tb_produto_classe];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descconv_tb_produto_fam_categ_sub]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descconv] DROP CONSTRAINT [FK_tb_parametro_descconv_tb_produto_fam_categ_sub];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descconv_tb_produto_linha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descconv] DROP CONSTRAINT [FK_tb_parametro_descconv_tb_produto_linha];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descconv_tb_produto_similaridade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descconv] DROP CONSTRAINT [FK_tb_parametro_descconv_tb_produto_similaridade];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descmax_tb_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descmax_tb_usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descmax_tb_usuario_funcao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descmax_tb_usuario_funcao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_desconto_tb_fornecedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descmax] DROP CONSTRAINT [FK_tb_parametro_desconto_tb_fornecedor];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_desconto_tb_parametro_desconto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descmax] DROP CONSTRAINT [FK_tb_parametro_desconto_tb_parametro_desconto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_desconto_tb_produto_classe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descmax] DROP CONSTRAINT [FK_tb_parametro_desconto_tb_produto_classe];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_desconto_tb_produto_fam_categ_sub]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descmax] DROP CONSTRAINT [FK_tb_parametro_desconto_tb_produto_fam_categ_sub];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_desconto_tb_produto_linha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descmax] DROP CONSTRAINT [FK_tb_parametro_desconto_tb_produto_linha];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_desconto_tb_produto_similaridade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descmax] DROP CONSTRAINT [FK_tb_parametro_desconto_tb_produto_similaridade];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descprod_tb_fornecedor_divisao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descprod] DROP CONSTRAINT [FK_tb_parametro_descprod_tb_fornecedor_divisao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descprod_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descprod] DROP CONSTRAINT [FK_tb_parametro_descprod_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descprod_tb_produto_classe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descprod] DROP CONSTRAINT [FK_tb_parametro_descprod_tb_produto_classe];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descprod_tb_produto_fam_categ_sub]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descprod] DROP CONSTRAINT [FK_tb_parametro_descprod_tb_produto_fam_categ_sub];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descprod_tb_produto_linha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descprod] DROP CONSTRAINT [FK_tb_parametro_descprod_tb_produto_linha];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descprod_tb_produto_similaridade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descprod] DROP CONSTRAINT [FK_tb_parametro_descprod_tb_produto_similaridade];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descvend_tb_fornecedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descvend_tb_fornecedor];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descvend_tb_fornecedor_divisao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descvend_tb_fornecedor_divisao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descvend_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descvend_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descvend_tb_produto_classe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descvend_tb_produto_classe];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descvend_tb_produto_fam_categ_sub]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descvend_tb_produto_fam_categ_sub];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descvend_tb_produto_fam_categoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descvend_tb_produto_fam_categoria];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descvend_tb_produto_fam_grupo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descvend_tb_produto_fam_grupo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descvend_tb_produto_familia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descvend_tb_produto_familia];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descvend_tb_produto_linha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descvend_tb_produto_linha];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_descvend_tb_produto_similaridade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_descvend] DROP CONSTRAINT [FK_tb_parametro_descvend_tb_produto_similaridade];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_markup_tb_fornecedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_markup] DROP CONSTRAINT [FK_tb_parametro_markup_tb_fornecedor];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_markup_tb_parametro_markup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_markup] DROP CONSTRAINT [FK_tb_parametro_markup_tb_parametro_markup];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_markup_tb_produto_classe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_markup] DROP CONSTRAINT [FK_tb_parametro_markup_tb_produto_classe];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_markup_tb_produto_fam_categ_sub]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_markup] DROP CONSTRAINT [FK_tb_parametro_markup_tb_produto_fam_categ_sub];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_markup_tb_produto_linha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_markup] DROP CONSTRAINT [FK_tb_parametro_markup_tb_produto_linha];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_parametro_markup_tb_produto_similaridade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_parametro_markup] DROP CONSTRAINT [FK_tb_parametro_markup_tb_produto_similaridade];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_pedido_compra_item13902]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_pedido_compra_item_???] DROP CONSTRAINT [FK_tb_pedido_compra_item13902];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_pedido_compra1_tb_u9994]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_pedido_compra_???] DROP CONSTRAINT [FK_tb_pedido_compra1_tb_u9994];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_pedido_compra3_tb_f9800]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_pedido_compra_???] DROP CONSTRAINT [FK_tb_pedido_compra3_tb_f9800];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_polo_entrega_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_entrega_polo] DROP CONSTRAINT [FK_tb_polo_entrega_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_ponto_tb_ponto_motivo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_ponto] DROP CONSTRAINT [FK_tb_ponto_tb_ponto_motivo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_ponto_tb_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_ponto] DROP CONSTRAINT [FK_tb_ponto_tb_usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_privatelabel_finalizadora_tb_financeiro_prazo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_privatelabel_finalizadora] DROP CONSTRAINT [FK_tb_privatelabel_finalizadora_tb_financeiro_prazo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_privatelabel_finalizadora_tb_privatelabel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_privatelabel_finalizadora] DROP CONSTRAINT [FK_tb_privatelabel_finalizadora_tb_privatelabel];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_privatelabel_tb_empresa_privatelabel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_privatelabel] DROP CONSTRAINT [FK_tb_privatelabel_tb_empresa_privatelabel];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto_barra_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto_barra] DROP CONSTRAINT [FK_tb_produto_barra_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto_categoria1_1492]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto_fam_categoria] DROP CONSTRAINT [FK_tb_produto_categoria1_1492];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto_grupo1_tb_p6944]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto_fam_grupo] DROP CONSTRAINT [FK_tb_produto_grupo1_tb_p6944];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto_hist_diario_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_produto_estoque_dia] DROP CONSTRAINT [FK_tb_produto_hist_diario_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto_hist_diario_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_produto_estoque_dia] DROP CONSTRAINT [FK_tb_produto_hist_diario_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto_subcateg1_t3705]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto_fam_categ_sub] DROP CONSTRAINT [FK_tb_produto_subcateg1_t3705];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto_tb_abcfarma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto] DROP CONSTRAINT [FK_tb_produto_tb_abcfarma];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto_tb_produto_piscofins]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto] DROP CONSTRAINT [FK_tb_produto_tb_produto_piscofins];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto10_tb_pr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto] DROP CONSTRAINT [FK_tb_produto10_tb_pr];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto3_tb_pr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto] DROP CONSTRAINT [FK_tb_produto3_tb_pr];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto4_tb_pr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto] DROP CONSTRAINT [FK_tb_produto4_tb_pr];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto5_tb_pr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto] DROP CONSTRAINT [FK_tb_produto5_tb_pr];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto6_tb_pr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto] DROP CONSTRAINT [FK_tb_produto6_tb_pr];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto7_tb_pr]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto] DROP CONSTRAINT [FK_tb_produto7_tb_pr];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_produto9_tb_fo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_produto] DROP CONSTRAINT [FK_tb_produto9_tb_fo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_recarga_empresa_tb_financeiro_prazo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_empresa_recarga] DROP CONSTRAINT [FK_tb_recarga_empresa_tb_financeiro_prazo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_recarga_empresa_tb_fornecedor_divisao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_empresa_recarga] DROP CONSTRAINT [FK_tb_recarga_empresa_tb_fornecedor_divisao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_recarga_finalizadora_tb_financeiro_prazo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_recarga_finalizadora] DROP CONSTRAINT [FK_tb_recarga_finalizadora_tb_financeiro_prazo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_recarga_finalizadora_tb_recarga1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_recarga_finalizadora] DROP CONSTRAINT [FK_tb_recarga_finalizadora_tb_recarga1];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_recarga_tb_recarga_empresa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_recarga] DROP CONSTRAINT [FK_tb_recarga_tb_recarga_empresa];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_reducao_z_itens_tb_reducao_z]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_reducao_z_itens] DROP CONSTRAINT [FK_tb_reducao_z_itens_tb_reducao_z];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_reducao_z_tb_ecf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_reducao_z] DROP CONSTRAINT [FK_tb_reducao_z_tb_ecf];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_Sincronizacao_tb_terminal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_sincronizacao] DROP CONSTRAINT [FK_tb_Sincronizacao_tb_terminal];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_terminal_tb_ecf_modelo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_terminal] DROP CONSTRAINT [FK_tb_terminal_tb_ecf_modelo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_terminal_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_terminal] DROP CONSTRAINT [FK_tb_terminal_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_tipo_nota_tb_cfop]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_tipo_nota] DROP CONSTRAINT [FK_tb_tipo_nota_tb_cfop];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_tipo_nota_tb_financeiro_evento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_tipo_nota] DROP CONSTRAINT [FK_tb_tipo_nota_tb_financeiro_evento];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_tipo_nota_tb_tipo_mvto_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_tipo_nota] DROP CONSTRAINT [FK_tb_tipo_nota_tb_tipo_mvto_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_uf_tb_uf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_uf] DROP CONSTRAINT [FK_tb_uf_tb_uf];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_unid_negocio_tb_cadastro_contador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_unid_negocio] DROP CONSTRAINT [FK_tb_unid_negocio_tb_cadastro_contador];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_unid_negocio_tb_ibge]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_unid_negocio] DROP CONSTRAINT [FK_tb_unid_negocio_tb_ibge];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_unid_negocio_tb_tipo_logradouro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_unid_negocio] DROP CONSTRAINT [FK_tb_unid_negocio_tb_tipo_logradouro];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_unid_negocio_tb_uf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_unid_negocio] DROP CONSTRAINT [FK_tb_unid_negocio_tb_uf];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_usuario_tb_usuario_bloqueio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_usuario] DROP CONSTRAINT [FK_tb_usuario_tb_usuario_bloqueio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_usuario_tb_usuario_dpto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_usuario] DROP CONSTRAINT [FK_tb_usuario_tb_usuario_dpto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_usuario_tb_usuario_grupo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_usuario] DROP CONSTRAINT [FK_tb_usuario_tb_usuario_grupo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_usuario1_tb_usuario_funcao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_usuario] DROP CONSTRAINT [FK_tb_usuario1_tb_usuario_funcao];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_dav_item_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_dav_item] DROP CONSTRAINT [FK_tb_venda_dav_item_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_dav_item_tb_venda_dav_item]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_dav_item] DROP CONSTRAINT [FK_tb_venda_dav_item_tb_venda_dav_item];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_dav_tb_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_dav] DROP CONSTRAINT [FK_tb_venda_dav_tb_cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_dav_tb_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_dav] DROP CONSTRAINT [FK_tb_venda_dav_tb_usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_estorno_tef_tb_venda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_estorno_tef] DROP CONSTRAINT [FK_tb_venda_estorno_tef_tb_venda];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_item_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_item] DROP CONSTRAINT [FK_tb_venda_item_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_pagamento_tb_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_pagamento] DROP CONSTRAINT [FK_tb_venda_pagamento_tb_cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_pagamento_tb_finalizadora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_pagamento] DROP CONSTRAINT [FK_tb_venda_pagamento_tb_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_pagamento_tb_financeiro_bancos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_pagamento] DROP CONSTRAINT [FK_tb_venda_pagamento_tb_financeiro_bancos];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_pagamento_tb_financeiro_prazo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_pagamento] DROP CONSTRAINT [FK_tb_venda_pagamento_tb_financeiro_prazo];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_prevenda_item_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_prevenda_item] DROP CONSTRAINT [FK_tb_venda_prevenda_item_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_prevenda_item_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_prevenda_item] DROP CONSTRAINT [FK_tb_venda_prevenda_item_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_prevenda_item_tb_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_prevenda_item] DROP CONSTRAINT [FK_tb_venda_prevenda_item_tb_usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_prevenda_tb_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_prevenda] DROP CONSTRAINT [FK_tb_venda_prevenda_tb_cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_prevenda_tb_usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda_prevenda] DROP CONSTRAINT [FK_tb_venda_prevenda_tb_usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_tb_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda] DROP CONSTRAINT [FK_tb_venda_tb_cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_tb_cliente_fiscal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda] DROP CONSTRAINT [FK_tb_venda_tb_cliente_fiscal];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_tb_ecf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda] DROP CONSTRAINT [FK_tb_venda_tb_ecf];
GO
IF OBJECT_ID(N'[dbo].[FK_tb_venda_tb_venda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_venda] DROP CONSTRAINT [FK_tb_venda_tb_venda];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_abcfarma_uf_tb_abcfarma]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_abcfarma_uf] DROP CONSTRAINT [FK_tbr_abcfarma_uf_tb_abcfarma];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_abcfarma_uf_tb_abcfarma_periodo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_abcfarma_uf] DROP CONSTRAINT [FK_tbr_abcfarma_uf_tb_abcfarma_periodo];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_abcfarma_uf_tb_uf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_abcfarma_uf] DROP CONSTRAINT [FK_tbr_abcfarma_uf_tb_uf];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_cfop_compra1_tb_mv]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_mvto_compra_cfop_???] DROP CONSTRAINT [FK_tbr_cfop_compra1_tb_mv];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_convenio_cliente_tb_cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_convenio_cliente] DROP CONSTRAINT [FK_tbr_convenio_cliente_tb_cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_convenio_cliente_tb_cliente_bloqueio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_convenio_cliente] DROP CONSTRAINT [FK_tbr_convenio_cliente_tb_cliente_bloqueio];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_convenio_cliente_tb_cliente1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_convenio_cliente] DROP CONSTRAINT [FK_tbr_convenio_cliente_tb_cliente1];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_convenio_cliente_tb_financeiro_prazo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_convenio_cliente] DROP CONSTRAINT [FK_tbr_convenio_cliente_tb_financeiro_prazo];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_convenio_finalizadora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_convenio_finalizadora_sub] DROP CONSTRAINT [FK_tbr_convenio_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_convenio_un1_tb_un]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_convenio_un] DROP CONSTRAINT [FK_tbr_convenio_un1_tb_un];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_convenio_un2_tb_co]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_convenio_un] DROP CONSTRAINT [FK_tbr_convenio_un2_tb_co];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_dicionario_produto_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_dicionario_produto] DROP CONSTRAINT [FK_tbr_dicionario_produto_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_dicionario_produto2729]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_dicionario_produto] DROP CONSTRAINT [FK_tbr_dicionario_produto2729];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_dicionario_un_tb_fornecedor_divisao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_dicionario_un] DROP CONSTRAINT [FK_tbr_dicionario_un_tb_fornecedor_divisao];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_dpto_aplicativo_tb_usuario_dpto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_dpto_aplicativo] DROP CONSTRAINT [FK_tbr_dpto_aplicativo_tb_usuario_dpto];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_ecf_finalizadora_tb_ecf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_ecf_finalizadora] DROP CONSTRAINT [FK_tbr_ecf_finalizadora_tb_ecf];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_ecf_finalizadora_tb_finalizadora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_ecf_finalizadora] DROP CONSTRAINT [FK_tbr_ecf_finalizadora_tb_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_ecf_tributacao_tb_ecf]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_ecf_tributacao] DROP CONSTRAINT [FK_tbr_ecf_tributacao_tb_ecf];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_ecf_tributacao_tb_tributacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_ecf_tributacao] DROP CONSTRAINT [FK_tbr_ecf_tributacao_tb_tributacao];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_finalizadora_sub_u8262]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_finalizadora_sub_un] DROP CONSTRAINT [FK_tbr_finalizadora_sub_u8262];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_finalizadora_sub_un_tb_finalizadora_sub]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_finalizadora_sub_un] DROP CONSTRAINT [FK_tbr_finalizadora_sub_un_tb_finalizadora_sub];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_finalizadora_sub_un_tb_financeiro_banco]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_finalizadora_sub_un] DROP CONSTRAINT [FK_tbr_finalizadora_sub_un_tb_financeiro_banco];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_finalizadora_un1_t4804]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_finalizadora_un] DROP CONSTRAINT [FK_tbr_finalizadora_un1_t4804];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_finalizadora_un2_t3406]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_finalizadora_un] DROP CONSTRAINT [FK_tbr_finalizadora_un2_t3406];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_mvto_compra_cfop_tb_cfop]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_mvto_compra_cfop_???] DROP CONSTRAINT [FK_tbr_mvto_compra_cfop_tb_cfop];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_mvto_compra_fin_tb_mvto_compra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_mvto_compra_dup_???] DROP CONSTRAINT [FK_tbr_mvto_compra_fin_tb_mvto_compra];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_mvto_compra_fin_tb_mvto_compra_fin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_mvto_compra_dup_???] DROP CONSTRAINT [FK_tbr_mvto_compra_fin_tb_mvto_compra_fin];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_mvto_nfe_cfop_tb_cfop]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_nfe_cfop] DROP CONSTRAINT [FK_tbr_mvto_nfe_cfop_tb_cfop];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_parametro_descprod_uneg_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_parametro_descprod_uneg] DROP CONSTRAINT [FK_tbr_parametro_descprod_uneg_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_parametro_descvend_uneg_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_parametro_descvend_uneg] DROP CONSTRAINT [FK_tbr_parametro_descvend_uneg_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_parametro_markup_uneg_tb_parametro_markup]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_parametro_markup_uneg] DROP CONSTRAINT [FK_tbr_parametro_markup_uneg_tb_parametro_markup];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_parametro_markup_uneg_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_parametro_markup_uneg] DROP CONSTRAINT [FK_tbr_parametro_markup_uneg_tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_produto_tributacao_tb_tributacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_produto_tributacao] DROP CONSTRAINT [FK_tbr_produto_tributacao_tb_tributacao];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_produto_tributacao_tb_tributacao1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_produto_tributacao] DROP CONSTRAINT [FK_tbr_produto_tributacao_tb_tributacao1];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_produto_tributacao5334]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_produto_tributacao] DROP CONSTRAINT [FK_tbr_produto_tributacao5334];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_produto_tributacao7747]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_produto_tributacao] DROP CONSTRAINT [FK_tbr_produto_tributacao7747];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_produto_uneg]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_produto_uneg] DROP CONSTRAINT [FK_tbr_produto_uneg];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_produto_uneg_tb_produto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_produto_uneg] DROP CONSTRAINT [FK_tbr_produto_uneg_tb_produto];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_promocao_convenio_tb_convenio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_promocao_convenio] DROP CONSTRAINT [FK_tbr_promocao_convenio_tb_convenio];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_promocao_convenio_tb_promocao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_promocao_convenio] DROP CONSTRAINT [FK_tbr_promocao_convenio_tb_promocao];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_promocao_produto_promocao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_promocao_produto] DROP CONSTRAINT [FK_tbr_promocao_produto_promocao];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_promocao_uneg_tb_promocao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_promocao_uneg] DROP CONSTRAINT [FK_tbr_promocao_uneg_tb_promocao];
GO
IF OBJECT_ID(N'[dbo].[FK_tbr_promocao_uneg_tb_unid_negocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbr_promocao_uneg] DROP CONSTRAINT [FK_tbr_promocao_uneg_tb_unid_negocio];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tb_abcfarma]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_abcfarma];
GO
IF OBJECT_ID(N'[dbo].[tb_abcfarma_periodo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_abcfarma_periodo];
GO
IF OBJECT_ID(N'[dbo].[tb_abertura_caixa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_abertura_caixa];
GO
IF OBJECT_ID(N'[dbo].[tb_agenda_produto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_agenda_produto];
GO
IF OBJECT_ID(N'[dbo].[tb_banco]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_banco];
GO
IF OBJECT_ID(N'[dbo].[tb_cadastro_contador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_cadastro_contador];
GO
IF OBJECT_ID(N'[dbo].[tb_cargo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_cargo];
GO
IF OBJECT_ID(N'[dbo].[tb_ceps]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ceps];
GO
IF OBJECT_ID(N'[dbo].[tb_cfop]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_cfop];
GO
IF OBJECT_ID(N'[dbo].[tb_checkin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_checkin];
GO
IF OBJECT_ID(N'[dbo].[tb_checkin_item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_checkin_item];
GO
IF OBJECT_ID(N'[dbo].[tb_checkin_item_tmp]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_checkin_item_tmp];
GO
IF OBJECT_ID(N'[dbo].[tb_checkin_tmp]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_checkin_tmp];
GO
IF OBJECT_ID(N'[dbo].[tb_checkout]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_checkout];
GO
IF OBJECT_ID(N'[dbo].[tb_checkout_item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_checkout_item];
GO
IF OBJECT_ID(N'[dbo].[tb_cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_cliente];
GO
IF OBJECT_ID(N'[dbo].[tb_cliente_anvisa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_cliente_anvisa];
GO
IF OBJECT_ID(N'[dbo].[tb_cliente_bloqueio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_cliente_bloqueio];
GO
IF OBJECT_ID(N'[dbo].[tb_cliente_endereco]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_cliente_endereco];
GO
IF OBJECT_ID(N'[dbo].[tb_cliente_fiscal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_cliente_fiscal];
GO
IF OBJECT_ID(N'[dbo].[tb_cliente_telefone]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_cliente_telefone];
GO
IF OBJECT_ID(N'[dbo].[tb_conselho]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_conselho];
GO
IF OBJECT_ID(N'[dbo].[tb_conselho_regional]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_conselho_regional];
GO
IF OBJECT_ID(N'[db_lojaModelStoreContainer].[tb_conta]', 'U') IS NOT NULL
    DROP TABLE [db_lojaModelStoreContainer].[tb_conta];
GO
IF OBJECT_ID(N'[dbo].[tb_convenio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_convenio];
GO
IF OBJECT_ID(N'[dbo].[tb_crediario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_crediario];
GO
IF OBJECT_ID(N'[dbo].[tb_crediario_finalizadora]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_crediario_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[tb_crm]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_crm];
GO
IF OBJECT_ID(N'[dbo].[tb_crm_endereco]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_crm_endereco];
GO
IF OBJECT_ID(N'[dbo].[tb_crm_especialidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_crm_especialidade];
GO
IF OBJECT_ID(N'[dbo].[tb_dav]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_dav];
GO
IF OBJECT_ID(N'[dbo].[tb_dav_itens ???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_dav_itens ???];
GO
IF OBJECT_ID(N'[dbo].[tb_ecf]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ecf];
GO
IF OBJECT_ID(N'[dbo].[tb_ecf_dd]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ecf_dd];
GO
IF OBJECT_ID(N'[dbo].[tb_ecf_modelo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ecf_modelo];
GO
IF OBJECT_ID(N'[dbo].[tb_empresa_privatelabel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_empresa_privatelabel];
GO
IF OBJECT_ID(N'[dbo].[tb_empresa_recarga]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_empresa_recarga];
GO
IF OBJECT_ID(N'[dbo].[tb_entrega_arearisco]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_entrega_arearisco];
GO
IF OBJECT_ID(N'[dbo].[tb_entrega_endereco]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_entrega_endereco];
GO
IF OBJECT_ID(N'[dbo].[tb_entrega_polo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_entrega_polo];
GO
IF OBJECT_ID(N'[dbo].[tb_entrega_polo_bairro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_entrega_polo_bairro];
GO
IF OBJECT_ID(N'[dbo].[tb_entrega_prod_continuo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_entrega_prod_continuo];
GO
IF OBJECT_ID(N'[dbo].[tb_entrega_quadrante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_entrega_quadrante];
GO
IF OBJECT_ID(N'[dbo].[tb_entrega_rota]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_entrega_rota];
GO
IF OBJECT_ID(N'[dbo].[tb_entrega_rota_cep]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_entrega_rota_cep];
GO
IF OBJECT_ID(N'[dbo].[tb_finalizadora]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[tb_finalizadora_sub]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_finalizadora_sub];
GO
IF OBJECT_ID(N'[dbo].[tb_financeiro_administradora]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_financeiro_administradora];
GO
IF OBJECT_ID(N'[dbo].[tb_financeiro_bancos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_financeiro_bancos];
GO
IF OBJECT_ID(N'[dbo].[tb_financeiro_evento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_financeiro_evento];
GO
IF OBJECT_ID(N'[dbo].[tb_financeiro_prazo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_financeiro_prazo];
GO
IF OBJECT_ID(N'[dbo].[tb_financeiro_sangria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_financeiro_sangria];
GO
IF OBJECT_ID(N'[dbo].[tb_financeiro_suprimento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_financeiro_suprimento];
GO
IF OBJECT_ID(N'[dbo].[tb_fornecedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_fornecedor];
GO
IF OBJECT_ID(N'[dbo].[tb_fornecedor_divisao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_fornecedor_divisao];
GO
IF OBJECT_ID(N'[dbo].[tb_funcionario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_funcionario];
GO
IF OBJECT_ID(N'[dbo].[tb_funcionario_horario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_funcionario_horario];
GO
IF OBJECT_ID(N'[dbo].[tb_funcionario_horario_item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_funcionario_horario_item];
GO
IF OBJECT_ID(N'[dbo].[tb_funcionario_visitante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_funcionario_visitante];
GO
IF OBJECT_ID(N'[dbo].[tb_hist_sangria_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_hist_sangria_???];
GO
IF OBJECT_ID(N'[dbo].[tb_ibge]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ibge];
GO
IF OBJECT_ID(N'[dbo].[tb_ibpt_ax]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ibpt_ax];
GO
IF OBJECT_ID(N'[dbo].[tb_lancto_financeiro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_lancto_financeiro];
GO
IF OBJECT_ID(N'[dbo].[tb_liquidacao_forma]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_liquidacao_forma];
GO
IF OBJECT_ID(N'[dbo].[tb_liquidacao_motivo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_liquidacao_motivo];
GO
IF OBJECT_ID(N'[dbo].[tb_mvto_compra_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_mvto_compra_???];
GO
IF OBJECT_ID(N'[dbo].[tb_mvto_compra_dup_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_mvto_compra_dup_???];
GO
IF OBJECT_ID(N'[dbo].[tb_mvto_compra_item_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_mvto_compra_item_???];
GO
IF OBJECT_ID(N'[dbo].[tb_mvto_compra_item_divergencia_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_mvto_compra_item_divergencia_???];
GO
IF OBJECT_ID(N'[dbo].[tb_mvto_compra_item_lote_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_mvto_compra_item_lote_???];
GO
IF OBJECT_ID(N'[dbo].[tb_mvto_fin_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_mvto_fin_???];
GO
IF OBJECT_ID(N'[dbo].[tb_nfe]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_nfe];
GO
IF OBJECT_ID(N'[dbo].[tb_nfe_cfop]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_nfe_cfop];
GO
IF OBJECT_ID(N'[dbo].[tb_nfe_danfe]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_nfe_danfe];
GO
IF OBJECT_ID(N'[dbo].[tb_nfe_finalizadora]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_nfe_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[tb_nfe_item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_nfe_item];
GO
IF OBJECT_ID(N'[dbo].[tb_paciente_anvisa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_paciente_anvisa];
GO
IF OBJECT_ID(N'[dbo].[tb_paf_numero]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_paf_numero];
GO
IF OBJECT_ID(N'[dbo].[tb_parametro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_parametro];
GO
IF OBJECT_ID(N'[dbo].[tb_parametro_comissao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_parametro_comissao];
GO
IF OBJECT_ID(N'[dbo].[tb_parametro_descconv]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_parametro_descconv];
GO
IF OBJECT_ID(N'[dbo].[tb_parametro_descmax]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_parametro_descmax];
GO
IF OBJECT_ID(N'[dbo].[tb_parametro_descprod]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_parametro_descprod];
GO
IF OBJECT_ID(N'[dbo].[tb_parametro_descvend]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_parametro_descvend];
GO
IF OBJECT_ID(N'[db_lojaModelStoreContainer].[tb_parametro_limpezas]', 'U') IS NOT NULL
    DROP TABLE [db_lojaModelStoreContainer].[tb_parametro_limpezas];
GO
IF OBJECT_ID(N'[dbo].[tb_parametro_markup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_parametro_markup];
GO
IF OBJECT_ID(N'[dbo].[tb_pbm]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_pbm];
GO
IF OBJECT_ID(N'[dbo].[tb_pedido_compra_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_pedido_compra_???];
GO
IF OBJECT_ID(N'[dbo].[tb_pedido_compra_item_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_pedido_compra_item_???];
GO
IF OBJECT_ID(N'[dbo].[tb_piscofins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_piscofins];
GO
IF OBJECT_ID(N'[dbo].[tb_ponto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ponto];
GO
IF OBJECT_ID(N'[dbo].[tb_ponto_motivo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_ponto_motivo];
GO
IF OBJECT_ID(N'[dbo].[tb_princ_ativo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_princ_ativo];
GO
IF OBJECT_ID(N'[dbo].[tb_privatelabel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_privatelabel];
GO
IF OBJECT_ID(N'[dbo].[tb_privatelabel_finalizadora]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_privatelabel_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[tb_produto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_barra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_barra];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_classe]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_classe];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_fam_categ_sub]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_fam_categ_sub];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_fam_categoria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_fam_categoria];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_fam_grupo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_fam_grupo];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_familia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_familia];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_kit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_kit];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_linha]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_linha];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_piscofins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_piscofins];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_princativo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_princativo];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_receituario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_receituario];
GO
IF OBJECT_ID(N'[dbo].[tb_produto_similaridade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_produto_similaridade];
GO
IF OBJECT_ID(N'[dbo].[tb_promocao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_promocao];
GO
IF OBJECT_ID(N'[dbo].[tb_promocao_tipo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_promocao_tipo];
GO
IF OBJECT_ID(N'[dbo].[tb_recarga]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_recarga];
GO
IF OBJECT_ID(N'[dbo].[tb_recarga_finalizadora]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_recarga_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[tb_reducao_z]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_reducao_z];
GO
IF OBJECT_ID(N'[dbo].[tb_reducao_z_itens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_reducao_z_itens];
GO
IF OBJECT_ID(N'[dbo].[tb_sangrias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_sangrias];
GO
IF OBJECT_ID(N'[dbo].[tb_serie_nota]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_serie_nota];
GO
IF OBJECT_ID(N'[dbo].[tb_sincronizacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_sincronizacao];
GO
IF OBJECT_ID(N'[dbo].[tb_suprimentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_suprimentos];
GO
IF OBJECT_ID(N'[dbo].[tb_terminal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_terminal];
GO
IF OBJECT_ID(N'[dbo].[tb_terminal_mobile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_terminal_mobile];
GO
IF OBJECT_ID(N'[dbo].[tb_tipo_logradouro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_tipo_logradouro];
GO
IF OBJECT_ID(N'[dbo].[tb_tipo_mvto_produto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_tipo_mvto_produto];
GO
IF OBJECT_ID(N'[dbo].[tb_tipo_nota]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_tipo_nota];
GO
IF OBJECT_ID(N'[dbo].[tb_transportadora]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_transportadora];
GO
IF OBJECT_ID(N'[dbo].[tb_tributacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_tributacao];
GO
IF OBJECT_ID(N'[dbo].[tb_uf]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_uf];
GO
IF OBJECT_ID(N'[dbo].[tb_unid_negocio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_unid_negocio];
GO
IF OBJECT_ID(N'[dbo].[tb_unid_negocio_grupo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_unid_negocio_grupo];
GO
IF OBJECT_ID(N'[dbo].[tb_unid_negocio_parametro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_unid_negocio_parametro];
GO
IF OBJECT_ID(N'[dbo].[tb_usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_usuario];
GO
IF OBJECT_ID(N'[dbo].[tb_usuario_bloqueio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_usuario_bloqueio];
GO
IF OBJECT_ID(N'[dbo].[tb_usuario_dpto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_usuario_dpto];
GO
IF OBJECT_ID(N'[dbo].[tb_usuario_funcao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_usuario_funcao];
GO
IF OBJECT_ID(N'[dbo].[tb_usuario_grupo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_usuario_grupo];
GO
IF OBJECT_ID(N'[dbo].[tb_venda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_venda];
GO
IF OBJECT_ID(N'[dbo].[tb_venda_dav]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_venda_dav];
GO
IF OBJECT_ID(N'[dbo].[tb_venda_dav_item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_venda_dav_item];
GO
IF OBJECT_ID(N'[dbo].[tb_venda_estorno_tef]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_venda_estorno_tef];
GO
IF OBJECT_ID(N'[dbo].[tb_venda_item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_venda_item];
GO
IF OBJECT_ID(N'[dbo].[tb_venda_pagamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_venda_pagamento];
GO
IF OBJECT_ID(N'[dbo].[tb_venda_prevenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_venda_prevenda];
GO
IF OBJECT_ID(N'[dbo].[tb_venda_prevenda_item]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_venda_prevenda_item];
GO
IF OBJECT_ID(N'[dbo].[tb_venda_prevenda_pgto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_venda_prevenda_pgto];
GO
IF OBJECT_ID(N'[dbo].[tbManagerUpdate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbManagerUpdate];
GO
IF OBJECT_ID(N'[dbo].[tbr_abcfarma_uf]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_abcfarma_uf];
GO
IF OBJECT_ID(N'[dbo].[tbr_convenio_cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_convenio_cliente];
GO
IF OBJECT_ID(N'[dbo].[tbr_convenio_finalizadora_sub]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_convenio_finalizadora_sub];
GO
IF OBJECT_ID(N'[dbo].[tbr_convenio_un]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_convenio_un];
GO
IF OBJECT_ID(N'[dbo].[tbr_dicionario_produto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_dicionario_produto];
GO
IF OBJECT_ID(N'[dbo].[tbr_dicionario_un]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_dicionario_un];
GO
IF OBJECT_ID(N'[dbo].[tbr_dpto_aplicativo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_dpto_aplicativo];
GO
IF OBJECT_ID(N'[dbo].[tbr_ecf_finalizadora]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_ecf_finalizadora];
GO
IF OBJECT_ID(N'[dbo].[tbr_ecf_tributacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_ecf_tributacao];
GO
IF OBJECT_ID(N'[dbo].[tbr_finalizadora_sub_un]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_finalizadora_sub_un];
GO
IF OBJECT_ID(N'[dbo].[tbr_finalizadora_un]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_finalizadora_un];
GO
IF OBJECT_ID(N'[dbo].[tbr_mvto_compra_cfop_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_mvto_compra_cfop_???];
GO
IF OBJECT_ID(N'[dbo].[tbr_mvto_compra_dup_???]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_mvto_compra_dup_???];
GO
IF OBJECT_ID(N'[dbo].[tbr_parametro_descprod_uneg]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_parametro_descprod_uneg];
GO
IF OBJECT_ID(N'[dbo].[tbr_parametro_descvend_uneg]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_parametro_descvend_uneg];
GO
IF OBJECT_ID(N'[dbo].[tbr_parametro_markup_uneg]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_parametro_markup_uneg];
GO
IF OBJECT_ID(N'[dbo].[tbr_produto_estoque_dia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_produto_estoque_dia];
GO
IF OBJECT_ID(N'[dbo].[tbr_produto_estoque_lote]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_produto_estoque_lote];
GO
IF OBJECT_ID(N'[dbo].[tbr_produto_tributacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_produto_tributacao];
GO
IF OBJECT_ID(N'[dbo].[tbr_produto_uneg]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_produto_uneg];
GO
IF OBJECT_ID(N'[dbo].[tbr_promocao_convenio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_promocao_convenio];
GO
IF OBJECT_ID(N'[dbo].[tbr_promocao_produto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_promocao_produto];
GO
IF OBJECT_ID(N'[dbo].[tbr_promocao_uneg]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbr_promocao_uneg];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tb_abcfarma'
CREATE TABLE [dbo].[tb_abcfarma] (
    [abcf_id] int  NOT NULL,
    [abcf_codigo] decimal(9,0)  NULL,
    [abcf_cd_barra] decimal(14,0)  NULL,
    [abcf_preco_fabrica] decimal(19,4)  NULL,
    [abcf_pmc] decimal(19,4)  NULL,
    [abcf_pmc_fracao] decimal(19,4)  NULL,
    [abcf_descricao1] varchar(50)  NULL,
    [abcf_descricao2] varchar(50)  NULL,
    [abcf_cod_fabricante] decimal(6,0)  NULL,
    [abcf_fabricante] varchar(50)  NULL,
    [abcf_tip_produto] char(1)  NULL,
    [abcf_prod_novo] char(1)  NULL,
    [abcf_generico] char(1)  NULL,
    [abcf_princativo] varchar(80)  NULL,
    [abcf_tip_lista] char(1)  NULL,
    [abcf_qtd_caixa] decimal(3,0)  NULL,
    [abcf_ipi] decimal(19,4)  NULL,
    [abcf_dt_alteracao] datetime  NULL,
    [abcf_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_abcfarma_periodo'
CREATE TABLE [dbo].[tb_abcfarma_periodo] (
    [per_id] int  NOT NULL,
    [per_periodo] varchar(20)  NULL,
    [per_dt_alteracao] datetime  NULL,
    [per_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_abertura_caixa'
CREATE TABLE [dbo].[tb_abertura_caixa] (
    [uneg_id] int  NOT NULL,
    [aberturaCx_usr_id_operador] int  NOT NULL,
    [aberturaCx_dt_abertura] datetime  NOT NULL,
    [aberturaCx_dt_fechamento] datetime  NULL,
    [aberturaCx_usr_id_fechamento] int  NULL,
    [aberturaCx_usr_id_conferente] int  NULL,
    [aberturaCx_dt_conferencia] datetime  NULL,
    [aberturaCx_observacao] varchar(50)  NULL,
    [aberturaCx_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_agenda_produto'
CREATE TABLE [dbo].[tb_agenda_produto] (
    [uneg_id] int  NOT NULL,
    [agen_pdv] int  NOT NULL,
    [agen_id] int IDENTITY(1,1) NOT NULL,
    [agen_dt_agenda] datetime  NOT NULL,
    [pro_id] int  NULL,
    [agen_dt_vencimento] datetime  NULL,
    [agen_dt_start] datetime  NULL,
    [agen_dt_venda] datetime  NULL,
    [agen_status] varchar(1)  NULL,
    [agen_status_data] datetime  NULL,
    [agen_status_obs] varchar(100)  NULL,
    [agen_dt_alteracao] datetime  NULL,
    [agen_qtde_embalagem] int  NULL,
    [agen_atde_compra] int  NULL,
    [agen_tmp_consumo_hora] int  NULL,
    [agen_tmp_consumo_diario] int  NULL,
    [agen_tmp_consumo_dia] int  NULL,
    [agen_tmp_consumo_mes] int  NULL,
    [agen_qtde_consumo] int  NULL,
    [agen_nome_contato] varchar(50)  NULL,
    [agen_tel_residencial] bigint  NULL,
    [agen_tel_comercial] bigint  NULL,
    [agen_tel_celular] bigint  NULL,
    [agen_observacao] varchar(100)  NULL,
    [agen_agendador] int  NULL,
    [agen_vendedor] int  NULL,
    [agen_preco_custo] decimal(19,4)  NULL,
    [agen_preco_venda] decimal(19,4)  NULL,
    [end_telefone] bigint  NULL
);
GO

-- Creating table 'tb_banco'
CREATE TABLE [dbo].[tb_banco] (
    [banco_id] int IDENTITY(1,1) NOT NULL,
    [banco_codigo] decimal(5,0)  NULL,
    [banco_nome] varchar(40)  NULL,
    [banco_tipo] char(1)  NULL,
    [banco_situacao] char(1)  NULL,
    [banco_dt_cadastro] datetime  NULL,
    [banco_dt_alteracao] datetime  NULL,
    [banco_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_cadastro_contador'
CREATE TABLE [dbo].[tb_cadastro_contador] (
    [cadcont_id] int  NOT NULL,
    [cadcont_nome] varchar(50)  NOT NULL,
    [cadcont_cpf] varchar(11)  NOT NULL,
    [cadcont_crc] varchar(15)  NOT NULL,
    [cadcont_email] varchar(50)  NOT NULL,
    [cadcont_status] char(1)  NOT NULL,
    [cadcont_data_modificacao] datetime  NULL,
    [cadcont_escritorio_cnpj] varchar(14)  NULL,
    [cadcont_escritorio_inscricao_estadual] varchar(19)  NULL,
    [cadcont_escritorio_inscricao_municipal] varchar(14)  NULL,
    [cadcont_escritorio_razao_social] varchar(60)  NULL,
    [cadcont_escritorio_nome_fantasia] varchar(60)  NULL,
    [cadcont_escritorio_endereco] varchar(60)  NULL,
    [cadcont_escritorio_numero] varchar(50)  NULL,
    [cadcont_escritorio_complemento] varchar(30)  NULL,
    [cadcont_escritorio_bairro] varchar(30)  NULL,
    [cadcont_escritorio_cep] varchar(8)  NULL,
    [cadcont_escritorio_ddd] int  NULL,
    [cadcont_escritorio_telefone] varchar(13)  NULL,
    [cadcont_escritorio_ddd_fax] int  NULL,
    [cadcont_escritorio_fax] varchar(13)  NULL,
    [cadcont_escritorio_email] varchar(50)  NULL,
    [ibge_codigo] int  NULL
);
GO

-- Creating table 'tb_cargo'
CREATE TABLE [dbo].[tb_cargo] (
    [cargo_id] int  NOT NULL,
    [cargo_descricao] varchar(30)  NULL,
    [cargo_situacao] char(1)  NULL,
    [cargo_dt_cadastro] datetime  NULL,
    [cargo_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_ceps'
CREATE TABLE [dbo].[tb_ceps] (
    [polo_id] int  NOT NULL,
    [quadra_id] int  NOT NULL,
    [rota_id] int  NOT NULL,
    [cep_id] int IDENTITY(1,1) NOT NULL,
    [cep_inicial] decimal(8,0)  NULL,
    [cep_final] decimal(8,0)  NULL,
    [cep_nu_inicial] decimal(5,0)  NULL,
    [cep_nu_final] decimal(5,0)  NULL,
    [cep_situacao] char(1)  NULL,
    [cep_dt_cadastro] datetime  NULL,
    [cep_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_cfop'
CREATE TABLE [dbo].[tb_cfop] (
    [cfop_id] int  NOT NULL,
    [cfop_codigo] decimal(5,0)  NULL,
    [cfop_descricao] varchar(190)  NULL,
    [cfop_situacao] char(1)  NULL,
    [cfop_dt_cadastro] datetime  NULL,
    [cfop_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_checkin'
CREATE TABLE [dbo].[tb_checkin] (
    [uneg_id] int  NOT NULL,
    [chkin_pdv] int  NOT NULL,
    [chkin_id] int  NOT NULL,
    [chkin_data] datetime  NOT NULL,
    [chkin_num_nf] decimal(10,0)  NULL,
    [chkin_operador_id] int  NULL,
    [cmp_id] int  NULL,
    [pedc_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL
);
GO

-- Creating table 'tb_checkin_item'
CREATE TABLE [dbo].[tb_checkin_item] (
    [uneg_id] int  NOT NULL,
    [chkin_pdv] int  NOT NULL,
    [chkin_id] int  NOT NULL,
    [chkin_data] datetime  NOT NULL,
    [ickin_id] int  NOT NULL,
    [pro_id] int  NULL,
    [ickin_cd_barra_lido] decimal(14,0)  NULL,
    [ickin_quantidade] decimal(6,3)  NULL,
    [ickin_nu_lote] varchar(50)  NULL,
    [ickin_val_lote] datetime  NULL,
    [ickin_conciliacao_nf] bit  NULL
);
GO

-- Creating table 'tb_checkin_item_tmp'
CREATE TABLE [dbo].[tb_checkin_item_tmp] (
    [chkin_id] int  NOT NULL,
    [ickin_id] int IDENTITY(1,1) NOT NULL,
    [ickin_quantidade] decimal(6,3)  NULL,
    [ickin_nu_lote] char(10)  NULL,
    [pro_id] int  NULL,
    [ickin_val_lote] datetime  NULL
);
GO

-- Creating table 'tb_checkin_tmp'
CREATE TABLE [dbo].[tb_checkin_tmp] (
    [chkin_id] int IDENTITY(1,1) NOT NULL,
    [chkin_num_nf] decimal(10,0)  NULL,
    [chkin_data] datetime  NULL,
    [chkin_cpf_usuario] decimal(11,0)  NULL,
    [chkin_dt_alteracao] datetime  NULL,
    [uneg_id] int  NULL,
    [pedc_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL
);
GO

-- Creating table 'tb_checkout'
CREATE TABLE [dbo].[tb_checkout] (
    [uneg_id] int  NOT NULL,
    [chkout_pdv] int  NOT NULL,
    [chkout_id] int  NOT NULL,
    [chkout_data] datetime  NOT NULL,
    [chkout_num_nf] decimal(10,0)  NULL,
    [chkout_operador_id] int  NULL,
    [cli_id] int  NULL,
    [pedv_id] int  NULL
);
GO

-- Creating table 'tb_checkout_item'
CREATE TABLE [dbo].[tb_checkout_item] (
    [uneg_id] int  NOT NULL,
    [chkout_pdv] int  NOT NULL,
    [chkout_id] int  NOT NULL,
    [chkout_data] datetime  NOT NULL,
    [ickout_id] int  NOT NULL,
    [pro_id] int  NULL,
    [ickout_cd_barra_lido] decimal(14,0)  NULL,
    [ickout_quantidade] decimal(6,3)  NULL,
    [ickout_nu_lote] varchar(50)  NULL,
    [ickout_val_lote] datetime  NULL,
    [ickout_conciliacao_nf] bit  NULL
);
GO

-- Creating table 'tb_cliente'
CREATE TABLE [dbo].[tb_cliente] (
    [cli_id] bigint  NOT NULL,
    [cli_email] varchar(50)  NULL,
    [cli_limite_compra] decimal(19,4)  NULL,
    [cli_compra_acumulada] decimal(19,4)  NULL,
    [cli_dt_bloqueio] datetime  NULL,
    [cli_qtd_bloqueio] decimal(3,0)  NULL,
    [cli_obs] varchar(max)  NULL,
    [cli_dt_ultima_compra] datetime  NULL,
    [cli_cpf_alteracao] varchar(11)  NULL,
    [cli_tip_pessoa] char(1)  NULL,
    [cli_titular_id] int  NULL,
    [cli_cpf] varchar(11)  NULL,
    [cli_nome] varchar(40)  NULL,
    [cli_id_numero] varchar(11)  NULL,
    [cli_id_orgao_expedidor] varchar(10)  NULL,
    [cli_id_dt_expedicao] datetime  NULL,
    [cli_dt_nascimento] datetime  NULL,
    [cli_sexo] char(1)  NULL,
    [cli_estado_civil] char(1)  NULL,
    [cli_nu_filhos] decimal(2,0)  NULL,
    [cli_nm_pai] varchar(40)  NULL,
    [cli_nm_mae] varchar(40)  NULL,
    [cli_cnpj] varchar(14)  NULL,
    [cli_insc_estadual] decimal(11,0)  NULL,
    [cli_razao_social] varchar(40)  NULL,
    [cli_nome_fantasia] varchar(40)  NULL,
    [cli_cnpj_rede] varchar(14)  NULL,
    [cli_vlr_credito] decimal(19,4)  NULL,
    [cli_polo_distribuidor] decimal(3,0)  NULL,
    [cli_perc_csub] decimal(3,0)  NULL,
    [cli_perc_ssub] decimal(3,0)  NULL,
    [cli_venda_imp_fracionada] bit  NULL,
    [cli_venda_imp_princativo] bit  NULL,
    [cli_nm_contato] varchar(40)  NULL,
    [cli_situacao] char(1)  NULL,
    [cli_dt_cadastro] datetime  NULL,
    [cli_dt_alteracao] datetime  NULL,
    [prm_id] int  NULL,
    [final_id] int  NULL,
    [subfin_id] int  NULL,
    [bloq_id] int  NULL,
    [uneg_id] int  NULL,
    [uf_id] int  NULL
);
GO

-- Creating table 'tb_cliente_anvisa'
CREATE TABLE [dbo].[tb_cliente_anvisa] (
    [cli_anv_num_documento] varchar(20)  NOT NULL,
    [cli_anv_orgao_expedidor] varchar(20)  NOT NULL,
    [cli_anv_nome] varchar(80)  NULL,
    [cli_anv_telefone] varchar(20)  NULL,
    [cli_anv_data_cadastro] datetime  NOT NULL,
    [uf_id] int  NULL,
    [usr_id] int  NOT NULL,
    [uneg_id] int  NOT NULL
);
GO

-- Creating table 'tb_cliente_bloqueio'
CREATE TABLE [dbo].[tb_cliente_bloqueio] (
    [bloq_id] int  NOT NULL,
    [bloq_descricao] varchar(60)  NULL,
    [bloq_tip_acao] decimal(1,0)  NULL,
    [bloq_situacao] char(1)  NULL,
    [bloq_dt_cadastro] datetime  NULL,
    [bloq_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_cliente_endereco'
CREATE TABLE [dbo].[tb_cliente_endereco] (
    [cli_id] bigint  NOT NULL,
    [end_id] int  NOT NULL,
    [end_cep] varchar(8)  NULL,
    [end_tp_logradouro] varchar(50)  NULL,
    [end_nm_logradouro] varchar(60)  NULL,
    [end_numero] int  NULL,
    [end_complemento] varchar(50)  NULL,
    [end_bairro] varchar(50)  NULL,
    [end_cidade] varchar(50)  NULL,
    [end_referencia] varchar(60)  NULL,
    [end_tipo] varchar(50)  NULL,
    [end_situacao] char(1)  NULL,
    [end_dt_cadastro] datetime  NULL,
    [end_dt_alteracao] datetime  NULL,
    [end_cpf_alteracao] varchar(50)  NULL,
    [uf_id] int  NULL
);
GO

-- Creating table 'tb_cliente_fiscal'
CREATE TABLE [dbo].[tb_cliente_fiscal] (
    [cli_fisc_cpf_cnpj] varchar(14)  NOT NULL,
    [cli_fisc_nome] varchar(40)  NULL,
    [cli_fisc_email] varchar(100)  NULL,
    [cli_fisc_endereco] varchar(40)  NULL,
    [cli_fisc_tp_logradouro] varchar(10)  NULL,
    [cli_fisc_numero] int  NULL,
    [cli_fisc_complemento] varchar(50)  NULL,
    [cli_fisc_bairro] varchar(50)  NULL,
    [cli_fisc_cidade] varchar(50)  NULL,
    [cli_fisc_uf] varchar(2)  NULL,
    [cli_fisc_cep] varchar(50)  NULL,
    [cli_fisc_data_cadastro] datetime  NOT NULL,
    [cli_fisc_ibge_codigo] varchar(7)  NULL,
    [usr_id] int  NOT NULL,
    [uneg_id] int  NOT NULL
);
GO

-- Creating table 'tb_cliente_telefone'
CREATE TABLE [dbo].[tb_cliente_telefone] (
    [cli_id] bigint  NOT NULL,
    [tel_id] int  NOT NULL,
    [tel_tipo] decimal(1,0)  NULL,
    [tel_cod_area] decimal(3,0)  NULL,
    [tel_numero] decimal(9,0)  NULL,
    [tel_situacao] char(1)  NULL,
    [tel_dt_cadastro] datetime  NULL,
    [tel_dt_alteracao] datetime  NULL,
    [tel_cpf_alteracao] varchar(50)  NULL
);
GO

-- Creating table 'tb_conselho'
CREATE TABLE [dbo].[tb_conselho] (
    [cs_id] smallint IDENTITY(1,1) NOT NULL,
    [cs_descricao] varchar(40)  NOT NULL
);
GO

-- Creating table 'tb_conselho_regional'
CREATE TABLE [dbo].[tb_conselho_regional] (
    [cr_id] int IDENTITY(1,1) NOT NULL,
    [cr_numero] decimal(10,0)  NOT NULL,
    [cr_nome] varchar(60)  NOT NULL,
    [cr_cons_id] smallint  NOT NULL,
    [cr_cons_uf] char(2)  NOT NULL,
    [cr_especialidade_id] decimal(3,0)  NULL
);
GO

-- Creating table 'tb_conta'
CREATE TABLE [dbo].[tb_conta] (
    [grau_id] int IDENTITY(1,1) NOT NULL,
    [grau_1] char(3)  NOT NULL,
    [grau_2] char(3)  NULL,
    [grau_3] char(3)  NULL,
    [grau_descricao] varchar(40)  NOT NULL
);
GO

-- Creating table 'tb_convenio'
CREATE TABLE [dbo].[tb_convenio] (
    [cnv_id] int  NOT NULL,
    [cnv_titulo] varchar(40)  NULL,
    [cnv_dia_fechamento] decimal(2,0)  NULL,
    [cnv_tipo] decimal(1,0)  NULL,
    [cnv_tipo_pagamento] char(1)  NULL,
    [cnv_situacao] char(1)  NULL,
    [cnv_dt_cadastro] datetime  NULL,
    [cnv_dt_alteracao] datetime  NULL,
    [prazo_id] int  NULL,
    [cli_id] bigint  NULL,
    [cnv_codpbm] int  NULL
);
GO

-- Creating table 'tb_crediario'
CREATE TABLE [dbo].[tb_crediario] (
    [cred_id] int  NOT NULL,
    [cred_dt_entrada] datetime  NULL,
    [cred_dt_vencimento] datetime  NULL,
    [cred_vlr_documento] decimal(19,4)  NULL,
    [cred_vlr_pago] decimal(19,4)  NULL,
    [cred_dt_liquidacao] datetime  NULL,
    [cred_vlr_liquidacao] decimal(19,4)  NULL,
    [cred_desconto_liq] decimal(19,4)  NULL,
    [cred_juros_liq] decimal(19,4)  NULL,
    [cred_taxa_liq] decimal(19,4)  NULL,
    [cred_situacao] varchar(2)  NULL,
    [cred_cpf_cadastro] decimal(11,0)  NULL,
    [cred_dt_alteracao] datetime  NULL,
    [cred_cpf_alteracao] decimal(11,0)  NULL,
    [cnv_id] int  NULL,
    [cli_id] bigint  NULL,
    [uneg_id] int  NULL,
    [venda_pdv] int  NULL,
    [venda_id] int  NULL,
    [venda_data] datetime  NULL,
    [rec_id] int  NOT NULL
);
GO

-- Creating table 'tb_crediario_finalizadora'
CREATE TABLE [dbo].[tb_crediario_finalizadora] (
    [cred_id] int  NOT NULL,
    [uneg_id] int  NOT NULL,
    [venda_pdv] int  NOT NULL,
    [crpgto_id] int  NOT NULL,
    [crpgto_data] datetime  NOT NULL,
    [crpgto_valor] decimal(19,4)  NULL,
    [crpgto_atendente] int  NULL,
    [crpgto_operadorCX] int  NULL,
    [final_id] int  NULL,
    [subfin_id] int  NULL,
    [crpgto_troco] decimal(19,4)  NULL,
    [crpgto_cli_data_ch] datetime  NULL,
    [crpgto_cli_banco_id_ch] int  NULL,
    [crpgto_cli_agencia_ch] decimal(4,0)  NULL,
    [crpgto_cli_c1_ch] decimal(1,0)  NULL,
    [crpgto_cli_conta_corrente_ch] decimal(10,0)  NULL,
    [crpgto_cli_c2_ch] decimal(1,0)  NULL,
    [crpgto_cli_numero_ch] decimal(6,0)  NULL,
    [crpgto_cli_c3_ch] decimal(1,0)  NULL,
    [prazo_id] int  NULL,
    [cheqrec_id] int  NULL,
    [bcaixa_id] int  NULL
);
GO

-- Creating table 'tb_crm'
CREATE TABLE [dbo].[tb_crm] (
    [crm_id] int  NOT NULL,
    [crm_tipo] char(1)  NOT NULL,
    [uf_id] int  NOT NULL,
    [crm_nome] varchar(60)  NULL,
    [crm_crm] varchar(8)  NULL,
    [crm_email] varchar(50)  NULL,
    [crm_sexo] char(1)  NULL,
    [crm_dt_nascimento] datetime  NULL,
    [crm_celular] varchar(15)  NULL,
    [crm_obs] varchar(100)  NULL,
    [crm_situacao] char(1)  NULL,
    [crm_dt_cadastro] datetime  NULL,
    [crm_dt_alteracao] datetime  NULL,
    [crm_cpf_alteracao] varchar(11)  NULL,
    [esp_id] int  NULL
);
GO

-- Creating table 'tb_crm_endereco'
CREATE TABLE [dbo].[tb_crm_endereco] (
    [crm_end_id] int  NOT NULL,
    [crm_id] int  NOT NULL,
    [uf_id] int  NOT NULL,
    [crm_tipo] char(1)  NOT NULL,
    [crm_end_tel] varchar(15)  NULL,
    [crm_end_cep] varchar(8)  NULL,
    [crm_end_tp_logradouro] varchar(50)  NULL,
    [crm_end_nm_logradouro] varchar(60)  NULL,
    [crm_end_numero] int  NULL,
    [crm_end_complemento] varchar(20)  NULL,
    [crm_end_bairro] varchar(50)  NULL,
    [crm_end_referencia] varchar(60)  NULL,
    [crm_end_cidade] varchar(50)  NULL,
    [crm_end_situacao] char(1)  NULL,
    [crm_end_dt_cadastro] datetime  NULL,
    [crm_end_dt_alteracao] datetime  NULL,
    [crm_end_cpf_alteracao] varchar(11)  NULL
);
GO

-- Creating table 'tb_crm_especialidade'
CREATE TABLE [dbo].[tb_crm_especialidade] (
    [esp_id] int  NOT NULL,
    [esp_descricao] varchar(50)  NULL,
    [esp_situacao] char(1)  NULL,
    [esp_dt_cadastro] datetime  NULL,
    [esp_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_dav'
CREATE TABLE [dbo].[tb_dav] (
    [dav_id] int IDENTITY(1,1) NOT NULL,
    [uneg_id] int  NULL,
    [venda_id] int  NULL,
    [venda_pdv] int  NULL,
    [venda_data] datetime  NULL,
    [dav_data] datetime  NOT NULL,
    [dav_data_emissao] datetime  NOT NULL,
    [dav_numero] int  NULL,
    [dav_numero_controle] int  NULL,
    [ecf_numero_serie_emissao] varchar(30)  NOT NULL,
    [dav_coo_emissao] int  NOT NULL,
    [dav_gnf_emissao] int  NOT NULL,
    [dav_cpf_cnpj] varchar(14)  NULL,
    [dav_nome_adquirente] varchar(40)  NULL,
    [dav_num_ecf_venda] int  NULL,
    [dav_coo_venda] int  NULL,
    [dav_coo_cupom_vinculado_venda] int  NULL,
    [dav_titulo] char(1)  NOT NULL,
    [dav_valor_total] decimal(8,2)  NULL,
    [dav_status] char(1)  NULL,
    [ecf_numero_serie_fechamento_cupom] varchar(30)  NULL,
    [dav_md5] varchar(255)  NULL
);
GO

-- Creating table 'tb_dav_itens____'
CREATE TABLE [dbo].[tb_dav_itens____] (
    [davi_id] int IDENTITY(1,1) NOT NULL,
    [dav_id] int  NOT NULL,
    [davi_codigo] varchar(14)  NOT NULL,
    [davi_descricao] varchar(100)  NOT NULL,
    [davi_quantidade] decimal(11,3)  NOT NULL,
    [davi_embalagem] varchar(3)  NOT NULL,
    [davi_valor_unitario] decimal(8,2)  NOT NULL,
    [davi_valor_desconto] decimal(8,2)  NOT NULL,
    [davi_valor_acrescimo] decimal(8,2)  NOT NULL,
    [davi_total_liquido] decimal(14,2)  NOT NULL,
    [davi_situacao_tributaria] char(1)  NOT NULL,
    [davi_aliquota] int  NOT NULL,
    [davi_indicador_cancelamento] char(1)  NOT NULL,
    [davi_decimais_quantidade] int  NOT NULL,
    [davi_decimais_vlr_unitario] int  NOT NULL
);
GO

-- Creating table 'tb_ecf'
CREATE TABLE [dbo].[tb_ecf] (
    [ecf_numero_serie] varchar(30)  NOT NULL,
    [ecf_numero_ecf] int  NOT NULL,
    [ecfm_id_marca] int  NOT NULL,
    [ecfm_id_modelo] int  NOT NULL,
    [ecfm_id_versao] int  NOT NULL,
    [ecf_versao_firmware] varchar(30)  NULL,
    [ecf_data_instalacao_software_basico] datetime  NOT NULL,
    [ecf_numero_usuario_atual] char(2)  NOT NULL,
    [ecf_qtdlinhas_guilhotina] int  NULL,
    [ecf_velocidade_porta] int  NULL,
    [ecf_situacao] char(1)  NULL,
    [ecf_dt_cadastro] datetime  NULL,
    [ecf_dt_alteracao] datetime  NULL,
    [ecf_cpf_alteracao] char(11)  NULL,
    [uneg_id] int  NULL
);
GO

-- Creating table 'tb_ecf_dd'
CREATE TABLE [dbo].[tb_ecf_dd] (
    [ecfd_id] int IDENTITY(1,1) NOT NULL,
    [final_id] int  NULL,
    [ecf_numero_serie] varchar(30)  NOT NULL,
    [ecfd_dt_movimento] datetime  NOT NULL,
    [ecfd_coo] varchar(20)  NOT NULL,
    [ecfd_gnf] varchar(20)  NOT NULL,
    [ecfd_grg] varchar(20)  NOT NULL,
    [ecfd_cdc] varchar(20)  NOT NULL,
    [ecfd_tipo] char(2)  NOT NULL,
    [ecfd_valor_pago] decimal(13,2)  NOT NULL,
    [ecfd_tipos_lancamento] char(1)  NULL
);
GO

-- Creating table 'tb_ecf_modelo'
CREATE TABLE [dbo].[tb_ecf_modelo] (
    [ecfm_id_marca] int  NOT NULL,
    [ecfm_id_modelo] int  NOT NULL,
    [ecfm_id_versao] int  NOT NULL,
    [ecfm_tipo_ecf] varchar(50)  NOT NULL,
    [ecfm_desc_marca] varchar(50)  NOT NULL,
    [ecfm_desc_modelo] varchar(50)  NOT NULL,
    [ecfm_versao] varchar(50)  NOT NULL,
    [ecfm_qtd_lacre_sl] int  NOT NULL,
    [ecfm_qtd_lacre_fab] int  NOT NULL,
    [ecfm_mfd] bit  NOT NULL,
    [ecfm_lacre_mfd] bit  NOT NULL,
    [ecfm_ato_aprovacao] varchar(50)  NOT NULL,
    [ecfm_ato_registro] varchar(50)  NOT NULL,
    [ecfm_formato_num_fabricacao] varchar(50)  NOT NULL,
    [ecfm_dt_cadastro] datetime  NULL,
    [ecfm_dt_alteracao] datetime  NULL,
    [ecfm_cpf_alteracao] varchar(11)  NULL
);
GO

-- Creating table 'tb_empresa_privatelabel'
CREATE TABLE [dbo].[tb_empresa_privatelabel] (
    [emplabel_id] int  NOT NULL,
    [emplabel_nome] varchar(50)  NULL,
    [emplabel_contato] varchar(60)  NULL,
    [emplabel_telefones] varchar(50)  NULL,
    [emplabel_perc_comissao] decimal(19,4)  NULL,
    [emplabel_situacao] char(1)  NULL,
    [emplabel_dt_cadastro] datetime  NULL,
    [emplabel_dt_alteracao] datetime  NULL,
    [emplabel_cpf_alteracao] decimal(11,0)  NULL,
    [prazo_id] int  NOT NULL,
    [fab_id] int  NOT NULL,
    [div_id] int  NOT NULL
);
GO

-- Creating table 'tb_empresa_recarga'
CREATE TABLE [dbo].[tb_empresa_recarga] (
    [emprec_id] int IDENTITY(1,1) NOT NULL,
    [emprec_nome] varchar(50)  NULL,
    [emprec_contato] varchar(60)  NULL,
    [emprec_telefones] varchar(50)  NULL,
    [emprec_perc_comissao] decimal(19,4)  NULL,
    [emprec_situacao] char(1)  NULL,
    [emprec_dt_cadastro] datetime  NULL,
    [emprec_dt_alteracao] datetime  NULL,
    [emprec_cpf_alteracao] decimal(11,0)  NULL,
    [prazo_id] int  NOT NULL,
    [fab_id] int  NOT NULL,
    [div_id] int  NOT NULL
);
GO

-- Creating table 'tb_entrega_arearisco'
CREATE TABLE [dbo].[tb_entrega_arearisco] (
    [arearisco_id] int IDENTITY(1,1) NOT NULL,
    [arearisco_descricao] varchar(50)  NULL,
    [arearisco_cep_inicial] decimal(8,0)  NULL,
    [arearisco_cep_final] decimal(8,0)  NULL,
    [arearisco_nu_inicial] decimal(5,0)  NULL,
    [arearisco_nu_final] decimal(5,0)  NULL,
    [arearisco_mensagem] varchar(60)  NULL,
    [arearisco_acao] decimal(1,0)  NULL,
    [arearisco_situacao] char(1)  NULL,
    [arearisco_dt_cadastro] datetime  NULL,
    [arearisco_dt_alteracao] datetime  NULL,
    [arearisco_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_entrega_endereco'
CREATE TABLE [dbo].[tb_entrega_endereco] (
    [uneg_id] int  NOT NULL,
    [end_pdv] int  NOT NULL,
    [end_id] int  NOT NULL,
    [end_data] datetime  NOT NULL,
    [end_telefone] bigint  NOT NULL,
    [end_cep] int  NULL,
    [end_tp_logradouro] varchar(50)  NULL,
    [end_nm_logradouro] varchar(60)  NULL,
    [end_numero] int  NULL,
    [end_complemento] varchar(50)  NULL,
    [end_bairro] varchar(50)  NULL,
    [end_cidade] varchar(50)  NULL,
    [end_referencia] varchar(60)  NULL,
    [end_tipo] char(1)  NULL,
    [end_latitude_decimais] varchar(20)  NULL,
    [end_longitude_decimais] varchar(20)  NULL,
    [end_situacao] char(1)  NULL,
    [end_dt_cadastro] datetime  NULL,
    [end_dt_alteracao] datetime  NULL,
    [end_cpf_alteracao] varchar(11)  NULL,
    [uf_id] int  NULL,
    [ibge_codigo] bigint  NULL,
    [polo_id] int  NULL,
    [end_contato] varchar(50)  NULL,
    [end_uso_continuo] bit  NULL,
    [end_obs] varchar(max)  NULL,
    [end_dt_ultima_compra] datetime  NULL
);
GO

-- Creating table 'tb_entrega_polo'
CREATE TABLE [dbo].[tb_entrega_polo] (
    [polo_id] int IDENTITY(1,1) NOT NULL,
    [polo_descricao] varchar(50)  NULL,
    [polo_localizacao] varchar(60)  NULL,
    [polo_situacao] char(1)  NULL,
    [polo_dt_cadastro] datetime  NULL,
    [polo_dt_alteracao] datetime  NULL,
    [polo_cpf_alteracao] decimal(11,0)  NULL,
    [uneg_id] int  NULL
);
GO

-- Creating table 'tb_entrega_polo_bairro'
CREATE TABLE [dbo].[tb_entrega_polo_bairro] (
    [bairro_id] int IDENTITY(1,1) NOT NULL,
    [polo_id] int  NOT NULL,
    [bairro_bairro] varchar(50)  NULL,
    [bairro_municipio] varchar(50)  NULL,
    [bairro_estado] varchar(2)  NULL,
    [bairro_situacao] char(1)  NULL,
    [bairro_dt_cadastro] datetime  NULL,
    [bairro_dt_alteracao] datetime  NULL,
    [bairro_cpf_alteracao] decimal(11,0)  NULL,
    [rota_id] int  NULL
);
GO

-- Creating table 'tb_entrega_prod_continuo'
CREATE TABLE [dbo].[tb_entrega_prod_continuo] (
    [uneg_id] int  NOT NULL,
    [end_pdv] int  NOT NULL,
    [end_id] int  NOT NULL,
    [end_data] datetime  NOT NULL,
    [pro_id] int  NOT NULL,
    [proc_dt_ultima_compra] datetime  NULL,
    [proc_qt_ultima_compra] decimal(19,4)  NULL,
    [proc_pr_ultima_compra] decimal(19,4)  NULL
);
GO

-- Creating table 'tb_entrega_quadrante'
CREATE TABLE [dbo].[tb_entrega_quadrante] (
    [quadra_id] int IDENTITY(1,1) NOT NULL,
    [quadra_coordenada] varchar(50)  NULL,
    [quadra_situacao] char(1)  NULL,
    [quadra_dt_cadastro] datetime  NULL,
    [quadra_dt_alteracao] datetime  NULL,
    [quadra_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_entrega_rota'
CREATE TABLE [dbo].[tb_entrega_rota] (
    [rota_id] int IDENTITY(1,1) NOT NULL,
    [quadra_id] int  NOT NULL,
    [rota_descricao] varchar(50)  NULL,
    [rota_situacao] char(1)  NULL,
    [rota_dt_cadastro] datetime  NULL,
    [rota_dt_alteracao] datetime  NULL,
    [rota_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_entrega_rota_cep'
CREATE TABLE [dbo].[tb_entrega_rota_cep] (
    [cep_id] int IDENTITY(1,1) NOT NULL,
    [rota_id] int  NOT NULL,
    [cep_inicial] decimal(8,0)  NULL,
    [cep_final] decimal(8,0)  NULL,
    [cep_nu_inicial] decimal(5,0)  NULL,
    [cep_nu_final] decimal(5,0)  NULL,
    [cep_situacao] char(1)  NULL,
    [cep_dt_cadastro] datetime  NULL,
    [cep_dt_alteracao] datetime  NULL,
    [cep_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_finalizadora'
CREATE TABLE [dbo].[tb_finalizadora] (
    [final_id] int  NOT NULL,
    [final_descricao] varchar(50)  NULL,
    [final_permite_troco] bit  NULL,
    [final_permite_sangria] bit  NULL,
    [final_vlr_sangria_aviso] bigint  NULL,
    [final_vlr_sangria_bloqueio] decimal(19,4)  NULL,
    [final_consulta_cli_tef] bit  NULL,
    [final_venda_tef] bit  NULL,
    [final_obriga_cliente] bit  NULL,
    [final_solicita_dados_ch] bit  NULL,
    [final_tipo_convenio] bit  NULL,
    [final_obriga_autenticacao] bit  NULL,
    [final_tecla_atalho] varchar(50)  NULL,
    [final_db_folha] bit  NULL,
    [final_emite_recibo] int  NULL,
    [final_situacao] char(1)  NULL,
    [final_imagem] varchar(50)  NULL,
    [final_dt_cadastro] datetime  NULL,
    [final_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_finalizadora_sub'
CREATE TABLE [dbo].[tb_finalizadora_sub] (
    [finsub_id] int  NOT NULL,
    [final_id] int  NOT NULL,
    [finsub_descricao] varchar(30)  NULL,
    [finsub_pratica_pmc] bit  NULL,
    [finsub_inibir_desconto] bit  NULL,
    [finsub_desc_maximo] decimal(19,4)  NULL,
    [finsub_tolerancia_dia] decimal(2,0)  NULL,
    [finsub_mora_diaria] decimal(19,4)  NULL,
    [finsub_taxa] decimal(19,4)  NULL,
    [finsub_situacao] char(1)  NULL,
    [finsub_dt_cadastro] datetime  NULL,
    [finsub_dt_alteracao] datetime  NULL,
    [finsub_taxa_evento] int  NULL,
    [finsub_tef_descricao] varchar(30)  NULL,
    [finsub_obriga_supervisor] bit  NULL,
    [finsub_permite_compra_saque] bit  NULL,
    [prazo_id] int  NOT NULL,
    [eventf_id] int  NOT NULL,
    [adm_id] int  NULL
);
GO

-- Creating table 'tb_financeiro_administradora'
CREATE TABLE [dbo].[tb_financeiro_administradora] (
    [adm_id] int  NOT NULL,
    [adm_nome] varchar(30)  NULL,
    [adm_situacao] char(1)  NULL,
    [adm_dt_cadastro] datetime  NULL,
    [adm_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_financeiro_bancos'
CREATE TABLE [dbo].[tb_financeiro_bancos] (
    [banco_id] int  NOT NULL,
    [banco_codigo] decimal(5,0)  NULL,
    [banco_nome] varchar(40)  NULL,
    [banco_tipo] char(1)  NULL,
    [banco_situacao] char(1)  NULL,
    [banco_dt_cadastro] datetime  NULL,
    [banco_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_financeiro_evento'
CREATE TABLE [dbo].[tb_financeiro_evento] (
    [eventf_id] int  NOT NULL,
    [eventf_descricao] varchar(50)  NULL,
    [eventf_tip_lancto] char(1)  NULL,
    [eventf_lanc_manual] bit  NULL,
    [eventf_exportar_uneg] bit  NULL,
    [eventf_situacao] char(1)  NULL,
    [eventf_dt_cadastro] datetime  NULL,
    [eventf_dt_alteracao] datetime  NULL,
    [eventf_cpf_alteracao] varchar(11)  NULL,
    [grau1_id] int  NULL,
    [grau2_id] int  NULL,
    [grau3_id] int  NULL
);
GO

-- Creating table 'tb_financeiro_prazo'
CREATE TABLE [dbo].[tb_financeiro_prazo] (
    [prazo_id] int  NOT NULL,
    [prazo_titulo] varchar(30)  NULL,
    [prazo_tipo] decimal(1,0)  NULL,
    [prazo_qtd_meses] decimal(3,0)  NULL,
    [prazo_qtd_dias] decimal(3,0)  NULL,
    [prazo_fora_a] decimal(2,0)  NULL,
    [prazo_nu_parcelas] decimal(3,0)  NULL,
    [prazo_entrada] bit  NULL,
    [prazo_intervalo_dias] decimal(3,0)  NULL,
    [prazo_nu_retorno_tef] decimal(3,0)  NULL,
    [prazo_inibe_promocao] bit  NULL,
    [prazo_pratica_pmc] bit  NULL,
    [prazo_situacao] char(1)  NULL,
    [prazo_dt_cadastro] datetime  NULL,
    [prazo_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_financeiro_sangria'
CREATE TABLE [dbo].[tb_financeiro_sangria] (
    [sangriaf_id] int IDENTITY(1,1) NOT NULL,
    [sangriaf_data] datetime  NOT NULL,
    [sangriaf_valor] decimal(19,4)  NOT NULL,
    [sangriaf_observacao] varchar(70)  NOT NULL,
    [sangriaf_cpf_responsavel] char(11)  NOT NULL,
    [sangriaf_status] varchar(2)  NULL,
    [sangriaf_cpf_funcionario] char(11)  NOT NULL,
    [sangriaf_dt_alteracao] datetime  NULL,
    [sangriaf_cpf_alteracao] char(11)  NULL,
    [final_id] int  NOT NULL,
    [usr_id] int  NOT NULL,
    [sangriaf_md5] varchar(max)  NOT NULL
);
GO

-- Creating table 'tb_financeiro_suprimento'
CREATE TABLE [dbo].[tb_financeiro_suprimento] (
    [suprimentof_id] int IDENTITY(1,1) NOT NULL,
    [suprimentof_data] datetime  NOT NULL,
    [suprimentof_valor] decimal(19,4)  NOT NULL,
    [suprimentof_observacao] varchar(70)  NOT NULL,
    [suprimentof_cpf_responsavel] varchar(11)  NOT NULL,
    [suprimentof_status] varchar(2)  NULL,
    [suprimentof_cpf_funcionario] varchar(511)  NOT NULL,
    [suprimentof_dt_alteracao] datetime  NULL,
    [suprimentof_cpf_alteracao] varchar(11)  NULL,
    [suprimentof_md5] varchar(max)  NOT NULL,
    [usr_id] int  NOT NULL
);
GO

-- Creating table 'tb_fornecedor'
CREATE TABLE [dbo].[tb_fornecedor] (
    [fab_id] int  NOT NULL,
    [fab_codigo] decimal(6,0)  NULL,
    [fab_razao] varchar(40)  NULL,
    [fab_fantasia] varchar(40)  NULL,
    [fab_fabricante] decimal(1,0)  NULL,
    [fab_tipo] decimal(1,0)  NULL,
    [fab_nm_arq_envio] varchar(60)  NULL,
    [fab_nm_arq_retorno] varchar(60)  NULL,
    [fab_tip_prc_desc] char(1)  NULL,
    [fab_layout_pedido] char(2)  NULL,
    [fab_layout_dicionario] char(2)  NULL,
    [fab_layout_preco] char(2)  NULL,
    [fab_situacao] char(1)  NULL,
    [fab_dt_cadastro] datetime  NULL,
    [fab_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_fornecedor_divisao'
CREATE TABLE [dbo].[tb_fornecedor_divisao] (
    [fab_id] int  NOT NULL,
    [div_id] int  NOT NULL,
    [div_nome] varchar(40)  NULL,
    [div_tip_logradouro] varchar(10)  NULL,
    [div_logradouro] varchar(40)  NULL,
    [div_numero] decimal(6,0)  NULL,
    [div_complemento] varchar(20)  NULL,
    [div_bairro] varchar(25)  NULL,
    [div_cidade] varchar(25)  NULL,
    [div_cod_municipio] decimal(7,0)  NULL,
    [div_cep] varchar(8)  NULL,
    [div_uf] char(2)  NULL,
    [div_ddd] varchar(4)  NULL,
    [div_telefone] varchar(25)  NULL,
    [div_ramal] varchar(5)  NULL,
    [div_fax] varchar(25)  NULL,
    [div_faxramal] varchar(5)  NULL,
    [div_cnpj] varchar(14)  NULL,
    [div_insc_est] decimal(14,0)  NULL,
    [div_nm_represent] varchar(35)  NULL,
    [div_tel_represent] varchar(20)  NULL,
    [div_email_represent] varchar(50)  NULL,
    [div_nm_ger_regional] varchar(35)  NULL,
    [div_tel_ger_regional] varchar(20)  NULL,
    [div_email_ger_regional] varchar(50)  NULL,
    [div_nm_ger_nacional] varchar(35)  NULL,
    [div_tel_ger_nacional] varchar(20)  NULL,
    [div_email_ger_nacional] varchar(50)  NULL,
    [div_tipo_frete] char(1)  NULL,
    [div_cond_pgto] decimal(4,0)  NULL,
    [div_prazo_entrega] decimal(4,0)  NULL,
    [div_pedido_min] decimal(12,2)  NULL,
    [div_freq_compra] decimal(2,0)  NULL,
    [div_situacao] char(1)  NULL,
    [div_dt_cadastro] datetime  NULL,
    [div_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_funcionario'
CREATE TABLE [dbo].[tb_funcionario] (
    [func_id] int  NOT NULL,
    [func_nome] char(40)  NULL,
    [func_matricula] int  NOT NULL,
    [func_filiacao_mae] char(40)  NULL,
    [func_filiacao_pai] char(40)  NULL,
    [func_dt_nascimento] datetime  NULL,
    [func_sexo] char(1)  NULL,
    [func_estado_civil] char(1)  NULL,
    [func_nu_filhos] decimal(2,0)  NULL,
    [func_cpf] char(11)  NULL,
    [func_ident_numero] char(14)  NULL,
    [func_ident_orgao_expedidor] char(12)  NULL,
    [func_ident_dt_expedicao] datetime  NULL,
    [func_ctps] char(15)  NULL,
    [func_ctps_serie] char(15)  NULL,
    [func_pis_pasep] decimal(12,0)  NULL,
    [func_dt_admissao] datetime  NULL,
    [func_dt_demissao] datetime  NULL,
    [func_parente] decimal(1,0)  NULL,
    [func_parente_nome] char(40)  NULL,
    [func_end_cep] char(8)  NULL,
    [func_end_tip_logradouro] char(10)  NULL,
    [func_end_nm_logradouro] char(60)  NULL,
    [func_end_numero] decimal(5,0)  NULL,
    [func_end_complemento] char(20)  NULL,
    [func_end_bairro] char(30)  NULL,
    [func_end_cidade] char(30)  NULL,
    [func_end_uf] char(2)  NULL,
    [func_end_referencia] char(60)  NULL,
    [func_tel_residen_area] decimal(2,0)  NULL,
    [func_tel_residen] decimal(8,0)  NULL,
    [func_tel_celular_area] decimal(2,0)  NULL,
    [func_tel_celular] decimal(8,0)  NULL,
    [func_email] char(50)  NULL,
    [func_escolaridade] decimal(1,0)  NULL,
    [func_cursos] varchar(max)  NULL,
    [func_obs] varchar(max)  NULL,
    [func_ferias_contab_dt_inicial] datetime  NULL,
    [func_ferias_contab_dt_final] datetime  NULL,
    [func_ferias_real_dt_inicial] datetime  NULL,
    [func_ferias_real_dt_final] datetime  NULL,
    [func_cc_agencia] decimal(5,0)  NULL,
    [func_cc_numero] decimal(10,0)  NULL,
    [func_salario] decimal(19,4)  NULL,
    [func_quinzena] decimal(19,4)  NULL,
    [func_deducao_fixa] decimal(19,4)  NULL,
    [func_saldo_devedor] decimal(19,4)  NULL,
    [func_vale_limite] decimal(19,4)  NULL,
    [func_vale_acumulado] decimal(19,4)  NULL,
    [func_biometria_confirm] bit  NULL,
    [func_biometria_image] varbinary(max)  NULL,
    [func_image] varbinary(max)  NULL,
    [func_biometria] varbinary(max)  NULL,
    [func_dt_alteracao_sync] datetime  NULL,
    [func_afastado_dt_inicial] datetime  NULL,
    [func_afastado_dt_final] datetime  NULL,
    [func_situacao] char(1)  NULL,
    [func_dt_cadastro] datetime  NULL,
    [func_dt_alteracao] datetime  NULL,
    [banco_id] int  NULL,
    [cnv_id] int  NULL,
    [cli_id] bigint  NULL,
    [cargo_id] int  NULL,
    [uneg_registro_id] int  NULL,
    [uneg_locacao_id] int  NULL,
    [hora_contab_id] int  NULL,
    [hora_real_id] int  NULL,
    [func_biometria_nao] bit  NULL
);
GO

-- Creating table 'tb_funcionario_horario'
CREATE TABLE [dbo].[tb_funcionario_horario] (
    [hora_id] int  NOT NULL,
    [hora_titulo] char(50)  NULL,
    [hora_desc_dom] bit  NULL,
    [hora_desc_seg] bit  NULL,
    [hora_desc_ter] bit  NULL,
    [hora_desc_qua] bit  NULL,
    [hora_desc_qui] bit  NULL,
    [hora_desc_sex] bit  NULL,
    [hora_desc_sab] bit  NULL,
    [hora_desc_feriado] bit  NULL,
    [hora_situacao] char(1)  NULL,
    [hora_dt_cadastro] datetime  NULL,
    [hora_dt_alteracao] datetime  NULL,
    [hora_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_funcionario_horario_item'
CREATE TABLE [dbo].[tb_funcionario_horario_item] (
    [hora_id] int  NOT NULL,
    [ihora_dia] char(1)  NOT NULL,
    [ihora_entrada] char(5)  NULL,
    [ihora_almoco_saida] char(5)  NULL,
    [ihora_almoco_retorno] char(5)  NULL,
    [ihora_saida] char(5)  NULL,
    [ihora_situacao] char(1)  NULL,
    [ihora_dt_cadastro] datetime  NULL,
    [ihora_dt_alteracao] datetime  NULL,
    [ihora_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_funcionario_visitante'
CREATE TABLE [dbo].[tb_funcionario_visitante] (
    [funcvisit_id] int IDENTITY(1,1) NOT NULL,
    [funcvisit_dt_visita] datetime  NULL,
    [funcvisit_situacao] char(1)  NULL,
    [funcvisit_dt_cadastro] datetime  NULL,
    [funcvisit_dt_alteracao] datetime  NULL,
    [func_id] int  NULL,
    [uneg_id] int  NULL
);
GO

-- Creating table 'tb_hist_sangria____'
CREATE TABLE [dbo].[tb_hist_sangria____] (
    [hsang_id] int IDENTITY(1,1) NOT NULL,
    [hsang_data] datetime  NOT NULL,
    [hsang_cod_caixa] decimal(4,0)  NOT NULL,
    [hsang_fund_dinh] decimal(19,4)  NULL,
    [hsang_sang_dinh] decimal(19,4)  NULL,
    [hsang_sang_cheq] decimal(19,4)  NULL,
    [hsang_sang_cheP] decimal(19,4)  NULL,
    [hsang_sang_carv] decimal(19,4)  NULL,
    [hsang_sang_carp] decimal(19,4)  NULL,
    [hsang_sang_dev] decimal(19,4)  NULL,
    [hsang_sang_canc] decimal(19,4)  NULL,
    [hsang_sang_cext] decimal(19,4)  NULL,
    [hsang_sang_desp] decimal(19,4)  NULL,
    [hsang_sang_conv] decimal(19,4)  NULL,
    [hsang_sang_outr] decimal(19,4)  NULL,
    [hsang_usr_respons] decimal(10,0)  NULL
);
GO

-- Creating table 'tb_ibge'
CREATE TABLE [dbo].[tb_ibge] (
    [ibge_codigo] int  NOT NULL,
    [uf_id] int  NOT NULL,
    [ibge_municipio] varchar(50)  NOT NULL
);
GO

-- Creating table 'tb_ibpt_ax'
CREATE TABLE [dbo].[tb_ibpt_ax] (
    [iax_id] bigint  NOT NULL,
    [iax_tabela] int  NULL,
    [iax_excecoes] int  NULL,
    [iax_ncm] decimal(12,0)  NULL,
    [iax_ncm_descricao_reduz] varchar(max)  NULL,
    [iax_ncm_descricao] varchar(max)  NULL,
    [iax_situacao] char(1)  NULL,
    [iax_data_alteracao] datetime  NULL,
    [iax_aliq_nacional] decimal(6,2)  NULL,
    [iax_aliq_importado] decimal(6,2)  NULL,
    [iax_aliq_estadual] decimal(6,2)  NULL,
    [iax_aliq_municipal] decimal(6,2)  NULL,
    [iax_vigencia_inicio] datetime  NULL,
    [iax_vigencia_fim] datetime  NULL,
    [iax_fonte] varchar(50)  NULL,
    [iax_chave] varchar(50)  NULL,
    [iax_versao] varchar(50)  NULL
);
GO

-- Creating table 'tb_lancto_financeiro'
CREATE TABLE [dbo].[tb_lancto_financeiro] (
    [uneg_id] int  NOT NULL,
    [lanctof_pdv] int  NOT NULL,
    [lanctof_data] datetime  NOT NULL,
    [lanctof_id] int  NOT NULL,
    [lanctof_valor] decimal(19,4)  NULL,
    [lanctof_observacao] varchar(70)  NULL,
    [lanctof_num_documento] decimal(11,0)  NULL,
    [lanctof_responsavel] int  NULL,
    [lanctof_tipo_movimento] char(1)  NULL,
    [lanctof_tipo_operacao] char(1)  NULL,
    [lanctof_funcionario_id] int  NULL,
    [eventf_id] int  NULL,
    [bancocx_id] int  NULL,
    [lanctof_operadorCX] int  NULL,
    [lanctof_md5] nvarchar(max)  NULL
);
GO

-- Creating table 'tb_liquidacao_forma'
CREATE TABLE [dbo].[tb_liquidacao_forma] (
    [formaliq_id] int  NOT NULL,
    [formaliq_descricao] varchar(20)  NULL,
    [formaliq_cpmf] decimal(19,4)  NULL,
    [formaliq_tipo] char(1)  NULL,
    [formaliq_infor_cheque] char(1)  NULL,
    [formaliq_situacao] char(1)  NULL,
    [formaliq_dt_cadastro] datetime  NULL,
    [formaliq_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_liquidacao_motivo'
CREATE TABLE [dbo].[tb_liquidacao_motivo] (
    [motivoliq_id] int  NOT NULL,
    [motivoliq_descricao] varchar(30)  NULL,
    [motivoliq_situacao] char(1)  NULL,
    [motivoliq_dt_cadastro] datetime  NULL,
    [motivoliq_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_mvto_compra____'
CREATE TABLE [dbo].[tb_mvto_compra____] (
    [cmp_id] int IDENTITY(1,1) NOT NULL,
    [cmp_num_nf] decimal(10,0)  NULL,
    [cmp_dt_entrada] datetime  NULL,
    [cmp_dt_emissao] datetime  NULL,
    [cmp_vlr_produtos] decimal(19,4)  NULL,
    [cmp_vlr_nota] decimal(19,4)  NULL,
    [cmp_vlr_informado] decimal(19,4)  NULL,
    [cmp_desc_comercial] decimal(19,4)  NULL,
    [cmp_desc_financeiro] decimal(19,4)  NULL,
    [cmp_vlr_frete] decimal(19,4)  NULL,
    [cmp_vlr_seguro] decimal(19,4)  NULL,
    [cmp_vlr_ipi] decimal(19,4)  NULL,
    [cmp_base_icms_st] decimal(19,4)  NULL,
    [cmp_vlr_icms_st] decimal(19,4)  NULL,
    [cmp_vlr_icms] decimal(19,4)  NULL,
    [cmp_base_icms] decimal(19,4)  NULL,
    [cmp_vlr_repasse] decimal(19,4)  NULL,
    [cmp_vlr_encargos] decimal(19,4)  NULL,
    [cmp_vlr_bonificacao] decimal(19,4)  NULL,
    [cmp_observacao] varchar(max)  NULL,
    [cmp_duplicata] bit  NULL,
    [cmp_qtde_itens] decimal(5,0)  NULL,
    [cmp_cd_operador] decimal(11,0)  NULL,
    [cmp_situacao] char(2)  NULL,
    [cmp_dt_alteracao] datetime  NULL,
    [cmp_cpf_alteracao] decimal(11,0)  NULL,
    [uneg_id] int  NULL,
    [tipnota_id] int  NULL,
    [transp_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL,
    [serient_id] int  NULL,
    [uf_id] int  NULL,
    [chkin_id] int  NULL,
    [prazo_id] int  NULL
);
GO

-- Creating table 'tb_mvto_compra_dup____'
CREATE TABLE [dbo].[tb_mvto_compra_dup____] (
    [cmpdup_id] int IDENTITY(1,1) NOT NULL,
    [cmpdup_numero] int  NULL,
    [cmpdup_vencimento] datetime  NULL,
    [cmpdup_valor] decimal(19,4)  NULL,
    [cmpdup_mora_dia] decimal(19,4)  NULL,
    [cmpdup_taxa] decimal(19,4)  NULL,
    [cmpdup_dt_antecipacao] datetime  NULL,
    [cmpdup_vl_antecipacao] decimal(19,4)  NULL,
    [cmpdup_NossoNumero] bigint  NULL
);
GO

-- Creating table 'tb_mvto_compra_item____'
CREATE TABLE [dbo].[tb_mvto_compra_item____] (
    [cmp_id] int  NOT NULL,
    [icmp_id] int IDENTITY(1,1) NOT NULL,
    [icmp_qtd_checkin] decimal(8,3)  NULL,
    [icmp_qtd_pedida] decimal(8,3)  NULL,
    [icmp_qtd_nota] decimal(8,3)  NULL,
    [icmp_custo_unit_ped] decimal(19,4)  NULL,
    [icmp_custo_unit_prod] decimal(19,4)  NULL,
    [icmp_custo_unit_nota] decimal(19,4)  NULL,
    [icmp_tot_custo_ped] decimal(19,4)  NULL,
    [icmp_tot_custo_prod] decimal(19,4)  NULL,
    [icmp_tot_custo_nota] decimal(19,4)  NULL,
    [icmp_qtd_bonificacao] decimal(8,3)  NULL,
    [icmp_vlr_bonificacao] decimal(19,4)  NULL,
    [icmp_aliq_ipi] decimal(19,4)  NULL,
    [icmp_vlr_ipi] decimal(19,4)  NULL,
    [icmp_base_icms] decimal(19,4)  NULL,
    [icmp_aliq_icms] decimal(19,4)  NULL,
    [icmp_vlr_icms] decimal(19,4)  NULL,
    [icmp_perc_encfin] decimal(19,4)  NULL,
    [icmp_vlr_encfin] decimal(19,4)  NULL,
    [icmp_perc_desconto] decimal(19,4)  NULL,
    [icmp_vlr_desconto] decimal(19,4)  NULL,
    [icmp_mar_icmsst] decimal(19,4)  NULL,
    [icmp_base_icmsst] decimal(19,4)  NULL,
    [icmp_aliq_icmsst] decimal(19,4)  NULL,
    [icmp_vlr_icmsst] decimal(19,4)  NULL,
    [icmp_vlr_frete] decimal(19,4)  NULL,
    [icmp_perc_descfin] decimal(19,4)  NULL,
    [icmp_vlr_descfin] decimal(19,4)  NULL,
    [icmp_perc_repassse] decimal(19,4)  NULL,
    [icmp_vlr_repassse] decimal(19,4)  NULL,
    [icmp_preco_sugerido] decimal(19,4)  NULL,
    [icmp_preco_alterado] decimal(19,4)  NULL,
    [pro_id] int  NULL,
    [cfop_id] int  NULL,
    [icmp_Num_Pedido] int  NULL
);
GO

-- Creating table 'tb_mvto_compra_item_divergencia____'
CREATE TABLE [dbo].[tb_mvto_compra_item_divergencia____] (
    [divicmp_id] int IDENTITY(1,1) NOT NULL,
    [cmp_id] int  NOT NULL,
    [pro_id] int  NOT NULL,
    [divicmp_tipo] char(2)  NOT NULL,
    [divicmp_qtde] decimal(8,0)  NULL,
    [divicmp_custo] decimal(19,4)  NULL,
    [divicmp_justificativa] varchar(max)  NULL
);
GO

-- Creating table 'tb_mvto_compra_item_lote____'
CREATE TABLE [dbo].[tb_mvto_compra_item_lote____] (
    [cmp_id] int  NOT NULL,
    [icmp_id] int  NOT NULL,
    [loteicmp_id] int IDENTITY(1,1) NOT NULL,
    [loteicmp_numero] varchar(20)  NULL,
    [loteicmp_qtde] decimal(8,0)  NULL,
    [loteicmp_validade] datetime  NULL
);
GO

-- Creating table 'tb_mvto_fin____'
CREATE TABLE [dbo].[tb_mvto_fin____] (
    [mvtof_id] int IDENTITY(1,1) NOT NULL,
    [mvtof_data] datetime  NOT NULL,
    [mvtof_cod_caixa] decimal(4,0)  NOT NULL,
    [mvtof_valor] decimal(19,4)  NULL,
    [mvtof_usr_respons] decimal(10,0)  NULL,
    [mvtof_historico] varchar(40)  NULL,
    [mvtof_usr_mat] decimal(10,0)  NULL
);
GO

-- Creating table 'tb_nfe'
CREATE TABLE [dbo].[tb_nfe] (
    [uneg_id] int  NOT NULL,
    [nfe_pdv] int  NOT NULL,
    [nfe_id] int IDENTITY(1,1) NOT NULL,
    [nfe_data] datetime  NOT NULL,
    [nfe_id_vendedor] int  NULL,
    [nfe_id_atendente] int  NULL,
    [nfe_id_cancelado] int  NULL,
    [nfe_chave_acesso] varchar(50)  NULL,
    [nfe_situacao] varchar(2)  NULL,
    [nfe_uf_origem] varchar(2)  NULL,
    [nfe_uf_destino] varchar(2)  NULL,
    [nfe_numero] decimal(10,0)  NULL,
    [nfe_cfop] decimal(5,0)  NULL,
    [nfe_nat_operacao] decimal(4,0)  NULL,
    [nfe_modelo] varchar(2)  NULL,
    [nfe_serie] decimal(3,0)  NULL,
    [nfe_tipo] char(1)  NULL,
    [nfe_cod_municipio] decimal(7,0)  NULL,
    [nfe_data_saida] varchar(10)  NULL,
    [nfe_hora_saida] varchar(8)  NULL,
    [nfe_itens_produto] int  NULL,
    [nfe_qtd_produto] decimal(8,3)  NULL,
    [nfe_total_venda] decimal(19,4)  NULL,
    [nfe_total_venda_padrao] decimal(19,4)  NULL,
    [nfe_total_venda_praticado] decimal(19,4)  NULL,
    [nfe_total_venda_real] decimal(19,4)  NULL,
    [nfe_total_custo] decimal(19,4)  NULL,
    [nfe_total_bonificado] decimal(19,4)  NULL,
    [nfe_total_comissao] decimal(19,4)  NULL,
    [nfe_desc_comercial] decimal(19,4)  NULL,
    [nfe_desc_financeiro] decimal(19,4)  NULL,
    [nfe_icmstot_vbc] decimal(19,4)  NULL,
    [nfe_icmstot_vicms] decimal(19,4)  NULL,
    [nfe_icmstot_vst] decimal(19,4)  NULL,
    [nfe_icmstot_vprod] decimal(19,4)  NULL,
    [nfe_icmstot_vfrete] decimal(19,4)  NULL,
    [nfe_icmstot_vseg] decimal(19,4)  NULL,
    [nfe_icmstot_vdesc] decimal(19,4)  NULL,
    [nfe_icmstot_vii] decimal(19,4)  NULL,
    [nfe_icmstot_vipi] decimal(19,4)  NULL,
    [nfe_icmstot_vpis] decimal(19,4)  NULL,
    [nfe_icmstot_vcofins] decimal(19,4)  NULL,
    [nfe_icmstot_voutros] decimal(19,4)  NULL,
    [nfe_icmstot_vnf] decimal(19,4)  NULL,
    [nfe_vlr_totaltrib] decimal(19,4)  NULL,
    [nfe_issqntot_vserv] decimal(19,4)  NULL,
    [nfe_issqntot_vbc] decimal(19,4)  NULL,
    [nfe_issqntot_viss] decimal(19,4)  NULL,
    [nfe_issqntot_vpis] decimal(19,4)  NULL,
    [nfe_issqntot_vcofins] decimal(19,4)  NULL,
    [nfe_rettrib_vretpis] decimal(19,4)  NULL,
    [nfe_rettrib_vretcofins] decimal(19,4)  NULL,
    [nfe_rettrib_vretcsll] decimal(19,4)  NULL,
    [nfe_rettrib_vbcirrf] decimal(19,4)  NULL,
    [nfe_rettrib_virrf] decimal(19,4)  NULL,
    [nfe_rettrib_vbcretprev] decimal(19,4)  NULL,
    [nfe_rettrib_vretprev] decimal(19,4)  NULL,
    [nfe_vlr_isento] decimal(19,4)  NULL,
    [nfe_nf_obs] varchar(200)  NULL,
    [nfe_tip_frete] char(10)  NULL,
    [nfe_destino] char(1)  NULL,
    [nfe_peso_l] decimal(6,3)  NULL,
    [nfe_peso_b] decimal(6,3)  NULL,
    [nfe_placa_veiculo] varchar(50)  NULL,
    [nfe_transportadora] decimal(2,0)  NULL,
    [nfe_dispositivo] varchar(1)  NULL,
    [nfe_refecf_mod] char(2)  NULL,
    [nfe_refecf_necf] int  NULL,
    [nfe_refecf_coo] int  NULL,
    [transp_id] int  NULL,
    [pedv_id] int  NULL,
    [cli_id] bigint  NULL,
    [cnv_id] int  NULL,
    [serient_id] int  NULL,
    [enft_id] int  NULL,
    [venda_ecf_pdv] int  NULL,
    [venda_ecf_id] int  NULL,
    [venda_ecf_data] datetime  NULL
);
GO

-- Creating table 'tb_nfe_cfop'
CREATE TABLE [dbo].[tb_nfe_cfop] (
    [uneg_id] int  NOT NULL,
    [nfe_pdv] int  NOT NULL,
    [nfe_id] int  NOT NULL,
    [nfe_data] datetime  NOT NULL,
    [cfop_id] int  NOT NULL,
    [cfop_base_icms] decimal(19,4)  NULL,
    [cfop_aliq_icms] decimal(19,4)  NULL,
    [cfop_valor_icms] decimal(19,4)  NULL
);
GO

-- Creating table 'tb_nfe_danfe'
CREATE TABLE [dbo].[tb_nfe_danfe] (
    [uneg_id] int  NOT NULL,
    [nfe_pdv] int  NOT NULL,
    [nfe_id] int  NOT NULL,
    [nfe_data] datetime  NOT NULL,
    [danfe_chave_acesso] varchar(50)  NULL,
    [danfe_xml] nvarchar(max)  NULL,
    [danfe_txt] varchar(max)  NULL
);
GO

-- Creating table 'tb_nfe_finalizadora'
CREATE TABLE [dbo].[tb_nfe_finalizadora] (
    [uneg_id] int  NOT NULL,
    [nfe_pdv] int  NOT NULL,
    [nfe_id] int  NOT NULL,
    [nfe_data] datetime  NOT NULL,
    [final_seq] int IDENTITY(1,1) NOT NULL,
    [final_id] int  NOT NULL,
    [subfin_id] int  NOT NULL,
    [vpag_num_referencia] int  NULL,
    [vpag_valor] decimal(19,4)  NULL,
    [vpag_troco] decimal(19,4)  NULL,
    [vpag_vendatef] bit  NULL,
    [vpag_valor_compra_saque] decimal(19,4)  NULL,
    [vpag_tef_nsu_venda] varchar(13)  NULL,
    [vpag_tef_nsu_host] varchar(13)  NULL,
    [vpag_tipo_cartao] char(1)  NULL,
    [vpag_comprovante_cliente] varchar(max)  NULL,
    [vpag_comprovante_loja] varchar(max)  NULL,
    [vpag_status] varchar(3)  NULL,
    [vpag_cli_data_ch] datetime  NULL,
    [vpag_cli_banco_id_ch] int  NULL,
    [vpag_cli_agencia_ch] decimal(4,0)  NULL,
    [vpag_cli_c1_ch] decimal(1,0)  NULL,
    [vpag_cli_conta_corrente_ch] decimal(10,0)  NULL,
    [vpag_cli_c2_ch] decimal(1,0)  NULL,
    [vpag_cli_numero_ch] decimal(6,0)  NULL,
    [vpag_cli_c3_ch] decimal(1,0)  NULL,
    [vpag_cli_doc_troca] varchar(14)  NULL,
    [prazo_id] int  NULL,
    [cheqrec_id] int  NULL,
    [cli_id] bigint  NULL,
    [boleto_id] int  NULL,
    [bcaixa_id] int  NULL
);
GO

-- Creating table 'tb_nfe_item'
CREATE TABLE [dbo].[tb_nfe_item] (
    [uneg_id] int  NOT NULL,
    [nfe_pdv] int  NOT NULL,
    [nfe_id] int  NOT NULL,
    [nfe_data] datetime  NOT NULL,
    [infe_id] int IDENTITY(1,1) NOT NULL,
    [infe_qtd_checkin] decimal(8,3)  NULL,
    [infe_qtd_pedida] decimal(8,3)  NULL,
    [infe_qtd_nota] decimal(8,3)  NULL,
    [infe_lote_numero] varchar(20)  NULL,
    [infe_lote_validade] datetime  NULL,
    [infe_lote_fabricacao] datetime  NULL,
    [infe_lote_vlr_pmc] decimal(19,4)  NULL,
    [infe_custo_unit_ped] decimal(19,4)  NULL,
    [infe_custo_unit_prod] decimal(19,4)  NULL,
    [infe_custo_unit_nota] decimal(19,4)  NULL,
    [infe_custo_unit_cont] decimal(19,4)  NULL,
    [infe_preco_padrao] decimal(19,4)  NULL,
    [infe_preco_praticado] decimal(19,4)  NULL,
    [infe_custo_medio] decimal(19,4)  NULL,
    [infe_tot_custo_ped] decimal(19,4)  NULL,
    [infe_tot_custo_prod] decimal(19,4)  NULL,
    [infe_tot_custo_nota] decimal(19,4)  NULL,
    [infe_tot_custo_cont] decimal(19,4)  NULL,
    [infe_tot_preco_padrao] decimal(19,4)  NULL,
    [infe_tot_preco_praticado] decimal(19,4)  NULL,
    [infe_tot_custo_medio] decimal(19,4)  NULL,
    [infe_qtd_bonificacao] decimal(8,3)  NULL,
    [infe_vlr_bonificacao] decimal(19,4)  NULL,
    [infe_vlr_encfin] decimal(19,4)  NULL,
    [infe_vlr_desconto] decimal(19,4)  NULL,
    [infe_vlr_frete] decimal(19,4)  NULL,
    [infe_vlr_descfin] decimal(19,4)  NULL,
    [infe_vlr_repassse] decimal(19,4)  NULL,
    [infe_vlr_comissao] decimal(19,4)  NULL,
    [infe_Num_Pedido] int  NULL,
    [infe_icms_orig] int  NULL,
    [infe_icms_cst] int  NULL,
    [infe_icms_modbc] int  NULL,
    [infe_icms_predbc] decimal(19,4)  NULL,
    [infe_icms_vbc] decimal(19,4)  NULL,
    [infe_icms_picms] decimal(19,4)  NULL,
    [infe_icms_vicms] decimal(19,4)  NULL,
    [infe_icms_modbst] int  NULL,
    [infe_icms_pmvast] decimal(19,4)  NULL,
    [infe_icms_predbcst] decimal(19,4)  NULL,
    [infe_icms_vbcst] decimal(19,4)  NULL,
    [infe_icms_picmsst] decimal(19,4)  NULL,
    [infe_icms_vicmsst] decimal(19,4)  NULL,
    [infe_icms_vbstret] decimal(19,4)  NULL,
    [infe_icms_vicmsstret] decimal(19,4)  NULL,
    [infe_qcom] decimal(19,4)  NULL,
    [infe_vuncom] decimal(19,4)  NULL,
    [infe_vprod] decimal(19,4)  NULL,
    [infe_vdesc] decimal(19,4)  NULL,
    [infe_vprodcont] decimal(19,4)  NULL,
    [infe_ipi_cenq] int  NULL,
    [infe_ipi_cst] int  NULL,
    [infe_ipi_pipi] decimal(19,4)  NULL,
    [infe_ipi_vipi] decimal(19,4)  NULL,
    [infe_pis_cst] int  NULL,
    [infe_pis_vbcpis] decimal(19,4)  NULL,
    [infe_pis_ppis] decimal(19,4)  NULL,
    [infe_pis_vpis] decimal(19,4)  NULL,
    [infe_cofins_cst] int  NULL,
    [infe_cofins_vbccofins] decimal(19,4)  NULL,
    [infe_cofins_pcofins] decimal(19,4)  NULL,
    [infe_cofins_vcofiins] decimal(19,4)  NULL,
    [infe_voutro] decimal(19,4)  NULL,
    [infe_vdescfin] decimal(19,4)  NULL,
    [pro_id] int  NULL,
    [cfop_id] int  NULL
);
GO

-- Creating table 'tb_paciente_anvisa'
CREATE TABLE [dbo].[tb_paciente_anvisa] (
    [paciente_id] bigint  NOT NULL,
    [paciente_nome] varchar(50)  NULL,
    [paciente_sexo] char(1)  NULL,
    [paciente_dt_nascimento] datetime  NULL,
    [uf_id] int  NOT NULL,
    [paciente_dt_modific] datetime  NULL
);
GO

-- Creating table 'tb_paf_numero'
CREATE TABLE [dbo].[tb_paf_numero] (
    [paf_ult_pv] varchar(10)  NOT NULL,
    [paf_ult_dav] varchar(10)  NOT NULL
);
GO

-- Creating table 'tb_parametro'
CREATE TABLE [dbo].[tb_parametro] (
    [par_loja] int  NOT NULL,
    [par_pdv] int  NOT NULL,
    [par_msgRodape] varchar(50)  NULL,
    [par_ponto_tempoSeguranca] int  NOT NULL,
    [par_ponto_tempoAprovGerenteEntrada] int  NOT NULL,
    [par_ponto_tempoAprovGerenteAlmoco] int  NOT NULL,
    [par_ponto_tempoAprovGerenteVoltaAlmoco] int  NOT NULL,
    [par_ponto_tempoAprovGerenteSaida] int  NOT NULL,
    [par_ponto_meridianoMinutos] int  NULL
);
GO

-- Creating table 'tb_parametro_comissao'
CREATE TABLE [dbo].[tb_parametro_comissao] (
    [par_id] int  NOT NULL,
    [par_objeto] nchar(1)  NULL,
    [par_tipo] char(1)  NULL,
    [par_situacao] nchar(1)  NULL,
    [par_aplicar] bit  NULL,
    [par_tp_regra] bit  NULL,
    [par_locked] char(1)  NULL,
    [par_dt_cadastro] datetime  NULL,
    [par_dt_alteracao] datetime  NULL,
    [par_cpf_alteracao] varchar(50)  NULL,
    [par_desconto_ate_1] decimal(19,4)  NULL,
    [par_percentual_1] decimal(19,4)  NULL,
    [par_desconto_ate_2] decimal(19,4)  NULL,
    [par_percentual_2] decimal(19,4)  NULL,
    [par_desconto_ate_3] decimal(19,4)  NULL,
    [par_percentual_3] decimal(19,4)  NULL,
    [par_desconto_ate_4] decimal(19,4)  NULL,
    [par_percentual_4] decimal(19,4)  NULL,
    [par_desconto_ate_5] decimal(19,4)  NULL,
    [par_percentual_5] decimal(19,4)  NULL,
    [pro_id] int  NULL,
    [sim_id] int  NULL,
    [cla_id] int  NULL,
    [lin_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL,
    [fam_id] int  NULL,
    [grp_id] int  NULL,
    [cat_id] int  NULL,
    [scat_id] int  NULL,
    [funcao_id] int  NULL,
    [usr_id] int  NULL
);
GO

-- Creating table 'tb_parametro_descconv'
CREATE TABLE [dbo].[tb_parametro_descconv] (
    [par_id] int  NOT NULL,
    [par_objeto] nchar(1)  NOT NULL,
    [par_situacao] nchar(1)  NULL,
    [par_tp_regra] bit  NULL,
    [par_locked] char(1)  NULL,
    [par_dt_cadastro] datetime  NULL,
    [par_dt_alteracao] datetime  NULL,
    [par_cpf_alteracao] decimal(11,0)  NULL,
    [par_app_alteracao] varchar(50)  NULL,
    [par_preco_ate_1] decimal(19,4)  NULL,
    [par_percentual_1] decimal(19,4)  NULL,
    [par_preco_ate_2] decimal(19,4)  NULL,
    [par_percentual_2] decimal(19,4)  NULL,
    [par_preco_ate_3] decimal(19,4)  NULL,
    [par_percentual_3] decimal(19,4)  NULL,
    [par_preco_ate_4] decimal(19,4)  NULL,
    [par_percentual_4] decimal(19,4)  NULL,
    [par_preco_ate_5] decimal(19,4)  NULL,
    [par_percentual_5] decimal(19,4)  NULL,
    [pro_id] int  NULL,
    [sim_id] int  NULL,
    [cla_id] int  NULL,
    [lin_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL,
    [fam_id] int  NULL,
    [grp_id] int  NULL,
    [cat_id] int  NULL,
    [scat_id] int  NULL,
    [cnv_id] int  NULL
);
GO

-- Creating table 'tb_parametro_descmax'
CREATE TABLE [dbo].[tb_parametro_descmax] (
    [par_id] int  NOT NULL,
    [par_objeto] nchar(1)  NULL,
    [par_todos_usuarios] bit  NULL,
    [par_todas_funcoes] bit  NULL,
    [par_desconto_sobre_desconto] bit  NULL,
    [par_preco_ate_1] decimal(19,4)  NULL,
    [par_percentual_1] decimal(19,4)  NULL,
    [par_preco_ate_2] decimal(19,4)  NULL,
    [par_percentual_2] decimal(19,4)  NULL,
    [par_preco_ate_3] decimal(19,4)  NULL,
    [par_percentual_3] decimal(19,4)  NULL,
    [par_preco_ate_4] decimal(19,4)  NULL,
    [par_percentual_4] decimal(19,4)  NULL,
    [par_preco_ate_5] decimal(19,4)  NULL,
    [par_percentual_5] decimal(19,4)  NULL,
    [par_situacao] nchar(1)  NULL,
    [par_dt_cadastro] datetime  NULL,
    [par_dt_alteracao] datetime  NULL,
    [par_md5] nchar(32)  NULL,
    [pro_id] int  NULL,
    [sim_id] int  NULL,
    [cla_id] int  NULL,
    [lin_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL,
    [fam_id] int  NULL,
    [grp_id] int  NULL,
    [cat_id] int  NULL,
    [scat_id] int  NULL
);
GO

-- Creating table 'tb_parametro_descprod'
CREATE TABLE [dbo].[tb_parametro_descprod] (
    [par_id] int  NOT NULL,
    [par_objeto] nchar(1)  NOT NULL,
    [par_situacao] nchar(1)  NULL,
    [par_tp_regra] bit  NULL,
    [par_locked] char(1)  NULL,
    [par_dt_cadastro] datetime  NULL,
    [par_dt_alteracao] datetime  NULL,
    [par_cpf_alteracao] decimal(11,0)  NULL,
    [par_app_alteracao] varchar(50)  NULL,
    [par_preco_ate_1] decimal(19,4)  NULL,
    [par_percentual_1] decimal(19,4)  NULL,
    [par_preco_ate_2] decimal(19,4)  NULL,
    [par_percentual_2] decimal(19,4)  NULL,
    [par_preco_ate_3] decimal(19,4)  NULL,
    [par_percentual_3] decimal(19,4)  NULL,
    [par_preco_ate_4] decimal(19,4)  NULL,
    [par_percentual_4] decimal(19,4)  NULL,
    [par_preco_ate_5] decimal(19,4)  NULL,
    [par_percentual_5] decimal(19,4)  NULL,
    [pro_id] int  NULL,
    [sim_id] int  NULL,
    [cla_id] int  NULL,
    [lin_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL,
    [fam_id] int  NULL,
    [grp_id] int  NULL,
    [cat_id] int  NULL,
    [scat_id] int  NULL
);
GO

-- Creating table 'tb_parametro_descvend'
CREATE TABLE [dbo].[tb_parametro_descvend] (
    [par_id] int  NOT NULL,
    [par_objeto] nchar(1)  NOT NULL,
    [par_desconto_sobre_desconto] bit  NULL,
    [par_situacao] nchar(1)  NULL,
    [par_aplicar] bit  NULL,
    [par_tp_regra] bit  NULL,
    [par_locked] char(1)  NULL,
    [par_dt_cadastro] datetime  NULL,
    [par_dt_alteracao] datetime  NULL,
    [par_cpf_alteracao] decimal(11,0)  NULL,
    [par_app_alteracao] varchar(50)  NULL,
    [par_margem_ate_1] decimal(19,4)  NULL,
    [par_percentual_1] decimal(19,4)  NULL,
    [par_margem_ate_2] decimal(19,4)  NULL,
    [par_percentual_2] decimal(19,4)  NULL,
    [par_margem_ate_3] decimal(19,4)  NULL,
    [par_percentual_3] decimal(19,4)  NULL,
    [par_margem_ate_4] decimal(19,4)  NULL,
    [par_percentual_4] decimal(19,4)  NULL,
    [par_margem_ate_5] decimal(19,4)  NULL,
    [par_percentual_5] decimal(19,4)  NULL,
    [pro_id] int  NULL,
    [sim_id] int  NULL,
    [cla_id] int  NULL,
    [lin_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL,
    [fam_id] int  NULL,
    [grp_id] int  NULL,
    [cat_id] int  NULL,
    [scat_id] int  NULL,
    [funcao_id] int  NULL,
    [usr_id] int  NULL
);
GO

-- Creating table 'tb_parametro_limpezas'
CREATE TABLE [dbo].[tb_parametro_limpezas] (
    [tb_id] int  NOT NULL,
    [tb_dt_alteracao] datetime  NULL,
    [tb_cpf_alteracao] decimal(11,0)  NULL,
    [tb_data_exec] datetime  NULL,
    [LJ_tb_abertura_caixa] int  NULL,
    [LJ_tb_checkin] int  NULL,
    [LJ_tb_checkout] int  NULL,
    [LJ_tb_abcfarma_periodo] int  NULL,
    [LJ_tb_sangrias] int  NULL,
    [LJ_tb_suprimentos] int  NULL,
    [LJ_tb_reducao_z] int  NULL,
    [LJ_tb_venda] int  NULL,
    [LJ_tb_promocao] int  NULL,
    [LJ_tb_ponto] int  NULL,
    [LJ_tb_nfe] int  NULL,
    [LJ_tb_privatelabel] int  NULL,
    [LJ_tb_recarga] int  NULL,
    [LJ_tb_lancto_financeiro] int  NULL,
    [LJ_tb_agenda_produto] int  NULL,
    [LJ_tb_crediario] int  NULL
);
GO

-- Creating table 'tb_parametro_markup'
CREATE TABLE [dbo].[tb_parametro_markup] (
    [par_id] int  NOT NULL,
    [par_objeto] int  NULL,
    [par_situacao] char(1)  NULL,
    [par_tp_regra] bit  NULL,
    [par_dt_cadastro] datetime  NULL,
    [par_dt_alteracao] datetime  NULL,
    [par_cpf_alteracao] varchar(50)  NULL,
    [par_markup] decimal(10,5)  NULL,
    [pro_id] int  NULL,
    [sim_id] int  NULL,
    [cla_id] int  NULL,
    [lin_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL,
    [fam_id] int  NULL,
    [grp_id] int  NULL,
    [cat_id] int  NULL,
    [scat_id] int  NULL
);
GO

-- Creating table 'tb_pbm'
CREATE TABLE [dbo].[tb_pbm] (
    [pbm_id] int IDENTITY(1,1) NOT NULL,
    [pbm_descricao] varchar(30)  NOT NULL
);
GO

-- Creating table 'tb_pedido_compra____'
CREATE TABLE [dbo].[tb_pedido_compra____] (
    [pedc_id] int  NOT NULL,
    [pedc_nu_nf] decimal(6,0)  NULL,
    [pedc_dt_pedido] datetime  NULL,
    [pedc_dt_emissao] datetime  NULL,
    [pedc_dt_vencimento] datetime  NULL,
    [pedc_vlr_total] decimal(19,4)  NULL,
    [pedc_qtd_itens] decimal(5,0)  NULL,
    [pedc_vlr_desconto] decimal(19,4)  NULL,
    [pedc_situacao] char(2)  NULL,
    [uneg_id] int  NULL,
    [ped_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL,
    [pedc_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_pedido_compra_item____'
CREATE TABLE [dbo].[tb_pedido_compra_item____] (
    [pedc_id] int  NOT NULL,
    [ipedc_id] int  NOT NULL,
    [ipedc_qtd_atendida] decimal(6,0)  NULL,
    [ipedv_qtd_embalagem] decimal(3,0)  NULL,
    [ipedc_custo_unitario] decimal(19,4)  NULL,
    [ipedc_perc_desconto] decimal(19,4)  NULL,
    [pro_id] int  NULL,
    [ipedc_situacao] char(2)  NULL
);
GO

-- Creating table 'tb_piscofins'
CREATE TABLE [dbo].[tb_piscofins] (
    [piscofins_id] int  NOT NULL,
    [piscofins_cst] decimal(2,0)  NULL,
    [piscofins_aliq_LP_pis] decimal(19,4)  NULL,
    [piscofins_aliq_LP_cofins] decimal(19,4)  NULL,
    [piscofins_aliq_LR_pis] decimal(19,4)  NULL,
    [piscofins_aliq_LR_cofins] decimal(19,4)  NULL,
    [piscofins_situacao] char(1)  NULL,
    [piscofins_dt_cadastro] datetime  NULL,
    [piscofins_dt_alteracao] datetime  NULL,
    [piscofins_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_ponto'
CREATE TABLE [dbo].[tb_ponto] (
    [ponto_id] int IDENTITY(1,1) NOT NULL,
    [ponto_dt_ponto] datetime  NOT NULL,
    [ponto_hr_entrada] datetime  NULL,
    [ponto_hr_almoco_inicio] datetime  NULL,
    [ponto_hr_almoco_fim] datetime  NULL,
    [ponto_hr_saida] datetime  NULL,
    [func_id] int  NOT NULL,
    [motivo_id] int  NULL,
    [usr_id] int  NULL,
    [ponto_situacao] char(1)  NULL
);
GO

-- Creating table 'tb_ponto_motivo'
CREATE TABLE [dbo].[tb_ponto_motivo] (
    [motivo_id] int  NOT NULL,
    [motivo_descricao] varchar(60)  NOT NULL,
    [motivo_situacao] char(1)  NULL
);
GO

-- Creating table 'tb_princ_ativo'
CREATE TABLE [dbo].[tb_princ_ativo] (
    [pat_id] int IDENTITY(1,1) NOT NULL,
    [pat_descricao] varchar(70)  NOT NULL,
    [pat_dt_alteracao] datetime  NOT NULL
);
GO

-- Creating table 'tb_privatelabel'
CREATE TABLE [dbo].[tb_privatelabel] (
    [uneg_id] int  NOT NULL,
    [plabel_pdv] int  NOT NULL,
    [plabel_data] datetime  NOT NULL,
    [plabel_id] int  NOT NULL,
    [plabel_nsu] varchar(13)  NOT NULL,
    [plabel_nome_rec] varchar(30)  NULL,
    [plabel_tipo_rec] decimal(1,0)  NULL,
    [plabel_tot_rec] decimal(19,4)  NULL,
    [plabel_operado_cx] int  NULL,
    [emplabel_id] int  NOT NULL
);
GO

-- Creating table 'tb_privatelabel_finalizadora'
CREATE TABLE [dbo].[tb_privatelabel_finalizadora] (
    [uneg_id] int  NOT NULL,
    [plabel_pdv] int  NOT NULL,
    [plabel_data] datetime  NOT NULL,
    [plabel_id] int  NOT NULL,
    [vpag_id] nchar(10)  NOT NULL,
    [final_id] int  NOT NULL,
    [subfin_id] int  NOT NULL,
    [vpag_num_referencia] int  NULL,
    [vpag_valor] decimal(19,4)  NOT NULL,
    [vpag_troco] decimal(19,4)  NULL,
    [vpag_vendatef] bit  NULL,
    [vpag_tef_nsu_venda] varchar(13)  NULL,
    [vpag_tef_nsu_host] varchar(13)  NULL,
    [vpag_tipo_cartao] char(1)  NULL,
    [vpag_comprovante_cliente] varchar(max)  NULL,
    [vpag_comprovante_loja] varchar(max)  NULL,
    [vpag_status] varchar(3)  NULL,
    [prazo_id] int  NULL,
    [cli_id] int  NULL,
    [bcaixa_id] int  NULL
);
GO

-- Creating table 'tb_produto'
CREATE TABLE [dbo].[tb_produto] (
    [pro_id] int  NOT NULL,
    [pro_codigo] decimal(6,0)  NULL,
    [pro_descricao] varchar(250)  NULL,
    [pro_nome] varchar(100)  NULL,
    [pro_dosagem] nchar(40)  NULL,
    [pro_qtd_embalagem] decimal(3,0)  NULL,
    [pro_embalagem] varchar(10)  NULL,
    [pro_apresentacao] nchar(40)  NULL,
    [pro_unidade_venda] varchar(50)  NULL,
    [pro_situacao] char(1)  NULL,
    [pro_ipi] decimal(2,0)  NULL,
    [pro_ncm] decimal(8,0)  NULL,
    [pro_tip_etiqueta] decimal(3,0)  NULL,
    [pro_tip_compra] char(1)  NULL,
    [pro_tip_preco] char(1)  NULL,
    [pro_tip_produto] char(1)  NOT NULL,
    [pro_cod_ms] decimal(14,0)  NULL,
    [pro_uso_continuo] bit  NULL,
    [pro_desc_max] decimal(19,4)  NULL,
    [pro_composto] bit  NULL,
    [pro_peso_variavel] bit  NULL,
    [pro_validade_perec] decimal(3,0)  NULL,
    [pro_dt_cadastro] datetime  NULL,
    [pro_dt_alteracao] datetime  NULL,
    [pro_cod_genero] decimal(2,0)  NULL,
    [pro_qtde_m2] decimal(5,4)  NULL,
    [pro_marca_crm] bit  NULL,
    [pro_fracionado] bit  NULL,
    [pro_peso] decimal(19,4)  NULL,
    [pro_pei] decimal(1,0)  NULL,
    [pro_tb_balanca] nchar(1)  NULL,
    [pro_encarte] bit  NULL,
    [pro_cod_dcb] decimal(6,0)  NULL,
    [pro_marca_propaganda] bit  NULL,
    [pro_link_propaganda_1] int  NULL,
    [pro_link_propaganda_2] int  NULL,
    [pro_link_propaganda_3] int  NULL,
    [pro_link_propaganda_4] int  NULL,
    [pro_link_propaganda_5] int  NULL,
    [pro_dados_adicionais] varchar(max)  NULL,
    [pro_lista_icms_medic] char(1)  NULL,
    [pro_mva] decimal(19,4)  NULL,
    [pro_cod_origem] decimal(1,0)  NULL,
    [pro_cod_cst_icms] decimal(2,0)  NULL,
    [pro_cod_csosn_icms] decimal(3,0)  NULL,
    [pro_class_trib_piscofins] char(1)  NULL,
    [pro_cod_cst_piscofins] decimal(2,0)  NULL,
    [sim_id] int  NULL,
    [cla_id] int  NULL,
    [pat_id] int  NULL,
    [lin_id] int  NULL,
    [rec_id] int  NULL,
    [abcf_id] int  NULL,
    [fab_id] int  NULL,
    [div_id] int  NULL,
    [fam_id] int  NULL,
    [grp_id] int  NULL,
    [cat_id] int  NULL,
    [scat_id] int  NULL,
    [piscofins_cod] char(1)  NULL
);
GO

-- Creating table 'tb_produto_barra'
CREATE TABLE [dbo].[tb_produto_barra] (
    [pro_id] int  NOT NULL,
    [barra_codigo] decimal(15,0)  NOT NULL,
    [barra_tip_embalagem] char(3)  NULL,
    [barra_qtd_embalagem] decimal(4,0)  NULL,
    [barra_situacao] char(1)  NULL,
    [barra_dt_cadastro] datetime  NULL,
    [barra_dt_alteracao] datetime  NULL,
    [barra_cpf_alteracao] char(11)  NULL
);
GO

-- Creating table 'tb_produto_classe'
CREATE TABLE [dbo].[tb_produto_classe] (
    [cla_id] int  NOT NULL,
    [cla_descricao] char(25)  NULL,
    [cla_situacao] char(1)  NULL,
    [cla_dt_cadastro] datetime  NULL,
    [cla_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_produto_fam_categ_sub'
CREATE TABLE [dbo].[tb_produto_fam_categ_sub] (
    [fam_id] int  NOT NULL,
    [grp_id] int  NOT NULL,
    [cat_id] int  NOT NULL,
    [scat_id] int  NOT NULL,
    [scat_descricao] char(20)  NULL,
    [scat_situacao] char(1)  NULL,
    [scat_dt_cadastro] datetime  NULL,
    [scat_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_produto_fam_categoria'
CREATE TABLE [dbo].[tb_produto_fam_categoria] (
    [fam_id] int  NOT NULL,
    [grp_id] int  NOT NULL,
    [cat_id] int  NOT NULL,
    [cat_descricao] char(20)  NOT NULL,
    [cat_situacao] char(1)  NULL,
    [cat_dt_cadastro] datetime  NULL,
    [cat_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_produto_fam_grupo'
CREATE TABLE [dbo].[tb_produto_fam_grupo] (
    [fam_id] int  NOT NULL,
    [grp_id] int  NOT NULL,
    [grp_descricao] char(20)  NULL,
    [grp_situacao] char(1)  NULL,
    [grp_dt_cadastro] datetime  NULL,
    [grp_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_produto_familia'
CREATE TABLE [dbo].[tb_produto_familia] (
    [fam_id] int  NOT NULL,
    [fam_descricao] varchar(20)  NULL,
    [fam_situacao] char(1)  NULL,
    [fam_dt_cadastro] datetime  NULL,
    [fam_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_produto_kit'
CREATE TABLE [dbo].[tb_produto_kit] (
    [pro_id] int  NOT NULL,
    [kitpro_produto] int  NOT NULL,
    [kitpro_quantidade] decimal(4,0)  NULL,
    [kitpro_situacao] char(1)  NULL,
    [kitpro_dt_cadastro] datetime  NULL,
    [kitpro_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_produto_linha'
CREATE TABLE [dbo].[tb_produto_linha] (
    [lin_id] int  NOT NULL,
    [lin_descricao] char(50)  NULL,
    [lin_situacao] char(1)  NULL,
    [lin_dt_cadastro] datetime  NULL,
    [lin_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_produto_piscofins'
CREATE TABLE [dbo].[tb_produto_piscofins] (
    [piscofins_cod] char(1)  NOT NULL,
    [piscofins_legenda] char(15)  NULL,
    [piscofins_situacao] char(1)  NULL,
    [piscofins_dt_cadastro] datetime  NULL,
    [piscofins_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_produto_princativo'
CREATE TABLE [dbo].[tb_produto_princativo] (
    [pat_id] int  NOT NULL,
    [pat_descricao] varchar(70)  NULL,
    [pat_situacao] char(1)  NULL,
    [pat_dt_cadastro] datetime  NULL,
    [pat_dt_alteracao] datetime  NULL,
    [pat_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_produto_receituario'
CREATE TABLE [dbo].[tb_produto_receituario] (
    [rec_id] int  NOT NULL,
    [rec_lista] char(2)  NULL,
    [rec_lista_descricao] varchar(60)  NULL,
    [rec_receita_descricao] char(50)  NULL,
    [rec_reter_receita] decimal(1,0)  NULL,
    [rec_situacao] char(1)  NULL,
    [rec_dt_cadastro] datetime  NULL,
    [rec_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_produto_similaridade'
CREATE TABLE [dbo].[tb_produto_similaridade] (
    [sim_id] int  NOT NULL,
    [sim_descricao] char(50)  NULL,
    [sim_situacao] char(1)  NULL,
    [sim_dt_cadastro] datetime  NULL,
    [sim_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_promocao'
CREATE TABLE [dbo].[tb_promocao] (
    [prm_id] int  NOT NULL,
    [prm_observacao] varchar(30)  NULL,
    [prm_dt_inicio] datetime  NULL,
    [prm_dt_fim] datetime  NULL,
    [prm_tip_aplicacao] char(1)  NULL,
    [prm_situacao] char(1)  NULL,
    [prm_dt_cadastro] datetime  NULL,
    [prm_dt_alteracao] datetime  NULL,
    [prm_cpf_alteracao] decimal(11,0)  NULL,
    [tippro_id] int  NULL
);
GO

-- Creating table 'tb_promocao_tipo'
CREATE TABLE [dbo].[tb_promocao_tipo] (
    [tippro_id] int  NOT NULL,
    [tippro_descricao] varchar(30)  NULL,
    [tippro_situacao] char(1)  NULL,
    [tippro_dt_cadastro] datetime  NULL,
    [tippro_dt_alteracao] datetime  NULL,
    [tippro_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_recarga'
CREATE TABLE [dbo].[tb_recarga] (
    [uneg_id] int  NOT NULL,
    [pin_pdv] int  NOT NULL,
    [pin_data] datetime  NOT NULL,
    [pin_id] int  NOT NULL,
    [pin_cod_convenio] varchar(9)  NULL,
    [pin_nome_convenio] varchar(50)  NULL,
    [pin_tipo_credito] varchar(9)  NULL,
    [pin_nome_credito] varchar(50)  NULL,
    [pin_qtde] decimal(9,0)  NULL,
    [pin_preco] decimal(19,4)  NULL,
    [pin_tot_pgto] decimal(19,4)  NULL,
    [pin_ddd] varchar(2)  NULL,
    [pin_telefone] varchar(10)  NULL,
    [pin_operado_cx] int  NULL,
    [emprec_id] int  NOT NULL,
    [pin_ecf] int  NULL,
    [pin_coo] int  NULL,
    [pin_gnf] int  NULL
);
GO

-- Creating table 'tb_recarga_finalizadora'
CREATE TABLE [dbo].[tb_recarga_finalizadora] (
    [uneg_id] int  NOT NULL,
    [pin_pdv] int  NOT NULL,
    [pin_data] datetime  NOT NULL,
    [pin_id] int  NOT NULL,
    [vpag_id] nchar(10)  NOT NULL,
    [final_id] int  NOT NULL,
    [subfin_id] int  NOT NULL,
    [vpag_num_referencia] int  NULL,
    [vpag_valor] decimal(19,4)  NOT NULL,
    [vpag_troco] decimal(19,4)  NULL,
    [vpag_vendatef] bit  NULL,
    [vpag_tef_nsu_venda] varchar(13)  NULL,
    [vpag_tef_nsu_host] varchar(13)  NULL,
    [vpag_tipo_cartao] char(1)  NULL,
    [vpag_comprovante_cliente] varchar(max)  NULL,
    [vpag_comprovante_loja] varchar(max)  NULL,
    [vpag_status] varchar(3)  NULL,
    [cli_id] int  NULL,
    [prazo_id] int  NULL,
    [bcaixa_id] int  NULL
);
GO

-- Creating table 'tb_reducao_z'
CREATE TABLE [dbo].[tb_reducao_z] (
    [ecf_numero_serie] varchar(30)  NOT NULL,
    [reduz_data_movimento] datetime  NOT NULL,
    [reduz_crz] int  NOT NULL,
    [reduz_coo] int  NOT NULL,
    [reduz_cro] int  NOT NULL,
    [reduz_data_emissao] datetime  NOT NULL,
    [reduz_venda_bruta] decimal(18,2)  NOT NULL,
    [reduz_gt] decimal(18,2)  NOT NULL,
    [reduz_md5] varchar(max)  NULL,
    [uneg_id] int  NULL,
    [ecf_id] int  NULL
);
GO

-- Creating table 'tb_reducao_z_itens'
CREATE TABLE [dbo].[tb_reducao_z_itens] (
    [reduz_itens_id] int  NOT NULL,
    [ecf_numero_serie] varchar(30)  NOT NULL,
    [reduz_data_movimento] datetime  NOT NULL,
    [reduz_itens_sequencia] varchar(10)  NULL,
    [reduz_itens_tipo] varchar(10)  NULL,
    [reduz_itens_valor] decimal(18,2)  NULL,
    [reduz_itens_total] decimal(18,2)  NULL,
    [reduz_itens_md5] varchar(max)  NULL
);
GO

-- Creating table 'tb_sangrias'
CREATE TABLE [dbo].[tb_sangrias] (
    [uneg_id] int  NOT NULL,
    [sangriafl_pdv] int  NOT NULL,
    [sangriaf_data] datetime  NOT NULL,
    [sangriaf_id] int  NOT NULL,
    [sangriaf_valor] decimal(19,4)  NULL,
    [sangriaf_operadorCx] int  NULL,
    [sangriaf_observacao] varchar(max)  NULL,
    [sangriaf_responsavel] int  NULL,
    [sangriaf_status] varchar(2)  NULL,
    [sangriaf_funcionario] int  NULL,
    [sangriaf_dt_alteracao] datetime  NULL,
    [sangriaf_cpf_alteracao] varchar(50)  NULL,
    [final_id] int  NULL,
    [sangriaf_md5] varchar(max)  NULL,
    [bcaixa_id] int  NULL
);
GO

-- Creating table 'tb_serie_nota'
CREATE TABLE [dbo].[tb_serie_nota] (
    [serient_id] int  NOT NULL,
    [serient_serie] char(3)  NULL,
    [serient_descricao] char(20)  NULL,
    [serient_situacao] char(1)  NULL,
    [serient_dt_cadastro] datetime  NULL,
    [serient_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_sincronizacao'
CREATE TABLE [dbo].[tb_sincronizacao] (
    [id_sincronizacao] int IDENTITY(1,1) NOT NULL,
    [id_terminal] int  NULL,
    [id_registro] int  NULL,
    [entidade_registro] varchar(50)  NULL,
    [dt_alteracao] datetime  NULL,
    [dt_inclusao] datetime  NULL,
    [status] int  NULL
);
GO

-- Creating table 'tb_suprimentos'
CREATE TABLE [dbo].[tb_suprimentos] (
    [uneg_id] int  NOT NULL,
    [suprimentof_pdv] int  NOT NULL,
    [suprimentof_data] datetime  NOT NULL,
    [suprimentof_id] int  NOT NULL,
    [suprimentof_valor] decimal(19,4)  NOT NULL,
    [suprimentof_operadorCx] int  NOT NULL,
    [suprimentof_observacao] varchar(max)  NOT NULL,
    [suprimentof_responsavel] int  NOT NULL,
    [suprimentof_status] varchar(2)  NULL,
    [suprimentof_funcionario] int  NULL,
    [suprimentof_dt_alteracao] datetime  NULL,
    [suprimentof_cpf_alteracao] varchar(50)  NULL,
    [final_id] int  NULL,
    [suprimentof_md5] varchar(max)  NULL,
    [bcaixa_id] int  NULL
);
GO

-- Creating table 'tb_terminal'
CREATE TABLE [dbo].[tb_terminal] (
    [te_id_terminal] int  NOT NULL,
    [te_nome] varchar(50)  NULL,
    [te_nome_rede] varchar(50)  NULL,
    [te_database] varchar(50)  NULL,
    [te_tipo] varchar(20)  NULL,
    [te_dt_alteracao] datetime  NULL,
    [te_dt_inclusao] datetime  NULL,
    [te_status] char(1)  NULL,
    [te_acbr_ecf_marca] varchar(50)  NULL,
    [te_acbr_ecf_porta] varchar(6)  NULL,
    [te_acbr_ecf_velocidade_porta] int  NULL,
    [te_acbr_ecf_timeout] int  NULL,
    [te_acbr_ecf_intervalo_apos_comando] int  NULL,
    [te_acbr_ecf_controla_gaveta] bit  NULL,
    [te_acbr_ecf_gaveta_sinal_invertido] bit  NULL,
    [te_acbr_ecf_descricao_grande] bit  NULL,
    [te_acbr_caminho_log] varchar(50)  NULL,
    [te_caminho_servidor] varchar(100)  NULL,
    [te_caminho_preVenda] varchar(100)  NULL,
    [uneg_id] int  NULL,
    [ecfm_id_marca] int  NULL,
    [ecfm_id_modelo] int  NULL,
    [ecfm_id_versao] int  NULL,
    [te_balanca] bit  NULL,
    [te_acbr_bal_marca] varchar(50)  NULL,
    [te_acbr_bal_porta] varchar(10)  NULL,
    [te_imprimir_dav] bit  NULL,
    [te_data_ult_imp_srv_web] datetime  NULL,
    [te_data_ult_imp_srv_loja] datetime  NULL,
    [te_data_ult_imp_pdv] datetime  NULL,
    [te_servidor_loja] bit  NULL,
    [te_percentual_importacao] int  NULL,
    [te_nfce] bit  NULL,
    [te_certificado] nvarchar(400)  NULL,
    [te_sat] bit  NULL,
    [te_num_ativacao_aparelho] varchar(50)  NULL,
    [te_ambiente_sefaz] char(1)  NULL,
    [te_drive_rede] char(1)  NULL,
    [te_id_token_sefaz] varchar(50)  NULL,
    [te_token_sefaz] varchar(50)  NULL,
    [te_debug] char(1)  NULL,
    [te_serie_hd] varchar(50)  NULL,
    [te_serie_placa_mae] varchar(50)  NULL,
    [te_terminal_atualizado] bit  NULL,
    [te_serie_nfce] int  NULL,
    [te_numero_nfce] int  NULL,
    [te_aparelho_sat] varchar(100)  NULL
);
GO

-- Creating table 'tb_terminal_mobile'
CREATE TABLE [dbo].[tb_terminal_mobile] (
    [te_mobile_id] int  NOT NULL,
    [te_mobile_mac] varchar(20)  NULL
);
GO

-- Creating table 'tb_tipo_logradouro'
CREATE TABLE [dbo].[tb_tipo_logradouro] (
    [tiplog_id] int IDENTITY(1,1) NOT NULL,
    [tiplog_abreviatura] varchar(10)  NULL,
    [tiplog_descricao] varchar(30)  NULL,
    [tiplog_situacao] char(1)  NULL,
    [tiplog_dt_cadastro] datetime  NULL,
    [tiplog_dt_alteracao] datetime  NULL,
    [tiplog_cpf_alteracao] varchar(11)  NULL
);
GO

-- Creating table 'tb_tipo_mvto_produto'
CREATE TABLE [dbo].[tb_tipo_mvto_produto] (
    [cdmvto_codigo] int  NOT NULL,
    [cdmvto_descricao] varchar(30)  NULL,
    [cdmvto_tipo] char(1)  NULL,
    [cdmvto_lanc_manual] bit  NULL,
    [cdmvto_cd_anvisa] char(1)  NULL,
    [cdmvto_situacao] char(1)  NULL,
    [cdmvto_dt_cadastro] datetime  NULL,
    [cdmvto_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_tipo_nota'
CREATE TABLE [dbo].[tb_tipo_nota] (
    [tipnota_id] int  NOT NULL,
    [tipnota_descricao] nchar(60)  NULL,
    [tipnota_tipo] nchar(1)  NULL,
    [tipnota_bonificado_alt_custo] bit  NULL,
    [tipnota_tipo_aplicacao_financ] nchar(1)  NULL,
    [tipnota_romaneio] bit  NULL,
    [tipnota_obrigar_checkin] bit  NULL,
    [tipnota_obrigar_icms] bit  NULL,
    [tipnota_permitir_alterar_dic] bit  NULL,
    [tipnota_aplicar_preco_rede] bit  NULL,
    [tipnota_desprezar_sngpc] bit  NULL,
    [tipnota_nf_contabil] bit  NULL,
    [tipnota_ac_qtde_prod_fora_ped] decimal(3,0)  NULL,
    [tipnota_acao_custo_maior_vend] nchar(1)  NULL,
    [tipnota_acao_alterar_prec_vend] nchar(1)  NULL,
    [tipnota_obrigar_pedido_compra] bit  NULL,
    [tipnota_limite_acert_dif_fech] decimal(19,4)  NULL,
    [tipnota_ignora_justif_diverg] bit  NULL,
    [tipnota_situacao] nchar(1)  NULL,
    [tipnota_dt_cadastro] datetime  NULL,
    [tipnota_dt_alteracao] datetime  NULL,
    [cfop_id] int  NULL,
    [cdmvto_codigo] int  NULL,
    [eventf_id] int  NULL
);
GO

-- Creating table 'tb_transportadora'
CREATE TABLE [dbo].[tb_transportadora] (
    [transp_id] int  NOT NULL,
    [transp_nome] char(40)  NULL,
    [transp_situacao] char(1)  NULL,
    [transp_dt_cadastro] datetime  NULL,
    [transp_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_tributacao'
CREATE TABLE [dbo].[tb_tributacao] (
    [trb_id] int  NOT NULL,
    [trb_aliquota] decimal(19,4)  NULL,
    [trb_servico] bit  NULL,
    [trb_subst_trib] bit  NULL,
    [trb_situacao] char(1)  NULL,
    [trb_dt_cadastro] datetime  NULL,
    [trb_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_uf'
CREATE TABLE [dbo].[tb_uf] (
    [uf_id] int  NOT NULL,
    [uf_sigla] char(2)  NULL,
    [uf_descricao] char(20)  NULL,
    [uf_situacao] char(1)  NULL,
    [uf_dt_cadastro] datetime  NULL,
    [uf_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_unid_negocio'
CREATE TABLE [dbo].[tb_unid_negocio] (
    [uneg_id] int  NOT NULL,
    [uneg_numero] decimal(3,0)  NULL,
    [uneg_cnpj] varchar(14)  NULL,
    [uneg_nome] varchar(60)  NULL,
    [uneg_razao_social] varchar(60)  NULL,
    [uneg_fantasia] varchar(60)  NULL,
    [uneg_inscricao_estadual] varchar(19)  NULL,
    [uneg_inscricao_municipal] varchar(14)  NULL,
    [uneg_situacao] char(1)  NULL,
    [uneg_loja] varchar(50)  NULL,
    [uneg_cnpj_local] bit  NULL,
    [uneg_obriga_justif_diverg] bit  NULL,
    [ibge_codigo] int  NOT NULL,
    [uneg_epp] bit  NOT NULL,
    [uneg_img_logo] varbinary(max)  NULL,
    [uf_id] int  NULL,
    [uneg_dt_cadastro] datetime  NULL,
    [uneg_dt_alteracao] datetime  NULL,
    [uneg_cep] varchar(8)  NULL,
    [uneg_tip_logradouro] int  NULL,
    [uneg_logradouro] varchar(60)  NULL,
    [uneg_endereco_numero] varchar(10)  NULL,
    [uneg_complemento] varchar(30)  NULL,
    [uneg_bairro] varchar(20)  NULL,
    [uneg_municipio] varchar(25)  NULL,
    [uneg_telefones] varchar(30)  NULL,
    [uneg_fax] varchar(50)  NULL,
    [uneg_email] varchar(50)  NULL,
    [uneg_regime] char(1)  NULL,
    [uneg_nfe_automacao] varchar(10)  NULL,
    [uneg_fid_login] varchar(10)  NULL,
    [uneg_fid_senha] varchar(10)  NULL,
    [uneg_cod_regime_fat] char(2)  NULL,
    [uneg_cli_asafisco] char(1)  NULL,
    [uneg_cli_ifarma] char(1)  NULL,
    [uneg_vazio] varchar(45)  NULL,
    [uneg_versao_banco] varchar(10)  NULL,
    [uneg_tef_idLoja] char(8)  NULL,
    [uneg_tef_IP] varchar(max)  NULL,
    [cadcont_id] int  NOT NULL
);
GO

-- Creating table 'tb_unid_negocio_grupo'
CREATE TABLE [dbo].[tb_unid_negocio_grupo] (
    [guneg_id] int IDENTITY(1,1) NOT NULL,
    [guneg_descricao] char(40)  NULL,
    [guneg_situacao] char(1)  NULL,
    [guneg_dt_cadastro] datetime  NULL,
    [guneg_dt_alteracao] datetime  NULL,
    [guneg_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tb_unid_negocio_parametro'
CREATE TABLE [dbo].[tb_unid_negocio_parametro] (
    [uneg_id] int  NOT NULL,
    [par_msg_rodape] varchar(50)  NULL,
    [par_ponto_tmp_seguranca] int  NULL,
    [par_ponto_tmp_apv_entrada] int  NULL,
    [par_ponto_tmp_apv_almoco_said] int  NULL,
    [par_ponto_tmp_apv_almoco_ret] int  NULL,
    [par_ponto_tmp_apv_saida] int  NULL,
    [par_ponto_meridiano_minutos] int  NULL,
    [par_dt_alteracao] datetime  NULL,
    [par_obriga_justif_diverg] bit  NULL,
    [par_obriga_anvisa] bit  NULL,
    [par_obriga_comanda] char(1)  NOT NULL,
    [par_tef_IdLoja] char(8)  NULL,
    [par_tef_IP] varchar(max)  NULL,
    [par_incluir_item_preVenda] bit  NULL,
    [par_vende_item_pdv] bit  NULL,
    [par_metodo_resgate_preVenda] int  NULL,
    [par_venda_item_sem_cod_barra] varchar(10)  NULL,
    [par_qtd_maxima_item] int  NULL,
    [par_permite_qtd_fracionada] bit  NULL,
    [par_etiqueta_peso] bit  NULL,
    [par_altera_finalizadora_preVenda] bit  NULL,
    [par_msg_livre_rodape_cupom_01] varchar(50)  NULL,
    [par_msg_livre_rodape_cupom_02] varchar(50)  NULL,
    [par_msg_livre_rodape_cupom_03] varchar(50)  NULL,
    [par_msg_livre_rodape_cupom_04] varchar(50)  NULL,
    [par_sistema_externo] char(1)  NOT NULL,
    [par_sistema_externo_ip_servidor] varchar(15)  NULL,
    [par_sistema_externo_caminho_banco] varchar(50)  NULL,
    [par_multi_vendedor] bit  NOT NULL,
    [par_tem_preVenda] bit  NULL,
    [par_tem_dav] bit  NULL,
    [par_aplica_desconto_cadastro] char(2)  NOT NULL,
    [par_balcao_old] bit  NULL,
    [par_controle_lote] char(1)  NULL,
    [par_data_ult_exp_cobol] datetime  NULL,
    [par_mobile_dav] bit  NULL
);
GO

-- Creating table 'tb_usuario'
CREATE TABLE [dbo].[tb_usuario] (
    [usr_id] int  NOT NULL,
    [usr_cpf] varchar(11)  NULL,
    [usr_nome] varchar(40)  NULL,
    [usr_apelido] varchar(40)  NULL,
    [usr_senha_local] varchar(15)  NULL,
    [usr_senha_tmp] datetime  NULL,
    [usr_dt_alteracao_sync] datetime  NULL,
    [usr_situacao] char(1)  NULL,
    [usr_blq_dt_inicial] datetime  NULL,
    [usr_blq_dt_final] datetime  NULL,
    [usr_dt_cadastro] datetime  NULL,
    [usr_dt_alteracao] datetime  NULL,
    [usr_online] bit  NULL,
    [grp_id] int  NULL,
    [dpto_id] int  NULL,
    [funcao_id] int  NULL,
    [bloq_id] int  NULL,
    [func_id] int  NULL
);
GO

-- Creating table 'tb_usuario_bloqueio'
CREATE TABLE [dbo].[tb_usuario_bloqueio] (
    [bloq_id] int  NOT NULL,
    [bloq_descricao] varchar(60)  NULL,
    [bloq_situacao] char(1)  NULL,
    [bloq_dt_cadastro] datetime  NULL,
    [bloq_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_usuario_dpto'
CREATE TABLE [dbo].[tb_usuario_dpto] (
    [dpto_id] int  NOT NULL,
    [dpto_nome] varchar(30)  NULL,
    [dpto_situacao] char(1)  NULL,
    [dpto_dt_cadastro] datetime  NULL,
    [dpto_dt_alteracao] datetime  NULL,
    [dpto_cpf_alteracao] decimal(11,0)  NULL,
    [dpto_apl_planilha] bit  NULL,
    [dpto_apl_checkin] bit  NULL,
    [dpto_apl_entrada_nf] bit  NULL,
    [dpto_apl_consulta_preco] bit  NULL,
    [dpto_apl_alteracao_preco] bit  NULL,
    [dpto_apl_vnd_balcao] bit  NULL,
    [dpto_apl_pdv] bit  NULL,
    [dpto_apl_vnd_callcenter] bit  NULL,
    [dpto_apl_supervisor_callcenter] bit  NULL,
    [dpto_apl_etiquetas_loja] bit  NULL,
    [dpto_apl_vnd_atacado] bit  NULL,
    [dpto_apl_checkout_atacado] bit  NULL,
    [dpto_apl_fat_atacado] bit  NULL,
    [dpto_apl_etiquetas_atacado] bit  NULL,
    [dpto_apl_supervisor_atacado] bit  NULL
);
GO

-- Creating table 'tb_usuario_funcao'
CREATE TABLE [dbo].[tb_usuario_funcao] (
    [funcao_id] int  NOT NULL,
    [funcao_descricao] char(30)  NULL,
    [funcao_param_lj_ponto] bit  NULL,
    [funcao_situacao] char(1)  NULL,
    [funcao_cancela_venda] bit  NULL,
    [funcao_cancela_vendaItem] bit  NULL,
    [funcao_desconto_vendaItem] bit  NULL,
    [funcao_desconto_venda] bit  NULL,
    [funcao_gerenciar_ponto] bit  NULL,
    [funcao_reiniciar_setup] bit  NULL,
    [funcao_menu_gerencial] bit  NULL,
    [funcao_fundo_caixa] bit  NULL,
    [funcao_sangria] bit  NULL,
    [funcao_despesa] bit  NULL,
    [funcao_dt_cadastro] datetime  NULL,
    [funcao_dt_alteracao] datetime  NULL,
    [funcao_vendaItem_semCodBarra] bit  NULL,
    [funcao_libera_lote] bit  NULL,
    [funcao_limite_desconto] decimal(19,4)  NULL
);
GO

-- Creating table 'tb_usuario_grupo'
CREATE TABLE [dbo].[tb_usuario_grupo] (
    [grp_id] int  NOT NULL,
    [grp_nome] varchar(40)  NULL,
    [grp_diautil] varchar(54)  NULL,
    [grp_sabado] varchar(54)  NULL,
    [grp_domingo] varchar(54)  NULL,
    [grp_feriado] varchar(54)  NULL,
    [grp_tmp_senha] decimal(3,0)  NULL,
    [grp_acesso_filial_ilimitada] bit  NULL,
    [grp_situacao] char(1)  NULL,
    [grp_dt_cadastro] datetime  NULL,
    [grp_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tb_venda'
CREATE TABLE [dbo].[tb_venda] (
    [venda_id] int  NOT NULL,
    [uneg_id] int  NOT NULL,
    [venda_pdv] int  NOT NULL,
    [venda_data] datetime  NOT NULL,
    [ecf_numero_serie] varchar(30)  NOT NULL,
    [ecf_numero_ecf] int  NULL,
    [venda_num_cupom] decimal(9,0)  NULL,
    [venda_tipo] char(1)  NULL,
    [venda_vendedor_id] int  NULL,
    [venda_cli_fidelizacao] bit  NULL,
    [venda_prevenda_id] int  NULL,
    [venda_prevenda_data] datetime  NULL,
    [venda_prevenda_uneg_id] int  NULL,
    [venda_prevenda_pdv] int  NULL,
    [venda_tot_acrescimo] decimal(19,4)  NULL,
    [venda_tot_itens] int  NULL,
    [venda_tot_quant] decimal(10,3)  NULL,
    [venda_tot_valor] decimal(19,4)  NULL,
    [venda_tot_preco] decimal(19,4)  NULL,
    [venda_tot_preco_padrao] decimal(19,4)  NULL,
    [venda_tot_preco_praticado] decimal(19,4)  NULL,
    [venda_tot_preco_Reembolso] decimal(19,4)  NULL,
    [venda_tot_preco_avista] decimal(19,4)  NULL,
    [venda_tot_custo] decimal(19,4)  NULL,
    [venda_vlr_comissao] decimal(19,4)  NULL,
    [venda_vlr_desc] decimal(19,4)  NULL,
    [venda_vlr_desc_fin] decimal(19,4)  NULL,
    [venda_vlr_desc_usr_id] int  NULL,
    [venda_cancelada] bit  NULL,
    [venda_cancelada_data] datetime  NULL,
    [venda_cancelada_usr_id] int  NULL,
    [venda_cancelada_coo] decimal(9,0)  NULL,
    [venda_cancelamento_paf] bit  NOT NULL,
    [venda_ccf] varchar(20)  NULL,
    [venda_coo_cupom_vinculado] varchar(20)  NULL,
    [venda_finalizada] bit  NULL,
    [venda_obs] varchar(max)  NULL,
    [venda_md5] varchar(50)  NULL,
    [venda_status] varchar(3)  NULL,
    [venda_data_fiscal] datetime  NULL,
    [venda_data_cupom_ecf] datetime  NULL,
    [venda_pre_venda] char(1)  NULL,
    [venda_num_paf] varchar(10)  NULL,
    [venda_operadorcx_id] decimal(18,0)  NULL,
    [venda_atendente_id] int  NULL,
    [venda_fpop_autorizacao] bigint  NULL,
    [venda_telefone_id] int  NULL,
    [venda_dt_entrega] datetime  NULL,
    [venda_observacao] varchar(100)  NULL,
    [venda_entrega_situacao] varchar(2)  NULL,
    [venda_entrega_dt_separacao] datetime  NULL,
    [venda_entrega_dt_retorno] datetime  NULL,
    [venda_entrega_dt_saida] datetime  NULL,
    [venda_entrega_id_entregador] int  NULL,
    [venda_entrega_operadorcx_retorno] int  NULL,
    [venda_pbm_autorizacao_num] varchar(18)  NULL,
    [venda_pbm_autorizacao_tipo] varchar(1)  NULL,
    [venda_pbm_cpf] bigint  NULL,
    [venda_pbm_cnpj] bigint  NULL,
    [venda_dt_alteracao] datetime  NULL,
    [venda_nfce_chave] varchar(50)  NULL,
    [venda_nfce_protocolo] varchar(15)  NULL,
    [venda_conferente_id] int  NULL,
    [cli_fisc_cpf_cnpj] varchar(14)  NULL,
    [cli_id] bigint  NULL,
    [cnv_id] int  NULL,
    [pbm_id] int  NULL,
    [end_telefone] bigint  NULL,
    [polo_id] int  NULL,
    [quadra_id] int  NULL,
    [rota_id] int  NULL,
    [arearisco_id] int  NULL
);
GO

-- Creating table 'tb_venda_dav'
CREATE TABLE [dbo].[tb_venda_dav] (
    [venda_dav_id] int  NOT NULL,
    [venda_dav_data_preVenda] datetime  NOT NULL,
    [uneg_id] int  NOT NULL,
    [venda_pdv] int  NOT NULL,
    [venda_id] int  NULL,
    [venda_data] datetime  NULL,
    [venda_dav_num_preVenda] varchar(6)  NOT NULL,
    [venda_dav_num_comanda] varchar(14)  NULL,
    [venda_dav_status] char(2)  NOT NULL,
    [venda_dav_valorTotal] decimal(19,4)  NULL,
    [venda_dav_vendedor_id] int  NULL,
    [venda_dav_paf_numero] varchar(10)  NULL,
    [venda_dav_data_alteracao] datetime  NULL,
    [venda_dav_id_origem] int  NULL,
    [uneg_id_origem] int  NULL,
    [venda_dav_data_preVenda_origem] datetime  NULL,
    [venda_pdv_origem] int  NULL,
    [venda_dav_nome_arquivo] nchar(10)  NULL,
    [venda_dav_cancela_vendedor_id] int  NULL,
    [venda_dav_itens] int  NULL,
    [venda_dav_desconto_final] decimal(19,4)  NULL,
    [venda_dav_data_emissao] datetime  NULL,
    [venda_dav_numero_controle] int  NULL,
    [ecf_numero_serie_emissao] varchar(30)  NULL,
    [venda_dav_coo_emissao] int  NULL,
    [venda_dav_gnf_emissao] int  NULL,
    [venda_dav_nome_adquirente] varchar(40)  NULL,
    [venda_dav_num_ecf_venda] int  NULL,
    [venda_dav_coo_venda] int  NULL,
    [venda_dav_coo_cupom_vinculado_venda] int  NULL,
    [venda_dav_titulo] char(1)  NULL,
    [vendaPv_chave_acesso_nfe] varchar(44)  NULL,
    [cli_fisc_cpf_cnpj] varchar(14)  NULL,
    [ecf_numero_serie_fechamento_cupom] varchar(30)  NULL,
    [venda_dav_md5] varchar(255)  NULL,
    [dav_status] char(1)  NULL,
    [cnv_id] int  NULL,
    [cli_id] bigint  NULL
);
GO

-- Creating table 'tb_venda_dav_item'
CREATE TABLE [dbo].[tb_venda_dav_item] (
    [venda_dav_item_id] int  NOT NULL,
    [venda_dav_data_preVenda] datetime  NOT NULL,
    [venda_dav_id] int  NOT NULL,
    [uneg_id] int  NOT NULL,
    [venda_pdv] int  NOT NULL,
    [venda_id] int  NULL,
    [venda_dav_item_autorizacao] bigint  NULL,
    [venda_dav_item_codigo] int  NULL,
    [venda_dav_item_cpfCnpj] varchar(14)  NULL,
    [venda_dav_item_descricao] varchar(50)  NULL,
    [venda_dav_item_ean13] varchar(13)  NULL,
    [venda_dav_item_marcaAgpuc] bit  NULL,
    [venda_dav_item_preco] decimal(7,2)  NULL,
    [venda_dav_item_precoPraticado] decimal(7,2)  NULL,
    [venda_dav_item_precoPadrao] decimal(19,4)  NULL,
    [venda_dav_item_precoReal] decimal(19,4)  NULL,
    [venda_dav_item_precoReembolso] decimal(6,2)  NULL,
    [venda_dav_item_precoVista] decimal(6,2)  NULL,
    [venda_dav_item_quantidade] int  NULL,
    [venda_dav_item_totalValor] decimal(19,4)  NULL,
    [venda_dav_item_valorDesconto] decimal(6,2)  NULL,
    [venda_dav_item_vendedor_id] int  NULL,
    [venda_dav_item_data] datetime  NULL,
    [venda_dav_item_status] char(2)  NOT NULL,
    [venda_dav_item_cancela_vendedor_id] bigint  NULL,
    [venda_dav_item_vidaLink] char(1)  NULL,
    [venda_dav_item_receita_data] datetime  NULL,
    [venda_dav_item_receita_notificacao_num] varchar(50)  NULL,
    [venda_dav_item_receita_notificacao_tipo] varchar(1)  NULL,
    [venda_dav_item_comprador_nome] varchar(50)  NULL,
    [venda_dav_item_comprador_tipdoc] decimal(2,0)  NULL,
    [venda_dav_item_comprador_doc] varchar(20)  NULL,
    [venda_dav_item_comprador_oexped] varchar(20)  NULL,
    [venda_dav_item_comprador_uf] varchar(2)  NULL,
    [venda_dav_item_paciente_doc] varchar(15)  NULL,
    [venda_dav_item_paciente_nome] varchar(30)  NULL,
    [venda_dav_item_paciente_sexo] varchar(1)  NULL,
    [venda_dav_item_paciente_dt_nascimento] datetime  NULL,
    [venda_dav_item_paciente_cid] varchar(20)  NULL,
    [venda_dav_item_lote_numero] varchar(20)  NULL,
    [venda_dav_item_lote_validade] datetime  NULL,
    [venda_dav_item_lote_fabricacao] datetime  NULL,
    [venda_dav_item_lote_vlr_pmc] decimal(19,4)  NULL,
    [venda_dav_item_fpop_qtde_diaria] int  NULL,
    [venda_dav_item_fpop_qtde_unitaria] int  NULL,
    [pro_id] int  NULL,
    [crm_id] int  NULL,
    [treceita_id] int  NULL
);
GO

-- Creating table 'tb_venda_estorno_tef'
CREATE TABLE [dbo].[tb_venda_estorno_tef] (
    [vestef_id] int IDENTITY(1,1) NOT NULL,
    [uneg_id] int  NOT NULL,
    [venda_id] int  NOT NULL,
    [venda_pdv] int  NOT NULL,
    [venda_data] datetime  NOT NULL,
    [vpag_id] int  NOT NULL,
    [vestef_usr_mat] decimal(10,0)  NOT NULL,
    [vestef_vendedor_mat] decimal(10,0)  NOT NULL
);
GO

-- Creating table 'tb_venda_item'
CREATE TABLE [dbo].[tb_venda_item] (
    [uneg_id] int  NOT NULL,
    [venda_id] int  NOT NULL,
    [venda_pdv] int  NOT NULL,
    [venda_data] datetime  NOT NULL,
    [vitem_id] int  NOT NULL,
    [vitem_sequencia_impressora] int  NULL,
    [vitem_descricao] varchar(70)  NULL,
    [vitem_qtde] decimal(10,3)  NULL,
    [vitem_preco] decimal(19,4)  NULL,
    [vitem_preco_padrao] decimal(19,4)  NULL,
    [vitem_preco_praticado] decimal(19,4)  NULL,
    [vitem_preco_real] decimal(19,4)  NULL,
    [vitem_preco_reembolso] decimal(19,4)  NULL,
    [vitem_preco_a_vista] decimal(19,4)  NULL,
    [vitem_desconto] decimal(19,4)  NULL,
    [vitem_desconto_percent] int  NULL,
    [vitem_desc_aut_usr_mat] int  NULL,
    [vitem_desc_financ] decimal(19,4)  NULL,
    [vitem_custo_medio] decimal(19,4)  NULL,
    [vitem_comissao] decimal(19,4)  NULL,
    [vitem_comissao_percent] int  NULL,
    [vitem_vendedor_id] int  NULL,
    [vitem_ean_pistolado] decimal(15,0)  NULL,
    [vitem_sit_trib] varchar(7)  NULL,
    [vitem_situacao] char(2)  NULL,
    [vitem_cancel_usr_mat] int  NULL,
    [vitem_cancel_data] datetime  NULL,
    [vitem_md5] varchar(50)  NULL,
    [vitem_id_cancelado] int  NULL,
    [barra_codigo] decimal(15,0)  NULL,
    [vitem_pre_venda] bit  NULL,
    [vitem_tot_preco] decimal(19,4)  NULL,
    [vitem_tot_preco_padrao] decimal(19,4)  NULL,
    [vitem_tot_preco_praticado] decimal(19,4)  NULL,
    [vitem_tot_preco_real] decimal(19,4)  NULL,
    [vitem_tot_preco_Reembolso] decimal(19,4)  NULL,
    [vitem_tot_preco_a_vista] decimal(19,4)  NULL,
    [vitem_tot_custo_medio] decimal(19,4)  NULL,
    [vitem_tot_comissao] decimal(19,4)  NULL,
    [vitem_tot_desconto] decimal(19,4)  NULL,
    [vitem_tot_desc_financ] decimal(19,4)  NULL,
    [vitem_vidaLink] char(1)  NULL,
    [vitem_receita_data] datetime  NULL,
    [vitem_receita_notificacao_num] varchar(50)  NULL,
    [vitem_receita_notificacao_tipo] varchar(1)  NULL,
    [vitem_comprador_nome] varchar(50)  NULL,
    [vitem_comprador_tipdoc] decimal(2,0)  NULL,
    [vitem_comprador_doc] varchar(20)  NULL,
    [vitem_comprador_oexped] varchar(20)  NULL,
    [vitem_comprador_uf] varchar(2)  NULL,
    [vitem_paciente_oexped] varchar(10)  NULL,
    [vitem_paciente_doc] varchar(15)  NULL,
    [vitem_paciente_nome] varchar(30)  NULL,
    [vitem_paciente_sexo] varchar(1)  NULL,
    [vitem_paciente_dt_nascimento] datetime  NULL,
    [vitem_paciente_cid] varchar(20)  NULL,
    [vitem_lote_numero] varchar(20)  NULL,
    [vitem_lote_validade] datetime  NULL,
    [vitem_lote_fabricacao] datetime  NULL,
    [vitem_lote_vlr_pmc] decimal(19,4)  NULL,
    [vitem_fpop_qtde_Diaria] int  NULL,
    [vitem_fpop_qtde_Unitaria] int  NULL,
    [treceita_id] int  NULL,
    [pro_id] int  NULL,
    [crm_id] int  NULL
);
GO

-- Creating table 'tb_venda_pagamento'
CREATE TABLE [dbo].[tb_venda_pagamento] (
    [uneg_id] int  NOT NULL,
    [venda_id] int  NOT NULL,
    [venda_pdv] int  NOT NULL,
    [venda_data] datetime  NOT NULL,
    [vpag_id] int  NOT NULL,
    [finsub_id] int  NOT NULL,
    [final_id] int  NOT NULL,
    [vpag_num_referencia] int  NULL,
    [vpag_valor] decimal(19,4)  NOT NULL,
    [vpag_troco] decimal(19,4)  NULL,
    [vpag_vendatef] bit  NULL,
    [vpag_valor_compra_saque] decimal(19,4)  NOT NULL,
    [vpag_tef_nsu_venda] varchar(13)  NULL,
    [vpag_tef_nsu_host] varchar(13)  NULL,
    [vpag_tipo_cartao] char(1)  NULL,
    [vpag_comprovante_cliente] varchar(max)  NULL,
    [vpag_comprovante_loja] varchar(max)  NULL,
    [vpag_status] varchar(3)  NULL,
    [vpag_cli_data_ch] datetime  NULL,
    [vpag_cli_banco_id_ch] int  NULL,
    [vpag_cli_agencia_ch] decimal(4,0)  NULL,
    [vpag_cli_c1_ch] decimal(1,0)  NULL,
    [vpag_cli_conta_corrente_ch] decimal(10,0)  NULL,
    [vpag_cli_c2_ch] decimal(1,0)  NULL,
    [vpag_cli_numero_ch] decimal(6,0)  NULL,
    [vpag_cli_c3_ch] decimal(1,0)  NULL,
    [vpag_cli_doc_troca] varchar(14)  NULL,
    [prazo_id] int  NULL,
    [cli_id] bigint  NULL
);
GO

-- Creating table 'tb_venda_prevenda'
CREATE TABLE [dbo].[tb_venda_prevenda] (
    [vendaPv_id] int  NOT NULL,
    [vendaPv_data_preVenda] datetime  NOT NULL,
    [uneg_id] int  NOT NULL,
    [venda_pdv] int  NOT NULL,
    [venda_id] int  NULL,
    [venda_data] datetime  NULL,
    [vendaPv_num_preVenda] varchar(6)  NULL,
    [vendaPv_num_comanda] varchar(14)  NULL,
    [vendaPv_valorTotal] decimal(19,4)  NULL,
    [vendaPv_valorTroco] decimal(19,4)  NULL,
    [vendaPv_vlr_creditos] decimal(19,4)  NULL,
    [vendaPv_desconto_final] decimal(19,4)  NULL,
    [vendaPv_itens] int  NULL,
    [vendaPv_volmes] int  NULL,
    [vendaPv_observacao] varchar(100)  NULL,
    [vendaPv_vendedor_id] int  NULL,
    [vendaPv_atendente_id] int  NULL,
    [vendaPv_situacao] varchar(2)  NULL,
    [vendaPv_tip_pedido] varchar(2)  NULL,
    [vendaPv_tip_faturamento] varchar(2)  NULL,
    [vendaPv_dispositivo] varchar(2)  NULL,
    [vendaPv_id_origem] int  NULL,
    [vendaPv_data_preVenda_origem] datetime  NULL,
    [uneg_id_origem] int  NULL,
    [venda_pdv_origem] int  NULL,
    [vendaPv_end_cobranca] int  NULL,
    [vendaPv_dt_entrega] datetime  NULL,
    [vendaPv_telefone_id] int  NULL,
    [vendaPv_paf_numero] varchar(10)  NULL,
    [vendaPv_pbm_autorizacao_num] varchar(18)  NULL,
    [vendaPv_pbm_autorizacao_tipo] varchar(1)  NULL,
    [vendaPv_pbm_cpf] bigint  NULL,
    [vendaPv_pbm_cnpj] bigint  NULL,
    [vendaPv_pbm_avista] decimal(19,4)  NULL,
    [vendaPv_pbm_reembolso] decimal(19,4)  NULL,
    [vendaPv_pedido_compra_cliente] varchar(20)  NULL,
    [vendaPv_cancela_vendedor_id] int  NULL,
    [vendaPv_cancela_data] datetime  NULL,
    [vendaPv_cancela_motivo] varchar(100)  NULL,
    [vendaPv_entrega_dt_separacao] datetime  NULL,
    [vendaPv_entrega_dt_retorno] datetime  NULL,
    [vendaPv_entrega_id_entregador] int  NULL,
    [vendaPv_status] varchar(2)  NULL,
    [vendaPv_data_alteracao] datetime  NULL,
    [vendaPv_nome_arquivo] varchar(50)  NULL,
    [vendaPv_chave_acesso_nfe] varchar(44)  NULL,
    [vendaPv_ecf_dv] varchar(4)  NULL,
    [vendaPv_coo_dv] varchar(6)  NULL,
    [vendaPv_chave_nfce_dv] varchar(44)  NULL,
    [cli_fisc_cpf_cnpj] varchar(14)  NULL,
    [cli_id] bigint  NULL,
    [cnv_id] int  NULL,
    [pbm_id] int  NULL,
    [end_telefone] bigint  NULL,
    [polo_id] int  NULL,
    [quadra_id] int  NULL,
    [rota_id] int  NULL,
    [arearisco_id] int  NULL
);
GO

-- Creating table 'tb_venda_prevenda_item'
CREATE TABLE [dbo].[tb_venda_prevenda_item] (
    [vendaPv_item_id] int  NOT NULL,
    [vendaPv_data_preVenda] datetime  NOT NULL,
    [vendaPv_id] int  NOT NULL,
    [uneg_id] int  NOT NULL,
    [venda_pdv] int  NOT NULL,
    [venda_id] int  NULL,
    [vendaPv_item_autorizacao] bigint  NULL,
    [vendaPv_item_codigo] int  NULL,
    [vendaPv_item_cpfCnpj] varchar(14)  NULL,
    [vendaPv_item_descricao] varchar(50)  NULL,
    [vendaPv_item_ean13] varchar(13)  NULL,
    [vendaPv_item_agenda_marca_puc] bit  NULL,
    [vendaPv_item_preco] decimal(19,4)  NULL,
    [vendaPv_item_precoPraticado] decimal(19,4)  NULL,
    [vendaPv_item_precoPadrao] decimal(19,4)  NULL,
    [vendaPv_item_precoReal] decimal(19,4)  NULL,
    [vendaPv_item_precoReembolso] decimal(19,4)  NULL,
    [vendaPv_item_precoVista] decimal(19,4)  NULL,
    [vendaPv_item_quantidade] int  NULL,
    [vendaPv_item_totalValor] decimal(19,4)  NULL,
    [vendaPv_item_valorDesconto] decimal(19,4)  NULL,
    [vendaPv_item_vendedor_id] int  NULL,
    [vendaPv_item_data] datetime  NULL,
    [vendaPv_item_status] char(2)  NULL,
    [vendaPv_item_cancela_vendedor_id] bigint  NULL,
    [vendaPv_item_vidaLink] char(1)  NULL,
    [vendaPv_item_receita_data] datetime  NULL,
    [vendaPv_item_receita_notificacao_num] varchar(50)  NULL,
    [vendaPv_item_receita_notificacao_tipo] varchar(1)  NULL,
    [vendaPv_item_comprador_nome] varchar(50)  NULL,
    [vendaPv_item_comprador_tipdoc] decimal(2,0)  NULL,
    [vendaPv_item_comprador_doc] varchar(20)  NULL,
    [vendaPv_item_comprador_oexped] varchar(20)  NULL,
    [vendaPv_item_comprador_uf] varchar(2)  NULL,
    [vendaPv_item_paciente_doc] varchar(15)  NULL,
    [vendaPv_item_paciente_nome] varchar(30)  NULL,
    [vendaPv_item_paciente_sexo] varchar(1)  NULL,
    [vendaPv_item_paciente_dt_nascimento] datetime  NULL,
    [vendaPv_item_paciente_cid] varchar(20)  NULL,
    [vendaPv_item_lote_numero] varchar(20)  NULL,
    [vendaPv_item_lote_validade] datetime  NULL,
    [vendaPv_lote_fabricacao] datetime  NULL,
    [vendaPv_item_lote_vlr_pmc] decimal(19,4)  NULL,
    [vendaPv_item_fpop_qtde_Diaria] int  NULL,
    [vendaPv_item_fpop_qtde_Unitaria] int  NULL,
    [pro_id] int  NULL,
    [crm_id] int  NULL,
    [treceita_id] int  NULL
);
GO

-- Creating table 'tb_venda_prevenda_pgto'
CREATE TABLE [dbo].[tb_venda_prevenda_pgto] (
    [vendaPv_id] int  NOT NULL,
    [vendaPv_data_preVenda] datetime  NOT NULL,
    [uneg_id] int  NOT NULL,
    [venda_pdv] int  NOT NULL,
    [vpag_id] int IDENTITY(1,1) NOT NULL,
    [final_id] int  NOT NULL,
    [subfin_id] int  NOT NULL,
    [vpag_num_referencia] int  NULL,
    [vpag_valor] decimal(19,4)  NULL,
    [vpag_troco] decimal(19,4)  NULL,
    [vpag_vendatef] bit  NULL,
    [vpag_valor_compra_saque] decimal(19,4)  NULL,
    [vpag_tef_nsu_venda] varchar(13)  NULL,
    [vpag_tef_nsu_host] varchar(13)  NULL,
    [vpag_tipo_cartao] char(1)  NULL,
    [vpag_comprovante_cliente] varchar(max)  NULL,
    [vpag_comprovante_loja] varchar(max)  NULL,
    [vpag_status] varchar(3)  NULL,
    [vpag_cli_data_ch] datetime  NULL,
    [vpag_cli_banco_id_ch] int  NULL,
    [vpag_cli_agencia_ch] decimal(4,0)  NULL,
    [vpag_cli_c1_ch] decimal(1,0)  NULL,
    [vpag_cli_conta_corrente_ch] decimal(10,0)  NULL,
    [vpag_cli_c2_ch] decimal(1,0)  NULL,
    [vpag_cli_numero_ch] decimal(6,0)  NULL,
    [vpag_cli_c3_ch] decimal(1,0)  NULL,
    [vpag_cli_doc_troca] varchar(14)  NULL,
    [prazo_id] int  NULL,
    [cli_id] bigint  NULL
);
GO

-- Creating table 'tbManagerUpdates'
CREATE TABLE [dbo].[tbManagerUpdates] (
    [ManagerUpdateID] int IDENTITY(1,1) NOT NULL,
    [Rotina] varchar(50)  NOT NULL,
    [CreatedOn] datetime  NOT NULL
);
GO

-- Creating table 'tbr_abcfarma_uf'
CREATE TABLE [dbo].[tbr_abcfarma_uf] (
    [per_id] int  NOT NULL,
    [abcf_id] int  NOT NULL,
    [uf_id] int  NOT NULL,
    [prouf_preco_fabrica] decimal(19,4)  NULL,
    [prouf_pmc] decimal(19,4)  NULL,
    [prouf_pmc_fracao] decimal(19,4)  NULL,
    [prouf_situacao] char(1)  NULL,
    [prouf_dt_cadastro] datetime  NULL,
    [prouf_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tbr_convenio_cliente'
CREATE TABLE [dbo].[tbr_convenio_cliente] (
    [cnv_id] int  NOT NULL,
    [cli_id] bigint  NOT NULL,
    [clicnv_vlr_limite] decimal(19,4)  NULL,
    [clicnv_vlr_acumulado] decimal(19,4)  NULL,
    [clicnv_nu_matricula] char(12)  NULL,
    [clicnv_situacao] char(1)  NULL,
    [clicnv_dt_cadastro] datetime  NULL,
    [clicnv_dt_alteracao] datetime  NULL,
    [bloq_id] int  NULL,
    [prazo_id] int  NULL
);
GO

-- Creating table 'tbr_convenio_finalizadora_sub'
CREATE TABLE [dbo].[tbr_convenio_finalizadora_sub] (
    [cnv_id] int  NOT NULL,
    [final_id] int  NOT NULL,
    [subfin_id] int  NOT NULL,
    [cfinaliza_situacao] char(1)  NULL,
    [cfinaliza_dt_cadastro] datetime  NULL,
    [cfinaliza_dt_alteracao] datetime  NULL,
    [cfinaliza_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tbr_convenio_un'
CREATE TABLE [dbo].[tbr_convenio_un] (
    [cnv_id] int  NOT NULL,
    [uneg_id] int  NOT NULL,
    [convun_situacao] char(1)  NULL,
    [convun_dt_cadastro] datetime  NULL,
    [convun_dt_alteracao] datetime  NULL,
    [convun_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tbr_dicionario_produto'
CREATE TABLE [dbo].[tbr_dicionario_produto] (
    [fab_id] int  NOT NULL,
    [pro_id] int  NOT NULL,
    [dicprod_qtde_embal] decimal(6,0)  NULL,
    [dicprod_tipo_embal] char(3)  NULL,
    [dicprod_codigo] varchar(20)  NULL,
    [dicprod_situacao] char(1)  NULL,
    [dicprod_dt_cadastro] datetime  NULL,
    [dicprod_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tbr_dicionario_un'
CREATE TABLE [dbo].[tbr_dicionario_un] (
    [uneg_id] int  NOT NULL,
    [fab_id] int  NOT NULL,
    [div_id] int  NOT NULL,
    [dicun_codigo] char(10)  NULL,
    [dicun_situacao] char(1)  NULL,
    [dicun_dt_cadastro] datetime  NULL,
    [dicun_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tbr_dpto_aplicativo'
CREATE TABLE [dbo].[tbr_dpto_aplicativo] (
    [dpto_id] int  NOT NULL,
    [apl_id] int  NOT NULL,
    [dptapl_acesso] int  NULL,
    [dptapl_inclusao] bit  NULL,
    [dptapl_alteracao] bit  NULL,
    [dptapl_exclusao] bit  NULL,
    [dptapl_impressao] bit  NULL,
    [dptapl_exp_xls] bit  NULL,
    [dptapl_exp_pdf] bit  NULL,
    [dptapl_exp_txt] bit  NULL,
    [dptapl_processo] bit  NULL,
    [dptapl_edicao] bit  NULL,
    [dptapl_dt_cadastro] datetime  NULL,
    [dptapl_dt_alteracao] datetime  NULL,
    [dptapl_aplicacao] varchar(255)  NULL
);
GO

-- Creating table 'tbr_ecf_finalizadora'
CREATE TABLE [dbo].[tbr_ecf_finalizadora] (
    [final_id] int  NOT NULL,
    [ecf_numero_serie] varchar(30)  NOT NULL,
    [finalecf_codigo] varchar(50)  NOT NULL,
    [finalecf_cupom_vinculado] bit  NOT NULL,
    [finalecf_situacao] char(1)  NOT NULL,
    [finalecf_dt_cadastro] datetime  NOT NULL,
    [finalecf_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tbr_ecf_tributacao'
CREATE TABLE [dbo].[tbr_ecf_tributacao] (
    [trb_id] int  NOT NULL,
    [ecf_numero_serie] varchar(30)  NOT NULL,
    [trbecf_codigo] char(3)  NULL,
    [trbecf_situacao] char(1)  NULL,
    [trbecf_dt_cadastro] datetime  NULL,
    [trbecf_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tbr_finalizadora_sub_un'
CREATE TABLE [dbo].[tbr_finalizadora_sub_un] (
    [final_id] int  NOT NULL,
    [subfin_id] int  NOT NULL,
    [uneg_id] int  NOT NULL,
    [finsubun_taxa_adm] decimal(19,4)  NULL,
    [finsubun_situacao] char(1)  NULL,
    [finsubun_dt_cadastro] datetime  NULL,
    [finsubun_dt_alteracao] datetime  NULL,
    [finsubun_cpf_alteracao] decimal(11,0)  NULL,
    [banco_id] int  NULL
);
GO

-- Creating table 'tbr_finalizadora_un'
CREATE TABLE [dbo].[tbr_finalizadora_un] (
    [uneg_id] int  NOT NULL,
    [final_id] int  NOT NULL,
    [finalun_situacao] char(1)  NULL,
    [finalun_dt_cadastro] datetime  NULL,
    [finalun_dt_alteracao] datetime  NULL,
    [finalun_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tbr_mvto_compra_cfop____'
CREATE TABLE [dbo].[tbr_mvto_compra_cfop____] (
    [cmp_id] int  NOT NULL,
    [cfop_id] int  NOT NULL,
    [mvtoccfop_base_icms] decimal(19,4)  NULL,
    [mvtoccfop_aliq_icms] decimal(19,4)  NULL,
    [mvtoccfop_valor_icms] decimal(19,4)  NULL,
    [mvtoccfop_situacao] char(1)  NULL,
    [mvtoccfop_dt_cadastro] datetime  NULL,
    [mvtoccfop_dt_alteracao] datetime  NULL,
    [mvtoccfop_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tbr_mvto_compra_dup____'
CREATE TABLE [dbo].[tbr_mvto_compra_dup____] (
    [cmp_id] int  NOT NULL,
    [cmpdup_id] int  NOT NULL,
    [mvtocdup_situacao] char(1)  NULL,
    [mvtocdup_dt_cadastro] datetime  NULL,
    [mvtocdup_dt_alteracao] datetime  NULL,
    [mvtocdup_cpf_alteracao] decimal(11,0)  NULL
);
GO

-- Creating table 'tbr_parametro_descprod_uneg'
CREATE TABLE [dbo].[tbr_parametro_descprod_uneg] (
    [par_id] int  NOT NULL,
    [uneg_id] int  NOT NULL
);
GO

-- Creating table 'tbr_parametro_descvend_uneg'
CREATE TABLE [dbo].[tbr_parametro_descvend_uneg] (
    [par_id] int  NOT NULL,
    [uneg_id] int  NOT NULL
);
GO

-- Creating table 'tbr_parametro_markup_uneg'
CREATE TABLE [dbo].[tbr_parametro_markup_uneg] (
    [par_id] int  NOT NULL,
    [uneg_id] int  NOT NULL,
    [par_percentual] decimal(19,4)  NULL
);
GO

-- Creating table 'tbr_produto_estoque_dia'
CREATE TABLE [dbo].[tbr_produto_estoque_dia] (
    [uneg_id] int  NOT NULL,
    [pro_id] int  NOT NULL,
    [proes_dt_cadastro] datetime  NOT NULL,
    [proes_dt_alteracao] datetime  NULL,
    [proes_dt_leiturax] datetime  NULL,
    [proes_dt_update] datetime  NULL,
    [proes_estoque] decimal(9,3)  NULL,
    [proes_estoque_dia] decimal(9,3)  NOT NULL,
    [proes_custo_nf] decimal(19,4)  NULL,
    [proes_custo_real] decimal(19,4)  NULL,
    [proes_custo_medio] decimal(19,4)  NULL,
    [proes_preco_venda] decimal(19,4)  NULL,
    [ecf_numero_serie] varchar(50)  NULL
);
GO

-- Creating table 'tbr_produto_estoque_lote'
CREATE TABLE [dbo].[tbr_produto_estoque_lote] (
    [uneg_id] int  NOT NULL,
    [pro_id] int  NOT NULL,
    [lote_numero] varchar(20)  NOT NULL,
    [lote_validade] datetime  NOT NULL,
    [lote_estoque] decimal(9,3)  NULL,
    [lote_fabricacao] datetime  NULL,
    [lote_vlr_pmc] decimal(19,4)  NULL,
    [lote_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tbr_produto_tributacao'
CREATE TABLE [dbo].[tbr_produto_tributacao] (
    [pro_id] int  NOT NULL,
    [uf_id] int  NOT NULL,
    [protrb_class_tributaria] char(1)  NULL,
    [trb_id_interno] int  NOT NULL,
    [trb_id_interestadual] int  NOT NULL,
    [protrb_origem_cst] int  NULL,
    [protrb_situacao] char(1)  NULL,
    [protrb_dt_cadastro] datetime  NULL,
    [protrb_dt_alteracao] datetime  NULL
);
GO

-- Creating table 'tbr_produto_uneg'
CREATE TABLE [dbo].[tbr_produto_uneg] (
    [uneg_id] int  NOT NULL,
    [pro_id] int  NOT NULL,
    [proun_preco_venda] decimal(19,4)  NULL,
    [proun_situacao] char(1)  NULL,
    [proun_custo_nf] decimal(19,4)  NULL,
    [proun_encargos_nf] decimal(19,4)  NULL,
    [proun_descontos_nf] decimal(19,4)  NULL,
    [proun_custo_real] decimal(19,4)  NULL,
    [proun_custo_medio] decimal(19,4)  NULL,
    [proun_dia_min] decimal(3,0)  NULL,
    [proun_dia_max] decimal(3,0)  NULL,
    [proun_qtd_min] decimal(5,0)  NULL,
    [proun_qtd_max] decimal(5,0)  NULL,
    [proun_fixa_qtd_max] bit  NULL,
    [proun_vnd_media] decimal(10,2)  NULL,
    [proun_repos_auto] bit  NULL,
    [proun_abc_qtde] char(1)  NULL,
    [proun_abc_val] char(1)  NULL,
    [proun_abc_mrg] char(1)  NULL,
    [proun_abc_qtde_rank] decimal(6,0)  NULL,
    [proun_abc_val_rank] decimal(6,0)  NULL,
    [proun_abc_mrg_rank] decimal(6,0)  NULL,
    [proun_qtd_estoque] decimal(10,3)  NULL,
    [proun_qtd_pedida] decimal(10,3)  NULL,
    [proun_qtd_transferida] decimal(10,3)  NULL,
    [proun_dt_ult_compra] datetime  NULL,
    [proun_dt_ult_venda] datetime  NULL,
    [proun_dt_ult_mvto] datetime  NULL,
    [proun_dt_ult_preco] datetime  NULL,
    [proun_dt_cadastro] datetime  NULL,
    [proun_dt_alteracao] datetime  NULL,
    [proun_bloq_compra] bit  NULL,
    [proun_dt_ult_inventario] datetime  NULL,
    [proun_id_ult_fornecedor] int  NULL
);
GO

-- Creating table 'tbr_promocao_produto'
CREATE TABLE [dbo].[tbr_promocao_produto] (
    [prm_id] int  NOT NULL,
    [pro_id] int  NOT NULL,
    [prom_preco] decimal(19,4)  NULL,
    [prom_situacao] char(1)  NULL,
    [prom_dt_cadastro] datetime  NULL,
    [prom_dt_alteracao] datetime  NULL,
    [prom_cpf_alteracao] decimal(11,0)  NULL,
    [prom_app_alteracao] varchar(50)  NULL
);
GO

-- Creating table 'tbr_promocao_convenio'
CREATE TABLE [dbo].[tbr_promocao_convenio] (
    [tb_convenio_cnv_id] int  NOT NULL,
    [tb_promocao_prm_id] int  NOT NULL
);
GO

-- Creating table 'tbr_promocao_uneg'
CREATE TABLE [dbo].[tbr_promocao_uneg] (
    [tb_promocao_prm_id] int  NOT NULL,
    [tb_unid_negocio_uneg_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [abcf_id] in table 'tb_abcfarma'
ALTER TABLE [dbo].[tb_abcfarma]
ADD CONSTRAINT [PK_tb_abcfarma]
    PRIMARY KEY CLUSTERED ([abcf_id] ASC);
GO

-- Creating primary key on [per_id] in table 'tb_abcfarma_periodo'
ALTER TABLE [dbo].[tb_abcfarma_periodo]
ADD CONSTRAINT [PK_tb_abcfarma_periodo]
    PRIMARY KEY CLUSTERED ([per_id] ASC);
GO

-- Creating primary key on [uneg_id], [aberturaCx_usr_id_operador], [aberturaCx_dt_abertura] in table 'tb_abertura_caixa'
ALTER TABLE [dbo].[tb_abertura_caixa]
ADD CONSTRAINT [PK_tb_abertura_caixa]
    PRIMARY KEY CLUSTERED ([uneg_id], [aberturaCx_usr_id_operador], [aberturaCx_dt_abertura] ASC);
GO

-- Creating primary key on [uneg_id], [agen_pdv], [agen_id], [agen_dt_agenda] in table 'tb_agenda_produto'
ALTER TABLE [dbo].[tb_agenda_produto]
ADD CONSTRAINT [PK_tb_agenda_produto]
    PRIMARY KEY CLUSTERED ([uneg_id], [agen_pdv], [agen_id], [agen_dt_agenda] ASC);
GO

-- Creating primary key on [banco_id] in table 'tb_banco'
ALTER TABLE [dbo].[tb_banco]
ADD CONSTRAINT [PK_tb_banco]
    PRIMARY KEY CLUSTERED ([banco_id] ASC);
GO

-- Creating primary key on [cadcont_id] in table 'tb_cadastro_contador'
ALTER TABLE [dbo].[tb_cadastro_contador]
ADD CONSTRAINT [PK_tb_cadastro_contador]
    PRIMARY KEY CLUSTERED ([cadcont_id] ASC);
GO

-- Creating primary key on [cargo_id] in table 'tb_cargo'
ALTER TABLE [dbo].[tb_cargo]
ADD CONSTRAINT [PK_tb_cargo]
    PRIMARY KEY CLUSTERED ([cargo_id] ASC);
GO

-- Creating primary key on [polo_id], [quadra_id], [rota_id], [cep_id] in table 'tb_ceps'
ALTER TABLE [dbo].[tb_ceps]
ADD CONSTRAINT [PK_tb_ceps]
    PRIMARY KEY CLUSTERED ([polo_id], [quadra_id], [rota_id], [cep_id] ASC);
GO

-- Creating primary key on [cfop_id] in table 'tb_cfop'
ALTER TABLE [dbo].[tb_cfop]
ADD CONSTRAINT [PK_tb_cfop]
    PRIMARY KEY CLUSTERED ([cfop_id] ASC);
GO

-- Creating primary key on [uneg_id], [chkin_pdv], [chkin_id], [chkin_data] in table 'tb_checkin'
ALTER TABLE [dbo].[tb_checkin]
ADD CONSTRAINT [PK_tb_checkin]
    PRIMARY KEY CLUSTERED ([uneg_id], [chkin_pdv], [chkin_id], [chkin_data] ASC);
GO

-- Creating primary key on [uneg_id], [chkin_pdv], [chkin_id], [chkin_data], [ickin_id] in table 'tb_checkin_item'
ALTER TABLE [dbo].[tb_checkin_item]
ADD CONSTRAINT [PK_tb_checkin_item]
    PRIMARY KEY CLUSTERED ([uneg_id], [chkin_pdv], [chkin_id], [chkin_data], [ickin_id] ASC);
GO

-- Creating primary key on [chkin_id], [ickin_id] in table 'tb_checkin_item_tmp'
ALTER TABLE [dbo].[tb_checkin_item_tmp]
ADD CONSTRAINT [PK_tb_checkin_item_tmp]
    PRIMARY KEY CLUSTERED ([chkin_id], [ickin_id] ASC);
GO

-- Creating primary key on [chkin_id] in table 'tb_checkin_tmp'
ALTER TABLE [dbo].[tb_checkin_tmp]
ADD CONSTRAINT [PK_tb_checkin_tmp]
    PRIMARY KEY CLUSTERED ([chkin_id] ASC);
GO

-- Creating primary key on [uneg_id], [chkout_pdv], [chkout_id], [chkout_data] in table 'tb_checkout'
ALTER TABLE [dbo].[tb_checkout]
ADD CONSTRAINT [PK_tb_checkout]
    PRIMARY KEY CLUSTERED ([uneg_id], [chkout_pdv], [chkout_id], [chkout_data] ASC);
GO

-- Creating primary key on [uneg_id], [chkout_pdv], [chkout_id], [chkout_data], [ickout_id] in table 'tb_checkout_item'
ALTER TABLE [dbo].[tb_checkout_item]
ADD CONSTRAINT [PK_tb_checkout_item]
    PRIMARY KEY CLUSTERED ([uneg_id], [chkout_pdv], [chkout_id], [chkout_data], [ickout_id] ASC);
GO

-- Creating primary key on [cli_id] in table 'tb_cliente'
ALTER TABLE [dbo].[tb_cliente]
ADD CONSTRAINT [PK_tb_cliente]
    PRIMARY KEY CLUSTERED ([cli_id] ASC);
GO

-- Creating primary key on [cli_anv_num_documento], [cli_anv_orgao_expedidor] in table 'tb_cliente_anvisa'
ALTER TABLE [dbo].[tb_cliente_anvisa]
ADD CONSTRAINT [PK_tb_cliente_anvisa]
    PRIMARY KEY CLUSTERED ([cli_anv_num_documento], [cli_anv_orgao_expedidor] ASC);
GO

-- Creating primary key on [bloq_id] in table 'tb_cliente_bloqueio'
ALTER TABLE [dbo].[tb_cliente_bloqueio]
ADD CONSTRAINT [PK_tb_cliente_bloqueio]
    PRIMARY KEY CLUSTERED ([bloq_id] ASC);
GO

-- Creating primary key on [cli_id], [end_id] in table 'tb_cliente_endereco'
ALTER TABLE [dbo].[tb_cliente_endereco]
ADD CONSTRAINT [PK_tb_cliente_endereco]
    PRIMARY KEY CLUSTERED ([cli_id], [end_id] ASC);
GO

-- Creating primary key on [cli_fisc_cpf_cnpj] in table 'tb_cliente_fiscal'
ALTER TABLE [dbo].[tb_cliente_fiscal]
ADD CONSTRAINT [PK_tb_cliente_fiscal]
    PRIMARY KEY CLUSTERED ([cli_fisc_cpf_cnpj] ASC);
GO

-- Creating primary key on [cli_id], [tel_id] in table 'tb_cliente_telefone'
ALTER TABLE [dbo].[tb_cliente_telefone]
ADD CONSTRAINT [PK_tb_cliente_telefone]
    PRIMARY KEY CLUSTERED ([cli_id], [tel_id] ASC);
GO

-- Creating primary key on [cs_id] in table 'tb_conselho'
ALTER TABLE [dbo].[tb_conselho]
ADD CONSTRAINT [PK_tb_conselho]
    PRIMARY KEY CLUSTERED ([cs_id] ASC);
GO

-- Creating primary key on [cr_id] in table 'tb_conselho_regional'
ALTER TABLE [dbo].[tb_conselho_regional]
ADD CONSTRAINT [PK_tb_conselho_regional]
    PRIMARY KEY CLUSTERED ([cr_id] ASC);
GO

-- Creating primary key on [grau_id], [grau_1], [grau_descricao] in table 'tb_conta'
ALTER TABLE [dbo].[tb_conta]
ADD CONSTRAINT [PK_tb_conta]
    PRIMARY KEY CLUSTERED ([grau_id], [grau_1], [grau_descricao] ASC);
GO

-- Creating primary key on [cnv_id] in table 'tb_convenio'
ALTER TABLE [dbo].[tb_convenio]
ADD CONSTRAINT [PK_tb_convenio]
    PRIMARY KEY CLUSTERED ([cnv_id] ASC);
GO

-- Creating primary key on [cred_id] in table 'tb_crediario'
ALTER TABLE [dbo].[tb_crediario]
ADD CONSTRAINT [PK_tb_crediario]
    PRIMARY KEY CLUSTERED ([cred_id] ASC);
GO

-- Creating primary key on [cred_id], [uneg_id], [venda_pdv], [crpgto_id], [crpgto_data] in table 'tb_crediario_finalizadora'
ALTER TABLE [dbo].[tb_crediario_finalizadora]
ADD CONSTRAINT [PK_tb_crediario_finalizadora]
    PRIMARY KEY CLUSTERED ([cred_id], [uneg_id], [venda_pdv], [crpgto_id], [crpgto_data] ASC);
GO

-- Creating primary key on [crm_id], [crm_tipo], [uf_id] in table 'tb_crm'
ALTER TABLE [dbo].[tb_crm]
ADD CONSTRAINT [PK_tb_crm]
    PRIMARY KEY CLUSTERED ([crm_id], [crm_tipo], [uf_id] ASC);
GO

-- Creating primary key on [crm_end_id], [crm_id], [uf_id], [crm_tipo] in table 'tb_crm_endereco'
ALTER TABLE [dbo].[tb_crm_endereco]
ADD CONSTRAINT [PK_tb_crm_endereco]
    PRIMARY KEY CLUSTERED ([crm_end_id], [crm_id], [uf_id], [crm_tipo] ASC);
GO

-- Creating primary key on [esp_id] in table 'tb_crm_especialidade'
ALTER TABLE [dbo].[tb_crm_especialidade]
ADD CONSTRAINT [PK_tb_crm_especialidade]
    PRIMARY KEY CLUSTERED ([esp_id] ASC);
GO

-- Creating primary key on [dav_id] in table 'tb_dav'
ALTER TABLE [dbo].[tb_dav]
ADD CONSTRAINT [PK_tb_dav]
    PRIMARY KEY CLUSTERED ([dav_id] ASC);
GO

-- Creating primary key on [davi_id] in table 'tb_dav_itens____'
ALTER TABLE [dbo].[tb_dav_itens____]
ADD CONSTRAINT [PK_tb_dav_itens____]
    PRIMARY KEY CLUSTERED ([davi_id] ASC);
GO

-- Creating primary key on [ecf_numero_serie] in table 'tb_ecf'
ALTER TABLE [dbo].[tb_ecf]
ADD CONSTRAINT [PK_tb_ecf]
    PRIMARY KEY CLUSTERED ([ecf_numero_serie] ASC);
GO

-- Creating primary key on [ecfd_id] in table 'tb_ecf_dd'
ALTER TABLE [dbo].[tb_ecf_dd]
ADD CONSTRAINT [PK_tb_ecf_dd]
    PRIMARY KEY CLUSTERED ([ecfd_id] ASC);
GO

-- Creating primary key on [ecfm_id_marca], [ecfm_id_modelo], [ecfm_id_versao] in table 'tb_ecf_modelo'
ALTER TABLE [dbo].[tb_ecf_modelo]
ADD CONSTRAINT [PK_tb_ecf_modelo]
    PRIMARY KEY CLUSTERED ([ecfm_id_marca], [ecfm_id_modelo], [ecfm_id_versao] ASC);
GO

-- Creating primary key on [emplabel_id] in table 'tb_empresa_privatelabel'
ALTER TABLE [dbo].[tb_empresa_privatelabel]
ADD CONSTRAINT [PK_tb_empresa_privatelabel]
    PRIMARY KEY CLUSTERED ([emplabel_id] ASC);
GO

-- Creating primary key on [emprec_id] in table 'tb_empresa_recarga'
ALTER TABLE [dbo].[tb_empresa_recarga]
ADD CONSTRAINT [PK_tb_empresa_recarga]
    PRIMARY KEY CLUSTERED ([emprec_id] ASC);
GO

-- Creating primary key on [arearisco_id] in table 'tb_entrega_arearisco'
ALTER TABLE [dbo].[tb_entrega_arearisco]
ADD CONSTRAINT [PK_tb_entrega_arearisco]
    PRIMARY KEY CLUSTERED ([arearisco_id] ASC);
GO

-- Creating primary key on [uneg_id], [end_pdv], [end_id], [end_data] in table 'tb_entrega_endereco'
ALTER TABLE [dbo].[tb_entrega_endereco]
ADD CONSTRAINT [PK_tb_entrega_endereco]
    PRIMARY KEY CLUSTERED ([uneg_id], [end_pdv], [end_id], [end_data] ASC);
GO

-- Creating primary key on [polo_id] in table 'tb_entrega_polo'
ALTER TABLE [dbo].[tb_entrega_polo]
ADD CONSTRAINT [PK_tb_entrega_polo]
    PRIMARY KEY CLUSTERED ([polo_id] ASC);
GO

-- Creating primary key on [bairro_id] in table 'tb_entrega_polo_bairro'
ALTER TABLE [dbo].[tb_entrega_polo_bairro]
ADD CONSTRAINT [PK_tb_entrega_polo_bairro]
    PRIMARY KEY CLUSTERED ([bairro_id] ASC);
GO

-- Creating primary key on [uneg_id], [end_pdv], [end_id], [end_data], [pro_id] in table 'tb_entrega_prod_continuo'
ALTER TABLE [dbo].[tb_entrega_prod_continuo]
ADD CONSTRAINT [PK_tb_entrega_prod_continuo]
    PRIMARY KEY CLUSTERED ([uneg_id], [end_pdv], [end_id], [end_data], [pro_id] ASC);
GO

-- Creating primary key on [quadra_id] in table 'tb_entrega_quadrante'
ALTER TABLE [dbo].[tb_entrega_quadrante]
ADD CONSTRAINT [PK_tb_entrega_quadrante]
    PRIMARY KEY CLUSTERED ([quadra_id] ASC);
GO

-- Creating primary key on [rota_id] in table 'tb_entrega_rota'
ALTER TABLE [dbo].[tb_entrega_rota]
ADD CONSTRAINT [PK_tb_entrega_rota]
    PRIMARY KEY CLUSTERED ([rota_id] ASC);
GO

-- Creating primary key on [cep_id] in table 'tb_entrega_rota_cep'
ALTER TABLE [dbo].[tb_entrega_rota_cep]
ADD CONSTRAINT [PK_tb_entrega_rota_cep]
    PRIMARY KEY CLUSTERED ([cep_id] ASC);
GO

-- Creating primary key on [final_id] in table 'tb_finalizadora'
ALTER TABLE [dbo].[tb_finalizadora]
ADD CONSTRAINT [PK_tb_finalizadora]
    PRIMARY KEY CLUSTERED ([final_id] ASC);
GO

-- Creating primary key on [finsub_id], [final_id] in table 'tb_finalizadora_sub'
ALTER TABLE [dbo].[tb_finalizadora_sub]
ADD CONSTRAINT [PK_tb_finalizadora_sub]
    PRIMARY KEY CLUSTERED ([finsub_id], [final_id] ASC);
GO

-- Creating primary key on [adm_id] in table 'tb_financeiro_administradora'
ALTER TABLE [dbo].[tb_financeiro_administradora]
ADD CONSTRAINT [PK_tb_financeiro_administradora]
    PRIMARY KEY CLUSTERED ([adm_id] ASC);
GO

-- Creating primary key on [banco_id] in table 'tb_financeiro_bancos'
ALTER TABLE [dbo].[tb_financeiro_bancos]
ADD CONSTRAINT [PK_tb_financeiro_bancos]
    PRIMARY KEY CLUSTERED ([banco_id] ASC);
GO

-- Creating primary key on [eventf_id] in table 'tb_financeiro_evento'
ALTER TABLE [dbo].[tb_financeiro_evento]
ADD CONSTRAINT [PK_tb_financeiro_evento]
    PRIMARY KEY CLUSTERED ([eventf_id] ASC);
GO

-- Creating primary key on [prazo_id] in table 'tb_financeiro_prazo'
ALTER TABLE [dbo].[tb_financeiro_prazo]
ADD CONSTRAINT [PK_tb_financeiro_prazo]
    PRIMARY KEY CLUSTERED ([prazo_id] ASC);
GO

-- Creating primary key on [sangriaf_id] in table 'tb_financeiro_sangria'
ALTER TABLE [dbo].[tb_financeiro_sangria]
ADD CONSTRAINT [PK_tb_financeiro_sangria]
    PRIMARY KEY CLUSTERED ([sangriaf_id] ASC);
GO

-- Creating primary key on [suprimentof_id] in table 'tb_financeiro_suprimento'
ALTER TABLE [dbo].[tb_financeiro_suprimento]
ADD CONSTRAINT [PK_tb_financeiro_suprimento]
    PRIMARY KEY CLUSTERED ([suprimentof_id] ASC);
GO

-- Creating primary key on [fab_id] in table 'tb_fornecedor'
ALTER TABLE [dbo].[tb_fornecedor]
ADD CONSTRAINT [PK_tb_fornecedor]
    PRIMARY KEY CLUSTERED ([fab_id] ASC);
GO

-- Creating primary key on [fab_id], [div_id] in table 'tb_fornecedor_divisao'
ALTER TABLE [dbo].[tb_fornecedor_divisao]
ADD CONSTRAINT [PK_tb_fornecedor_divisao]
    PRIMARY KEY CLUSTERED ([fab_id], [div_id] ASC);
GO

-- Creating primary key on [func_id] in table 'tb_funcionario'
ALTER TABLE [dbo].[tb_funcionario]
ADD CONSTRAINT [PK_tb_funcionario]
    PRIMARY KEY CLUSTERED ([func_id] ASC);
GO

-- Creating primary key on [hora_id] in table 'tb_funcionario_horario'
ALTER TABLE [dbo].[tb_funcionario_horario]
ADD CONSTRAINT [PK_tb_funcionario_horario]
    PRIMARY KEY CLUSTERED ([hora_id] ASC);
GO

-- Creating primary key on [hora_id], [ihora_dia] in table 'tb_funcionario_horario_item'
ALTER TABLE [dbo].[tb_funcionario_horario_item]
ADD CONSTRAINT [PK_tb_funcionario_horario_item]
    PRIMARY KEY CLUSTERED ([hora_id], [ihora_dia] ASC);
GO

-- Creating primary key on [funcvisit_id] in table 'tb_funcionario_visitante'
ALTER TABLE [dbo].[tb_funcionario_visitante]
ADD CONSTRAINT [PK_tb_funcionario_visitante]
    PRIMARY KEY CLUSTERED ([funcvisit_id] ASC);
GO

-- Creating primary key on [hsang_id] in table 'tb_hist_sangria____'
ALTER TABLE [dbo].[tb_hist_sangria____]
ADD CONSTRAINT [PK_tb_hist_sangria____]
    PRIMARY KEY CLUSTERED ([hsang_id] ASC);
GO

-- Creating primary key on [ibge_codigo] in table 'tb_ibge'
ALTER TABLE [dbo].[tb_ibge]
ADD CONSTRAINT [PK_tb_ibge]
    PRIMARY KEY CLUSTERED ([ibge_codigo] ASC);
GO

-- Creating primary key on [iax_id] in table 'tb_ibpt_ax'
ALTER TABLE [dbo].[tb_ibpt_ax]
ADD CONSTRAINT [PK_tb_ibpt_ax]
    PRIMARY KEY CLUSTERED ([iax_id] ASC);
GO

-- Creating primary key on [uneg_id], [lanctof_pdv], [lanctof_data], [lanctof_id] in table 'tb_lancto_financeiro'
ALTER TABLE [dbo].[tb_lancto_financeiro]
ADD CONSTRAINT [PK_tb_lancto_financeiro]
    PRIMARY KEY CLUSTERED ([uneg_id], [lanctof_pdv], [lanctof_data], [lanctof_id] ASC);
GO

-- Creating primary key on [formaliq_id] in table 'tb_liquidacao_forma'
ALTER TABLE [dbo].[tb_liquidacao_forma]
ADD CONSTRAINT [PK_tb_liquidacao_forma]
    PRIMARY KEY CLUSTERED ([formaliq_id] ASC);
GO

-- Creating primary key on [motivoliq_id] in table 'tb_liquidacao_motivo'
ALTER TABLE [dbo].[tb_liquidacao_motivo]
ADD CONSTRAINT [PK_tb_liquidacao_motivo]
    PRIMARY KEY CLUSTERED ([motivoliq_id] ASC);
GO

-- Creating primary key on [cmp_id] in table 'tb_mvto_compra____'
ALTER TABLE [dbo].[tb_mvto_compra____]
ADD CONSTRAINT [PK_tb_mvto_compra____]
    PRIMARY KEY CLUSTERED ([cmp_id] ASC);
GO

-- Creating primary key on [cmpdup_id] in table 'tb_mvto_compra_dup____'
ALTER TABLE [dbo].[tb_mvto_compra_dup____]
ADD CONSTRAINT [PK_tb_mvto_compra_dup____]
    PRIMARY KEY CLUSTERED ([cmpdup_id] ASC);
GO

-- Creating primary key on [cmp_id], [icmp_id] in table 'tb_mvto_compra_item____'
ALTER TABLE [dbo].[tb_mvto_compra_item____]
ADD CONSTRAINT [PK_tb_mvto_compra_item____]
    PRIMARY KEY CLUSTERED ([cmp_id], [icmp_id] ASC);
GO

-- Creating primary key on [divicmp_id] in table 'tb_mvto_compra_item_divergencia____'
ALTER TABLE [dbo].[tb_mvto_compra_item_divergencia____]
ADD CONSTRAINT [PK_tb_mvto_compra_item_divergencia____]
    PRIMARY KEY CLUSTERED ([divicmp_id] ASC);
GO

-- Creating primary key on [cmp_id], [icmp_id], [loteicmp_id] in table 'tb_mvto_compra_item_lote____'
ALTER TABLE [dbo].[tb_mvto_compra_item_lote____]
ADD CONSTRAINT [PK_tb_mvto_compra_item_lote____]
    PRIMARY KEY CLUSTERED ([cmp_id], [icmp_id], [loteicmp_id] ASC);
GO

-- Creating primary key on [mvtof_id] in table 'tb_mvto_fin____'
ALTER TABLE [dbo].[tb_mvto_fin____]
ADD CONSTRAINT [PK_tb_mvto_fin____]
    PRIMARY KEY CLUSTERED ([mvtof_id] ASC);
GO

-- Creating primary key on [uneg_id], [nfe_pdv], [nfe_id], [nfe_data] in table 'tb_nfe'
ALTER TABLE [dbo].[tb_nfe]
ADD CONSTRAINT [PK_tb_nfe]
    PRIMARY KEY CLUSTERED ([uneg_id], [nfe_pdv], [nfe_id], [nfe_data] ASC);
GO

-- Creating primary key on [uneg_id], [nfe_pdv], [nfe_id], [nfe_data], [cfop_id] in table 'tb_nfe_cfop'
ALTER TABLE [dbo].[tb_nfe_cfop]
ADD CONSTRAINT [PK_tb_nfe_cfop]
    PRIMARY KEY CLUSTERED ([uneg_id], [nfe_pdv], [nfe_id], [nfe_data], [cfop_id] ASC);
GO

-- Creating primary key on [uneg_id], [nfe_pdv], [nfe_id], [nfe_data] in table 'tb_nfe_danfe'
ALTER TABLE [dbo].[tb_nfe_danfe]
ADD CONSTRAINT [PK_tb_nfe_danfe]
    PRIMARY KEY CLUSTERED ([uneg_id], [nfe_pdv], [nfe_id], [nfe_data] ASC);
GO

-- Creating primary key on [uneg_id], [nfe_pdv], [nfe_id], [nfe_data], [final_seq] in table 'tb_nfe_finalizadora'
ALTER TABLE [dbo].[tb_nfe_finalizadora]
ADD CONSTRAINT [PK_tb_nfe_finalizadora]
    PRIMARY KEY CLUSTERED ([uneg_id], [nfe_pdv], [nfe_id], [nfe_data], [final_seq] ASC);
GO

-- Creating primary key on [uneg_id], [nfe_pdv], [nfe_id], [nfe_data], [infe_id] in table 'tb_nfe_item'
ALTER TABLE [dbo].[tb_nfe_item]
ADD CONSTRAINT [PK_tb_nfe_item]
    PRIMARY KEY CLUSTERED ([uneg_id], [nfe_pdv], [nfe_id], [nfe_data], [infe_id] ASC);
GO

-- Creating primary key on [paciente_id] in table 'tb_paciente_anvisa'
ALTER TABLE [dbo].[tb_paciente_anvisa]
ADD CONSTRAINT [PK_tb_paciente_anvisa]
    PRIMARY KEY CLUSTERED ([paciente_id] ASC);
GO

-- Creating primary key on [paf_ult_pv], [paf_ult_dav] in table 'tb_paf_numero'
ALTER TABLE [dbo].[tb_paf_numero]
ADD CONSTRAINT [PK_tb_paf_numero]
    PRIMARY KEY CLUSTERED ([paf_ult_pv], [paf_ult_dav] ASC);
GO

-- Creating primary key on [par_loja], [par_pdv] in table 'tb_parametro'
ALTER TABLE [dbo].[tb_parametro]
ADD CONSTRAINT [PK_tb_parametro]
    PRIMARY KEY CLUSTERED ([par_loja], [par_pdv] ASC);
GO

-- Creating primary key on [par_id] in table 'tb_parametro_comissao'
ALTER TABLE [dbo].[tb_parametro_comissao]
ADD CONSTRAINT [PK_tb_parametro_comissao]
    PRIMARY KEY CLUSTERED ([par_id] ASC);
GO

-- Creating primary key on [par_id] in table 'tb_parametro_descconv'
ALTER TABLE [dbo].[tb_parametro_descconv]
ADD CONSTRAINT [PK_tb_parametro_descconv]
    PRIMARY KEY CLUSTERED ([par_id] ASC);
GO

-- Creating primary key on [par_id] in table 'tb_parametro_descmax'
ALTER TABLE [dbo].[tb_parametro_descmax]
ADD CONSTRAINT [PK_tb_parametro_descmax]
    PRIMARY KEY CLUSTERED ([par_id] ASC);
GO

-- Creating primary key on [par_id] in table 'tb_parametro_descprod'
ALTER TABLE [dbo].[tb_parametro_descprod]
ADD CONSTRAINT [PK_tb_parametro_descprod]
    PRIMARY KEY CLUSTERED ([par_id] ASC);
GO

-- Creating primary key on [par_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [PK_tb_parametro_descvend]
    PRIMARY KEY CLUSTERED ([par_id] ASC);
GO

-- Creating primary key on [tb_id] in table 'tb_parametro_limpezas'
ALTER TABLE [dbo].[tb_parametro_limpezas]
ADD CONSTRAINT [PK_tb_parametro_limpezas]
    PRIMARY KEY CLUSTERED ([tb_id] ASC);
GO

-- Creating primary key on [par_id] in table 'tb_parametro_markup'
ALTER TABLE [dbo].[tb_parametro_markup]
ADD CONSTRAINT [PK_tb_parametro_markup]
    PRIMARY KEY CLUSTERED ([par_id] ASC);
GO

-- Creating primary key on [pbm_id] in table 'tb_pbm'
ALTER TABLE [dbo].[tb_pbm]
ADD CONSTRAINT [PK_tb_pbm]
    PRIMARY KEY CLUSTERED ([pbm_id] ASC);
GO

-- Creating primary key on [pedc_id] in table 'tb_pedido_compra____'
ALTER TABLE [dbo].[tb_pedido_compra____]
ADD CONSTRAINT [PK_tb_pedido_compra____]
    PRIMARY KEY CLUSTERED ([pedc_id] ASC);
GO

-- Creating primary key on [pedc_id], [ipedc_id] in table 'tb_pedido_compra_item____'
ALTER TABLE [dbo].[tb_pedido_compra_item____]
ADD CONSTRAINT [PK_tb_pedido_compra_item____]
    PRIMARY KEY CLUSTERED ([pedc_id], [ipedc_id] ASC);
GO

-- Creating primary key on [piscofins_id] in table 'tb_piscofins'
ALTER TABLE [dbo].[tb_piscofins]
ADD CONSTRAINT [PK_tb_piscofins]
    PRIMARY KEY CLUSTERED ([piscofins_id] ASC);
GO

-- Creating primary key on [ponto_id] in table 'tb_ponto'
ALTER TABLE [dbo].[tb_ponto]
ADD CONSTRAINT [PK_tb_ponto]
    PRIMARY KEY CLUSTERED ([ponto_id] ASC);
GO

-- Creating primary key on [motivo_id] in table 'tb_ponto_motivo'
ALTER TABLE [dbo].[tb_ponto_motivo]
ADD CONSTRAINT [PK_tb_ponto_motivo]
    PRIMARY KEY CLUSTERED ([motivo_id] ASC);
GO

-- Creating primary key on [pat_id] in table 'tb_princ_ativo'
ALTER TABLE [dbo].[tb_princ_ativo]
ADD CONSTRAINT [PK_tb_princ_ativo]
    PRIMARY KEY CLUSTERED ([pat_id] ASC);
GO

-- Creating primary key on [uneg_id], [plabel_pdv], [plabel_data], [plabel_id] in table 'tb_privatelabel'
ALTER TABLE [dbo].[tb_privatelabel]
ADD CONSTRAINT [PK_tb_privatelabel]
    PRIMARY KEY CLUSTERED ([uneg_id], [plabel_pdv], [plabel_data], [plabel_id] ASC);
GO

-- Creating primary key on [uneg_id], [plabel_pdv], [plabel_data], [plabel_id], [vpag_id] in table 'tb_privatelabel_finalizadora'
ALTER TABLE [dbo].[tb_privatelabel_finalizadora]
ADD CONSTRAINT [PK_tb_privatelabel_finalizadora]
    PRIMARY KEY CLUSTERED ([uneg_id], [plabel_pdv], [plabel_data], [plabel_id], [vpag_id] ASC);
GO

-- Creating primary key on [pro_id] in table 'tb_produto'
ALTER TABLE [dbo].[tb_produto]
ADD CONSTRAINT [PK_tb_produto]
    PRIMARY KEY CLUSTERED ([pro_id] ASC);
GO

-- Creating primary key on [pro_id], [barra_codigo] in table 'tb_produto_barra'
ALTER TABLE [dbo].[tb_produto_barra]
ADD CONSTRAINT [PK_tb_produto_barra]
    PRIMARY KEY CLUSTERED ([pro_id], [barra_codigo] ASC);
GO

-- Creating primary key on [cla_id] in table 'tb_produto_classe'
ALTER TABLE [dbo].[tb_produto_classe]
ADD CONSTRAINT [PK_tb_produto_classe]
    PRIMARY KEY CLUSTERED ([cla_id] ASC);
GO

-- Creating primary key on [fam_id], [grp_id], [cat_id], [scat_id] in table 'tb_produto_fam_categ_sub'
ALTER TABLE [dbo].[tb_produto_fam_categ_sub]
ADD CONSTRAINT [PK_tb_produto_fam_categ_sub]
    PRIMARY KEY CLUSTERED ([fam_id], [grp_id], [cat_id], [scat_id] ASC);
GO

-- Creating primary key on [fam_id], [grp_id], [cat_id] in table 'tb_produto_fam_categoria'
ALTER TABLE [dbo].[tb_produto_fam_categoria]
ADD CONSTRAINT [PK_tb_produto_fam_categoria]
    PRIMARY KEY CLUSTERED ([fam_id], [grp_id], [cat_id] ASC);
GO

-- Creating primary key on [fam_id], [grp_id] in table 'tb_produto_fam_grupo'
ALTER TABLE [dbo].[tb_produto_fam_grupo]
ADD CONSTRAINT [PK_tb_produto_fam_grupo]
    PRIMARY KEY CLUSTERED ([fam_id], [grp_id] ASC);
GO

-- Creating primary key on [fam_id] in table 'tb_produto_familia'
ALTER TABLE [dbo].[tb_produto_familia]
ADD CONSTRAINT [PK_tb_produto_familia]
    PRIMARY KEY CLUSTERED ([fam_id] ASC);
GO

-- Creating primary key on [pro_id], [kitpro_produto] in table 'tb_produto_kit'
ALTER TABLE [dbo].[tb_produto_kit]
ADD CONSTRAINT [PK_tb_produto_kit]
    PRIMARY KEY CLUSTERED ([pro_id], [kitpro_produto] ASC);
GO

-- Creating primary key on [lin_id] in table 'tb_produto_linha'
ALTER TABLE [dbo].[tb_produto_linha]
ADD CONSTRAINT [PK_tb_produto_linha]
    PRIMARY KEY CLUSTERED ([lin_id] ASC);
GO

-- Creating primary key on [piscofins_cod] in table 'tb_produto_piscofins'
ALTER TABLE [dbo].[tb_produto_piscofins]
ADD CONSTRAINT [PK_tb_produto_piscofins]
    PRIMARY KEY CLUSTERED ([piscofins_cod] ASC);
GO

-- Creating primary key on [pat_id] in table 'tb_produto_princativo'
ALTER TABLE [dbo].[tb_produto_princativo]
ADD CONSTRAINT [PK_tb_produto_princativo]
    PRIMARY KEY CLUSTERED ([pat_id] ASC);
GO

-- Creating primary key on [rec_id] in table 'tb_produto_receituario'
ALTER TABLE [dbo].[tb_produto_receituario]
ADD CONSTRAINT [PK_tb_produto_receituario]
    PRIMARY KEY CLUSTERED ([rec_id] ASC);
GO

-- Creating primary key on [sim_id] in table 'tb_produto_similaridade'
ALTER TABLE [dbo].[tb_produto_similaridade]
ADD CONSTRAINT [PK_tb_produto_similaridade]
    PRIMARY KEY CLUSTERED ([sim_id] ASC);
GO

-- Creating primary key on [prm_id] in table 'tb_promocao'
ALTER TABLE [dbo].[tb_promocao]
ADD CONSTRAINT [PK_tb_promocao]
    PRIMARY KEY CLUSTERED ([prm_id] ASC);
GO

-- Creating primary key on [tippro_id] in table 'tb_promocao_tipo'
ALTER TABLE [dbo].[tb_promocao_tipo]
ADD CONSTRAINT [PK_tb_promocao_tipo]
    PRIMARY KEY CLUSTERED ([tippro_id] ASC);
GO

-- Creating primary key on [uneg_id], [pin_pdv], [pin_data], [pin_id] in table 'tb_recarga'
ALTER TABLE [dbo].[tb_recarga]
ADD CONSTRAINT [PK_tb_recarga]
    PRIMARY KEY CLUSTERED ([uneg_id], [pin_pdv], [pin_data], [pin_id] ASC);
GO

-- Creating primary key on [uneg_id], [pin_pdv], [pin_data], [pin_id], [vpag_id] in table 'tb_recarga_finalizadora'
ALTER TABLE [dbo].[tb_recarga_finalizadora]
ADD CONSTRAINT [PK_tb_recarga_finalizadora]
    PRIMARY KEY CLUSTERED ([uneg_id], [pin_pdv], [pin_data], [pin_id], [vpag_id] ASC);
GO

-- Creating primary key on [ecf_numero_serie], [reduz_data_movimento] in table 'tb_reducao_z'
ALTER TABLE [dbo].[tb_reducao_z]
ADD CONSTRAINT [PK_tb_reducao_z]
    PRIMARY KEY CLUSTERED ([ecf_numero_serie], [reduz_data_movimento] ASC);
GO

-- Creating primary key on [reduz_itens_id], [ecf_numero_serie], [reduz_data_movimento] in table 'tb_reducao_z_itens'
ALTER TABLE [dbo].[tb_reducao_z_itens]
ADD CONSTRAINT [PK_tb_reducao_z_itens]
    PRIMARY KEY CLUSTERED ([reduz_itens_id], [ecf_numero_serie], [reduz_data_movimento] ASC);
GO

-- Creating primary key on [uneg_id], [sangriafl_pdv], [sangriaf_data], [sangriaf_id] in table 'tb_sangrias'
ALTER TABLE [dbo].[tb_sangrias]
ADD CONSTRAINT [PK_tb_sangrias]
    PRIMARY KEY CLUSTERED ([uneg_id], [sangriafl_pdv], [sangriaf_data], [sangriaf_id] ASC);
GO

-- Creating primary key on [serient_id] in table 'tb_serie_nota'
ALTER TABLE [dbo].[tb_serie_nota]
ADD CONSTRAINT [PK_tb_serie_nota]
    PRIMARY KEY CLUSTERED ([serient_id] ASC);
GO

-- Creating primary key on [id_sincronizacao] in table 'tb_sincronizacao'
ALTER TABLE [dbo].[tb_sincronizacao]
ADD CONSTRAINT [PK_tb_sincronizacao]
    PRIMARY KEY CLUSTERED ([id_sincronizacao] ASC);
GO

-- Creating primary key on [uneg_id], [suprimentof_pdv], [suprimentof_data], [suprimentof_id] in table 'tb_suprimentos'
ALTER TABLE [dbo].[tb_suprimentos]
ADD CONSTRAINT [PK_tb_suprimentos]
    PRIMARY KEY CLUSTERED ([uneg_id], [suprimentof_pdv], [suprimentof_data], [suprimentof_id] ASC);
GO

-- Creating primary key on [te_id_terminal] in table 'tb_terminal'
ALTER TABLE [dbo].[tb_terminal]
ADD CONSTRAINT [PK_tb_terminal]
    PRIMARY KEY CLUSTERED ([te_id_terminal] ASC);
GO

-- Creating primary key on [te_mobile_id] in table 'tb_terminal_mobile'
ALTER TABLE [dbo].[tb_terminal_mobile]
ADD CONSTRAINT [PK_tb_terminal_mobile]
    PRIMARY KEY CLUSTERED ([te_mobile_id] ASC);
GO

-- Creating primary key on [tiplog_id] in table 'tb_tipo_logradouro'
ALTER TABLE [dbo].[tb_tipo_logradouro]
ADD CONSTRAINT [PK_tb_tipo_logradouro]
    PRIMARY KEY CLUSTERED ([tiplog_id] ASC);
GO

-- Creating primary key on [cdmvto_codigo] in table 'tb_tipo_mvto_produto'
ALTER TABLE [dbo].[tb_tipo_mvto_produto]
ADD CONSTRAINT [PK_tb_tipo_mvto_produto]
    PRIMARY KEY CLUSTERED ([cdmvto_codigo] ASC);
GO

-- Creating primary key on [tipnota_id] in table 'tb_tipo_nota'
ALTER TABLE [dbo].[tb_tipo_nota]
ADD CONSTRAINT [PK_tb_tipo_nota]
    PRIMARY KEY CLUSTERED ([tipnota_id] ASC);
GO

-- Creating primary key on [transp_id] in table 'tb_transportadora'
ALTER TABLE [dbo].[tb_transportadora]
ADD CONSTRAINT [PK_tb_transportadora]
    PRIMARY KEY CLUSTERED ([transp_id] ASC);
GO

-- Creating primary key on [trb_id] in table 'tb_tributacao'
ALTER TABLE [dbo].[tb_tributacao]
ADD CONSTRAINT [PK_tb_tributacao]
    PRIMARY KEY CLUSTERED ([trb_id] ASC);
GO

-- Creating primary key on [uf_id] in table 'tb_uf'
ALTER TABLE [dbo].[tb_uf]
ADD CONSTRAINT [PK_tb_uf]
    PRIMARY KEY CLUSTERED ([uf_id] ASC);
GO

-- Creating primary key on [uneg_id] in table 'tb_unid_negocio'
ALTER TABLE [dbo].[tb_unid_negocio]
ADD CONSTRAINT [PK_tb_unid_negocio]
    PRIMARY KEY CLUSTERED ([uneg_id] ASC);
GO

-- Creating primary key on [guneg_id] in table 'tb_unid_negocio_grupo'
ALTER TABLE [dbo].[tb_unid_negocio_grupo]
ADD CONSTRAINT [PK_tb_unid_negocio_grupo]
    PRIMARY KEY CLUSTERED ([guneg_id] ASC);
GO

-- Creating primary key on [uneg_id] in table 'tb_unid_negocio_parametro'
ALTER TABLE [dbo].[tb_unid_negocio_parametro]
ADD CONSTRAINT [PK_tb_unid_negocio_parametro]
    PRIMARY KEY CLUSTERED ([uneg_id] ASC);
GO

-- Creating primary key on [usr_id] in table 'tb_usuario'
ALTER TABLE [dbo].[tb_usuario]
ADD CONSTRAINT [PK_tb_usuario]
    PRIMARY KEY CLUSTERED ([usr_id] ASC);
GO

-- Creating primary key on [bloq_id] in table 'tb_usuario_bloqueio'
ALTER TABLE [dbo].[tb_usuario_bloqueio]
ADD CONSTRAINT [PK_tb_usuario_bloqueio]
    PRIMARY KEY CLUSTERED ([bloq_id] ASC);
GO

-- Creating primary key on [dpto_id] in table 'tb_usuario_dpto'
ALTER TABLE [dbo].[tb_usuario_dpto]
ADD CONSTRAINT [PK_tb_usuario_dpto]
    PRIMARY KEY CLUSTERED ([dpto_id] ASC);
GO

-- Creating primary key on [funcao_id] in table 'tb_usuario_funcao'
ALTER TABLE [dbo].[tb_usuario_funcao]
ADD CONSTRAINT [PK_tb_usuario_funcao]
    PRIMARY KEY CLUSTERED ([funcao_id] ASC);
GO

-- Creating primary key on [grp_id] in table 'tb_usuario_grupo'
ALTER TABLE [dbo].[tb_usuario_grupo]
ADD CONSTRAINT [PK_tb_usuario_grupo]
    PRIMARY KEY CLUSTERED ([grp_id] ASC);
GO

-- Creating primary key on [venda_id], [uneg_id], [venda_pdv], [venda_data] in table 'tb_venda'
ALTER TABLE [dbo].[tb_venda]
ADD CONSTRAINT [PK_tb_venda]
    PRIMARY KEY CLUSTERED ([venda_id], [uneg_id], [venda_pdv], [venda_data] ASC);
GO

-- Creating primary key on [venda_dav_id], [venda_dav_data_preVenda], [uneg_id], [venda_pdv] in table 'tb_venda_dav'
ALTER TABLE [dbo].[tb_venda_dav]
ADD CONSTRAINT [PK_tb_venda_dav]
    PRIMARY KEY CLUSTERED ([venda_dav_id], [venda_dav_data_preVenda], [uneg_id], [venda_pdv] ASC);
GO

-- Creating primary key on [venda_dav_item_id], [venda_dav_data_preVenda], [venda_dav_id], [uneg_id], [venda_pdv] in table 'tb_venda_dav_item'
ALTER TABLE [dbo].[tb_venda_dav_item]
ADD CONSTRAINT [PK_tb_venda_dav_item]
    PRIMARY KEY CLUSTERED ([venda_dav_item_id], [venda_dav_data_preVenda], [venda_dav_id], [uneg_id], [venda_pdv] ASC);
GO

-- Creating primary key on [vestef_id], [uneg_id], [venda_id], [venda_pdv], [venda_data] in table 'tb_venda_estorno_tef'
ALTER TABLE [dbo].[tb_venda_estorno_tef]
ADD CONSTRAINT [PK_tb_venda_estorno_tef]
    PRIMARY KEY CLUSTERED ([vestef_id], [uneg_id], [venda_id], [venda_pdv], [venda_data] ASC);
GO

-- Creating primary key on [uneg_id], [venda_id], [venda_pdv], [venda_data], [vitem_id] in table 'tb_venda_item'
ALTER TABLE [dbo].[tb_venda_item]
ADD CONSTRAINT [PK_tb_venda_item]
    PRIMARY KEY CLUSTERED ([uneg_id], [venda_id], [venda_pdv], [venda_data], [vitem_id] ASC);
GO

-- Creating primary key on [uneg_id], [venda_id], [venda_pdv], [venda_data], [vpag_id] in table 'tb_venda_pagamento'
ALTER TABLE [dbo].[tb_venda_pagamento]
ADD CONSTRAINT [PK_tb_venda_pagamento]
    PRIMARY KEY CLUSTERED ([uneg_id], [venda_id], [venda_pdv], [venda_data], [vpag_id] ASC);
GO

-- Creating primary key on [vendaPv_id], [vendaPv_data_preVenda], [uneg_id], [venda_pdv] in table 'tb_venda_prevenda'
ALTER TABLE [dbo].[tb_venda_prevenda]
ADD CONSTRAINT [PK_tb_venda_prevenda]
    PRIMARY KEY CLUSTERED ([vendaPv_id], [vendaPv_data_preVenda], [uneg_id], [venda_pdv] ASC);
GO

-- Creating primary key on [vendaPv_item_id], [vendaPv_data_preVenda], [vendaPv_id], [uneg_id], [venda_pdv] in table 'tb_venda_prevenda_item'
ALTER TABLE [dbo].[tb_venda_prevenda_item]
ADD CONSTRAINT [PK_tb_venda_prevenda_item]
    PRIMARY KEY CLUSTERED ([vendaPv_item_id], [vendaPv_data_preVenda], [vendaPv_id], [uneg_id], [venda_pdv] ASC);
GO

-- Creating primary key on [vendaPv_id], [vendaPv_data_preVenda], [uneg_id], [venda_pdv], [vpag_id] in table 'tb_venda_prevenda_pgto'
ALTER TABLE [dbo].[tb_venda_prevenda_pgto]
ADD CONSTRAINT [PK_tb_venda_prevenda_pgto]
    PRIMARY KEY CLUSTERED ([vendaPv_id], [vendaPv_data_preVenda], [uneg_id], [venda_pdv], [vpag_id] ASC);
GO

-- Creating primary key on [ManagerUpdateID] in table 'tbManagerUpdates'
ALTER TABLE [dbo].[tbManagerUpdates]
ADD CONSTRAINT [PK_tbManagerUpdates]
    PRIMARY KEY CLUSTERED ([ManagerUpdateID] ASC);
GO

-- Creating primary key on [per_id], [abcf_id], [uf_id] in table 'tbr_abcfarma_uf'
ALTER TABLE [dbo].[tbr_abcfarma_uf]
ADD CONSTRAINT [PK_tbr_abcfarma_uf]
    PRIMARY KEY CLUSTERED ([per_id], [abcf_id], [uf_id] ASC);
GO

-- Creating primary key on [cnv_id], [cli_id] in table 'tbr_convenio_cliente'
ALTER TABLE [dbo].[tbr_convenio_cliente]
ADD CONSTRAINT [PK_tbr_convenio_cliente]
    PRIMARY KEY CLUSTERED ([cnv_id], [cli_id] ASC);
GO

-- Creating primary key on [cnv_id], [final_id], [subfin_id] in table 'tbr_convenio_finalizadora_sub'
ALTER TABLE [dbo].[tbr_convenio_finalizadora_sub]
ADD CONSTRAINT [PK_tbr_convenio_finalizadora_sub]
    PRIMARY KEY CLUSTERED ([cnv_id], [final_id], [subfin_id] ASC);
GO

-- Creating primary key on [cnv_id], [uneg_id] in table 'tbr_convenio_un'
ALTER TABLE [dbo].[tbr_convenio_un]
ADD CONSTRAINT [PK_tbr_convenio_un]
    PRIMARY KEY CLUSTERED ([cnv_id], [uneg_id] ASC);
GO

-- Creating primary key on [fab_id], [pro_id] in table 'tbr_dicionario_produto'
ALTER TABLE [dbo].[tbr_dicionario_produto]
ADD CONSTRAINT [PK_tbr_dicionario_produto]
    PRIMARY KEY CLUSTERED ([fab_id], [pro_id] ASC);
GO

-- Creating primary key on [uneg_id], [fab_id], [div_id] in table 'tbr_dicionario_un'
ALTER TABLE [dbo].[tbr_dicionario_un]
ADD CONSTRAINT [PK_tbr_dicionario_un]
    PRIMARY KEY CLUSTERED ([uneg_id], [fab_id], [div_id] ASC);
GO

-- Creating primary key on [dpto_id], [apl_id] in table 'tbr_dpto_aplicativo'
ALTER TABLE [dbo].[tbr_dpto_aplicativo]
ADD CONSTRAINT [PK_tbr_dpto_aplicativo]
    PRIMARY KEY CLUSTERED ([dpto_id], [apl_id] ASC);
GO

-- Creating primary key on [final_id], [ecf_numero_serie] in table 'tbr_ecf_finalizadora'
ALTER TABLE [dbo].[tbr_ecf_finalizadora]
ADD CONSTRAINT [PK_tbr_ecf_finalizadora]
    PRIMARY KEY CLUSTERED ([final_id], [ecf_numero_serie] ASC);
GO

-- Creating primary key on [trb_id], [ecf_numero_serie] in table 'tbr_ecf_tributacao'
ALTER TABLE [dbo].[tbr_ecf_tributacao]
ADD CONSTRAINT [PK_tbr_ecf_tributacao]
    PRIMARY KEY CLUSTERED ([trb_id], [ecf_numero_serie] ASC);
GO

-- Creating primary key on [final_id], [subfin_id], [uneg_id] in table 'tbr_finalizadora_sub_un'
ALTER TABLE [dbo].[tbr_finalizadora_sub_un]
ADD CONSTRAINT [PK_tbr_finalizadora_sub_un]
    PRIMARY KEY CLUSTERED ([final_id], [subfin_id], [uneg_id] ASC);
GO

-- Creating primary key on [uneg_id], [final_id] in table 'tbr_finalizadora_un'
ALTER TABLE [dbo].[tbr_finalizadora_un]
ADD CONSTRAINT [PK_tbr_finalizadora_un]
    PRIMARY KEY CLUSTERED ([uneg_id], [final_id] ASC);
GO

-- Creating primary key on [cmp_id], [cfop_id] in table 'tbr_mvto_compra_cfop____'
ALTER TABLE [dbo].[tbr_mvto_compra_cfop____]
ADD CONSTRAINT [PK_tbr_mvto_compra_cfop____]
    PRIMARY KEY CLUSTERED ([cmp_id], [cfop_id] ASC);
GO

-- Creating primary key on [cmp_id], [cmpdup_id] in table 'tbr_mvto_compra_dup____'
ALTER TABLE [dbo].[tbr_mvto_compra_dup____]
ADD CONSTRAINT [PK_tbr_mvto_compra_dup____]
    PRIMARY KEY CLUSTERED ([cmp_id], [cmpdup_id] ASC);
GO

-- Creating primary key on [par_id], [uneg_id] in table 'tbr_parametro_descprod_uneg'
ALTER TABLE [dbo].[tbr_parametro_descprod_uneg]
ADD CONSTRAINT [PK_tbr_parametro_descprod_uneg]
    PRIMARY KEY CLUSTERED ([par_id], [uneg_id] ASC);
GO

-- Creating primary key on [par_id], [uneg_id] in table 'tbr_parametro_descvend_uneg'
ALTER TABLE [dbo].[tbr_parametro_descvend_uneg]
ADD CONSTRAINT [PK_tbr_parametro_descvend_uneg]
    PRIMARY KEY CLUSTERED ([par_id], [uneg_id] ASC);
GO

-- Creating primary key on [par_id], [uneg_id] in table 'tbr_parametro_markup_uneg'
ALTER TABLE [dbo].[tbr_parametro_markup_uneg]
ADD CONSTRAINT [PK_tbr_parametro_markup_uneg]
    PRIMARY KEY CLUSTERED ([par_id], [uneg_id] ASC);
GO

-- Creating primary key on [uneg_id], [pro_id] in table 'tbr_produto_estoque_dia'
ALTER TABLE [dbo].[tbr_produto_estoque_dia]
ADD CONSTRAINT [PK_tbr_produto_estoque_dia]
    PRIMARY KEY CLUSTERED ([uneg_id], [pro_id] ASC);
GO

-- Creating primary key on [uneg_id], [pro_id], [lote_numero], [lote_validade] in table 'tbr_produto_estoque_lote'
ALTER TABLE [dbo].[tbr_produto_estoque_lote]
ADD CONSTRAINT [PK_tbr_produto_estoque_lote]
    PRIMARY KEY CLUSTERED ([uneg_id], [pro_id], [lote_numero], [lote_validade] ASC);
GO

-- Creating primary key on [pro_id], [uf_id] in table 'tbr_produto_tributacao'
ALTER TABLE [dbo].[tbr_produto_tributacao]
ADD CONSTRAINT [PK_tbr_produto_tributacao]
    PRIMARY KEY CLUSTERED ([pro_id], [uf_id] ASC);
GO

-- Creating primary key on [uneg_id], [pro_id] in table 'tbr_produto_uneg'
ALTER TABLE [dbo].[tbr_produto_uneg]
ADD CONSTRAINT [PK_tbr_produto_uneg]
    PRIMARY KEY CLUSTERED ([uneg_id], [pro_id] ASC);
GO

-- Creating primary key on [prm_id], [pro_id] in table 'tbr_promocao_produto'
ALTER TABLE [dbo].[tbr_promocao_produto]
ADD CONSTRAINT [PK_tbr_promocao_produto]
    PRIMARY KEY CLUSTERED ([prm_id], [pro_id] ASC);
GO

-- Creating primary key on [tb_convenio_cnv_id], [tb_promocao_prm_id] in table 'tbr_promocao_convenio'
ALTER TABLE [dbo].[tbr_promocao_convenio]
ADD CONSTRAINT [PK_tbr_promocao_convenio]
    PRIMARY KEY NONCLUSTERED ([tb_convenio_cnv_id], [tb_promocao_prm_id] ASC);
GO

-- Creating primary key on [tb_promocao_prm_id], [tb_unid_negocio_uneg_id] in table 'tbr_promocao_uneg'
ALTER TABLE [dbo].[tbr_promocao_uneg]
ADD CONSTRAINT [PK_tbr_promocao_uneg]
    PRIMARY KEY NONCLUSTERED ([tb_promocao_prm_id], [tb_unid_negocio_uneg_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [abcf_id] in table 'tb_produto'
ALTER TABLE [dbo].[tb_produto]
ADD CONSTRAINT [FK_tb_produto_tb_abcfarma]
    FOREIGN KEY ([abcf_id])
    REFERENCES [dbo].[tb_abcfarma]
        ([abcf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_produto_tb_abcfarma'
CREATE INDEX [IX_FK_tb_produto_tb_abcfarma]
ON [dbo].[tb_produto]
    ([abcf_id]);
GO

-- Creating foreign key on [abcf_id] in table 'tbr_abcfarma_uf'
ALTER TABLE [dbo].[tbr_abcfarma_uf]
ADD CONSTRAINT [FK_tbr_abcfarma_uf_tb_abcfarma]
    FOREIGN KEY ([abcf_id])
    REFERENCES [dbo].[tb_abcfarma]
        ([abcf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_abcfarma_uf_tb_abcfarma'
CREATE INDEX [IX_FK_tbr_abcfarma_uf_tb_abcfarma]
ON [dbo].[tbr_abcfarma_uf]
    ([abcf_id]);
GO

-- Creating foreign key on [per_id] in table 'tbr_abcfarma_uf'
ALTER TABLE [dbo].[tbr_abcfarma_uf]
ADD CONSTRAINT [FK_tbr_abcfarma_uf_tb_abcfarma_periodo]
    FOREIGN KEY ([per_id])
    REFERENCES [dbo].[tb_abcfarma_periodo]
        ([per_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [pro_id] in table 'tb_agenda_produto'
ALTER TABLE [dbo].[tb_agenda_produto]
ADD CONSTRAINT [FK_tb_agenda_produto_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_agenda_produto_tb_produto'
CREATE INDEX [IX_FK_tb_agenda_produto_tb_produto]
ON [dbo].[tb_agenda_produto]
    ([pro_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tb_agenda_produto'
ALTER TABLE [dbo].[tb_agenda_produto]
ADD CONSTRAINT [FK_tb_agenda_produto_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [agen_agendador] in table 'tb_agenda_produto'
ALTER TABLE [dbo].[tb_agenda_produto]
ADD CONSTRAINT [FK_tb_agenda_produto_tb_usuario]
    FOREIGN KEY ([agen_agendador])
    REFERENCES [dbo].[tb_usuario]
        ([usr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_agenda_produto_tb_usuario'
CREATE INDEX [IX_FK_tb_agenda_produto_tb_usuario]
ON [dbo].[tb_agenda_produto]
    ([agen_agendador]);
GO

-- Creating foreign key on [agen_vendedor] in table 'tb_agenda_produto'
ALTER TABLE [dbo].[tb_agenda_produto]
ADD CONSTRAINT [FK_tb_agenda_produto_tb_usuario1]
    FOREIGN KEY ([agen_vendedor])
    REFERENCES [dbo].[tb_usuario]
        ([usr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_agenda_produto_tb_usuario1'
CREATE INDEX [IX_FK_tb_agenda_produto_tb_usuario1]
ON [dbo].[tb_agenda_produto]
    ([agen_vendedor]);
GO

-- Creating foreign key on [ibge_codigo] in table 'tb_cadastro_contador'
ALTER TABLE [dbo].[tb_cadastro_contador]
ADD CONSTRAINT [FK_tb_cadastro_contador_tb_ibge]
    FOREIGN KEY ([ibge_codigo])
    REFERENCES [dbo].[tb_ibge]
        ([ibge_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_cadastro_contador_tb_ibge'
CREATE INDEX [IX_FK_tb_cadastro_contador_tb_ibge]
ON [dbo].[tb_cadastro_contador]
    ([ibge_codigo]);
GO

-- Creating foreign key on [cadcont_id] in table 'tb_unid_negocio'
ALTER TABLE [dbo].[tb_unid_negocio]
ADD CONSTRAINT [FK_tb_unid_negocio_tb_cadastro_contador]
    FOREIGN KEY ([cadcont_id])
    REFERENCES [dbo].[tb_cadastro_contador]
        ([cadcont_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_unid_negocio_tb_cadastro_contador'
CREATE INDEX [IX_FK_tb_unid_negocio_tb_cadastro_contador]
ON [dbo].[tb_unid_negocio]
    ([cadcont_id]);
GO

-- Creating foreign key on [cargo_id] in table 'tb_funcionario'
ALTER TABLE [dbo].[tb_funcionario]
ADD CONSTRAINT [FK_tb_funcionario_tb_cargo]
    FOREIGN KEY ([cargo_id])
    REFERENCES [dbo].[tb_cargo]
        ([cargo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_funcionario_tb_cargo'
CREATE INDEX [IX_FK_tb_funcionario_tb_cargo]
ON [dbo].[tb_funcionario]
    ([cargo_id]);
GO

-- Creating foreign key on [cfop_id] in table 'tb_mvto_compra_item____'
ALTER TABLE [dbo].[tb_mvto_compra_item____]
ADD CONSTRAINT [FK_tb_mvto_compra_item_tb_cfop]
    FOREIGN KEY ([cfop_id])
    REFERENCES [dbo].[tb_cfop]
        ([cfop_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_mvto_compra_item_tb_cfop'
CREATE INDEX [IX_FK_tb_mvto_compra_item_tb_cfop]
ON [dbo].[tb_mvto_compra_item____]
    ([cfop_id]);
GO

-- Creating foreign key on [cfop_id] in table 'tb_nfe_item'
ALTER TABLE [dbo].[tb_nfe_item]
ADD CONSTRAINT [FK_tb_nfe_item_tb_cfop]
    FOREIGN KEY ([cfop_id])
    REFERENCES [dbo].[tb_cfop]
        ([cfop_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_nfe_item_tb_cfop'
CREATE INDEX [IX_FK_tb_nfe_item_tb_cfop]
ON [dbo].[tb_nfe_item]
    ([cfop_id]);
GO

-- Creating foreign key on [cfop_id] in table 'tb_tipo_nota'
ALTER TABLE [dbo].[tb_tipo_nota]
ADD CONSTRAINT [FK_tb_tipo_nota_tb_cfop]
    FOREIGN KEY ([cfop_id])
    REFERENCES [dbo].[tb_cfop]
        ([cfop_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_tipo_nota_tb_cfop'
CREATE INDEX [IX_FK_tb_tipo_nota_tb_cfop]
ON [dbo].[tb_tipo_nota]
    ([cfop_id]);
GO

-- Creating foreign key on [cfop_id] in table 'tbr_mvto_compra_cfop____'
ALTER TABLE [dbo].[tbr_mvto_compra_cfop____]
ADD CONSTRAINT [FK_tbr_mvto_compra_cfop_tb_cfop]
    FOREIGN KEY ([cfop_id])
    REFERENCES [dbo].[tb_cfop]
        ([cfop_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_mvto_compra_cfop_tb_cfop'
CREATE INDEX [IX_FK_tbr_mvto_compra_cfop_tb_cfop]
ON [dbo].[tbr_mvto_compra_cfop____]
    ([cfop_id]);
GO

-- Creating foreign key on [cfop_id] in table 'tb_nfe_cfop'
ALTER TABLE [dbo].[tb_nfe_cfop]
ADD CONSTRAINT [FK_tbr_mvto_nfe_cfop_tb_cfop]
    FOREIGN KEY ([cfop_id])
    REFERENCES [dbo].[tb_cfop]
        ([cfop_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_mvto_nfe_cfop_tb_cfop'
CREATE INDEX [IX_FK_tbr_mvto_nfe_cfop_tb_cfop]
ON [dbo].[tb_nfe_cfop]
    ([cfop_id]);
GO

-- Creating foreign key on [chkin_id] in table 'tb_checkin_item_tmp'
ALTER TABLE [dbo].[tb_checkin_item_tmp]
ADD CONSTRAINT [FK_tb_checkin_item_tmp_tb_checkin_tmp]
    FOREIGN KEY ([chkin_id])
    REFERENCES [dbo].[tb_checkin_tmp]
        ([chkin_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [pro_id] in table 'tb_checkin_item_tmp'
ALTER TABLE [dbo].[tb_checkin_item_tmp]
ADD CONSTRAINT [FK_tb_checkin_item_tmp_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_checkin_item_tmp_tb_produto'
CREATE INDEX [IX_FK_tb_checkin_item_tmp_tb_produto]
ON [dbo].[tb_checkin_item_tmp]
    ([pro_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_checkin_tmp'
ALTER TABLE [dbo].[tb_checkin_tmp]
ADD CONSTRAINT [FK_tb_checkin_tmp_tb_fornecedor_divisao]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_checkin_tmp_tb_fornecedor_divisao'
CREATE INDEX [IX_FK_tb_checkin_tmp_tb_fornecedor_divisao]
ON [dbo].[tb_checkin_tmp]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [pedc_id] in table 'tb_checkin_tmp'
ALTER TABLE [dbo].[tb_checkin_tmp]
ADD CONSTRAINT [FK_tb_checkin_tmp_tb_pe]
    FOREIGN KEY ([pedc_id])
    REFERENCES [dbo].[tb_pedido_compra____]
        ([pedc_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_checkin_tmp_tb_pe'
CREATE INDEX [IX_FK_tb_checkin_tmp_tb_pe]
ON [dbo].[tb_checkin_tmp]
    ([pedc_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tb_checkin_tmp'
ALTER TABLE [dbo].[tb_checkin_tmp]
ADD CONSTRAINT [FK_tb_checkin_tmp_tb_un]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_checkin_tmp_tb_un'
CREATE INDEX [IX_FK_tb_checkin_tmp_tb_un]
ON [dbo].[tb_checkin_tmp]
    ([uneg_id]);
GO

-- Creating foreign key on [cli_id] in table 'tb_cliente_endereco'
ALTER TABLE [dbo].[tb_cliente_endereco]
ADD CONSTRAINT [FK_tb_cliente_endereco_tb_cliente]
    FOREIGN KEY ([cli_id])
    REFERENCES [dbo].[tb_cliente]
        ([cli_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [bloq_id] in table 'tb_cliente'
ALTER TABLE [dbo].[tb_cliente]
ADD CONSTRAINT [FK_tb_cliente_tb_cliente_bloqueio]
    FOREIGN KEY ([bloq_id])
    REFERENCES [dbo].[tb_cliente_bloqueio]
        ([bloq_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_cliente_tb_cliente_bloqueio'
CREATE INDEX [IX_FK_tb_cliente_tb_cliente_bloqueio]
ON [dbo].[tb_cliente]
    ([bloq_id]);
GO

-- Creating foreign key on [prm_id] in table 'tb_cliente'
ALTER TABLE [dbo].[tb_cliente]
ADD CONSTRAINT [FK_tb_cliente_tb_promocao]
    FOREIGN KEY ([prm_id])
    REFERENCES [dbo].[tb_promocao]
        ([prm_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_cliente_tb_promocao'
CREATE INDEX [IX_FK_tb_cliente_tb_promocao]
ON [dbo].[tb_cliente]
    ([prm_id]);
GO

-- Creating foreign key on [uf_id] in table 'tb_cliente'
ALTER TABLE [dbo].[tb_cliente]
ADD CONSTRAINT [FK_tb_cliente_tb_uf]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_cliente_tb_uf'
CREATE INDEX [IX_FK_tb_cliente_tb_uf]
ON [dbo].[tb_cliente]
    ([uf_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tb_cliente'
ALTER TABLE [dbo].[tb_cliente]
ADD CONSTRAINT [FK_tb_cliente_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_cliente_tb_unid_negocio'
CREATE INDEX [IX_FK_tb_cliente_tb_unid_negocio]
ON [dbo].[tb_cliente]
    ([uneg_id]);
GO

-- Creating foreign key on [cli_id] in table 'tb_convenio'
ALTER TABLE [dbo].[tb_convenio]
ADD CONSTRAINT [FK_tb_convenio_tb_cliente]
    FOREIGN KEY ([cli_id])
    REFERENCES [dbo].[tb_cliente]
        ([cli_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_convenio_tb_cliente'
CREATE INDEX [IX_FK_tb_convenio_tb_cliente]
ON [dbo].[tb_convenio]
    ([cli_id]);
GO

-- Creating foreign key on [cli_id] in table 'tb_crediario'
ALTER TABLE [dbo].[tb_crediario]
ADD CONSTRAINT [FK_tb_crediario_tb_cliente]
    FOREIGN KEY ([cli_id])
    REFERENCES [dbo].[tb_cliente]
        ([cli_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_crediario_tb_cliente'
CREATE INDEX [IX_FK_tb_crediario_tb_cliente]
ON [dbo].[tb_crediario]
    ([cli_id]);
GO

-- Creating foreign key on [cli_id] in table 'tb_funcionario'
ALTER TABLE [dbo].[tb_funcionario]
ADD CONSTRAINT [FK_tb_funcionario_tb_cliente]
    FOREIGN KEY ([cli_id])
    REFERENCES [dbo].[tb_cliente]
        ([cli_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_funcionario_tb_cliente'
CREATE INDEX [IX_FK_tb_funcionario_tb_cliente]
ON [dbo].[tb_funcionario]
    ([cli_id]);
GO

-- Creating foreign key on [cli_id] in table 'tb_venda_dav'
ALTER TABLE [dbo].[tb_venda_dav]
ADD CONSTRAINT [FK_tb_venda_dav_tb_cliente]
    FOREIGN KEY ([cli_id])
    REFERENCES [dbo].[tb_cliente]
        ([cli_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_dav_tb_cliente'
CREATE INDEX [IX_FK_tb_venda_dav_tb_cliente]
ON [dbo].[tb_venda_dav]
    ([cli_id]);
GO

-- Creating foreign key on [cli_id] in table 'tb_venda_pagamento'
ALTER TABLE [dbo].[tb_venda_pagamento]
ADD CONSTRAINT [FK_tb_venda_pagamento_tb_cliente]
    FOREIGN KEY ([cli_id])
    REFERENCES [dbo].[tb_cliente]
        ([cli_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_pagamento_tb_cliente'
CREATE INDEX [IX_FK_tb_venda_pagamento_tb_cliente]
ON [dbo].[tb_venda_pagamento]
    ([cli_id]);
GO

-- Creating foreign key on [cli_id] in table 'tb_venda_prevenda'
ALTER TABLE [dbo].[tb_venda_prevenda]
ADD CONSTRAINT [FK_tb_venda_prevenda_tb_cliente]
    FOREIGN KEY ([cli_id])
    REFERENCES [dbo].[tb_cliente]
        ([cli_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_prevenda_tb_cliente'
CREATE INDEX [IX_FK_tb_venda_prevenda_tb_cliente]
ON [dbo].[tb_venda_prevenda]
    ([cli_id]);
GO

-- Creating foreign key on [cli_id] in table 'tb_venda'
ALTER TABLE [dbo].[tb_venda]
ADD CONSTRAINT [FK_tb_venda_tb_cliente]
    FOREIGN KEY ([cli_id])
    REFERENCES [dbo].[tb_cliente]
        ([cli_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_tb_cliente'
CREATE INDEX [IX_FK_tb_venda_tb_cliente]
ON [dbo].[tb_venda]
    ([cli_id]);
GO

-- Creating foreign key on [cli_id] in table 'tbr_convenio_cliente'
ALTER TABLE [dbo].[tbr_convenio_cliente]
ADD CONSTRAINT [FK_tbr_convenio_cliente_tb_cliente1]
    FOREIGN KEY ([cli_id])
    REFERENCES [dbo].[tb_cliente]
        ([cli_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_convenio_cliente_tb_cliente1'
CREATE INDEX [IX_FK_tbr_convenio_cliente_tb_cliente1]
ON [dbo].[tbr_convenio_cliente]
    ([cli_id]);
GO

-- Creating foreign key on [uf_id] in table 'tb_cliente_anvisa'
ALTER TABLE [dbo].[tb_cliente_anvisa]
ADD CONSTRAINT [FK_tb_cliente_anvisa_tb_cliente_anvisa]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_cliente_anvisa_tb_cliente_anvisa'
CREATE INDEX [IX_FK_tb_cliente_anvisa_tb_cliente_anvisa]
ON [dbo].[tb_cliente_anvisa]
    ([uf_id]);
GO

-- Creating foreign key on [bloq_id] in table 'tbr_convenio_cliente'
ALTER TABLE [dbo].[tbr_convenio_cliente]
ADD CONSTRAINT [FK_tbr_convenio_cliente_tb_cliente_bloqueio]
    FOREIGN KEY ([bloq_id])
    REFERENCES [dbo].[tb_cliente_bloqueio]
        ([bloq_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_convenio_cliente_tb_cliente_bloqueio'
CREATE INDEX [IX_FK_tbr_convenio_cliente_tb_cliente_bloqueio]
ON [dbo].[tbr_convenio_cliente]
    ([bloq_id]);
GO

-- Creating foreign key on [uf_id] in table 'tb_cliente_endereco'
ALTER TABLE [dbo].[tb_cliente_endereco]
ADD CONSTRAINT [FK_tb_cliente_endereco_tb_uf]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_cliente_endereco_tb_uf'
CREATE INDEX [IX_FK_tb_cliente_endereco_tb_uf]
ON [dbo].[tb_cliente_endereco]
    ([uf_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tb_cliente_fiscal'
ALTER TABLE [dbo].[tb_cliente_fiscal]
ADD CONSTRAINT [FK_tb_cliente_fiscal_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_cliente_fiscal_tb_unid_negocio'
CREATE INDEX [IX_FK_tb_cliente_fiscal_tb_unid_negocio]
ON [dbo].[tb_cliente_fiscal]
    ([uneg_id]);
GO

-- Creating foreign key on [usr_id] in table 'tb_cliente_fiscal'
ALTER TABLE [dbo].[tb_cliente_fiscal]
ADD CONSTRAINT [FK_tb_cliente_fiscal_tb_usuario]
    FOREIGN KEY ([usr_id])
    REFERENCES [dbo].[tb_usuario]
        ([usr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_cliente_fiscal_tb_usuario'
CREATE INDEX [IX_FK_tb_cliente_fiscal_tb_usuario]
ON [dbo].[tb_cliente_fiscal]
    ([usr_id]);
GO

-- Creating foreign key on [cli_fisc_cpf_cnpj] in table 'tb_venda'
ALTER TABLE [dbo].[tb_venda]
ADD CONSTRAINT [FK_tb_venda_tb_cliente_fiscal]
    FOREIGN KEY ([cli_fisc_cpf_cnpj])
    REFERENCES [dbo].[tb_cliente_fiscal]
        ([cli_fisc_cpf_cnpj])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_tb_cliente_fiscal'
CREATE INDEX [IX_FK_tb_venda_tb_cliente_fiscal]
ON [dbo].[tb_venda]
    ([cli_fisc_cpf_cnpj]);
GO

-- Creating foreign key on [cr_cons_id] in table 'tb_conselho_regional'
ALTER TABLE [dbo].[tb_conselho_regional]
ADD CONSTRAINT [FK_tb_conselho_regional_tb_conselho]
    FOREIGN KEY ([cr_cons_id])
    REFERENCES [dbo].[tb_conselho]
        ([cs_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_conselho_regional_tb_conselho'
CREATE INDEX [IX_FK_tb_conselho_regional_tb_conselho]
ON [dbo].[tb_conselho_regional]
    ([cr_cons_id]);
GO

-- Creating foreign key on [prazo_id] in table 'tb_convenio'
ALTER TABLE [dbo].[tb_convenio]
ADD CONSTRAINT [FK_tb_convenio_prazo]
    FOREIGN KEY ([prazo_id])
    REFERENCES [dbo].[tb_financeiro_prazo]
        ([prazo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_convenio_prazo'
CREATE INDEX [IX_FK_tb_convenio_prazo]
ON [dbo].[tb_convenio]
    ([prazo_id]);
GO

-- Creating foreign key on [cnv_id] in table 'tb_crediario'
ALTER TABLE [dbo].[tb_crediario]
ADD CONSTRAINT [FK_tb_crediario_tb_convenio]
    FOREIGN KEY ([cnv_id])
    REFERENCES [dbo].[tb_convenio]
        ([cnv_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_crediario_tb_convenio'
CREATE INDEX [IX_FK_tb_crediario_tb_convenio]
ON [dbo].[tb_crediario]
    ([cnv_id]);
GO

-- Creating foreign key on [cnv_id] in table 'tb_funcionario'
ALTER TABLE [dbo].[tb_funcionario]
ADD CONSTRAINT [FK_tb_funcionario_tb_convenio]
    FOREIGN KEY ([cnv_id])
    REFERENCES [dbo].[tb_convenio]
        ([cnv_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_funcionario_tb_convenio'
CREATE INDEX [IX_FK_tb_funcionario_tb_convenio]
ON [dbo].[tb_funcionario]
    ([cnv_id]);
GO

-- Creating foreign key on [cnv_id] in table 'tb_parametro_descconv'
ALTER TABLE [dbo].[tb_parametro_descconv]
ADD CONSTRAINT [FK_tb_parametro_descconv_tb_convenio]
    FOREIGN KEY ([cnv_id])
    REFERENCES [dbo].[tb_convenio]
        ([cnv_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descconv_tb_convenio'
CREATE INDEX [IX_FK_tb_parametro_descconv_tb_convenio]
ON [dbo].[tb_parametro_descconv]
    ([cnv_id]);
GO

-- Creating foreign key on [cnv_id] in table 'tbr_convenio_cliente'
ALTER TABLE [dbo].[tbr_convenio_cliente]
ADD CONSTRAINT [FK_tbr_convenio_cliente_tb_cliente]
    FOREIGN KEY ([cnv_id])
    REFERENCES [dbo].[tb_convenio]
        ([cnv_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cnv_id] in table 'tbr_convenio_finalizadora_sub'
ALTER TABLE [dbo].[tbr_convenio_finalizadora_sub]
ADD CONSTRAINT [FK_tbr_convenio_finalizadora]
    FOREIGN KEY ([cnv_id])
    REFERENCES [dbo].[tb_convenio]
        ([cnv_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cnv_id] in table 'tbr_convenio_un'
ALTER TABLE [dbo].[tbr_convenio_un]
ADD CONSTRAINT [FK_tbr_convenio_un2_tb_co]
    FOREIGN KEY ([cnv_id])
    REFERENCES [dbo].[tb_convenio]
        ([cnv_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uneg_id] in table 'tb_crediario'
ALTER TABLE [dbo].[tb_crediario]
ADD CONSTRAINT [FK_tb_crediario_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_crediario_tb_unid_negocio'
CREATE INDEX [IX_FK_tb_crediario_tb_unid_negocio]
ON [dbo].[tb_crediario]
    ([uneg_id]);
GO

-- Creating foreign key on [crm_id], [crm_tipo], [uf_id] in table 'tb_crm_endereco'
ALTER TABLE [dbo].[tb_crm_endereco]
ADD CONSTRAINT [FK_tb_crm_endereco_crm_id_crm_tipo_uf_id]
    FOREIGN KEY ([crm_id], [crm_tipo], [uf_id])
    REFERENCES [dbo].[tb_crm]
        ([crm_id], [crm_tipo], [uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_crm_endereco_crm_id_crm_tipo_uf_id'
CREATE INDEX [IX_FK_tb_crm_endereco_crm_id_crm_tipo_uf_id]
ON [dbo].[tb_crm_endereco]
    ([crm_id], [crm_tipo], [uf_id]);
GO

-- Creating foreign key on [uf_id] in table 'tb_crm'
ALTER TABLE [dbo].[tb_crm]
ADD CONSTRAINT [FK_tb_crm_tb_uf]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_crm_tb_uf'
CREATE INDEX [IX_FK_tb_crm_tb_uf]
ON [dbo].[tb_crm]
    ([uf_id]);
GO

-- Creating foreign key on [uf_id] in table 'tb_crm_endereco'
ALTER TABLE [dbo].[tb_crm_endereco]
ADD CONSTRAINT [FK_tb_crm_endereco_uf_id]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_crm_endereco_uf_id'
CREATE INDEX [IX_FK_tb_crm_endereco_uf_id]
ON [dbo].[tb_crm_endereco]
    ([uf_id]);
GO

-- Creating foreign key on [dav_id] in table 'tb_dav_itens____'
ALTER TABLE [dbo].[tb_dav_itens____]
ADD CONSTRAINT [FK_tb_dav_itens_tb_dav]
    FOREIGN KEY ([dav_id])
    REFERENCES [dbo].[tb_dav]
        ([dav_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_dav_itens_tb_dav'
CREATE INDEX [IX_FK_tb_dav_itens_tb_dav]
ON [dbo].[tb_dav_itens____]
    ([dav_id]);
GO

-- Creating foreign key on [uneg_id], [venda_id], [venda_pdv], [venda_data] in table 'tb_dav'
ALTER TABLE [dbo].[tb_dav]
ADD CONSTRAINT [FK_tb_dav_tb_venda]
    FOREIGN KEY ([uneg_id], [venda_id], [venda_pdv], [venda_data])
    REFERENCES [dbo].[tb_venda]
        ([uneg_id], [venda_id], [venda_pdv], [venda_data])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_dav_tb_venda'
CREATE INDEX [IX_FK_tb_dav_tb_venda]
ON [dbo].[tb_dav]
    ([uneg_id], [venda_id], [venda_pdv], [venda_data]);
GO

-- Creating foreign key on [ecf_numero_serie] in table 'tb_ecf_dd'
ALTER TABLE [dbo].[tb_ecf_dd]
ADD CONSTRAINT [FK_tb_ecf_dd_tb_ecf]
    FOREIGN KEY ([ecf_numero_serie])
    REFERENCES [dbo].[tb_ecf]
        ([ecf_numero_serie])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_ecf_dd_tb_ecf'
CREATE INDEX [IX_FK_tb_ecf_dd_tb_ecf]
ON [dbo].[tb_ecf_dd]
    ([ecf_numero_serie]);
GO

-- Creating foreign key on [ecfm_id_marca], [ecfm_id_modelo], [ecfm_id_versao] in table 'tb_ecf'
ALTER TABLE [dbo].[tb_ecf]
ADD CONSTRAINT [FK_tb_ecf_tb_ecf_modelo]
    FOREIGN KEY ([ecfm_id_marca], [ecfm_id_modelo], [ecfm_id_versao])
    REFERENCES [dbo].[tb_ecf_modelo]
        ([ecfm_id_marca], [ecfm_id_modelo], [ecfm_id_versao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_ecf_tb_ecf_modelo'
CREATE INDEX [IX_FK_tb_ecf_tb_ecf_modelo]
ON [dbo].[tb_ecf]
    ([ecfm_id_marca], [ecfm_id_modelo], [ecfm_id_versao]);
GO

-- Creating foreign key on [ecf_numero_serie] in table 'tb_reducao_z'
ALTER TABLE [dbo].[tb_reducao_z]
ADD CONSTRAINT [FK_tb_reducao_z_tb_ecf]
    FOREIGN KEY ([ecf_numero_serie])
    REFERENCES [dbo].[tb_ecf]
        ([ecf_numero_serie])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ecf_numero_serie] in table 'tb_venda'
ALTER TABLE [dbo].[tb_venda]
ADD CONSTRAINT [FK_tb_venda_tb_ecf]
    FOREIGN KEY ([ecf_numero_serie])
    REFERENCES [dbo].[tb_ecf]
        ([ecf_numero_serie])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_tb_ecf'
CREATE INDEX [IX_FK_tb_venda_tb_ecf]
ON [dbo].[tb_venda]
    ([ecf_numero_serie]);
GO

-- Creating foreign key on [ecf_numero_serie] in table 'tbr_ecf_finalizadora'
ALTER TABLE [dbo].[tbr_ecf_finalizadora]
ADD CONSTRAINT [FK_tbr_ecf_finalizadora_tb_ecf]
    FOREIGN KEY ([ecf_numero_serie])
    REFERENCES [dbo].[tb_ecf]
        ([ecf_numero_serie])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_ecf_finalizadora_tb_ecf'
CREATE INDEX [IX_FK_tbr_ecf_finalizadora_tb_ecf]
ON [dbo].[tbr_ecf_finalizadora]
    ([ecf_numero_serie]);
GO

-- Creating foreign key on [ecf_numero_serie] in table 'tbr_ecf_tributacao'
ALTER TABLE [dbo].[tbr_ecf_tributacao]
ADD CONSTRAINT [FK_tbr_ecf_tributacao_tb_ecf]
    FOREIGN KEY ([ecf_numero_serie])
    REFERENCES [dbo].[tb_ecf]
        ([ecf_numero_serie])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_ecf_tributacao_tb_ecf'
CREATE INDEX [IX_FK_tbr_ecf_tributacao_tb_ecf]
ON [dbo].[tbr_ecf_tributacao]
    ([ecf_numero_serie]);
GO

-- Creating foreign key on [final_id] in table 'tb_ecf_dd'
ALTER TABLE [dbo].[tb_ecf_dd]
ADD CONSTRAINT [FK_tb_ecf_dd_tb_finalizadora]
    FOREIGN KEY ([final_id])
    REFERENCES [dbo].[tb_finalizadora]
        ([final_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_ecf_dd_tb_finalizadora'
CREATE INDEX [IX_FK_tb_ecf_dd_tb_finalizadora]
ON [dbo].[tb_ecf_dd]
    ([final_id]);
GO

-- Creating foreign key on [ecfm_id_marca], [ecfm_id_modelo], [ecfm_id_versao] in table 'tb_terminal'
ALTER TABLE [dbo].[tb_terminal]
ADD CONSTRAINT [FK_tb_terminal_tb_ecf_modelo]
    FOREIGN KEY ([ecfm_id_marca], [ecfm_id_modelo], [ecfm_id_versao])
    REFERENCES [dbo].[tb_ecf_modelo]
        ([ecfm_id_marca], [ecfm_id_modelo], [ecfm_id_versao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_terminal_tb_ecf_modelo'
CREATE INDEX [IX_FK_tb_terminal_tb_ecf_modelo]
ON [dbo].[tb_terminal]
    ([ecfm_id_marca], [ecfm_id_modelo], [ecfm_id_versao]);
GO

-- Creating foreign key on [prazo_id] in table 'tb_empresa_privatelabel'
ALTER TABLE [dbo].[tb_empresa_privatelabel]
ADD CONSTRAINT [FK_tb_empresa_privatelabel_tb_financeiro_prazo]
    FOREIGN KEY ([prazo_id])
    REFERENCES [dbo].[tb_financeiro_prazo]
        ([prazo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_empresa_privatelabel_tb_financeiro_prazo'
CREATE INDEX [IX_FK_tb_empresa_privatelabel_tb_financeiro_prazo]
ON [dbo].[tb_empresa_privatelabel]
    ([prazo_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_empresa_privatelabel'
ALTER TABLE [dbo].[tb_empresa_privatelabel]
ADD CONSTRAINT [FK_tb_empresa_privatelabel_tb_fornecedor_divisao]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_empresa_privatelabel_tb_fornecedor_divisao'
CREATE INDEX [IX_FK_tb_empresa_privatelabel_tb_fornecedor_divisao]
ON [dbo].[tb_empresa_privatelabel]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [emplabel_id] in table 'tb_privatelabel'
ALTER TABLE [dbo].[tb_privatelabel]
ADD CONSTRAINT [FK_tb_privatelabel_tb_empresa_privatelabel]
    FOREIGN KEY ([emplabel_id])
    REFERENCES [dbo].[tb_empresa_privatelabel]
        ([emplabel_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_privatelabel_tb_empresa_privatelabel'
CREATE INDEX [IX_FK_tb_privatelabel_tb_empresa_privatelabel]
ON [dbo].[tb_privatelabel]
    ([emplabel_id]);
GO

-- Creating foreign key on [prazo_id] in table 'tb_empresa_recarga'
ALTER TABLE [dbo].[tb_empresa_recarga]
ADD CONSTRAINT [FK_tb_recarga_empresa_tb_financeiro_prazo]
    FOREIGN KEY ([prazo_id])
    REFERENCES [dbo].[tb_financeiro_prazo]
        ([prazo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_recarga_empresa_tb_financeiro_prazo'
CREATE INDEX [IX_FK_tb_recarga_empresa_tb_financeiro_prazo]
ON [dbo].[tb_empresa_recarga]
    ([prazo_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_empresa_recarga'
ALTER TABLE [dbo].[tb_empresa_recarga]
ADD CONSTRAINT [FK_tb_recarga_empresa_tb_fornecedor_divisao]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_recarga_empresa_tb_fornecedor_divisao'
CREATE INDEX [IX_FK_tb_recarga_empresa_tb_fornecedor_divisao]
ON [dbo].[tb_empresa_recarga]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [emprec_id] in table 'tb_recarga'
ALTER TABLE [dbo].[tb_recarga]
ADD CONSTRAINT [FK_tb_recarga_tb_recarga_empresa]
    FOREIGN KEY ([emprec_id])
    REFERENCES [dbo].[tb_empresa_recarga]
        ([emprec_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_recarga_tb_recarga_empresa'
CREATE INDEX [IX_FK_tb_recarga_tb_recarga_empresa]
ON [dbo].[tb_recarga]
    ([emprec_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tb_entrega_endereco'
ALTER TABLE [dbo].[tb_entrega_endereco]
ADD CONSTRAINT [FK_tb_entrega_endereco_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uneg_id] in table 'tb_entrega_polo'
ALTER TABLE [dbo].[tb_entrega_polo]
ADD CONSTRAINT [FK_tb_polo_entrega_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_polo_entrega_tb_unid_negocio'
CREATE INDEX [IX_FK_tb_polo_entrega_tb_unid_negocio]
ON [dbo].[tb_entrega_polo]
    ([uneg_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_entrega_prod_continuo'
ALTER TABLE [dbo].[tb_entrega_prod_continuo]
ADD CONSTRAINT [FK_tb_entrega_prod_continuo_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_entrega_prod_continuo_tb_produto'
CREATE INDEX [IX_FK_tb_entrega_prod_continuo_tb_produto]
ON [dbo].[tb_entrega_prod_continuo]
    ([pro_id]);
GO

-- Creating foreign key on [final_id] in table 'tb_finalizadora_sub'
ALTER TABLE [dbo].[tb_finalizadora_sub]
ADD CONSTRAINT [FK_tb_finalizadora_sub_tb_finalizadora]
    FOREIGN KEY ([final_id])
    REFERENCES [dbo].[tb_finalizadora]
        ([final_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_finalizadora_sub_tb_finalizadora'
CREATE INDEX [IX_FK_tb_finalizadora_sub_tb_finalizadora]
ON [dbo].[tb_finalizadora_sub]
    ([final_id]);
GO

-- Creating foreign key on [final_id] in table 'tb_financeiro_sangria'
ALTER TABLE [dbo].[tb_financeiro_sangria]
ADD CONSTRAINT [FK_tb_financeiro_sangria_tb_finalizadora]
    FOREIGN KEY ([final_id])
    REFERENCES [dbo].[tb_finalizadora]
        ([final_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_financeiro_sangria_tb_finalizadora'
CREATE INDEX [IX_FK_tb_financeiro_sangria_tb_finalizadora]
ON [dbo].[tb_financeiro_sangria]
    ([final_id]);
GO

-- Creating foreign key on [final_id] in table 'tb_venda_pagamento'
ALTER TABLE [dbo].[tb_venda_pagamento]
ADD CONSTRAINT [FK_tb_venda_pagamento_tb_finalizadora]
    FOREIGN KEY ([final_id])
    REFERENCES [dbo].[tb_finalizadora]
        ([final_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_pagamento_tb_finalizadora'
CREATE INDEX [IX_FK_tb_venda_pagamento_tb_finalizadora]
ON [dbo].[tb_venda_pagamento]
    ([final_id]);
GO

-- Creating foreign key on [final_id] in table 'tbr_ecf_finalizadora'
ALTER TABLE [dbo].[tbr_ecf_finalizadora]
ADD CONSTRAINT [FK_tbr_ecf_finalizadora_tb_finalizadora]
    FOREIGN KEY ([final_id])
    REFERENCES [dbo].[tb_finalizadora]
        ([final_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [final_id] in table 'tbr_finalizadora_un'
ALTER TABLE [dbo].[tbr_finalizadora_un]
ADD CONSTRAINT [FK_tbr_finalizadora_un1_t4804]
    FOREIGN KEY ([final_id])
    REFERENCES [dbo].[tb_finalizadora]
        ([final_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_finalizadora_un1_t4804'
CREATE INDEX [IX_FK_tbr_finalizadora_un1_t4804]
ON [dbo].[tbr_finalizadora_un]
    ([final_id]);
GO

-- Creating foreign key on [adm_id] in table 'tb_finalizadora_sub'
ALTER TABLE [dbo].[tb_finalizadora_sub]
ADD CONSTRAINT [FK_tb_finalizadora_sub_tb_financeiro_administradora]
    FOREIGN KEY ([adm_id])
    REFERENCES [dbo].[tb_financeiro_administradora]
        ([adm_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_finalizadora_sub_tb_financeiro_administradora'
CREATE INDEX [IX_FK_tb_finalizadora_sub_tb_financeiro_administradora]
ON [dbo].[tb_finalizadora_sub]
    ([adm_id]);
GO

-- Creating foreign key on [eventf_id] in table 'tb_finalizadora_sub'
ALTER TABLE [dbo].[tb_finalizadora_sub]
ADD CONSTRAINT [FK_tb_finalizadora_sub_tb_financeiro_evento]
    FOREIGN KEY ([eventf_id])
    REFERENCES [dbo].[tb_financeiro_evento]
        ([eventf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_finalizadora_sub_tb_financeiro_evento'
CREATE INDEX [IX_FK_tb_finalizadora_sub_tb_financeiro_evento]
ON [dbo].[tb_finalizadora_sub]
    ([eventf_id]);
GO

-- Creating foreign key on [prazo_id] in table 'tb_finalizadora_sub'
ALTER TABLE [dbo].[tb_finalizadora_sub]
ADD CONSTRAINT [FK_tb_finalizadora_sub_tb_financeiro_prazo]
    FOREIGN KEY ([prazo_id])
    REFERENCES [dbo].[tb_financeiro_prazo]
        ([prazo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_finalizadora_sub_tb_financeiro_prazo'
CREATE INDEX [IX_FK_tb_finalizadora_sub_tb_financeiro_prazo]
ON [dbo].[tb_finalizadora_sub]
    ([prazo_id]);
GO

-- Creating foreign key on [subfin_id], [final_id] in table 'tbr_finalizadora_sub_un'
ALTER TABLE [dbo].[tbr_finalizadora_sub_un]
ADD CONSTRAINT [FK_tbr_finalizadora_sub_un_tb_finalizadora_sub]
    FOREIGN KEY ([subfin_id], [final_id])
    REFERENCES [dbo].[tb_finalizadora_sub]
        ([finsub_id], [final_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [banco_id] in table 'tb_funcionario'
ALTER TABLE [dbo].[tb_funcionario]
ADD CONSTRAINT [FK_tb_funcionario_tb_financeiro_bancos]
    FOREIGN KEY ([banco_id])
    REFERENCES [dbo].[tb_financeiro_bancos]
        ([banco_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_funcionario_tb_financeiro_bancos'
CREATE INDEX [IX_FK_tb_funcionario_tb_financeiro_bancos]
ON [dbo].[tb_funcionario]
    ([banco_id]);
GO

-- Creating foreign key on [vpag_cli_banco_id_ch] in table 'tb_venda_pagamento'
ALTER TABLE [dbo].[tb_venda_pagamento]
ADD CONSTRAINT [FK_tb_venda_pagamento_tb_financeiro_bancos]
    FOREIGN KEY ([vpag_cli_banco_id_ch])
    REFERENCES [dbo].[tb_financeiro_bancos]
        ([banco_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_pagamento_tb_financeiro_bancos'
CREATE INDEX [IX_FK_tb_venda_pagamento_tb_financeiro_bancos]
ON [dbo].[tb_venda_pagamento]
    ([vpag_cli_banco_id_ch]);
GO

-- Creating foreign key on [banco_id] in table 'tbr_finalizadora_sub_un'
ALTER TABLE [dbo].[tbr_finalizadora_sub_un]
ADD CONSTRAINT [FK_tbr_finalizadora_sub_un_tb_financeiro_banco]
    FOREIGN KEY ([banco_id])
    REFERENCES [dbo].[tb_financeiro_bancos]
        ([banco_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_finalizadora_sub_un_tb_financeiro_banco'
CREATE INDEX [IX_FK_tbr_finalizadora_sub_un_tb_financeiro_banco]
ON [dbo].[tbr_finalizadora_sub_un]
    ([banco_id]);
GO

-- Creating foreign key on [eventf_id] in table 'tb_lancto_financeiro'
ALTER TABLE [dbo].[tb_lancto_financeiro]
ADD CONSTRAINT [FK_tb_financeiro_lancto_tb_financeiro_evento]
    FOREIGN KEY ([eventf_id])
    REFERENCES [dbo].[tb_financeiro_evento]
        ([eventf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_financeiro_lancto_tb_financeiro_evento'
CREATE INDEX [IX_FK_tb_financeiro_lancto_tb_financeiro_evento]
ON [dbo].[tb_lancto_financeiro]
    ([eventf_id]);
GO

-- Creating foreign key on [eventf_id] in table 'tb_tipo_nota'
ALTER TABLE [dbo].[tb_tipo_nota]
ADD CONSTRAINT [FK_tb_tipo_nota_tb_financeiro_evento]
    FOREIGN KEY ([eventf_id])
    REFERENCES [dbo].[tb_financeiro_evento]
        ([eventf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_tipo_nota_tb_financeiro_evento'
CREATE INDEX [IX_FK_tb_tipo_nota_tb_financeiro_evento]
ON [dbo].[tb_tipo_nota]
    ([eventf_id]);
GO

-- Creating foreign key on [prazo_id] in table 'tb_mvto_compra____'
ALTER TABLE [dbo].[tb_mvto_compra____]
ADD CONSTRAINT [FK_tb_mvto_compra_tb_financeiro_prazo]
    FOREIGN KEY ([prazo_id])
    REFERENCES [dbo].[tb_financeiro_prazo]
        ([prazo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_mvto_compra_tb_financeiro_prazo'
CREATE INDEX [IX_FK_tb_mvto_compra_tb_financeiro_prazo]
ON [dbo].[tb_mvto_compra____]
    ([prazo_id]);
GO

-- Creating foreign key on [prazo_id] in table 'tb_privatelabel_finalizadora'
ALTER TABLE [dbo].[tb_privatelabel_finalizadora]
ADD CONSTRAINT [FK_tb_privatelabel_finalizadora_tb_financeiro_prazo]
    FOREIGN KEY ([prazo_id])
    REFERENCES [dbo].[tb_financeiro_prazo]
        ([prazo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_privatelabel_finalizadora_tb_financeiro_prazo'
CREATE INDEX [IX_FK_tb_privatelabel_finalizadora_tb_financeiro_prazo]
ON [dbo].[tb_privatelabel_finalizadora]
    ([prazo_id]);
GO

-- Creating foreign key on [prazo_id] in table 'tb_recarga_finalizadora'
ALTER TABLE [dbo].[tb_recarga_finalizadora]
ADD CONSTRAINT [FK_tb_recarga_finalizadora_tb_financeiro_prazo]
    FOREIGN KEY ([prazo_id])
    REFERENCES [dbo].[tb_financeiro_prazo]
        ([prazo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_recarga_finalizadora_tb_financeiro_prazo'
CREATE INDEX [IX_FK_tb_recarga_finalizadora_tb_financeiro_prazo]
ON [dbo].[tb_recarga_finalizadora]
    ([prazo_id]);
GO

-- Creating foreign key on [prazo_id] in table 'tb_venda_pagamento'
ALTER TABLE [dbo].[tb_venda_pagamento]
ADD CONSTRAINT [FK_tb_venda_pagamento_tb_financeiro_prazo]
    FOREIGN KEY ([prazo_id])
    REFERENCES [dbo].[tb_financeiro_prazo]
        ([prazo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_pagamento_tb_financeiro_prazo'
CREATE INDEX [IX_FK_tb_venda_pagamento_tb_financeiro_prazo]
ON [dbo].[tb_venda_pagamento]
    ([prazo_id]);
GO

-- Creating foreign key on [prazo_id] in table 'tbr_convenio_cliente'
ALTER TABLE [dbo].[tbr_convenio_cliente]
ADD CONSTRAINT [FK_tbr_convenio_cliente_tb_financeiro_prazo]
    FOREIGN KEY ([prazo_id])
    REFERENCES [dbo].[tb_financeiro_prazo]
        ([prazo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_convenio_cliente_tb_financeiro_prazo'
CREATE INDEX [IX_FK_tbr_convenio_cliente_tb_financeiro_prazo]
ON [dbo].[tbr_convenio_cliente]
    ([prazo_id]);
GO

-- Creating foreign key on [usr_id] in table 'tb_financeiro_sangria'
ALTER TABLE [dbo].[tb_financeiro_sangria]
ADD CONSTRAINT [FK_tb_financeiro_sangria_tb_usuario]
    FOREIGN KEY ([usr_id])
    REFERENCES [dbo].[tb_usuario]
        ([usr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_financeiro_sangria_tb_usuario'
CREATE INDEX [IX_FK_tb_financeiro_sangria_tb_usuario]
ON [dbo].[tb_financeiro_sangria]
    ([usr_id]);
GO

-- Creating foreign key on [usr_id] in table 'tb_financeiro_suprimento'
ALTER TABLE [dbo].[tb_financeiro_suprimento]
ADD CONSTRAINT [FK_tb_financeiro_suprimento_tb_usuario]
    FOREIGN KEY ([usr_id])
    REFERENCES [dbo].[tb_usuario]
        ([usr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_financeiro_suprimento_tb_usuario'
CREATE INDEX [IX_FK_tb_financeiro_suprimento_tb_usuario]
ON [dbo].[tb_financeiro_suprimento]
    ([usr_id]);
GO

-- Creating foreign key on [fab_id] in table 'tb_fornecedor_divisao'
ALTER TABLE [dbo].[tb_fornecedor_divisao]
ADD CONSTRAINT [FK_tb_fornecedor_divisao11282]
    FOREIGN KEY ([fab_id])
    REFERENCES [dbo].[tb_fornecedor]
        ([fab_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [fab_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descvend_tb_fornecedor]
    FOREIGN KEY ([fab_id])
    REFERENCES [dbo].[tb_fornecedor]
        ([fab_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descvend_tb_fornecedor'
CREATE INDEX [IX_FK_tb_parametro_descvend_tb_fornecedor]
ON [dbo].[tb_parametro_descvend]
    ([fab_id]);
GO

-- Creating foreign key on [fab_id] in table 'tbr_dicionario_produto'
ALTER TABLE [dbo].[tbr_dicionario_produto]
ADD CONSTRAINT [FK_tbr_dicionario_produto2729]
    FOREIGN KEY ([fab_id])
    REFERENCES [dbo].[tb_fornecedor]
        ([fab_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_mvto_compra____'
ALTER TABLE [dbo].[tb_mvto_compra____]
ADD CONSTRAINT [FK_tb_mvto_compra4_tb_fo]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_mvto_compra4_tb_fo'
CREATE INDEX [IX_FK_tb_mvto_compra4_tb_fo]
ON [dbo].[tb_mvto_compra____]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_parametro_comissao'
ALTER TABLE [dbo].[tb_parametro_comissao]
ADD CONSTRAINT [FK_tb_parametro_comissao_tb_fornecedor]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_comissao_tb_fornecedor'
CREATE INDEX [IX_FK_tb_parametro_comissao_tb_fornecedor]
ON [dbo].[tb_parametro_comissao]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_parametro_descconv'
ALTER TABLE [dbo].[tb_parametro_descconv]
ADD CONSTRAINT [FK_tb_parametro_descconv_tb_fornecedor_divisao]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descconv_tb_fornecedor_divisao'
CREATE INDEX [IX_FK_tb_parametro_descconv_tb_fornecedor_divisao]
ON [dbo].[tb_parametro_descconv]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_parametro_descmax'
ALTER TABLE [dbo].[tb_parametro_descmax]
ADD CONSTRAINT [FK_tb_parametro_desconto_tb_fornecedor]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_desconto_tb_fornecedor'
CREATE INDEX [IX_FK_tb_parametro_desconto_tb_fornecedor]
ON [dbo].[tb_parametro_descmax]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_parametro_descprod'
ALTER TABLE [dbo].[tb_parametro_descprod]
ADD CONSTRAINT [FK_tb_parametro_descprod_tb_fornecedor_divisao]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descprod_tb_fornecedor_divisao'
CREATE INDEX [IX_FK_tb_parametro_descprod_tb_fornecedor_divisao]
ON [dbo].[tb_parametro_descprod]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descvend_tb_fornecedor_divisao]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descvend_tb_fornecedor_divisao'
CREATE INDEX [IX_FK_tb_parametro_descvend_tb_fornecedor_divisao]
ON [dbo].[tb_parametro_descvend]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_parametro_markup'
ALTER TABLE [dbo].[tb_parametro_markup]
ADD CONSTRAINT [FK_tb_parametro_markup_tb_fornecedor]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_markup_tb_fornecedor'
CREATE INDEX [IX_FK_tb_parametro_markup_tb_fornecedor]
ON [dbo].[tb_parametro_markup]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_pedido_compra____'
ALTER TABLE [dbo].[tb_pedido_compra____]
ADD CONSTRAINT [FK_tb_pedido_compra3_tb_f9800]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_pedido_compra3_tb_f9800'
CREATE INDEX [IX_FK_tb_pedido_compra3_tb_f9800]
ON [dbo].[tb_pedido_compra____]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tb_produto'
ALTER TABLE [dbo].[tb_produto]
ADD CONSTRAINT [FK_tb_produto9_tb_fo]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_produto9_tb_fo'
CREATE INDEX [IX_FK_tb_produto9_tb_fo]
ON [dbo].[tb_produto]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [fab_id], [div_id] in table 'tbr_dicionario_un'
ALTER TABLE [dbo].[tbr_dicionario_un]
ADD CONSTRAINT [FK_tbr_dicionario_un_tb_fornecedor_divisao]
    FOREIGN KEY ([fab_id], [div_id])
    REFERENCES [dbo].[tb_fornecedor_divisao]
        ([fab_id], [div_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_dicionario_un_tb_fornecedor_divisao'
CREATE INDEX [IX_FK_tbr_dicionario_un_tb_fornecedor_divisao]
ON [dbo].[tbr_dicionario_un]
    ([fab_id], [div_id]);
GO

-- Creating foreign key on [hora_real_id] in table 'tb_funcionario'
ALTER TABLE [dbo].[tb_funcionario]
ADD CONSTRAINT [FK_tb_funcionario_tb_funcionario_horario]
    FOREIGN KEY ([hora_real_id])
    REFERENCES [dbo].[tb_funcionario_horario]
        ([hora_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_funcionario_tb_funcionario_horario'
CREATE INDEX [IX_FK_tb_funcionario_tb_funcionario_horario]
ON [dbo].[tb_funcionario]
    ([hora_real_id]);
GO

-- Creating foreign key on [hora_contab_id] in table 'tb_funcionario'
ALTER TABLE [dbo].[tb_funcionario]
ADD CONSTRAINT [FK_tb_funcionario_tb_funcionario_horario1]
    FOREIGN KEY ([hora_contab_id])
    REFERENCES [dbo].[tb_funcionario_horario]
        ([hora_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_funcionario_tb_funcionario_horario1'
CREATE INDEX [IX_FK_tb_funcionario_tb_funcionario_horario1]
ON [dbo].[tb_funcionario]
    ([hora_contab_id]);
GO

-- Creating foreign key on [uneg_locacao_id] in table 'tb_funcionario'
ALTER TABLE [dbo].[tb_funcionario]
ADD CONSTRAINT [FK_tb_funcionario_uneg_locacao]
    FOREIGN KEY ([uneg_locacao_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_funcionario_uneg_locacao'
CREATE INDEX [IX_FK_tb_funcionario_uneg_locacao]
ON [dbo].[tb_funcionario]
    ([uneg_locacao_id]);
GO

-- Creating foreign key on [uneg_registro_id] in table 'tb_funcionario'
ALTER TABLE [dbo].[tb_funcionario]
ADD CONSTRAINT [FK_tb_funcionario_uneg_registro]
    FOREIGN KEY ([uneg_registro_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_funcionario_uneg_registro'
CREATE INDEX [IX_FK_tb_funcionario_uneg_registro]
ON [dbo].[tb_funcionario]
    ([uneg_registro_id]);
GO

-- Creating foreign key on [hora_id] in table 'tb_funcionario_horario_item'
ALTER TABLE [dbo].[tb_funcionario_horario_item]
ADD CONSTRAINT [FK_tb_funcionario_horario_item_tb_funcionario_horario]
    FOREIGN KEY ([hora_id])
    REFERENCES [dbo].[tb_funcionario_horario]
        ([hora_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uneg_id] in table 'tb_funcionario_visitante'
ALTER TABLE [dbo].[tb_funcionario_visitante]
ADD CONSTRAINT [FK_tb_funcionario_visitante_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_funcionario_visitante_tb_unid_negocio'
CREATE INDEX [IX_FK_tb_funcionario_visitante_tb_unid_negocio]
ON [dbo].[tb_funcionario_visitante]
    ([uneg_id]);
GO

-- Creating foreign key on [uf_id] in table 'tb_ibge'
ALTER TABLE [dbo].[tb_ibge]
ADD CONSTRAINT [FK_tb_ibge_tb_uf]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_ibge_tb_uf'
CREATE INDEX [IX_FK_tb_ibge_tb_uf]
ON [dbo].[tb_ibge]
    ([uf_id]);
GO

-- Creating foreign key on [ibge_codigo] in table 'tb_unid_negocio'
ALTER TABLE [dbo].[tb_unid_negocio]
ADD CONSTRAINT [FK_tb_unid_negocio_tb_ibge]
    FOREIGN KEY ([ibge_codigo])
    REFERENCES [dbo].[tb_ibge]
        ([ibge_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_unid_negocio_tb_ibge'
CREATE INDEX [IX_FK_tb_unid_negocio_tb_ibge]
ON [dbo].[tb_unid_negocio]
    ([ibge_codigo]);
GO

-- Creating foreign key on [uneg_id] in table 'tb_lancto_financeiro'
ALTER TABLE [dbo].[tb_lancto_financeiro]
ADD CONSTRAINT [FK_tb_lancto_financeiro_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cmp_id] in table 'tb_mvto_compra_item_divergencia____'
ALTER TABLE [dbo].[tb_mvto_compra_item_divergencia____]
ADD CONSTRAINT [FK_tb_mvto_compra_item_divergencia_tb_mvto_compra_item]
    FOREIGN KEY ([cmp_id])
    REFERENCES [dbo].[tb_mvto_compra____]
        ([cmp_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_mvto_compra_item_divergencia_tb_mvto_compra_item'
CREATE INDEX [IX_FK_tb_mvto_compra_item_divergencia_tb_mvto_compra_item]
ON [dbo].[tb_mvto_compra_item_divergencia____]
    ([cmp_id]);
GO

-- Creating foreign key on [cmp_id] in table 'tb_mvto_compra_item____'
ALTER TABLE [dbo].[tb_mvto_compra_item____]
ADD CONSTRAINT [FK_tb_mvto_compra_item1_t555]
    FOREIGN KEY ([cmp_id])
    REFERENCES [dbo].[tb_mvto_compra____]
        ([cmp_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [serient_id] in table 'tb_mvto_compra____'
ALTER TABLE [dbo].[tb_mvto_compra____]
ADD CONSTRAINT [FK_tb_mvto_compra_tb_serie_nt]
    FOREIGN KEY ([serient_id])
    REFERENCES [dbo].[tb_serie_nota]
        ([serient_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_mvto_compra_tb_serie_nt'
CREATE INDEX [IX_FK_tb_mvto_compra_tb_serie_nt]
ON [dbo].[tb_mvto_compra____]
    ([serient_id]);
GO

-- Creating foreign key on [uf_id] in table 'tb_mvto_compra____'
ALTER TABLE [dbo].[tb_mvto_compra____]
ADD CONSTRAINT [FK_tb_mvto_compra_tb_uf]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_mvto_compra_tb_uf'
CREATE INDEX [IX_FK_tb_mvto_compra_tb_uf]
ON [dbo].[tb_mvto_compra____]
    ([uf_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tb_mvto_compra____'
ALTER TABLE [dbo].[tb_mvto_compra____]
ADD CONSTRAINT [FK_tb_mvto_compra1_tb_un]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_mvto_compra1_tb_un'
CREATE INDEX [IX_FK_tb_mvto_compra1_tb_un]
ON [dbo].[tb_mvto_compra____]
    ([uneg_id]);
GO

-- Creating foreign key on [tipnota_id] in table 'tb_mvto_compra____'
ALTER TABLE [dbo].[tb_mvto_compra____]
ADD CONSTRAINT [FK_tb_mvto_compra2_tb_ti]
    FOREIGN KEY ([tipnota_id])
    REFERENCES [dbo].[tb_tipo_nota]
        ([tipnota_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_mvto_compra2_tb_ti'
CREATE INDEX [IX_FK_tb_mvto_compra2_tb_ti]
ON [dbo].[tb_mvto_compra____]
    ([tipnota_id]);
GO

-- Creating foreign key on [transp_id] in table 'tb_mvto_compra____'
ALTER TABLE [dbo].[tb_mvto_compra____]
ADD CONSTRAINT [FK_tb_mvto_compra3_tb_tr]
    FOREIGN KEY ([transp_id])
    REFERENCES [dbo].[tb_transportadora]
        ([transp_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_mvto_compra3_tb_tr'
CREATE INDEX [IX_FK_tb_mvto_compra3_tb_tr]
ON [dbo].[tb_mvto_compra____]
    ([transp_id]);
GO

-- Creating foreign key on [cmp_id] in table 'tbr_mvto_compra_cfop____'
ALTER TABLE [dbo].[tbr_mvto_compra_cfop____]
ADD CONSTRAINT [FK_tbr_cfop_compra1_tb_mv]
    FOREIGN KEY ([cmp_id])
    REFERENCES [dbo].[tb_mvto_compra____]
        ([cmp_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cmp_id] in table 'tbr_mvto_compra_dup____'
ALTER TABLE [dbo].[tbr_mvto_compra_dup____]
ADD CONSTRAINT [FK_tbr_mvto_compra_fin_tb_mvto_compra]
    FOREIGN KEY ([cmp_id])
    REFERENCES [dbo].[tb_mvto_compra____]
        ([cmp_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cmpdup_id] in table 'tb_mvto_compra_dup____'
ALTER TABLE [dbo].[tb_mvto_compra_dup____]
ADD CONSTRAINT [FK_tb_mvto_compra_dup_tb_mvto_compra_dup]
    FOREIGN KEY ([cmpdup_id])
    REFERENCES [dbo].[tb_mvto_compra_dup____]
        ([cmpdup_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cmpdup_id] in table 'tbr_mvto_compra_dup____'
ALTER TABLE [dbo].[tbr_mvto_compra_dup____]
ADD CONSTRAINT [FK_tbr_mvto_compra_fin_tb_mvto_compra_fin]
    FOREIGN KEY ([cmpdup_id])
    REFERENCES [dbo].[tb_mvto_compra_dup____]
        ([cmpdup_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_mvto_compra_fin_tb_mvto_compra_fin'
CREATE INDEX [IX_FK_tbr_mvto_compra_fin_tb_mvto_compra_fin]
ON [dbo].[tbr_mvto_compra_dup____]
    ([cmpdup_id]);
GO

-- Creating foreign key on [cmp_id], [icmp_id] in table 'tb_mvto_compra_item_lote____'
ALTER TABLE [dbo].[tb_mvto_compra_item_lote____]
ADD CONSTRAINT [FK_tb_mvto_compra_item_lote_tb_mvto_compra_item]
    FOREIGN KEY ([cmp_id], [icmp_id])
    REFERENCES [dbo].[tb_mvto_compra_item____]
        ([cmp_id], [icmp_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [pro_id] in table 'tb_mvto_compra_item____'
ALTER TABLE [dbo].[tb_mvto_compra_item____]
ADD CONSTRAINT [FK_tb_mvto_compra_item_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_mvto_compra_item_tb_produto'
CREATE INDEX [IX_FK_tb_mvto_compra_item_tb_produto]
ON [dbo].[tb_mvto_compra_item____]
    ([pro_id]);
GO

-- Creating foreign key on [uneg_id], [nfe_data], [nfe_pdv], [nfe_id] in table 'tb_nfe_item'
ALTER TABLE [dbo].[tb_nfe_item]
ADD CONSTRAINT [FK_tb_nfe_item_tb_nfe]
    FOREIGN KEY ([uneg_id], [nfe_data], [nfe_pdv], [nfe_id])
    REFERENCES [dbo].[tb_nfe]
        ([uneg_id], [nfe_data], [nfe_pdv], [nfe_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [pro_id] in table 'tb_nfe_item'
ALTER TABLE [dbo].[tb_nfe_item]
ADD CONSTRAINT [FK_tb_nfe_item_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_nfe_item_tb_produto'
CREATE INDEX [IX_FK_tb_nfe_item_tb_produto]
ON [dbo].[tb_nfe_item]
    ([pro_id]);
GO

-- Creating foreign key on [uf_id] in table 'tb_paciente_anvisa'
ALTER TABLE [dbo].[tb_paciente_anvisa]
ADD CONSTRAINT [FK_tb_paciente_anvisa_tb_paciente_anvisa]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_paciente_anvisa_tb_paciente_anvisa'
CREATE INDEX [IX_FK_tb_paciente_anvisa_tb_paciente_anvisa]
ON [dbo].[tb_paciente_anvisa]
    ([uf_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_parametro_comissao'
ALTER TABLE [dbo].[tb_parametro_comissao]
ADD CONSTRAINT [FK_tb_parametro_comissao_tb_parametro_comissao]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_comissao_tb_parametro_comissao'
CREATE INDEX [IX_FK_tb_parametro_comissao_tb_parametro_comissao]
ON [dbo].[tb_parametro_comissao]
    ([pro_id]);
GO

-- Creating foreign key on [par_id] in table 'tb_parametro_comissao'
ALTER TABLE [dbo].[tb_parametro_comissao]
ADD CONSTRAINT [FK_tb_parametro_comissao_tb_parametro_comissao1]
    FOREIGN KEY ([par_id])
    REFERENCES [dbo].[tb_parametro_comissao]
        ([par_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cla_id] in table 'tb_parametro_comissao'
ALTER TABLE [dbo].[tb_parametro_comissao]
ADD CONSTRAINT [FK_tb_parametro_comissao_tb_produto_classe]
    FOREIGN KEY ([cla_id])
    REFERENCES [dbo].[tb_produto_classe]
        ([cla_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_comissao_tb_produto_classe'
CREATE INDEX [IX_FK_tb_parametro_comissao_tb_produto_classe]
ON [dbo].[tb_parametro_comissao]
    ([cla_id]);
GO

-- Creating foreign key on [fam_id], [grp_id], [cat_id], [scat_id] in table 'tb_parametro_comissao'
ALTER TABLE [dbo].[tb_parametro_comissao]
ADD CONSTRAINT [FK_tb_parametro_comissao_tb_produto_fam_categ_sub]
    FOREIGN KEY ([fam_id], [grp_id], [cat_id], [scat_id])
    REFERENCES [dbo].[tb_produto_fam_categ_sub]
        ([fam_id], [grp_id], [cat_id], [scat_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_comissao_tb_produto_fam_categ_sub'
CREATE INDEX [IX_FK_tb_parametro_comissao_tb_produto_fam_categ_sub]
ON [dbo].[tb_parametro_comissao]
    ([fam_id], [grp_id], [cat_id], [scat_id]);
GO

-- Creating foreign key on [lin_id] in table 'tb_parametro_comissao'
ALTER TABLE [dbo].[tb_parametro_comissao]
ADD CONSTRAINT [FK_tb_parametro_comissao_tb_produto_linha]
    FOREIGN KEY ([lin_id])
    REFERENCES [dbo].[tb_produto_linha]
        ([lin_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_comissao_tb_produto_linha'
CREATE INDEX [IX_FK_tb_parametro_comissao_tb_produto_linha]
ON [dbo].[tb_parametro_comissao]
    ([lin_id]);
GO

-- Creating foreign key on [sim_id] in table 'tb_parametro_comissao'
ALTER TABLE [dbo].[tb_parametro_comissao]
ADD CONSTRAINT [FK_tb_parametro_comissao_tb_produto_similaridade]
    FOREIGN KEY ([sim_id])
    REFERENCES [dbo].[tb_produto_similaridade]
        ([sim_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_comissao_tb_produto_similaridade'
CREATE INDEX [IX_FK_tb_parametro_comissao_tb_produto_similaridade]
ON [dbo].[tb_parametro_comissao]
    ([sim_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_parametro_descconv'
ALTER TABLE [dbo].[tb_parametro_descconv]
ADD CONSTRAINT [FK_tb_parametro_descconv_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descconv_tb_produto'
CREATE INDEX [IX_FK_tb_parametro_descconv_tb_produto]
ON [dbo].[tb_parametro_descconv]
    ([pro_id]);
GO

-- Creating foreign key on [cla_id] in table 'tb_parametro_descconv'
ALTER TABLE [dbo].[tb_parametro_descconv]
ADD CONSTRAINT [FK_tb_parametro_descconv_tb_produto_classe]
    FOREIGN KEY ([cla_id])
    REFERENCES [dbo].[tb_produto_classe]
        ([cla_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descconv_tb_produto_classe'
CREATE INDEX [IX_FK_tb_parametro_descconv_tb_produto_classe]
ON [dbo].[tb_parametro_descconv]
    ([cla_id]);
GO

-- Creating foreign key on [fam_id], [grp_id], [cat_id], [scat_id] in table 'tb_parametro_descconv'
ALTER TABLE [dbo].[tb_parametro_descconv]
ADD CONSTRAINT [FK_tb_parametro_descconv_tb_produto_fam_categ_sub]
    FOREIGN KEY ([fam_id], [grp_id], [cat_id], [scat_id])
    REFERENCES [dbo].[tb_produto_fam_categ_sub]
        ([fam_id], [grp_id], [cat_id], [scat_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descconv_tb_produto_fam_categ_sub'
CREATE INDEX [IX_FK_tb_parametro_descconv_tb_produto_fam_categ_sub]
ON [dbo].[tb_parametro_descconv]
    ([fam_id], [grp_id], [cat_id], [scat_id]);
GO

-- Creating foreign key on [lin_id] in table 'tb_parametro_descconv'
ALTER TABLE [dbo].[tb_parametro_descconv]
ADD CONSTRAINT [FK_tb_parametro_descconv_tb_produto_linha]
    FOREIGN KEY ([lin_id])
    REFERENCES [dbo].[tb_produto_linha]
        ([lin_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descconv_tb_produto_linha'
CREATE INDEX [IX_FK_tb_parametro_descconv_tb_produto_linha]
ON [dbo].[tb_parametro_descconv]
    ([lin_id]);
GO

-- Creating foreign key on [sim_id] in table 'tb_parametro_descconv'
ALTER TABLE [dbo].[tb_parametro_descconv]
ADD CONSTRAINT [FK_tb_parametro_descconv_tb_produto_similaridade]
    FOREIGN KEY ([sim_id])
    REFERENCES [dbo].[tb_produto_similaridade]
        ([sim_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descconv_tb_produto_similaridade'
CREATE INDEX [IX_FK_tb_parametro_descconv_tb_produto_similaridade]
ON [dbo].[tb_parametro_descconv]
    ([sim_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_parametro_descmax'
ALTER TABLE [dbo].[tb_parametro_descmax]
ADD CONSTRAINT [FK_tb_parametro_desconto_tb_parametro_desconto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_desconto_tb_parametro_desconto'
CREATE INDEX [IX_FK_tb_parametro_desconto_tb_parametro_desconto]
ON [dbo].[tb_parametro_descmax]
    ([pro_id]);
GO

-- Creating foreign key on [cla_id] in table 'tb_parametro_descmax'
ALTER TABLE [dbo].[tb_parametro_descmax]
ADD CONSTRAINT [FK_tb_parametro_desconto_tb_produto_classe]
    FOREIGN KEY ([cla_id])
    REFERENCES [dbo].[tb_produto_classe]
        ([cla_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_desconto_tb_produto_classe'
CREATE INDEX [IX_FK_tb_parametro_desconto_tb_produto_classe]
ON [dbo].[tb_parametro_descmax]
    ([cla_id]);
GO

-- Creating foreign key on [fam_id], [grp_id], [cat_id], [scat_id] in table 'tb_parametro_descmax'
ALTER TABLE [dbo].[tb_parametro_descmax]
ADD CONSTRAINT [FK_tb_parametro_desconto_tb_produto_fam_categ_sub]
    FOREIGN KEY ([fam_id], [grp_id], [cat_id], [scat_id])
    REFERENCES [dbo].[tb_produto_fam_categ_sub]
        ([fam_id], [grp_id], [cat_id], [scat_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_desconto_tb_produto_fam_categ_sub'
CREATE INDEX [IX_FK_tb_parametro_desconto_tb_produto_fam_categ_sub]
ON [dbo].[tb_parametro_descmax]
    ([fam_id], [grp_id], [cat_id], [scat_id]);
GO

-- Creating foreign key on [lin_id] in table 'tb_parametro_descmax'
ALTER TABLE [dbo].[tb_parametro_descmax]
ADD CONSTRAINT [FK_tb_parametro_desconto_tb_produto_linha]
    FOREIGN KEY ([lin_id])
    REFERENCES [dbo].[tb_produto_linha]
        ([lin_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_desconto_tb_produto_linha'
CREATE INDEX [IX_FK_tb_parametro_desconto_tb_produto_linha]
ON [dbo].[tb_parametro_descmax]
    ([lin_id]);
GO

-- Creating foreign key on [sim_id] in table 'tb_parametro_descmax'
ALTER TABLE [dbo].[tb_parametro_descmax]
ADD CONSTRAINT [FK_tb_parametro_desconto_tb_produto_similaridade]
    FOREIGN KEY ([sim_id])
    REFERENCES [dbo].[tb_produto_similaridade]
        ([sim_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_desconto_tb_produto_similaridade'
CREATE INDEX [IX_FK_tb_parametro_desconto_tb_produto_similaridade]
ON [dbo].[tb_parametro_descmax]
    ([sim_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_parametro_descprod'
ALTER TABLE [dbo].[tb_parametro_descprod]
ADD CONSTRAINT [FK_tb_parametro_descprod_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descprod_tb_produto'
CREATE INDEX [IX_FK_tb_parametro_descprod_tb_produto]
ON [dbo].[tb_parametro_descprod]
    ([pro_id]);
GO

-- Creating foreign key on [cla_id] in table 'tb_parametro_descprod'
ALTER TABLE [dbo].[tb_parametro_descprod]
ADD CONSTRAINT [FK_tb_parametro_descprod_tb_produto_classe]
    FOREIGN KEY ([cla_id])
    REFERENCES [dbo].[tb_produto_classe]
        ([cla_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descprod_tb_produto_classe'
CREATE INDEX [IX_FK_tb_parametro_descprod_tb_produto_classe]
ON [dbo].[tb_parametro_descprod]
    ([cla_id]);
GO

-- Creating foreign key on [fam_id], [grp_id], [cat_id], [scat_id] in table 'tb_parametro_descprod'
ALTER TABLE [dbo].[tb_parametro_descprod]
ADD CONSTRAINT [FK_tb_parametro_descprod_tb_produto_fam_categ_sub]
    FOREIGN KEY ([fam_id], [grp_id], [cat_id], [scat_id])
    REFERENCES [dbo].[tb_produto_fam_categ_sub]
        ([fam_id], [grp_id], [cat_id], [scat_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descprod_tb_produto_fam_categ_sub'
CREATE INDEX [IX_FK_tb_parametro_descprod_tb_produto_fam_categ_sub]
ON [dbo].[tb_parametro_descprod]
    ([fam_id], [grp_id], [cat_id], [scat_id]);
GO

-- Creating foreign key on [lin_id] in table 'tb_parametro_descprod'
ALTER TABLE [dbo].[tb_parametro_descprod]
ADD CONSTRAINT [FK_tb_parametro_descprod_tb_produto_linha]
    FOREIGN KEY ([lin_id])
    REFERENCES [dbo].[tb_produto_linha]
        ([lin_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descprod_tb_produto_linha'
CREATE INDEX [IX_FK_tb_parametro_descprod_tb_produto_linha]
ON [dbo].[tb_parametro_descprod]
    ([lin_id]);
GO

-- Creating foreign key on [sim_id] in table 'tb_parametro_descprod'
ALTER TABLE [dbo].[tb_parametro_descprod]
ADD CONSTRAINT [FK_tb_parametro_descprod_tb_produto_similaridade]
    FOREIGN KEY ([sim_id])
    REFERENCES [dbo].[tb_produto_similaridade]
        ([sim_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descprod_tb_produto_similaridade'
CREATE INDEX [IX_FK_tb_parametro_descprod_tb_produto_similaridade]
ON [dbo].[tb_parametro_descprod]
    ([sim_id]);
GO

-- Creating foreign key on [usr_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descmax_tb_usuario]
    FOREIGN KEY ([usr_id])
    REFERENCES [dbo].[tb_usuario]
        ([usr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descmax_tb_usuario'
CREATE INDEX [IX_FK_tb_parametro_descmax_tb_usuario]
ON [dbo].[tb_parametro_descvend]
    ([usr_id]);
GO

-- Creating foreign key on [funcao_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descmax_tb_usuario_funcao]
    FOREIGN KEY ([funcao_id])
    REFERENCES [dbo].[tb_usuario_funcao]
        ([funcao_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descmax_tb_usuario_funcao'
CREATE INDEX [IX_FK_tb_parametro_descmax_tb_usuario_funcao]
ON [dbo].[tb_parametro_descvend]
    ([funcao_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descvend_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descvend_tb_produto'
CREATE INDEX [IX_FK_tb_parametro_descvend_tb_produto]
ON [dbo].[tb_parametro_descvend]
    ([pro_id]);
GO

-- Creating foreign key on [cla_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descvend_tb_produto_classe]
    FOREIGN KEY ([cla_id])
    REFERENCES [dbo].[tb_produto_classe]
        ([cla_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descvend_tb_produto_classe'
CREATE INDEX [IX_FK_tb_parametro_descvend_tb_produto_classe]
ON [dbo].[tb_parametro_descvend]
    ([cla_id]);
GO

-- Creating foreign key on [fam_id], [grp_id], [cat_id], [scat_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descvend_tb_produto_fam_categ_sub]
    FOREIGN KEY ([fam_id], [grp_id], [cat_id], [scat_id])
    REFERENCES [dbo].[tb_produto_fam_categ_sub]
        ([fam_id], [grp_id], [cat_id], [scat_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descvend_tb_produto_fam_categ_sub'
CREATE INDEX [IX_FK_tb_parametro_descvend_tb_produto_fam_categ_sub]
ON [dbo].[tb_parametro_descvend]
    ([fam_id], [grp_id], [cat_id], [scat_id]);
GO

-- Creating foreign key on [fam_id], [grp_id], [cat_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descvend_tb_produto_fam_categoria]
    FOREIGN KEY ([fam_id], [grp_id], [cat_id])
    REFERENCES [dbo].[tb_produto_fam_categoria]
        ([fam_id], [grp_id], [cat_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descvend_tb_produto_fam_categoria'
CREATE INDEX [IX_FK_tb_parametro_descvend_tb_produto_fam_categoria]
ON [dbo].[tb_parametro_descvend]
    ([fam_id], [grp_id], [cat_id]);
GO

-- Creating foreign key on [fam_id], [grp_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descvend_tb_produto_fam_grupo]
    FOREIGN KEY ([fam_id], [grp_id])
    REFERENCES [dbo].[tb_produto_fam_grupo]
        ([fam_id], [grp_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descvend_tb_produto_fam_grupo'
CREATE INDEX [IX_FK_tb_parametro_descvend_tb_produto_fam_grupo]
ON [dbo].[tb_parametro_descvend]
    ([fam_id], [grp_id]);
GO

-- Creating foreign key on [fam_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descvend_tb_produto_familia]
    FOREIGN KEY ([fam_id])
    REFERENCES [dbo].[tb_produto_familia]
        ([fam_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descvend_tb_produto_familia'
CREATE INDEX [IX_FK_tb_parametro_descvend_tb_produto_familia]
ON [dbo].[tb_parametro_descvend]
    ([fam_id]);
GO

-- Creating foreign key on [lin_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descvend_tb_produto_linha]
    FOREIGN KEY ([lin_id])
    REFERENCES [dbo].[tb_produto_linha]
        ([lin_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descvend_tb_produto_linha'
CREATE INDEX [IX_FK_tb_parametro_descvend_tb_produto_linha]
ON [dbo].[tb_parametro_descvend]
    ([lin_id]);
GO

-- Creating foreign key on [sim_id] in table 'tb_parametro_descvend'
ALTER TABLE [dbo].[tb_parametro_descvend]
ADD CONSTRAINT [FK_tb_parametro_descvend_tb_produto_similaridade]
    FOREIGN KEY ([sim_id])
    REFERENCES [dbo].[tb_produto_similaridade]
        ([sim_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_descvend_tb_produto_similaridade'
CREATE INDEX [IX_FK_tb_parametro_descvend_tb_produto_similaridade]
ON [dbo].[tb_parametro_descvend]
    ([sim_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_parametro_markup'
ALTER TABLE [dbo].[tb_parametro_markup]
ADD CONSTRAINT [FK_tb_parametro_markup_tb_parametro_markup]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_markup_tb_parametro_markup'
CREATE INDEX [IX_FK_tb_parametro_markup_tb_parametro_markup]
ON [dbo].[tb_parametro_markup]
    ([pro_id]);
GO

-- Creating foreign key on [cla_id] in table 'tb_parametro_markup'
ALTER TABLE [dbo].[tb_parametro_markup]
ADD CONSTRAINT [FK_tb_parametro_markup_tb_produto_classe]
    FOREIGN KEY ([cla_id])
    REFERENCES [dbo].[tb_produto_classe]
        ([cla_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_markup_tb_produto_classe'
CREATE INDEX [IX_FK_tb_parametro_markup_tb_produto_classe]
ON [dbo].[tb_parametro_markup]
    ([cla_id]);
GO

-- Creating foreign key on [fam_id], [grp_id], [cat_id], [scat_id] in table 'tb_parametro_markup'
ALTER TABLE [dbo].[tb_parametro_markup]
ADD CONSTRAINT [FK_tb_parametro_markup_tb_produto_fam_categ_sub]
    FOREIGN KEY ([fam_id], [grp_id], [cat_id], [scat_id])
    REFERENCES [dbo].[tb_produto_fam_categ_sub]
        ([fam_id], [grp_id], [cat_id], [scat_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_markup_tb_produto_fam_categ_sub'
CREATE INDEX [IX_FK_tb_parametro_markup_tb_produto_fam_categ_sub]
ON [dbo].[tb_parametro_markup]
    ([fam_id], [grp_id], [cat_id], [scat_id]);
GO

-- Creating foreign key on [lin_id] in table 'tb_parametro_markup'
ALTER TABLE [dbo].[tb_parametro_markup]
ADD CONSTRAINT [FK_tb_parametro_markup_tb_produto_linha]
    FOREIGN KEY ([lin_id])
    REFERENCES [dbo].[tb_produto_linha]
        ([lin_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_markup_tb_produto_linha'
CREATE INDEX [IX_FK_tb_parametro_markup_tb_produto_linha]
ON [dbo].[tb_parametro_markup]
    ([lin_id]);
GO

-- Creating foreign key on [sim_id] in table 'tb_parametro_markup'
ALTER TABLE [dbo].[tb_parametro_markup]
ADD CONSTRAINT [FK_tb_parametro_markup_tb_produto_similaridade]
    FOREIGN KEY ([sim_id])
    REFERENCES [dbo].[tb_produto_similaridade]
        ([sim_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_parametro_markup_tb_produto_similaridade'
CREATE INDEX [IX_FK_tb_parametro_markup_tb_produto_similaridade]
ON [dbo].[tb_parametro_markup]
    ([sim_id]);
GO

-- Creating foreign key on [par_id] in table 'tbr_parametro_markup_uneg'
ALTER TABLE [dbo].[tbr_parametro_markup_uneg]
ADD CONSTRAINT [FK_tbr_parametro_markup_uneg_tb_parametro_markup]
    FOREIGN KEY ([par_id])
    REFERENCES [dbo].[tb_parametro_markup]
        ([par_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [pedc_id] in table 'tb_pedido_compra_item____'
ALTER TABLE [dbo].[tb_pedido_compra_item____]
ADD CONSTRAINT [FK_tb_pedido_compra_item13902]
    FOREIGN KEY ([pedc_id])
    REFERENCES [dbo].[tb_pedido_compra____]
        ([pedc_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uneg_id] in table 'tb_pedido_compra____'
ALTER TABLE [dbo].[tb_pedido_compra____]
ADD CONSTRAINT [FK_tb_pedido_compra1_tb_u9994]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_pedido_compra1_tb_u9994'
CREATE INDEX [IX_FK_tb_pedido_compra1_tb_u9994]
ON [dbo].[tb_pedido_compra____]
    ([uneg_id]);
GO

-- Creating foreign key on [motivo_id] in table 'tb_ponto'
ALTER TABLE [dbo].[tb_ponto]
ADD CONSTRAINT [FK_tb_ponto_tb_ponto_motivo]
    FOREIGN KEY ([motivo_id])
    REFERENCES [dbo].[tb_ponto_motivo]
        ([motivo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_ponto_tb_ponto_motivo'
CREATE INDEX [IX_FK_tb_ponto_tb_ponto_motivo]
ON [dbo].[tb_ponto]
    ([motivo_id]);
GO

-- Creating foreign key on [usr_id] in table 'tb_ponto'
ALTER TABLE [dbo].[tb_ponto]
ADD CONSTRAINT [FK_tb_ponto_tb_usuario]
    FOREIGN KEY ([usr_id])
    REFERENCES [dbo].[tb_usuario]
        ([usr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_ponto_tb_usuario'
CREATE INDEX [IX_FK_tb_ponto_tb_usuario]
ON [dbo].[tb_ponto]
    ([usr_id]);
GO

-- Creating foreign key on [uneg_id], [plabel_pdv], [plabel_data], [plabel_id] in table 'tb_privatelabel_finalizadora'
ALTER TABLE [dbo].[tb_privatelabel_finalizadora]
ADD CONSTRAINT [FK_tb_privatelabel_finalizadora_tb_privatelabel]
    FOREIGN KEY ([uneg_id], [plabel_pdv], [plabel_data], [plabel_id])
    REFERENCES [dbo].[tb_privatelabel]
        ([uneg_id], [plabel_pdv], [plabel_data], [plabel_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [pro_id] in table 'tbr_produto_estoque_lote'
ALTER TABLE [dbo].[tbr_produto_estoque_lote]
ADD CONSTRAINT [FK_tb_estoque_lote_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_estoque_lote_tb_produto'
CREATE INDEX [IX_FK_tb_estoque_lote_tb_produto]
ON [dbo].[tbr_produto_estoque_lote]
    ([pro_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_produto_barra'
ALTER TABLE [dbo].[tb_produto_barra]
ADD CONSTRAINT [FK_tb_produto_barra_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [pro_id] in table 'tbr_produto_estoque_dia'
ALTER TABLE [dbo].[tbr_produto_estoque_dia]
ADD CONSTRAINT [FK_tb_produto_hist_diario_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_produto_hist_diario_tb_produto'
CREATE INDEX [IX_FK_tb_produto_hist_diario_tb_produto]
ON [dbo].[tbr_produto_estoque_dia]
    ([pro_id]);
GO

-- Creating foreign key on [piscofins_cod] in table 'tb_produto'
ALTER TABLE [dbo].[tb_produto]
ADD CONSTRAINT [FK_tb_produto_tb_produto_piscofins]
    FOREIGN KEY ([piscofins_cod])
    REFERENCES [dbo].[tb_produto_piscofins]
        ([piscofins_cod])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_produto_tb_produto_piscofins'
CREATE INDEX [IX_FK_tb_produto_tb_produto_piscofins]
ON [dbo].[tb_produto]
    ([piscofins_cod]);
GO

-- Creating foreign key on [fam_id], [grp_id], [cat_id], [scat_id] in table 'tb_produto'
ALTER TABLE [dbo].[tb_produto]
ADD CONSTRAINT [FK_tb_produto10_tb_pr]
    FOREIGN KEY ([fam_id], [grp_id], [cat_id], [scat_id])
    REFERENCES [dbo].[tb_produto_fam_categ_sub]
        ([fam_id], [grp_id], [cat_id], [scat_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_produto10_tb_pr'
CREATE INDEX [IX_FK_tb_produto10_tb_pr]
ON [dbo].[tb_produto]
    ([fam_id], [grp_id], [cat_id], [scat_id]);
GO

-- Creating foreign key on [sim_id] in table 'tb_produto'
ALTER TABLE [dbo].[tb_produto]
ADD CONSTRAINT [FK_tb_produto3_tb_pr]
    FOREIGN KEY ([sim_id])
    REFERENCES [dbo].[tb_produto_similaridade]
        ([sim_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_produto3_tb_pr'
CREATE INDEX [IX_FK_tb_produto3_tb_pr]
ON [dbo].[tb_produto]
    ([sim_id]);
GO

-- Creating foreign key on [cla_id] in table 'tb_produto'
ALTER TABLE [dbo].[tb_produto]
ADD CONSTRAINT [FK_tb_produto4_tb_pr]
    FOREIGN KEY ([cla_id])
    REFERENCES [dbo].[tb_produto_classe]
        ([cla_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_produto4_tb_pr'
CREATE INDEX [IX_FK_tb_produto4_tb_pr]
ON [dbo].[tb_produto]
    ([cla_id]);
GO

-- Creating foreign key on [pat_id] in table 'tb_produto'
ALTER TABLE [dbo].[tb_produto]
ADD CONSTRAINT [FK_tb_produto5_tb_pr]
    FOREIGN KEY ([pat_id])
    REFERENCES [dbo].[tb_produto_princativo]
        ([pat_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_produto5_tb_pr'
CREATE INDEX [IX_FK_tb_produto5_tb_pr]
ON [dbo].[tb_produto]
    ([pat_id]);
GO

-- Creating foreign key on [lin_id] in table 'tb_produto'
ALTER TABLE [dbo].[tb_produto]
ADD CONSTRAINT [FK_tb_produto6_tb_pr]
    FOREIGN KEY ([lin_id])
    REFERENCES [dbo].[tb_produto_linha]
        ([lin_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_produto6_tb_pr'
CREATE INDEX [IX_FK_tb_produto6_tb_pr]
ON [dbo].[tb_produto]
    ([lin_id]);
GO

-- Creating foreign key on [rec_id] in table 'tb_produto'
ALTER TABLE [dbo].[tb_produto]
ADD CONSTRAINT [FK_tb_produto7_tb_pr]
    FOREIGN KEY ([rec_id])
    REFERENCES [dbo].[tb_produto_receituario]
        ([rec_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_produto7_tb_pr'
CREATE INDEX [IX_FK_tb_produto7_tb_pr]
ON [dbo].[tb_produto]
    ([rec_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_venda_dav_item'
ALTER TABLE [dbo].[tb_venda_dav_item]
ADD CONSTRAINT [FK_tb_venda_dav_item_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_dav_item_tb_produto'
CREATE INDEX [IX_FK_tb_venda_dav_item_tb_produto]
ON [dbo].[tb_venda_dav_item]
    ([pro_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_venda_item'
ALTER TABLE [dbo].[tb_venda_item]
ADD CONSTRAINT [FK_tb_venda_item_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_item_tb_produto'
CREATE INDEX [IX_FK_tb_venda_item_tb_produto]
ON [dbo].[tb_venda_item]
    ([pro_id]);
GO

-- Creating foreign key on [pro_id] in table 'tb_venda_prevenda_item'
ALTER TABLE [dbo].[tb_venda_prevenda_item]
ADD CONSTRAINT [FK_tb_venda_prevenda_item_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_prevenda_item_tb_produto'
CREATE INDEX [IX_FK_tb_venda_prevenda_item_tb_produto]
ON [dbo].[tb_venda_prevenda_item]
    ([pro_id]);
GO

-- Creating foreign key on [pro_id] in table 'tbr_dicionario_produto'
ALTER TABLE [dbo].[tbr_dicionario_produto]
ADD CONSTRAINT [FK_tbr_dicionario_produto_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_dicionario_produto_tb_produto'
CREATE INDEX [IX_FK_tbr_dicionario_produto_tb_produto]
ON [dbo].[tbr_dicionario_produto]
    ([pro_id]);
GO

-- Creating foreign key on [pro_id] in table 'tbr_produto_tributacao'
ALTER TABLE [dbo].[tbr_produto_tributacao]
ADD CONSTRAINT [FK_tbr_produto_tributacao5334]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [pro_id] in table 'tbr_produto_uneg'
ALTER TABLE [dbo].[tbr_produto_uneg]
ADD CONSTRAINT [FK_tbr_produto_uneg_tb_produto]
    FOREIGN KEY ([pro_id])
    REFERENCES [dbo].[tb_produto]
        ([pro_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_produto_uneg_tb_produto'
CREATE INDEX [IX_FK_tbr_produto_uneg_tb_produto]
ON [dbo].[tbr_produto_uneg]
    ([pro_id]);
GO

-- Creating foreign key on [fam_id], [grp_id], [cat_id] in table 'tb_produto_fam_categ_sub'
ALTER TABLE [dbo].[tb_produto_fam_categ_sub]
ADD CONSTRAINT [FK_tb_produto_subcateg1_t3705]
    FOREIGN KEY ([fam_id], [grp_id], [cat_id])
    REFERENCES [dbo].[tb_produto_fam_categoria]
        ([fam_id], [grp_id], [cat_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [fam_id], [grp_id] in table 'tb_produto_fam_categoria'
ALTER TABLE [dbo].[tb_produto_fam_categoria]
ADD CONSTRAINT [FK_tb_produto_categoria1_1492]
    FOREIGN KEY ([fam_id], [grp_id])
    REFERENCES [dbo].[tb_produto_fam_grupo]
        ([fam_id], [grp_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [fam_id] in table 'tb_produto_fam_grupo'
ALTER TABLE [dbo].[tb_produto_fam_grupo]
ADD CONSTRAINT [FK_tb_produto_grupo1_tb_p6944]
    FOREIGN KEY ([fam_id])
    REFERENCES [dbo].[tb_produto_familia]
        ([fam_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [prm_id] in table 'tbr_promocao_produto'
ALTER TABLE [dbo].[tbr_promocao_produto]
ADD CONSTRAINT [FK_tbr_promocao_produto_promocao]
    FOREIGN KEY ([prm_id])
    REFERENCES [dbo].[tb_promocao]
        ([prm_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uneg_id], [pin_pdv], [pin_data], [pin_id] in table 'tb_recarga_finalizadora'
ALTER TABLE [dbo].[tb_recarga_finalizadora]
ADD CONSTRAINT [FK_tb_recarga_finalizadora_tb_recarga1]
    FOREIGN KEY ([uneg_id], [pin_pdv], [pin_data], [pin_id])
    REFERENCES [dbo].[tb_recarga]
        ([uneg_id], [pin_pdv], [pin_data], [pin_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ecf_numero_serie], [reduz_data_movimento] in table 'tb_reducao_z_itens'
ALTER TABLE [dbo].[tb_reducao_z_itens]
ADD CONSTRAINT [FK_tb_reducao_z_itens_tb_reducao_z]
    FOREIGN KEY ([ecf_numero_serie], [reduz_data_movimento])
    REFERENCES [dbo].[tb_reducao_z]
        ([ecf_numero_serie], [reduz_data_movimento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_reducao_z_itens_tb_reducao_z'
CREATE INDEX [IX_FK_tb_reducao_z_itens_tb_reducao_z]
ON [dbo].[tb_reducao_z_itens]
    ([ecf_numero_serie], [reduz_data_movimento]);
GO

-- Creating foreign key on [id_terminal] in table 'tb_sincronizacao'
ALTER TABLE [dbo].[tb_sincronizacao]
ADD CONSTRAINT [FK_tb_Sincronizacao_tb_terminal]
    FOREIGN KEY ([id_terminal])
    REFERENCES [dbo].[tb_terminal]
        ([te_id_terminal])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_Sincronizacao_tb_terminal'
CREATE INDEX [IX_FK_tb_Sincronizacao_tb_terminal]
ON [dbo].[tb_sincronizacao]
    ([id_terminal]);
GO

-- Creating foreign key on [uneg_id] in table 'tb_terminal'
ALTER TABLE [dbo].[tb_terminal]
ADD CONSTRAINT [FK_tb_terminal_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_terminal_tb_unid_negocio'
CREATE INDEX [IX_FK_tb_terminal_tb_unid_negocio]
ON [dbo].[tb_terminal]
    ([uneg_id]);
GO

-- Creating foreign key on [uneg_tip_logradouro] in table 'tb_unid_negocio'
ALTER TABLE [dbo].[tb_unid_negocio]
ADD CONSTRAINT [FK_tb_unid_negocio_tb_tipo_logradouro]
    FOREIGN KEY ([uneg_tip_logradouro])
    REFERENCES [dbo].[tb_tipo_logradouro]
        ([tiplog_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_unid_negocio_tb_tipo_logradouro'
CREATE INDEX [IX_FK_tb_unid_negocio_tb_tipo_logradouro]
ON [dbo].[tb_unid_negocio]
    ([uneg_tip_logradouro]);
GO

-- Creating foreign key on [cdmvto_codigo] in table 'tb_tipo_nota'
ALTER TABLE [dbo].[tb_tipo_nota]
ADD CONSTRAINT [FK_tb_tipo_nota_tb_tipo_mvto_produto]
    FOREIGN KEY ([cdmvto_codigo])
    REFERENCES [dbo].[tb_tipo_mvto_produto]
        ([cdmvto_codigo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_tipo_nota_tb_tipo_mvto_produto'
CREATE INDEX [IX_FK_tb_tipo_nota_tb_tipo_mvto_produto]
ON [dbo].[tb_tipo_nota]
    ([cdmvto_codigo]);
GO

-- Creating foreign key on [trb_id] in table 'tbr_ecf_tributacao'
ALTER TABLE [dbo].[tbr_ecf_tributacao]
ADD CONSTRAINT [FK_tbr_ecf_tributacao_tb_tributacao]
    FOREIGN KEY ([trb_id])
    REFERENCES [dbo].[tb_tributacao]
        ([trb_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [trb_id_interno] in table 'tbr_produto_tributacao'
ALTER TABLE [dbo].[tbr_produto_tributacao]
ADD CONSTRAINT [FK_tbr_produto_tributacao_tb_tributacao]
    FOREIGN KEY ([trb_id_interno])
    REFERENCES [dbo].[tb_tributacao]
        ([trb_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_produto_tributacao_tb_tributacao'
CREATE INDEX [IX_FK_tbr_produto_tributacao_tb_tributacao]
ON [dbo].[tbr_produto_tributacao]
    ([trb_id_interno]);
GO

-- Creating foreign key on [trb_id_interestadual] in table 'tbr_produto_tributacao'
ALTER TABLE [dbo].[tbr_produto_tributacao]
ADD CONSTRAINT [FK_tbr_produto_tributacao_tb_tributacao1]
    FOREIGN KEY ([trb_id_interestadual])
    REFERENCES [dbo].[tb_tributacao]
        ([trb_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_produto_tributacao_tb_tributacao1'
CREATE INDEX [IX_FK_tbr_produto_tributacao_tb_tributacao1]
ON [dbo].[tbr_produto_tributacao]
    ([trb_id_interestadual]);
GO

-- Creating foreign key on [uf_id] in table 'tb_uf'
ALTER TABLE [dbo].[tb_uf]
ADD CONSTRAINT [FK_tb_uf_tb_uf]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uf_id] in table 'tb_unid_negocio'
ALTER TABLE [dbo].[tb_unid_negocio]
ADD CONSTRAINT [FK_tb_unid_negocio_tb_uf]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_unid_negocio_tb_uf'
CREATE INDEX [IX_FK_tb_unid_negocio_tb_uf]
ON [dbo].[tb_unid_negocio]
    ([uf_id]);
GO

-- Creating foreign key on [uf_id] in table 'tbr_abcfarma_uf'
ALTER TABLE [dbo].[tbr_abcfarma_uf]
ADD CONSTRAINT [FK_tbr_abcfarma_uf_tb_uf]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_abcfarma_uf_tb_uf'
CREATE INDEX [IX_FK_tbr_abcfarma_uf_tb_uf]
ON [dbo].[tbr_abcfarma_uf]
    ([uf_id]);
GO

-- Creating foreign key on [uf_id] in table 'tbr_produto_tributacao'
ALTER TABLE [dbo].[tbr_produto_tributacao]
ADD CONSTRAINT [FK_tbr_produto_tributacao7747]
    FOREIGN KEY ([uf_id])
    REFERENCES [dbo].[tb_uf]
        ([uf_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_produto_tributacao7747'
CREATE INDEX [IX_FK_tbr_produto_tributacao7747]
ON [dbo].[tbr_produto_tributacao]
    ([uf_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tbr_produto_estoque_lote'
ALTER TABLE [dbo].[tbr_produto_estoque_lote]
ADD CONSTRAINT [FK_tb_estoque_lote_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uneg_id] in table 'tbr_produto_estoque_dia'
ALTER TABLE [dbo].[tbr_produto_estoque_dia]
ADD CONSTRAINT [FK_tb_produto_hist_diario_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uneg_id] in table 'tb_venda_prevenda_item'
ALTER TABLE [dbo].[tb_venda_prevenda_item]
ADD CONSTRAINT [FK_tb_venda_prevenda_item_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_prevenda_item_tb_unid_negocio'
CREATE INDEX [IX_FK_tb_venda_prevenda_item_tb_unid_negocio]
ON [dbo].[tb_venda_prevenda_item]
    ([uneg_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tbr_convenio_un'
ALTER TABLE [dbo].[tbr_convenio_un]
ADD CONSTRAINT [FK_tbr_convenio_un1_tb_un]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_convenio_un1_tb_un'
CREATE INDEX [IX_FK_tbr_convenio_un1_tb_un]
ON [dbo].[tbr_convenio_un]
    ([uneg_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tbr_finalizadora_sub_un'
ALTER TABLE [dbo].[tbr_finalizadora_sub_un]
ADD CONSTRAINT [FK_tbr_finalizadora_sub_u8262]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_finalizadora_sub_u8262'
CREATE INDEX [IX_FK_tbr_finalizadora_sub_u8262]
ON [dbo].[tbr_finalizadora_sub_un]
    ([uneg_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tbr_finalizadora_un'
ALTER TABLE [dbo].[tbr_finalizadora_un]
ADD CONSTRAINT [FK_tbr_finalizadora_un2_t3406]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uneg_id] in table 'tbr_parametro_descprod_uneg'
ALTER TABLE [dbo].[tbr_parametro_descprod_uneg]
ADD CONSTRAINT [FK_tbr_parametro_descprod_uneg_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_parametro_descprod_uneg_tb_unid_negocio'
CREATE INDEX [IX_FK_tbr_parametro_descprod_uneg_tb_unid_negocio]
ON [dbo].[tbr_parametro_descprod_uneg]
    ([uneg_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tbr_parametro_descvend_uneg'
ALTER TABLE [dbo].[tbr_parametro_descvend_uneg]
ADD CONSTRAINT [FK_tbr_parametro_descvend_uneg_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_parametro_descvend_uneg_tb_unid_negocio'
CREATE INDEX [IX_FK_tbr_parametro_descvend_uneg_tb_unid_negocio]
ON [dbo].[tbr_parametro_descvend_uneg]
    ([uneg_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tbr_parametro_markup_uneg'
ALTER TABLE [dbo].[tbr_parametro_markup_uneg]
ADD CONSTRAINT [FK_tbr_parametro_markup_uneg_tb_unid_negocio]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_parametro_markup_uneg_tb_unid_negocio'
CREATE INDEX [IX_FK_tbr_parametro_markup_uneg_tb_unid_negocio]
ON [dbo].[tbr_parametro_markup_uneg]
    ([uneg_id]);
GO

-- Creating foreign key on [uneg_id] in table 'tbr_produto_uneg'
ALTER TABLE [dbo].[tbr_produto_uneg]
ADD CONSTRAINT [FK_tbr_produto_uneg]
    FOREIGN KEY ([uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [bloq_id] in table 'tb_usuario'
ALTER TABLE [dbo].[tb_usuario]
ADD CONSTRAINT [FK_tb_usuario_tb_usuario_bloqueio]
    FOREIGN KEY ([bloq_id])
    REFERENCES [dbo].[tb_usuario_bloqueio]
        ([bloq_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_usuario_tb_usuario_bloqueio'
CREATE INDEX [IX_FK_tb_usuario_tb_usuario_bloqueio]
ON [dbo].[tb_usuario]
    ([bloq_id]);
GO

-- Creating foreign key on [dpto_id] in table 'tb_usuario'
ALTER TABLE [dbo].[tb_usuario]
ADD CONSTRAINT [FK_tb_usuario_tb_usuario_dpto]
    FOREIGN KEY ([dpto_id])
    REFERENCES [dbo].[tb_usuario_dpto]
        ([dpto_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_usuario_tb_usuario_dpto'
CREATE INDEX [IX_FK_tb_usuario_tb_usuario_dpto]
ON [dbo].[tb_usuario]
    ([dpto_id]);
GO

-- Creating foreign key on [grp_id] in table 'tb_usuario'
ALTER TABLE [dbo].[tb_usuario]
ADD CONSTRAINT [FK_tb_usuario_tb_usuario_grupo]
    FOREIGN KEY ([grp_id])
    REFERENCES [dbo].[tb_usuario_grupo]
        ([grp_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_usuario_tb_usuario_grupo'
CREATE INDEX [IX_FK_tb_usuario_tb_usuario_grupo]
ON [dbo].[tb_usuario]
    ([grp_id]);
GO

-- Creating foreign key on [funcao_id] in table 'tb_usuario'
ALTER TABLE [dbo].[tb_usuario]
ADD CONSTRAINT [FK_tb_usuario1_tb_usuario_funcao]
    FOREIGN KEY ([funcao_id])
    REFERENCES [dbo].[tb_usuario_funcao]
        ([funcao_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_usuario1_tb_usuario_funcao'
CREATE INDEX [IX_FK_tb_usuario1_tb_usuario_funcao]
ON [dbo].[tb_usuario]
    ([funcao_id]);
GO

-- Creating foreign key on [venda_dav_vendedor_id] in table 'tb_venda_dav'
ALTER TABLE [dbo].[tb_venda_dav]
ADD CONSTRAINT [FK_tb_venda_dav_tb_usuario]
    FOREIGN KEY ([venda_dav_vendedor_id])
    REFERENCES [dbo].[tb_usuario]
        ([usr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_dav_tb_usuario'
CREATE INDEX [IX_FK_tb_venda_dav_tb_usuario]
ON [dbo].[tb_venda_dav]
    ([venda_dav_vendedor_id]);
GO

-- Creating foreign key on [vendaPv_item_vendedor_id] in table 'tb_venda_prevenda_item'
ALTER TABLE [dbo].[tb_venda_prevenda_item]
ADD CONSTRAINT [FK_tb_venda_prevenda_item_tb_usuario]
    FOREIGN KEY ([vendaPv_item_vendedor_id])
    REFERENCES [dbo].[tb_usuario]
        ([usr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_prevenda_item_tb_usuario'
CREATE INDEX [IX_FK_tb_venda_prevenda_item_tb_usuario]
ON [dbo].[tb_venda_prevenda_item]
    ([vendaPv_item_vendedor_id]);
GO

-- Creating foreign key on [vendaPv_vendedor_id] in table 'tb_venda_prevenda'
ALTER TABLE [dbo].[tb_venda_prevenda]
ADD CONSTRAINT [FK_tb_venda_prevenda_tb_usuario]
    FOREIGN KEY ([vendaPv_vendedor_id])
    REFERENCES [dbo].[tb_usuario]
        ([usr_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_prevenda_tb_usuario'
CREATE INDEX [IX_FK_tb_venda_prevenda_tb_usuario]
ON [dbo].[tb_venda_prevenda]
    ([vendaPv_vendedor_id]);
GO

-- Creating foreign key on [dpto_id] in table 'tbr_dpto_aplicativo'
ALTER TABLE [dbo].[tbr_dpto_aplicativo]
ADD CONSTRAINT [FK_tbr_dpto_aplicativo_tb_usuario_dpto]
    FOREIGN KEY ([dpto_id])
    REFERENCES [dbo].[tb_usuario_dpto]
        ([dpto_id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [uneg_id], [venda_id], [venda_pdv], [venda_data] in table 'tb_venda_estorno_tef'
ALTER TABLE [dbo].[tb_venda_estorno_tef]
ADD CONSTRAINT [FK_tb_venda_estorno_tef_tb_venda]
    FOREIGN KEY ([uneg_id], [venda_id], [venda_pdv], [venda_data])
    REFERENCES [dbo].[tb_venda]
        ([uneg_id], [venda_id], [venda_pdv], [venda_data])
    ON DELETE CASCADE ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_estorno_tef_tb_venda'
CREATE INDEX [IX_FK_tb_venda_estorno_tef_tb_venda]
ON [dbo].[tb_venda_estorno_tef]
    ([uneg_id], [venda_id], [venda_pdv], [venda_data]);
GO

-- Creating foreign key on [uneg_id], [venda_id], [venda_pdv], [venda_data] in table 'tb_venda'
ALTER TABLE [dbo].[tb_venda]
ADD CONSTRAINT [FK_tb_venda_tb_venda]
    FOREIGN KEY ([uneg_id], [venda_id], [venda_pdv], [venda_data])
    REFERENCES [dbo].[tb_venda]
        ([uneg_id], [venda_id], [venda_pdv], [venda_data])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [venda_dav_id], [venda_dav_data_preVenda], [uneg_id], [venda_pdv] in table 'tb_venda_dav_item'
ALTER TABLE [dbo].[tb_venda_dav_item]
ADD CONSTRAINT [FK_tb_venda_dav_item_tb_venda_dav]
    FOREIGN KEY ([venda_dav_id], [venda_dav_data_preVenda], [uneg_id], [venda_pdv])
    REFERENCES [dbo].[tb_venda_dav]
        ([venda_dav_id], [venda_dav_data_preVenda], [uneg_id], [venda_pdv])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_venda_dav_item_tb_venda_dav'
CREATE INDEX [IX_FK_tb_venda_dav_item_tb_venda_dav]
ON [dbo].[tb_venda_dav_item]
    ([venda_dav_id], [venda_dav_data_preVenda], [uneg_id], [venda_pdv]);
GO

-- Creating foreign key on [venda_dav_item_id], [venda_dav_data_preVenda], [venda_dav_id], [uneg_id], [venda_pdv] in table 'tb_venda_dav_item'
ALTER TABLE [dbo].[tb_venda_dav_item]
ADD CONSTRAINT [FK_tb_venda_dav_item_tb_venda_dav_item]
    FOREIGN KEY ([venda_dav_item_id], [venda_dav_data_preVenda], [venda_dav_id], [uneg_id], [venda_pdv])
    REFERENCES [dbo].[tb_venda_dav_item]
        ([venda_dav_item_id], [venda_dav_data_preVenda], [venda_dav_id], [uneg_id], [venda_pdv])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tb_convenio_cnv_id] in table 'tbr_promocao_convenio'
ALTER TABLE [dbo].[tbr_promocao_convenio]
ADD CONSTRAINT [FK_tbr_promocao_convenio_tb_convenio]
    FOREIGN KEY ([tb_convenio_cnv_id])
    REFERENCES [dbo].[tb_convenio]
        ([cnv_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tb_promocao_prm_id] in table 'tbr_promocao_convenio'
ALTER TABLE [dbo].[tbr_promocao_convenio]
ADD CONSTRAINT [FK_tbr_promocao_convenio_tb_promocao]
    FOREIGN KEY ([tb_promocao_prm_id])
    REFERENCES [dbo].[tb_promocao]
        ([prm_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_promocao_convenio_tb_promocao'
CREATE INDEX [IX_FK_tbr_promocao_convenio_tb_promocao]
ON [dbo].[tbr_promocao_convenio]
    ([tb_promocao_prm_id]);
GO

-- Creating foreign key on [tb_promocao_prm_id] in table 'tbr_promocao_uneg'
ALTER TABLE [dbo].[tbr_promocao_uneg]
ADD CONSTRAINT [FK_tbr_promocao_uneg_tb_promocao]
    FOREIGN KEY ([tb_promocao_prm_id])
    REFERENCES [dbo].[tb_promocao]
        ([prm_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tb_unid_negocio_uneg_id] in table 'tbr_promocao_uneg'
ALTER TABLE [dbo].[tbr_promocao_uneg]
ADD CONSTRAINT [FK_tbr_promocao_uneg_tb_unid_negocio]
    FOREIGN KEY ([tb_unid_negocio_uneg_id])
    REFERENCES [dbo].[tb_unid_negocio]
        ([uneg_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_tbr_promocao_uneg_tb_unid_negocio'
CREATE INDEX [IX_FK_tbr_promocao_uneg_tb_unid_negocio]
ON [dbo].[tbr_promocao_uneg]
    ([tb_unid_negocio_uneg_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------