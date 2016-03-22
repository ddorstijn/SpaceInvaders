using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceInvadersFramework
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class SpaceInvaders : GameEnvironment
    {
        public SpaceInvaders()
        {
            Content.RootDirectory = "Content";
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            screen = new Point(800, 600);
            this.SetFullScreen(false);

            // TODO: add gamestate to GameStateManager here
            gameStateManager.AddGameState("playingState", new PlayingState());
            gameStateManager.SwitchTo("playingState");

        }
    }
}
