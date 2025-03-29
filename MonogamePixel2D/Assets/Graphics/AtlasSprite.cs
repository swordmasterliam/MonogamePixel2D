using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGamePixel2D.Assets.Graphics;

public class AtlasSprite : IComplexDrawable
{
    public string fileName { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int x { get; set; }
    public int y { get; set; }

    public Texture2D Texture { get; set; }

    private Rectangle atlasSourceRectangle;

    /// <summary>
    /// Checks if the atlasSourceRectangle is empty. If it is, sets it with x, y, width, height.
    /// </summary>
    private void CheckAndFillSourceRectangle()
    {
        if (atlasSourceRectangle.IsEmpty) atlasSourceRectangle = new Rectangle(x, y, width, height);
    }

    public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle, Color color)
    {
        CheckAndFillSourceRectangle();
        spriteBatch.Draw(Texture, destinationRectangle, atlasSourceRectangle, color);
    }

    public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color)
    {
        CheckAndFillSourceRectangle();
        if (!sourceRectangle.HasValue)
        {
            spriteBatch.Draw(Texture, destinationRectangle, atlasSourceRectangle, color);
            return;
        }

        Rectangle srcRectangle = TextureUtils.GetClampedSourceRectangle(atlasSourceRectangle, sourceRectangle.GetValueOrDefault());
        spriteBatch.Draw(Texture, destinationRectangle, srcRectangle, color);
    }

    public void Draw(SpriteBatch spriteBatch, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color,
        float rotation, Point origin, SpriteEffects effects, float layerDepth)
    {
        CheckAndFillSourceRectangle();
        if (!sourceRectangle.HasValue)
        {
            spriteBatch.Draw(Texture, destinationRectangle, atlasSourceRectangle, color, rotation, origin.ToVector2(), effects, layerDepth);
            return;
        }

        Rectangle srcRectangle = TextureUtils.GetClampedSourceRectangle(atlasSourceRectangle, sourceRectangle.GetValueOrDefault());
        spriteBatch.Draw(Texture, destinationRectangle, srcRectangle, color, rotation, origin.ToVector2(), effects, layerDepth);
    }

    public void Draw(SpriteBatch spriteBatch, Point position, Color color)
    {
        CheckAndFillSourceRectangle();
        spriteBatch.Draw(Texture, position.ToVector2(), atlasSourceRectangle, color);
    }

    public void Draw(SpriteBatch spriteBatch, Point position, Rectangle? sourceRectangle, Color color)
    {
        CheckAndFillSourceRectangle();
        if (!sourceRectangle.HasValue)
        {
            spriteBatch.Draw(Texture, position.ToVector2(), atlasSourceRectangle, color);
            return;
        }

        Rectangle srcRectangle = TextureUtils.GetClampedSourceRectangle(atlasSourceRectangle, sourceRectangle.GetValueOrDefault());
        spriteBatch.Draw(Texture, position.ToVector2(), srcRectangle, color);
    }

    public void Draw(SpriteBatch spriteBatch, Point position, Rectangle? sourceRectangle, Color color,
        float rotation, Point origin, Vector2 scale, SpriteEffects effects, float layerDepth)
    {
        CheckAndFillSourceRectangle();
        if (!sourceRectangle.HasValue)
        {
            spriteBatch.Draw(Texture, position.ToVector2(), atlasSourceRectangle, color, rotation, origin.ToVector2(), scale, effects, layerDepth);
            return;
        }

        Rectangle srcRectangle = TextureUtils.GetClampedSourceRectangle(atlasSourceRectangle, sourceRectangle.GetValueOrDefault());
        spriteBatch.Draw(Texture, position.ToVector2(), srcRectangle, color, rotation, origin.ToVector2(), scale, effects, layerDepth);
    }

    public void Draw(SpriteBatch spriteBatch, Point position, Rectangle? sourceRectangle, Color color,
        float rotation, Point origin, float scale, SpriteEffects effects, float layerDepth)
    {
        CheckAndFillSourceRectangle();
        if (!sourceRectangle.HasValue)
        {
            spriteBatch.Draw(Texture, position.ToVector2(), atlasSourceRectangle, color, rotation, origin.ToVector2(), scale, effects, layerDepth);
            return;
        }

        Rectangle srcRectangle = TextureUtils.GetClampedSourceRectangle(atlasSourceRectangle, sourceRectangle.GetValueOrDefault());
        spriteBatch.Draw(Texture, position.ToVector2(), srcRectangle, color, rotation, origin.ToVector2(), scale, effects, layerDepth);
    }

    public void GetData(Color[] data)
    {
        var size = atlasSourceRectangle.Width * atlasSourceRectangle.Height;
        Texture.GetData(0, atlasSourceRectangle, data, 0, size);
    }
}