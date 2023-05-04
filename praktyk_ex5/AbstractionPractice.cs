using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Distraction
{
    abstract class Reg_Polyhedron
    {
        protected int EdgeCount;
        protected float EdgeLength;
        protected int EC
        {
            get { return EdgeCount; }
            set { EdgeCount = value; }
        }
        protected float EL
        {
            get { return EdgeLength; }
            set { EdgeLength = value; }
        }
        internal Reg_Polyhedron(int EC, float EL)
        {
            this.EC = EC;
            this.EL = EL;
        }
        internal abstract double FaceArea();
        internal abstract double SurfaceArea();
        internal abstract double Volume();
        public abstract string ValuesPrint();
    }
    class Tetrahedron : Reg_Polyhedron
    {
        protected int SideCount = 4;
        protected double HL;
        protected double TFA; // Tetrahedron Face Area
        protected double TSA; // Tetrahedron Surface Area
        protected double TV; // Tetrahedron Volume
        internal Tetrahedron(int EC, float EL) : base(EC, EL)
        {
            HL = EL * Math.Sqrt(2) / Math.Sqrt(3);
            TFA = FaceArea();
            TSA = SurfaceArea();
            TV = Volume();
        }
        internal override double FaceArea()
        {
            return Math.Pow(EL, 2) * (Math.Sqrt(3) / 4);
        }
        internal override double SurfaceArea()
        {
            return SideCount * TFA;
        }
        internal override double Volume()
        {
            return (HL * TFA) / 3;
        }
        public override string ValuesPrint()
        {
            return "Повна площа поверхні тетраедра становить " +
                   TSA + "кв. м., об'єм тетраедра становить " +
                   TV + "куб. м.";
        }
    }
    class Octahedron : Reg_Polyhedron
    {
        protected int SideCount = 8;
        protected double HL;
        protected double OFA;
        protected double OSA; // Tetrahedron Surface Area
        protected double OV; // Tetrahedron Volume
        internal Octahedron(int EC, float EL) : base(EC, EL)
        {
            HL = 2 * Math.Sqrt(2) * EL / Math.Sqrt(3);
            OFA = FaceArea();
            OSA = SurfaceArea();
            OV = Volume();
        }
        internal override double FaceArea()
        {
            return Math.Pow(EL, 2) * (Math.Sqrt(3) / 4);
        }
        internal override double SurfaceArea()
        {
            return SideCount * OFA;
        }
        internal override double Volume()
        {
            return 2 * (HL * OFA) / 3;
        }
        public override string ValuesPrint()
        {
            return "Повна площа поверхні октаедра становить " +
                    OSA + "кв. м., об'єм октаедра становить " +
                    OV + "куб. м.";
        }
    }
    class Cube : Reg_Polyhedron
    {
        protected int SideCount = 6;
        protected double CFA;
        protected double CSA; // Tetrahedron Surface Area
        protected double CV; // Tetrahedron Volume
        internal Cube(int EC, float EL) : base(EC, EL)
        {
            CFA = FaceArea();
            CSA = SurfaceArea();
            CV = Volume();
        }
        internal override double FaceArea()
        {
            return Math.Pow(EL, 2);
        }
        internal override double SurfaceArea()
        {
            return SideCount * CFA;
        }
        internal override double Volume()
        {
            return Math.Pow(EL, 3);
        }
        public override string ValuesPrint()
        {
            return "Повна площа поверхні куба становить " +
                    CSA + "кв. м., об'єм куба становить " +
                    CV + "куб. м.";
        }
    }

}
