using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atata.Bootstrap
{
    /// <summary>
    /// Represents the carousel slide control(Bootstrap class="carousel slide"). Default search finds the first occuring class="carousel slide" element.
    /// </summary>
    /// <typeparam name="TOwner">The type of the owner page object.</typeparam>
    [ControlDefinition("div[@class='carousel slide']", ComponentTypeName = "carousel slide")]
    public class BSCarousel<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
    }
}