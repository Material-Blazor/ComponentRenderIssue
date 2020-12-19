using System.Collections.Generic;

using Microsoft.AspNetCore.Components;

namespace ComponentRenderIssues
{
    public partial class GCSlidingTabBar<TItem>
    {
        [Parameter] public RenderFragment<TItem> pContent { get; set; }
        [Parameter] public RenderFragment<TItem> pIcon { get; set; }
        [Parameter] public IEnumerable<TItem> pItems { get; set; }
        [Parameter] public RenderFragment<TItem> pLabel { get; set; }
        [Parameter] public bool pStackIcons { get; set; }
        [Parameter] public int pTabIndex { get; set; }
        [Parameter] public EventCallback<int> pTabIndexChanged { get; set; }
    }
}
