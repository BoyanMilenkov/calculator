using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    public class Enumarable : IEnumerable<Rectangle>
    {
        private readonly List<Rectangle> rectangles;
        public Enumarable(params Rectangle[] rectangles)
        {
            this.Rectangles = new List<Rectangle>(rectangles);
        }
        public List<Rectangle> Rectangles { get; }
        public IEnumerator<Rectangle> GetEnumerator()
        {
            for(int i = 0; i < this.Rectangles.Count; i++)
            {
                yield return this.Rectangles[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
