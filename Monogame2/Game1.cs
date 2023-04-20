using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D circleTexture;
        Texture2D squareTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);


            // TODO: use this.Content to load your game content here
            circleTexture = Content.Load<Texture2D>("circle");
            squareTexture = Content.Load<Texture2D>("rectangle");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.MistyRose);
            _spriteBatch.Begin();
            _spriteBatch.Draw(squareTexture, new Rectangle(300, 80, 200, 300), Color.DimGray);
            _spriteBatch.Draw(squareTexture, new Rectangle(300, 380, 40, 50), Color.SlateGray);
            _spriteBatch.Draw(squareTexture, new Rectangle(460,380,40,50), Color.SlateGray);
            _spriteBatch.Draw(squareTexture, new Rectangle(320, 90, 5, 280), Color.Black);
            _spriteBatch.Draw(squareTexture, new Rectangle(475, 90, 5, 280), Color.Black);
            _spriteBatch.Draw(squareTexture, new Rectangle(320, 90, 160, 5),Color.Black);
            _spriteBatch.Draw(squareTexture, new Rectangle(320, 365, 160, 5), Color.Black);
            _spriteBatch.Draw(circleTexture, new Rectangle(330,200,50,50), Color.DarkGray);
            _spriteBatch.Draw(squareTexture, new Rectangle(310, 220, 30, 10), Color.LightSlateGray);
            _spriteBatch.Draw(squareTexture, new Rectangle(370, 220, 30, 10), Color.LightSlateGray);
            _spriteBatch.Draw(squareTexture, new Rectangle(350, 180, 10, 30), Color.LightSlateGray);
            _spriteBatch.Draw(squareTexture, new Rectangle(350, 240, 10, 30), Color.LightSlateGray);
            _spriteBatch.End();

            // TODO: Add your drawing code here


            base.Draw(gameTime);
        }
    }
}