﻿using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpaceInvadersFramework
{
    class Player : SpriteGameObject
    {
        public Player() : base("ship", 0, "", 0)
        {
            position = new Vector2(GameEnvironment.Screen.X/2, GameEnvironment.Screen.Y-Height);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.IsKeyDown(Keys.Left))
            {
                velocity.X -= 30;   
            }

            if (inputHelper.IsKeyDown(Keys.Right))
            {
                velocity.X += 30;
            }

            if (!inputHelper.IsKeyDown(Keys.Left) && !inputHelper.IsKeyDown(Keys.Right))
            {
                velocity.X = 0;
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (position.X > GameEnvironment.Screen.X - Width)
            {
                velocity.X = 0;
                position.X = GameEnvironment.Screen.X - Width;
            }

            if (position.X < 0)
            {
                velocity.X = 0;
                position.X = 0;
            }
        }
    }
}
