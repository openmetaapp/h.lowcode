﻿using AntDesign;
using H.LowCode.DesignEngine.DefaultComponents.Components;
using H.LowCode.MetaSchema;

namespace H.LowCode.DesignEngine.DefaultComponents.ComponentProviders
{
    public class LayoutComponentProvider : IComponentProvider
    {
        public string Title { get; set; } = "布局组件";

        public IEnumerable<ComponentSchema> LoadComponent()
        {
            List<ComponentSchema> components =
            [
                new ComponentSchema(ComponentType:"grid"){
                    IsHiddenTitle = true,
                    ComponentCategory = ComponentCategory.Layout,
                    RenderFragment = (componentSchema) =>  (builder) =>
                    {
                        builder.OpenComponent(0, typeof(GridContainer));
                        builder.AddComponentParameter(0, "Component", componentSchema);
                        builder.CloseComponent();
                    },
                    ComponentPropertySchema = new ComponentPropertySchema()
                    {
                        Title = "Grid 栅格",
                        Style = "background-color: #ffffff00; height: auto;",
                        ItemWidth = 24,
                        ExtensionProperties = new Dictionary<string, ComponentExtensionPropertySchema>(){
                            { "rows", new ComponentExtensionPropertySchema() { Label = "行数", Value = 1 } },
                            { "cols", new ComponentExtensionPropertySchema(){ Label = "列数", Value = 2 } }
                        }
                    }
                },
                new ComponentSchema(ComponentType:"layout"){
                    IsHiddenTitle = true,
                    ComponentCategory = ComponentCategory.Layout,
                    SupportProperties = ["MaximumLength", "MinimumLength", "Pattern", "Format"],
                    RenderFragment = (componentSchema) =>  (builder) =>
                    {
                        builder.OpenComponent(0, typeof(LayoutContainer));
                        builder.AddComponentParameter(0, "Component", componentSchema);
                        builder.CloseComponent();
                    },
                    ComponentPropertySchema = new ComponentPropertySchema()
                    {
                        Title = "Layout 布局",
                        Style = "background-color: #ffffff00",
                        ItemWidth = 24,
                        ItemHeight = 150,
                        CustomStyle = "height: 100%"
                    }
                }
            ];
            return components;
        }
    }
}