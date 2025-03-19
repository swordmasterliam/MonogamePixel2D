using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGamePixel2D.Assets.Graphics;

public class ImageSprite(Texture2D texture) : IDrawable
{
    public Texture2D Texture { get; set; } = texture;

    public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle, Color color)
    {
        spriteBatch.Draw(Texture, destinationRectangle, color);
    }

    public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color)
    {
        spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, color);
    }

    public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color,
        float rotation, Point origin, SpriteEffects effects, float layerDepth)
    {
        spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, color, rotation, origin.ToVector2(), effects, layerDepth);
    }

    public void Draw(SpriteBatch spriteBatch, Point position, Color color)
    {
        spriteBatch.Draw(Texture, position.ToVector2(), color);
    }

    public void Draw(SpriteBatch spriteBatch, Point position, Rectangle? sourceRectangle, Color color)
    {
        spriteBatch.Draw(Texture, position.ToVector2(), sourceRectangle, color);
    }

    public void Draw(SpriteBatch spriteBatch, Point position, Rectangle? sourceRectangle, Color color,
        float rotation, Point origin, Vector2 scale, SpriteEffects effects, float layerDepth)
    {
        spriteBatch.Draw(Texture, position.ToVector2(), sourceRectangle, color, rotation,
            origin.ToVector2(), scale, effects, layerDepth);
    }

    public void Draw(SpriteBatch spriteBatch, Point position, Rectangle? sourceRectangle, Color color,
        float rotation, Point origin, float scale, SpriteEffects effects, float layerDepth)
    {
        spriteBatch.Draw(Texture, position.ToVector2(), sourceRectangle, color, rotation,
            origin.ToVector2(), scale, effects, layerDepth);
    }

    public void GetData(Color[] data)
    {
        Texture.GetData(data);
    }
}