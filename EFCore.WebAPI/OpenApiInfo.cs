using Swashbuckle.AspNetCore.Swagger;

namespace EFCore.WebAPI
{
    internal class OpenApiInfo : Info
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}