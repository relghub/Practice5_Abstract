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
        protected int SideCount;
        protected float SideLength;
        protected int SC
        {
            get { return SideCount; }
            set { SideCount = value; }
        }
        protected float SL
        {
            get { return SideLength; }
            set { SideLength = value; }
        }
        internal Reg_Polyhedron(int SC, float SL)
        {
            this.SC = SC;
            this.SL = SL;
        }
        internal abstract double SurfaceArea();
        internal abstract double Volume();
        public abstract string ValuesPrint();
    }
    class Tetrahedron : Reg_Polyhedron
    {
        protected double HL;
        protected double TSA; // Tetrahedron Surface Area
        protected double TV; // Tetrahedron Volume
        internal Tetrahedron(int SC, float SL) : base(SC, SL)
        {
            HL = Math.Sqrt(2)/ Math.Sqrt(3) * SL;
            TSA = SurfaceArea();
            TV = Volume();
        }
        internal override double SurfaceArea()
        {
            return SC * Math.Pow(SL, 2) * (Math.Sqrt(3) / 4);
        }
        internal override double Volume()
        {
            return (HL * TSA)/(3 * SC);
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
        protected double HL;
        protected double OSA; // Tetrahedron Surface Area
        protected double OV; // Tetrahedron Volume
        internal Octahedron(int SC, float SL) : base(SC, SL)
        {
            HL = SL * Math.Sqrt(2) / Math.Sqrt(3);
            OSA = SurfaceArea();
            OV = Volume();
        }
        internal override double SurfaceArea()
        {
            return SC * Math.Pow(SL, 2) * (Math.Sqrt(3) / 4);
        }
        internal override double Volume()
        {
            return (HL * OSA) / (3 * SC);
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
        protected double CSA; // Tetrahedron Surface Area
        protected double CV; // Tetrahedron Volume
        internal Cube(int SC, float SL) : base(SC, SL)
        {
            CSA = SurfaceArea();
            CV = Volume();
        }
        internal override double SurfaceArea()
        {
            return SC * Math.Pow(SL, 2);
        }
        internal override double Volume()
        {
            return Math.Pow(SL, 3);
        }
        public override string ValuesPrint()
        {
            return "Повна площа поверхні куба становить " +
                    CSA + "кв. м., об'єм куба становить " +
                    CV + "куб. м.";
        }
    }

}
