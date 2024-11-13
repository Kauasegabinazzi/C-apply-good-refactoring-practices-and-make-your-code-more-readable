using Alura.Adopet.Console;

namespace Tests
{
    public class httpClientTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ListNotEmpty()
        {
            var clientPet = new HttpClientPet();

            //Assert.Pass();

            var list = await clientPet.ListPetsAsync();

        }
    }
}