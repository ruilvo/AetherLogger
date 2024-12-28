// This file is part of AetherLogger
// SPDX-FileCopyrightText: 2024 Rui Oliveira <ruimail24@gmail.com>
// SPDX-License-Identifier: Apache-2.0

using CommunityToolkit.Mvvm.ComponentModel;

namespace AetherLogger.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
