namespace Atata.Bootstrap
{
    [ControlDefinition("div", ContainingClass = "tab-pane", ComponentTypeName = "tab pane", Visibility = Visibility.Any)]
    [ControlFinding(FindTermBy.Id)]
    [ClickTabOrPill(AppliesTo = TriggerScope.Self)]
    public class BSTabPane<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
