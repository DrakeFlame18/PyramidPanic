using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace PyramidPanic.GameScenes.StartScene
{
    class StartScene
    {
        //Fields
        private PyramidPanic game;


        //Constructor
        public StartScene(PyramidPanic game)
        {
            this.game = game;
            this.initialize();
        }


        //Initialize
        public void initialize()
        {
            this.LoadContent();

        }

        //LoadContent
        public void LoadContent()
        {
            
        }

        //Update
        public void Update()
        { 
        
        }

        //Draw
        public void Draw()
        {
        
        }

    }
}
