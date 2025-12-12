using HomagGroup.Blazor3D.Core;
using HomagGroup.Blazor3D.Maths;

namespace HomagGroup.Blazor3D.Geometires
{
    /// <summary>
    /// <para>Geometry for a mesh from multiple triangles.</para>
    /// <para>This class inherits from <see cref="BufferGeometry"/></para>
    /// </summary>
    /// <inheritdoc><see cref="BufferGeometry"/></inheritdoc>
    public sealed class TrianglesGeometry : BufferGeometry
    {
        public TrianglesGeometry() : base("TrianglesGeometry")
        { }

        /// <summary>
        /// Lists of vertices for each polygon. Each vertex has a position and a normal vector.
        /// </summary>
        public List<Triangle3> Triangles { get; set; } = new List<Triangle3>();
    }
}
