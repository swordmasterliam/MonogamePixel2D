using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGamePixel2D.Assets.Graphics;

/// <summary>
/// Utilities for dealing with texture data.
/// </summary>
public static class TextureUtils
{
    public static Texture2D GetRectangleTexture(GraphicsDevice graphics, int width, int height, Color color)
    {
        Texture2D texture = new(graphics, width, height);

        int size = width * height;
        Color[] data = new Color[size];
        for (int i = 0; i < size; i++)
        {
            data[i] = color;
        }
        
        texture.SetData(data);
        return texture;
    }
    /// <summary>
    /// Takes a section <c>sourceRectangle</c> of the <c>originalRectangle</c> and
    /// returns that section as a rectangle.
    /// </summary>
    /// <param name="originalRectangle">The original rectangle to take a section from. Should be larger than <c>sourceRectangle</c>.</param>
    /// <param name="sourceRectangle">The rectangle section to take from <c>originalRectangle</c>. Should be smaller than <c>originalRectangle</c>.</param>
    /// <returns></returns>
    public static Rectangle GetClampedSourceRectangle(Rectangle originalRectangle, Rectangle sourceRectangle)
    {
        var x = Math.Clamp(originalRectangle.X + sourceRectangle.X, originalRectangle.Left, originalRectangle.Right);
        var y = Math.Clamp(originalRectangle.Y + sourceRectangle.Y, originalRectangle.Top, originalRectangle.Bottom);
        var width = Math.Clamp(sourceRectangle.Width, 0, originalRectangle.Width);
        var height = Math.Clamp(sourceRectangle.Height, 0, originalRectangle.Height);

        return new Rectangle(x, y, width, height);
    }

    /// <summary>
    /// Takes the <b>XY</b> position of a pixel on an image and returns its index that it would be found at on a 
    /// 1D array, such as one ued in <c>SetData</c>.
    /// </summary>
    /// <param name="x">X coordinate of the pixel.</param>
    /// <param name="y">Y coordinate of the pixel.</param>
    /// <param name="width">Width of the image.</param>
    /// <returns></returns>
    public static int PosToIndex(int x, int y, int width) => x + y * width;

    /// <summary>
    /// Takes the <c>Point</c> position of a pixel on an image and returns its index that it would be found at on a 
    /// 1D array, such as one ued in <c>SetData</c>.
    /// </summary>
    /// <param name="pos"><c>Point</c> position of the pixel.</param>
    /// <param name="width">Width of the image.</param>
    /// <returns></returns>
    public static int PosToIndex(Point pos, int width) => pos.X + pos.Y * width;
}