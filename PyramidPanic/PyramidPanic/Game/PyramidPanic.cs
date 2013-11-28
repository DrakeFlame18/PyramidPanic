using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
    
    public class PyramidPanic : Microsoft.Xna.Framework.Game
    {
        //fields
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public PyramidPanic()
        {
            this.graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            //dit maakt de muis zicht of onzichtbaar
            this.IsMouseVisible = true;
            
            //Verandert de titel van de gamescreen
            this.Window.Title = "Pyramid Panic";
            
            //verandert de breedte van het canvas
            this.graphics.PreferredBackBufferWidth = 640;

            //verandert de hoogste van het canvas
            this.graphics.PreferredBackBufferHeight = 480;
            
            //past de veranderingen betreffende het canvas
            this.graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
           
            this.spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
         
            if ((GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed) ||
               (Keyboard.GetState().IsKeyDown(Keys.Escape)))
                this.Exit();

           

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            base.Draw(gameTime);
        }
    }
}
