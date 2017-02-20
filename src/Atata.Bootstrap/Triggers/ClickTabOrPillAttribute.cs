using System;
using System.Linq;
using OpenQA.Selenium;

namespace Atata.Bootstrap
{
    public class ClickTabOrPillAttribute : TriggerAttribute
    {
        public ClickTabOrPillAttribute(TriggerEvents on = TriggerEvents.BeforeAccess, TriggerPriority priority = TriggerPriority.Medium)
            : base(on, priority)
        {
        }

        protected override void Execute<TOwner>(TriggerContext<TOwner> context)
        {
            BSNavItem<TOwner> navItem = GetNavItem(context);

            if (!navItem.IsActive)
                navItem.Click();
        }

        private BSNavItem<TOwner> GetNavItem<TOwner>(TriggerContext<TOwner> context)
            where TOwner : PageObject<TOwner>
        {
            var tabPane = context.Component.GetAncestorOrSelf<BSTabPane<TOwner>>() as IUIComponent<TOwner>;
            if (tabPane == null)
                throw new InvalidOperationException($"Cannot find '{nameof(BSTabPane<TOwner>)}' ancestor.");

            string navItemName = tabPane.ComponentName;

            BSNavItem<TOwner> navItem = tabPane.Parent.Controls.
                OfType<IUIComponent<TOwner>>().
                FirstOrDefault(x => x.ComponentName == navItemName && (x is BSPill<TOwner> || x is BSTab<TOwner>))
                as BSNavItem<TOwner>;

            if (navItem == null)
            {
                string tabPillInnerXPath = $".//a[@href='#{tabPane.Attributes.Id.Value}']";
                string pillXPath = UIComponentResolver.GetControlDefinition(typeof(BSPill<TOwner>)).ScopeXPath;

                bool isUsingPill = tabPane.Parent.Scope.Exists(By.XPath($".//{pillXPath}[{tabPillInnerXPath}]").SafelyAtOnce());

                var findAttribute = new FindByInnerXPathAttribute(tabPillInnerXPath);

                navItem = isUsingPill
                    ? (BSNavItem<TOwner>)tabPane.Parent.Controls.Create<BSPill<TOwner>>(navItemName, findAttribute)
                    : tabPane.Parent.Controls.Create<BSTab<TOwner>>(navItemName, findAttribute);
            }

            return navItem;
        }
    }
}
