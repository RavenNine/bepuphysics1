using System.Numerics;

namespace ConversionHelper
{
    /// <summary>
    /// Helps convert between Numerics math types and the BEPUphysics replacement math types.
    /// A version of this converter could be created for other platforms to ease the integration of the engine.
    /// </summary>
    public static class MathConverter
    {
        //NVector2
        public static NVector2 Convert(BVector2 bepuVector)
        {
            NVector2 toReturn;
            toReturn.X = bepuVector.X;
            toReturn.Y = bepuVector.Y;
            return toReturn;
        }

        public static void Convert(ref BVector2 bepuVector, out NVector2 numericsVector)
        {
            numericsVector.X = bepuVector.X;
            numericsVector.Y = bepuVector.Y;
        }

        public static BVector2 Convert(NVector2 numericsVector)
        {
            BVector2 toReturn;
            toReturn.X = numericsVector.X;
            toReturn.Y = numericsVector.Y;
            return toReturn;
        }

        public static void Convert(ref NVector2 numericsVector, out BVector2 bepuVector)
        {
            bepuVector.X = numericsVector.X;
            bepuVector.Y = numericsVector.Y;
        }

        //NVector3
        public static NVector3 Convert(BVector3 bepuVector)
        {
            NVector3 toReturn;
            toReturn.X = bepuVector.X;
            toReturn.Y = bepuVector.Y;
            toReturn.Z = bepuVector.Z;
            return toReturn;
        }

        public static void Convert(ref BVector3 bepuVector, out NVector3 numericsVector)
        {
            numericsVector.X = bepuVector.X;
            numericsVector.Y = bepuVector.Y;
            numericsVector.Z = bepuVector.Z;
        }

        public static BVector3 Convert(NVector3 numericsVector)
        {
            BVector3 toReturn;
            toReturn.X = numericsVector.X;
            toReturn.Y = numericsVector.Y;
            toReturn.Z = numericsVector.Z;
            return toReturn;
        }

        public static void Convert(ref NVector3 numericsVector, out BVector3 bepuVector)
        {
            bepuVector.X = numericsVector.X;
            bepuVector.Y = numericsVector.Y;
            bepuVector.Z = numericsVector.Z;
        }

        public static NVector3[] Convert(BVector3[] bepuVectors)
        {
            NVector3[] numericsVectors = new NVector3[bepuVectors.Length];
            for (int i = 0; i < bepuVectors.Length; i++)
            {
                Convert(ref bepuVectors[i], out numericsVectors[i]);
            }
            return numericsVectors;

        }

        public static BVector3[] Convert(NVector3[] numericsVectors)
        {
            var bepuVectors = new BVector3[numericsVectors.Length];
            for (int i = 0; i < numericsVectors.Length; i++)
            {
                Convert(ref numericsVectors[i], out bepuVectors[i]);
            }
            return bepuVectors;

        }

        //NMatrix
        public static NMatrix Convert(BMatrix matrix)
        {
            NMatrix toReturn;
            Convert(ref matrix, out toReturn);
            return toReturn;
        }

        public static BMatrix Convert(NMatrix matrix)
        {
            BMatrix toReturn;
            Convert(ref matrix, out toReturn);
            return toReturn;
        }

        public static void Convert(ref BMatrix matrix, out NMatrix numericsMatrix)
        {
            numericsMatrix.M11 = matrix.M11;
            numericsMatrix.M12 = matrix.M12;
            numericsMatrix.M13 = matrix.M13;
            numericsMatrix.M14 = matrix.M14;

            numericsMatrix.M21 = matrix.M21;
            numericsMatrix.M22 = matrix.M22;
            numericsMatrix.M23 = matrix.M23;
            numericsMatrix.M24 = matrix.M24;

            numericsMatrix.M31 = matrix.M31;
            numericsMatrix.M32 = matrix.M32;
            numericsMatrix.M33 = matrix.M33;
            numericsMatrix.M34 = matrix.M34;

            numericsMatrix.M41 = matrix.M41;
            numericsMatrix.M42 = matrix.M42;
            numericsMatrix.M43 = matrix.M43;
            numericsMatrix.M44 = matrix.M44;

        }

        public static void Convert(ref NMatrix matrix, out BMatrix bepuMatrix)
        {
            bepuMatrix.M11 = matrix.M11;
            bepuMatrix.M12 = matrix.M12;
            bepuMatrix.M13 = matrix.M13;
            bepuMatrix.M14 = matrix.M14;

            bepuMatrix.M21 = matrix.M21;
            bepuMatrix.M22 = matrix.M22;
            bepuMatrix.M23 = matrix.M23;
            bepuMatrix.M24 = matrix.M24;

            bepuMatrix.M31 = matrix.M31;
            bepuMatrix.M32 = matrix.M32;
            bepuMatrix.M33 = matrix.M33;
            bepuMatrix.M34 = matrix.M34;

            bepuMatrix.M41 = matrix.M41;
            bepuMatrix.M42 = matrix.M42;
            bepuMatrix.M43 = matrix.M43;
            bepuMatrix.M44 = matrix.M44;

        }

        public static NMatrix Convert(BMatrix3x3 matrix)
        {
            NMatrix toReturn;
            Convert(ref matrix, out toReturn);
            return toReturn;
        }

        public static void Convert(ref BMatrix3x3 matrix, out NMatrix numericsMatrix)
        {
            numericsMatrix.M11 = matrix.M11;
            numericsMatrix.M12 = matrix.M12;
            numericsMatrix.M13 = matrix.M13;
            numericsMatrix.M14 = 0;

            numericsMatrix.M21 = matrix.M21;
            numericsMatrix.M22 = matrix.M22;
            numericsMatrix.M23 = matrix.M23;
            numericsMatrix.M24 = 0;

            numericsMatrix.M31 = matrix.M31;
            numericsMatrix.M32 = matrix.M32;
            numericsMatrix.M33 = matrix.M33;
            numericsMatrix.M34 = 0;

            numericsMatrix.M41 = 0;
            numericsMatrix.M42 = 0;
            numericsMatrix.M43 = 0;
            numericsMatrix.M44 = 1;
        }

        public static void Convert(ref NMatrix matrix, out BMatrix3x3 bepuMatrix)
        {
            bepuMatrix.M11 = matrix.M11;
            bepuMatrix.M12 = matrix.M12;
            bepuMatrix.M13 = matrix.M13;

            bepuMatrix.M21 = matrix.M21;
            bepuMatrix.M22 = matrix.M22;
            bepuMatrix.M23 = matrix.M23;

            bepuMatrix.M31 = matrix.M31;
            bepuMatrix.M32 = matrix.M32;
            bepuMatrix.M33 = matrix.M33;

        }

        //NQuaternion
        public static NQuaternion Convert(BQuaternion quaternion)
        {
            NQuaternion toReturn;
            toReturn.X = quaternion.X;
            toReturn.Y = quaternion.Y;
            toReturn.Z = quaternion.Z;
            toReturn.W = quaternion.W;
            return toReturn;
        }

        public static BQuaternion Convert(NQuaternion quaternion)
        {
            BQuaternion toReturn;
            toReturn.X = quaternion.X;
            toReturn.Y = quaternion.Y;
            toReturn.Z = quaternion.Z;
            toReturn.W = quaternion.W;
            return toReturn;
        }

        public static void Convert(ref BQuaternion bepuQuaternion, out NQuaternion quaternion)
        {
            quaternion.X = bepuQuaternion.X;
            quaternion.Y = bepuQuaternion.Y;
            quaternion.Z = bepuQuaternion.Z;
            quaternion.W = bepuQuaternion.W;
        }

        public static void Convert(ref NQuaternion quaternion, out  BQuaternion bepuQuaternion)
        {
            bepuQuaternion.X = quaternion.X;
            bepuQuaternion.Y = quaternion.Y;
            bepuQuaternion.Z = quaternion.Z;
            bepuQuaternion.W = quaternion.W;
        }
    }
}
