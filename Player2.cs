using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PlatformerGame
{
    class Player2
    {
        Sprite Sprite = new Sprite();

        KeyboardState State;

        float Speed = 5;

        public Player2()
        {

        }

        public void Load(ContentManager Content)
        {
            Sprite.Load(Content, "hero2");
        }

        public void Update(float DeltaTime)
        {
            State = Keyboard.GetState();

            if (State.IsKeyDown(Keys.D))
                Sprite.Position.X += Speed;

            if (State.IsKeyDown(Keys.A))
                Sprite.Position.X -= Speed;

            if (State.IsKeyDown(Keys.S))
                Sprite.Position.Y += Speed;

            if (State.IsKeyDown(Keys.W))
                Sprite.Position.Y -= Speed;

            Sprite.Update(DeltaTime);
        }

        public void Draw(SpriteBatch Spritebatch)
        {
            Sprite.Draw(Spritebatch);
        }
    }
}
