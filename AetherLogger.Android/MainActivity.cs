// This file is part of AetherLogger
// SPDX-FileCopyrightText: 2024 Rui Oliveira <ruimail24@gmail.com>
// SPDX-License-Identifier: Apache-2.0

using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;

namespace AetherLogger.Android;

[Activity(
    Label = "AetherLogger.Android",
    Theme = "@style/AetherLoggerTheme.NoActionBar",
    Icon = "@drawable/icon_400px",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.UiMode)]
public class MainActivity : AvaloniaMainActivity<App>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithInterFont();
    }
}
