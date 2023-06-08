using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActivityReportSystem.Function;

namespace ActivityReportSystem
{
    public partial class ucCards : UserControl
    {
        public ucCards()
        {
            InitializeComponent();
            //ClickEvent();
        }

        private Image _Icon;
        private LinkLabel _Links;

        private string _Title;
        private string _Value;
        private string _LinkText;

        private Color _BodyColor;
        private Color _BodyLeftColor;
        private Color _BodyBottomColor;
        private Color _TitleFontColor;
        private Color _ValueFontColor;

        // Controls

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _Icon; }
            set { _Icon = value; pb_Header.Image = value; }
        }

        [Category("Custom Props")]
        public string TextLinks
        {
            get { return _LinkText; }
            set { _LinkText = value; Lk_Details.Text = value; }
        }

        [Category("Custom Props")]
        public string TextHeader
        {
            get { return _Title; }
            set { _Title = value; Lb_Header.Text = value; }
        }

        [Category("Custom Props")]
        public string TextValue
        {
            get { return _Value; }
            set { _Value = value; Lb_Value.Text = value; }
        }

        // Colors

        [Category("Custom Props")]
        public Color BackColorBody
        {
            get { return _BodyColor; }
            set { _BodyColor = value; Pn_Body.BackColor = value; }
        }

        [Category("Custom Props")]
        public Color BackColorSide
        {
            get { return _BodyLeftColor; }
            set { _BodyLeftColor = value; Pn_Left.BackColor = value; }
        }

        [Category("Custom Props")]
        public Color BackColorBottom
        {
            get { return _BodyBottomColor; }
            set { _BodyBottomColor = value; pn_Bottom.BackColor = value; }
        }


        [Category("Custom Props")]
        public Color ForeColorTitle
        {
            get { return _TitleFontColor; }
            set { _TitleFontColor = value; Lb_Header.ForeColor = value; }
        }

        [Category("Custom Props")]
        public Color ForeColorValue
        {
            get { return _ValueFontColor; }
            set { _ValueFontColor = value; Lb_Value.ForeColor = value; }
        }


        // Events
        //private void ClickEvent()
        //{
        //    Lk_Details.Click += new EventHandler((object sender, EventArgs e) => this.OnClick(e));
        //}

        private void Lk_Details_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
