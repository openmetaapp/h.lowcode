using H.LowCode.RenderEngine.Html.ElementRender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.LowCode.RenderEngine.Html
{
    internal static class ElementTypeConst
    {

        internal static readonly Dictionary<string, Type> ElementTypeDic = new Dictionary<string, Type>()
        {
            { "string", typeof(InputElementRender)}
            , {"select", typeof(SelectElementRender) }
        };
    }
}
