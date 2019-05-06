using System;
using TesteTDD.DAO;
using TesteTDD.Models;
using Xunit;

namespace TesteForum
{
    public class AdicionarPergunta
    {
        [Fact]
        public void Adicionar()
        {
            string emailUsuario = "isapsz@gmail";

            var user = new UsuarioDAO();

            Usuario usuario = user.BuscaPorEmail(emailUsuario);

            Pergunta pergunta = new Pergunta
            {
                Titulo = "Como colocar uma camisinha?",
                Descricao = "Ol�, tenho uma d�vida, gostaria de saber como fa�o para colocar um camisinha",
                PalavraChave = "Camisinha",
                QuantidadeAcesso = 0,
                CodUsuario = usuario.Id
            };

            var dao = new PerguntaDAO();

            string cadastrado = dao.Adicionar(pergunta);

            Assert.Equal("Como colocar uma camisinha?", cadastrado);
        }
    }
}
