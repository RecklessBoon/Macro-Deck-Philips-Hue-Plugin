using SuchByte.MacroDeck.GUI.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Dialog
{
    public partial class ButtonPressNotifier : DialogForm
    {
        public ButtonPressNotifier()
        {
            InitializeComponent();
            this.Shown += ButtonPressNotifier_Shown;
        }

        private void ButtonPressNotifier_Shown(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var time = 0;
                while (time < 30)
                {
                    if (!prgTimer.IsDisposed)
                    {
                        prgTimer.Invoke((MethodInvoker)(() =>
                        {
                            prgTimer.Value += 1;
                        }));
                    }
                    Thread.Sleep(1000);
                }
                this.Close();
            });
        }
    }
}
