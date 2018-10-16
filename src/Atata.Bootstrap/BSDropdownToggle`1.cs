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
    [FindSettings(OuterXPath = "following-sibling::*[1]//", TargetAnyType = true)]
    [InvokeMethod(nameof(OnBeforeAccessChild), TriggerEvents.BeforeAccess, AppliesTo = TriggerScope.Children)]
    [InvokeMethod(nameof(OnInit), TriggerEvents.Init)]
    public class BSDropdownToggle<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        [FindByClass(BSClass.DropdownMenu, OuterXPath = "following-sibling::", Visibility = Visibility.Any)]
        [TraceLog]
        protected Control<TOwner> DropdownMenu { get; private set; }

        protected void OnInit()
        {
            DropdownMenu.Triggers.RemoveAll(x => x is InvokeMethodAttribute);
        }

        protected void OnBeforeAccessChild()
        {
            if (!DropdownMenu.IsVisible)
                Click();
        }

        protected override bool GetIsEnabled()
        {
            return !Attributes.Class.Value.Contains(BSClass.Disabled);
        }
    }
}
