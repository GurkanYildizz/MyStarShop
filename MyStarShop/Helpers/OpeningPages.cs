using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStarShop.Helpers
{
    public class OpeningPages<Frm> where Frm : Form, new()
    {
        private Frm openForm = null;


        public OpeningPages()
        {
            openForm = new Frm();

        }
        public void OpenForm(Form mainForm)
        {


            if (openForm is Form formOpen)
            {
                if (AllOpenForms.myOpenForms is not null)
                {
                    AllOpenForms.openFormCheck();
                    foreach (var item in AllOpenForms.myOpenForms)
                    {
                        if (item.GetType() == formOpen.GetType())
                        {
                            item.BringToFront();
                            return;
                        }

                    }
                }

                formOpen.MdiParent = mainForm;
                formOpen.Size = new Size(810, 600);
                formOpen.StartPosition = FormStartPosition.CenterScreen;
                formOpen.MaximizeBox = false;
                formOpen.MinimizeBox = false;
                formOpen.FormBorderStyle = FormBorderStyle.FixedSingle;
                formOpen.FormClosing += ExitMessage;


                formOpen.Show();
                AllOpenForms.AddForm(formOpen);

            }

        }

        private void ExitMessage(object? sender, FormClosingEventArgs e)
        {
            var whatIsAction = MessageBox.Show("Kapatmak İstediğinden Emin Misin?", "Dikkat", MessageBoxButtons.YesNo);
            if (whatIsAction == DialogResult.Yes)
            {
                return;
            }
            e.Cancel = true;
        }


    }


}
