//
//  2020-06-15  Mark Stega
//              Created
//              A list item used in GCRadioButtonGroup and GCSelect
//
namespace ComponentRenderIssues
{
    public class GCListElement<T>
    {
        public T pDataValue { get; set; }
        public string pLabel { get; set; }
        public bool pDisabled { get; set; } = false;
    }
}
