﻿using H.LowCode.MetaSchema;
using System.Text.Json.Serialization;

namespace H.LowCode.PartsMetaSchema;

public class ComponentPartsSchema : BaseMetaSchema
{
    public ComponentPartsSchema(string componentName)
    {
        ComponentName = componentName;
    }

    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// 组件名称
    /// </summary>
    [JsonPropertyName("n")]
    public string ComponentName { get; }
    
    /// <summary>
    /// 是否隐藏标题
    /// </summary>
    [JsonPropertyName("hide")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool IsHiddenTitle { get; set; }

    /// <summary>
    /// 组件渲染片段
    /// </summary>
    [JsonPropertyName("fragment")]
    public IList<ComponentFragmentSchema> ComponentFragments { get; set; } = [];

    /// <summary>
    /// 组件属性
    /// </summary>
    [JsonPropertyName("compprop")]
    public ComponentPropertySchema ComponentProperty { get; set; }

    /// <summary>
    /// 组件样式
    /// </summary>
    [JsonPropertyName("style")]
    public ComponentStyleSchema ComponentStyle { get; set; } = new();

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("childs")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public IList<ComponentSchema> Childrens { get; set; } = [];

    [JsonPropertyName("ds")]
    public DataSourceSchema DataSource { get; set; }
}