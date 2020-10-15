using Agenda.Domain;
using Moq;
using System;
using AutoFixture;

namespace Agenda.Repositorio.Test
{
    public class ITelefoneContrutor : IBaseConstrutor<ITelefone>
    {
        protected ITelefoneContrutor() : base() { }

        public static ITelefoneContrutor TelefoneContrutor()
        {
            return new ITelefoneContrutor();
        }

        public ITelefoneContrutor Padrao()
        {
            _mock.SetupGet(o => o.Id).Returns(_fixture.Create<Guid>());
            _mock.SetupGet(o => o.Numero).Returns(_fixture.Create<string>());
            _mock.SetupGet(o => o.ContatoId).Returns(_fixture.Create<Guid>());
            return this;
        }

        public ITelefoneContrutor RetornaComId(Guid id)
        {
            _mock.SetupGet(o => o.Id).Returns(id);
            return this;
        }

        public ITelefoneContrutor RetornaComContatoId(Guid id)
        {
            _mock.SetupGet(o => o.ContatoId).Returns(id);
            return this;
        }
    }
}
