// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Presentation/OpenAPI/SwaggerConfigureOptions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 11:41 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Presentation.OpenAPI
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
                Title = "Facilities Module - PMS Platform API Services",
                Version = description.ApiVersion.ToString(),
                Description = "Back-end API Services for the PMS Platform",
                Contact = new OpenApiContact { Name = "MindSprings Company Limited", Email = "boakye.ofori-atta@mindsprings-gh.com" },
                License = new OpenApiLicense { Name = "TDC Ghana Ltd License" },

                Extensions = new Dictionary<string, IOpenApiExtension>
                        {
                            {"x-logo", new OpenApiObject
                                {
                                    {"url", new OpenApiString("")},
                                    { "altText", new OpenApiString("")}
                                }
                            }
                        }
            };

            return info;
        }

    }
}

