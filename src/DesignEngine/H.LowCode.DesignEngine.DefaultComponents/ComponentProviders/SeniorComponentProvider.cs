﻿using AntDesign;
using H.LowCode.MetaSchema;

namespace H.LowCode.DesignEngine.DefaultComponents.ComponentProviders
{
    public class SeniorComponentProvider : IComponentProvider
    {
        public string Title { get; set; } = "高级组件";

        public IEnumerable<ComponentSchema> LoadComponent()
        {
            List<ComponentSchema> components = new List<ComponentSchema>()
            {
                new ComponentSchema(ComponentType:"upload"){
                    RenderFragment = (componentSchema) =>  (builder) =>
                    {
                        //builder.OpenComponent(0, typeof(Upload));
                        //builder.CloseComponent();
                    },
                    ComponentPropertySchema = new ComponentPropertySchema()
                    {
                        Title = "附件"
                    }
                }
            };
            return components;
        }
    }
}