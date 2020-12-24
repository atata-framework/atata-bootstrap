using System.Linq;

namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents Bootstrap dropdown toggle control (element with "dropdown-toggle" class).
    /// Default search is performed by the content.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition(ContainingClass = BSClass.DropdownToggle, ComponentTypeName = "dropdown toggle", IgnoreNameEndings = "DropdownButton,DropDownButton,Dropdown,DropDown,Button,DropdownToggle,DropDownToggle,Toggle")]
    [FindByContent]
    [FindSettings(OuterXPath = "following-sibling::*[1]//", TargetAllChildren = true)]
    [InvokeMethodWithExcluding(nameof(OnBeforeAccessChild), TriggerEvents.BeforeAccess, TargetAllChildren = true, TargetNameExclude = nameof(DropdownMenu))]
    public class BSDropdownToggle<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        [FindByClass(BSClass.DropdownMenu, OuterXPath = "following-sibling::", Visibility = Visibility.Any)]
        [TraceLog]
        protected Control<TOwner> DropdownMenu { get; private set; }

        protected void OnInit()
        {
            DropdownMenu.Metadata.RemoveAll(x => x is InvokeMethodAttribute);
        }

        protected void OnBeforeAccessChild()
        {
            if (!DropdownMenu.IsVisible)
                Click();
        }

        protected override bool GetIsEnabled()
        {
            return base.GetIsEnabled() && !Attributes.Class.Value.Contains(BSClass.Disabled);
        }
    }
}
