
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonMultiplicator = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanelDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxRowsValues = new System.Windows.Forms.ListBox();
            this.listBoxRowsNum = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelKeys.SuspendLayout();
            this.tableLayoutPanelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelKeys, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelDisplay, 0, 0);
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
            // buttonEnter
            // 
            this.buttonEnter.AutoSize = true;
            this.buttonEnter.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.ForeColor = System.Drawing.Color.White;
            this.buttonEnter.Location = new System.Drawing.Point(255, 279);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(80, 66);
            this.buttonEnter.TabIndex = 19;
            this.buttonEnter.Text = "ENTER";
            this.buttonEnter.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.AutoSize = true;
            this.buttonClear.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(171, 279);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 66);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonNum0
            // 
            this.buttonNum0.AutoSize = true;
            this.buttonNum0.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum0.FlatAppearance.BorderSize = 0;
            this.buttonNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum0.Location = new System.Drawing.Point(87, 279);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(78, 66);
            this.buttonNum0.TabIndex = 17;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = false;
            this.buttonNum0.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.AutoSize = true;
            this.buttonComma.BackColor = System.Drawing.Color.DarkGray;
            this.buttonComma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonComma.FlatAppearance.BorderSize = 0;
            this.buttonComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComma.Location = new System.Drawing.Point(3, 279);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(78, 66);
            this.buttonComma.TabIndex = 16;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = false;
            // 
            // buttonSum
            // 
            this.buttonSum.AutoSize = true;
            this.buttonSum.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSum.FlatAppearance.BorderSize = 0;
            this.buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSum.ForeColor = System.Drawing.Color.White;
            this.buttonSum.Location = new System.Drawing.Point(255, 210);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(80, 63);
            this.buttonSum.TabIndex = 15;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = false;
            // 
            // buttonNum3
            // 
            this.buttonNum3.AutoSize = true;
            this.buttonNum3.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum3.FlatAppearance.BorderSize = 0;
            this.buttonNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum3.Location = new System.Drawing.Point(171, 210);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(78, 63);
            this.buttonNum3.TabIndex = 14;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = false;
            this.buttonNum3.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.AutoSize = true;
            this.buttonNum2.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum2.FlatAppearance.BorderSize = 0;
            this.buttonNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum2.Location = new System.Drawing.Point(87, 210);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(78, 63);
            this.buttonNum2.TabIndex = 13;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = false;
            this.buttonNum2.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonNum1
            // 
            this.buttonNum1.AutoSize = true;
            this.buttonNum1.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum1.FlatAppearance.BorderSize = 0;
            this.buttonNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum1.Location = new System.Drawing.Point(3, 210);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(78, 63);
            this.buttonNum1.TabIndex = 12;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = false;
            this.buttonNum1.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.AutoSize = true;
            this.buttonSubtract.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubtract.FlatAppearance.BorderSize = 0;
            this.buttonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.ForeColor = System.Drawing.Color.White;
            this.buttonSubtract.Location = new System.Drawing.Point(255, 141);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(80, 63);
            this.buttonSubtract.TabIndex = 11;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            // 
            // buttonNum6
            // 
            this.buttonNum6.AutoSize = true;
            this.buttonNum6.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum6.FlatAppearance.BorderSize = 0;
            this.buttonNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum6.Location = new System.Drawing.Point(171, 141);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(78, 63);
            this.buttonNum6.TabIndex = 10;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = false;
            this.buttonNum6.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.AutoSize = true;
            this.buttonNum5.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum5.FlatAppearance.BorderSize = 0;
            this.buttonNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum5.Location = new System.Drawing.Point(87, 141);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(78, 63);
            this.buttonNum5.TabIndex = 9;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = false;
            this.buttonNum5.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.AutoSize = true;
            this.buttonNum4.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum4.FlatAppearance.BorderSize = 0;
            this.buttonNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum4.Location = new System.Drawing.Point(3, 141);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(78, 63);
            this.buttonNum4.TabIndex = 8;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = false;
            this.buttonNum4.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonMultiplicator
            // 
            this.buttonMultiplicator.AutoSize = true;
            this.buttonMultiplicator.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonMultiplicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiplicator.FlatAppearance.BorderSize = 0;
            this.buttonMultiplicator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplicator.ForeColor = System.Drawing.Color.White;
            this.buttonMultiplicator.Location = new System.Drawing.Point(255, 72);
            this.buttonMultiplicator.Name = "buttonMultiplicator";
            this.buttonMultiplicator.Size = new System.Drawing.Size(80, 63);
            this.buttonMultiplicator.TabIndex = 7;
            this.buttonMultiplicator.Text = "*";
            this.buttonMultiplicator.UseVisualStyleBackColor = false;
            // 
            // buttonNum9
            // 
            this.buttonNum9.AutoSize = true;
            this.buttonNum9.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum9.FlatAppearance.BorderSize = 0;
            this.buttonNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum9.Location = new System.Drawing.Point(171, 72);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(78, 63);
            this.buttonNum9.TabIndex = 6;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = false;
            this.buttonNum9.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.AutoSize = true;
            this.buttonNum8.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum8.FlatAppearance.BorderSize = 0;
            this.buttonNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum8.Location = new System.Drawing.Point(87, 72);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(78, 63);
            this.buttonNum8.TabIndex = 5;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = false;
            this.buttonNum8.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonNum7
            // 
            this.buttonNum7.AutoSize = true;
            this.buttonNum7.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNum7.FlatAppearance.BorderSize = 0;
            this.buttonNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNum7.Location = new System.Drawing.Point(3, 72);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(78, 63);
            this.buttonNum7.TabIndex = 4;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = false;
            this.buttonNum7.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.AutoSize = true;
            this.buttonDivision.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDivision.FlatAppearance.BorderSize = 0;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.ForeColor = System.Drawing.Color.White;
            this.buttonDivision.Location = new System.Drawing.Point(255, 3);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(80, 63);
            this.buttonDivision.TabIndex = 3;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(171, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(87, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // tableLayoutPanelDisplay
            // 
            this.tableLayoutPanelDisplay.ColumnCount = 2;
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelDisplay.Controls.Add(this.listBoxRowsValues, 0, 0);
            this.tableLayoutPanelDisplay.Controls.Add(this.listBoxRowsNum, 0, 0);
            this.tableLayoutPanelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDisplay.Enabled = false;
            this.tableLayoutPanelDisplay.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelDisplay.Name = "tableLayoutPanelDisplay";
            this.tableLayoutPanelDisplay.RowCount = 1;
            this.tableLayoutPanelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDisplay.Size = new System.Drawing.Size(338, 241);
            this.tableLayoutPanelDisplay.TabIndex = 1;
            // 
            // listBoxRowsValues
            // 
            this.listBoxRowsValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRowsValues.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRowsValues.FormattingEnabled = true;
            this.listBoxRowsValues.ItemHeight = 22;
            this.listBoxRowsValues.Location = new System.Drawing.Point(72, 3);
            this.listBoxRowsValues.Name = "listBoxRowsValues";
            this.listBoxRowsValues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxRowsValues.Size = new System.Drawing.Size(263, 235);
            this.listBoxRowsValues.TabIndex = 3;
            // 
            // listBoxRowsNum
            // 
            this.listBoxRowsNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRowsNum.Enabled = false;
            this.listBoxRowsNum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRowsNum.FormattingEnabled = true;
            this.listBoxRowsNum.ItemHeight = 22;
            this.listBoxRowsNum.Items.AddRange(new object[] {
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
            this.listBoxRowsNum.Size = new System.Drawing.Size(63, 235);
            this.listBoxRowsNum.TabIndex = 2;
            // 
            // FormMainCalc
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 601);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(360, 640);
            this.MinimumSize = new System.Drawing.Size(360, 640);
            this.Name = "FormMainCalc";
            this.Text = "RPN Calculator";
            this.Load += new System.EventHandler(this.FormMainCalc_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMainCalc_KeyPress);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelKeys.ResumeLayout(false);
            this.tableLayoutPanelKeys.PerformLayout();
            this.tableLayoutPanelDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKeys;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDisplay;
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

