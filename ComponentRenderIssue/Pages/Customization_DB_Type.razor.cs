//
//  2018-07-09  Mark Stega
//              Created
//              See ProcessesFilterView.xaml & CalendarHelper.cs for the enumerations used herein
//
//  2020-11-20  Mark Stega
//              Split from CustomizationDialog
//

using Microsoft.AspNetCore.Components;

namespace ComponentRenderIssues
{
    public partial class Customization_DB_Type
    {
        private int pDashboardType { get; set; } = 1;
        private GCListElement<int>[] pDashboardTypeItems { get; set; } = new GCListElement<int>[]
            {
                new GCListElement<int>{
                    pDataValue = 0,
                    pLabel = "Medical Oncology Infusion"},
                new GCListElement<int>{
                    pDataValue = 3,
                    pLabel = "OR Manager"},
                new GCListElement<int>{
                    pDataValue = 1,
                    pLabel = "PreAnesthesia"},
                new GCListElement<int>{
                    pDataValue = 2,
                    pLabel = "Surgical Office"},
            };

    }
}
