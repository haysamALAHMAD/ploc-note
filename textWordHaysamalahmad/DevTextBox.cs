using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textWordHaysamalahmad
{
    public class DevTextBox : TextBox
    {
        private bool _IsSaved;

        public bool IsSaved
        {
            get { return _IsSaved; }
            set { _IsSaved = value; }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            IsSaved = false;
        }
    

    }
}
