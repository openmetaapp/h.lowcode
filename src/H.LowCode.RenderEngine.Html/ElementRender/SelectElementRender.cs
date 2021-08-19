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
    internal class SelectElementRender : ElementRenderBase
    {
        public override void Render(RenderTreeBuilder builder, JSchema jsonSchema, Func<JSchema, RenderFragment> func)
        {
            builder.OpenElement(0, "select");

            for (int i = 0; i < jsonSchema.Enum.Count - 1; i++)
            {
                builder.OpenElement(i * 3 + 1, "option");
                builder.AddAttribute(i * 3 + 2, "value", jsonSchema.Enum[i]);
                builder.AddContent(i * 3 + 3, jsonSchema.Enum[i]);
                builder.CloseElement();
            }

            builder.CloseElement();
        }
    }
}
