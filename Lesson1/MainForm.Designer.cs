
namespace Lesson1
{
    partial class MainForm
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
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.tooltipButton = new System.Windows.Forms.Button();
            this.pickColorButton = new System.Windows.Forms.Button();
            this.clearLineButton = new System.Windows.Forms.Button();
            this.paintLineButton = new System.Windows.Forms.Button();
            this.toggleGraphicsButton = new System.Windows.Forms.Button();
            this.lineWidthTextBox = new System.Windows.Forms.TextBox();
            this.lineWidthLabel = new System.Windows.Forms.Label();
            this.y2textBox = new System.Windows.Forms.TextBox();
            this.y2label = new System.Windows.Forms.Label();
            this.x2textBox = new System.Windows.Forms.TextBox();
            this.x2label = new System.Windows.Forms.Label();
            this.y1textBox = new System.Windows.Forms.TextBox();
            this.y1label = new System.Windows.Forms.Label();
            this.x1textBox = new System.Windows.Forms.TextBox();
            this.x1label = new System.Windows.Forms.Label();
            this.pickColorDialog = new System.Windows.Forms.ColorDialog();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.helpTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.mainControlsPage = new System.Windows.Forms.TabControl();
            this.lineControlsPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.circleRadiusTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.circleXTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.circleYTextbox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.polygonAddPointButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.polygonXTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.polygonYTextBox = new System.Windows.Forms.TextBox();
            this.polygonPointsListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.polygonWidthTextBox = new System.Windows.Forms.TextBox();
            this.controlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.mainControlsPage.SuspendLayout();
            this.lineControlsPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsGroupBox
            // 
            this.controlsGroupBox.Controls.Add(this.tooltipButton);
            this.controlsGroupBox.Controls.Add(this.pickColorButton);
            this.controlsGroupBox.Controls.Add(this.clearLineButton);
            this.controlsGroupBox.Controls.Add(this.paintLineButton);
            this.controlsGroupBox.Controls.Add(this.toggleGraphicsButton);
            this.controlsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.controlsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlsGroupBox.Size = new System.Drawing.Size(248, 193);
            this.controlsGroupBox.TabIndex = 0;
            this.controlsGroupBox.TabStop = false;
            this.controlsGroupBox.Text = "Меню";
            // 
            // tooltipButton
            // 
            this.tooltipButton.Location = new System.Drawing.Point(5, 138);
            this.tooltipButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tooltipButton.Name = "tooltipButton";
            this.tooltipButton.Size = new System.Drawing.Size(107, 23);
            this.tooltipButton.TabIndex = 14;
            this.tooltipButton.Text = "Справка";
            this.tooltipButton.UseVisualStyleBackColor = true;
            this.tooltipButton.Click += new System.EventHandler(this.tooltipButton_Click);
            // 
            // pickColorButton
            // 
            this.pickColorButton.Location = new System.Drawing.Point(5, 110);
            this.pickColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickColorButton.Name = "pickColorButton";
            this.pickColorButton.Size = new System.Drawing.Size(107, 23);
            this.pickColorButton.TabIndex = 11;
            this.pickColorButton.Text = "Выбрать цвет";
            this.pickColorButton.UseVisualStyleBackColor = true;
            this.pickColorButton.Click += new System.EventHandler(this.pickColorButton_Click);
            // 
            // clearLineButton
            // 
            this.clearLineButton.Location = new System.Drawing.Point(5, 80);
            this.clearLineButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearLineButton.Name = "clearLineButton";
            this.clearLineButton.Size = new System.Drawing.Size(107, 23);
            this.clearLineButton.TabIndex = 4;
            this.clearLineButton.Text = "Очистить";
            this.clearLineButton.UseVisualStyleBackColor = true;
            this.clearLineButton.Click += new System.EventHandler(this.clearLineButton_Click);
            // 
            // paintLineButton
            // 
            this.paintLineButton.Location = new System.Drawing.Point(5, 50);
            this.paintLineButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paintLineButton.Name = "paintLineButton";
            this.paintLineButton.Size = new System.Drawing.Size(107, 23);
            this.paintLineButton.TabIndex = 3;
            this.paintLineButton.Text = "Нарисовать";
            this.paintLineButton.UseVisualStyleBackColor = true;
            this.paintLineButton.Click += new System.EventHandler(this.paintLineButton_Click);
            // 
            // toggleGraphicsButton
            // 
            this.toggleGraphicsButton.Location = new System.Drawing.Point(5, 21);
            this.toggleGraphicsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toggleGraphicsButton.Name = "toggleGraphicsButton";
            this.toggleGraphicsButton.Size = new System.Drawing.Size(107, 23);
            this.toggleGraphicsButton.TabIndex = 0;
            this.toggleGraphicsButton.Text = "Вкл./Выкл.";
            this.toggleGraphicsButton.UseVisualStyleBackColor = true;
            this.toggleGraphicsButton.Click += new System.EventHandler(this.toggleGraphicsButton_Click);
            // 
            // lineWidthTextBox
            // 
            this.lineWidthTextBox.Location = new System.Drawing.Point(28, 127);
            this.lineWidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineWidthTextBox.Name = "lineWidthTextBox";
            this.lineWidthTextBox.Size = new System.Drawing.Size(89, 22);
            this.lineWidthTextBox.TabIndex = 13;
            // 
            // lineWidthLabel
            // 
            this.lineWidthLabel.AutoSize = true;
            this.lineWidthLabel.Location = new System.Drawing.Point(20, 107);
            this.lineWidthLabel.Name = "lineWidthLabel";
            this.lineWidthLabel.Size = new System.Drawing.Size(103, 17);
            this.lineWidthLabel.TabIndex = 12;
            this.lineWidthLabel.Text = "Ширина линии";
            // 
            // y2textBox
            // 
            this.y2textBox.Location = new System.Drawing.Point(81, 75);
            this.y2textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.y2textBox.Name = "y2textBox";
            this.y2textBox.Size = new System.Drawing.Size(37, 22);
            this.y2textBox.TabIndex = 10;
            // 
            // y2label
            // 
            this.y2label.AutoSize = true;
            this.y2label.Location = new System.Drawing.Point(72, 55);
            this.y2label.Name = "y2label";
            this.y2label.Size = new System.Drawing.Size(23, 17);
            this.y2label.TabIndex = 9;
            this.y2label.Text = "y2";
            // 
            // x2textBox
            // 
            this.x2textBox.Location = new System.Drawing.Point(28, 75);
            this.x2textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x2textBox.Name = "x2textBox";
            this.x2textBox.Size = new System.Drawing.Size(37, 22);
            this.x2textBox.TabIndex = 8;
            // 
            // x2label
            // 
            this.x2label.AutoSize = true;
            this.x2label.Location = new System.Drawing.Point(20, 55);
            this.x2label.Name = "x2label";
            this.x2label.Size = new System.Drawing.Size(22, 17);
            this.x2label.TabIndex = 7;
            this.x2label.Text = "x2";
            // 
            // y1textBox
            // 
            this.y1textBox.Location = new System.Drawing.Point(81, 30);
            this.y1textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.y1textBox.Name = "y1textBox";
            this.y1textBox.Size = new System.Drawing.Size(37, 22);
            this.y1textBox.TabIndex = 6;
            // 
            // y1label
            // 
            this.y1label.AutoSize = true;
            this.y1label.Location = new System.Drawing.Point(72, 10);
            this.y1label.Name = "y1label";
            this.y1label.Size = new System.Drawing.Size(23, 17);
            this.y1label.TabIndex = 5;
            this.y1label.Text = "y1";
            // 
            // x1textBox
            // 
            this.x1textBox.Location = new System.Drawing.Point(28, 30);
            this.x1textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.x1textBox.Name = "x1textBox";
            this.x1textBox.Size = new System.Drawing.Size(37, 22);
            this.x1textBox.TabIndex = 2;
            // 
            // x1label
            // 
            this.x1label.AutoSize = true;
            this.x1label.Location = new System.Drawing.Point(20, 10);
            this.x1label.Name = "x1label";
            this.x1label.Size = new System.Drawing.Size(22, 17);
            this.x1label.TabIndex = 1;
            this.x1label.Text = "x1";
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPictureBox.Location = new System.Drawing.Point(591, 11);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(507, 425);
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            // 
            // mainControlsPage
            // 
            this.mainControlsPage.Controls.Add(this.lineControlsPage);
            this.mainControlsPage.Controls.Add(this.tabPage2);
            this.mainControlsPage.Controls.Add(this.tabPage1);
            this.mainControlsPage.Location = new System.Drawing.Point(284, 16);
            this.mainControlsPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainControlsPage.Name = "mainControlsPage";
            this.mainControlsPage.SelectedIndex = 0;
            this.mainControlsPage.Size = new System.Drawing.Size(295, 268);
            this.mainControlsPage.TabIndex = 2;
            // 
            // lineControlsPage
            // 
            this.lineControlsPage.Controls.Add(this.lineWidthLabel);
            this.lineControlsPage.Controls.Add(this.lineWidthTextBox);
            this.lineControlsPage.Controls.Add(this.x1label);
            this.lineControlsPage.Controls.Add(this.x1textBox);
            this.lineControlsPage.Controls.Add(this.y1label);
            this.lineControlsPage.Controls.Add(this.y2textBox);
            this.lineControlsPage.Controls.Add(this.y1textBox);
            this.lineControlsPage.Controls.Add(this.y2label);
            this.lineControlsPage.Controls.Add(this.x2label);
            this.lineControlsPage.Controls.Add(this.x2textBox);
            this.lineControlsPage.Location = new System.Drawing.Point(4, 25);
            this.lineControlsPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineControlsPage.Name = "lineControlsPage";
            this.lineControlsPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lineControlsPage.Size = new System.Drawing.Size(287, 239);
            this.lineControlsPage.TabIndex = 0;
            this.lineControlsPage.Text = "Линия";
            this.lineControlsPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.circleRadiusTextBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.circleXTextbox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.circleYTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(287, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Круг";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Центр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Радиус";
            // 
            // circleRadiusTextBox
            // 
            this.circleRadiusTextBox.Location = new System.Drawing.Point(27, 106);
            this.circleRadiusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleRadiusTextBox.Name = "circleRadiusTextBox";
            this.circleRadiusTextBox.Size = new System.Drawing.Size(89, 22);
            this.circleRadiusTextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Х";
            // 
            // circleXTextbox
            // 
            this.circleXTextbox.Location = new System.Drawing.Point(20, 49);
            this.circleXTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleXTextbox.Name = "circleXTextbox";
            this.circleXTextbox.Size = new System.Drawing.Size(37, 22);
            this.circleXTextbox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "У";
            // 
            // circleYTextbox
            // 
            this.circleYTextbox.Location = new System.Drawing.Point(73, 49);
            this.circleYTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circleYTextbox.Name = "circleYTextbox";
            this.circleYTextbox.Size = new System.Drawing.Size(37, 22);
            this.circleYTextbox.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.polygonWidthTextBox);
            this.tabPage1.Controls.Add(this.polygonAddPointButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.polygonXTextBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.polygonYTextBox);
            this.tabPage1.Controls.Add(this.polygonPointsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(287, 239);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Многоугольник";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // polygonAddPointButton
            // 
            this.polygonAddPointButton.Location = new System.Drawing.Point(32, 181);
            this.polygonAddPointButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.polygonAddPointButton.Name = "polygonAddPointButton";
            this.polygonAddPointButton.Size = new System.Drawing.Size(107, 23);
            this.polygonAddPointButton.TabIndex = 22;
            this.polygonAddPointButton.Text = "Добавить";
            this.polygonAddPointButton.UseVisualStyleBackColor = true;
            this.polygonAddPointButton.Click += new System.EventHandler(this.polygonAddPointButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Х";
            // 
            // polygonXTextBox
            // 
            this.polygonXTextBox.Location = new System.Drawing.Point(32, 151);
            this.polygonXTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.polygonXTextBox.Name = "polygonXTextBox";
            this.polygonXTextBox.Size = new System.Drawing.Size(37, 22);
            this.polygonXTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "У";
            // 
            // polygonYTextBox
            // 
            this.polygonYTextBox.Location = new System.Drawing.Point(85, 151);
            this.polygonYTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.polygonYTextBox.Name = "polygonYTextBox";
            this.polygonYTextBox.Size = new System.Drawing.Size(37, 22);
            this.polygonYTextBox.TabIndex = 21;
            // 
            // polygonPointsListBox
            // 
            this.polygonPointsListBox.FormattingEnabled = true;
            this.polygonPointsListBox.ItemHeight = 16;
            this.polygonPointsListBox.Location = new System.Drawing.Point(0, 0);
            this.polygonPointsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.polygonPointsListBox.Name = "polygonPointsListBox";
            this.polygonPointsListBox.Size = new System.Drawing.Size(117, 116);
            this.polygonPointsListBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ширина";
            // 
            // polygonWidthTextBox
            // 
            this.polygonWidthTextBox.Location = new System.Drawing.Point(128, 26);
            this.polygonWidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.polygonWidthTextBox.Name = "polygonWidthTextBox";
            this.polygonWidthTextBox.Size = new System.Drawing.Size(95, 22);
            this.polygonWidthTextBox.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.mainControlsPage);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.controlsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Постройка линии";
            this.controlsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.mainControlsPage.ResumeLayout(false);
            this.lineControlsPage.ResumeLayout(false);
            this.lineControlsPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.TextBox y2textBox;
        private System.Windows.Forms.Label y2label;
        private System.Windows.Forms.TextBox x2textBox;
        private System.Windows.Forms.Label x2label;
        private System.Windows.Forms.TextBox y1textBox;
        private System.Windows.Forms.Label y1label;
        private System.Windows.Forms.Button clearLineButton;
        private System.Windows.Forms.Button paintLineButton;
        private System.Windows.Forms.TextBox x1textBox;
        private System.Windows.Forms.Label x1label;
        private System.Windows.Forms.Button toggleGraphicsButton;
        private System.Windows.Forms.Button pickColorButton;
        private System.Windows.Forms.ColorDialog pickColorDialog;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.TextBox lineWidthTextBox;
        private System.Windows.Forms.Label lineWidthLabel;
        private System.Windows.Forms.Button tooltipButton;
        private System.Windows.Forms.ToolTip helpTooltip;
        private System.Windows.Forms.TabControl mainControlsPage;
        private System.Windows.Forms.TabPage lineControlsPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox circleRadiusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox circleXTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox circleYTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox polygonPointsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox polygonXTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox polygonYTextBox;
        private System.Windows.Forms.Button polygonAddPointButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox polygonWidthTextBox;
    }
}

