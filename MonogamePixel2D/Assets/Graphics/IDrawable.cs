using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGamePixel2D.Assets.Graphics;

public interface IDrawable
{
    public Texture2D Texture { get; set; }

    /// <summary>
    /// Submits the texture to the spritebatch as a sprite for drawing in the current batch.
    /// </summary>
    /// <param name="spriteBatch">The <c>SpriteBatch</c> to submit the sprite to for drawing.</param>
    /// <param name="destinationRectangle">The drawing bounds on screen.</param>   
    /// <param name="color">A color mask.</param>
    public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle, Color color);

    /// <summary>
    /// Submits the texture to the spritebatch as a sprite for drawing in the current batch.
    /// </summary>
    /// <param name="spriteBatch">The <c>SpriteBatch</c> to submit the sprite to for drawing.</param>
    /// <param name="destinationRectangle">The drawing bounds on screen.</param>
    /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
    /// <param name="color">A color mask.</param>
    public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color);

    /// <summary>
    /// Submits the texture to the spritebatch as a sprite for drawing in the current batch.
    /// </summary>
    /// <param name="spriteBatch">The <c>SpriteBatch</c> to submit the sprite to for drawing.</param>
    /// <param name="destinationRectangle">The drawing bounds on screen.</param>
    /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
    /// <param name="color">A color mask.</param>
    /// <param name="rotation">A rotation of this sprite.</param>
    /// <param name="origin">Center of the rotation. 0,0 by default.</param>
    /// <param name="effects">Modificators for drawing. Can be combined.</param>
    /// <param name="layerDepth">A depth of the layer of this sprite.</param>
    public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color,
        float rotation, Point origin, SpriteEffects effects, float layerDepth);

    /// <summary>
    /// Submits the texture to the spritebatch as a sprite for drawing in the current batch.
    /// </summary>
    /// <param name="spriteBatch">The <c>SpriteBatch</c> to submit the sprite to for drawing.</param>
    /// <param name="position">The drawing location on screen.</param>
    /// <param name="color">A color mask.</param>
    public void Draw(SpriteBatch spriteBatch, Point position, Color color);

    /// <summary>
    /// Submits the texture to the spritebatch as a sprite for drawing in the current batch.
    /// </summary>
    /// <param name="spriteBatch">The <c>SpriteBatch</c> to submit the sprite to for drawing.</param>
    /// <param name="position">The drawing location on screen.</param>
    /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
    /// <param name="color">A color mask.</param>
    public void Draw(SpriteBatch spriteBatch, Point position, Rectangle? sourceRectangle, Color color);

    /// <summary>
    /// Submits the texture to the spritebatch as a sprite for drawing in the current batch.
    /// </summary>
    /// <param name="spriteBatch">The <c>SpriteBatch</c> to submit the sprite to for drawing.</param>
    /// <param name="position">The drawing location on screen.</param>
    /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
    /// <param name="color">A color mask.</param>
    /// <param name="rotation">A rotation of this sprite.</param>
    /// <param name="origin">Center of the rotation. 0,0 by default.</param>
    /// <param name="scale">A scaling of this sprite.</param>
    /// <param name="effects">Modificators for drawing. Can be combined.</param>
    /// <param name="layerDepth">A depth of the layer of this sprite.</param>
    public void Draw(SpriteBatch spriteBatch, Point position, Rectangle? sourceRectangle, Color color,
        float rotation, Point origin, Vector2 scale, SpriteEffects effects, float layerDepth);

    /// <summary>
    /// Submits the texture to the spritebatch as a sprite for drawing in the current batch.
    /// </summary>
    /// <param name="spriteBatch">The <c>SpriteBatch</c> to submit the sprite to for drawing.</param>
    /// <param name="position">The drawing location on screen.</param>
    /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
    /// <param name="color">A color mask.</param>
    /// <param name="rotation">A rotation of this sprite.</param>
    /// <param name="origin">Center of the rotation. 0,0 by default.</param>
    /// <param name="scale">A scaling of this sprite.</param>
    /// <param name="effects">Modificators for drawing. Can be combined.</param>
    /// <param name="layerDepth">A depth of the layer of this sprite.</param>
    public void Draw(SpriteBatch spriteBatch, Point position, Rectangle? sourceRectangle, Color color,
        float rotation, Point origin, float scale, SpriteEffects effects, float layerDepth);

    /// <summary>
    /// Copies texture data into an array.
    /// </summary>
    /// <param name="data">The array to recieve texture data.</param>
    public void GetData(Color[] data);
}