namespace Cairns_Auto
{
    partial class Form1
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
            this.oilAndLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.partsAndLabourGroupBox = new System.Windows.Forms.GroupBox();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.receiptsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.tyreRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.partsLabel = new System.Windows.Forms.Label();
            this.labourLabel = new System.Windows.Forms.Label();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.labourTextBox = new System.Windows.Forms.TextBox();
            this.serviceAndLabourSummaryLabel = new System.Windows.Forms.Label();
            this.partsSummarylabel = new System.Windows.Forms.Label();
            this.taxSummaryLabel = new System.Windows.Forms.Label();
            this.totalFeesSummaryLabel = new System.Windows.Forms.Label();
            this.serviceAndLabourOutputLabel = new System.Windows.Forms.Label();
            this.partsOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.programmerLabel = new System.Windows.Forms.Label();
            this.oilAndLubeGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsAndLabourGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilAndLubeGroupBox
            // 
            this.oilAndLubeGroupBox.Controls.Add(this.lubeJobCheckBox);
            this.oilAndLubeGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilAndLubeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.oilAndLubeGroupBox.Name = "oilAndLubeGroupBox";
            this.oilAndLubeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.oilAndLubeGroupBox.TabIndex = 0;
            this.oilAndLubeGroupBox.TabStop = false;
            this.oilAndLubeGroupBox.Text = "Oil and Lube";
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.Controls.Add(this.transmissionFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiatorFlushCheckBox);
            this.flushesGroupBox.Location = new System.Drawing.Point(218, 12);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.flushesGroupBox.TabIndex = 1;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "Flushes";
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tyreRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.replaceMufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(12, 118);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(200, 100);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // partsAndLabourGroupBox
            // 
            this.partsAndLabourGroupBox.Controls.Add(this.labourTextBox);
            this.partsAndLabourGroupBox.Controls.Add(this.partsTextBox);
            this.partsAndLabourGroupBox.Controls.Add(this.labourLabel);
            this.partsAndLabourGroupBox.Controls.Add(this.partsLabel);
            this.partsAndLabourGroupBox.Location = new System.Drawing.Point(218, 118);
            this.partsAndLabourGroupBox.Name = "partsAndLabourGroupBox";
            this.partsAndLabourGroupBox.Size = new System.Drawing.Size(200, 100);
            this.partsAndLabourGroupBox.TabIndex = 3;
            this.partsAndLabourGroupBox.TabStop = false;
            this.partsAndLabourGroupBox.Text = "Parts and Labour";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalOutputLabel);
            this.summaryGroupBox.Controls.Add(this.taxOutputLabel);
            this.summaryGroupBox.Controls.Add(this.partsOutputLabel);
            this.summaryGroupBox.Controls.Add(this.serviceAndLabourOutputLabel);
            this.summaryGroupBox.Controls.Add(this.totalFeesSummaryLabel);
            this.summaryGroupBox.Controls.Add(this.taxSummaryLabel);
            this.summaryGroupBox.Controls.Add(this.partsSummarylabel);
            this.summaryGroupBox.Controls.Add(this.serviceAndLabourSummaryLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(52, 224);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(293, 150);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(39, 394);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // receiptsButton
            // 
            this.receiptsButton.Location = new System.Drawing.Point(121, 394);
            this.receiptsButton.Name = "receiptsButton";
            this.receiptsButton.Size = new System.Drawing.Size(75, 23);
            this.receiptsButton.TabIndex = 6;
            this.receiptsButton.Text = "&Receipts";
            this.receiptsButton.UseVisualStyleBackColor = true;
            this.receiptsButton.Click += new System.EventHandler(this.receiptsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(203, 394);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(285, 394);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(7, 20);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(105, 17);
            this.oilChangeCheckBox.TabIndex = 0;
            this.oilChangeCheckBox.Text = "Oil Change (€26)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(7, 44);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(97, 17);
            this.lubeJobCheckBox.TabIndex = 1;
            this.lubeJobCheckBox.Text = "Lube Job (€18)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(7, 20);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(121, 17);
            this.radiatorFlushCheckBox.TabIndex = 0;
            this.radiatorFlushCheckBox.Text = "Radiator Flush (€30)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(7, 44);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(142, 17);
            this.transmissionFlushCheckBox.TabIndex = 1;
            this.transmissionFlushCheckBox.Text = "Transmission Flush (€80)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(7, 20);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(102, 17);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection (€15)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(7, 44);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(134, 17);
            this.replaceMufflerCheckBox.TabIndex = 1;
            this.replaceMufflerCheckBox.Text = "Replace Muffler (€100)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // tyreRotationCheckBox
            // 
            this.tyreRotationCheckBox.AutoSize = true;
            this.tyreRotationCheckBox.Location = new System.Drawing.Point(7, 68);
            this.tyreRotationCheckBox.Name = "tyreRotationCheckBox";
            this.tyreRotationCheckBox.Size = new System.Drawing.Size(117, 17);
            this.tyreRotationCheckBox.TabIndex = 2;
            this.tyreRotationCheckBox.Text = "Tyre Rotation (€20)";
            this.tyreRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(6, 30);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(46, 13);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts (€)";
            // 
            // labourLabel
            // 
            this.labourLabel.AutoSize = true;
            this.labourLabel.Location = new System.Drawing.Point(6, 58);
            this.labourLabel.Name = "labourLabel";
            this.labourLabel.Size = new System.Drawing.Size(55, 13);
            this.labourLabel.TabIndex = 1;
            this.labourLabel.Text = "Labour (€)";
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(88, 27);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(100, 20);
            this.partsTextBox.TabIndex = 2;
            // 
            // labourTextBox
            // 
            this.labourTextBox.Location = new System.Drawing.Point(88, 55);
            this.labourTextBox.Name = "labourTextBox";
            this.labourTextBox.Size = new System.Drawing.Size(100, 20);
            this.labourTextBox.TabIndex = 3;
            // 
            // serviceAndLabourSummaryLabel
            // 
            this.serviceAndLabourSummaryLabel.AutoSize = true;
            this.serviceAndLabourSummaryLabel.Location = new System.Drawing.Point(7, 31);
            this.serviceAndLabourSummaryLabel.Name = "serviceAndLabourSummaryLabel";
            this.serviceAndLabourSummaryLabel.Size = new System.Drawing.Size(100, 13);
            this.serviceAndLabourSummaryLabel.TabIndex = 0;
            this.serviceAndLabourSummaryLabel.Text = "Service and Labour";
            // 
            // partsSummarylabel
            // 
            this.partsSummarylabel.AutoSize = true;
            this.partsSummarylabel.Location = new System.Drawing.Point(7, 60);
            this.partsSummarylabel.Name = "partsSummarylabel";
            this.partsSummarylabel.Size = new System.Drawing.Size(31, 13);
            this.partsSummarylabel.TabIndex = 1;
            this.partsSummarylabel.Text = "Parts";
            // 
            // taxSummaryLabel
            // 
            this.taxSummaryLabel.AutoSize = true;
            this.taxSummaryLabel.Location = new System.Drawing.Point(7, 89);
            this.taxSummaryLabel.Name = "taxSummaryLabel";
            this.taxSummaryLabel.Size = new System.Drawing.Size(72, 13);
            this.taxSummaryLabel.TabIndex = 2;
            this.taxSummaryLabel.Text = "Tax (on parts)";
            // 
            // totalFeesSummaryLabel
            // 
            this.totalFeesSummaryLabel.AutoSize = true;
            this.totalFeesSummaryLabel.Location = new System.Drawing.Point(7, 118);
            this.totalFeesSummaryLabel.Name = "totalFeesSummaryLabel";
            this.totalFeesSummaryLabel.Size = new System.Drawing.Size(57, 13);
            this.totalFeesSummaryLabel.TabIndex = 3;
            this.totalFeesSummaryLabel.Text = "Total Fees";
            // 
            // serviceAndLabourOutputLabel
            // 
            this.serviceAndLabourOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceAndLabourOutputLabel.Location = new System.Drawing.Point(113, 30);
            this.serviceAndLabourOutputLabel.Name = "serviceAndLabourOutputLabel";
            this.serviceAndLabourOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.serviceAndLabourOutputLabel.TabIndex = 4;
            // 
            // partsOutputLabel
            // 
            this.partsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsOutputLabel.Location = new System.Drawing.Point(113, 59);
            this.partsOutputLabel.Name = "partsOutputLabel";
            this.partsOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.partsOutputLabel.TabIndex = 5;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxOutputLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.taxOutputLabel.Location = new System.Drawing.Point(113, 88);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.taxOutputLabel.TabIndex = 6;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalOutputLabel.Location = new System.Drawing.Point(113, 117);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalOutputLabel.TabIndex = 7;
            // 
            // programmerLabel
            // 
            this.programmerLabel.AutoSize = true;
            this.programmerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmerLabel.Location = new System.Drawing.Point(304, 434);
            this.programmerLabel.Name = "programmerLabel";
            this.programmerLabel.Size = new System.Drawing.Size(122, 9);
            this.programmerLabel.TabIndex = 9;
            this.programmerLabel.Text = "Programmed by Merlin Bierekofen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 452);
            this.Controls.Add(this.programmerLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.receiptsButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.partsAndLabourGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.oilAndLubeGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.oilAndLubeGroupBox.ResumeLayout(false);
            this.oilAndLubeGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsAndLabourGroupBox.ResumeLayout(false);
            this.partsAndLabourGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox oilAndLubeGroupBox;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox tyreRotationCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox partsAndLabourGroupBox;
        private System.Windows.Forms.TextBox labourTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label labourLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label partsOutputLabel;
        private System.Windows.Forms.Label serviceAndLabourOutputLabel;
        private System.Windows.Forms.Label totalFeesSummaryLabel;
        private System.Windows.Forms.Label taxSummaryLabel;
        private System.Windows.Forms.Label partsSummarylabel;
        private System.Windows.Forms.Label serviceAndLabourSummaryLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button receiptsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label programmerLabel;
    }
}

