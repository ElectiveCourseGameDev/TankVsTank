using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TankVsTank.GameFrameWork;

namespace TankVsTank
{
    class Tank : SpriteObject
    {
        public Tank(GameHost game)
            : base(game)
        {
            // Set the default scale and color
            ScaleX = 1;
            ScaleY = 1;
            SpriteColor = Color.White;
        }

        public Tank(GameHost game, Vector2 position)
            : this(game)
        {
            // Store the provided position
            Position = position;
        }


       public Tank(GameHost game, Vector2 position, Texture2D texture)
            : this(game, position)
        {
            // Store the provided texture
            SpriteTexture = texture;
        }
       
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        
    }
}
