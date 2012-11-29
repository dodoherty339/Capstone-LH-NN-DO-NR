//! This is the namespace for the form used in the application
/**
 * It contains the class relating to the actions of the form.
 */
namespace AmazonPriceFinderForm
{
    //! This is the form used in the application
    /**
     * It contains the methods relating to the actions of the form.
     */
    partial class FormAmazonPrice
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
            this.radBtnMore = new System.Windows.Forms.RadioButton();
            this.radBtnLess = new System.Windows.Forms.RadioButton();
            this.radBtnNone = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.grpBoxRecords = new System.Windows.Forms.GroupBox();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblDisplayedRecords = new System.Windows.Forms.Label();
            this.tblResults = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatabasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnlinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBoxFilter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBoxRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblResults)).BeginInit();
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
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(320, 334);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(401, 334);
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
            this.groupBox2.Text = "Number of results";
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
            // grpBoxRecords
            // 
            this.grpBoxRecords.Controls.Add(this.lblTotalRecords);
            this.grpBoxRecords.Controls.Add(this.lblOf);
            this.grpBoxRecords.Controls.Add(this.lblDisplayedRecords);
            this.grpBoxRecords.Location = new System.Drawing.Point(482, 323);
            this.grpBoxRecords.Name = "grpBoxRecords";
            this.grpBoxRecords.Size = new System.Drawing.Size(102, 36);
            this.grpBoxRecords.TabIndex = 11;
            this.grpBoxRecords.TabStop = false;
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(69, 16);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(25, 13);
            this.lblTotalRecords.TabIndex = 4;
            this.lblTotalRecords.Text = "888";
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Location = new System.Drawing.Point(51, 16);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(16, 13);
            this.lblOf.TabIndex = 3;
            this.lblOf.Text = "of";
            // 
            // lblDisplayedRecords
            // 
            this.lblDisplayedRecords.AutoSize = true;
            this.lblDisplayedRecords.Location = new System.Drawing.Point(6, 16);
            this.lblDisplayedRecords.Name = "lblDisplayedRecords";
            this.lblDisplayedRecords.Size = new System.Drawing.Size(46, 13);
            this.lblDisplayedRecords.TabIndex = 0;
            this.lblDisplayedRecords.Text = "888-888";
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
            this.OnlinePrice});
            this.tblResults.Location = new System.Drawing.Point(15, 149);
            this.tblResults.Name = "tblResults";
            this.tblResults.Size = new System.Drawing.Size(569, 170);
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
            // FormAmazonPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 426);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tblResults);
            this.Controls.Add(this.grpBoxRecords);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.grpBoxFilter);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.comboBoxSort);
            this.Name = "FormAmazonPrice";
            this.Text = "Price Comparison";
            this.grpBoxFilter.ResumeLayout(false);
            this.grpBoxFilter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBoxRecords.ResumeLayout(false);
            this.grpBoxRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblResults)).EndInit();
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox grpBoxRecords;
        private System.Windows.Forms.Label lblOf;
        public System.Windows.Forms.DataGridView tblResults;
        public System.Windows.Forms.Label lblTotalRecords;
        public System.Windows.Forms.Label lblDisplayedRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatabasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnlinePrice;
    }
}

