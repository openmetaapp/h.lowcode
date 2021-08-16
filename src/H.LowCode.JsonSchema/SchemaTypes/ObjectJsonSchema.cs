using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.JsonSchema.SchemaTypes
{
    public class ObjectJsonSchema : BaseJsonSchema
    {
        public object Properties { get; set; }
    }
}
