namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents Bootstrap dropdown control (element with "dropdown" class).
    /// Default search is performed by the first child content (content of element with "dropdown-toggle" class).
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition(ContainingClass = BSClass.Dropdown, ComponentTypeName = "dropdown", IgnoreNameEndings = "DropdownButton,DropDownButton,Dropdown,DropDown,Button")]
    [ControlFinding(FindTermBy.ChildContent)]
    [ClickParent(AppliesTo = TriggerScope.Children)]
    public class BSDropdown<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        [FindFirst]
        [TraceLog]
        [InvokeMethod(nameof(OnToggleInit), TriggerEvents.Init)]
        protected BSDropdownToggle<TOwner> Toggle { get; private set; }

        protected void OnToggleInit()
        {
            Toggle.Triggers.RemoveAll(x => x is ClickParentAttribute);
        }

        protected override bool GetIsEnabled()
        {
            return Toggle.IsEnabled;
        }

        protected override void OnClick()
        {
            Toggle.Click();
        }

        protected override void OnDoubleClick()
        {
            Toggle.DoubleClick();
        }

        protected override void OnRightClick()
        {
            Toggle.RightClick();
        }

        protected override void OnHover()
        {
            Toggle.Hover();
        }
    }
}
