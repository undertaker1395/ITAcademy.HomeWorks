using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        const ushort speed = 420;
        static string vinNumer = "ASD76678-AS76F-S8D7F6G-SD78GF";
        static int odometr = 69_000;
        
        void StartEngine()
        {

        }

        public ushort speedPublic = speed;
        private ushort speedPrivate = speed;
        protected ushort speedProtected = speed;
        internal ushort speedInternal = speed;
        protected internal ushort speedProtIntern = speed;
        private protected ushort speedPrivProt = speed;

        public string vinNumerPublic = vinNumer;
        private string vinNumerPrivate = vinNumer;
        protected string vinNumerProtected = vinNumer;
        internal string vinNumerInternal = vinNumer;
        protected internal string vinNumerProtIntern = vinNumer;
        private protected string vinNumerPrivProt = vinNumer;

        public int odometrPublic = odometr;
        private int odometrPrivate = odometr;
        protected int odometrProtected = odometr;
        internal int odometrInternal = odometr;
        protected internal int odometrProtIntern = odometr;
        private protected int odometrPrivProt = odometr;

        public void StartEnginePublic()
        {
            StartEngine();
        }
        private void StartEnginePrivate()
        {
            StartEngine();
        }
        protected void StartEngineProtected()
        {
            StartEngine();
        }
        internal void StartEngineInternal()
        {
            StartEngine();
        }
        protected internal void StartEngineProtIntern ()
        {
            StartEngine();
        }
        private protected void StartEnginePrivProt()
        {
            StartEngine();
        }
    }
}
