
namespace SaveEditor
{
    partial class Editor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.maxStudsButton = new System.Windows.Forms.Button();
            this.setValuesButton = new System.Windows.Forms.Button();
            this.generalGrid = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savePathLabel = new System.Windows.Forms.TextBox();
            this.savePathBox = new System.Windows.Forms.TextBox();
            this.openSaveButton = new System.Windows.Forms.Button();
            this.unlockedCharactersTab = new System.Windows.Forms.TabPage();
            this.charsPathBox = new System.Windows.Forms.TextBox();
            this.charsPathLabel = new System.Windows.Forms.TextBox();
            this.openCharsButton = new System.Windows.Forms.Button();
            this.unlockCharacters = new System.Windows.Forms.Button();
            this.setCharacters = new System.Windows.Forms.Button();
            this.characterGrid = new System.Windows.Forms.DataGridView();
            this.characterNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterEnabledColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customCharactersTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.levelsTab = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checksumButton = new System.Windows.Forms.Button();
            this.checksumLabel = new System.Windows.Forms.TextBox();
            this.checksumBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.mainTabs.SuspendLayout();
            this.generalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalGrid)).BeginInit();
            this.unlockedCharactersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterGrid)).BeginInit();
            this.customCharactersTab.SuspendLayout();
            this.levelsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabs.Controls.Add(this.generalTab);
            this.mainTabs.Controls.Add(this.unlockedCharactersTab);
            this.mainTabs.Controls.Add(this.customCharactersTab);
            this.mainTabs.Controls.Add(this.levelsTab);
            this.mainTabs.ItemSize = new System.Drawing.Size(100, 20);
            this.mainTabs.Location = new System.Drawing.Point(12, 33);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(347, 435);
            this.mainTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainTabs.TabIndex = 1;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.maxStudsButton);
            this.generalTab.Controls.Add(this.setValuesButton);
            this.generalTab.Controls.Add(this.generalGrid);
            this.generalTab.Controls.Add(this.savePathLabel);
            this.generalTab.Controls.Add(this.savePathBox);
            this.generalTab.Controls.Add(this.openSaveButton);
            this.generalTab.Location = new System.Drawing.Point(4, 24);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(339, 407);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // maxStudsButton
            // 
            this.maxStudsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxStudsButton.Enabled = false;
            this.maxStudsButton.Location = new System.Drawing.Point(256, 33);
            this.maxStudsButton.Name = "maxStudsButton";
            this.maxStudsButton.Size = new System.Drawing.Size(75, 23);
            this.maxStudsButton.TabIndex = 12;
            this.maxStudsButton.Text = "Max Studs";
            this.maxStudsButton.UseVisualStyleBackColor = true;
            this.maxStudsButton.Click += new System.EventHandler(this.maxStudsButton_Click);
            // 
            // setValuesButton
            // 
            this.setValuesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setValuesButton.Enabled = false;
            this.setValuesButton.Location = new System.Drawing.Point(256, 378);
            this.setValuesButton.Name = "setValuesButton";
            this.setValuesButton.Size = new System.Drawing.Size(75, 23);
            this.setValuesButton.TabIndex = 11;
            this.setValuesButton.Text = "Set Values";
            this.setValuesButton.UseVisualStyleBackColor = true;
            this.setValuesButton.Click += new System.EventHandler(this.setValuesButton_Click);
            // 
            // generalGrid
            // 
            this.generalGrid.AllowUserToAddRows = false;
            this.generalGrid.AllowUserToDeleteRows = false;
            this.generalGrid.AllowUserToResizeColumns = false;
            this.generalGrid.AllowUserToResizeRows = false;
            this.generalGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.generalGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.generalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.valueColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.generalGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.generalGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.generalGrid.Enabled = false;
            this.generalGrid.Location = new System.Drawing.Point(6, 33);
            this.generalGrid.Name = "generalGrid";
            this.generalGrid.RowHeadersVisible = false;
            this.generalGrid.RowTemplate.Height = 23;
            this.generalGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.generalGrid.Size = new System.Drawing.Size(244, 368);
            this.generalGrid.TabIndex = 10;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.FillWeight = 0.9949229F;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // valueColumn
            // 
            this.valueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valueColumn.FillWeight = 1.005075F;
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.valueColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.valueColumn.Width = 70;
            // 
            // savePathLabel
            // 
            this.savePathLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savePathLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.savePathLabel.Location = new System.Drawing.Point(6, 9);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(80, 16);
            this.savePathLabel.TabIndex = 4;
            this.savePathLabel.Text = "Save File Path:";
            this.savePathLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // savePathBox
            // 
            this.savePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savePathBox.Location = new System.Drawing.Point(92, 6);
            this.savePathBox.Name = "savePathBox";
            this.savePathBox.PlaceholderText = "C:/";
            this.savePathBox.Size = new System.Drawing.Size(158, 23);
            this.savePathBox.TabIndex = 1;
            // 
            // openSaveButton
            // 
            this.openSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openSaveButton.Location = new System.Drawing.Point(256, 6);
            this.openSaveButton.Name = "openSaveButton";
            this.openSaveButton.Size = new System.Drawing.Size(75, 23);
            this.openSaveButton.TabIndex = 5;
            this.openSaveButton.Text = "Open...";
            this.openSaveButton.UseVisualStyleBackColor = true;
            this.openSaveButton.Click += new System.EventHandler(this.openSaveButton_Click);
            // 
            // unlockedCharactersTab
            // 
            this.unlockedCharactersTab.Controls.Add(this.charsPathBox);
            this.unlockedCharactersTab.Controls.Add(this.charsPathLabel);
            this.unlockedCharactersTab.Controls.Add(this.openCharsButton);
            this.unlockedCharactersTab.Controls.Add(this.unlockCharacters);
            this.unlockedCharactersTab.Controls.Add(this.setCharacters);
            this.unlockedCharactersTab.Controls.Add(this.characterGrid);
            this.unlockedCharactersTab.Location = new System.Drawing.Point(4, 24);
            this.unlockedCharactersTab.Name = "unlockedCharactersTab";
            this.unlockedCharactersTab.Padding = new System.Windows.Forms.Padding(3);
            this.unlockedCharactersTab.Size = new System.Drawing.Size(339, 407);
            this.unlockedCharactersTab.TabIndex = 1;
            this.unlockedCharactersTab.Text = "Unlocked Characters";
            this.unlockedCharactersTab.UseVisualStyleBackColor = true;
            // 
            // charsPathBox
            // 
            this.charsPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charsPathBox.Location = new System.Drawing.Point(92, 6);
            this.charsPathBox.Name = "charsPathBox";
            this.charsPathBox.PlaceholderText = "C:/";
            this.charsPathBox.Size = new System.Drawing.Size(158, 23);
            this.charsPathBox.TabIndex = 10;
            // 
            // charsPathLabel
            // 
            this.charsPathLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.charsPathLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.charsPathLabel.Location = new System.Drawing.Point(6, 9);
            this.charsPathLabel.Name = "charsPathLabel";
            this.charsPathLabel.Size = new System.Drawing.Size(80, 16);
            this.charsPathLabel.TabIndex = 11;
            this.charsPathLabel.Text = "Chars.txt Path:";
            this.charsPathLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // openCharsButton
            // 
            this.openCharsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openCharsButton.Location = new System.Drawing.Point(256, 6);
            this.openCharsButton.Name = "openCharsButton";
            this.openCharsButton.Size = new System.Drawing.Size(75, 23);
            this.openCharsButton.TabIndex = 12;
            this.openCharsButton.Text = "Open...";
            this.openCharsButton.UseVisualStyleBackColor = true;
            this.openCharsButton.Click += new System.EventHandler(this.openCharsButton_Click);
            // 
            // unlockCharacters
            // 
            this.unlockCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unlockCharacters.Location = new System.Drawing.Point(256, 33);
            this.unlockCharacters.Name = "unlockCharacters";
            this.unlockCharacters.Size = new System.Drawing.Size(75, 23);
            this.unlockCharacters.TabIndex = 9;
            this.unlockCharacters.Text = "Unlock All";
            this.unlockCharacters.UseVisualStyleBackColor = true;
            this.unlockCharacters.Click += new System.EventHandler(this.unlockCharacters_Click);
            // 
            // setCharacters
            // 
            this.setCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setCharacters.Location = new System.Drawing.Point(256, 363);
            this.setCharacters.Name = "setCharacters";
            this.setCharacters.Size = new System.Drawing.Size(75, 38);
            this.setCharacters.TabIndex = 8;
            this.setCharacters.Text = "Set Characters";
            this.setCharacters.UseVisualStyleBackColor = true;
            this.setCharacters.Click += new System.EventHandler(this.setCharacters_Click);
            // 
            // characterGrid
            // 
            this.characterGrid.AllowUserToAddRows = false;
            this.characterGrid.AllowUserToDeleteRows = false;
            this.characterGrid.AllowUserToResizeColumns = false;
            this.characterGrid.AllowUserToResizeRows = false;
            this.characterGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.characterGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.characterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.characterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.characterNameColumn,
            this.characterEnabledColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.characterGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.characterGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.characterGrid.Location = new System.Drawing.Point(6, 33);
            this.characterGrid.Name = "characterGrid";
            this.characterGrid.RowHeadersVisible = false;
            this.characterGrid.RowTemplate.Height = 23;
            this.characterGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.characterGrid.Size = new System.Drawing.Size(244, 368);
            this.characterGrid.TabIndex = 0;
            // 
            // characterNameColumn
            // 
            this.characterNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.characterNameColumn.FillWeight = 149.2386F;
            this.characterNameColumn.HeaderText = "Character";
            this.characterNameColumn.Name = "characterNameColumn";
            this.characterNameColumn.ReadOnly = true;
            // 
            // characterEnabledColumn
            // 
            this.characterEnabledColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.characterEnabledColumn.FillWeight = 50.76142F;
            this.characterEnabledColumn.HeaderText = "Enabled";
            this.characterEnabledColumn.Name = "characterEnabledColumn";
            this.characterEnabledColumn.Width = 55;
            // 
            // customCharactersTab
            // 
            this.customCharactersTab.Controls.Add(this.textBox1);
            this.customCharactersTab.Location = new System.Drawing.Point(4, 24);
            this.customCharactersTab.Name = "customCharactersTab";
            this.customCharactersTab.Size = new System.Drawing.Size(339, 407);
            this.customCharactersTab.TabIndex = 2;
            this.customCharactersTab.Text = "Custom Characters";
            this.customCharactersTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 16);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Coming Soon";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // levelsTab
            // 
            this.levelsTab.Controls.Add(this.textBox2);
            this.levelsTab.Location = new System.Drawing.Point(4, 24);
            this.levelsTab.Name = "levelsTab";
            this.levelsTab.Size = new System.Drawing.Size(339, 407);
            this.levelsTab.TabIndex = 3;
            this.levelsTab.Text = "Levels";
            this.levelsTab.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(339, 16);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Coming Soon";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checksumButton
            // 
            this.checksumButton.Enabled = false;
            this.checksumButton.Location = new System.Drawing.Point(176, 4);
            this.checksumButton.Name = "checksumButton";
            this.checksumButton.Size = new System.Drawing.Size(75, 23);
            this.checksumButton.TabIndex = 6;
            this.checksumButton.Text = "Regenerate";
            this.checksumButton.UseVisualStyleBackColor = true;
            this.checksumButton.Click += new System.EventHandler(this.checksumButton_Click);
            // 
            // checksumLabel
            // 
            this.checksumLabel.BackColor = System.Drawing.SystemColors.Control;
            this.checksumLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checksumLabel.Location = new System.Drawing.Point(12, 8);
            this.checksumLabel.Name = "checksumLabel";
            this.checksumLabel.Size = new System.Drawing.Size(65, 16);
            this.checksumLabel.TabIndex = 3;
            this.checksumLabel.Text = "Checksum:";
            this.checksumLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checksumBox
            // 
            this.checksumBox.Location = new System.Drawing.Point(83, 4);
            this.checksumBox.Name = "checksumBox";
            this.checksumBox.PlaceholderText = "00-00-00-00";
            this.checksumBox.ReadOnly = true;
            this.checksumBox.Size = new System.Drawing.Size(87, 23);
            this.checksumBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(272, 474);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(371, 509);
            this.Controls.Add(this.checksumLabel);
            this.Controls.Add(this.checksumBox);
            this.Controls.Add(this.checksumButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.mainTabs);
            this.Name = "Editor";
            this.Text = "LEGO Star Wars Save Editor";
            this.mainTabs.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalGrid)).EndInit();
            this.unlockedCharactersTab.ResumeLayout(false);
            this.unlockedCharactersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterGrid)).EndInit();
            this.customCharactersTab.ResumeLayout(false);
            this.customCharactersTab.PerformLayout();
            this.levelsTab.ResumeLayout(false);
            this.levelsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TextBox checksumBox;
        private System.Windows.Forms.TextBox savePathBox;
        private System.Windows.Forms.TabPage unlockedCharactersTab;
        private System.Windows.Forms.TextBox savePathLabel;
        private System.Windows.Forms.TextBox checksumLabel;
        private System.Windows.Forms.Button openSaveButton;
        private System.Windows.Forms.Button checksumButton;
        private System.Windows.Forms.Button saveButton;
        protected System.Windows.Forms.DataGridView characterGrid;
        private System.Windows.Forms.Button unlockCharacters;
        private System.Windows.Forms.Button setCharacters;
        private System.Windows.Forms.Button openCharsButton;
        private System.Windows.Forms.TextBox charsPathLabel;
        private System.Windows.Forms.TextBox charsPathBox;
        private System.Windows.Forms.TabPage customCharactersTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage levelsTab;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button maxStudsButton;
        private System.Windows.Forms.Button setValuesButton;
        protected System.Windows.Forms.DataGridView generalGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterNameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn characterEnabledColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
    }
}

