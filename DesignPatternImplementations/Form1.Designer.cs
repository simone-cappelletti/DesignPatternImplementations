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
            groupBox1 = new GroupBox();
            rbPublicTransport = new RadioButton();
            rbWalking = new RadioButton();
            rbRoad = new RadioButton();
            btnSrategyStart = new Button();
            groupBox2 = new GroupBox();
            rtbOutput = new RichTextBox();
            groupBox3 = new GroupBox();
            btnObserverStart = new Button();
            groupBox4 = new GroupBox();
            btnDecoratorStart = new Button();
            groupBox5 = new GroupBox();
            rbTruck = new RadioButton();
            rbShip = new RadioButton();
            btnFactoryMethodStart = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            groupBox8 = new GroupBox();
            btnFacadeStart = new Button();
            groupBox7 = new GroupBox();
            btnAdapterStart = new Button();
            groupBox6 = new GroupBox();
            btnCommandAllLightsOff = new Button();
            btnCommandAllLightsOn = new Button();
            label3 = new Label();
            btnCommandUndo = new Button();
            btnCommandKitchenLightsOff = new Button();
            label2 = new Label();
            btnCommandKitchenLightsOn = new Button();
            btnCommandLivingRoomLightsOff = new Button();
            label1 = new Label();
            btnCommandLivingRoomLightsOn = new Button();
            groupBox9 = new GroupBox();
            btnTemplateMethodStart = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbPublicTransport);
            groupBox1.Controls.Add(rbWalking);
            groupBox1.Controls.Add(rbRoad);
            groupBox1.Controls.Add(btnSrategyStart);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(208, 91);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "STRATEGY PATTERN";
            // 
            // rbPublicTransport
            // 
            rbPublicTransport.AutoSize = true;
            rbPublicTransport.Location = new Point(6, 62);
            rbPublicTransport.Name = "rbPublicTransport";
            rbPublicTransport.Size = new Size(107, 19);
            rbPublicTransport.TabIndex = 3;
            rbPublicTransport.Text = "PublicTransport";
            rbPublicTransport.UseVisualStyleBackColor = true;
            // 
            // rbWalking
            // 
            rbWalking.AutoSize = true;
            rbWalking.Location = new Point(6, 42);
            rbWalking.Name = "rbWalking";
            rbWalking.Size = new Size(68, 19);
            rbWalking.TabIndex = 2;
            rbWalking.Text = "Walking";
            rbWalking.UseVisualStyleBackColor = true;
            // 
            // rbRoad
            // 
            rbRoad.AutoSize = true;
            rbRoad.Checked = true;
            rbRoad.Location = new Point(6, 22);
            rbRoad.Name = "rbRoad";
            rbRoad.Size = new Size(52, 19);
            rbRoad.TabIndex = 1;
            rbRoad.TabStop = true;
            rbRoad.Text = "Road";
            rbRoad.UseVisualStyleBackColor = true;
            // 
            // btnSrategyStart
            // 
            btnSrategyStart.Location = new Point(127, 22);
            btnSrategyStart.Name = "btnSrategyStart";
            btnSrategyStart.Size = new Size(75, 59);
            btnSrategyStart.TabIndex = 0;
            btnSrategyStart.Text = "Start";
            btnSrategyStart.UseVisualStyleBackColor = true;
            btnSrategyStart.Click += btnSrategyStart_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtbOutput);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(945, 398);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "OUTPUT";
            // 
            // rtbOutput
            // 
            rtbOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbOutput.Location = new Point(13, 22);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(926, 370);
            rtbOutput.TabIndex = 0;
            rtbOutput.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnObserverStart);
            groupBox3.Location = new Point(217, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(208, 60);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "OBSERVER PATTERN";
            // 
            // btnObserverStart
            // 
            btnObserverStart.Location = new Point(6, 22);
            btnObserverStart.Name = "btnObserverStart";
            btnObserverStart.Size = new Size(196, 32);
            btnObserverStart.TabIndex = 1;
            btnObserverStart.Text = "Start";
            btnObserverStart.UseVisualStyleBackColor = true;
            btnObserverStart.Click += btnObserverStart_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDecoratorStart);
            groupBox4.Location = new Point(217, 69);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(208, 60);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "DECORATOR PATTERN";
            // 
            // btnDecoratorStart
            // 
            btnDecoratorStart.Location = new Point(6, 22);
            btnDecoratorStart.Name = "btnDecoratorStart";
            btnDecoratorStart.Size = new Size(196, 32);
            btnDecoratorStart.TabIndex = 2;
            btnDecoratorStart.Text = "Start";
            btnDecoratorStart.UseVisualStyleBackColor = true;
            btnDecoratorStart.Click += btnDecoratorStart_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rbTruck);
            groupBox5.Controls.Add(rbShip);
            groupBox5.Controls.Add(btnFactoryMethodStart);
            groupBox5.Location = new Point(3, 105);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(208, 90);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "FACTORY METHOD PATTERN";
            // 
            // rbTruck
            // 
            rbTruck.AutoSize = true;
            rbTruck.Location = new Point(6, 54);
            rbTruck.Name = "rbTruck";
            rbTruck.Size = new Size(53, 19);
            rbTruck.TabIndex = 4;
            rbTruck.Text = "Truck";
            rbTruck.UseVisualStyleBackColor = true;
            // 
            // rbShip
            // 
            rbShip.AutoSize = true;
            rbShip.Checked = true;
            rbShip.Location = new Point(6, 29);
            rbShip.Name = "rbShip";
            rbShip.Size = new Size(48, 19);
            rbShip.TabIndex = 3;
            rbShip.TabStop = true;
            rbShip.Text = "Ship";
            rbShip.UseVisualStyleBackColor = true;
            // 
            // btnFactoryMethodStart
            // 
            btnFactoryMethodStart.Location = new Point(127, 21);
            btnFactoryMethodStart.Name = "btnFactoryMethodStart";
            btnFactoryMethodStart.Size = new Size(75, 59);
            btnFactoryMethodStart.TabIndex = 2;
            btnFactoryMethodStart.Text = "Start";
            btnFactoryMethodStart.UseVisualStyleBackColor = true;
            btnFactoryMethodStart.Click += btnFactoryMethodStart_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.8461533F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.15385F));
            tableLayoutPanel1.Size = new Size(951, 610);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox9);
            panel1.Controls.Add(groupBox8);
            panel1.Controls.Add(groupBox7);
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 200);
            panel1.TabIndex = 2;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btnFacadeStart);
            groupBox8.Location = new Point(431, 135);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(208, 60);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "FACADE PATTERN";
            // 
            // btnFacadeStart
            // 
            btnFacadeStart.Location = new Point(6, 22);
            btnFacadeStart.Name = "btnFacadeStart";
            btnFacadeStart.Size = new Size(196, 32);
            btnFacadeStart.TabIndex = 2;
            btnFacadeStart.Text = "Start";
            btnFacadeStart.UseVisualStyleBackColor = true;
            btnFacadeStart.Click += btnFacadeStart_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btnAdapterStart);
            groupBox7.Location = new Point(217, 135);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(208, 60);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "ADAPTER PATTERN";
            // 
            // btnAdapterStart
            // 
            btnAdapterStart.Location = new Point(6, 22);
            btnAdapterStart.Name = "btnAdapterStart";
            btnAdapterStart.Size = new Size(196, 32);
            btnAdapterStart.TabIndex = 2;
            btnAdapterStart.Text = "Start";
            btnAdapterStart.UseVisualStyleBackColor = true;
            btnAdapterStart.Click += btnAdapterStart_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnCommandAllLightsOff);
            groupBox6.Controls.Add(btnCommandAllLightsOn);
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(btnCommandUndo);
            groupBox6.Controls.Add(btnCommandKitchenLightsOff);
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(btnCommandKitchenLightsOn);
            groupBox6.Controls.Add(btnCommandLivingRoomLightsOff);
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(btnCommandLivingRoomLightsOn);
            groupBox6.Location = new Point(431, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(208, 126);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "COMMAND PATTERN";
            // 
            // btnCommandAllLightsOff
            // 
            btnCommandAllLightsOff.Location = new Point(163, 68);
            btnCommandAllLightsOff.Name = "btnCommandAllLightsOff";
            btnCommandAllLightsOff.Size = new Size(36, 21);
            btnCommandAllLightsOff.TabIndex = 9;
            btnCommandAllLightsOff.Text = "OFF";
            btnCommandAllLightsOff.UseVisualStyleBackColor = true;
            btnCommandAllLightsOff.Click += btnCommandAllLightsOff_Click;
            // 
            // btnCommandAllLightsOn
            // 
            btnCommandAllLightsOn.Location = new Point(121, 68);
            btnCommandAllLightsOn.Name = "btnCommandAllLightsOn";
            btnCommandAllLightsOn.Size = new Size(36, 21);
            btnCommandAllLightsOn.TabIndex = 8;
            btnCommandAllLightsOn.Text = "ON";
            btnCommandAllLightsOn.UseVisualStyleBackColor = true;
            btnCommandAllLightsOn.Click += btnCommandAllLightsOn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 72);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "All lights:";
            // 
            // btnCommandUndo
            // 
            btnCommandUndo.Location = new Point(121, 91);
            btnCommandUndo.Name = "btnCommandUndo";
            btnCommandUndo.Size = new Size(78, 29);
            btnCommandUndo.TabIndex = 6;
            btnCommandUndo.Text = "Undo";
            btnCommandUndo.UseVisualStyleBackColor = true;
            btnCommandUndo.Click += btnCommandUndo_Click;
            // 
            // btnCommandKitchenLightsOff
            // 
            btnCommandKitchenLightsOff.Location = new Point(163, 44);
            btnCommandKitchenLightsOff.Name = "btnCommandKitchenLightsOff";
            btnCommandKitchenLightsOff.Size = new Size(36, 21);
            btnCommandKitchenLightsOff.TabIndex = 5;
            btnCommandKitchenLightsOff.Text = "OFF";
            btnCommandKitchenLightsOff.UseVisualStyleBackColor = true;
            btnCommandKitchenLightsOff.Click += btnCommandKitchenLightsOff_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 49);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Kitchen lights:";
            // 
            // btnCommandKitchenLightsOn
            // 
            btnCommandKitchenLightsOn.Location = new Point(121, 44);
            btnCommandKitchenLightsOn.Name = "btnCommandKitchenLightsOn";
            btnCommandKitchenLightsOn.Size = new Size(36, 21);
            btnCommandKitchenLightsOn.TabIndex = 3;
            btnCommandKitchenLightsOn.Text = "ON";
            btnCommandKitchenLightsOn.UseVisualStyleBackColor = true;
            btnCommandKitchenLightsOn.Click += btnCommandKitchenLightsOn_Click;
            // 
            // btnCommandLivingRoomLightsOff
            // 
            btnCommandLivingRoomLightsOff.Location = new Point(163, 20);
            btnCommandLivingRoomLightsOff.Name = "btnCommandLivingRoomLightsOff";
            btnCommandLivingRoomLightsOff.Size = new Size(36, 21);
            btnCommandLivingRoomLightsOff.TabIndex = 2;
            btnCommandLivingRoomLightsOff.Text = "OFF";
            btnCommandLivingRoomLightsOff.UseVisualStyleBackColor = true;
            btnCommandLivingRoomLightsOff.Click += btnCommandLivingRoomLightsOff_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Living room lights:";
            // 
            // btnCommandLivingRoomLightsOn
            // 
            btnCommandLivingRoomLightsOn.Location = new Point(121, 20);
            btnCommandLivingRoomLightsOn.Name = "btnCommandLivingRoomLightsOn";
            btnCommandLivingRoomLightsOn.Size = new Size(36, 21);
            btnCommandLivingRoomLightsOn.TabIndex = 0;
            btnCommandLivingRoomLightsOn.Text = "ON";
            btnCommandLivingRoomLightsOn.UseVisualStyleBackColor = true;
            btnCommandLivingRoomLightsOn.Click += btnCommandLivingRoomLightsOn_Click;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(btnTemplateMethodStart);
            groupBox9.Location = new Point(645, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(208, 60);
            groupBox9.TabIndex = 6;
            groupBox9.TabStop = false;
            groupBox9.Text = "TEMPLATE METHOD PATTERN";
            // 
            // btnTemplateMethodStart
            // 
            btnTemplateMethodStart.Location = new Point(6, 22);
            btnTemplateMethodStart.Name = "btnTemplateMethodStart";
            btnTemplateMethodStart.Size = new Size(196, 32);
            btnTemplateMethodStart.TabIndex = 2;
            btnTemplateMethodStart.Text = "Start";
            btnTemplateMethodStart.UseVisualStyleBackColor = true;
            btnTemplateMethodStart.Click += btnTemplateMethodStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 610);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox9.ResumeLayout(false);
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox6;
        private Button btnCommandKitchenLightsOff;
        private Label label2;
        private Button btnCommandKitchenLightsOn;
        private Button btnCommandLivingRoomLightsOff;
        private Label label1;
        private Button btnCommandLivingRoomLightsOn;
        private Button btnCommandUndo;
        private Button btnCommandAllLightsOff;
        private Button btnCommandAllLightsOn;
        private Label label3;
        private GroupBox groupBox7;
        private Button btnAdapterStart;
        private GroupBox groupBox8;
        private Button btnFacadeStart;
        private GroupBox groupBox9;
        private Button btnTemplateMethodStart;
    }
}