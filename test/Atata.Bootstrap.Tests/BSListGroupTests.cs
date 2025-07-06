﻿namespace Atata.Bootstrap.Tests;

public class BSListGroupTests : UITestSuite
{
    private ListGroupPage _page = null!;

    public BSListGroupTests(string bootstrapVersionString)
        : base(bootstrapVersionString)
    {
    }

    [SetUp]
    public void SetUp() =>
        _page = Go.To<ListGroupPage>();

    [Test]
    public void BSListGroup()
    {
        _page
            .AllListGroups.Count.Should.Be(5)
            .AllListGroupItems.Count.Should.Be(21);

        var control = _page.RegularGroup;

        control.Items.Count.Should.Be(5);
        control.Items[1].DomClasses.Should.Contain("list-group-item-success");
        control.Items[3].DomClasses.Should.Contain("list-group-item-danger");
        control.Items[2].Content.Should.Be("Morbi leo risus");
    }

    [Test]
    public void BSListGroup_Badges()
    {
        var control = _page.BadgeGroup;

        control.Items.Count.Should.Be(3);
        control.Items[x => x.Number == 2].Text.Should.Contain("Dapibus ac facilisis in");
        control.Items[0].Number.Should.Be(14);
    }

    [Test]
    public void BSListGroup_Links()
    {
        var control = _page.LinkGroup;

        control.Items.Count.Should.Be(5);
        control.Items[1].IsActive.Should.BeTrue();
        control.Items[2].IsActive.Should.BeFalse();
        control.Items[2].Should.BeEnabled();
        control.Items[2].Content.Should.Be("Morbi leo risus");
        control.Items[3].Should.BeDisabled();
    }

    [Test]
    public void BSListGroup_Buttons()
    {
        var control = _page.ButtonGroup;

        control.Items.Count.Should.Be(5);
        control.Items[1].IsActive.Should.BeTrue();
        control.Items[2].IsActive.Should.BeFalse();
        control.Items[2].Should.BeEnabled();
        control.Items[2].Content.Should.Be("Morbi leo risus");
        control.Items[3].Should.BeDisabled();
        control.Items[4].DomClasses.Should.Contain("list-group-item-success");
    }

    [Test]
    public void BSListGroup_CustomContent()
    {
        var control = _page.CustomContentGroup;

        control.Items.Count.Should.Be(3);
        control.Items[x => x.Heading == "Item 2"].Text.Should.Be("Item 2 text");
        control.Items[1].IsActive.Should.BeTrue();
        control.Items[2].Heading.Should.Be("Item 3");
        control.Items[2].Text.Should.Be("Item 3 text");
    }

    [Test]
    public void BSListGroup_CustomGroup()
    {
        var control = _page.CustomGroup;

        control.Item1.Text.Should.Contain("Item 1 text");
        control.Item2.Heading.Should.Contain("Item 2");
        control.Item2.IsActive.Should.BeTrue();
        control.Item3.Heading.Should.Be("Item 3");
        control.Items[2].Text.Should.Be("Item 3 text");
    }
}
