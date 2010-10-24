namespace WindowsFormsApplication1
{
    partial class OptionDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.groupBehaviour = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupAppearance = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lblFontColour = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.lblBackColour = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.btnColourDialog = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.scrollWidth = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBehaviour = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colourDialog = new System.Windows.Forms.ColorDialog();
            this.tabControl.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.groupBehaviour.SuspendLayout();
            this.groupAppearance.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBasic);
            this.tabControl.Controls.Add(this.tabBehaviour);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(262, 343);
            this.tabControl.TabIndex = 0;
            // 
            // tabBasic
            // 
            this.tabBasic.Controls.Add(this.groupBehaviour);
            this.tabBasic.Controls.Add(this.groupAppearance);
            this.tabBasic.Location = new System.Drawing.Point(4, 22);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasic.Size = new System.Drawing.Size(254, 317);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic Properties";
            this.tabBasic.UseVisualStyleBackColor = true;
            // 
            // groupBehaviour
            // 
            this.groupBehaviour.Controls.Add(this.checkBox1);
            this.groupBehaviour.Controls.Add(this.comboBox1);
            this.groupBehaviour.Controls.Add(this.label5);
            this.groupBehaviour.Controls.Add(this.label4);
            this.groupBehaviour.Location = new System.Drawing.Point(7, 220);
            this.groupBehaviour.Name = "groupBehaviour";
            this.groupBehaviour.Size = new System.Drawing.Size(241, 91);
            this.groupBehaviour.TabIndex = 1;
            this.groupBehaviour.TabStop = false;
            this.groupBehaviour.Text = "Behaviour";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(82, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Right",
            "Left"});
            this.comboBox1.Location = new System.Drawing.Point(82, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "On Startup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dock Edge";
            // 
            // groupAppearance
            // 
            this.groupAppearance.Controls.Add(this.button4);
            this.groupAppearance.Controls.Add(this.lblFontColour);
            this.groupAppearance.Controls.Add(this.label7);
            this.groupAppearance.Controls.Add(this.label6);
            this.groupAppearance.Controls.Add(this.hScrollBar1);
            this.groupAppearance.Controls.Add(this.lblBackColour);
            this.groupAppearance.Controls.Add(this.lblFont);
            this.groupAppearance.Controls.Add(this.btnColourDialog);
            this.groupAppearance.Controls.Add(this.button3);
            this.groupAppearance.Controls.Add(this.scrollWidth);
            this.groupAppearance.Controls.Add(this.label3);
            this.groupAppearance.Controls.Add(this.label2);
            this.groupAppearance.Controls.Add(this.label1);
            this.groupAppearance.Location = new System.Drawing.Point(6, 6);
            this.groupAppearance.Name = "groupAppearance";
            this.groupAppearance.Size = new System.Drawing.Size(242, 208);
            this.groupAppearance.TabIndex = 0;
            this.groupAppearance.TabStop = false;
            this.groupAppearance.Text = "Appearance";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(157, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Change";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblFontColour
            // 
            this.lblFontColour.AutoSize = true;
            this.lblFontColour.BackColor = System.Drawing.Color.White;
            this.lblFontColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFontColour.Location = new System.Drawing.Point(83, 170);
            this.lblFontColour.Name = "lblFontColour";
            this.lblFontColour.Size = new System.Drawing.Size(37, 15);
            this.lblFontColour.TabIndex = 10;
            this.lblFontColour.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Font Colour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Opacity";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(83, 65);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(149, 17);
            this.hScrollBar1.TabIndex = 7;
            // 
            // lblBackColour
            // 
            this.lblBackColour.AutoSize = true;
            this.lblBackColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBackColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBackColour.Location = new System.Drawing.Point(83, 100);
            this.lblBackColour.Name = "lblBackColour";
            this.lblBackColour.Size = new System.Drawing.Size(52, 15);
            this.lblBackColour.TabIndex = 6;
            this.lblBackColour.Text = "#FFFFFF";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(80, 139);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(35, 13);
            this.lblFont.TabIndex = 5;
            this.lblFont.Text = "label6";
            // 
            // btnColourDialog
            // 
            this.btnColourDialog.Location = new System.Drawing.Point(157, 95);
            this.btnColourDialog.Name = "btnColourDialog";
            this.btnColourDialog.Size = new System.Drawing.Size(75, 23);
            this.btnColourDialog.TabIndex = 4;
            this.btnColourDialog.Text = "Change";
            this.btnColourDialog.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Change";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // scrollWidth
            // 
            this.scrollWidth.Location = new System.Drawing.Point(83, 27);
            this.scrollWidth.Name = "scrollWidth";
            this.scrollWidth.Size = new System.Drawing.Size(149, 17);
            this.scrollWidth.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Font";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // tabBehaviour
            // 
            this.tabBehaviour.Location = new System.Drawing.Point(4, 22);
            this.tabBehaviour.Name = "tabBehaviour";
            this.tabBehaviour.Padding = new System.Windows.Forms.Padding(3);
            this.tabBehaviour.Size = new System.Drawing.Size(254, 317);
            this.tabBehaviour.TabIndex = 1;
            this.tabBehaviour.Text = "Behaviour";
            this.tabBehaviour.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // OptionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptionDialog";
            this.Text = " Options";
            this.Load += new System.EventHandler(this.OptionDialog_Load);
            this.tabControl.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.groupBehaviour.ResumeLayout(false);
            this.groupBehaviour.PerformLayout();
            this.groupAppearance.ResumeLayout(false);
            this.groupAppearance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.TabPage tabBehaviour;
        private System.Windows.Forms.GroupBox groupAppearance;
        private System.Windows.Forms.GroupBox groupBehaviour;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colourDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBackColour;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Button btnColourDialog;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.HScrollBar scrollWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblFontColour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}