﻿using System;

namespace H.LowCode.MetaSchema;

public abstract class BaseMetaSchema
{
    public string CreatedUser {  get; set; }

    public DateTime CreatedTime { get; set; }

    public string ModifiedUser { get; set; }

    public DateTime ModifiedTime { get; set; }
}