using Smobiler.Core;

namespace v0._1
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public SmobilerForm1()
            : base()
        {
            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.weiXin1 = new Smobiler.Core.Controls.Native.WeiXin();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.lable1 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // weiXin1
            // 
            this.weiXin1.Name = "weiXin1";
            // 
            // button1
            // 
            this.button1.FontSize = 25F;
            this.button1.Location = new System.Drawing.Point(0, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 71);
            this.button1.Text = "Hello World!";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(150, 250);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 60);
            // 
            // lable1
            // 
            this.lable1.FontSize = 20F;
            this.lable1.Location = new System.Drawing.Point(68, 30);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(100, 35);
            this.lable1.Text = "资讯";
            // 
            // label1
            // 
            this.label1.FontSize = 20F;
            this.label1.Location = new System.Drawing.Point(119, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "校园";
            // 
            // label2
            // 
            this.label2.FontSize = 20F;
            this.label2.Location = new System.Drawing.Point(168, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "工作";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.textBox1,
            this.label3});
            this.panel1.Location = new System.Drawing.Point(2, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 48);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 46);
            this.textBox1.WaterMarkText = "点击这里";
            // 
            // label3
            // 
            this.label3.FontSize = 30F;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.Text = "serch";
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(0, 110);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(300, 154);
            // 
            // SmobilerForm1
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.weiXin1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.title1,
            this.lable1,
            this.label1,
            this.label2,
            this.panel1,
            this.image1});
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.Native.WeiXin weiXin1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Label lable1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Image image1;
    }
}