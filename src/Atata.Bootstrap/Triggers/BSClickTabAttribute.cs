using System;

namespace Atata.Bootstrap
{
    public class BSClickTabAttribute : TriggerAttribute
    {
        public BSClickTabAttribute(TriggerEvents on = TriggerEvents.BeforeAnyAction, TriggerPriority priority = TriggerPriority.Medium)
            : base(on, priority)
        {
        }

        protected override void Execute<TOwner>(TriggerContext<TOwner> context)
        {
            var tabPane = context.Component.GetAncestorOrSelf<BSTabPane<TOwner>>();
            if (tabPane == null)
                throw new InvalidOperationException($"Cannot find '{nameof(BSTabPane<TOwner>)}' ancestor.");

            var findAttribute = new FindByInnerXPathAttribute($".//a[@href='#{tabPane.Attributes.Id.Value}']");

            var tab = ((IUIComponent<TOwner>)tabPane).Parent.Controls.Create<BSTab<TOwner>>(context.Component.Parent.ComponentName, findAttribute);

            if (!tab.IsActive)
                tab.Click();
        }
    }
}
