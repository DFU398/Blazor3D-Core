namespace HomagGroup.Blazor3D.Maths
{
    /// <summary>
    /// A triangle in 3D space with normal vectors for each vertex.
    /// </summary>
    public sealed class Triangle3
    {
        /// <summary>
        /// Position of the first vertex.
        /// </summary>
        public Vector3 PositionA { get; set; } = new Vector3();

        /// <summary>
        /// Position of the second vertex.
        /// </summary>
        public Vector3 PositionB { get; set; } = new Vector3();

        /// <summary>
        /// Position of the third vertex.
        /// </summary>
        public Vector3 PositionC { get; set; } = new Vector3();

        /// <summary>
        /// Normal vector of the first vertex.
        /// </summary>
        public Vector3 NormalA { get; set; } = new Vector3();

        /// <summary>
        /// Normal vector of the second vertex.
        /// </summary>
        public Vector3 NormalB { get; set; } = new Vector3();

        /// <summary>
        /// Normal vector of the third vertex.
        /// </summary>
        public Vector3 NormalC { get; set; } = new Vector3();

        /// <summary>
        /// Uses the positions of the vertices to calculate normal vectors perpendicular to the face, assuming the vertices are ordered counterclockwise when seen from the outside.
        /// </summary>
        public Triangle3 WithNormalsFromPositions()
        {
            var aToB = new System.Numerics.Vector3(
                (float)(this.PositionB.X - this.PositionA.X),
                (float)(this.PositionB.Y - this.PositionA.Y),
                (float)(this.PositionB.Z - this.PositionA.Z)
            );
            var aToC = new System.Numerics.Vector3(
                (float)(this.PositionC.X - this.PositionA.X),
                (float)(this.PositionC.Y - this.PositionA.Y),
                (float)(this.PositionC.Z - this.PositionA.Z)
            );
            var normal = System.Numerics.Vector3.Normalize(
                System.Numerics.Vector3.Cross(aToB, aToC)
            );
            var resultNormal = new Vector3(normal.X, normal.Y, normal.Z);
            return new Triangle3
            {
                PositionA = this.PositionA,
                PositionB = this.PositionB,
                PositionC = this.PositionC,
                NormalA = resultNormal,
                NormalB = resultNormal,
                NormalC = resultNormal
            };
        }
    }
}
