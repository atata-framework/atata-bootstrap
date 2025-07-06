namespace Atata.Bootstrap;

/// <summary>
/// Represents Bootstrap dropdown toggle control (element with "dropdown-toggle" class).
/// Default search is performed by the content.
/// </summary>
/// <typeparam name="TOwner">The type of the owner page object.</typeparam>
[ControlDefinition(ContainingClass = BSClass.DropdownToggle, ComponentTypeName = "dropdown toggle", IgnoreNameEndings = "DropdownButton,DropDownButton,Dropdown,DropDown,Button,DropdownToggle,DropDownToggle,Toggle")]
[FindByContent]
[FindSettings(OuterXPath = "following-sibling::*[1]//", TargetAllChildren = true)]
[InvokeMethod(nameof(OnBeforeAccessChild), TriggerEvents.BeforeAccess, TargetChildren = true, ExcludeTargetName = nameof(DropdownMenu))]
public class BSDropdownToggle<TOwner> : Control<TOwner>
    where TOwner : PageObject<TOwner>
{
    [FindByClass(BSClass.DropdownMenu, OuterXPath = "following-sibling::", Visibility = Visibility.Any)]
    [TraceLog]
    protected Control<TOwner> DropdownMenu { get; private set; } = null!;

    protected void OnBeforeAccessChild()
    {
        if (!DropdownMenu.IsVisible)
            Click();
    }

    protected override bool GetIsEnabled() =>
        base.GetIsEnabled() && !DomClasses.Value.Contains(BSClass.Disabled);
}
