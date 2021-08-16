using H.LowCode.JsonSchema.RenderEngine;
using H.LowCode.WasmHost.Client.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H.LowCode.WasmClient.Pages
{
    public partial class FormTemplate : ComponentBase
    {
        //[Parameter]
        //public string Id { get; set; }

        //protected override void BuildRenderTree(RenderTreeBuilder builder)
        //{
        //    JsonSchemaRender render = new JsonSchemaRender();
        //    render.Execute("sample-jsonschema/Sample.json", nameof(FormTemplate));

        //    builder.OpenComponent(0, typeof(SurveyPrompt));
        //    builder.AddAttribute(1, "Title", "Some title" + new Random().Next());
        //    builder.CloseComponent();
        //}

    }
}
