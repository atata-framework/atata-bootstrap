using NUnit.Framework;

namespace Atata.Bootstrap.Tests
{
    public class BSListGroupTests : UITestFixture
    {
        private ListGroupPage page;

        public override void SetUp()
        {
            base.SetUp();

            page = Go.To<ListGroupPage>();
        }

        [Test]
        public void BSListGroup()
        {
            page.
                AllListGroups.Count.Should.Equal(5).
                AllListGroupItems.Count.Should.Equal(21);

            var control = page.RegularGroup;

            control.Items.Count.Should.Equal(5);
            control.Items[1].Attributes.Class.Should.Contain("list-group-item-success");
            control.Items[3].Attributes.Class.Should.Contain("list-group-item-danger");
            control.Items[2].Content.Should.Equal("Morbi leo risus");
        }

        [Test]
        public void BSListGroup_Badges()
        {
            var control = page.BadgeGroup;

            control.Items.Count.Should.Equal(3);
            control.Items[x => x.Number == 2].Text.Should.Contain("Dapibus ac facilisis in");
            control.Items[0].Number.Should.Equal(14);
        }

        [Test]
        public void BSListGroup_Links()
        {
            var control = page.LinkGroup;

            control.Items.Count.Should.Equal(5);
            control.Items[1].IsActive.Should.BeTrue();
            control.Items[2].IsActive.Should.BeFalse();
            control.Items[2].Should.BeEnabled();
            control.Items[2].Content.Should.Equal("Morbi leo risus");
            control.Items[3].Should.BeDisabled();
        }

        [Test]
        public void BSListGroup_Buttons()
        {
            var control = page.ButtonGroup;

            control.Items.Count.Should.Equal(5);
            control.Items[1].IsActive.Should.BeTrue();
            control.Items[2].IsActive.Should.BeFalse();
            control.Items[2].Should.BeEnabled();
            control.Items[2].Content.Should.Equal("Morbi leo risus");
            control.Items[3].Should.BeDisabled();
            control.Items[4].Attributes.Class.Should.Contain("list-group-item-success");
        }

        [Test]
        public void BSListGroup_CustomContent()
        {
            var control = page.CustomContentGroup;

            control.Items.Count.Should.Equal(3);
            control.Items[x => x.Heading == "Item 2"].Text.Should.Equal("Item 2 text");
            control.Items[1].IsActive.Should.BeTrue();
            control.Items[2].Heading.Should.Equal("Item 3");
            control.Items[2].Text.Should.Equal("Item 3 text");
        }

        [Test]
        public void BSListGroup_CustomGroup()
        {
            var control = page.CustomGroup;

            control.Item1.Text.Should.Contain("Item 1 text");
            control.Item2.Heading.Should.Contain("Item 2");
            control.Item2.IsActive.Should.BeTrue();
            control.Item3.Heading.Should.Equal("Item 3");
            control.Items[2].Text.Should.Equal("Item 3 text");
        }
    }
}
