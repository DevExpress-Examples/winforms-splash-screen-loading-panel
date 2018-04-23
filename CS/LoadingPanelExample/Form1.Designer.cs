namespace LoadingPanelExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.listBox = new DevExpress.XtraEditors.ListBoxControl();
            this.picture = new DevExpress.XtraEditors.PictureEdit();
            this.radioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.memo = new DevExpress.XtraEditors.MemoEdit();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.LookAndFeel.SkinName = "Money Twins";
            this.listBox.LookAndFeel.UseDefaultLookAndFeel = false;
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(493, 487);
            this.listBox.TabIndex = 0;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(172, 507);
            this.picture.Name = "picture";
            this.picture.Properties.LookAndFeel.SkinName = "The Asphalt World";
            this.picture.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.picture.Size = new System.Drawing.Size(100, 96);
            this.picture.TabIndex = 1;
            // 
            // radioGroup
            // 
            this.radioGroup.Location = new System.Drawing.Point(529, 12);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Properties.LookAndFeel.SkinName = "Lilian";
            this.radioGroup.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.radioGroup.Size = new System.Drawing.Size(252, 179);
            this.radioGroup.TabIndex = 2;
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(543, 275);
            this.memo.Name = "memo";
            this.memo.Properties.LookAndFeel.SkinName = "iMaginary";
            this.memo.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.memo.Size = new System.Drawing.Size(368, 293);
            this.memo.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 615);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.radioGroup);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.listBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBox;
        private DevExpress.XtraEditors.PictureEdit picture;
        private DevExpress.XtraEditors.RadioGroup radioGroup;
        private DevExpress.XtraEditors.MemoEdit memo;
        private System.Windows.Forms.Timer timer;

    }
}

