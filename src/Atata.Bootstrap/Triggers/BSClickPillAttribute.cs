using System;

namespace Atata.Bootstrap
{
    public class BSClickPillAttribute : TriggerAttribute
    {
        public BSClickPillAttribute(TriggerEvents on = TriggerEvents.BeforeAnyAction, TriggerPriority priority = TriggerPriority.Medium)
            : base(on, priority)
        {
        }

        protected override void Execute<TOwner>(TriggerContext<TOwner> context)
        {
            var tabPane = context.Component.GetAncestorOrSelf<BSPillPane<TOwner>>();
            if (tabPane == null)
                throw new InvalidOperationException($"Cannot find '{nameof(BSPillPane<TOwner>)}' ancestor.");

            var findAttribute = new FindByInnerXPathAttribute($".//a[@href='#{tabPane.Attributes.Id.Value}']");

            var pill = ((IUIComponent<TOwner>)tabPane).Parent.Controls.Create<BSPill<TOwner>>(context.Component.Parent.ComponentName, findAttribute);

            if (!pill.IsActive)
                pill.Click();
        }
    }
}
