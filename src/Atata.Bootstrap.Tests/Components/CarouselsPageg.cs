namespace Atata.Bootstrap.Tests
{
    using _ = CarouselsPage;

    [Url("Carousel.html")]
    public class CarouselsPage : Page<_>
    {
        public BSCarousel<_> MyCarousel { get; private set; }

        public BSCarousel<CarouselIndicator, _> CarouselIndicators { get; private set; }

        public class CarouselIndicator : Control<_>
        {
            public OrderedList<ListItem<_>, _> SlideIndicator { get; private set; }
        }
    }
}