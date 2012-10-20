namespace WindowsFormsApplication1
{
    partial class formAmazonPrice
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
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.grpBoxFilter = new System.Windows.Forms.GroupBox();
            this.radBtnNone = new System.Windows.Forms.RadioButton();
            this.radBtnLess = new System.Windows.Forms.RadioButton();
            this.radBtnMore = new System.Windows.Forms.RadioButton();
            this.panelResults = new System.Windows.Forms.Panel();
            this.tblResults = new System.Windows.Forms.TableLayoutPanel();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAmazon = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.chkBoxMod1 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnSub = new System.Windows.Forms.RadioButton();
            this.radBtnAdd = new System.Windows.Forms.RadioButton();
            this.txtBoxSub = new System.Windows.Forms.TextBox();
            this.txtBoxAdd = new System.Windows.Forms.TextBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.grpBoxFilter.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.tblResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "Price (low to high)",
            "Price (high to low)",
            "Difference (low to high)",
            "Difference (high to low)"});
            this.comboBoxSort.Location = new System.Drawing.Point(58, 21);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSort.TabIndex = 1;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(12, 24);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(40, 13);
            this.lblSort.TabIndex = 2;
            this.lblSort.Text = "Sort by";
            // 
            // grpBoxFilter
            // 
            this.grpBoxFilter.Controls.Add(this.radBtnMore);
            this.grpBoxFilter.Controls.Add(this.radBtnLess);
            this.grpBoxFilter.Controls.Add(this.radBtnNone);
            this.grpBoxFilter.Location = new System.Drawing.Point(198, 21);
            this.grpBoxFilter.Name = "grpBoxFilter";
            this.grpBoxFilter.Size = new System.Drawing.Size(200, 100);
            this.grpBoxFilter.TabIndex = 5;
            this.grpBoxFilter.TabStop = false;
            this.grpBoxFilter.Text = "Filter results";
            // 
            // radBtnNone
            // 
            this.radBtnNone.AutoSize = true;
            this.radBtnNone.Location = new System.Drawing.Point(16, 19);
            this.radBtnNone.Name = "radBtnNone";
            this.radBtnNone.Size = new System.Drawing.Size(61, 17);
            this.radBtnNone.TabIndex = 0;
            this.radBtnNone.TabStop = true;
            this.radBtnNone.Text = "No filter";
            this.radBtnNone.UseVisualStyleBackColor = true;
            // 
            // radBtnLess
            // 
            this.radBtnLess.AutoSize = true;
            this.radBtnLess.Location = new System.Drawing.Point(16, 65);
            this.radBtnLess.Name = "radBtnLess";
            this.radBtnLess.Size = new System.Drawing.Size(161, 17);
            this.radBtnLess.TabIndex = 1;
            this.radBtnLess.TabStop = true;
            this.radBtnLess.Text = "Items that are less expensive";
            this.radBtnLess.UseVisualStyleBackColor = true;
            // 
            // radBtnMore
            // 
            this.radBtnMore.AutoSize = true;
            this.radBtnMore.Location = new System.Drawing.Point(16, 42);
            this.radBtnMore.Name = "radBtnMore";
            this.radBtnMore.Size = new System.Drawing.Size(166, 17);
            this.radBtnMore.TabIndex = 2;
            this.radBtnMore.TabStop = true;
            this.radBtnMore.Text = "Items that are more expensive";
            this.radBtnMore.UseVisualStyleBackColor = true;
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.tblResults);
            this.panelResults.Location = new System.Drawing.Point(15, 149);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(365, 170);
            this.panelResults.TabIndex = 6;
            // 
            // tblResults
            // 
            this.tblResults.ColumnCount = 5;
            this.tblResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tblResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblResults.Controls.Add(this.lblAmazon, 4, 0);
            this.tblResults.Controls.Add(this.lblPrice, 3, 0);
            this.tblResults.Controls.Add(this.lblItem, 2, 0);
            this.tblResults.Controls.Add(this.lblBarcode, 1, 0);
            this.tblResults.Controls.Add(this.chkBoxMod1, 0, 1);
            this.tblResults.Controls.Add(this.checkBox1, 0, 2);
            this.tblResults.Controls.Add(this.checkBox2, 0, 3);
            this.tblResults.Controls.Add(this.checkBox3, 0, 4);
            this.tblResults.Location = new System.Drawing.Point(3, 3);
            this.tblResults.Name = "tblResults";
            this.tblResults.RowCount = 5;
            this.tblResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblResults.Size = new System.Drawing.Size(359, 164);
            this.tblResults.TabIndex = 0;
            // 
            // lblBarcode
            // 
            this.lblBarcode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(43, 19);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(47, 13);
            this.lblBarcode.TabIndex = 7;
            this.lblBarcode.Text = "Barcode";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblItem
            // 
            this.lblItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(150, 19);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "Item";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(244, 19);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblAmazon
            // 
            this.lblAmazon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAmazon.AutoSize = true;
            this.lblAmazon.Location = new System.Drawing.Point(303, 6);
            this.lblAmazon.Name = "lblAmazon";
            this.lblAmazon.Size = new System.Drawing.Size(45, 26);
            this.lblAmazon.TabIndex = 10;
            this.lblAmazon.Text = "Amazon\r\nPrice";
            this.lblAmazon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(383, 149);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(30, 167);
            this.vScrollBar1.TabIndex = 7;
            // 
            // chkBoxMod1
            // 
            this.chkBoxMod1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkBoxMod1.AutoSize = true;
            this.chkBoxMod1.Location = new System.Drawing.Point(10, 41);
            this.chkBoxMod1.Name = "chkBoxMod1";
            this.chkBoxMod1.Size = new System.Drawing.Size(15, 14);
            this.chkBoxMod1.TabIndex = 11;
            this.chkBoxMod1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 105);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(10, 139);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMod);
            this.groupBox1.Controls.Add(this.txtBoxAdd);
            this.groupBox1.Controls.Add(this.txtBoxSub);
            this.groupBox1.Controls.Add(this.radBtnSub);
            this.groupBox1.Controls.Add(this.radBtnAdd);
            this.groupBox1.Location = new System.Drawing.Point(15, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modify selected items";
            // 
            // radBtnSub
            // 
            this.radBtnSub.AutoSize = true;
            this.radBtnSub.Location = new System.Drawing.Point(6, 42);
            this.radBtnSub.Name = "radBtnSub";
            this.radBtnSub.Size = new System.Drawing.Size(65, 17);
            this.radBtnSub.TabIndex = 4;
            this.radBtnSub.TabStop = true;
            this.radBtnSub.Text = "Subtract";
            this.radBtnSub.UseVisualStyleBackColor = true;
            // 
            // radBtnAdd
            // 
            this.radBtnAdd.AutoSize = true;
            this.radBtnAdd.Location = new System.Drawing.Point(6, 19);
            this.radBtnAdd.Name = "radBtnAdd";
            this.radBtnAdd.Size = new System.Drawing.Size(44, 17);
            this.radBtnAdd.TabIndex = 3;
            this.radBtnAdd.TabStop = true;
            this.radBtnAdd.Text = "Add";
            this.radBtnAdd.UseVisualStyleBackColor = true;
            // 
            // txtBoxSub
            // 
            this.txtBoxSub.Location = new System.Drawing.Point(77, 41);
            this.txtBoxSub.Name = "txtBoxSub";
            this.txtBoxSub.Size = new System.Drawing.Size(61, 20);
            this.txtBoxSub.TabIndex = 5;
            // 
            // txtBoxAdd
            // 
            this.txtBoxAdd.Location = new System.Drawing.Point(77, 18);
            this.txtBoxAdd.Name = "txtBoxAdd";
            this.txtBoxAdd.Size = new System.Drawing.Size(61, 20);
            this.txtBoxAdd.TabIndex = 6;
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(40, 66);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 7;
            this.btnMod.Text = "Modify";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(257, 326);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(338, 326);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(15, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 90);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Num Results";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "50 per screen";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "100 per screen";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "25 per screen";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // formAmazonPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.grpBoxFilter);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.comboBoxSort);
            this.Name = "formAmazonPrice";
            this.Text = "Amazon Price Comparison";
            this.grpBoxFilter.ResumeLayout(false);
            this.grpBoxFilter.PerformLayout();
            this.panelResults.ResumeLayout(false);
            this.tblResults.ResumeLayout(false);
            this.tblResults.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.GroupBox grpBoxFilter;
        private System.Windows.Forms.RadioButton radBtnMore;
        private System.Windows.Forms.RadioButton radBtnLess;
        private System.Windows.Forms.RadioButton radBtnNone;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.TableLayoutPanel tblResults;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblAmazon;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.CheckBox chkBoxMod1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox txtBoxAdd;
        private System.Windows.Forms.TextBox txtBoxSub;
        private System.Windows.Forms.RadioButton radBtnSub;
        private System.Windows.Forms.RadioButton radBtnAdd;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

