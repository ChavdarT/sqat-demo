using System.Net;
using NUnit.Framework;
using SQAT_demo.test.api.methods.pets;

namespace SQAT_demo.test.api.pets
{
    [TestFixture]
    internal class PetsTests
    {
        [Test]
        public void GetPetTest()
        {
            var method = new GetPetMethod();

            var response = method.CallApi();

            method.ExpectResponseStatus(HttpStatusCode.OK);

            Assert.IsNotNull(response);

            method.ValidateAgainstJsonSchema(@"api\\resources\\pets\\responseSchema.json");

            var petId = method.GetValueFromResponse("id");

            Assert.AreNotEqual(string.Empty, petId);
        }

        [Test]
        public void PostMethodTest()
        {
            var method = new PostPetMethod();

            var response = method.CallApi();

            method.ExpectResponseStatus(HttpStatusCode.OK);

            method.ValidateResponse();

            Assert.IsNotNull(response);
        }

        [Test]
        public void GetFindPetsByStatusMethod()
        {
            var api = new FindPetsByStatusMethod();

            var response = api.CallApi();

            Assert.IsNotNull(response);

            api.ExpectResponseStatus(HttpStatusCode.OK);
        }
    }
}
