﻿// This file is part of AetherLogger
// SPDX-FileCopyrightText: 2024 Rui Oliveira <ruimail24@gmail.com>
// SPDX-License-Identifier: Apache-2.0

namespace AetherLogger.Common;

public interface ISmartEnum : Ardalis.SmartEnum.ISmartEnum
{
    // Ardalis.SmartEnum.ISmartEnum is defined empty,
    // but it should have a Name and Value property.
    string Name { get; }
    int Value { get; }
}
