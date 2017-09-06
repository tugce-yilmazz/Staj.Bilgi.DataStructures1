using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoublyLinkedListArayaEklemeSilme
{   class DoubleLinkedList
    {   private DoubleLink _first;
        public bool IsEmpty {
            get { return _first == null; }    }
        public DoubleLinkedList() { _first = null;  }
        public DoubleLink Insert(string title) {
            DoubleLink link = new DoubleLink(title);
            link.NextLink = _first;
            if (_first != null)
                _first.PreviousLink = link;
            _first = link;
            return link; }
        public DoubleLink Delete() {
            DoubleLink temp = _first;
            if (_first != null) {
                _first = _first.NextLink;
                if (_first != null)
                    _first.PreviousLink = null;  }
            return temp;  }
        public override string ToString() {
            DoubleLink currentLink = _first;
            StringBuilder builder = new StringBuilder();
            while (currentLink != null)  {
                builder.Append(currentLink);
                currentLink = currentLink.NextLink;    }
            return builder.ToString();   }
        public void InsertAfter(DoubleLink link, string title){
            if (link == null || string.IsNullOrEmpty(title)) { return; }
            DoubleLink newLink = new DoubleLink(title);
            newLink.PreviousLink = link;
            if (link.NextLink != null) { link.NextLink.PreviousLink = newLink; }
            newLink.NextLink = link.NextLink;
            link.NextLink = newLink;
        }
    }
}

