using Business.Helpers;
using Xunit;

namespace Tests.Helpers
{
    public class IdGenerator_Tests
    {
        [Fact]
        public void GenerateId_ShouldReturnUniqueGuid()
        {
            var id1 = IdGenerator.GenerateId();
            var id2 = IdGenerator.GenerateId();

            Assert.NotEqual(id1, id2);
            Assert.IsType<Guid>(id1);
            Assert.IsType<Guid>(id2);
        }
    }
}
