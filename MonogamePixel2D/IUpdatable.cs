using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGamePixel2D;

public interface IUpdatable
{
    /// <summary>
    /// Updates the object based on the elapsed time between frames.
    /// </summary>
    /// <param name="gameTime">Game state and time data.</param>
    void Update(GameTime gameTime);
}