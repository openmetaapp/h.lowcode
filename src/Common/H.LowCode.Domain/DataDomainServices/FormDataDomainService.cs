﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace H.LowCode.Domain;

public class FormDataDomainService : DomainService, IFormDataDomainService
{
    public FormDataDomainService(IFormDataRepository formDataRepository)
    {

    }

    public Task<FormEntity> Get<TKey>(TKey id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Save(FormEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete<TKey>(TKey id)
    {
        throw new NotImplementedException();
    }
}
