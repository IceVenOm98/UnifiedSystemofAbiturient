using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnifiedSystemofAbiturient
{
    public class SelectionContext
    {
        private Selection Selection;
        public void setSelection(Selection selection)
        {
            Selection = selection;
        }
        public List<University> getSelection(List<University> universities)
        {
            return Selection.get(universities);
        }
    }
}