using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace v0._1
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        private void SmobilerForm1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Press(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
           // this.Show(new SmobilerForm2());
        }
    }
}