using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.RenderEngine.AntBlazor.DataEntryComponent
{
    internal class SelectRender : ElementRenderBase
    {
        public override bool CanRender(JSchema jsonSchema)
        {
            return false;
        }

        public override void Render(RenderTreeBuilder builder, string keys, JSchema jsonSchema, Func<JSchema, RenderFragment> func)
        {
            throw new NotImplementedException();
        }
    }
}
