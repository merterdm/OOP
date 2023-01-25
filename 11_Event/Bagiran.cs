using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Event
{

    public delegate void MetotTipi(object sender);
    public class Bagiran
    {

        public string Ad { get { return " Ali "; } }

        public event MetotTipi Bagirdim;

        public void HErhangiBirIslemYap()
        {
            MessageBox.Show(" heeeyyyyt  ");
            Bagirdim(this);
        }
    }
}
