using System;
using ToDoApp.Domain.Entities;
using Xunit;

namespace ToDoApp.Domain.Tests.Entities
{
    public class TarefaTests
    {
        [Fact]
        public void ConcluirTarefaJaConcluidaRetornaErro()
        {
            //Arrange
            var tarefa = new Tarefa(1, "teste", "teste de descrição");
            tarefa.Concluir();

            //Act
            var exception = Assert.Throws<Exception>(() => tarefa.Concluir());

            //Assert
            Assert.Equal("Tarefa já está concluída", exception.Message);
        }

        [Fact]
        public void ConcluirTarefaPendenteSemErros()
        {
            //Arrange
            var tarefa = new Tarefa(1, "teste", "teste de descrição");

            //Act
            tarefa.Concluir();

            //Assert
            Assert.True(tarefa.DataConclusao.HasValue);
        }
    }
}