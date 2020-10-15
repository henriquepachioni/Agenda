using Agenda.Domain;
using AutoFixture;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Repositorio.Test
{
    public class IContatoConstrutor : IBaseConstrutor<IContato>
    {
        protected IContatoConstrutor() : base() { }

        public static IContatoConstrutor ContatoContrutor()
        {
            return new IContatoConstrutor();
        }

        public IContatoConstrutor Padrao()
        {
            _mock.SetupGet(o => o.Id).Returns(_fixture.Create<Guid>());
            _mock.SetupGet(o => o.Nome).Returns(_fixture.Create<string>());
            return this;
        }

        public IContatoConstrutor RetornaComId(Guid id)
        {
            _mock.SetupGet(o => o.Id).Returns(id);
            return this;
        }
    }
}

