
namespace RPNCalc
{
    partial class FormMainCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelKeys = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxRowsNum = new System.Windows.Forms.ListBox();
            this.listBoxRowsValues = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonMultiplicator = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelKeys.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelKeys, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(344, 601);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelKeys
            // 
            this.tableLayoutPanelKeys.ColumnCount = 4;
            this.tableLayoutPanelKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKeys.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelKeys.Controls.Add(this.buttonEnter, 3, 4);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonClear, 2, 4);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonNum0, 1, 4);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonComma, 0, 4);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonSum, 3, 3);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonNum3, 2, 3);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonNum2, 1, 3);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonNum1, 0, 3);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonSubtract, 3, 2);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonNum6, 2, 2);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonNum5, 1, 2);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonNum4, 0, 2);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonMultiplicator, 3, 1);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonNum9, 2, 1);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonNum8, 1, 1);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonNum7, 0, 1);
            this.tableLayoutPanelKeys.Controls.Add(this.buttonDivision, 3, 0);
            this.tableLayoutPanelKeys.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanelKeys.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanelKeys.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanelKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelKeys.Location = new System.Drawing.Point(3, 250);
            this.tableLayoutPanelKeys.Name = "tableLayoutPanelKeys";
            this.tableLayoutPanelKeys.RowCount = 5;
            this.tableLayoutPanelKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelKeys.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelKeys.Size = new System.Drawing.Size(338, 348);
            this.tableLayoutPanelKeys.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.66078F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.33923F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxRowsValues, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxRowsNum, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 241);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listBoxRowsNum
            // 
            this.listBoxRowsNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRowsNum.Enabled = false;
            this.listBoxRowsNum.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRowsNum.FormattingEnabled = true;
            this.listBoxRowsNum.ItemHeight = 14;
            this.listBoxRowsNum.Items.AddRange(new object[] {
            "16:",
            "15:",
            "14:",
            "13:",
            "12:",
            "11:",
            "10:",
            "09:",
            "08:",
            "07:",
            "06:",
            "05:",
            "04:",
            "03:",
            "02:",
            "01:"});
            this.listBoxRowsNum.Location = new System.Drawing.Point(3, 3);
            this.listBoxRowsNum.Name = "listBoxRowsNum";
            this.listBoxRowsNum.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxRowsNum.Size = new System.Drawing.Size(33, 235);
            this.listBoxRowsNum.TabIndex = 2;
            // 
            // listBoxRowsValues
            // 
            this.listBoxRowsValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRowsValues.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRowsValues.FormattingEnabled = true;
            this.listBoxRowsValues.ItemHeight = 14;
            this.listBoxRowsValues.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "350,5",
            "02,20",
            "0125"});
            this.listBoxRowsValues.Location = new System.Drawing.Point(42, 3);
            this.listBoxRowsValues.Name = "listBoxRowsValues";
            this.listBoxRowsValues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxRowsValues.Size = new System.Drawing.Size(293, 235);
            this.listBoxRowsValues.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(132, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(140, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // buttonDivision
            // 
            this.buttonDivision.AutoSize = true;
            this.buttonDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(148, 179);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(75, 23);
            this.buttonDivision.TabIndex = 3;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            // 
            // buttonNum7
            // 
            this.buttonNum7.AutoSize = true;
            this.buttonNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum7.Location = new System.Drawing.Point(156, 187);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(75, 23);
            this.buttonNum7.TabIndex = 4;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = true;
            // 
            // buttonNum8
            // 
            this.buttonNum8.AutoSize = true;
            this.buttonNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum8.Location = new System.Drawing.Point(164, 195);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(75, 23);
            this.buttonNum8.TabIndex = 5;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = true;
            // 
            // buttonNum9
            // 
            this.buttonNum9.AutoSize = true;
            this.buttonNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum9.Location = new System.Drawing.Point(172, 203);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(75, 23);
            this.buttonNum9.TabIndex = 6;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = true;
            // 
            // buttonMultiplicator
            // 
            this.buttonMultiplicator.AutoSize = true;
            this.buttonMultiplicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiplicator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicator.Location = new System.Drawing.Point(180, 211);
            this.buttonMultiplicator.Name = "buttonMultiplicator";
            this.buttonMultiplicator.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplicator.TabIndex = 7;
            this.buttonMultiplicator.Text = "*";
            this.buttonMultiplicator.UseVisualStyleBackColor = true;
            // 
            // buttonNum4
            // 
            this.buttonNum4.AutoSize = true;
            this.buttonNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum4.Location = new System.Drawing.Point(188, 219);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(75, 23);
            this.buttonNum4.TabIndex = 8;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = true;
            // 
            // buttonNum5
            // 
            this.buttonNum5.AutoSize = true;
            this.buttonNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum5.Location = new System.Drawing.Point(196, 227);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(75, 23);
            this.buttonNum5.TabIndex = 9;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = true;
            // 
            // buttonNum6
            // 
            this.buttonNum6.AutoSize = true;
            this.buttonNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum6.Location = new System.Drawing.Point(204, 235);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(75, 23);
            this.buttonNum6.TabIndex = 10;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = true;
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.AutoSize = true;
            this.buttonSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.Location = new System.Drawing.Point(212, 243);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(75, 23);
            this.buttonSubtract.TabIndex = 11;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            // 
            // buttonNum1
            // 
            this.buttonNum1.AutoSize = true;
            this.buttonNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum1.Location = new System.Drawing.Point(220, 251);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(75, 23);
            this.buttonNum1.TabIndex = 12;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = true;
            // 
            // buttonNum2
            // 
            this.buttonNum2.AutoSize = true;
            this.buttonNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum2.Location = new System.Drawing.Point(228, 259);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(75, 23);
            this.buttonNum2.TabIndex = 13;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = true;
            // 
            // buttonNum3
            // 
            this.buttonNum3.AutoSize = true;
            this.buttonNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum3.Location = new System.Drawing.Point(236, 267);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(75, 23);
            this.buttonNum3.TabIndex = 14;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = true;
            // 
            // buttonSum
            // 
            this.buttonSum.AutoSize = true;
            this.buttonSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSum.Location = new System.Drawing.Point(244, 275);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(75, 23);
            this.buttonSum.TabIndex = 15;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            // 
            // buttonComma
            // 
            this.buttonComma.AutoSize = true;
            this.buttonComma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComma.Location = new System.Drawing.Point(252, 283);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(75, 23);
            this.buttonComma.TabIndex = 16;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            // 
            // buttonNum0
            // 
            this.buttonNum0.AutoSize = true;
            this.buttonNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum0.Location = new System.Drawing.Point(260, 291);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(75, 23);
            this.buttonNum0.TabIndex = 17;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.BackColor = System.Drawing.Color.Crimson;
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(268, 299);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonEnter
            // 
            this.buttonEnter.AutoSize = true;
            this.buttonEnter.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.ForeColor = System.Drawing.Color.White;
            this.buttonEnter.Location = new System.Drawing.Point(276, 307);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 19;
            this.buttonEnter.Text = "ENTER";
            this.buttonEnter.UseVisualStyleBackColor = false;
            // 
            // FormMainCalc
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MaximumSize = new System.Drawing.Size(360, 640);
            this.MinimumSize = new System.Drawing.Size(360, 640);
            this.Name = "FormMainCalc";
            this.Text = "RPN Calculator";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelKeys.ResumeLayout(false);
            this.tableLayoutPanelKeys.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKeys;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxRowsNum;
        private System.Windows.Forms.ListBox listBoxRowsValues;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonMultiplicator;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonDivision;
    }
}

