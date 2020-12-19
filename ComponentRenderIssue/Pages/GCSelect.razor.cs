using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Material.Blazor;

using Microsoft.AspNetCore.Components;

namespace ComponentRenderIssues
{
    public partial class GCSelect<TItem>
    {
        [Parameter] public bool pDisabled { get; set; } = false;
        [Parameter] public IEnumerable<GCListElement<TItem>> pGCItems { get; set; }
        [Parameter] public eItemValidation? pGCItemValidation { get; set; }
        [Parameter] public string pLabel { get; set; }
        [Parameter] public eSelectInputStyle? pGCSelectInputStyle { get; set; }
        [Parameter] public string pAdditionalStyles { get; set; }
        [Parameter] public eTextAlignStyle? pGCTextAlignStyle { get; set; }
        [Parameter] public TItem pValue { get; set; }
        [Parameter] public EventCallback<TItem> pValueChanged { get; set; }
        [Parameter] public Expression<Func<TItem>> pValueExpression { get; set; }

        private List<MBListElement<TItem>> pItems { get; set; }
        private MBItemValidation? pItemValidation { get; set; } = null;
        private MBSelectInputStyle? pSelectInputStyle { get; set; } = null;
        private MBTextAlignStyle? pTextAlignStyle { get; set; } = null;

        protected override void OnInitialized()
        {
            base.OnInitialized();

            var converters = new GCConverters<TItem>();

            pItems = converters.ConvertToListElement(pGCItems);

            pItemValidation = converters.ConvertToItemValidation(pGCItemValidation);

            pSelectInputStyle = converters.ConvertToSelectInputStyle(pGCSelectInputStyle);

            pTextAlignStyle = converters.ConvertToTextAlignStyle(pGCTextAlignStyle);
        }

    }
}
