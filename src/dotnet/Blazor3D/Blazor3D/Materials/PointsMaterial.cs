using HomagGroup.Blazor3D.Textures;

namespace HomagGroup.Blazor3D.Materials
{
    /// <summary>
    /// <para>The default material used by <see cref="Objects.Points"/>.</para>
    /// <para>This class inherits from <see cref="Material"/></para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/materials/PointsMaterial">PointsMaterial</a></para>
    /// <para>The documentation comments for this class have been copied from <a target="_blank" href="https://threejs.org/docs/index.html#api/en/materials/PointsMaterial">threejs.org</a>.</para>
    /// </summary>
    /// <inheritdoc><see cref="Material"/></inheritdoc>
    public sealed class PointsMaterial : Material
    {
        public PointsMaterial() : base("PointsMaterial")
        { }

        /// <summary>
        /// Sets the color of the points using data from a Texture. May optionally include an alpha channel, typically combined with Transparent (todo) or AlphaTest(todo).
        /// Default is null. The texture map color is modulated by the diffuse Color.
        /// </summary>
        public Texture Map { get; set; } = null!;

        /// <summary>
        /// The alpha map is a grayscale texture that controls the opacity across the surface (black: fully transparent; white: fully opaque). Default is null.
        /// 
        /// Only the color of the texture is used, ignoring the alpha channel if one exists.For RGB and RGBA textures, the
        /// <a target="_blank" href="https://threejs.org/docs/index.html#api/en/renderers/WebGLRenderer">WebGL renderer</a> will use the green channel
        /// when sampling this texture due to the extra bit of precision provided for green in DXT-compressed and uncompressed RGB 565 formats.
        /// Luminance-only and luminance/alpha textures will also still work as expected.
        /// </summary>
        public Texture AlphaMap { get; set; } = null!;

        /// <summary>
        /// Whether the material is affected by fog. Default is true.
        /// </summary>
        public bool Fog { get; set; } = true;

        /// <summary>
        /// Defines the size of the points in pixels. Default is 1.0.
        /// Will be capped if it exceeds the hardware dependent parameter <a target="_blank" href="https://developer.mozilla.org/en-US/docs/Web/API/WebGLRenderingContext/getParameter">gl.ALIASED_POINT_SIZE_RANGE</a>.
        /// </summary>
        public double Size { get; set; } = 1.0;

        /// <summary>
        /// Specify whether points' size is attenuated by the camera depth. (Perspective camera only.) Default is true.
        /// </summary>
        public bool SizeAttenuation { get; set; } = true;
    }
}
