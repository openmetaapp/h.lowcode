using H.LowCode.RenderEngine.Html.PageRender;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H.LowCode.RenderEngine.Html
{
    public class HtmlRender : IRender
    {
        public RenderFragment Render(JSchema jsonSchema, string jsonData)
        {
            //JsonSchemaHelper.ValidateJsonSchema(jsonSchema, jsonData);

            FormRender render = new FormRender();
            return render.Render(jsonSchema);
        }
    }
}
