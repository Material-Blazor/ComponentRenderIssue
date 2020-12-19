//
//  2018-11-20  Mark Stega
//              Created
//
//  2020-03-09  Mark Stega
//              Converted to use GCDialog
//

using System.Collections.Generic;
using System.Threading.Tasks;

using Material.Blazor;

using Microsoft.AspNetCore.Components;

namespace ComponentRenderIssues
{
    public partial class GCDialog
    {
        // The standard button styles we support
        public enum eButtonStyles
        {
            None, OK, OKCancel, YesNo
        };

#pragma warning disable IDE1006 // Naming Styles - Required Blazor name
        [Parameter] public RenderFragment ChildContent { get; set; }
#pragma warning restore IDE1006 // Naming Styles - Required Blazor name

        // Additional styles to pass to MBDialog
        [Parameter] public string pAdditionalStyles { get; set; } = string.Empty;

        // We invoke this to report OK or cancel
        [Parameter] public EventCallback<string> pOnDialogActionAsync { get; set; }

        // We get this passed in for the title
        [Parameter] public string pDialogTitle { get; set; }

        // And this for button display
        [Parameter] public eButtonStyles pButtonSelection { get; set; } = eButtonStyles.None;

        //
        //  An optional list of key/value pairs for custom buttons. They key is the button id, and
        //  the value is the button text.
        //
        [Parameter] public List<KeyValuePair<string, string>> pCustomButtons { get; set; } = null;

        protected MBDialog pDialogReference { get; set; }

        protected async Task OnDialogActionAsync(GCButtonRes result)
        {
            await pOnDialogActionAsync.InvokeAsync(result.pButtonId);
        }

        public async Task OpenDialogAsync()
        {
//            await pDialogReference.ShowAsync();
            _ = pDialogReference.ShowAsync();
            await Task.CompletedTask;
        }

        /*
        public async Task<string> OpenDialogWithWaitForActionAsync()
        {
            return await pDialogReference.ShowAsync();
        }
        */

        public async Task CloseDialogAsync()
        {
            await pDialogReference.HideAsync();
        }

    }
}
