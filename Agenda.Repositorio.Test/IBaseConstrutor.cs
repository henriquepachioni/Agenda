using AutoFixture;
using Moq;

namespace Agenda.Repositorio.Test
{
    public class IBaseConstrutor<T> where T : class
    {
        protected readonly Mock<T> _mock;
        protected readonly Fixture _fixture;

        protected IBaseConstrutor()
        {
            _mock = new Mock<T>();
            _fixture = new Fixture();
        }

        public T Construir()
        {
            return _mock.Object;
        }

        public Mock<T> Obter()
        {
            return _mock;
        }
    }
}
