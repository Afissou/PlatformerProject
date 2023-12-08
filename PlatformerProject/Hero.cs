using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using PlatformerProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlatformerProject.Animation;

namespace PlatformerProject
{
    public class Hero : IGameObject
    {
        Texture2D heroTexture;
        Animatie animatie;

        public Hero(Texture2D texture)
        {
            heroTexture = texture;
            animatie = new Animatie();
            animatie.AddFrame(new AnimationFrame(new Rectangle(0, 32, 32, 32)));
            animatie.AddFrame(new AnimationFrame(new Rectangle(32, 32, 32, 32)));
            animatie.AddFrame(new AnimationFrame(new Rectangle(64, 32, 32, 32)));
            animatie.AddFrame(new AnimationFrame(new Rectangle(96, 32, 32, 32)));
            animatie.AddFrame(new AnimationFrame(new Rectangle(128, 32, 32, 32)));
            animatie.AddFrame(new AnimationFrame(new Rectangle(160, 32, 32, 32)));
            animatie.AddFrame(new AnimationFrame(new Rectangle(192, 32, 32, 32)));
            animatie.AddFrame(new AnimationFrame(new Rectangle(224, 32, 32, 32)));
        }

        public void Update(GameTime gameTime)
        {
            animatie.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(heroTexture, new Vector2(0, 0), animatie.CurrentFrame.SourceRectangle, Color.White);
        }
    }
}
