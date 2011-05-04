﻿namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	partial class SearchFilterView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sourceComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.usersComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this._searchButton = new System.Windows.Forms.Button();
			this._textTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.urlsComboBox = new System.Windows.Forms.ComboBox();
			this._dateIntervalView = new Crepido.ElmahOfflineViewer.UI.Views.Partials.DateIntervalView();
			this.SuspendLayout();
			// 
			// sourceComboBox
			// 
			this.sourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sourceComboBox.FormattingEnabled = true;
			this.sourceComboBox.Location = new System.Drawing.Point(59, 73);
			this.sourceComboBox.Name = "sourceComboBox";
			this.sourceComboBox.Size = new System.Drawing.Size(293, 21);
			this.sourceComboBox.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Source:";
			// 
			// usersComboBox
			// 
			this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.usersComboBox.FormattingEnabled = true;
			this.usersComboBox.Location = new System.Drawing.Point(397, 73);
			this.usersComboBox.Name = "usersComboBox";
			this.usersComboBox.Size = new System.Drawing.Size(293, 21);
			this.usersComboBox.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(363, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "User:";
			// 
			// _searchButton
			// 
			this._searchButton.Location = new System.Drawing.Point(997, 71);
			this._searchButton.Name = "_searchButton";
			this._searchButton.Size = new System.Drawing.Size(75, 23);
			this._searchButton.TabIndex = 11;
			this._searchButton.Text = "Search";
			this._searchButton.UseVisualStyleBackColor = true;
			this._searchButton.Click += new System.EventHandler(this.SearchButtonClick);
			// 
			// _textTextbox
			// 
			this._textTextbox.Location = new System.Drawing.Point(715, 44);
			this._textTextbox.Multiline = true;
			this._textTextbox.Name = "_textTextbox";
			this._textTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._textTextbox.Size = new System.Drawing.Size(276, 50);
			this._textTextbox.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(712, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Error message/Details contains:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Type:";
			// 
			// typeComboBox
			// 
			this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Location = new System.Drawing.Point(59, 47);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(293, 21);
			this.typeComboBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(363, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Urls:";
			// 
			// urlsComboBox
			// 
			this.urlsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.urlsComboBox.FormattingEnabled = true;
			this.urlsComboBox.Location = new System.Drawing.Point(397, 44);
			this.urlsComboBox.Name = "urlsComboBox";
			this.urlsComboBox.Size = new System.Drawing.Size(293, 21);
			this.urlsComboBox.TabIndex = 4;
			// 
			// _dateIntervalView
			// 
			this._dateIntervalView.Location = new System.Drawing.Point(59, 0);
			this._dateIntervalView.Name = "_dateIntervalView";
			this._dateIntervalView.Size = new System.Drawing.Size(305, 41);
			this._dateIntervalView.TabIndex = 0;
			// 
			// SearchFilterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._dateIntervalView);
			this.Controls.Add(this.urlsComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.sourceComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.usersComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._searchButton);
			this.Controls.Add(this._textTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.typeComboBox);
			this.Name = "SearchFilterView";
			this.Size = new System.Drawing.Size(1085, 110);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox sourceComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox usersComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button _searchButton;
		private System.Windows.Forms.TextBox _textTextbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox urlsComboBox;
		private DateIntervalView _dateIntervalView;



	}
}
