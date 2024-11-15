﻿using H.LowCode.Configuration;
using H.LowCode.Domain.Repositories;
using H.LowCode.MetaSchema;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Text;

namespace H.LowCode.Repository.JsonFile;

public class AppFileRepository : FileRepositoryBase, IAppRepository
{
    private static string appFileName_Format = @"{0}\{1}\{2}.json";

    public AppFileRepository(IOptions<MetaOption> metaOption) : base(metaOption)
    {
        
    }

    public async Task<IList<AppSchema>> GetListAsync()
    {
        await Task.Delay(1);
        List<AppSchema> appSchemas = [];

        if (Directory.Exists(_metaBaseDir) == false)
            return appSchemas;

        var directories = Directory.GetDirectories(_metaBaseDir);
        foreach (var directory in directories)
        {
            DirectoryInfo dirInfo = new(directory);
            var fileName = string.Format(appFileName_Format, _metaBaseDir, dirInfo.Name, dirInfo.Name);

            if (!File.Exists(fileName))
                continue;

            var appSchemaJson = ReadAllText(fileName);
            var appSchema = appSchemaJson.FromJson<AppSchema>();
            appSchemas.Add(appSchema);
        }

        return appSchemas;
    }

    public async Task SaveAsync(AppSchema appSchema)
    {
        ArgumentNullException.ThrowIfNull(appSchema);
        ArgumentException.ThrowIfNullOrEmpty(appSchema.Id);

        appSchema.ModifiedTime = DateTime.UtcNow;

        await Task.Delay(1);
        string fileName = string.Format(appFileName_Format, _metaBaseDir, appSchema.Id, appSchema.Id);

        string fileDirectory = Path.GetDirectoryName(fileName);
        if (Directory.Exists(fileDirectory))
            throw new InvalidOperationException("应用已存在！");
        else
            Directory.CreateDirectory(fileDirectory);

        File.WriteAllText(fileName, appSchema.ToJson(), Encoding.UTF8);
    }

    public async Task<AppSchema> GetAsync(string appId)
    {
        await Task.Delay(1);
        string fileName = string.Format(appFileName_Format, _metaBaseDir, appId, appId);

        var appSchemaJson = ReadAllText(fileName);
        return appSchemaJson.FromJson<AppSchema>();
    }
}
