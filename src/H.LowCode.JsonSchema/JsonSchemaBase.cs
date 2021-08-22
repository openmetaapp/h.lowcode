using Newtonsoft.Json.Schema;
using System;

namespace H.LowCode.JsonSchema
{
    public class JsonSchemaBase : JSchema
    {
        public  Array EnumNames { get; set; }

        /// <summary>
        /// 组件类型
        /// </summary>
        public string WidgetType 
        { 
            get 
            {
                if (this.Type == JSchemaType.String && this.Enum.Count > 0)
                    return "select";
                else
                    return "input";

            }
            set { }
        }
    }
}
