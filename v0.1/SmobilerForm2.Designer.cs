using System;
using Smobiler.Core;
namespace v0._1
{
    partial class SmobilerForm2 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public SmobilerForm2()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Form2 = new Smobiler.Core.Controls.Title();
            // 
            // Form2
            // 
            this.Form2.Location = new System.Drawing.Point(111, 278);
            this.Form2.Name = "Form2";
            this.Form2.Size = new System.Drawing.Size(100, 30);
            // 
            // SmobilerForm2
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Form2});
            this.Name = "SmobilerForm2";

        }
        #endregion

        private Smobiler.Core.Controls.Title Form2;
    }
}