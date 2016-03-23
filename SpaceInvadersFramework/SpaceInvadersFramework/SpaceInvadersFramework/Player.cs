using Microsoft.Xna.Framework.Input;
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

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            if (inputHelper.KeyPressed(Keys.Left))
            {
                velocity.X -= 300;   
            }

            if (inputHelper.KeyPressed(Keys.Right))
            {
                velocity.X += 300;
            }

            if (!inputHelper.KeyPressed(Keys.Left) && !inputHelper.KeyPressed(Keys.Right))
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
