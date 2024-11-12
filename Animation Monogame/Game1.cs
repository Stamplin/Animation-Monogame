using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Animation_Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        //grey
       Texture2D greyTribbleTexture;
       Rectangle greyTribbleRectangle;
        Vector2 greyTribbleSpeed;
        //cream
        Texture2D creamTribbleTexture;
        Rectangle creamTribbleRectangle;
        Vector2 creamTribbleSpeed;
        //brown
        Texture2D brownTribbleTexture;
        Rectangle brownTribbleRectangle;
        Vector2 brownTribbleSpeed; 
        //orange
        Texture2D orangeTribbleTexture;
        Rectangle orangeTribbleRectangle;
        Vector2 orangeTribbleSpeed;

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
            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            //grey - defeault
            greyTribbleRectangle = new Rectangle(200, 30, 100, 100);
            greyTribbleSpeed = new Vector2(2, 2);
            //cream - horizontal
            creamTribbleRectangle = new Rectangle(600, 80, 100, 100);
            creamTribbleSpeed = new Vector2(-2, 0);
            //brown - vertical
            brownTribbleRectangle = new Rectangle(400, 200, 100, 100);
            brownTribbleSpeed = new Vector2(0, -2);
            //orange - diagonal
            orangeTribbleRectangle = new Rectangle(200, 200, 100, 100);
            orangeTribbleSpeed = new Vector2(3, -2);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            greyTribbleTexture = Content.Load<Texture2D>("tribbleGrey");
            creamTribbleTexture = Content.Load<Texture2D>("tribbleCream");
            brownTribbleTexture = Content.Load<Texture2D>("tribbleBrown");
            orangeTribbleTexture = Content.Load<Texture2D>("tribbleOrange");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //grey
            greyTribbleRectangle.X += (int)greyTribbleSpeed.X;
            if (greyTribbleRectangle.Right > window.Width || greyTribbleRectangle.Left < 0)
            {
                greyTribbleSpeed.X *= -1;
            }
            if (greyTribbleRectangle.Bottom > window.Height || greyTribbleRectangle.Top < 0)
            {
                greyTribbleSpeed.Y *= -1;
            }
            //cream
            creamTribbleRectangle.X += (int)creamTribbleSpeed.X;
            if (creamTribbleRectangle.Right > window.Width || creamTribbleRectangle.Left < 0)
            {
                creamTribbleSpeed.X *= -1;
            }
            if (creamTribbleRectangle.Bottom > window.Height || creamTribbleRectangle.Top < 0)
            {
                creamTribbleSpeed.Y *= -1;
            }
            //brown
            brownTribbleRectangle.X += (int)brownTribbleSpeed.X;
            brownTribbleRectangle.Y += (int)brownTribbleSpeed.Y;
            if (brownTribbleRectangle.Right > window.Width || brownTribbleRectangle.Left < 0)
            {
                brownTribbleSpeed.X *= -1;
            }
            if (brownTribbleRectangle.Bottom > window.Height || brownTribbleRectangle.Top < 0)
            {
                brownTribbleSpeed.Y *= -1;
            }
            //orange
            orangeTribbleRectangle.X += (int)orangeTribbleSpeed.X;
            orangeTribbleRectangle.Y += (int)orangeTribbleSpeed.Y;
            if (orangeTribbleRectangle.Right > window.Width || orangeTribbleRectangle.Left < 0)
            {
                orangeTribbleSpeed.X *= -1;
            }
            if (orangeTribbleRectangle.Bottom > window.Height || orangeTribbleRectangle.Top < 0)
            {
                orangeTribbleSpeed.Y *= -1;
            }

            greyTribbleRectangle.Y += (int)greyTribbleSpeed.Y;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();

            _spriteBatch.Draw(greyTribbleTexture, greyTribbleRectangle, Color.White);
            _spriteBatch.Draw(creamTribbleTexture, creamTribbleRectangle, Color.White);
            _spriteBatch.Draw(brownTribbleTexture, brownTribbleRectangle, Color.White);
            _spriteBatch.Draw(orangeTribbleTexture, orangeTribbleRectangle, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
