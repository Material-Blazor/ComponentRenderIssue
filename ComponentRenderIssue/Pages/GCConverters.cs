using System;
using System.Collections.Generic;
using System.Text;

using Material.Blazor;

namespace ComponentRenderIssues
{
#nullable enable annotations
    public class GCConverters<TItem>
    {
        public List<MBSelectElement<TItem>> ConvertToListElement(IEnumerable<GCListElement<TItem>>? p_GCListElementList)
        {
            var convertedItems = new List<MBSelectElement<TItem>>();
            foreach (var item in p_GCListElementList)
            {
                var newItem = new MBSelectElement<TItem>
                {
                    Disabled = item.pDisabled,
                    Label = item.pLabel,
                    SelectedValue = item.pDataValue
                };
                convertedItems.Add(newItem);
            }
            return convertedItems;
        }

        public MBButtonStyle? ConvertToButtonStyle(eButtonStyle? p_GCButtonStyle)
        {
            if (p_GCButtonStyle != null)
            {
                switch (p_GCButtonStyle)
                {
                    default:
                    case eButtonStyle.ContainedRaised:
                        return MBButtonStyle.ContainedRaised;

                    case eButtonStyle.ContainedUnelevated:
                        return MBButtonStyle.ContainedUnelevated;

                    case eButtonStyle.Outlined:
                        return MBButtonStyle.Outlined;

                    case eButtonStyle.Text:
                        return MBButtonStyle.Text;
                }
            }
            else
            {
                return null;
            }
        }

        public MBItemValidation? ConvertToItemValidation(eItemValidation? p_GCItemValidation)
        {
            if (p_GCItemValidation != null)
            {
                switch (p_GCItemValidation)
                {
                    default:
                    case eItemValidation.DefaultToFirst:
                        return MBItemValidation.DefaultToFirst;

                    case eItemValidation.Exception:
                        return MBItemValidation.Exception;

                    case eItemValidation.NoSelection:
                        return MBItemValidation.NoSelection;
                }
            }
            else
            {
                return null;
            }
        }

        public MBSelectInputStyle? ConvertToSelectInputStyle(eSelectInputStyle? p_GCSelectInputStyle)
        {
            if (p_GCSelectInputStyle != null)
            {
                switch (p_GCSelectInputStyle)
                {
                    default:
                    case eSelectInputStyle.Filled:
                        return MBSelectInputStyle.Filled;

                    case eSelectInputStyle.Outlined:
                        return MBSelectInputStyle.Outlined;
                }
            }
            else
            {
                return null;
            }
        }

        public MBTextAlignStyle? ConvertToTextAlignStyle(eTextAlignStyle? p_GCTextAlignStyle)
        {
            if (p_GCTextAlignStyle != null)
            {
                switch (p_GCTextAlignStyle)
                {
                    default:
                    case eTextAlignStyle.Center:
                        return MBTextAlignStyle.Center;

                    case eTextAlignStyle.Default:
                        return MBTextAlignStyle.Default;

                    case eTextAlignStyle.Left:
                        return MBTextAlignStyle.Left;

                    case eTextAlignStyle.Right:
                        return MBTextAlignStyle.Right;
                }
            }
            else
            {
                return null;
            }
        }

    }
#nullable restore annotations
}
