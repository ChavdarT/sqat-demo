using SQAT.api.main.core;
using static SQAT.configuration.Configuration;

namespace SQAT_demo.test.api.methods.pets
{
    class FindPetsByStatusMethod : AbstractApiMethod
    {
        public FindPetsByStatusMethod()
        {
            ReplaceInUrl("baseUrl", GetApiPropertyValue("url_pets"));
            ReplaceInUrl("status", "available");
        }
    }
}
