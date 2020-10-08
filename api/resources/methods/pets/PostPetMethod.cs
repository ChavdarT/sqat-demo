using SQAT.api.main.core;
using static SQAT.configuration.Configuration;

namespace SQAT_demo.test.api.methods.pets
{
    class PostPetMethod : AbstractApiMethod
    {
        public PostPetMethod() : base(@"api\\resources\\pets\\request.json",
            @"api\\resources\\pets\\response.json",
            @"api\\resources\\pets\\pet.Properties")
        {

            ReplaceInUrl("baseUrl", GetApiPropertyValue("url_pets"));
        }
    }
}
