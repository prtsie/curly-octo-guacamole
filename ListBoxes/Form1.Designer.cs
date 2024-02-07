namespace ListBoxes
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
            LeftList = new ListBox();
            RightList = new ListBox();
            SelectedToRight = new Button();
            SelectedToLeft = new Button();
            AllToRight = new Button();
            AllToLeft = new Button();
            SuspendLayout();
            // 
            // LeftList
            // 
            LeftList.FormattingEnabled = true;
            LeftList.ItemHeight = 15;
            LeftList.Location = new Point(12, 12);
            LeftList.Name = "LeftList";
            LeftList.Size = new Size(120, 109);
            LeftList.TabIndex = 0;
            // 
            // RightList
            // 
            RightList.FormattingEnabled = true;
            RightList.ItemHeight = 15;
            RightList.Location = new Point(176, 12);
            RightList.Name = "RightList";
            RightList.Size = new Size(120, 109);
            RightList.TabIndex = 1;
            // 
            // SelectedToRight
            // 
            SelectedToRight.Location = new Point(138, 12);
            SelectedToRight.Name = "SelectedToRight";
            SelectedToRight.Size = new Size(32, 23);
            SelectedToRight.TabIndex = 2;
            SelectedToRight.Text = ">";
            SelectedToRight.UseVisualStyleBackColor = true;
            // 
            // SelectedToLeft
            // 
            SelectedToLeft.Location = new Point(138, 41);
            SelectedToLeft.Name = "SelectedToLeft";
            SelectedToLeft.Size = new Size(32, 23);
            SelectedToLeft.TabIndex = 3;
            SelectedToLeft.Text = "<";
            SelectedToLeft.UseVisualStyleBackColor = true;
            // 
            // AllToRight
            // 
            AllToRight.Location = new Point(138, 70);
            AllToRight.Name = "AllToRight";
            AllToRight.Size = new Size(32, 23);
            AllToRight.TabIndex = 4;
            AllToRight.Text = ">>";
            AllToRight.UseVisualStyleBackColor = true;
            // 
            // AllToLeft
            // 
            AllToLeft.Location = new Point(138, 99);
            AllToLeft.Name = "AllToLeft";
            AllToLeft.Size = new Size(32, 23);
            AllToLeft.TabIndex = 5;
            AllToLeft.Text = "<<";
            AllToLeft.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 136);
            Controls.Add(AllToLeft);
            Controls.Add(AllToRight);
            Controls.Add(SelectedToLeft);
            Controls.Add(SelectedToRight);
            Controls.Add(RightList);
            Controls.Add(LeftList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LeftList;
        private ListBox RightList;
        private Button SelectedToRight;
        private Button SelectedToLeft;
        private Button AllToRight;
        private Button AllToLeft;
    }
}
