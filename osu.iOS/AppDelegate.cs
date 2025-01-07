// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using Foundation;
using osu.Framework.iOS;

namespace osu.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : GameApplicationDelegate
    {
        protected override Framework.Game CreateGame() => new OsuGameIOS();
    }
}