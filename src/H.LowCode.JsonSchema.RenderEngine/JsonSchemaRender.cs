using H.LowCode.JsonSchema.RenderEngine.PageRender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.JsonSchema.RenderEngine
{
    public class JsonSchemaRender
    {
        public void Execute(string id, string type)
        {
            FormRender render = new FormRender();
            render.Execute(id);
        }
    }
}
