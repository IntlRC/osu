// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Game.Tournament.Components;
using osu.Game.Tournament.Models;
using osuTK;

namespace osu.Game.Tournament.Screens.TeamIntro
{
    public class TeamIntroScreen : TournamentMatchScreen
    {
        private Container mainContainer;

        [BackgroundDependencyLoader]
        private void load()
        {
            RelativeSizeAxes = Axes.Both;

            InternalChildren = new Drawable[]
            {
                new TourneyVideo("teamintro")
                {
                    RelativeSizeAxes = Axes.Both,
                    Loop = true,
                },
                mainContainer = new Container
                {
                    RelativeSizeAxes = Axes.Both,
                }
            };
        }

        protected override void CurrentMatchChanged(ValueChangedEvent<TournamentMatch> match)
        {
            base.CurrentMatchChanged(match);

            mainContainer.Clear();

            if (match.NewValue == null)
                return;

            const float y_flag_offset1 = 300;

            const float y_offset1 = 360;

            const float y_flag_offset2 = 500;

            const float y_offset2 = 560;

            mainContainer.Children = new Drawable[]
            {
                new RoundDisplay(match.NewValue)
                {
                    Position = new Vector2(100, 100)
                },

                new DrawableTeamFlag(match.NewValue.Team1.Value)
                {
                    Position = new Vector2(100, y_flag_offset1),
                },
                new DrawableTeamWithPlayers(match.NewValue.Team1.Value, TeamColour.Red)
                {
                    Position = new Vector2(100, y_offset1),
                },
                new DrawableTeamFlag(match.NewValue.Team2.Value)
                {
                    Position = new Vector2(387, y_flag_offset2),
                },
                new DrawableTeamWithPlayers(match.NewValue.Team2.Value, TeamColour.Blue)
                {
                    Position = new Vector2(387, y_offset2),
                },

                new DrawableTeamFlag(match.NewValue.Team3.Value)
                {
                    Position = new Vector2(675, y_flag_offset1),
                },
                new DrawableTeamWithPlayers(match.NewValue.Team3.Value, TeamColour.Blue)
                {
                    Position = new Vector2(675, y_offset1),
                },
                new DrawableTeamFlag(match.NewValue.Team4.Value)
                {
                    Position = new Vector2(962, y_flag_offset2),
                },
                new DrawableTeamWithPlayers(match.NewValue.Team4.Value, TeamColour.Blue)
                {
                    Position = new Vector2(962, y_offset2),
                },
            };
        }
    }
}
