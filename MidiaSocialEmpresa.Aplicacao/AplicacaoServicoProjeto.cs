﻿
using System;
using System.Collections.Generic;
using MidiaSocialEmpresa.Aplicacao.Interface;
using MidiaSocialEmpresa.Dominio.Entidades;
using MidiaSocialEmpresa.Dominio.Interfaces.Servicos;

namespace MidiaSocialEmpresa.Aplicacao
{
    public class AplicacaoServicoProjeto : AplicacaoServicoBase<Projeto>, IAplicacaoServicoProjeto
    {
        private readonly IServicoProjeto _servicoProjeto;

        public AplicacaoServicoProjeto(IServicoProjeto servicoProjeto)
            : base(servicoProjeto)
        {
            _servicoProjeto = servicoProjeto;
        }

        public void AtualizarProjeto(Projeto projeto)
        {
            _servicoProjeto.AtualizarProjeto(projeto);
        }

        public Projeto CriarProjeto(Projeto projeto)
        {
            return _servicoProjeto.CriarProjeto(projeto);
        }

        public IEnumerable<Projeto> PesquisaPorNome(string texto)
        {
            return _servicoProjeto.PesquisaPorNome(texto);
        }
    }
}
