namespace Atata.Bootstrap;

/// <summary>
/// Represents Bootstrap dropdown control (element with "dropdown" class).
/// Default search is performed by the first child content (content of element with "dropdown-toggle" class).
/// </summary>
/// <typeparam name="TOwner">The type of the owner page object.</typeparam>
[ControlDefinition(ContainingClass = BSClass.Dropdown, ComponentTypeName = "dropdown", IgnoreNameEndings = "DropdownButton,DropDownButton,Dropdown,DropDown,Button")]
[FindByChildContent]
[InvokeMethod(nameof(OnBeforeAccessChild), TriggerEvents.BeforeAccess, TargetChildren = true, ExcludeTargetNames = [nameof(Toggle), nameof(DropdownMenu)])]
public class BSDropdown<TOwner> : Control<TOwner>
    where TOwner : PageObject<TOwner>
{
    [FindFirst]
    [TraceLog]
    protected BSDropdownToggle<TOwner> Toggle { get; private set; }

    [FindByClass(BSClass.DropdownMenu, Visibility = Visibility.Any)]
    [TraceLog]
    protected Control<TOwner> DropdownMenu { get; private set; }

    protected void OnBeforeAccessChild()
    {
        if (!DropdownMenu.IsVisible)
            Click();
    }

    protected override bool GetIsEnabled() =>
        Toggle.IsEnabled;

    protected override void OnClick() =>
        Toggle.Click();

    protected override void OnDoubleClick() =>
        Toggle.DoubleClick();

    protected override void OnRightClick() =>
        Toggle.RightClick();

    protected override void OnHover() =>
        Toggle.Hover();
}
