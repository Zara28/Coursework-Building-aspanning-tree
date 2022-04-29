namespace Ostovnoe_derevo
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMST = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHelpText = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCreate = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.button_Random = new System.Windows.Forms.Button();
            this.tabPageChange = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEdge = new System.Windows.Forms.Label();
            this.labelVer = new System.Windows.Forms.Label();
            this.buttonDeleteEdge = new System.Windows.Forms.Button();
            this.buttonAddEdge = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_w = new System.Windows.Forms.TextBox();
            this.textBox_s = new System.Windows.Forms.TextBox();
            this.textBox_f = new System.Windows.Forms.TextBox();
            this.textBox_edge_New_Ver = new System.Windows.Forms.TextBox();
            this.textBox_Add_Ver = new System.Windows.Forms.TextBox();
            this.tabPageAlgorithm = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageCreate.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPageChange.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPageAlgorithm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Граф",
            "Алгоритм Прима",
            "Алгоритм Краскала",
            "Алгоритм Борувки",
            "Алгоритм обратного удаления"});
            this.comboBox1.Location = new System.Drawing.Point(3, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 703);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelMST
            // 
            this.labelMST.AutoSize = true;
            this.labelMST.Location = new System.Drawing.Point(3, 115);
            this.labelMST.Name = "labelMST";
            this.labelMST.Size = new System.Drawing.Size(340, 20);
            this.labelMST.TabIndex = 3;
            this.labelMST.Text = "Минимальное остовное дерево состоит из:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(8, 321);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(94, 20);
            this.labelWeight.TabIndex = 4;
            this.labelWeight.Text = "Вес остова";
            // 
            // labelHelpText
            // 
            this.labelHelpText.AutoSize = true;
            this.labelHelpText.Location = new System.Drawing.Point(8, 19);
            this.labelHelpText.Name = "labelHelpText";
            this.labelHelpText.Size = new System.Drawing.Size(162, 20);
            this.labelHelpText.TabIndex = 5;
            this.labelHelpText.Text = "Выберите алгоритм";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCreate);
            this.tabControl1.Controls.Add(this.tabPageChange);
            this.tabControl1.Controls.Add(this.tabPageAlgorithm);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1158, 742);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.Controls.Add(this.tableLayoutPanel2);
            this.tabPageCreate.Location = new System.Drawing.Point(4, 29);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Size = new System.Drawing.Size(1150, 709);
            this.tabPageCreate.TabIndex = 2;
            this.tabPageCreate.Text = "Создать граф";
            this.tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.21739F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.78261F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1150, 709);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(605, 703);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.buttonCreate);
            this.panel2.Controls.Add(this.textBox_Count);
            this.panel2.Controls.Add(this.button_Random);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(614, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 703);
            this.panel2.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(338, 65);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(167, 37);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(338, 29);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(167, 30);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBox_Count
            // 
            this.textBox_Count.AccessibleDescription = "";
            this.textBox_Count.Location = new System.Drawing.Point(24, 28);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(138, 26);
            this.textBox_Count.TabIndex = 1;
            // 
            // button_Random
            // 
            this.button_Random.Location = new System.Drawing.Point(165, 28);
            this.button_Random.Name = "button_Random";
            this.button_Random.Size = new System.Drawing.Size(167, 31);
            this.button_Random.TabIndex = 0;
            this.button_Random.Text = "Сгенерировать";
            this.button_Random.UseVisualStyleBackColor = true;
            this.button_Random.Click += new System.EventHandler(this.button_Random_Click);
            // 
            // tabPageChange
            // 
            this.tabPageChange.Controls.Add(this.tableLayoutPanel3);
            this.tabPageChange.Location = new System.Drawing.Point(4, 29);
            this.tabPageChange.Name = "tabPageChange";
            this.tabPageChange.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChange.Size = new System.Drawing.Size(1150, 709);
            this.tabPageChange.TabIndex = 1;
            this.tabPageChange.Text = "Редактировать граф";
            this.tabPageChange.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1144, 703);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(566, 697);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.labelEdge);
            this.panel3.Controls.Add(this.labelVer);
            this.panel3.Controls.Add(this.buttonDeleteEdge);
            this.panel3.Controls.Add(this.buttonAddEdge);
            this.panel3.Controls.Add(this.buttonDelete);
            this.panel3.Controls.Add(this.button_Add);
            this.panel3.Controls.Add(this.textBox_w);
            this.panel3.Controls.Add(this.textBox_s);
            this.panel3.Controls.Add(this.textBox_f);
            this.panel3.Controls.Add(this.textBox_edge_New_Ver);
            this.panel3.Controls.Add(this.textBox_Add_Ver);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(575, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 697);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Добавить новое ребро";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Добавить новую вершину";
            // 
            // labelEdge
            // 
            this.labelEdge.AutoSize = true;
            this.labelEdge.Location = new System.Drawing.Point(371, 302);
            this.labelEdge.Name = "labelEdge";
            this.labelEdge.Size = new System.Drawing.Size(112, 20);
            this.labelEdge.TabIndex = 10;
            this.labelEdge.Text = "Список ребер";
            // 
            // labelVer
            // 
            this.labelVer.AutoSize = true;
            this.labelVer.Location = new System.Drawing.Point(32, 302);
            this.labelVer.Name = "labelVer";
            this.labelVer.Size = new System.Drawing.Size(125, 20);
            this.labelVer.TabIndex = 9;
            this.labelVer.Text = "Список вершин";
            // 
            // buttonDeleteEdge
            // 
            this.buttonDeleteEdge.Location = new System.Drawing.Point(375, 223);
            this.buttonDeleteEdge.Name = "buttonDeleteEdge";
            this.buttonDeleteEdge.Size = new System.Drawing.Size(94, 34);
            this.buttonDeleteEdge.TabIndex = 8;
            this.buttonDeleteEdge.Text = "Удалить";
            this.buttonDeleteEdge.UseVisualStyleBackColor = true;
            this.buttonDeleteEdge.Click += new System.EventHandler(this.buttonDeleteEdge_Click);
            // 
            // buttonAddEdge
            // 
            this.buttonAddEdge.Location = new System.Drawing.Point(375, 170);
            this.buttonAddEdge.Name = "buttonAddEdge";
            this.buttonAddEdge.Size = new System.Drawing.Size(94, 47);
            this.buttonAddEdge.TabIndex = 7;
            this.buttonAddEdge.Text = "Добавить";
            this.buttonAddEdge.UseVisualStyleBackColor = true;
            this.buttonAddEdge.Click += new System.EventHandler(this.buttonAddEdge_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(244, 56);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 49);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(127, 56);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(111, 49);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_w
            // 
            this.textBox_w.Location = new System.Drawing.Point(264, 201);
            this.textBox_w.Name = "textBox_w";
            this.textBox_w.Size = new System.Drawing.Size(100, 26);
            this.textBox_w.TabIndex = 4;
            // 
            // textBox_s
            // 
            this.textBox_s.Location = new System.Drawing.Point(143, 201);
            this.textBox_s.Name = "textBox_s";
            this.textBox_s.Size = new System.Drawing.Size(100, 26);
            this.textBox_s.TabIndex = 3;
            // 
            // textBox_f
            // 
            this.textBox_f.Location = new System.Drawing.Point(21, 202);
            this.textBox_f.Name = "textBox_f";
            this.textBox_f.Size = new System.Drawing.Size(100, 26);
            this.textBox_f.TabIndex = 2;
            // 
            // textBox_edge_New_Ver
            // 
            this.textBox_edge_New_Ver.Location = new System.Drawing.Point(21, 100);
            this.textBox_edge_New_Ver.Name = "textBox_edge_New_Ver";
            this.textBox_edge_New_Ver.Size = new System.Drawing.Size(100, 26);
            this.textBox_edge_New_Ver.TabIndex = 1;
            // 
            // textBox_Add_Ver
            // 
            this.textBox_Add_Ver.Location = new System.Drawing.Point(21, 56);
            this.textBox_Add_Ver.Name = "textBox_Add_Ver";
            this.textBox_Add_Ver.Size = new System.Drawing.Size(100, 26);
            this.textBox_Add_Ver.TabIndex = 0;
            // 
            // tabPageAlgorithm
            // 
            this.tabPageAlgorithm.Controls.Add(this.tableLayoutPanel1);
            this.tabPageAlgorithm.Location = new System.Drawing.Point(4, 29);
            this.tabPageAlgorithm.Name = "tabPageAlgorithm";
            this.tabPageAlgorithm.Size = new System.Drawing.Size(1150, 709);
            this.tabPageAlgorithm.TabIndex = 3;
            this.tabPageAlgorithm.Text = "Создать остовное дерево";
            this.tabPageAlgorithm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 709);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelWeight);
            this.panel1.Controls.Add(this.labelHelpText);
            this.panel1.Controls.Add(this.labelMST);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(808, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 703);
            this.panel1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 742);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCreate.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageChange.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageAlgorithm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMST;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHelpText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCreate;
        private System.Windows.Forms.TabPage tabPageChange;
        private System.Windows.Forms.TabPage tabPageAlgorithm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_Random;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelEdge;
        private System.Windows.Forms.Label labelVer;
        private System.Windows.Forms.Button buttonDeleteEdge;
        private System.Windows.Forms.Button buttonAddEdge;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_w;
        private System.Windows.Forms.TextBox textBox_s;
        private System.Windows.Forms.TextBox textBox_f;
        private System.Windows.Forms.TextBox textBox_edge_New_Ver;
        private System.Windows.Forms.TextBox textBox_Add_Ver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

