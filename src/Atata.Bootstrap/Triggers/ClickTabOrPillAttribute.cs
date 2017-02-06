using System;
using OpenQA.Selenium;

namespace Atata.Bootstrap
{
    public class ClickTabOrPillAttribute : TriggerAttribute
    {
        private bool isInitialized;
        private UIComponent navItemComponent;

        public ClickTabOrPillAttribute(TriggerEvents on = TriggerEvents.BeforeAccess, TriggerPriority priority = TriggerPriority.Medium)
            : base(on, priority)
        {
        }

        private void Init<TOwner>(TriggerContext<TOwner> context)
            where TOwner : PageObject<TOwner>
        {
            var tabPane = context.Component.GetAncestorOrSelf<BSTabPane<TOwner>>() as IUIComponent<TOwner>;
            if (tabPane == null)
                throw new InvalidOperationException($"Cannot find '{nameof(BSTabPane<TOwner>)}' ancestor.");

            string tabPillInnerXPath = $".//a[@href='#{tabPane.Attributes.Id.Value}']";
            string pillXPath = UIComponentResolver.GetControlDefinition(typeof(BSPill<TOwner>)).ScopeXPath;

            bool isUsingPill = tabPane.Parent.Scope.Exists(By.XPath($"{pillXPath}[{tabPillInnerXPath}]").SafelyAtOnce());

            var findAttribute = new FindByInnerXPathAttribute(tabPillInnerXPath);

            navItemComponent = isUsingPill
                ? (UIComponent)tabPane.Parent.Controls.Create<BSPill<TOwner>>(context.Component.Parent.ComponentName, findAttribute)
                : tabPane.Parent.Controls.Create<BSTab<TOwner>>(context.Component.Parent.ComponentName, findAttribute);

            isInitialized = true;
        }

        protected override void Execute<TOwner>(TriggerContext<TOwner> context)
        {
            if (!isInitialized)
                Init(context);

            BSNavItem<TOwner> navItem = (BSNavItem<TOwner>)navItemComponent;

            if (!navItem.IsActive)
                navItem.Click();
        }
    }
}
