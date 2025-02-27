﻿using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace IngressoMVC.Models
{
    public class Filme : IEntidade
    {      
        public Filme(string titulo, string descricao, decimal preco, string imageURL, int produtorId, int cinemaId)
        {
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            ImageURL = imageURL;
            ProdutorId = produtorId;
            CinemaId = cinemaId;

            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;            
        }

        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public string ImageURL { get; private set; }

        #region relacionamentos
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        public int ProdutorId { get; set; }
        public Produtor Produtor { get; set; }

        public List<AtorFilme> AtoresFilmes { get; set; }
        public List<FilmeCategoria> FilmesCategorias { get; set; }
        #endregion


        public void AlterarDados(string titulo, string descricao, decimal novoPreco, string imagem, int produtorId, int cinemaId)
        {
            if (titulo.Length < 1 || novoPreco < 0)
                return;
            Titulo = titulo;
            Descricao = descricao;
            Preco = novoPreco;
            ImageURL = imagem;
            ProdutorId = produtorId;
            CinemaId = cinemaId;

            DataAlteracao = DateTime.Now;
        }
    }
}
