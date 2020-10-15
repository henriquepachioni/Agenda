using Agenda.Domain;
using AutoFixture;
using NUnit.Framework;
using System.Linq;

namespace Agenda.DAL.Test
{
    [TestFixture]
    public class ContatosBaseTest : BaseTest
    {
        Contatos _contatos;
        Fixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _contatos = new Contatos();
            _fixture = new Fixture();
        }
        
        [Test]
        public void ObterTodosOsContatosTest()
        {
            //Monta
            var contato1 = _fixture.Create<Contato>();
            var contato2 = _fixture.Create<Contato>();
            //Executa
            _contatos.Incluir(contato1);
            _contatos.Incluir(contato2);
            var lstContatos = _contatos.ObterTodos();
            var contatoResul = lstContatos.Where(x => x.Id == contato1.Id).First();

            //Verifica
            Assert.AreEqual(2, lstContatos.Count());
            Assert.AreEqual(contatoResul.Id, contato1.Id);
        }

        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _fixture = null;
        }
    }
}
