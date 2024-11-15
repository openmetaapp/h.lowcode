﻿using H.LowCode.Configuration;
using H.LowCode.DesignEngine.Application;
using H.LowCode.DesignEngine.Application.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace H.LowCode.DesignEngine.HttpApi;

[DependsOn(typeof(DesignEngineApplicationModule))]
public class DesignEngineHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddControllers().AddApplicationPart(typeof(DesignEngineHttpApiModule).Assembly);

        var configuration = context.Services.GetConfiguration();
        context.Services.Configure<List<SiteOption>>(configuration.GetSection(SiteOption.SectionName));
    }
}
