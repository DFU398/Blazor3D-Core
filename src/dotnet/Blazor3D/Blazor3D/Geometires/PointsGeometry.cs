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
        /// Positions of each point. Defaults to empty list.
        /// </summary>
        public List<Vector3> Points { get; set; } = new List<Vector3>();

        /// <summary>
        /// Normal vectors for each point. Defaults to empty list. Optional, leave empty if not used.
        /// </summary>
        public List<Vector3> Normals { get; set; } = new List<Vector3>();

        /// <summary>
        /// RGB colors for each point. Defaults to empty list. Optional, leave empty if not used.
        /// </summary>
        public List<Vector3> Colors { get; set; } = new List<Vector3>();

        /// <summary>
        /// Intensities for each point. Defaults to empty list. Optional, leave empty if not used.
        /// </summary>
        public List<double> Intensities{ get; set; } = new List<double>();

        /// <summary>
        /// Numeric labels for each point. Defaults to empty list. Optional, leave empty if not used.
        /// </summary>
        public List<int> Labels{ get; set; } = new List<int>();
    }
}
