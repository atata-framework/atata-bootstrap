namespace Atata.Bootstrap
{
    [ControlDefinition("div", ContainingClass = "tab-pane", ComponentTypeName = "pill pane", Visibility = Visibility.Any)]
    [ControlFinding(FindTermBy.Id)]
    [BSClickPill(AppliesTo = TriggerScope.Children)]
    public class BSPillPane<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
