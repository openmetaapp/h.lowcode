using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.JsonSchema
{
    public class RootJsonSchema : BaseJsonSchema
    {
        public List<BaseJsonSchema> Properties { get; set; }
    }
}
