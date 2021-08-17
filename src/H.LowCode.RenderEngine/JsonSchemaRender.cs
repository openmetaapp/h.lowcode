using H.LowCode.RenderEngine.PageRender;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.RenderEngine
{
    public class JsonSchemaRender
    {
        public RenderFragment Render(JSchema jsonSchema, string jsonData)
        {
            //ValidateJsonSchema(jsonSchema, jsonData);

            FormRender render = new FormRender();
            return render.Render(jsonSchema);
        }

        private bool ValidateJsonSchema(JSchema jsonSchema, string jsonData)
        {
            if (jsonSchema == null)
                return false;

            // load schema
            JSchema schema = JSchema.Parse(jsonSchema.ToString());
            JToken json = JToken.Parse(jsonData);

            // validate json
            IList<ValidationError> errors;
            bool valid = json.IsValid(schema, out errors);

            return valid;
        }
    }
}
