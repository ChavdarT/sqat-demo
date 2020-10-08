using SQAT.api.main.core;

namespace SQAT_demo.test.api.methods.pets
{
    class GetPetMethod : AbstractApiMethod
    {
        public GetPetMethod()
        {
            ReplaceInUrl("baseUrl", "https://petstore.swagger.io/v2");
            ReplaceInUrl("petId", "1");
        }
    }
}
