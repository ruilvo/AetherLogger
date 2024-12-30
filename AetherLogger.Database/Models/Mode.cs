// This file is part of AetherLogger
// SPDX-FileCopyrightText: 2024 Rui Oliveira <ruimail24@gmail.com>
// SPDX-License-Identifier: Apache-2.0

using System.Linq;

namespace AetherLogger.Database.Models;

public class Mode
{
    public required ModeEnum MainMode { get; set; }
    private IModeEnum? _submode;
    public IModeEnum? Submode
    {
        get => _submode;
        set
        {
            if (MainMode.Submodes != null && MainMode.Submodes.Contains(value))
            {
                _submode = value;
            }
            else
            {
                throw new ArgumentException("Sub-mode not valid for mode", nameof(value));
            }
        }
    }

    public IEnumerable<IModeEnum>? Submodes => MainMode.Submodes;

    public Mode(ModeEnum mainMode, IModeEnum? submode = null)
    {
        MainMode = mainMode;
        if (MainMode.Submodes != null)
        {
            if (submode == null && MainMode.Submodes.Contains(submode))
            {
                throw new ArgumentException("The sub-mode must be provided and valid when the mode has sub-modes.", nameof(submode));
            }
            _submode = submode;
        }
    }
}
