using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef2
{
    internal class Stapel<S>
    {
        private List<S> StapelLijst = new List<S>();
        private List<S> CopyStapelLijst = new List<S>();



        public void VStapel(S voegToe)
        {
            StapelLijst.Add(voegToe);
        }

        public S AfStapel()
        {
            if (StapelLijst.Count <= 0)
            {
                throw new ArgumentNullException();
            }
            S updatedLijst = StapelLijst[StapelLijst.Count - 1];
            StapelLijst.RemoveAt(StapelLijst.Count - 1);

            return updatedLijst;

        }
        public void StapelLeeg()
        {
            StapelLijst.Clear();
        }



        public override string ToString()
        {
            string lijst = "";

            foreach (S s in StapelLijst)
            {
                lijst += s.ToString() + " " + ",";
            }

            return lijst;
        }

        public bool zoekInLable(S Zoek)
        {
            foreach (S elements in StapelLijst)
            {

                if (elements.ToString() == Zoek.ToString())
                {

                    return true;

                }

            }

            return false;

        }

        public List<S> CopyLijst()
        {
            CopyStapelLijst = StapelLijst.GetRange(0, StapelLijst.Count);

            return CopyStapelLijst;
        }
    }
}
