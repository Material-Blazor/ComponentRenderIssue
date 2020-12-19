//
//  2018-07-09  Mark Stega
//              Created
//              See ProcessesFilterView.xaml & CalendarHelper.cs for the enumerations used herein
//
//  2018-11-20  Mark Stega
//              Some touchup adjustments of StateHasChanged() for Blazor 0.7.0
//
//  2019-04-22  Mark Stega
//              Fixed logic error due to multiple calls to OnAfterRender which did not occur
//              until Blazor 3.0.0 Preview 4
//
//  2020-08-28  Mark Stega
//              Support for pORManagerDashboardMode (Simplified dialog if true)
//
//  2020-11-20  Mark Stega
//              Made tab items components to handle the overly large content of the dialog
//

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace ComponentRenderIssues
{
    public partial class CustomizationDialog
    {
        // We invoke this to report OK or cancel
        [Parameter] public EventCallback<bool> pOnCompletion { get; set; }

        protected GCDialog pCustomizationDialogReference { get; set; }

        public int pTabIndexModeORM { get; set; } = 0;
        public int pTabIndexModeNonORM { get; set; } = 0;
        public string[] pTabItemsModeORM { get; set; } = new string[] { "Filter", "Type" };
        public string[] pTabItemsModeNonORM { get; set; } = new string[] { "Content", "Filter", "Sort", "Type" };

        public DateTime pORM_SelectedDate { get; set; }
        public int pORM_SelectedSuiteGroup { get; set; }
        public async Task OpenDialogAsync()
        {
            await pCustomizationDialogReference.OpenDialogAsync();
        }

        public async Task CloseDialogAsync()
        {
            await pCustomizationDialogReference.CloseDialogAsync();
        }

        protected async Task OnDialogComplete(string buttonId)
        {
            await pOnCompletion.InvokeAsync(true);
        }

    }
}
