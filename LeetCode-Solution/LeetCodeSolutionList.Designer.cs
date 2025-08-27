namespace LeetCode_Solution
{
    partial class LeetCodeSolutionList
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
            RichTextBox solutionOutput;
            problemListView = new ListView();
            solutionOutput = new RichTextBox();
            SuspendLayout();
            // 
            // problemListView
            // 
            problemListView.Location = new Point(55, 52);
            problemListView.Name = "problemListView";
            problemListView.Size = new Size(121, 97);
            problemListView.TabIndex = 0;
            problemListView.UseCompatibleStateImageBehavior = false;
            problemListView.SelectedIndexChanged += problemListView_DoubleClick;
            // 
            // solutionOutput
            // 
            solutionOutput.Location = new Point(334, 52);
            solutionOutput.Name = "solutionOutput";
            solutionOutput.Size = new Size(203, 150);
            solutionOutput.TabIndex = 1;
            solutionOutput.Text = "";
            // 
            // LeetCodeSolutionList
            // 
            ClientSize = new Size(609, 261);
            Controls.Add(solutionOutput);
            Controls.Add(problemListView);
            Name = "LeetCodeSolutionList";
            ResumeLayout(false);
        }

        #endregion

        private ListView problemListView;
        private RichTextBox solutionOutput;
    }
}
