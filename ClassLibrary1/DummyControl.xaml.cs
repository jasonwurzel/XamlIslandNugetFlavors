﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ReactiveUI;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ClassLibrary1
{
    public sealed partial class DummyControl : UserControl
    {
        public DummyControl()
        {
            this.InitializeComponent();

            Observable.Interval(TimeSpan.FromSeconds(1)).ObserveOnDispatcher().BindTo(this, v => v.TheTextBlock.Text);
        }
    }
}
