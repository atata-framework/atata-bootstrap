using System.Linq;
using OpenQA.Selenium;

namespace Atata.Bootstrap
{
    [ControlDefinition("li", ComponentTypeName = "nav item")]
    public class BSNavItem<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        public DataProvider<bool, TOwner> IsActive => GetOrCreateDataProvider(
            nameof(IsActive).ToString(TermCase.MidSentence),
            () => Attributes.Class.Value.Contains(BSClass.Active));

        protected override bool GetIsEnabled()
        {
            // In 3rd version of Bootstrap 'disabled' class applies to the <li> element, but in 4th - to the <a>.
            IWebElement scope = Scope;
            return !scope.HasClass(BSClass.Disabled) && !(scope.Get(By.TagName("a").SafelyAtOnce())?.HasClass(BSClass.Disabled) ?? false);
        }
    }
}
