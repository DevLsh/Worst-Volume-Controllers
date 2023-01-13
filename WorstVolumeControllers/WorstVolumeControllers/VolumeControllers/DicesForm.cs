using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WorstVolumeControllers
{
    public partial class DicesForm : Form
    {
        #region DEF
        private Random rand = new Random();
        // DO NOT MODIFY THIS VARIANCE
        private readonly string[] DICE_NUM_ARR = {
            "\r\n       ●",
            "●\r\n\r\n              ●",
            "●\r\n       ●\r\n              ●",
            "●         ●\r\n\r\n●         ●",
            "●         ●\r\n       ●\r\n●         ●",
            "●         ●\r\n●         ●\r\n●         ●"
        };
        private bool isRolling = false;
        private int rollCount = 25;
        private List<DiceInfo> diceLbList = new List<DiceInfo>();        
        private class DiceInfo
        {            
            public Label diceLb;
            public int index;
            public bool isHold;
        }
        #endregion
        public DicesForm()
        {
            InitializeComponent();
            CreateDices(12);
        }

        private void CreateDices(int count)
        {
            DiceFlpn.Controls.Clear();
            diceLbList.Clear();
            for (int i = 0; i < count; i++)
            {
                #region CONTAINER
                Panel pn = new Panel();
                pn.BorderStyle = BorderStyle.None;
                pn.Location = new Point(0, 0);
                pn.Size = new Size(65, 90);
                pn.Visible = true;
                DiceFlpn.Controls.Add(pn);
                #endregion

                #region DICE_PANEL
                Panel dicePn = new Panel();
                dicePn.Dock = DockStyle.Top;
                dicePn.BorderStyle = BorderStyle.FixedSingle;
                dicePn.Location = new Point(0, 0);
                dicePn.Size = new Size(65, 65);
                dicePn.Visible = true;
                pn.Controls.Add(dicePn);
                #endregion

                #region DICE_LABEL
                Label diceLb = new Label();
                diceLb.Text = DICE_NUM_ARR[rand.Next(6)];
                diceLb.AutoSize = true;
                diceLb.Dock = DockStyle.Fill;
                diceLb.Font = new Font("Dubai", 9F, FontStyle.Bold, GraphicsUnit.Point);
                dicePn.Controls.Add(diceLb);
                diceLbList.Add(new DiceInfo { diceLb = diceLb, isHold = false });
                #endregion

                #region HOLD_CHECKBOX
                CheckBox cbox = new CheckBox();
                cbox.Name = i.ToString();
                cbox.Text = "Hold";
                cbox.Dock = DockStyle.Bottom;
                int clonedIndex = i;
                cbox.CheckedChanged += (s, ev) =>
                {
                    diceLbList[clonedIndex].isHold = cbox.Checked;
                };
                pn.Controls.Add(cbox);
                #endregion
            }
            Roll(1);
        }

        private void RollBtn_Click(object sender, EventArgs e)
        {
            if (isRolling)
            {
                Console.WriteLine("Is rolling now...");
                return;
            }
            Task.Run(() => Roll(rollCount));
        }

        private void Roll(int rollCount)
        {
            isRolling = true;
            for (int ri = 0; ri < rollCount; ri++)
            {
                //var lb = DiceFlpn.Controls[ci].Controls[$"DiceLb{ci}"];
                //SetControlUI(lb, () => lb.Text = DICE_NUM_ARR[rand.Next(6)]);
                foreach (var di in diceLbList)
                {
                    if (!di.isHold)
                    {
                        var randIndex = rand.Next(6);
                        di.index = randIndex + 1;
                        Tools.Instance.SetControlUI(this, () => di.diceLb.Text = DICE_NUM_ARR[randIndex]);
                    }
                }
                Thread.Sleep(30);
            }
            var volume = 0;
            foreach (var di in diceLbList)
            {
                volume += di.index;
            }
            volume = Math.Min(100, volume);
            Tools.Instance.SetControlUI(this, () => VolumeLb.Text = $"Volume: {volume}");
            Tools.Instance.SetVolume(volume);
            isRolling = false;
        }

        private void SetDiceCountBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(DiceCountTbox.Text, out int result))
            {
                Console.WriteLine($"{nameof(DiceCountTbox)} Parse err");
                return;
            }
            CreateDices(result);
        }

        private void SetRollCountBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(RollCountTbox.Text, out int result))
            {
                Console.WriteLine($"{nameof(RollCountTbox)} Parse err");
                return;
            }
            rollCount = result;
        }
    }
}
