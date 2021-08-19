using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.RenderEngine.Html.ElementRender
{
    internal class InputElementRender : ElementRenderBase
    {
        public override void Render(RenderTreeBuilder builder, JSchema jsonSchema, Func<JSchema, RenderFragment> func)
        {
            builder.OpenElement(0, "div");

            if (jsonSchema.Required.Count > 0)
            {
                builder.AddMarkupContent(1, "<span style='color:red;'>*</span>");
            }

            builder.AddContent(2, jsonSchema.Title);
            builder.CloseElement();

            builder.OpenElement(0, "input");
            builder.AddAttribute(1, "type", "text");

            if (jsonSchema.Required.Count > 0)
                builder.AddAttribute(2, "required", "required");

            builder.CloseElement();

            //无需调用委托，input元素不存在子元素
        }
    }
}
