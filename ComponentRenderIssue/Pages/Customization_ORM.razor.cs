//
//  2018-07-09  Mark Stega
//              Created
//              See ProcessesFilterView.xaml & CalendarHelper.cs for the enumerations used herein
//
//  2020-11-20  Mark Stega
//              Split from CustomizationDialog
//

using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Components;

namespace ComponentRenderIssues
{
    public partial class Customization_ORM
    {
        private DateTime pORM_SelectedDate { get; set; } = DateTime.Now;
        private int pORM_SelectedSuiteGroup { get; set; } = 1;
        private List<GCListElement<int>> pLocationList { get; set; } = new List<GCListElement<int>>();

        protected override void OnInitialized()
        {
            base.OnInitialized();

            pLocationList.Add(new GCListElement<int>() { pDataValue = 1, pLabel = "1", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 2, pLabel = "2", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 3, pLabel = "3", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 4, pLabel = "4", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 5, pLabel = "5", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 6, pLabel = "6", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 7, pLabel = "7", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 8, pLabel = "8", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 9, pLabel = "9", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 10, pLabel = "10", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 11, pLabel = "11", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 12, pLabel = "12", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 13, pLabel = "13", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 14, pLabel = "14", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 15, pLabel = "15", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 16, pLabel = "16", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 17, pLabel = "17", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 18, pLabel = "18", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 19, pLabel = "19", pDisabled = false });
            pLocationList.Add(new GCListElement<int>() { pDataValue = 20, pLabel = "20", pDisabled = false });
        }

    }
}
