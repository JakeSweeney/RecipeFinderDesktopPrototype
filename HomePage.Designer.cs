﻿namespace RecipeFinderPrototype
{
    partial class HomePage
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
            logoLbl = new Label();
            dialogueLbl1 = new Label();
            dialogueLbl2 = new Label();
            dialogueLbl3 = new Label();
            dialogueLbl4 = new Label();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // logoLbl
            // 
            logoLbl.AutoSize = true;
            logoLbl.BackColor = SystemColors.ControlLight;
            logoLbl.BorderStyle = BorderStyle.FixedSingle;
            logoLbl.Location = new Point(12, 9);
            logoLbl.Name = "logoLbl";
            logoLbl.Size = new Size(126, 22);
            logoLbl.TabIndex = 0;
            logoLbl.Text = "Choose My Food!";
            // 
            // dialogueLbl1
            // 
            dialogueLbl1.AutoSize = true;
            dialogueLbl1.Location = new Point(173, 68);
            dialogueLbl1.Name = "dialogueLbl1";
            dialogueLbl1.Size = new Size(208, 20);
            dialogueLbl1.TabIndex = 1;
            dialogueLbl1.Text = "Welcome to Choose My Food!";
            // 
            // dialogueLbl2
            // 
            dialogueLbl2.AutoSize = true;
            dialogueLbl2.Location = new Point(36, 88);
            dialogueLbl2.Name = "dialogueLbl2";
            dialogueLbl2.Size = new Size(484, 20);
            dialogueLbl2.TabIndex = 2;
            dialogueLbl2.Text = "This application aims to curb food waste by using as much food in your ";
            // 
            // dialogueLbl3
            // 
            dialogueLbl3.AutoSize = true;
            dialogueLbl3.Location = new Point(211, 108);
            dialogueLbl3.Name = "dialogueLbl3";
            dialogueLbl3.Size = new Size(129, 20);
            dialogueLbl3.TabIndex = 3;
            dialogueLbl3.Text = "fridge as possible.";
            // 
            // dialogueLbl4
            // 
            dialogueLbl4.AutoSize = true;
            dialogueLbl4.Location = new Point(187, 149);
            dialogueLbl4.Name = "dialogueLbl4";
            dialogueLbl4.Size = new Size(185, 20);
            dialogueLbl4.TabIndex = 4;
            dialogueLbl4.Text = "Where do you want to go?";
            // 
            // button1
            // 
            button1.Location = new Point(77, 228);
            button1.Name = "button1";
            button1.Size = new Size(161, 29);
            button1.TabIndex = 5;
            button1.Text = "Find me a recipe";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(310, 228);
            button2.Name = "button2";
            button2.Size = new Size(174, 29);
            button2.TabIndex = 6;
            button2.Text = "Custom recipe tools";
            button2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(77, 274);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 303);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dialogueLbl4);
            Controls.Add(dialogueLbl3);
            Controls.Add(dialogueLbl2);
            Controls.Add(dialogueLbl1);
            Controls.Add(logoLbl);
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logoLbl;
        private Label dialogueLbl1;
        private Label dialogueLbl2;
        private Label dialogueLbl3;
        private Label dialogueLbl4;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}