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
            //bool anonimo = true;
            bool anonimo = false;

            Pergunta pergunta = new Pergunta
            {
                Titulo = "Como colocar uma camisinha?",
                Descricao = "Ol�, tenho uma d�vida, gostaria de saber como fa�o para colocar um camisinha",
                PalavraChave = "Camisinha",
                QuantidadeAcesso = 0,
            };

            //string cadastro = ForumDiscussexController.FazerPergunta(anonimo, "isapsz", pergunta);
            //string cadastro = ForumDiscussexController.FazerPergunta(anonimo, "isapsz@gmail", pergunta);
            string cadastro = ForumDiscussexController.FazerPergunta(anonimo, null, pergunta);

            Assert.Equal("Como colocar uma camisinha?", cadastro);
        }
    }
}
