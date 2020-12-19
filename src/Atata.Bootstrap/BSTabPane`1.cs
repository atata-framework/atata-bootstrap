namespace Atata.Bootstrap
{
    [ControlDefinition("div", ContainingClass = "tab-pane", ComponentTypeName = "tab pane", Visibility = Visibility.Any)]
    [FindById]
    [ClickTabOrPill(TargetAllChildren = true)]
    public class BSTabPane<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}
