using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Motorcycle
    {
        const ushort speed = 420;
        string vinNumer = "ASD76678-AS76F-S8D7F6G-SD78GF";
        int odometr = 69_000;

        void StartEngine()
        {

        }

        public ushort speedPublic = speed;
        private ushort speedPrivate = speed;
        protected ushort speedProtected = speed;
        internal ushort speedInternal = speed;
        protected internal ushort speedProtIntern = speed;
        private protected ushort speedPrivProt = speed;

        
    }
}
