using Alura.Adopet.Console;
using Alura.Adopet.Console.Servicos;
using Xunit;

namespace Tests
{
    public class httpClientTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Fact]
        public async Task ListNotEmpty()
        {
            var clientPet = new HttpClientPet();

            //Assert.Pass();

            var list = await clientPet.ListPetsAsync();

        }

        [Fact]
        public async Task Exceptions()
        {
            var clientPet = new HttpClientPet(uri: "http://localhost:1111");

            await Xunit.Assert.ThrowsAsync<Exception>(() => clientPet.ListPetsAsync());

        }
    }
}