﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H.LowCode.RenderEngine.Html.BasicComponent
{
    internal class InputNumberRender : ComponentRenderBase
    {
        public override bool CanRender(JSchema jsonSchema)
        {
            if (jsonSchema.Type == JSchemaType.Number)
                return true;

            return false;
        }

        public override void Render(RenderTreeBuilder builder, string key, JSchema jsonSchema, Func<JSchema, RenderFragment> func)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "field-label");
            if (jsonSchema.Required.Count > 0)
            {
                builder.AddMarkupContent(2, "<span style='color:red;'>*</span>");
            }
            builder.AddContent(3, $"{jsonSchema.Title}：");
            builder.CloseElement();

            builder.OpenElement(0, "input");
            builder.AddAttribute(1, "type", "number");
            builder.AddAttribute(2, "class", "field-value");

            if (jsonSchema.Required.Count > 0)
                builder.AddAttribute(3, "required", "required");

            builder.CloseElement();
        }
    }
}