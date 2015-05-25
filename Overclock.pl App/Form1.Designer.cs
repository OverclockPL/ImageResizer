namespace Overclock.pl_App
{
    partial class mainForm
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
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.info_menuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImages_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.articleTitle_textBox = new System.Windows.Forms.TextBox();
            this.articleDescription_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clearLoadedImagesList = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.articleDetails = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.generateHTML_button = new System.Windows.Forms.Button();
            this.HTMLinNewWindow_CheckBox = new System.Windows.Forms.CheckBox();
            this.HTMLToFile_CheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cataloguesCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.width1280_ratio = new System.Windows.Forms.RadioButton();
            this.width1024_ratio = new System.Windows.Forms.RadioButton();
            this.addLogo_checkBox = new System.Windows.Forms.CheckBox();
            this.generateBigImages_button = new System.Windows.Forms.Button();
            this.widthManual_ratio = new System.Windows.Forms.RadioButton();
            this.manualWidth = new System.Windows.Forms.TextBox();
            this.manualSize_description = new System.Windows.Forms.Label();
            this.manualSize_description2 = new System.Windows.Forms.Label();
            this.generateMiniatures_CheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.originalFilename_CheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.articleDetails.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info_menuTool,
            this.zamknijToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // info_menuTool
            // 
            this.info_menuTool.Name = "info_menuTool";
            this.info_menuTool.Size = new System.Drawing.Size(131, 22);
            this.info_menuTool.Text = "Informacje";
            this.info_menuTool.Click += new System.EventHandler(this.info_action);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            // 
            // openImages_button
            // 
            this.openImages_button.Location = new System.Drawing.Point(279, 84);
            this.openImages_button.Name = "openImages_button";
            this.openImages_button.Size = new System.Drawing.Size(126, 28);
            this.openImages_button.TabIndex = 0;
            this.openImages_button.Text = "Wczytaj zdjęcia";
            this.openImages_button.UseVisualStyleBackColor = true;
            this.openImages_button.Click += new System.EventHandler(this.openFile_action);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tytuł artykułu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Krótki opis artykułu";
            // 
            // articleTitle_textBox
            // 
            this.articleTitle_textBox.Location = new System.Drawing.Point(134, 32);
            this.articleTitle_textBox.Name = "articleTitle_textBox";
            this.articleTitle_textBox.Size = new System.Drawing.Size(268, 20);
            this.articleTitle_textBox.TabIndex = 28;
            // 
            // articleDescription_textBox
            // 
            this.articleDescription_textBox.Location = new System.Drawing.Point(134, 58);
            this.articleDescription_textBox.Name = "articleDescription_textBox";
            this.articleDescription_textBox.Size = new System.Drawing.Size(268, 20);
            this.articleDescription_textBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "O programie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.info_action);
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(134, 6);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(268, 20);
            this.address_textBox.TabIndex = 33;
            this.address_textBox.Text = "2014/03/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(9, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Adres na serwerze";
            // 
            // clearLoadedImagesList
            // 
            this.clearLoadedImagesList.Enabled = false;
            this.clearLoadedImagesList.Location = new System.Drawing.Point(147, 84);
            this.clearLoadedImagesList.Name = "clearLoadedImagesList";
            this.clearLoadedImagesList.Size = new System.Drawing.Size(126, 28);
            this.clearLoadedImagesList.TabIndex = 42;
            this.clearLoadedImagesList.Text = "Wyczyść listę zdjęć";
            this.clearLoadedImagesList.UseVisualStyleBackColor = true;
            this.clearLoadedImagesList.Click += new System.EventHandler(this.clearLoadedImagesList_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(414, 22);
            this.statusStrip1.TabIndex = 58;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel.Text = "Gotowy";
            // 
            // articleDetails
            // 
            this.articleDetails.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.articleDetails.Controls.Add(this.label8);
            this.articleDetails.Controls.Add(this.address_textBox);
            this.articleDetails.Controls.Add(this.articleTitle_textBox);
            this.articleDetails.Controls.Add(this.clearLoadedImagesList);
            this.articleDetails.Controls.Add(this.articleDescription_textBox);
            this.articleDetails.Controls.Add(this.label1);
            this.articleDetails.Controls.Add(this.openImages_button);
            this.articleDetails.Controls.Add(this.label7);
            this.articleDetails.Location = new System.Drawing.Point(3, 3);
            this.articleDetails.Name = "articleDetails";
            this.articleDetails.Size = new System.Drawing.Size(408, 122);
            this.articleDetails.TabIndex = 59;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.generateHTML_button);
            this.tabPage2.Controls.Add(this.HTMLinNewWindow_CheckBox);
            this.tabPage2.Controls.Add(this.HTMLToFile_CheckBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 156);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generuj HTML";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // generateHTML_button
            // 
            this.generateHTML_button.Location = new System.Drawing.Point(6, 52);
            this.generateHTML_button.Name = "generateHTML_button";
            this.generateHTML_button.Size = new System.Drawing.Size(129, 27);
            this.generateHTML_button.TabIndex = 31;
            this.generateHTML_button.Text = "Generuj kod HTML";
            this.generateHTML_button.UseVisualStyleBackColor = true;
            this.generateHTML_button.Click += new System.EventHandler(this.generateHTML_action);
            // 
            // HTMLinNewWindow_CheckBox
            // 
            this.HTMLinNewWindow_CheckBox.AutoSize = true;
            this.HTMLinNewWindow_CheckBox.Checked = true;
            this.HTMLinNewWindow_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HTMLinNewWindow_CheckBox.Location = new System.Drawing.Point(6, 6);
            this.HTMLinNewWindow_CheckBox.Name = "HTMLinNewWindow_CheckBox";
            this.HTMLinNewWindow_CheckBox.Size = new System.Drawing.Size(165, 17);
            this.HTMLinNewWindow_CheckBox.TabIndex = 40;
            this.HTMLinNewWindow_CheckBox.Text = "Wyświetl kod w nowym oknie";
            this.HTMLinNewWindow_CheckBox.UseVisualStyleBackColor = true;
            // 
            // HTMLToFile_CheckBox
            // 
            this.HTMLToFile_CheckBox.AutoSize = true;
            this.HTMLToFile_CheckBox.Location = new System.Drawing.Point(6, 29);
            this.HTMLToFile_CheckBox.Name = "HTMLToFile_CheckBox";
            this.HTMLToFile_CheckBox.Size = new System.Drawing.Size(359, 17);
            this.HTMLToFile_CheckBox.TabIndex = 47;
            this.HTMLToFile_CheckBox.Text = "Zapisz kod do pliku (kod_wynikowy.txt w katalogu głównym programu)";
            this.HTMLToFile_CheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cataloguesCheckBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.width1280_ratio);
            this.tabPage1.Controls.Add(this.width1024_ratio);
            this.tabPage1.Controls.Add(this.addLogo_checkBox);
            this.tabPage1.Controls.Add(this.generateBigImages_button);
            this.tabPage1.Controls.Add(this.widthManual_ratio);
            this.tabPage1.Controls.Add(this.manualWidth);
            this.tabPage1.Controls.Add(this.manualSize_description);
            this.tabPage1.Controls.Add(this.manualSize_description2);
            this.tabPage1.Controls.Add(this.generateMiniatures_CheckBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.originalFilename_CheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 156);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zmniejsz zdjęcia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cataloguesCheckBox
            // 
            this.cataloguesCheckBox.AutoSize = true;
            this.cataloguesCheckBox.Location = new System.Drawing.Point(158, 55);
            this.cataloguesCheckBox.Name = "cataloguesCheckBox";
            this.cataloguesCheckBox.Size = new System.Drawing.Size(179, 17);
            this.cataloguesCheckBox.TabIndex = 47;
            this.cataloguesCheckBox.Text = "Podziel na katalogi: big oraz mini";
            this.cataloguesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(2, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Szerokość:";
            // 
            // width1280_ratio
            // 
            this.width1280_ratio.AutoSize = true;
            this.width1280_ratio.Checked = true;
            this.width1280_ratio.Location = new System.Drawing.Point(9, 31);
            this.width1280_ratio.Name = "width1280_ratio";
            this.width1280_ratio.Size = new System.Drawing.Size(81, 17);
            this.width1280_ratio.TabIndex = 3;
            this.width1280_ratio.TabStop = true;
            this.width1280_ratio.Text = "1280 pikseli";
            this.width1280_ratio.UseVisualStyleBackColor = true;
            // 
            // width1024_ratio
            // 
            this.width1024_ratio.AutoSize = true;
            this.width1024_ratio.Location = new System.Drawing.Point(9, 54);
            this.width1024_ratio.Name = "width1024_ratio";
            this.width1024_ratio.Size = new System.Drawing.Size(81, 17);
            this.width1024_ratio.TabIndex = 4;
            this.width1024_ratio.Text = "1024 pikseli";
            this.width1024_ratio.UseVisualStyleBackColor = true;
            // 
            // addLogo_checkBox
            // 
            this.addLogo_checkBox.AutoSize = true;
            this.addLogo_checkBox.Checked = true;
            this.addLogo_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addLogo_checkBox.Location = new System.Drawing.Point(158, 76);
            this.addLogo_checkBox.Name = "addLogo_checkBox";
            this.addLogo_checkBox.Size = new System.Drawing.Size(140, 17);
            this.addLogo_checkBox.TabIndex = 7;
            this.addLogo_checkBox.Text = "Dodaj logo Overclock.pl";
            this.addLogo_checkBox.UseVisualStyleBackColor = true;
            // 
            // generateBigImages_button
            // 
            this.generateBigImages_button.Location = new System.Drawing.Point(6, 123);
            this.generateBigImages_button.Name = "generateBigImages_button";
            this.generateBigImages_button.Size = new System.Drawing.Size(129, 27);
            this.generateBigImages_button.TabIndex = 8;
            this.generateBigImages_button.Text = "Generuj fotki";
            this.generateBigImages_button.UseVisualStyleBackColor = true;
            this.generateBigImages_button.Click += new System.EventHandler(this.generateImages_action);
            // 
            // widthManual_ratio
            // 
            this.widthManual_ratio.AutoSize = true;
            this.widthManual_ratio.Location = new System.Drawing.Point(9, 77);
            this.widthManual_ratio.Name = "widthManual_ratio";
            this.widthManual_ratio.Size = new System.Drawing.Size(14, 13);
            this.widthManual_ratio.TabIndex = 35;
            this.widthManual_ratio.UseVisualStyleBackColor = true;
            this.widthManual_ratio.CheckedChanged += new System.EventHandler(this.widthManual_ratio_CheckedChanged);
            // 
            // manualWidth
            // 
            this.manualWidth.Enabled = false;
            this.manualWidth.Location = new System.Drawing.Point(29, 77);
            this.manualWidth.Name = "manualWidth";
            this.manualWidth.Size = new System.Drawing.Size(45, 20);
            this.manualWidth.TabIndex = 36;
            // 
            // manualSize_description
            // 
            this.manualSize_description.AutoSize = true;
            this.manualSize_description.Location = new System.Drawing.Point(77, 80);
            this.manualSize_description.Name = "manualSize_description";
            this.manualSize_description.Size = new System.Drawing.Size(36, 13);
            this.manualSize_description.TabIndex = 37;
            this.manualSize_description.Text = "pikseli";
            // 
            // manualSize_description2
            // 
            this.manualSize_description2.AutoSize = true;
            this.manualSize_description2.Enabled = false;
            this.manualSize_description2.Location = new System.Drawing.Point(80, 80);
            this.manualSize_description2.Name = "manualSize_description2";
            this.manualSize_description2.Size = new System.Drawing.Size(0, 13);
            this.manualSize_description2.TabIndex = 39;
            // 
            // generateMiniatures_CheckBox
            // 
            this.generateMiniatures_CheckBox.AutoSize = true;
            this.generateMiniatures_CheckBox.Checked = true;
            this.generateMiniatures_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.generateMiniatures_CheckBox.Location = new System.Drawing.Point(158, 99);
            this.generateMiniatures_CheckBox.Name = "generateMiniatures_CheckBox";
            this.generateMiniatures_CheckBox.Size = new System.Drawing.Size(169, 17);
            this.generateMiniatures_CheckBox.TabIndex = 41;
            this.generateMiniatures_CheckBox.Text = "Generuj miniaturki (250 pikseli)";
            this.generateMiniatures_CheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(155, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Szczegóły:";
            // 
            // originalFilename_CheckBox
            // 
            this.originalFilename_CheckBox.AutoSize = true;
            this.originalFilename_CheckBox.Location = new System.Drawing.Point(158, 32);
            this.originalFilename_CheckBox.Name = "originalFilename_CheckBox";
            this.originalFilename_CheckBox.Size = new System.Drawing.Size(190, 17);
            this.originalFilename_CheckBox.TabIndex = 46;
            this.originalFilename_CheckBox.Text = "Zachowaj oryginalne nazwy plików";
            this.originalFilename_CheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(3, 131);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(408, 182);
            this.tabControl.TabIndex = 60;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 374);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.articleDetails);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Overclock.pl App";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.articleDetails.ResumeLayout(false);
            this.articleDetails.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem info_menuTool;
        private System.Windows.Forms.Button openImages_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox articleTitle_textBox;
        private System.Windows.Forms.TextBox articleDescription_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearLoadedImagesList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel articleDetails;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button generateHTML_button;
        private System.Windows.Forms.CheckBox HTMLinNewWindow_CheckBox;
        private System.Windows.Forms.CheckBox HTMLToFile_CheckBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cataloguesCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton width1280_ratio;
        private System.Windows.Forms.RadioButton width1024_ratio;
        private System.Windows.Forms.CheckBox addLogo_checkBox;
        private System.Windows.Forms.Button generateBigImages_button;
        private System.Windows.Forms.RadioButton widthManual_ratio;
        private System.Windows.Forms.TextBox manualWidth;
        private System.Windows.Forms.Label manualSize_description;
        private System.Windows.Forms.Label manualSize_description2;
        private System.Windows.Forms.CheckBox generateMiniatures_CheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox originalFilename_CheckBox;
        private System.Windows.Forms.TabControl tabControl;
    }
}

