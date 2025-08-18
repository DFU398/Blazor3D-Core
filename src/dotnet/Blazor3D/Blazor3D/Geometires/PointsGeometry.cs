using HomagGroup.Blazor3D.Core;
using HomagGroup.Blazor3D.Maths;

namespace HomagGroup.Blazor3D.Geometires
{
    /// <summary>
    /// <para>Geometry for a point cloud.</para>
    /// <para>This class inherits from <see cref="BufferGeometry"/></para>
    /// </summary>
    /// <inheritdoc><see cref="BufferGeometry"/></inheritdoc>
    public sealed class PointsGeometry : BufferGeometry
    {
        public PointsGeometry() : base("PointsGeometry")
        { }

        /// <summary>
        /// Positions of each point. Defaults to empty array.
        /// </summary>
        public Vector3[] Points { get; set; } = Array.Empty<Vector3>();

        /// <summary>
        /// Normal vectors for each point. Defaults to empty array. Optional, leave empty if not used.
        /// </summary>
        public Vector3[] Normals { get; set; } = Array.Empty<Vector3>();

        /// <summary>
        /// RGB colors for each point. Defaults to empty array. Optional, leave empty if not used.
        /// </summary>
        public Vector3[] Colors { get; set; } = Array.Empty<Vector3>();

        /// <summary>
        /// Intensities for each point. Defaults to empty array. Optional, leave empty if not used.
        /// </summary>
        public double[] Intensities{ get; set; } = Array.Empty<double>();

        /// <summary>
        /// Numeric labels for each point. Defaults to empty array. Optional, leave empty if not used.
        /// </summary>
        public int[] Labels{ get; set; } = Array.Empty<int>();
    }
}
