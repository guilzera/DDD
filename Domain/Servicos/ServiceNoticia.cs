﻿using Domain.Interfaces;
using Domain.Interfaces.InterfaceServicos;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class ServiceNoticia : IServiceNoticia
    {
        private readonly INoticia _INoticia;

        public ServiceNoticia(INoticia INoticia)
        {
            _INoticia = INoticia;
        }

        public async Task AdicionarNoticia(Noticia noticia)
        {
            var validarTitulo = noticia.ValidarPropriedadeString(noticia.Titulo, "Titulo");
            var validarInformacao = noticia.ValidarPropriedadeString(noticia.Informacao, "Informacao");

            if(validarTitulo && validarInformacao)
            {
                noticia.DataAlteracao = DateTime.Now;    
                noticia.DataCadastro = DateTime.Now;
                noticia.Ativo = true;
                await _INoticia.Adicionar(noticia);
            }
        }

        public async Task AtualizaNoticia(Noticia noticia)
        {
            var validarTitulo = noticia.ValidarPropriedadeString(noticia.Titulo, "Titulo");
            var validarInformacao = noticia.ValidarPropriedadeString(noticia.Informacao, "Informacao");

            if (validarTitulo && validarInformacao)
            {
                noticia.DataAlteracao = DateTime.Now;
                noticia.DataCadastro = DateTime.Now;
                noticia.Ativo = true;
                await _INoticia.Atualizar(noticia);
            }
        }

        //Lista somente noticias ativas
        public async Task<List<Noticia>> ListarNoticiasAtivas()
        {
            return await _INoticia.ListarNoticias(n => n.Ativo);
        }
    }
}
