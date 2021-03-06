﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;
using osuTK;

namespace osu.Game.Rulesets.Tau.Replays
{
    public class TauReplayFrame : ReplayFrame
    {
        public List<TauAction> Actions = new List<TauAction>();
        public Vector2 Position;

        public TauReplayFrame(TauAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
