#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using TankVsTank.GameFrameWork;

#endregion

namespace TankVsTank
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : GameHost
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Tank _tank;
        private SpriteBatch _spriteBatch;
        private Texture2D _tankTexture;
        private SpriteFont _font;

        public Game1()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
                _spriteBatch = new SpriteBatch(GraphicsDevice); 
                _tankTexture = Content.Load<Texture2D>("car.png"); 
                _tank = new Tank(this, new Vector2(100,100), _tankTexture);
                GameObjects.Add(_tank);

                // add text to my game
                _font = Content.Load<SpriteFont>("Stencil");
                TextObject font = new TextObject(this, _font, new Vector2(200,200), "Tank Vs Tank");
                GameObjects.Add(font);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Up)) _tank.PositionY--;

            if (Keyboard.GetState().IsKeyDown(Keys.Down)) _tank.PositionY++;

            if (Keyboard.GetState().IsKeyDown(Keys.Left)) _tank.PositionX--;

            if (Keyboard.GetState().IsKeyDown(Keys.Right)) _tank.PositionX++;
            

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            foreach (SpriteObject gameObject in GameObjects)
            {
                gameObject.Draw(gameTime, _spriteBatch);
            }
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
