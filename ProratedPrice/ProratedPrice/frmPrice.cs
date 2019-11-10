using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProratedPrice
{
    public partial class frmPrice : Form
    {
        /// <summary>
        /// FormClosingイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.ApplicationExitCall:
                    // Application.Exit
                    break;
                case CloseReason.FormOwnerClosing:
                    // 所有側のフォームが閉じられようとしている
                    break;
                case CloseReason.MdiFormClosing:
                    // MDIの親フォームが閉じられようとしている
                    break;
                case CloseReason.TaskManagerClosing:
                    // タスクマネージャにより閉じられようとしている
                    break;
                case CloseReason.UserClosing:
                    // ユーザーインターフェイスにより閉じられようとしている
                    break;
                case CloseReason.WindowsShutDown:
                    // OSのシャットダウンにより閉じられようとしている
                    break;
                case CloseReason.None:
                default:
                    // (上記以外)予期せぬ原因
                    break;
            }
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmPrice()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("price");
            ds.Tables.Add(dt);

            dt.Columns.Add("税込単価", typeof(decimal));
            dt.Columns.Add("数量", typeof(int));
            dt.Columns.Add("税率", typeof(int));
            dt.Columns.Add("税込価格", typeof(decimal));
            dt.Columns.Add("税抜価格", typeof(decimal));
            dt.Columns.Add("消費税", typeof(decimal));
            dt.Columns.Add("按分値引", typeof(decimal));
            dt.Columns.Add("値引税込価格", typeof(decimal));
            dt.Columns.Add("値引税抜価格", typeof(decimal));
            dt.Columns.Add("値引消費税", typeof(decimal));

            dataGridView1.DataSource = ds.Tables["price"];

            // 税率コンボボックスカラム
            SetRateComboboxColumns();
        }
        /// <summary>
        /// ■税率コンボボックスカラム
        /// </summary>
        private void SetRateComboboxColumns()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Display", typeof(int));
            dt.Columns.Add("Value", typeof(int));
            dt.Rows.Add("10", 10);
            dt.Rows.Add("8", 8);
            dt.Rows.Add("0", 0);

            DataGridViewComboBoxColumn dgvCombobox = new DataGridViewComboBoxColumn();
            dgvCombobox = (DataGridViewComboBoxColumn)dataGridView1.Columns["税率"];
            dgvCombobox.DataSource = dt;
            dgvCombobox.ValueMember = "Value";
            dgvCombobox.DisplayMember = "Display";
        }

        /// <summary>
        /// FormLoadイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = bindingSource1;
        }

        /// <summary>
        /// 閉じるボタン クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 計算ボタン クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //------------------------
            // 入力チェック
            //------------------------
            if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show("価格情報を入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
            {
                if (dgvRow.IsNewRow) continue;

                if (string.IsNullOrEmpty(dgvRow.Cells["税込価格"].ToString()))
                {
                    MessageBox.Show("税込み価格が未入力の行があります。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(dgvRow.Cells["数量"].ToString()))
                {
                    MessageBox.Show("数量が未入力の行があります。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (string.IsNullOrEmpty(dgvRow.Cells["税率"].ToString()))
                {
                    MessageBox.Show("税率が未入力の行があります。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                txtDiscount.Select();
                MessageBox.Show("値引きを入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int discount;
            if (!int.TryParse(txtDiscount.Text, out discount))
            {
                txtDiscount.Select();
                MessageBox.Show("値引きには数値を入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //------------------------
            // 初期化
            //------------------------
            DataTable dt = dataGridView1.DataSource as DataTable;
            foreach (DataRow dRow in dt.Rows)
            {
                dRow["税込価格"] = 0;
                dRow["税抜価格"] = 0;
                dRow["消費税"] = 0;
                dRow["按分値引"] = 0;
                dRow["値引税込価格"] = 0;
                dRow["値引税抜価格"] = 0;
                dRow["値引消費税"] = 0;
            }
            
            //------------------------
            // 按分計算処理メイン
            //------------------------
            try
            {
                // LINQソート(税込単価昇順ソート)
                DataRow[] dRows = dt.AsEnumerable()
                    .OrderByDescending(row => row.Field<decimal>("税込単価")).ToArray();

                // =======================
                // ①税込価格
                // ②税抜価格
                // ③消費税
                // =======================
                foreach (DataRow dRow in dt.Rows)
                {
                    dRow["税込価格"] = (decimal)dRow["税込単価"] * (int)dRow["数量"];

                    if (Math.Ceiling((decimal)dRow["税込単価"] / (1 + (decimal)(int)dRow["税率"] / 100)) <= (int)dRow["税率"])
                    {
                        // 税抜単価 < 税率
                        dRow["税抜価格"] = dRow["税込価格"];
                        dRow["消費税"] = 0;
                    }
                    else
                    {
                        // 消費税切り上げ = 税抜単価端数切り捨て
                        dRow["税抜価格"] = Math.Floor((decimal)dRow["税込単価"] / (1 + (decimal)(int)dRow["税率"] / 100)) * (int)dRow["数量"];
                        dRow["消費税"] = (decimal)dRow["税込価格"] - (decimal)dRow["税抜価格"];
                    }
                }

                // LINQ集計(税込価格合計)
                object sumPrice = dt.Compute("SUM(税込価格)", null);

                if (discount > (decimal)sumPrice)
                {
                    txtDiscount.Select();
                    MessageBox.Show("値引きが総額を超えています。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // =======================
                // ④按分値引
                // =======================
                foreach (DataRow dRow in dRows)
                {
                    dRow["按分値引"] = Math.Round(((decimal)dRow["税込価格"] / (decimal)sumPrice) * discount);
                }

                int adjuster = 0;
                sumPrice = dt.Compute("SUM(按分値引)", null);
                int diff = discount - (int)(decimal)sumPrice;
                if (diff > 0)
                {
                    // 値引き不足のためADD値引き
                    foreach (DataRow dRow in dRows)
                    {
                        if ((decimal)dRow["按分値引"] + 1 > (decimal)dRow["税込価格"]) continue;

                        for (int i = 1; i <= (int)dRow["数量"]; i++)
                        {
                            // 1円追加値引き
                            dRow["按分値引"] = (decimal)dRow["按分値引"] + 1;
                            adjuster += 1;

                            if (adjuster == diff) break;
                        }

                        if (adjuster == diff) break;
                    }
                }
                if (diff < 0)
                {
                    // 値引き過剰のためMINUS値引き

                    // LINQソート(税込単価降順ソート)
                    dRows = dt.AsEnumerable()
                        .OrderBy(row => row.Field<decimal>("税込単価")).ToArray();

                    foreach (DataRow dRow in dRows)
                    {
                        for (int i = 1; i <= (int)dRow["数量"]; i++)
                        {
                            // 1円戻し
                            dRow["按分値引"] = (decimal)dRow["按分値引"] - 1;
                            adjuster -= 1;

                            if (adjuster == diff) break;
                        }

                        if (adjuster == diff) break;
                    }
                }

                // =======================
                // ⑤値引税込価格
                // ⑥値引税抜価格
                // ⑦値引消費税
                // =======================
                decimal unitPrice;
                foreach (DataRow dRow in dRows)
                {
                    dRow["値引税込価格"] = (decimal)dRow["税込価格"] - (decimal)dRow["按分値引"];

                    unitPrice = (decimal)dRow["値引税込価格"] / (int)dRow["数量"];
                    if (Math.Ceiling(unitPrice / (1 + (decimal)(int)dRow["税率"] / 100)) <= (int)dRow["税率"])
                    {
                        // 値引税抜単価 < 税率
                        dRow["値引税抜価格"] = dRow["値引税込価格"];
                        dRow["値引消費税"] = 0;
                    }
                    else
                    {
                        // 消費税切り上げ = 値引税抜単価端数切り捨て
                        dRow["値引税抜価格"] = Math.Floor(unitPrice / (1 + (decimal)(int)dRow["税率"] / 100)) * (int)dRow["数量"];
                        dRow["値引消費税"] = (decimal)dRow["値引税込価格"] - (decimal)dRow["値引税抜価格"];
                    }
                }

                // 値引き前テキスト出力
                OutputBeforePriceText();
                // 値引き適用テキスト出力
                if (discount > 0) OutputAfterPriceText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ■値引き前テキスト出力
        /// </summary>
        private void OutputBeforePriceText()
        {
            decimal totalPrice = 0;
            decimal totalTax = 0;

            DataTable dt = dataGridView1.DataSource as DataTable;

            object sumPrice = dt.Compute("SUM(税込価格)", "税率 = 10");
            object sumTax = dt.Compute("SUM(消費税)", "税率 = 10");

            if (!string.IsNullOrEmpty(sumPrice.ToString()))
            {
                txtPriceBefore.Text = "  10％：" + string.Format("{0:c}", sumPrice) +
                                        "（税：" + string.Format("{0:c}", sumTax) + "）";
                txtPriceBefore.Text += Environment.NewLine;

                totalPrice += (decimal)sumPrice;
                totalTax += (decimal)sumTax;
            }


            sumPrice = dt.Compute("SUM(税込価格)", "税率 = 8");
            sumTax = dt.Compute("SUM(消費税)", "税率 = 8");

            if (!string.IsNullOrEmpty(sumPrice.ToString()))
            {
                txtPriceBefore.Text += "    8％：" + string.Format("{0:c}", sumPrice) +
                                    "（税：" + string.Format("{0:c}", sumTax) + "）";
                txtPriceBefore.Text += Environment.NewLine;

                totalPrice += (decimal)sumPrice;
                totalTax += (decimal)sumTax;
            }
            
            sumPrice = dt.Compute("SUM(税込価格)", "税率 = 0");
            sumTax = dt.Compute("SUM(消費税)", "税率 = 0");

            if (!string.IsNullOrEmpty(sumPrice.ToString()))
            {
                txtPriceBefore.Text += "非課税：" + string.Format("{0:c}", sumPrice) +
                                    "（税：" + string.Format("{0:c}", sumTax) + "）";
                txtPriceBefore.Text += Environment.NewLine;

                totalPrice += (decimal)sumPrice;
                totalTax += (decimal)sumTax;
            }
                                                                    
            txtPriceBefore.Text += "-----------------------------------";
            txtPriceBefore.Text += Environment.NewLine;

            txtPriceBefore.Text += "   合計：" + string.Format("{0:c}", totalPrice) +
                                    "（税：" + string.Format("{0:c}", totalTax) + "）";

        }
        /// <summary>
        /// ■値引き適用テキスト出力
        /// </summary>
        private void OutputAfterPriceText()
        {
            decimal totalPrice = 0;
            decimal totalTax = 0;

            DataTable dt = dataGridView1.DataSource as DataTable;

            object sumPrice = dt.Compute("SUM(値引税込価格)", "税率 = 10");
            object sumTax = dt.Compute("SUM(値引消費税)", "税率 = 10");

            if (!string.IsNullOrEmpty(sumPrice.ToString()))
            {
                txtPriceAfter.Text = "  10％：" + string.Format("{0:c}", sumPrice) +
                                        "（税：" + string.Format("{0:c}", sumTax) + "）";
                txtPriceAfter.Text += Environment.NewLine;

                totalPrice += (decimal)sumPrice;
                totalTax += (decimal)sumTax;
            }


            sumPrice = dt.Compute("SUM(値引税込価格)", "税率 = 8");
            sumTax = dt.Compute("SUM(値引消費税)", "税率 = 8");

            if (!string.IsNullOrEmpty(sumPrice.ToString()))
            {
                txtPriceAfter.Text += "    8％：" + string.Format("{0:c}", sumPrice) +
                                    "（税：" + string.Format("{0:c}", sumTax) + "）";
                txtPriceAfter.Text += Environment.NewLine;

                totalPrice += (decimal)sumPrice;
                totalTax += (decimal)sumTax;
            }

            sumPrice = dt.Compute("SUM(値引税込価格)", "税率 = 0");
            sumTax = dt.Compute("SUM(値引消費税)", "税率 = 0");

            if (!string.IsNullOrEmpty(sumPrice.ToString()))
            {
                txtPriceAfter.Text += "非課税：" + string.Format("{0:c}", sumPrice) +
                                    "（税：" + string.Format("{0:c}", sumTax) + "）";
                txtPriceAfter.Text += Environment.NewLine;

                totalPrice += (decimal)sumPrice;
                totalTax += (decimal)sumTax;
            }

            txtPriceAfter.Text += "-----------------------------------";
            txtPriceAfter.Text += Environment.NewLine;

            txtPriceAfter.Text += "   合計：" + string.Format("{0:c}", totalPrice) +
                                    "（税：" + string.Format("{0:c}", totalTax) + "）";

        }

        /// <summary>
        /// 【dataGridView_CellValidating】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == dgv.NewRowIndex || !dgv.IsCurrentCellDirty)
            {
                return;
            }

            decimal val;
            if (dgv.Columns[e.ColumnIndex].Name == "税込単価")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString())) return;

                if (decimal.TryParse(e.FormattedValue.ToString(), out val))
                {
                    if (Math.Floor(val) <= 0)
                    {
                        MessageBox.Show("税込単価は1円以上を入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true; return;
                    }
                }
                else
                {
                    MessageBox.Show("税込単価が不正です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true; return;
                }
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "数量")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString())) return;

                if (decimal.TryParse(e.FormattedValue.ToString(), out val))
                {
                    if (Math.Floor(val) <= 0)
                    {
                        MessageBox.Show("数量は正数を入力してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true; return;
                    }
                }
                else
                {
                    MessageBox.Show("数量が不正です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true; return;
                }
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "税率")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString())) return;

                if (decimal.TryParse(e.FormattedValue.ToString(), out val))
                {
                    if (Math.Floor(val) < 0 || 100 < Math.Floor(val))
                    {
                        MessageBox.Show("税率は正数（0～100）を入力してください。。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true; return;
                    }
                }
                else
                {
                    MessageBox.Show("税率が不正です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true; return;
                }
            }
        }
        /// <summary>
        /// 【dataGridView1_CellValidated】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (e.RowIndex == dgv.NewRowIndex)
            {
                return;
            }

            decimal val;
            if (dgv.Columns[e.ColumnIndex].Name == "税込単価")
            {
                if (string.IsNullOrEmpty(dgv[e.ColumnIndex, e.RowIndex].Value.ToString())) return;

                if (decimal.TryParse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString(), out val))
                {
                    dgv[e.ColumnIndex, e.RowIndex].Value = Math.Floor(val);
                }
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "数量")
            {
                if (string.IsNullOrEmpty(dgv[e.ColumnIndex, e.RowIndex].Value.ToString())) return;

                if (decimal.TryParse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString(), out val))
                {
                    dgv[e.ColumnIndex, e.RowIndex].Value = Math.Floor(val);
                }
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "税率")
            {
                if (string.IsNullOrEmpty(dgv[e.ColumnIndex, e.RowIndex].Value.ToString())) return;

                if (decimal.TryParse(dgv[e.ColumnIndex, e.RowIndex].Value.ToString(), out val))
                {
                    dgv[e.ColumnIndex, e.RowIndex].Value = Math.Floor(val);
                }
            }
        }
        /// <summary>
        /// 【dataGridView1_DataError】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dataGridView1[e.ColumnIndex, e.RowIndex].ErrorText = "";
        }
        /// <summary>
        /// 【dataGridView1_CellEnter】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                SendKeys.Send("{F4}");
            }
        }
        /// <summary>
        /// 【dataGridView1_DefaultValuesNeeded】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // 税率
            e.Row.Cells["税率"].Value = 10;
        }
    }
}
