
namespace Program
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectDataBase = new System.Windows.Forms.Button();
            this.bCatDishes = new System.Windows.Forms.Button();
            this.bDesks = new System.Windows.Forms.Button();
            this.bOrders = new System.Windows.Forms.Button();
            this.bOrderList = new System.Windows.Forms.Button();
            this.bCat = new System.Windows.Forms.Button();
            this.bDishes = new System.Windows.Forms.Button();
            this.bClients = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ресторан";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.connectDataBase, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bCatDishes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bDesks, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.bOrders, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bOrderList, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bCat, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.bDishes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bClients, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 227);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(415, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Подключение";
            // 
            // connectDataBase
            // 
            this.connectDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectDataBase.Location = new System.Drawing.Point(415, 63);
            this.connectDataBase.Name = "connectDataBase";
            this.connectDataBase.Size = new System.Drawing.Size(197, 34);
            this.connectDataBase.TabIndex = 9;
            this.connectDataBase.Text = "Подключение";
            this.connectDataBase.UseVisualStyleBackColor = true;
            this.connectDataBase.Click += new System.EventHandler(this.connectDataBase_Click);
            // 
            // bCatDishes
            // 
            this.bCatDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCatDishes.Location = new System.Drawing.Point(209, 63);
            this.bCatDishes.Name = "bCatDishes";
            this.bCatDishes.Size = new System.Drawing.Size(200, 34);
            this.bCatDishes.TabIndex = 16;
            this.bCatDishes.Text = "Категории блюд";
            this.bCatDishes.UseVisualStyleBackColor = true;
            this.bCatDishes.Click += new System.EventHandler(this.TableClick);
            // 
            // bDesks
            // 
            this.bDesks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDesks.Location = new System.Drawing.Point(209, 143);
            this.bDesks.Name = "bDesks";
            this.bDesks.Size = new System.Drawing.Size(200, 34);
            this.bDesks.TabIndex = 17;
            this.bDesks.Text = "Столы";
            this.bDesks.UseVisualStyleBackColor = true;
            this.bDesks.Click += new System.EventHandler(this.TableClick);
            // 
            // bOrders
            // 
            this.bOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOrders.Location = new System.Drawing.Point(3, 103);
            this.bOrders.Name = "bOrders";
            this.bOrders.Size = new System.Drawing.Size(200, 34);
            this.bOrders.TabIndex = 1;
            this.bOrders.Text = "Заказы";
            this.bOrders.UseVisualStyleBackColor = true;
            this.bOrders.Click += new System.EventHandler(this.TableClick);
            // 
            // bOrderList
            // 
            this.bOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bOrderList.Location = new System.Drawing.Point(3, 143);
            this.bOrderList.Name = "bOrderList";
            this.bOrderList.Size = new System.Drawing.Size(200, 34);
            this.bOrderList.TabIndex = 4;
            this.bOrderList.Text = "Состав заказов";
            this.bOrderList.UseVisualStyleBackColor = true;
            this.bOrderList.Click += new System.EventHandler(this.TableClick);
            // 
            // bCat
            // 
            this.bCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCat.Location = new System.Drawing.Point(3, 183);
            this.bCat.Name = "bCat";
            this.bCat.Size = new System.Drawing.Size(200, 34);
            this.bCat.TabIndex = 22;
            this.bCat.Text = "Категории";
            this.bCat.UseVisualStyleBackColor = true;
            this.bCat.Click += new System.EventHandler(this.TableClick);
            // 
            // bDishes
            // 
            this.bDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDishes.Location = new System.Drawing.Point(3, 63);
            this.bDishes.Name = "bDishes";
            this.bDishes.Size = new System.Drawing.Size(200, 34);
            this.bDishes.TabIndex = 19;
            this.bDishes.Text = "Меню";
            this.bDishes.UseVisualStyleBackColor = true;
            this.bDishes.Click += new System.EventHandler(this.TableClick);
            // 
            // bClients
            // 
            this.bClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClients.Location = new System.Drawing.Point(209, 103);
            this.bClients.Name = "bClients";
            this.bClients.Size = new System.Drawing.Size(200, 34);
            this.bClients.TabIndex = 0;
            this.bClients.Text = "Клиенты";
            this.bClients.UseVisualStyleBackColor = true;
            this.bClients.Click += new System.EventHandler(this.TableClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 246);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.Text = "Программа";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button connectDataBase;
        private System.Windows.Forms.Button bOrderList;
        private System.Windows.Forms.Button bOrders;
        private System.Windows.Forms.Button bClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCatDishes;
        private System.Windows.Forms.Button bDesks;
        private System.Windows.Forms.Button bDishes;
        private System.Windows.Forms.Button bCat;
    }
}

