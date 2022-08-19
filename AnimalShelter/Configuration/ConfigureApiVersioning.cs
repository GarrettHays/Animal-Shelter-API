using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace AnimalShelter.Configuration
{
  public static class ConfigureApiVersioning
  {
    public static void AddApiVersioningConfigured(this IServiceCollection services)
    {
      services.AddApiVersioning(options =>
      {
        options.ReportApiVersions = true;

        options.AssumeDefaultVersionWhenUnspecified = true;
        options.DefaultApiVersion = new ApiVersion(1, 0);


        options.ApiVersionReader = ApiVersionReader.Combine(
                new QueryStringApiVersionReader("api-version"),
                new HeaderApiVersionReader("Accept-Version"),
                new MediaTypeApiVersionReader("api-version")
            );
      });
    }
  }
}