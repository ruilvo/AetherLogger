// This file is part of AetherLogger
// SPDX-FileCopyrightText: 2024 Rui Oliveira <ruimail24@gmail.com>
// SPDX-License-Identifier: Apache-2.0

namespace AetherLogger.Database.Models;

public class Contact
{
    public required string Callsign { get; set; }
    public required DateTime TimeOn { get; set; }
    public required Mode Mode { get; set; }
}

