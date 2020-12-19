//
//  2020-03-27  Mark Stega
//              Created
//

using System;
using System.Linq.Expressions;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ComponentRenderIssues
{
    public partial class GCDatePicker
    {
        [Parameter] public bool pDisabled { get; set; } = false;
        [Parameter] public string pLabel { get; set; } = "";
        [Parameter] public EventCallback<DateTime> pDateTimeValueChanged { get; set; }
        [Parameter] public Expression<Func<DateTime>> pDateTimeValueExpression { get; set; }
        [Parameter] public DateTime pDateTimeValue { get; set; }
        [Parameter] public DateTime pEarliestDate { get; set; } = new DateTime(2020, 1, 1);
        [Parameter] public DateTime pLatestDate { get; set; } = new DateTime(2099, 12, 31);
        [Parameter] public string pAdditionalStyles { get; set; }
    }
}

