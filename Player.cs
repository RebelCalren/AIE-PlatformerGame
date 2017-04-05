using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PlatformerGame
{
    class Player
    {
        Sprite Sprite = new Sprite();
        KeyboardState State;

        float Speed = 5;

        public Player()
        {

        }

        public void Load(ContentManager Content)
        {
            Sprite.Load(Content, "hero");
        }

        public void Update(float DeltaTime)
        {
            State = Keyboard.GetState();

            if (State.IsKeyDown(Keys.Right))
                Sprite.Position.X += Speed;

            if (State.IsKeyDown(Keys.Left))
                Sprite.Position.X -= Speed;

            if (State.IsKeyDown(Keys.Down))
                Sprite.Position.Y += Speed;

            if (State.IsKeyDown(Keys.Up))
                Sprite.Position.Y -= Speed;

            Sprite.Update(DeltaTime);
        }

        public void Draw(SpriteBatch Spritebatch)
        {
            Sprite.Draw(Spritebatch);
        }

    }
}
