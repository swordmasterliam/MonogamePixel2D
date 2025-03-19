using System.Text.Json.Serialization;
using Microsoft.Xna.Framework;

namespace MonoGamePixel2D.Assets.Graphics.Animations;

public class Frame
{
    [JsonConverter(typeof(RectangleConverter))]
    public Rectangle SourceRectangle { get; init; }

    public int Duration { get; set; }
}