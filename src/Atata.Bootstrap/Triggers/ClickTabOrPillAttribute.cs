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

        private static BSNavItem<TOwner> GetNavItem<TOwner>(TriggerContext<TOwner> context)
            where TOwner : PageObject<TOwner>
        {
            if (!(context.Component.GetAncestorOrSelf<BSTabPane<TOwner>>() is IUIComponent<TOwner> tabPane))
                throw new InvalidOperationException($"Cannot find '{nameof(BSTabPane<TOwner>)}' ancestor.");

            string navItemName = tabPane.ComponentName;

            BSNavItem<TOwner> navItem = tabPane.Parent.Controls
                .OfType<IUIComponent<TOwner>>()
                .FirstOrDefault(x => x.ComponentName == navItemName && (x is BSPill<TOwner> || x is BSTab<TOwner>))
                as BSNavItem<TOwner>;

            if (navItem == null)
            {
                string tabPillInnerXPath = $"(self::a | child::a)[@href='#{tabPane.DomProperties.Id.Value}']";
                string pillXPath = UIComponentResolver.GetControlDefinition(typeof(BSPill<TOwner>)).ScopeXPath;

                bool isUsingPill = tabPane.Parent.ScopeContext.Exists(By.XPath($".//{pillXPath}[{tabPillInnerXPath}]").SafelyAtOnce());

                var findAttribute = new FindByInnerXPathAttribute(tabPillInnerXPath);

                navItem = isUsingPill
                    ? (BSNavItem<TOwner>)tabPane.Parent.Controls.Create<BSPill<TOwner>>(navItemName, findAttribute)
                    : tabPane.Parent.Controls.Create<BSTab<TOwner>>(navItemName, findAttribute);
            }

            return navItem;
        }
    }
}
