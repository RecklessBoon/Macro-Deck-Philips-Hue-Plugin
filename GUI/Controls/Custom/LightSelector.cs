using SuchByte.MacroDeck.GUI.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls
{
    public partial class LightSelector : RoundedUserControl
    {
        public event EventHandler<SelectedChangedEventArgs> OnSelectedChanged;

        public Color UnselectedColor = Color.FromArgb(255, 45, 45, 45);
        public Color SelectedColor = Color.FromArgb(255, 45, 80, 45);

        private string _id;
        public string ID
        {
            get { return _id; }
        }

        private object _value;
        public object Value
        {
            get { return _value; }
        }

        private bool _selected = false;
        public bool Selected
        {
            get { return _selected; }
            set 
            { 
                _selected = value;
                btnControl.BackColor = _selected ? SelectedColor : UnselectedColor;
                OnSelectedChanged?.Invoke(this, new SelectedChangedEventArgs { Selected = value });
            }
        }

        public LightSelector(string ID, string Label, object Value): this(ID, Label, Value, false) { }

        public LightSelector(string ID, string Label, object Value, bool selected)
        {
            _id = ID;
            _value = Value;
            InitializeComponent();
            btnControl.Text = Label;
            Selected = selected;

            btnControl.Click += PnlControl_Click;
        }

        private void PnlControl_Click(object sender, EventArgs e)
        {
            Selected = !Selected;
        }

        public object GetValueIfSelected()
        {
            return Selected ? Value : null;
        }
    }

    public class SelectedChangedEventArgs : EventArgs
    {
        public bool Selected { get; set; }
    }
}
