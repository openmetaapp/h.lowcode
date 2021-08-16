using H.LowCode.JsonSchema.Parser;
using System;

namespace H.LowCode.JsonSchema.RenderEngine.PageRender
{
    internal class FormRender
    {
        public void Execute(string id)
        {
            //加载Json
            JsonSchemaLoader.Load(id);
        }
    }
}
