using Microsoft.AspNetCore.Components;
using Newtonsoft.Json.Schema;
using System;

namespace H.LowCode.RenderEngine.PageRender
{
    internal class FormRender
    {
        public RenderFragment Render(JSchema jsonSchema)
        {
            return CreateDynamicComponent();
        }

        private RenderFragment CreateDynamicComponent() => builder =>
        {
            builder.OpenElement(0, "h3");
            builder.AddContent(1, "动态渲染: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            builder.CloseElement();
        };
    }
}
