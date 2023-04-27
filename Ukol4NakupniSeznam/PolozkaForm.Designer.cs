namespace Ukol4NakupniSeznam
{
	partial class PolozkaForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pridatButton = new System.Windows.Forms.Button();
			this.odebratPolozkuButton = new System.Windows.Forms.Button();
			this.pridatTextBox = new System.Windows.Forms.TextBox();
			this.polozkyListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Přidání položky:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Položky:";
			// 
			// pridatButton
			// 
			this.pridatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pridatButton.Location = new System.Drawing.Point(703, 61);
			this.pridatButton.Name = "pridatButton";
			this.pridatButton.Size = new System.Drawing.Size(75, 35);
			this.pridatButton.TabIndex = 2;
			this.pridatButton.Text = "Přidat";
			this.pridatButton.UseVisualStyleBackColor = true;
			this.pridatButton.Click += new System.EventHandler(this.pridatButton_Click);
			// 
			// odebratPolozkuButton
			// 
			this.odebratPolozkuButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.odebratPolozkuButton.Location = new System.Drawing.Point(329, 450);
			this.odebratPolozkuButton.Name = "odebratPolozkuButton";
			this.odebratPolozkuButton.Size = new System.Drawing.Size(177, 43);
			this.odebratPolozkuButton.TabIndex = 3;
			this.odebratPolozkuButton.Text = "Odebrat položku";
			this.odebratPolozkuButton.UseVisualStyleBackColor = true;
			this.odebratPolozkuButton.Click += new System.EventHandler(this.odebratPolozkuButton_Click);
			// 
			// pridatTextBox
			// 
			this.pridatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pridatTextBox.Location = new System.Drawing.Point(58, 61);
			this.pridatTextBox.Name = "pridatTextBox";
			this.pridatTextBox.Size = new System.Drawing.Size(615, 25);
			this.pridatTextBox.TabIndex = 4;
			// 
			// polozkyListBox
			// 
			this.polozkyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.polozkyListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.polozkyListBox.FormattingEnabled = true;
			this.polozkyListBox.ItemHeight = 20;
			this.polozkyListBox.Location = new System.Drawing.Point(58, 131);
			this.polozkyListBox.Name = "polozkyListBox";
			this.polozkyListBox.Size = new System.Drawing.Size(720, 284);
			this.polozkyListBox.TabIndex = 5;
			// 
			// PolozkaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 522);
			this.Controls.Add(this.polozkyListBox);
			this.Controls.Add(this.pridatTextBox);
			this.Controls.Add(this.odebratPolozkuButton);
			this.Controls.Add(this.pridatButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "PolozkaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nákupní seznam";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Button pridatButton;
		private Button odebratPolozkuButton;
		private TextBox pridatTextBox;
		private ListBox polozkyListBox;
	}
}