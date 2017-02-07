namespace Atata.Bootstrap
{
    [ControlDefinition(ContainingClass = "dropdown", ComponentTypeName = "dropdown", IgnoreNameEndings = "DropdownButton,DropDownButton,Dropdown,DropDown,Button")]
    [ControlFinding(FindTermBy.ChildContent)]
    [ClickParent(AppliesTo = TriggerScope.Children)]
    public class BSDropdown<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
