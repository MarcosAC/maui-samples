﻿using MauiSamples.Views;
using MauiSamples.Views.Accordion;

namespace MauiSamples;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(MultiBindingPage), typeof(MultiBindingPage));
        Routing.RegisterRoute(nameof(PassObjectsPage), typeof(PassObjectsPage));
        Routing.RegisterRoute(nameof(AccordionOnePage), typeof(AccordionOnePage));
        Routing.RegisterRoute(nameof(AccordionMvvmPage), typeof(AccordionMvvmPage));
    }
}
