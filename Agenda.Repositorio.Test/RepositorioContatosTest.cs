using Agenda.Domain;
using Agenda.DAL;
using Agenda.Repositorio;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Agenda.Repositorio.Test
{
    [TestFixture]
    public class RepositorioContatosTest
    {
        Mock<IContatos> _contatos;
        Mock<ITelefones> _telefones;
        RepositorioContatos _repositorioContatos;

        [SetUp]
        public void SetUp()
        {
            _contatos = new Mock<IContatos>();
            _telefones = new Mock<ITelefones>();
            _repositorioContatos = new RepositorioContatos(_contatos.Object, _telefones.Object);
        }

        [Test]
        public void DeveSerPossivelObterContatoComListaTelefone()
        {
            //Monta
            var lstTelefones = new List<ITelefone>();
            var telefoneId = Guid.NewGuid();
            var contatoId = Guid.NewGuid();

            //Criar Moq de IContato
            var mockContato = IContatoConstrutor.ContatoContrutor().Padrao()
                .RetornaComId(contatoId)
                .Obter();
            mockContato.SetupSet(o => o.Telefones = It.IsAny<List<ITelefone>>())
                .Callback<List<ITelefone>>(p => lstTelefones = p);
            //Moq da funcao ObterPorId de IContatos
            _contatos.Setup(o => o.Obter(contatoId)).Returns(mockContato.Object);
            //Criar Moq de ITelefone
            ITelefone mockTelefone = ITelefoneContrutor.TelefoneContrutor().Padrao()
                .RetornaComId(telefoneId)
                .RetornaComContatoId(contatoId)
                .Construir();
                
            //Moq da funcao ObterTodosPorContato de ITelefones
            _telefones.Setup(o => o.ObterTodosDoContatos(contatoId)).Returns(new List<ITelefone> { mockTelefone });
            //Executa
            //Chamar o método ObterPorId de RepositorioContatos
            var contatoResultado = _repositorioContatos.ObterPorId(contatoId);
            mockContato.SetupGet(o => o.Telefones).Returns(lstTelefones);
            //Verifica
            //Verificar se o contato retornado contém os mesmos dados do Moq de IContato com a lista de telefones do Moq ITelefone
            Assert.AreEqual(mockContato.Object.Id, contatoResultado.Id);
            Assert.AreEqual(mockContato.Object.Nome, contatoResultado.Nome);
            Assert.AreEqual(1, mockContato.Object.Telefones.Count);
            Assert.AreEqual(mockTelefone.Numero, contatoResultado.Telefones[0].Numero);
            Assert.AreEqual(mockTelefone.Id, contatoResultado.Telefones[0].Id);
            Assert.AreEqual(mockContato.Object.Id, contatoResultado.Telefones[0].ContatoId);
        }

        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _telefones = null;
        }
    }
}
