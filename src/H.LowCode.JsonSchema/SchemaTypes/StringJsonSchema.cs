using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.JsonSchema.SchemaTypes
{
    public class StringJsonSchema : BaseJsonSchema
    {
        public string Title { get; set; }

        public bool Required { get; set; }
    }
}
