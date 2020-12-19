//
//  2019-03-05  Mark Stega
//              Created
//

using System;
using System.Threading.Tasks;

using Material.Blazor;

using Microsoft.AspNetCore.Components;

namespace ComponentRenderIssues

{
    public partial class GCButton
    {
        [Parameter] public string pButtonId { get; set; }
        [Parameter] public string pLeadingIcon { get; set; } = null;
        [Parameter] public string pTrailingIcon { get; set; } = null;
        [Parameter] public bool pDisabled { get; set; } = false;
        [Parameter] public object pUserData { get; set; } = null;
        [Parameter] public string pButtonText { get; set; }
        [Parameter] public string pButtonType { get; set; } = "button";
        [Parameter] public string pAdditionalStyles { get; set; } = string.Empty;
        [Parameter] public EventCallback<GCButtonRes> pOnClickAsync { get; set; }
        public MBButtonStyle? pMdcButtonStyle { get; set; } = MBButtonStyle.ContainedRaised;

        public const string m_StdId_Cancel = "CANCEL";
        public const string m_StdId_No = "NO";
        public const string m_StdId_OK = "OK";
        public const string m_StdId_Yes = "YES";

        public async Task InternalClick()
        {
            if (!pDisabled)
            {
                await pOnClickAsync.InvokeAsync(new GCButtonRes(pButtonId, pUserData));
            }
        }
    }

    public class GCButtonRes : EventArgs
    {
        public GCButtonRes(string id, object data)
        {
            pButtonId = id;
            pUserData = data;
        }

        public string pButtonId { get; set; }

        public object pUserData { get; set; } = null;
    };
}
