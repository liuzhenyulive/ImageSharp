// // Copyright (c) Six Labors and contributors.
// // Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;

using Xunit;

namespace SixLabors.ImageSharp.Tests
{
    public partial class ColorTests
    {
        public class CastTo
        {
            [Fact]
            public void Rgba64()
            {
                Rgba64 source = new Rgba64(100, 2222, 3333, 4444);
                
                // Act:
                Color color = new Color(source);

                // Assert:
                Rgba64 data = color;
                Assert.Equal(source, data);
            }
            
            [Fact]
            public void Rgba32()
            {
                Rgba32 source = new Rgba32(1, 22, 33, 231);
                
                // Act:
                Color color = new Color(source);

                // Assert:
                Rgba32 data = color;
                Assert.Equal(source, data);
            }
            
            [Fact]
            public void Argb32()
            {
                Argb32 source = new Argb32(1, 22, 33, 231);
                
                // Act:
                Color color = new Color(source);

                // Assert:
                Argb32 data = color;
                Assert.Equal(source, data);
            }
            
            [Fact]
            public void Bgra32()
            {
                Bgra32 source = new Bgra32(1, 22, 33, 231);
                
                // Act:
                Color color = new Color(source);

                // Assert:
                Bgra32 data = color;
                Assert.Equal(source, data);
            }
            
            [Fact]
            public void Rgb24()
            {
                Rgb24 source = new Rgb24(1, 22,  231);
                
                // Act:
                Color color = new Color(source);

                // Assert:
                Rgb24 data = color;
                Assert.Equal(source, data);
            }
            
            [Fact]
            public void Bgr24()
            {
                Bgr24 source = new Bgr24(1, 22,  231);
                
                // Act:
                Color color = new Color(source);

                // Assert:
                Bgr24 data = color;
                Assert.Equal(source, data);
            }
        }
    }
}