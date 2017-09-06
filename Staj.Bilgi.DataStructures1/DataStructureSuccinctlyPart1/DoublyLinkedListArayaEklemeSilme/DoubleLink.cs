using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoublyLinkedListArayaEklemeSilme
{
    class DoubleLink
    {
        public string Title { get; set; }
        public DoubleLink PreviousLink { get; set; }
        public DoubleLink NextLink { get; set; }

        public DoubleLink(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
