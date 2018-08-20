using System.Linq;

namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents Bootstrap dropdown toggle control (element with "dropdown-toggle" class).
    /// Default search is performed by the content.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition(ContainingClass = BSClass.DropdownToggle, ComponentTypeName = "dropdown toggle", IgnoreNameEndings = "DropdownButton,DropDownButton,Dropdown,DropDown,Button,DropdownToggle,DropDownToggle,Toggle")]
    [ControlFinding(FindTermBy.Content)]
    [ClickParent(AppliesTo = TriggerScope.Children)]
    [FindSettings(OuterXPath = "following-sibling::*[1]//")]
    public class BSDropdownToggle<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        protected override bool GetIsEnabled()
        {
            return !Attributes.Class.Value.Contains(BSClass.Disabled);
        }
    }
}
