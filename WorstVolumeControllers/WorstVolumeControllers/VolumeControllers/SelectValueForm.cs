using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorstVolumeControllers
{
    public partial class SelectValueForm : Form
    {
        public SelectValueForm()
        {
            InitializeComponent();
            CreateRdoBtns();
        }

        private void CreateRdoBtns()
        {
            for (int i = 0; i <= 100; i++)
            {
                RadioButton rdoBtn = new RadioButton();
                rdoBtn.AutoSize = true;
                rdoBtn.Text = i.ToString();
                rdoBtn.CheckedChanged += (s, ev) =>
                {
                    Tools.Instance.SetVolume(int.Parse(rdoBtn.Text));
                };
                VolumeValuesFlpn.Controls.Add(rdoBtn);
            }
        }
    }
}
