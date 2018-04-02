//Developed by www.codestack.net
//License: https://github.com/codestack-net-dev/pdm-vault-browser/blob/master/LICENSE

using System;
using System.Linq;
using System.Windows.Forms;

namespace CodeStack.Dev.PdmVaultBrowser
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var path = "";

            if (args.Any())
            {
                path = args.First();
            }

            var dlg = new OpenFileDialog()
            {
                InitialDirectory = path,
                Multiselect = true
            };

            dlg.ShowDialog();
        }
    }
}