namespace ProratedPrice
{
    partial class frmPrice
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrice));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPriceBefore = new System.Windows.Forms.TextBox();
            this.txtPriceAfter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.税込単価 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.税率 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.税込価格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.税抜価格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.消費税 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.按分値引 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.値引税込価格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.値引税抜価格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.値引消費税 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.税込単価,
            this.数量,
            this.税率,
            this.税込価格,
            this.税抜価格,
            this.消費税,
            this.按分値引,
            this.値引税込価格,
            this.値引税抜価格,
            this.値引消費税});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 281);
            this.panel1.TabIndex = 1;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDiscount.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtDiscount.Location = new System.Drawing.Point(60, 306);
            this.txtDiscount.MaxLength = 8;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 23);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(14, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "値引き";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(999, 368);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 43);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "計　算";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(882, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "閉じる";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPriceBefore
            // 
            this.txtPriceBefore.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPriceBefore.Location = new System.Drawing.Point(213, 327);
            this.txtPriceBefore.Multiline = true;
            this.txtPriceBefore.Name = "txtPriceBefore";
            this.txtPriceBefore.ReadOnly = true;
            this.txtPriceBefore.Size = new System.Drawing.Size(215, 84);
            this.txtPriceBefore.TabIndex = 6;
            // 
            // txtPriceAfter
            // 
            this.txtPriceAfter.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.txtPriceAfter.Location = new System.Drawing.Point(449, 327);
            this.txtPriceAfter.Multiline = true;
            this.txtPriceAfter.Name = "txtPriceAfter";
            this.txtPriceAfter.ReadOnly = true;
            this.txtPriceAfter.Size = new System.Drawing.Size(230, 84);
            this.txtPriceAfter.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(210, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "値引き前";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(446, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "値引き適用";
            // 
            // 税込単価
            // 
            this.税込単価.DataPropertyName = "税込単価";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle12.Format = "C0";
            this.税込単価.DefaultCellStyle = dataGridViewCellStyle12;
            this.税込単価.HeaderText = "税込単価";
            this.税込単価.MaxInputLength = 8;
            this.税込単価.Name = "税込単価";
            this.税込単価.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "数量";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.数量.DefaultCellStyle = dataGridViewCellStyle13;
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.数量.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 税率
            // 
            this.税率.DataPropertyName = "税率";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.税率.DefaultCellStyle = dataGridViewCellStyle14;
            this.税率.DisplayStyleForCurrentCellOnly = true;
            this.税率.DividerWidth = 3;
            this.税率.HeaderText = "税率（％）";
            this.税率.Name = "税率";
            this.税率.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 税込価格
            // 
            this.税込価格.DataPropertyName = "税込価格";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle15.Format = "C0";
            dataGridViewCellStyle15.NullValue = null;
            this.税込価格.DefaultCellStyle = dataGridViewCellStyle15;
            this.税込価格.HeaderText = "税込価格（自動）";
            this.税込価格.Name = "税込価格";
            this.税込価格.ReadOnly = true;
            this.税込価格.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 税抜価格
            // 
            this.税抜価格.DataPropertyName = "税抜価格";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Meiryo UI", 9F);
            dataGridViewCellStyle16.Format = "C0";
            dataGridViewCellStyle16.NullValue = null;
            this.税抜価格.DefaultCellStyle = dataGridViewCellStyle16;
            this.税抜価格.HeaderText = "税抜価格（自動）";
            this.税抜価格.Name = "税抜価格";
            this.税抜価格.ReadOnly = true;
            this.税抜価格.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 消費税
            // 
            this.消費税.DataPropertyName = "消費税";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Meiryo UI", 9F);
            dataGridViewCellStyle17.Format = "C0";
            dataGridViewCellStyle17.NullValue = null;
            this.消費税.DefaultCellStyle = dataGridViewCellStyle17;
            this.消費税.HeaderText = "消費税（自動）";
            this.消費税.Name = "消費税";
            this.消費税.ReadOnly = true;
            this.消費税.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 按分値引
            // 
            this.按分値引.DataPropertyName = "按分値引";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Meiryo UI", 9F);
            dataGridViewCellStyle18.Format = "C0";
            dataGridViewCellStyle18.NullValue = null;
            this.按分値引.DefaultCellStyle = dataGridViewCellStyle18;
            this.按分値引.HeaderText = "按分値引（自動）";
            this.按分値引.Name = "按分値引";
            this.按分値引.ReadOnly = true;
            this.按分値引.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 値引税込価格
            // 
            this.値引税込価格.DataPropertyName = "値引税込価格";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Meiryo UI", 9F);
            dataGridViewCellStyle19.Format = "C0";
            dataGridViewCellStyle19.NullValue = null;
            this.値引税込価格.DefaultCellStyle = dataGridViewCellStyle19;
            this.値引税込価格.HeaderText = "値引税込価格（自動）";
            this.値引税込価格.Name = "値引税込価格";
            this.値引税込価格.ReadOnly = true;
            this.値引税込価格.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.値引税込価格.Width = 125;
            // 
            // 値引税抜価格
            // 
            this.値引税抜価格.DataPropertyName = "値引税抜価格";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle20.Format = "C0";
            dataGridViewCellStyle20.NullValue = null;
            this.値引税抜価格.DefaultCellStyle = dataGridViewCellStyle20;
            this.値引税抜価格.HeaderText = "値引税抜価格（自動）";
            this.値引税抜価格.Name = "値引税抜価格";
            this.値引税抜価格.ReadOnly = true;
            this.値引税抜価格.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.値引税抜価格.Width = 125;
            // 
            // 値引消費税
            // 
            this.値引消費税.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.値引消費税.DataPropertyName = "値引消費税";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Meiryo UI", 9F);
            dataGridViewCellStyle21.Format = "C0";
            dataGridViewCellStyle21.NullValue = null;
            this.値引消費税.DefaultCellStyle = dataGridViewCellStyle21;
            this.値引消費税.HeaderText = "値引消費税（自動）";
            this.値引消費税.Name = "値引消費税";
            this.値引消費税.ReadOnly = true;
            this.値引消費税.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPriceAfter);
            this.Controls.Add(this.txtPriceBefore);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1120, 462);
            this.Name = "frmPrice";
            this.Text = "按分電卓";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtPriceBefore;
        private System.Windows.Forms.TextBox txtPriceAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 税込単価;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewComboBoxColumn 税率;
        private System.Windows.Forms.DataGridViewTextBoxColumn 税込価格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 税抜価格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 消費税;
        private System.Windows.Forms.DataGridViewTextBoxColumn 按分値引;
        private System.Windows.Forms.DataGridViewTextBoxColumn 値引税込価格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 値引税抜価格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 値引消費税;
    }
}

