
namespace Program
{
    partial class Connect
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
            this.gridMenu = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bLoad = new System.Windows.Forms.Button();
            this.bConnect = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.shema = new System.Windows.Forms.TextBox();
            this.labelDB = new System.Windows.Forms.Label();
            this.gridMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMenu
            // 
            this.gridMenu.ColumnCount = 1;
            this.gridMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridMenu.Controls.Add(this.label1, 0, 0);
            this.gridMenu.Controls.Add(this.bLoad, 0, 10);
            this.gridMenu.Controls.Add(this.bConnect, 0, 9);
            this.gridMenu.Controls.Add(this.password, 0, 8);
            this.gridMenu.Controls.Add(this.labelPassword, 0, 7);
            this.gridMenu.Controls.Add(this.login, 0, 6);
            this.gridMenu.Controls.Add(this.labelLogin, 0, 5);
            this.gridMenu.Controls.Add(this.server, 0, 4);
            this.gridMenu.Controls.Add(this.labelServer, 0, 3);
            this.gridMenu.Controls.Add(this.shema, 0, 2);
            this.gridMenu.Controls.Add(this.labelDB, 0, 1);
            this.gridMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridMenu.Location = new System.Drawing.Point(16, 15);
            this.gridMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.RowCount = 11;
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.gridMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.gridMenu.Size = new System.Drawing.Size(436, 506);
            this.gridMenu.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Подключение";
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(4, 454);
            this.bLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(428, 48);
            this.bLoad.TabIndex = 12;
            this.bLoad.Text = "ТЕСТ: Добавить 5 записей";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(4, 391);
            this.bConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(428, 55);
            this.bConnect.TabIndex = 3;
            this.bConnect.Text = "Подключиться к БД";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(4, 348);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(427, 34);
            this.password.TabIndex = 11;
            this.password.Text = "root";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(4, 301);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(99, 29);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Пароль";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(4, 262);
            this.login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(427, 34);
            this.login.TabIndex = 9;
            this.login.Text = "root";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(4, 215);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(83, 29);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Логин";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(4, 176);
            this.server.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(427, 34);
            this.server.TabIndex = 7;
            this.server.Text = "localhost";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(4, 129);
            this.labelServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(99, 29);
            this.labelServer.TabIndex = 6;
            this.labelServer.Text = "Сервер";
            // 
            // shema
            // 
            this.shema.Location = new System.Drawing.Point(4, 90);
            this.shema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shema.Name = "shema";
            this.shema.Size = new System.Drawing.Size(427, 34);
            this.shema.TabIndex = 5;
            this.shema.Text = "restoran";
            // 
            // labelDB
            // 
            this.labelDB.AutoSize = true;
            this.labelDB.Location = new System.Drawing.Point(4, 43);
            this.labelDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDB.Name = "labelDB";
            this.labelDB.Size = new System.Drawing.Size(158, 29);
            this.labelDB.TabIndex = 4;
            this.labelDB.Text = "База данных";
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 550);
            this.Controls.Add(this.gridMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Connect";
            this.Text = "Подключение";
            this.gridMenu.ResumeLayout(false);
            this.gridMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gridMenu;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Label labelDB;
        private System.Windows.Forms.TextBox shema;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Label label1;
    }
}