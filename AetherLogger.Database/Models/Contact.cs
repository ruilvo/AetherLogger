// This file is part of AetherLogger
// SPDX-FileCopyrightText: 2024 Rui Oliveira <ruimail24@gmail.com>
// SPDX-License-Identifier: Apache-2.0

using System.Linq;

namespace AetherLogger.Database.Models;

public class Contact
{
    public required string Callsign { get; set; }
    public required DateTime TimeOn { get; set; }

    public required Mode Mode { get; set; }

    private IMode? _submode;
    public IMode? Submode
    {
        get => _submode;
        set
        {
            if (Mode.Submodes != null && Mode.Submodes.Contains(value))
            {
                _submode = value;
            }
            else
            {
                throw new ArgumentException("Submode not valid for mode", nameof(value));
            }
        }
    }
}

