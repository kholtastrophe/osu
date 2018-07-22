﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Graphics.Containers;
using osu.Game.Graphics.UserInterface;
using System;
using System.Collections.Generic;

namespace osu.Game.Tests.Visual
{
    public class TestCaseClickableText : OsuTestCase
    {
        public override IReadOnlyList<Type> RequiredTypes => new[] { typeof(ClickableText) };

        public TestCaseClickableText()
        {
            ClickableText text;

            AddRange(new[] {
                new ClickableText{ Text = "Default", },
                new ClickableText{ IsEnabled = false, Text = "Disabled", },
                new ClickableText{ Text = "Without sounds", IsMuted = true, },
                new ClickableText{ Text = "Without click sounds", IsClickMuted = true, },
                new ClickableText{ Text = "Without hover sounds", IsHoverMuted = true, },
                text = new ClickableText{ Text = "Disables after click (Action)", },
                new ClickableText{ Text = "Has tooltip", TooltipText = "Yep", }
            });
            text.Action = () => text.IsEnabled = false;
        }
    }
}
