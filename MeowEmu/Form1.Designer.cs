namespace MeowEmu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.SendTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftEyeControls = new System.Windows.Forms.GroupBox();
            this.LeftSquinted = new System.Windows.Forms.CheckBox();
            this.BrowDownLeft = new System.Windows.Forms.TrackBar();
            this.BrowInnerUpLeft = new System.Windows.Forms.TrackBar();
            this.BrowOuterUpLeft = new System.Windows.Forms.TrackBar();
            this.LeftOpenness = new System.Windows.Forms.TrackBar();
            this.LeftWidened = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LeftEye = new MeowEmu.JoystickControl();
            this.RightEyeControls = new System.Windows.Forms.GroupBox();
            this.RightSquinted = new System.Windows.Forms.CheckBox();
            this.BrowOuterUpRight = new System.Windows.Forms.TrackBar();
            this.BrowDownRight = new System.Windows.Forms.TrackBar();
            this.BrowInnerUpRight = new System.Windows.Forms.TrackBar();
            this.RightOpenness = new System.Windows.Forms.TrackBar();
            this.RightWidened = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RightEye = new MeowEmu.JoystickControl();
            this.label10 = new System.Windows.Forms.Label();
            this.CurrentElementBox = new System.Windows.Forms.TextBox();
            this.MouthControls = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MouthLRUpper = new MeowEmu.JoystickControl();
            this.MouthRollLower = new System.Windows.Forms.TrackBar();
            this.MouthRollUpper = new System.Windows.Forms.TrackBar();
            this.MouthFunnel = new System.Windows.Forms.TrackBar();
            this.MouthPucker = new System.Windows.Forms.TrackBar();
            this.TongueOut = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SmileFrownLeft = new System.Windows.Forms.TrackBar();
            this.SmileFrownRight = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Jaw = new MeowEmu.JoystickControl();
            this.MouthLeftRight = new System.Windows.Forms.TrackBar();
            this.NoseControls = new System.Windows.Forms.GroupBox();
            this.NoseSneerRight = new System.Windows.Forms.TrackBar();
            this.NoseSneerLeft = new System.Windows.Forms.TrackBar();
            this.LeftEyeControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrowDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowInnerUpLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowOuterUpLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftOpenness)).BeginInit();
            this.RightEyeControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrowOuterUpRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowDownRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowInnerUpRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightOpenness)).BeginInit();
            this.MouthControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MouthRollLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouthRollUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouthFunnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouthPucker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TongueOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmileFrownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmileFrownRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouthLeftRight)).BeginInit();
            this.NoseControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoseSneerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoseSneerLeft)).BeginInit();
            this.SuspendLayout();
            //
            // SendTimer
            //
            this.SendTimer.Interval = 10;
            this.SendTimer.Tick += new System.EventHandler(this.timer1_Tick);
            //
            // LeftEyeControls
            //
            this.LeftEyeControls.Controls.Add(this.LeftSquinted);
            this.LeftEyeControls.Controls.Add(this.BrowDownLeft);
            this.LeftEyeControls.Controls.Add(this.BrowInnerUpLeft);
            this.LeftEyeControls.Controls.Add(this.BrowOuterUpLeft);
            this.LeftEyeControls.Controls.Add(this.LeftOpenness);
            this.LeftEyeControls.Controls.Add(this.LeftWidened);
            this.LeftEyeControls.Controls.Add(this.label7);
            this.LeftEyeControls.Controls.Add(this.LeftEye);
            this.LeftEyeControls.Location = new System.Drawing.Point(12, 12);
            this.LeftEyeControls.Name = "LeftEyeControls";
            this.LeftEyeControls.Size = new System.Drawing.Size(221, 203);
            this.LeftEyeControls.TabIndex = 7;
            this.LeftEyeControls.TabStop = false;
            this.LeftEyeControls.Text = "Left Eye";
            //
            // LeftSquinted
            //
            this.LeftSquinted.AutoSize = true;
            this.LeftSquinted.Location = new System.Drawing.Point(8, 176);
            this.LeftSquinted.Name = "LeftSquinted";
            this.LeftSquinted.Size = new System.Drawing.Size(68, 17);
            this.LeftSquinted.TabIndex = 9;
            this.LeftSquinted.Text = "Squinted";
            this.LeftSquinted.UseVisualStyleBackColor = true;
            //
            // BrowDownLeft
            //
            this.BrowDownLeft.Location = new System.Drawing.Point(119, 15);
            this.BrowDownLeft.Name = "BrowDownLeft";
            this.BrowDownLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BrowDownLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BrowDownLeft.Size = new System.Drawing.Size(45, 42);
            this.BrowDownLeft.TabIndex = 7;
            this.BrowDownLeft.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.BrowDownLeft.Value = 10;
            //
            // BrowInnerUpLeft
            //
            this.BrowInnerUpLeft.Location = new System.Drawing.Point(170, 15);
            this.BrowInnerUpLeft.Name = "BrowInnerUpLeft";
            this.BrowInnerUpLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BrowInnerUpLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BrowInnerUpLeft.Size = new System.Drawing.Size(45, 42);
            this.BrowInnerUpLeft.TabIndex = 7;
            this.BrowInnerUpLeft.TickStyle = System.Windows.Forms.TickStyle.Both;
            //
            // BrowOuterUpLeft
            //
            this.BrowOuterUpLeft.Location = new System.Drawing.Point(68, 15);
            this.BrowOuterUpLeft.Name = "BrowOuterUpLeft";
            this.BrowOuterUpLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BrowOuterUpLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BrowOuterUpLeft.Size = new System.Drawing.Size(45, 42);
            this.BrowOuterUpLeft.TabIndex = 7;
            this.BrowOuterUpLeft.TickStyle = System.Windows.Forms.TickStyle.Both;
            //
            // LeftOpenness
            //
            this.LeftOpenness.Location = new System.Drawing.Point(18, 87);
            this.LeftOpenness.Name = "LeftOpenness";
            this.LeftOpenness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftOpenness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LeftOpenness.Size = new System.Drawing.Size(45, 83);
            this.LeftOpenness.TabIndex = 7;
            this.LeftOpenness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.LeftOpenness.Value = 10;
            //
            // LeftWidened
            //
            this.LeftWidened.AutoSize = true;
            this.LeftWidened.Location = new System.Drawing.Point(8, 72);
            this.LeftWidened.Name = "LeftWidened";
            this.LeftWidened.Size = new System.Drawing.Size(69, 17);
            this.LeftWidened.TabIndex = 8;
            this.LeftWidened.Text = "Widened";
            this.LeftWidened.UseVisualStyleBackColor = true;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Brow";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // LeftEye
            //
            this.LeftEye.Location = new System.Drawing.Point(83, 63);
            this.LeftEye.Name = "LeftEye";
            this.LeftEye.Size = new System.Drawing.Size(130, 130);
            this.LeftEye.TabIndex = 1;
            //
            // RightEyeControls
            //
            this.RightEyeControls.Controls.Add(this.RightSquinted);
            this.RightEyeControls.Controls.Add(this.BrowOuterUpRight);
            this.RightEyeControls.Controls.Add(this.BrowDownRight);
            this.RightEyeControls.Controls.Add(this.BrowInnerUpRight);
            this.RightEyeControls.Controls.Add(this.RightOpenness);
            this.RightEyeControls.Controls.Add(this.RightWidened);
            this.RightEyeControls.Controls.Add(this.label8);
            this.RightEyeControls.Controls.Add(this.RightEye);
            this.RightEyeControls.Location = new System.Drawing.Point(468, 12);
            this.RightEyeControls.Name = "RightEyeControls";
            this.RightEyeControls.Size = new System.Drawing.Size(220, 203);
            this.RightEyeControls.TabIndex = 8;
            this.RightEyeControls.TabStop = false;
            this.RightEyeControls.Text = "Right Eye";
            //
            // RightSquinted
            //
            this.RightSquinted.AutoSize = true;
            this.RightSquinted.Location = new System.Drawing.Point(9, 176);
            this.RightSquinted.Name = "RightSquinted";
            this.RightSquinted.Size = new System.Drawing.Size(68, 17);
            this.RightSquinted.TabIndex = 9;
            this.RightSquinted.Text = "Squinted";
            this.RightSquinted.UseVisualStyleBackColor = true;
            //
            // BrowOuterUpRight
            //
            this.BrowOuterUpRight.Location = new System.Drawing.Point(169, 15);
            this.BrowOuterUpRight.Name = "BrowOuterUpRight";
            this.BrowOuterUpRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BrowOuterUpRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BrowOuterUpRight.Size = new System.Drawing.Size(45, 42);
            this.BrowOuterUpRight.TabIndex = 7;
            this.BrowOuterUpRight.TickStyle = System.Windows.Forms.TickStyle.Both;
            //
            // BrowDownRight
            //
            this.BrowDownRight.Location = new System.Drawing.Point(118, 15);
            this.BrowDownRight.Name = "BrowDownRight";
            this.BrowDownRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BrowDownRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BrowDownRight.Size = new System.Drawing.Size(45, 42);
            this.BrowDownRight.TabIndex = 7;
            this.BrowDownRight.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.BrowDownRight.Value = 10;
            //
            // BrowInnerUpRight
            //
            this.BrowInnerUpRight.Location = new System.Drawing.Point(67, 15);
            this.BrowInnerUpRight.Name = "BrowInnerUpRight";
            this.BrowInnerUpRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BrowInnerUpRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BrowInnerUpRight.Size = new System.Drawing.Size(45, 42);
            this.BrowInnerUpRight.TabIndex = 7;
            this.BrowInnerUpRight.TickStyle = System.Windows.Forms.TickStyle.Both;
            //
            // RightOpenness
            //
            this.RightOpenness.Location = new System.Drawing.Point(19, 87);
            this.RightOpenness.Name = "RightOpenness";
            this.RightOpenness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightOpenness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightOpenness.Size = new System.Drawing.Size(45, 83);
            this.RightOpenness.TabIndex = 7;
            this.RightOpenness.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RightOpenness.Value = 10;
            //
            // RightWidened
            //
            this.RightWidened.AutoSize = true;
            this.RightWidened.Location = new System.Drawing.Point(9, 72);
            this.RightWidened.Name = "RightWidened";
            this.RightWidened.Size = new System.Drawing.Size(69, 17);
            this.RightWidened.TabIndex = 8;
            this.RightWidened.Text = "Widened";
            this.RightWidened.UseVisualStyleBackColor = true;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Brow";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // RightEye
            //
            this.RightEye.Location = new System.Drawing.Point(84, 63);
            this.RightEye.Name = "RightEye";
            this.RightEye.Size = new System.Drawing.Size(130, 130);
            this.RightEye.TabIndex = 1;
            //
            // label10
            //
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(497, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Selected element:";
            //
            // CurrentElementBox
            //
            this.CurrentElementBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentElementBox.Location = new System.Drawing.Point(595, 453);
            this.CurrentElementBox.Name = "CurrentElementBox";
            this.CurrentElementBox.ReadOnly = true;
            this.CurrentElementBox.Size = new System.Drawing.Size(100, 20);
            this.CurrentElementBox.TabIndex = 15;
            //
            // MouthControls
            //
            this.MouthControls.Controls.Add(this.label11);
            this.MouthControls.Controls.Add(this.MouthLRUpper);
            this.MouthControls.Controls.Add(this.MouthRollLower);
            this.MouthControls.Controls.Add(this.MouthRollUpper);
            this.MouthControls.Controls.Add(this.MouthFunnel);
            this.MouthControls.Controls.Add(this.MouthPucker);
            this.MouthControls.Controls.Add(this.TongueOut);
            this.MouthControls.Controls.Add(this.label6);
            this.MouthControls.Controls.Add(this.label4);
            this.MouthControls.Controls.Add(this.label5);
            this.MouthControls.Controls.Add(this.label3);
            this.MouthControls.Controls.Add(this.SmileFrownLeft);
            this.MouthControls.Controls.Add(this.SmileFrownRight);
            this.MouthControls.Controls.Add(this.label9);
            this.MouthControls.Controls.Add(this.label2);
            this.MouthControls.Controls.Add(this.label12);
            this.MouthControls.Controls.Add(this.label1);
            this.MouthControls.Controls.Add(this.Jaw);
            this.MouthControls.Controls.Add(this.MouthLeftRight);
            this.MouthControls.Location = new System.Drawing.Point(239, 107);
            this.MouthControls.Name = "MouthControls";
            this.MouthControls.Size = new System.Drawing.Size(223, 377);
            this.MouthControls.TabIndex = 19;
            this.MouthControls.TabStop = false;
            this.MouthControls.Text = "Mouth";
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Lips";
            //
            // MouthLRUpper
            //
            this.MouthLRUpper.Location = new System.Drawing.Point(51, 104);
            this.MouthLRUpper.Name = "MouthLRUpper";
            this.MouthLRUpper.Size = new System.Drawing.Size(121, 43);
            this.MouthLRUpper.TabIndex = 31;
            this.MouthLRUpper.Text = "joystickControl1";
            //
            // MouthRollLower
            //
            this.MouthRollLower.Location = new System.Drawing.Point(85, 145);
            this.MouthRollLower.Name = "MouthRollLower";
            this.MouthRollLower.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MouthRollLower.Size = new System.Drawing.Size(45, 45);
            this.MouthRollLower.TabIndex = 29;
            this.MouthRollLower.TickStyle = System.Windows.Forms.TickStyle.Both;
            //
            // MouthRollUpper
            //
            this.MouthRollUpper.Location = new System.Drawing.Point(85, 60);
            this.MouthRollUpper.Name = "MouthRollUpper";
            this.MouthRollUpper.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MouthRollUpper.Size = new System.Drawing.Size(45, 45);
            this.MouthRollUpper.TabIndex = 30;
            this.MouthRollUpper.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.MouthRollUpper.Value = 10;
            //
            // MouthFunnel
            //
            this.MouthFunnel.Location = new System.Drawing.Point(51, 283);
            this.MouthFunnel.Name = "MouthFunnel";
            this.MouthFunnel.Size = new System.Drawing.Size(121, 45);
            this.MouthFunnel.TabIndex = 28;
            //
            // MouthPucker
            //
            this.MouthPucker.Location = new System.Drawing.Point(51, 238);
            this.MouthPucker.Name = "MouthPucker";
            this.MouthPucker.Size = new System.Drawing.Size(121, 45);
            this.MouthPucker.TabIndex = 28;
            //
            // TongueOut
            //
            this.TongueOut.Location = new System.Drawing.Point(51, 330);
            this.TongueOut.Name = "TongueOut";
            this.TongueOut.Size = new System.Drawing.Size(121, 45);
            this.TongueOut.TabIndex = 28;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Frown";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Frown";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Smile";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Smile";
            //
            // SmileFrownLeft
            //
            this.SmileFrownLeft.Location = new System.Drawing.Point(3, 96);
            this.SmileFrownLeft.Minimum = -10;
            this.SmileFrownLeft.Name = "SmileFrownLeft";
            this.SmileFrownLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SmileFrownLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SmileFrownLeft.Size = new System.Drawing.Size(45, 93);
            this.SmileFrownLeft.TabIndex = 19;
            this.SmileFrownLeft.TickStyle = System.Windows.Forms.TickStyle.Both;
            //
            // SmileFrownRight
            //
            this.SmileFrownRight.Location = new System.Drawing.Point(178, 96);
            this.SmileFrownRight.Minimum = -10;
            this.SmileFrownRight.Name = "SmileFrownRight";
            this.SmileFrownRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SmileFrownRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SmileFrownRight.Size = new System.Drawing.Size(45, 93);
            this.SmileFrownRight.TabIndex = 20;
            this.SmileFrownRight.TickStyle = System.Windows.Forms.TickStyle.Both;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Funnel";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pucker";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tongue";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Jaw";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // Jaw
            //
            this.Jaw.Location = new System.Drawing.Point(51, 192);
            this.Jaw.Name = "Jaw";
            this.Jaw.Size = new System.Drawing.Size(121, 45);
            this.Jaw.TabIndex = 21;
            this.Jaw.Text = "joystickControl1";
            //
            // MouthLeftRight
            //
            this.MouthLeftRight.Location = new System.Drawing.Point(51, 19);
            this.MouthLeftRight.Minimum = -10;
            this.MouthLeftRight.Name = "MouthLeftRight";
            this.MouthLeftRight.Size = new System.Drawing.Size(121, 45);
            this.MouthLeftRight.TabIndex = 33;
            this.MouthLeftRight.TickStyle = System.Windows.Forms.TickStyle.Both;
            //
            // NoseControls
            //
            this.NoseControls.Controls.Add(this.NoseSneerRight);
            this.NoseControls.Controls.Add(this.NoseSneerLeft);
            this.NoseControls.Location = new System.Drawing.Point(239, 14);
            this.NoseControls.Name = "NoseControls";
            this.NoseControls.Size = new System.Drawing.Size(223, 87);
            this.NoseControls.TabIndex = 20;
            this.NoseControls.TabStop = false;
            this.NoseControls.Text = "Nose";
            //
            // NoseSneerRight
            //
            this.NoseSneerRight.Location = new System.Drawing.Point(130, 15);
            this.NoseSneerRight.Name = "NoseSneerRight";
            this.NoseSneerRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.NoseSneerRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoseSneerRight.Size = new System.Drawing.Size(45, 62);
            this.NoseSneerRight.TabIndex = 8;
            this.NoseSneerRight.TickStyle = System.Windows.Forms.TickStyle.Both;
            //
            // NoseSneerLeft
            //
            this.NoseSneerLeft.Location = new System.Drawing.Point(35, 15);
            this.NoseSneerLeft.Name = "NoseSneerLeft";
            this.NoseSneerLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.NoseSneerLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoseSneerLeft.Size = new System.Drawing.Size(45, 62);
            this.NoseSneerLeft.TabIndex = 9;
            this.NoseSneerLeft.TickStyle = System.Windows.Forms.TickStyle.Both;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 485);
            this.Controls.Add(this.NoseControls);
            this.Controls.Add(this.MouthControls);
            this.Controls.Add(this.CurrentElementBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LeftEyeControls);
            this.Controls.Add(this.RightEyeControls);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Faceposer";
            this.LeftEyeControls.ResumeLayout(false);
            this.LeftEyeControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrowDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowInnerUpLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowOuterUpLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftOpenness)).EndInit();
            this.RightEyeControls.ResumeLayout(false);
            this.RightEyeControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrowOuterUpRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowDownRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowInnerUpRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightOpenness)).EndInit();
            this.MouthControls.ResumeLayout(false);
            this.MouthControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MouthRollLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouthRollUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouthFunnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouthPucker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TongueOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmileFrownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmileFrownRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouthLeftRight)).EndInit();
            this.NoseControls.ResumeLayout(false);
            this.NoseControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoseSneerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoseSneerLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer SendTimer;
        private System.Windows.Forms.GroupBox LeftEyeControls;
        private System.Windows.Forms.CheckBox LeftSquinted;
        private System.Windows.Forms.TrackBar LeftOpenness;
        private System.Windows.Forms.CheckBox LeftWidened;
        private JoystickControl LeftEye;
        private System.Windows.Forms.GroupBox RightEyeControls;
        private System.Windows.Forms.CheckBox RightSquinted;
        private System.Windows.Forms.TrackBar RightOpenness;
        private System.Windows.Forms.CheckBox RightWidened;
        private JoystickControl RightEye;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar BrowDownLeft;
        private System.Windows.Forms.TrackBar BrowInnerUpLeft;
        private System.Windows.Forms.TrackBar BrowOuterUpLeft;
        private System.Windows.Forms.TrackBar BrowOuterUpRight;
        private System.Windows.Forms.TrackBar BrowDownRight;
        private System.Windows.Forms.TrackBar BrowInnerUpRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CurrentElementBox;
        private System.Windows.Forms.GroupBox MouthControls;
        private System.Windows.Forms.TrackBar MouthRollLower;
        private System.Windows.Forms.TrackBar MouthRollUpper;
        private System.Windows.Forms.TrackBar TongueOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar SmileFrownLeft;
        private System.Windows.Forms.TrackBar SmileFrownRight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private JoystickControl Jaw;
        private System.Windows.Forms.GroupBox NoseControls;
        private System.Windows.Forms.TrackBar NoseSneerRight;
        private System.Windows.Forms.TrackBar NoseSneerLeft;
        private JoystickControl MouthLRUpper;
        private System.Windows.Forms.TrackBar MouthFunnel;
        private System.Windows.Forms.TrackBar MouthPucker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar MouthLeftRight;
    }
}

