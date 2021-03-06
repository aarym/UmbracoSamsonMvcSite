﻿namespace Samson.Model.DocumentTypes.Interfaces
{
    public interface IPage : IItem
    {
        string PageTitle { get; set; }

        string MainContent { get; set; }

        string NavigationTitle { get; set; }

        string NavigationClass { get; set; }

        bool ShowInNavigation { get; set; }

        bool HideFromParentListing { get; set; }
    }
}