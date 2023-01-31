namespace DesignPatternImplementations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPublicTransport = new System.Windows.Forms.RadioButton();
            this.rbWalking = new System.Windows.Forms.RadioButton();
            this.rbRoad = new System.Windows.Forms.RadioButton();
            this.btnSrategyStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnObserverStart = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDecoratorStart = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbTruck = new System.Windows.Forms.RadioButton();
            this.rbShip = new System.Windows.Forms.RadioButton();
            this.btnFactoryMethodStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPublicTransport);
            this.groupBox1.Controls.Add(this.rbWalking);
            this.groupBox1.Controls.Add(this.rbRoad);
            this.groupBox1.Controls.Add(this.btnSrategyStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STRATEGY PATTERN";
            // 
            // rbPublicTransport
            // 
            this.rbPublicTransport.AutoSize = true;
            this.rbPublicTransport.Location = new System.Drawing.Point(6, 62);
            this.rbPublicTransport.Name = "rbPublicTransport";
            this.rbPublicTransport.Size = new System.Drawing.Size(107, 19);
            this.rbPublicTransport.TabIndex = 3;
            this.rbPublicTransport.Text = "PublicTransport";
            this.rbPublicTransport.UseVisualStyleBackColor = true;
            // 
            // rbWalking
            // 
            this.rbWalking.AutoSize = true;
            this.rbWalking.Location = new System.Drawing.Point(6, 42);
            this.rbWalking.Name = "rbWalking";
            this.rbWalking.Size = new System.Drawing.Size(68, 19);
            this.rbWalking.TabIndex = 2;
            this.rbWalking.Text = "Walking";
            this.rbWalking.UseVisualStyleBackColor = true;
            // 
            // rbRoad
            // 
            this.rbRoad.AutoSize = true;
            this.rbRoad.Checked = true;
            this.rbRoad.Location = new System.Drawing.Point(6, 22);
            this.rbRoad.Name = "rbRoad";
            this.rbRoad.Size = new System.Drawing.Size(52, 19);
            this.rbRoad.TabIndex = 1;
            this.rbRoad.TabStop = true;
            this.rbRoad.Text = "Road";
            this.rbRoad.UseVisualStyleBackColor = true;
            // 
            // btnSrategyStart
            // 
            this.btnSrategyStart.Location = new System.Drawing.Point(127, 22);
            this.btnSrategyStart.Name = "btnSrategyStart";
            this.btnSrategyStart.Size = new System.Drawing.Size(75, 59);
            this.btnSrategyStart.TabIndex = 0;
            this.btnSrategyStart.Text = "Start";
            this.btnSrategyStart.UseVisualStyleBackColor = true;
            this.btnSrategyStart.Click += new System.EventHandler(this.btnSrategyStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(13, 22);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(493, 152);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnObserverStart);
            this.groupBox3.Location = new System.Drawing.Point(12, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OBSERVER PATTERN";
            // 
            // btnObserverStart
            // 
            this.btnObserverStart.Location = new System.Drawing.Point(6, 22);
            this.btnObserverStart.Name = "btnObserverStart";
            this.btnObserverStart.Size = new System.Drawing.Size(196, 32);
            this.btnObserverStart.TabIndex = 1;
            this.btnObserverStart.Text = "Start";
            this.btnObserverStart.UseVisualStyleBackColor = true;
            this.btnObserverStart.Click += new System.EventHandler(this.btnObserverStart_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDecoratorStart);
            this.groupBox4.Location = new System.Drawing.Point(12, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 60);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DECORATOR PATTERN";
            // 
            // btnDecoratorStart
            // 
            this.btnDecoratorStart.Location = new System.Drawing.Point(6, 22);
            this.btnDecoratorStart.Name = "btnDecoratorStart";
            this.btnDecoratorStart.Size = new System.Drawing.Size(196, 32);
            this.btnDecoratorStart.TabIndex = 2;
            this.btnDecoratorStart.Text = "Start";
            this.btnDecoratorStart.UseVisualStyleBackColor = true;
            this.btnDecoratorStart.Click += new System.EventHandler(this.btnDecoratorStart_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbTruck);
            this.groupBox5.Controls.Add(this.rbShip);
            this.groupBox5.Controls.Add(this.btnFactoryMethodStart);
            this.groupBox5.Location = new System.Drawing.Point(226, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(208, 90);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FACTORY METHOD PATTERN";
            // 
            // rbTruck
            // 
            this.rbTruck.AutoSize = true;
            this.rbTruck.Location = new System.Drawing.Point(6, 54);
            this.rbTruck.Name = "rbTruck";
            this.rbTruck.Size = new System.Drawing.Size(53, 19);
            this.rbTruck.TabIndex = 4;
            this.rbTruck.Text = "Truck";
            this.rbTruck.UseVisualStyleBackColor = true;
            // 
            // rbShip
            // 
            this.rbShip.AutoSize = true;
            this.rbShip.Checked = true;
            this.rbShip.Location = new System.Drawing.Point(6, 29);
            this.rbShip.Name = "rbShip";
            this.rbShip.Size = new System.Drawing.Size(48, 19);
            this.rbShip.TabIndex = 3;
            this.rbShip.TabStop = true;
            this.rbShip.Text = "Ship";
            this.rbShip.UseVisualStyleBackColor = true;
            // 
            // btnFactoryMethodStart
            // 
            this.btnFactoryMethodStart.Location = new System.Drawing.Point(127, 21);
            this.btnFactoryMethodStart.Name = "btnFactoryMethodStart";
            this.btnFactoryMethodStart.Size = new System.Drawing.Size(75, 59);
            this.btnFactoryMethodStart.TabIndex = 2;
            this.btnFactoryMethodStart.Text = "Start";
            this.btnFactoryMethodStart.UseVisualStyleBackColor = true;
            this.btnFactoryMethodStart.Click += new System.EventHandler(this.btnFactoryMethodStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 455);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSrategyStart;
        private RadioButton rbPublicTransport;
        private RadioButton rbWalking;
        private RadioButton rbRoad;
        private GroupBox groupBox2;
        private RichTextBox rtbOutput;
        private GroupBox groupBox3;
        private Button btnObserverStart;
        private GroupBox groupBox4;
        private Button btnDecoratorStart;
        private GroupBox groupBox5;
        private Button btnFactoryMethodStart;
        private RadioButton rbTruck;
        private RadioButton rbShip;
    }
}