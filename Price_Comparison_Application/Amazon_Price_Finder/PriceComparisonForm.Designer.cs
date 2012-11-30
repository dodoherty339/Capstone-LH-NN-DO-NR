//! This is the namespace for the form used in the application
/**
 * It contains the class relating to the actions of the form.
 */
namespace PriceComparisonForm
{
    //! This is the form used in the application
    /**
     * It contains the methods relating to the actions of the form.
     */
    partial class FormPriceCompare
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
            this.grpBoxFilter = new System.Windows.Forms.GroupBox();
            this.radBtnMore = new System.Windows.Forms.RadioButton();
            this.radBtnLess = new System.Windows.Forms.RadioButton();
            this.radBtnNone = new System.Windows.Forms.RadioButton();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpBoxNumResults = new System.Windows.Forms.GroupBox();
            this.radBtn50 = new System.Windows.Forms.RadioButton();
            this.radBtn100 = new System.Windows.Forms.RadioButton();
            this.radBtn25 = new System.Windows.Forms.RadioButton();
            this.tblResults = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatabasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnlinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxSort = new System.Windows.Forms.GroupBox();
            this.radBtnDiffPos = new System.Windows.Forms.RadioButton();
            this.radBtnDiffNeg = new System.Windows.Forms.RadioButton();
            this.radBtnPriceLow = new System.Windows.Forms.RadioButton();
            this.radBtnPriceHigh = new System.Windows.Forms.RadioButton();
            this.lblDisplayedRecords = new System.Windows.Forms.Label();
            this.grpBoxFilter.SuspendLayout();
            this.grpBoxNumResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblResults)).BeginInit();
            this.grpBoxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxFilter
            // 
            this.grpBoxFilter.Controls.Add(this.radBtnMore);
            this.grpBoxFilter.Controls.Add(this.radBtnLess);
            this.grpBoxFilter.Controls.Add(this.radBtnNone);
            this.grpBoxFilter.Location = new System.Drawing.Point(396, 21);
            this.grpBoxFilter.Name = "grpBoxFilter";
            this.grpBoxFilter.Size = new System.Drawing.Size(188, 100);
            this.grpBoxFilter.TabIndex = 5;
            this.grpBoxFilter.TabStop = false;
            this.grpBoxFilter.Text = "Filter results";
            // 
            // radBtnMore
            // 
            this.radBtnMore.AutoSize = true;
            this.radBtnMore.Location = new System.Drawing.Point(16, 42);
            this.radBtnMore.Name = "radBtnMore";
            this.radBtnMore.Size = new System.Drawing.Size(158, 17);
            this.radBtnMore.TabIndex = 2;
            this.radBtnMore.TabStop = true;
            this.radBtnMore.Text = "Items more expensive online";
            this.radBtnMore.UseVisualStyleBackColor = true;
            this.radBtnMore.CheckedChanged += new System.EventHandler(this.radBtnMore_CheckedChanged);
            // 
            // radBtnLess
            // 
            this.radBtnLess.AutoSize = true;
            this.radBtnLess.Location = new System.Drawing.Point(16, 65);
            this.radBtnLess.Name = "radBtnLess";
            this.radBtnLess.Size = new System.Drawing.Size(153, 17);
            this.radBtnLess.TabIndex = 1;
            this.radBtnLess.TabStop = true;
            this.radBtnLess.Text = "Items less expensive online";
            this.radBtnLess.UseVisualStyleBackColor = true;
            this.radBtnLess.CheckedChanged += new System.EventHandler(this.radBtnLess_CheckedChanged);
            // 
            // radBtnNone
            // 
            this.radBtnNone.AutoSize = true;
            this.radBtnNone.Checked = true;
            this.radBtnNone.Location = new System.Drawing.Point(16, 19);
            this.radBtnNone.Name = "radBtnNone";
            this.radBtnNone.Size = new System.Drawing.Size(61, 17);
            this.radBtnNone.TabIndex = 0;
            this.radBtnNone.TabStop = true;
            this.radBtnNone.Text = "No filter";
            this.radBtnNone.UseVisualStyleBackColor = true;
            this.radBtnNone.CheckedChanged += new System.EventHandler(this.radBtnNone_CheckedChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(342, 566);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(423, 566);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // grpBoxNumResults
            // 
            this.grpBoxNumResults.Controls.Add(this.radBtn50);
            this.grpBoxNumResults.Controls.Add(this.radBtn100);
            this.grpBoxNumResults.Controls.Add(this.radBtn25);
            this.grpBoxNumResults.Location = new System.Drawing.Point(235, 21);
            this.grpBoxNumResults.Name = "grpBoxNumResults";
            this.grpBoxNumResults.Size = new System.Drawing.Size(132, 100);
            this.grpBoxNumResults.TabIndex = 6;
            this.grpBoxNumResults.TabStop = false;
            this.grpBoxNumResults.Text = "Number of results";
            // 
            // radBtn50
            // 
            this.radBtn50.AutoSize = true;
            this.radBtn50.Location = new System.Drawing.Point(16, 42);
            this.radBtn50.Name = "radBtn50";
            this.radBtn50.Size = new System.Drawing.Size(90, 17);
            this.radBtn50.TabIndex = 2;
            this.radBtn50.TabStop = true;
            this.radBtn50.Text = "50 per screen";
            this.radBtn50.UseVisualStyleBackColor = true;
            this.radBtn50.CheckedChanged += new System.EventHandler(this.radBtn50_CheckedChanged);
            // 
            // radBtn100
            // 
            this.radBtn100.AutoSize = true;
            this.radBtn100.Location = new System.Drawing.Point(16, 65);
            this.radBtn100.Name = "radBtn100";
            this.radBtn100.Size = new System.Drawing.Size(96, 17);
            this.radBtn100.TabIndex = 1;
            this.radBtn100.TabStop = true;
            this.radBtn100.Text = "100 per screen";
            this.radBtn100.UseVisualStyleBackColor = true;
            this.radBtn100.CheckedChanged += new System.EventHandler(this.radBtn100_CheckedChanged);
            // 
            // radBtn25
            // 
            this.radBtn25.AutoSize = true;
            this.radBtn25.Checked = true;
            this.radBtn25.Location = new System.Drawing.Point(16, 19);
            this.radBtn25.Name = "radBtn25";
            this.radBtn25.Size = new System.Drawing.Size(90, 17);
            this.radBtn25.TabIndex = 0;
            this.radBtn25.TabStop = true;
            this.radBtn25.Text = "25 per screen";
            this.radBtn25.UseVisualStyleBackColor = true;
            this.radBtn25.CheckedChanged += new System.EventHandler(this.radBtn25_CheckedChanged);
            // 
            // tblResults
            // 
            this.tblResults.AllowUserToAddRows = false;
            this.tblResults.AllowUserToDeleteRows = false;
            this.tblResults.AllowUserToResizeColumns = false;
            this.tblResults.AllowUserToResizeRows = false;
            this.tblResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Description,
            this.DatabasePrice,
            this.OnlinePrice,
            this.Difference});
            this.tblResults.Location = new System.Drawing.Point(15, 149);
            this.tblResults.Name = "tblResults";
            this.tblResults.Size = new System.Drawing.Size(569, 400);
            this.tblResults.TabIndex = 13;
            this.tblResults.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblResults_CellEndEdit);
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // DatabasePrice
            // 
            this.DatabasePrice.HeaderText = "Database Price";
            this.DatabasePrice.Name = "DatabasePrice";
            this.DatabasePrice.Width = 75;
            // 
            // OnlinePrice
            // 
            this.OnlinePrice.HeaderText = "Online Price";
            this.OnlinePrice.Name = "OnlinePrice";
            this.OnlinePrice.ReadOnly = true;
            this.OnlinePrice.Width = 75;
            // 
            // Difference
            // 
            this.Difference.HeaderText = "Difference (Online - DB)";
            this.Difference.Name = "Difference";
            this.Difference.ReadOnly = true;
            this.Difference.Width = 75;
            // 
            // grpBoxSort
            // 
            this.grpBoxSort.Controls.Add(this.radBtnDiffPos);
            this.grpBoxSort.Controls.Add(this.radBtnDiffNeg);
            this.grpBoxSort.Controls.Add(this.radBtnPriceLow);
            this.grpBoxSort.Controls.Add(this.radBtnPriceHigh);
            this.grpBoxSort.Location = new System.Drawing.Point(15, 21);
            this.grpBoxSort.Name = "grpBoxSort";
            this.grpBoxSort.Size = new System.Drawing.Size(198, 115);
            this.grpBoxSort.TabIndex = 14;
            this.grpBoxSort.TabStop = false;
            this.grpBoxSort.Text = "Sort by";
            // 
            // radBtnDiffPos
            // 
            this.radBtnDiffPos.AutoSize = true;
            this.radBtnDiffPos.Location = new System.Drawing.Point(14, 88);
            this.radBtnDiffPos.Name = "radBtnDiffPos";
            this.radBtnDiffPos.Size = new System.Drawing.Size(175, 17);
            this.radBtnDiffPos.TabIndex = 3;
            this.radBtnDiffPos.TabStop = true;
            this.radBtnDiffPos.Text = "Difference (positive to negative)";
            this.radBtnDiffPos.UseVisualStyleBackColor = true;
            this.radBtnDiffPos.CheckedChanged += new System.EventHandler(this.radBtnDiffPos_CheckedChanged);
            // 
            // radBtnDiffNeg
            // 
            this.radBtnDiffNeg.AutoSize = true;
            this.radBtnDiffNeg.Location = new System.Drawing.Point(14, 65);
            this.radBtnDiffNeg.Name = "radBtnDiffNeg";
            this.radBtnDiffNeg.Size = new System.Drawing.Size(175, 17);
            this.radBtnDiffNeg.TabIndex = 2;
            this.radBtnDiffNeg.TabStop = true;
            this.radBtnDiffNeg.Text = "Difference (negative to positive)";
            this.radBtnDiffNeg.UseVisualStyleBackColor = true;
            this.radBtnDiffNeg.CheckedChanged += new System.EventHandler(this.radBtnDiffNeg_CheckedChanged);
            // 
            // radBtnPriceLow
            // 
            this.radBtnPriceLow.AutoSize = true;
            this.radBtnPriceLow.Checked = true;
            this.radBtnPriceLow.Location = new System.Drawing.Point(14, 19);
            this.radBtnPriceLow.Name = "radBtnPriceLow";
            this.radBtnPriceLow.Size = new System.Drawing.Size(109, 17);
            this.radBtnPriceLow.TabIndex = 1;
            this.radBtnPriceLow.TabStop = true;
            this.radBtnPriceLow.Text = "Price (low to high)";
            this.radBtnPriceLow.UseVisualStyleBackColor = true;
            this.radBtnPriceLow.CheckedChanged += new System.EventHandler(this.radBtnPriceLow_CheckedChanged);
            // 
            // radBtnPriceHigh
            // 
            this.radBtnPriceHigh.AutoSize = true;
            this.radBtnPriceHigh.Location = new System.Drawing.Point(14, 42);
            this.radBtnPriceHigh.Name = "radBtnPriceHigh";
            this.radBtnPriceHigh.Size = new System.Drawing.Size(109, 17);
            this.radBtnPriceHigh.TabIndex = 0;
            this.radBtnPriceHigh.TabStop = true;
            this.radBtnPriceHigh.Text = "Price (high to low)";
            this.radBtnPriceHigh.UseVisualStyleBackColor = true;
            this.radBtnPriceHigh.CheckedChanged += new System.EventHandler(this.radBtnPriceHigh_CheckedChanged);
            // 
            // lblDisplayedRecords
            // 
            this.lblDisplayedRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayedRecords.AutoSize = true;
            this.lblDisplayedRecords.Location = new System.Drawing.Point(504, 570);
            this.lblDisplayedRecords.MaximumSize = new System.Drawing.Size(80, 15);
            this.lblDisplayedRecords.MinimumSize = new System.Drawing.Size(80, 15);
            this.lblDisplayedRecords.Name = "lblDisplayedRecords";
            this.lblDisplayedRecords.Size = new System.Drawing.Size(80, 15);
            this.lblDisplayedRecords.TabIndex = 0;
            this.lblDisplayedRecords.Text = "888-888 of 888";
            this.lblDisplayedRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPriceCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 603);
            this.Controls.Add(this.lblDisplayedRecords);
            this.Controls.Add(this.grpBoxSort);
            this.Controls.Add(this.tblResults);
            this.Controls.Add(this.grpBoxNumResults);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.grpBoxFilter);
            this.MaximizeBox = false;
            this.Name = "FormPriceCompare";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Price Comparison";
            this.grpBoxFilter.ResumeLayout(false);
            this.grpBoxFilter.PerformLayout();
            this.grpBoxNumResults.ResumeLayout(false);
            this.grpBoxNumResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblResults)).EndInit();
            this.grpBoxSort.ResumeLayout(false);
            this.grpBoxSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxFilter;
        private System.Windows.Forms.RadioButton radBtnMore;
        private System.Windows.Forms.RadioButton radBtnLess;
        private System.Windows.Forms.RadioButton radBtnNone;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox grpBoxNumResults;
        private System.Windows.Forms.RadioButton radBtn50;
        private System.Windows.Forms.RadioButton radBtn100;
        private System.Windows.Forms.RadioButton radBtn25;
        public System.Windows.Forms.DataGridView tblResults;
        private System.Windows.Forms.GroupBox grpBoxSort;
        private System.Windows.Forms.RadioButton radBtnDiffPos;
        private System.Windows.Forms.RadioButton radBtnDiffNeg;
        private System.Windows.Forms.RadioButton radBtnPriceLow;
        private System.Windows.Forms.RadioButton radBtnPriceHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatabasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnlinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difference;
        public System.Windows.Forms.Label lblDisplayedRecords;
    }
}

