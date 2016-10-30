using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poke_Edit
{
    public static class Warning
    {
        public static bool UnsavedAbort(IWin32Window owner) {
            DialogResult res = MessageBox.Show(owner, "You have unsaved changes, do you wish to continue?", "Warning: Unsaved Progress",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            return (res == DialogResult.Cancel ? true : false);
        }
    }
}
