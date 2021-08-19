using H.LowCode.RenderEngine.Html.ElementRender;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;

namespace H.LowCode.RenderEngine.Html.PageRender
{
    internal class FormRender
    {
        public RenderFragment Render(JSchema jsonSchema)
        {
            return CreateDynamicComponent(jsonSchema);
        }

        private RenderFragment CreateDynamicComponent() => builder =>
        {
            builder.OpenElement(0, "h3");
            builder.AddContent(1, "动态渲染: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            builder.CloseElement();
        };

        private RenderFragment CreateDynamicComponent(JSchema jsonSchema) => builder =>
        {
            foreach (var kv in jsonSchema.Properties)
            {
                string elementType = kv.Value.Type.ToString().ToLower();
                if (ElementTypeConst.ElementTypeDic.TryGetValue(elementType, out Type elementRenderType))
                {
                    ElementRenderBase elementRender = (ElementRenderBase)Activator.CreateInstance(elementRenderType);

                    elementRender.Render(builder, kv.Value, CreateDynamicComponent);
                }
                else
                    throw new ArgumentOutOfRangeException($"参数不合法");
            }
        };
    }
}
