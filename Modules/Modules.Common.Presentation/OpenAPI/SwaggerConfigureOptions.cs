using System;
using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Modules.Common.Presentation.OpenAPI
{
    public class SwaggerConfigureOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;
        public SwaggerConfigureOptions(IApiVersionDescriptionProvider provider) => _provider = provider;

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var desc in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(desc.GroupName, CreateInfoForApiVersion(desc));
            }
        }

        private static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo
            {
                Title = "PMS API Services",
                Version = description.ApiVersion.ToString(),
                Description = "Back-end API Services for the Property Management System",
                Contact = new OpenApiContact { Name = "MindSprings Company Limited", Email = "boakye.ofori-atta@mindsprings-gh.com" },
                License = new OpenApiLicense { Name = "TDC Ghana Ltd Vendor License" },

                Extensions = new Dictionary<string, IOpenApiExtension>
                        {
                            {"x-logo", new OpenApiObject
                                {
                                    {"url", new OpenApiString("https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/tdclogo.jpg")},
                                    { "altText", new OpenApiString("https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/tdclogo.jpg")}
                                }
                            }
                        }
            };

            return info;
        }


    }
}

