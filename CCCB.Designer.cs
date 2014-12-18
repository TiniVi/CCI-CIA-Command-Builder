namespace CommandBuilder
{
    partial class CCCB
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
            this.cciMode = new System.Windows.Forms.RadioButton();
            this.ciaMode = new System.Windows.Forms.RadioButton();
            this.exheaderButton = new System.Windows.Forms.Button();
            this.codeButton = new System.Windows.Forms.Button();
            this.bannerButton = new System.Windows.Forms.Button();
            this.iconButton = new System.Windows.Forms.Button();
            this.rsfButton = new System.Windows.Forms.Button();
            this.exheaderText = new System.Windows.Forms.TextBox();
            this.codeText = new System.Windows.Forms.TextBox();
            this.bannerText = new System.Windows.Forms.TextBox();
            this.iconText = new System.Windows.Forms.TextBox();
            this.rsfText = new System.Windows.Forms.TextBox();
            this.romfsButton = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.useManual = new System.Windows.Forms.CheckBox();
            this.useUpdate = new System.Windows.Forms.CheckBox();
            this.useRomFS = new System.Windows.Forms.CheckBox();
            this.manualText = new System.Windows.Forms.TextBox();
            this.updateText = new System.Windows.Forms.TextBox();
            this.romfsText = new System.Windows.Forms.TextBox();
            this.commandText = new System.Windows.Forms.RichTextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.commandLabel = new System.Windows.Forms.Label();
            this.alignwr = new System.Windows.Forms.CheckBox();
            this.createCommand = new System.Windows.Forms.Button();
            this.useELF = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.quotation = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.outputButton = new System.Windows.Forms.Button();
            this.computeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fwNumber = new System.Windows.Forms.TextBox();
            this.fwLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cciMode
            // 
            this.cciMode.AutoSize = true;
            this.cciMode.Location = new System.Drawing.Point(12, 12);
            this.cciMode.Name = "cciMode";
            this.cciMode.Size = new System.Drawing.Size(42, 17);
            this.cciMode.TabIndex = 0;
            this.cciMode.TabStop = true;
            this.cciMode.Text = "CCI";
            this.cciMode.UseVisualStyleBackColor = true;
            // 
            // ciaMode
            // 
            this.ciaMode.AutoSize = true;
            this.ciaMode.Location = new System.Drawing.Point(12, 35);
            this.ciaMode.Name = "ciaMode";
            this.ciaMode.Size = new System.Drawing.Size(42, 17);
            this.ciaMode.TabIndex = 1;
            this.ciaMode.TabStop = true;
            this.ciaMode.Text = "CIA";
            this.ciaMode.UseVisualStyleBackColor = true;
            this.ciaMode.CheckedChanged += new System.EventHandler(this.ciaMode_CheckedChanged);
            // 
            // exheaderButton
            // 
            this.exheaderButton.Location = new System.Drawing.Point(12, 58);
            this.exheaderButton.Name = "exheaderButton";
            this.exheaderButton.Size = new System.Drawing.Size(75, 23);
            this.exheaderButton.TabIndex = 2;
            this.exheaderButton.Text = "ExHeader";
            this.exheaderButton.UseVisualStyleBackColor = true;
            this.exheaderButton.Click += new System.EventHandler(this.exheaderButton_Click);
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(12, 87);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(75, 23);
            this.codeButton.TabIndex = 3;
            this.codeButton.Text = ".code/ELF";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // bannerButton
            // 
            this.bannerButton.Location = new System.Drawing.Point(12, 116);
            this.bannerButton.Name = "bannerButton";
            this.bannerButton.Size = new System.Drawing.Size(75, 23);
            this.bannerButton.TabIndex = 4;
            this.bannerButton.Text = "Banner";
            this.bannerButton.UseVisualStyleBackColor = true;
            this.bannerButton.Click += new System.EventHandler(this.bannerButton_Click);
            // 
            // iconButton
            // 
            this.iconButton.Location = new System.Drawing.Point(12, 145);
            this.iconButton.Name = "iconButton";
            this.iconButton.Size = new System.Drawing.Size(75, 23);
            this.iconButton.TabIndex = 5;
            this.iconButton.Text = "Icon";
            this.iconButton.UseVisualStyleBackColor = true;
            this.iconButton.Click += new System.EventHandler(this.iconButton_Click);
            // 
            // rsfButton
            // 
            this.rsfButton.Location = new System.Drawing.Point(12, 174);
            this.rsfButton.Name = "rsfButton";
            this.rsfButton.Size = new System.Drawing.Size(75, 23);
            this.rsfButton.TabIndex = 6;
            this.rsfButton.Text = "rsf";
            this.rsfButton.UseVisualStyleBackColor = true;
            this.rsfButton.Click += new System.EventHandler(this.rsfButton_Click);
            // 
            // exheaderText
            // 
            this.exheaderText.Location = new System.Drawing.Point(94, 60);
            this.exheaderText.Name = "exheaderText";
            this.exheaderText.Size = new System.Drawing.Size(178, 20);
            this.exheaderText.TabIndex = 7;
            // 
            // codeText
            // 
            this.codeText.Location = new System.Drawing.Point(94, 89);
            this.codeText.Name = "codeText";
            this.codeText.Size = new System.Drawing.Size(178, 20);
            this.codeText.TabIndex = 8;
            // 
            // bannerText
            // 
            this.bannerText.Location = new System.Drawing.Point(94, 118);
            this.bannerText.Name = "bannerText";
            this.bannerText.Size = new System.Drawing.Size(178, 20);
            this.bannerText.TabIndex = 9;
            // 
            // iconText
            // 
            this.iconText.Location = new System.Drawing.Point(94, 147);
            this.iconText.Name = "iconText";
            this.iconText.Size = new System.Drawing.Size(178, 20);
            this.iconText.TabIndex = 10;
            // 
            // rsfText
            // 
            this.rsfText.Location = new System.Drawing.Point(94, 177);
            this.rsfText.Name = "rsfText";
            this.rsfText.Size = new System.Drawing.Size(178, 20);
            this.rsfText.TabIndex = 11;
            // 
            // romfsButton
            // 
            this.romfsButton.Enabled = false;
            this.romfsButton.Location = new System.Drawing.Point(289, 172);
            this.romfsButton.Name = "romfsButton";
            this.romfsButton.Size = new System.Drawing.Size(75, 23);
            this.romfsButton.TabIndex = 12;
            this.romfsButton.Text = "RomFS";
            this.romfsButton.UseVisualStyleBackColor = true;
            this.romfsButton.Click += new System.EventHandler(this.romfsButton_Click);
            // 
            // manualButton
            // 
            this.manualButton.Enabled = false;
            this.manualButton.Location = new System.Drawing.Point(289, 68);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(75, 23);
            this.manualButton.TabIndex = 13;
            this.manualButton.Text = "Manual";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(289, 120);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // useManual
            // 
            this.useManual.AutoSize = true;
            this.useManual.Location = new System.Drawing.Point(289, 45);
            this.useManual.Name = "useManual";
            this.useManual.Size = new System.Drawing.Size(124, 17);
            this.useManual.TabIndex = 15;
            this.useManual.Text = "Use Manual Partition";
            this.useManual.UseVisualStyleBackColor = true;
            this.useManual.CheckedChanged += new System.EventHandler(this.useManual_CheckedChanged);
            // 
            // useUpdate
            // 
            this.useUpdate.AutoSize = true;
            this.useUpdate.Location = new System.Drawing.Point(289, 97);
            this.useUpdate.Name = "useUpdate";
            this.useUpdate.Size = new System.Drawing.Size(124, 17);
            this.useUpdate.TabIndex = 16;
            this.useUpdate.Text = "Use Update Partition";
            this.useUpdate.UseVisualStyleBackColor = true;
            this.useUpdate.CheckedChanged += new System.EventHandler(this.useUpdate_CheckedChanged);
            // 
            // useRomFS
            // 
            this.useRomFS.AutoSize = true;
            this.useRomFS.Location = new System.Drawing.Point(289, 149);
            this.useRomFS.Name = "useRomFS";
            this.useRomFS.Size = new System.Drawing.Size(130, 17);
            this.useRomFS.TabIndex = 17;
            this.useRomFS.Text = "Load RomFS from File";
            this.useRomFS.UseVisualStyleBackColor = true;
            this.useRomFS.CheckedChanged += new System.EventHandler(this.useRomFS_CheckedChanged);
            // 
            // manualText
            // 
            this.manualText.Enabled = false;
            this.manualText.Location = new System.Drawing.Point(371, 68);
            this.manualText.Name = "manualText";
            this.manualText.Size = new System.Drawing.Size(178, 20);
            this.manualText.TabIndex = 18;
            // 
            // updateText
            // 
            this.updateText.Enabled = false;
            this.updateText.Location = new System.Drawing.Point(371, 120);
            this.updateText.Name = "updateText";
            this.updateText.Size = new System.Drawing.Size(178, 20);
            this.updateText.TabIndex = 19;
            // 
            // romfsText
            // 
            this.romfsText.Enabled = false;
            this.romfsText.Location = new System.Drawing.Point(371, 172);
            this.romfsText.Name = "romfsText";
            this.romfsText.Size = new System.Drawing.Size(178, 20);
            this.romfsText.TabIndex = 20;
            // 
            // commandText
            // 
            this.commandText.Location = new System.Drawing.Point(107, 223);
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(442, 95);
            this.commandText.TabIndex = 22;
            this.commandText.Text = "Click \"Write\" before \"Compute\"";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(169, 13);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(380, 20);
            this.outputText.TabIndex = 23;
            this.outputText.Text = "rom";
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(9, 207);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(89, 13);
            this.commandLabel.TabIndex = 25;
            this.commandLabel.Text = "Output Command";
            // 
            // alignwr
            // 
            this.alignwr.AutoSize = true;
            this.alignwr.Location = new System.Drawing.Point(12, 223);
            this.alignwr.Name = "alignwr";
            this.alignwr.Size = new System.Drawing.Size(54, 17);
            this.alignwr.TabIndex = 26;
            this.alignwr.Text = "Card2";
            this.alignwr.UseVisualStyleBackColor = true;
            // 
            // createCommand
            // 
            this.createCommand.Location = new System.Drawing.Point(12, 246);
            this.createCommand.Name = "createCommand";
            this.createCommand.Size = new System.Drawing.Size(75, 23);
            this.createCommand.TabIndex = 27;
            this.createCommand.Text = "Write";
            this.createCommand.UseVisualStyleBackColor = true;
            this.createCommand.Click += new System.EventHandler(this.createCommand_Click);
            // 
            // useELF
            // 
            this.useELF.AutoSize = true;
            this.useELF.Location = new System.Drawing.Point(60, 37);
            this.useELF.Name = "useELF";
            this.useELF.Size = new System.Drawing.Size(67, 17);
            this.useELF.TabIndex = 28;
            this.useELF.Text = "Use ELF";
            this.useELF.UseVisualStyleBackColor = true;
            this.useELF.CheckedChanged += new System.EventHandler(this.useELF_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // quotation
            // 
            this.quotation.AutoSize = true;
            this.quotation.Location = new System.Drawing.Point(115, 210);
            this.quotation.Name = "quotation";
            this.quotation.Size = new System.Drawing.Size(12, 13);
            this.quotation.TabIndex = 29;
            this.quotation.Text = "\"";
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(88, 11);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 23);
            this.outputButton.TabIndex = 30;
            this.outputButton.Text = "Output";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(12, 275);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(75, 23);
            this.computeButton.TabIndex = 31;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "By TiniVi";
            // 
            // fwNumber
            // 
            this.fwNumber.Enabled = false;
            this.fwNumber.Location = new System.Drawing.Point(150, 201);
            this.fwNumber.Name = "fwNumber";
            this.fwNumber.Size = new System.Drawing.Size(15, 20);
            this.fwNumber.TabIndex = 33;
            this.fwNumber.Text = "4";
            // 
            // fwLabel
            // 
            this.fwLabel.AutoSize = true;
            this.fwLabel.Location = new System.Drawing.Point(104, 204);
            this.fwLabel.Name = "fwLabel";
            this.fwLabel.Size = new System.Drawing.Size(49, 13);
            this.fwLabel.TabIndex = 34;
            this.fwLabel.Text = "Firmware";
            // 
            // CCCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 327);
            this.Controls.Add(this.fwNumber);
            this.Controls.Add(this.fwLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.commandText);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.quotation);
            this.Controls.Add(this.useELF);
            this.Controls.Add(this.createCommand);
            this.Controls.Add(this.alignwr);
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.romfsText);
            this.Controls.Add(this.updateText);
            this.Controls.Add(this.manualText);
            this.Controls.Add(this.useRomFS);
            this.Controls.Add(this.useUpdate);
            this.Controls.Add(this.useManual);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.romfsButton);
            this.Controls.Add(this.rsfText);
            this.Controls.Add(this.iconText);
            this.Controls.Add(this.bannerText);
            this.Controls.Add(this.codeText);
            this.Controls.Add(this.exheaderText);
            this.Controls.Add(this.rsfButton);
            this.Controls.Add(this.iconButton);
            this.Controls.Add(this.bannerButton);
            this.Controls.Add(this.codeButton);
            this.Controls.Add(this.exheaderButton);
            this.Controls.Add(this.ciaMode);
            this.Controls.Add(this.cciMode);
            this.Name = "CCCB";
            this.Text = "CCI/CIA Command Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton cciMode;
        private System.Windows.Forms.RadioButton ciaMode;
        private System.Windows.Forms.Button exheaderButton;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.Button bannerButton;
        private System.Windows.Forms.Button iconButton;
        private System.Windows.Forms.Button rsfButton;
        private System.Windows.Forms.TextBox exheaderText;
        private System.Windows.Forms.TextBox codeText;
        private System.Windows.Forms.TextBox bannerText;
        private System.Windows.Forms.TextBox iconText;
        private System.Windows.Forms.TextBox rsfText;
        private System.Windows.Forms.Button romfsButton;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.CheckBox useManual;
        private System.Windows.Forms.CheckBox useUpdate;
        private System.Windows.Forms.CheckBox useRomFS;
        private System.Windows.Forms.TextBox manualText;
        private System.Windows.Forms.TextBox updateText;
        private System.Windows.Forms.TextBox romfsText;
        private System.Windows.Forms.RichTextBox commandText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.CheckBox alignwr;
        private System.Windows.Forms.Button createCommand;
        private System.Windows.Forms.CheckBox useELF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label quotation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fwNumber;
        private System.Windows.Forms.Label fwLabel;
    }
}

