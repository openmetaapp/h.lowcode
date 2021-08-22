using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;

namespace H.LowCode.Theme
{
    public class MainLayout : LayoutComponentBase
    {
        [Inject]
        private MainLayout InjectMainLayout { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);

            builder.OpenComponent(0, InjectMainLayout.GetType());
            builder.CloseComponent();
        }
    }
}
