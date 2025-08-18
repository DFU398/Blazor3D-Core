using HomagGroup.Blazor3D.Core;
using HomagGroup.Blazor3D.Geometires;
using HomagGroup.Blazor3D.Materials;

namespace HomagGroup.Blazor3D.Objects
{
    /// <summary>
    /// <para>A class for displaying points. The points are rendered by the
    /// <a target="_blank" href="https://threejs.org/docs/index.html#api/en/renderers/WebGLRenderer">WebGLRenderer</a> using
    /// <a target="_blank" href="https://developer.mozilla.org/en-US/docs/Web/API/WebGLRenderingContext/drawElements">gl.POINTS</a>.
    /// </para>
    /// <para>This object inherits from <see cref="Object3D"/></para>
    /// <para>Wrapper for three.js <a target="_blank" href="https://threejs.org/docs/index.html#api/en/objects/Points">Points</a></para>
    /// <para>The documentation comments for this class have been copied from <a target="_blank" href="https://threejs.org/docs/index.html#api/en/objects/Points">threejs.org</a>.</para>
    /// </summary>
    /// <inheritdoc><see cref="Object3D"/></inheritdoc>
    public class Points : Object3D
    {
        public Points() : base("Points")
        { }

        protected Points(string type) : base(type)
        { }

        /// <summary>
        /// <para>An instance of <see cref="Materials.Material"/>, defining the object's appearance. Default is a <see cref="PointsMaterial"/>.</para>
        /// </summary>
        public Material Material { get; set; } = new PointsMaterial();

        /// <summary>
        /// <para>An instance of <see cref="BufferGeometry"/> (or derived classes), defining the object's structure.</para>
        /// </summary>
        public BufferGeometry Geometry { get; set; } = new PointsGeometry();
    }
}
