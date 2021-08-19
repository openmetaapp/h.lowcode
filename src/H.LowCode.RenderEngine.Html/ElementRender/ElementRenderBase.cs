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
    internal abstract class ElementRenderBase
    {
        public abstract void Render(RenderTreeBuilder builder, JSchema jsonSchema, Func<JSchema, RenderFragment> func);
    }
}
