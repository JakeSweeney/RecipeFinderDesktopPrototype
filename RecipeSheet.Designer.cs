﻿namespace RecipeFinderPrototype
{
    partial class RecipeSheet
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
            returnHomeButton = new Button();
            fLPRecipeSheet = new FlowLayoutPanel();
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
            // returnHomeButton
            // 
            returnHomeButton.Location = new Point(423, 9);
            returnHomeButton.Name = "returnHomeButton";
            returnHomeButton.Size = new Size(114, 29);
            returnHomeButton.TabIndex = 1;
            returnHomeButton.Text = "Return Home";
            returnHomeButton.UseVisualStyleBackColor = true;
            returnHomeButton.Click += button1_Click;
            // 
            // fLPRecipeSheet
            // 
            fLPRecipeSheet.AutoScroll = true;
            fLPRecipeSheet.Location = new Point(12, 52);
            fLPRecipeSheet.Name = "fLPRecipeSheet";
            fLPRecipeSheet.Size = new Size(525, 710);
            fLPRecipeSheet.TabIndex = 2;
            // 
            // RecipeSheet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 789);
            Controls.Add(fLPRecipeSheet);
            Controls.Add(returnHomeButton);
            Controls.Add(logoLbl);
            Name = "RecipeSheet";
            Text = "Recipe Sheet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logoLbl;
        private Button returnHomeButton;
        private FlowLayoutPanel fLPRecipeSheet;
    }
}