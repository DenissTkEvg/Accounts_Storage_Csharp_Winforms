namespace PasswordsStorage
{
    partial class MainForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_Page = new System.Windows.Forms.TabPage();
            this.EmptyFieldErrorLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchDescrOfAccLabel = new System.Windows.Forms.Label();
            this.SearchIdLabel = new System.Windows.Forms.Label();
            this.SearchDescrOfAccTextBox = new System.Windows.Forms.TextBox();
            this.SearchIdTextBox = new System.Windows.Forms.TextBox();
            this.ResultOfSearchListBox = new System.Windows.Forms.ListBox();
            this.Delete_Or_Update_Page = new System.Windows.Forms.TabPage();
            this.DeleteOrUdpateOneFieldErrorLabel = new System.Windows.Forms.Label();
            this.DeleteOrUpdateIdErrorLabel = new System.Windows.Forms.Label();
            this.DataBaseUdpateButton = new System.Windows.Forms.Button();
            this.DataBaseDeleteButton = new System.Windows.Forms.Button();
            this.DeleteOrUpdateIdLabel = new System.Windows.Forms.Label();
            this.DeleteOrUdpatePasswordLabel = new System.Windows.Forms.Label();
            this.DeleteOrUdpateLoginLabel = new System.Windows.Forms.Label();
            this.DeleteOrUpdateDescriptionOfAccountLabel = new System.Windows.Forms.Label();
            this.DeleteOrUpdatePasswordTextBox = new System.Windows.Forms.TextBox();
            this.DeleteOrUpdateLoginTextBox = new System.Windows.Forms.TextBox();
            this.DeleteOrUdpateDescriptionOfAccountTextBox = new System.Windows.Forms.TextBox();
            this.DeleteOrUpdateIdTextBox = new System.Windows.Forms.TextBox();
            this.Insert_Page = new System.Windows.Forms.TabPage();
            this.InsertErrorLabel = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.DescriptionOfAccountLabel = new System.Windows.Forms.Label();
            this.DescriptionOfAccountTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.Select_Page = new System.Windows.Forms.TabPage();
            this.DataBaseUpdateButton = new System.Windows.Forms.Button();
            this.SelectListBox = new System.Windows.Forms.ListBox();
            this.Tab_Control = new System.Windows.Forms.TabControl();
            this.MainMenu.SuspendLayout();
            this.Search_Page.SuspendLayout();
            this.Delete_Or_Update_Page.SuspendLayout();
            this.Insert_Page.SuspendLayout();
            this.Select_Page.SuspendLayout();
            this.Tab_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.DataBaseToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.MenuItemFile.Text = "Файл";
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CloseToolStripMenuItem.Text = "Выход";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // DataBaseToolStripMenuItem
            // 
            this.DataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateToolStripMenuItem});
            this.DataBaseToolStripMenuItem.Name = "DataBaseToolStripMenuItem";
            this.DataBaseToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.DataBaseToolStripMenuItem.Text = "База данных";
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UpdateToolStripMenuItem.Text = "Обновить";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // Search_Page
            // 
            this.Search_Page.Controls.Add(this.EmptyFieldErrorLabel);
            this.Search_Page.Controls.Add(this.SearchButton);
            this.Search_Page.Controls.Add(this.SearchDescrOfAccLabel);
            this.Search_Page.Controls.Add(this.SearchIdLabel);
            this.Search_Page.Controls.Add(this.SearchDescrOfAccTextBox);
            this.Search_Page.Controls.Add(this.SearchIdTextBox);
            this.Search_Page.Controls.Add(this.ResultOfSearchListBox);
            this.Search_Page.Location = new System.Drawing.Point(4, 22);
            this.Search_Page.Name = "Search_Page";
            this.Search_Page.Size = new System.Drawing.Size(792, 400);
            this.Search_Page.TabIndex = 4;
            this.Search_Page.Text = "Найти";
            this.Search_Page.UseVisualStyleBackColor = true;
            // 
            // EmptyFieldErrorLabel
            // 
            this.EmptyFieldErrorLabel.AutoSize = true;
            this.EmptyFieldErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.EmptyFieldErrorLabel.Location = new System.Drawing.Point(298, 14);
            this.EmptyFieldErrorLabel.Name = "EmptyFieldErrorLabel";
            this.EmptyFieldErrorLabel.Size = new System.Drawing.Size(160, 13);
            this.EmptyFieldErrorLabel.TabIndex = 10;
            this.EmptyFieldErrorLabel.Text = "Заполните хотя бы одно поле!";
            this.EmptyFieldErrorLabel.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(323, 78);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(124, 23);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchDescrOfAccLabel
            // 
            this.SearchDescrOfAccLabel.AutoSize = true;
            this.SearchDescrOfAccLabel.Location = new System.Drawing.Point(363, 46);
            this.SearchDescrOfAccLabel.Name = "SearchDescrOfAccLabel";
            this.SearchDescrOfAccLabel.Size = new System.Drawing.Size(109, 13);
            this.SearchDescrOfAccLabel.TabIndex = 7;
            this.SearchDescrOfAccLabel.Text = "Описание аккаунта:";
            // 
            // SearchIdLabel
            // 
            this.SearchIdLabel.AutoSize = true;
            this.SearchIdLabel.Location = new System.Drawing.Point(225, 46);
            this.SearchIdLabel.Name = "SearchIdLabel";
            this.SearchIdLabel.Size = new System.Drawing.Size(21, 13);
            this.SearchIdLabel.TabIndex = 5;
            this.SearchIdLabel.Text = "ID:";
            // 
            // SearchDescrOfAccTextBox
            // 
            this.SearchDescrOfAccTextBox.Location = new System.Drawing.Point(478, 43);
            this.SearchDescrOfAccTextBox.Name = "SearchDescrOfAccTextBox";
            this.SearchDescrOfAccTextBox.Size = new System.Drawing.Size(107, 20);
            this.SearchDescrOfAccTextBox.TabIndex = 4;
            // 
            // SearchIdTextBox
            // 
            this.SearchIdTextBox.Location = new System.Drawing.Point(252, 43);
            this.SearchIdTextBox.Name = "SearchIdTextBox";
            this.SearchIdTextBox.Size = new System.Drawing.Size(50, 20);
            this.SearchIdTextBox.TabIndex = 1;
            // 
            // ResultOfSearchListBox
            // 
            this.ResultOfSearchListBox.FormattingEnabled = true;
            this.ResultOfSearchListBox.Location = new System.Drawing.Point(3, 107);
            this.ResultOfSearchListBox.Name = "ResultOfSearchListBox";
            this.ResultOfSearchListBox.Size = new System.Drawing.Size(786, 277);
            this.ResultOfSearchListBox.TabIndex = 0;
            // 
            // Delete_Or_Update_Page
            // 
            this.Delete_Or_Update_Page.Controls.Add(this.DeleteOrUdpateOneFieldErrorLabel);
            this.Delete_Or_Update_Page.Controls.Add(this.DeleteOrUpdateIdErrorLabel);
            this.Delete_Or_Update_Page.Controls.Add(this.DataBaseUdpateButton);
            this.Delete_Or_Update_Page.Controls.Add(this.DataBaseDeleteButton);
            this.Delete_Or_Update_Page.Controls.Add(this.DeleteOrUpdateIdLabel);
            this.Delete_Or_Update_Page.Controls.Add(this.DeleteOrUdpatePasswordLabel);
            this.Delete_Or_Update_Page.Controls.Add(this.DeleteOrUdpateLoginLabel);
            this.Delete_Or_Update_Page.Controls.Add(this.DeleteOrUpdateDescriptionOfAccountLabel);
            this.Delete_Or_Update_Page.Controls.Add(this.DeleteOrUpdatePasswordTextBox);
            this.Delete_Or_Update_Page.Controls.Add(this.DeleteOrUpdateLoginTextBox);
            this.Delete_Or_Update_Page.Controls.Add(this.DeleteOrUdpateDescriptionOfAccountTextBox);
            this.Delete_Or_Update_Page.Controls.Add(this.DeleteOrUpdateIdTextBox);
            this.Delete_Or_Update_Page.Location = new System.Drawing.Point(4, 22);
            this.Delete_Or_Update_Page.Name = "Delete_Or_Update_Page";
            this.Delete_Or_Update_Page.Size = new System.Drawing.Size(792, 400);
            this.Delete_Or_Update_Page.TabIndex = 2;
            this.Delete_Or_Update_Page.Text = "Удалить/Изменить";
            this.Delete_Or_Update_Page.UseVisualStyleBackColor = true;
            // 
            // DeleteOrUdpateOneFieldErrorLabel
            // 
            this.DeleteOrUdpateOneFieldErrorLabel.AutoSize = true;
            this.DeleteOrUdpateOneFieldErrorLabel.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteOrUdpateOneFieldErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.DeleteOrUdpateOneFieldErrorLabel.Location = new System.Drawing.Point(492, 144);
            this.DeleteOrUdpateOneFieldErrorLabel.Name = "DeleteOrUdpateOneFieldErrorLabel";
            this.DeleteOrUdpateOneFieldErrorLabel.Size = new System.Drawing.Size(283, 19);
            this.DeleteOrUdpateOneFieldErrorLabel.TabIndex = 11;
            this.DeleteOrUdpateOneFieldErrorLabel.Text = "Одно из полей должно быть заполнено!";
            this.DeleteOrUdpateOneFieldErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteOrUdpateOneFieldErrorLabel.Visible = false;
            // 
            // DeleteOrUpdateIdErrorLabel
            // 
            this.DeleteOrUpdateIdErrorLabel.AutoSize = true;
            this.DeleteOrUpdateIdErrorLabel.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteOrUpdateIdErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.DeleteOrUpdateIdErrorLabel.Location = new System.Drawing.Point(30, 84);
            this.DeleteOrUpdateIdErrorLabel.Name = "DeleteOrUpdateIdErrorLabel";
            this.DeleteOrUpdateIdErrorLabel.Size = new System.Drawing.Size(184, 19);
            this.DeleteOrUpdateIdErrorLabel.TabIndex = 10;
            this.DeleteOrUpdateIdErrorLabel.Text = "Укажите идентификатор!";
            this.DeleteOrUpdateIdErrorLabel.Visible = false;
            // 
            // DataBaseUdpateButton
            // 
            this.DataBaseUdpateButton.Location = new System.Drawing.Point(476, 265);
            this.DataBaseUdpateButton.Name = "DataBaseUdpateButton";
            this.DataBaseUdpateButton.Size = new System.Drawing.Size(158, 38);
            this.DataBaseUdpateButton.TabIndex = 9;
            this.DataBaseUdpateButton.Text = "Изменить";
            this.DataBaseUdpateButton.UseVisualStyleBackColor = true;
            this.DataBaseUdpateButton.Click += new System.EventHandler(this.UpdateFieldButton_Click);
            // 
            // DataBaseDeleteButton
            // 
            this.DataBaseDeleteButton.Location = new System.Drawing.Point(162, 264);
            this.DataBaseDeleteButton.Name = "DataBaseDeleteButton";
            this.DataBaseDeleteButton.Size = new System.Drawing.Size(167, 39);
            this.DataBaseDeleteButton.TabIndex = 8;
            this.DataBaseDeleteButton.Text = "Удалить из базы данных";
            this.DataBaseDeleteButton.UseVisualStyleBackColor = true;
            this.DataBaseDeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteOrUpdateIdLabel
            // 
            this.DeleteOrUpdateIdLabel.AutoSize = true;
            this.DeleteOrUpdateIdLabel.Location = new System.Drawing.Point(79, 55);
            this.DeleteOrUpdateIdLabel.Name = "DeleteOrUpdateIdLabel";
            this.DeleteOrUpdateIdLabel.Size = new System.Drawing.Size(21, 13);
            this.DeleteOrUpdateIdLabel.TabIndex = 7;
            this.DeleteOrUpdateIdLabel.Text = "ID:";
            // 
            // DeleteOrUdpatePasswordLabel
            // 
            this.DeleteOrUdpatePasswordLabel.AutoSize = true;
            this.DeleteOrUdpatePasswordLabel.Location = new System.Drawing.Point(281, 187);
            this.DeleteOrUdpatePasswordLabel.Name = "DeleteOrUdpatePasswordLabel";
            this.DeleteOrUdpatePasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.DeleteOrUdpatePasswordLabel.TabIndex = 6;
            this.DeleteOrUdpatePasswordLabel.Text = "Пароль:";
            // 
            // DeleteOrUdpateLoginLabel
            // 
            this.DeleteOrUdpateLoginLabel.AutoSize = true;
            this.DeleteOrUdpateLoginLabel.Location = new System.Drawing.Point(281, 120);
            this.DeleteOrUdpateLoginLabel.Name = "DeleteOrUdpateLoginLabel";
            this.DeleteOrUdpateLoginLabel.Size = new System.Drawing.Size(41, 13);
            this.DeleteOrUdpateLoginLabel.TabIndex = 5;
            this.DeleteOrUdpateLoginLabel.Text = "Логин:";
            // 
            // DeleteOrUpdateDescriptionOfAccountLabel
            // 
            this.DeleteOrUpdateDescriptionOfAccountLabel.AutoSize = true;
            this.DeleteOrUpdateDescriptionOfAccountLabel.Location = new System.Drawing.Point(281, 59);
            this.DeleteOrUpdateDescriptionOfAccountLabel.Name = "DeleteOrUpdateDescriptionOfAccountLabel";
            this.DeleteOrUpdateDescriptionOfAccountLabel.Size = new System.Drawing.Size(141, 13);
            this.DeleteOrUpdateDescriptionOfAccountLabel.TabIndex = 4;
            this.DeleteOrUpdateDescriptionOfAccountLabel.Text = "Описание учетной записи:";
            // 
            // DeleteOrUpdatePasswordTextBox
            // 
            this.DeleteOrUpdatePasswordTextBox.Location = new System.Drawing.Point(284, 213);
            this.DeleteOrUpdatePasswordTextBox.Name = "DeleteOrUpdatePasswordTextBox";
            this.DeleteOrUpdatePasswordTextBox.Size = new System.Drawing.Size(180, 20);
            this.DeleteOrUpdatePasswordTextBox.TabIndex = 3;
            // 
            // DeleteOrUpdateLoginTextBox
            // 
            this.DeleteOrUpdateLoginTextBox.Location = new System.Drawing.Point(284, 145);
            this.DeleteOrUpdateLoginTextBox.Name = "DeleteOrUpdateLoginTextBox";
            this.DeleteOrUpdateLoginTextBox.Size = new System.Drawing.Size(180, 20);
            this.DeleteOrUpdateLoginTextBox.TabIndex = 2;
            // 
            // DeleteOrUdpateDescriptionOfAccountTextBox
            // 
            this.DeleteOrUdpateDescriptionOfAccountTextBox.Location = new System.Drawing.Point(284, 84);
            this.DeleteOrUdpateDescriptionOfAccountTextBox.Name = "DeleteOrUdpateDescriptionOfAccountTextBox";
            this.DeleteOrUdpateDescriptionOfAccountTextBox.Size = new System.Drawing.Size(180, 20);
            this.DeleteOrUdpateDescriptionOfAccountTextBox.TabIndex = 1;
            // 
            // DeleteOrUpdateIdTextBox
            // 
            this.DeleteOrUpdateIdTextBox.Location = new System.Drawing.Point(106, 52);
            this.DeleteOrUpdateIdTextBox.Name = "DeleteOrUpdateIdTextBox";
            this.DeleteOrUpdateIdTextBox.Size = new System.Drawing.Size(70, 20);
            this.DeleteOrUpdateIdTextBox.TabIndex = 0;
            // 
            // Insert_Page
            // 
            this.Insert_Page.Controls.Add(this.InsertErrorLabel);
            this.Insert_Page.Controls.Add(this.InsertButton);
            this.Insert_Page.Controls.Add(this.PasswordLabel);
            this.Insert_Page.Controls.Add(this.LoginLabel);
            this.Insert_Page.Controls.Add(this.DescriptionOfAccountLabel);
            this.Insert_Page.Controls.Add(this.DescriptionOfAccountTextBox);
            this.Insert_Page.Controls.Add(this.PasswordTextBox);
            this.Insert_Page.Controls.Add(this.LoginTextBox);
            this.Insert_Page.Location = new System.Drawing.Point(4, 22);
            this.Insert_Page.Name = "Insert_Page";
            this.Insert_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Insert_Page.Size = new System.Drawing.Size(792, 400);
            this.Insert_Page.TabIndex = 1;
            this.Insert_Page.Text = "Добавить";
            this.Insert_Page.UseVisualStyleBackColor = true;
            // 
            // InsertErrorLabel
            // 
            this.InsertErrorLabel.AutoSize = true;
            this.InsertErrorLabel.Font = new System.Drawing.Font("NewsGoth BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.InsertErrorLabel.Location = new System.Drawing.Point(257, 191);
            this.InsertErrorLabel.Name = "InsertErrorLabel";
            this.InsertErrorLabel.Size = new System.Drawing.Size(296, 19);
            this.InsertErrorLabel.TabIndex = 7;
            this.InsertErrorLabel.Text = "Не все поля заполнены. Повторите ввод!";
            this.InsertErrorLabel.Visible = false;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(320, 229);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(170, 35);
            this.InsertButton.TabIndex = 6;
            this.InsertButton.Text = "Добавить в базу данных";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(277, 144);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(284, 99);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(41, 13);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Логин:";
            // 
            // DescriptionOfAccountLabel
            // 
            this.DescriptionOfAccountLabel.AutoSize = true;
            this.DescriptionOfAccountLabel.Location = new System.Drawing.Point(184, 55);
            this.DescriptionOfAccountLabel.Name = "DescriptionOfAccountLabel";
            this.DescriptionOfAccountLabel.Size = new System.Drawing.Size(141, 13);
            this.DescriptionOfAccountLabel.TabIndex = 3;
            this.DescriptionOfAccountLabel.Text = "Описание учетной записи:";
            // 
            // DescriptionOfAccountTextBox
            // 
            this.DescriptionOfAccountTextBox.Location = new System.Drawing.Point(331, 52);
            this.DescriptionOfAccountTextBox.Name = "DescriptionOfAccountTextBox";
            this.DescriptionOfAccountTextBox.Size = new System.Drawing.Size(182, 20);
            this.DescriptionOfAccountTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(331, 144);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(182, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(331, 96);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(182, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // Select_Page
            // 
            this.Select_Page.Controls.Add(this.DataBaseUpdateButton);
            this.Select_Page.Controls.Add(this.SelectListBox);
            this.Select_Page.Location = new System.Drawing.Point(4, 22);
            this.Select_Page.Name = "Select_Page";
            this.Select_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Select_Page.Size = new System.Drawing.Size(792, 400);
            this.Select_Page.TabIndex = 0;
            this.Select_Page.Text = "Отобразить все данные";
            this.Select_Page.UseVisualStyleBackColor = true;
            // 
            // DataBaseUpdateButton
            // 
            this.DataBaseUpdateButton.Location = new System.Drawing.Point(310, 20);
            this.DataBaseUpdateButton.Name = "DataBaseUpdateButton";
            this.DataBaseUpdateButton.Size = new System.Drawing.Size(171, 30);
            this.DataBaseUpdateButton.TabIndex = 1;
            this.DataBaseUpdateButton.Text = "Обновить базу данных";
            this.DataBaseUpdateButton.UseVisualStyleBackColor = true;
            this.DataBaseUpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SelectListBox
            // 
            this.SelectListBox.FormattingEnabled = true;
            this.SelectListBox.Location = new System.Drawing.Point(0, 56);
            this.SelectListBox.Name = "SelectListBox";
            this.SelectListBox.Size = new System.Drawing.Size(786, 329);
            this.SelectListBox.TabIndex = 0;
            // 
            // Tab_Control
            // 
            this.Tab_Control.AllowDrop = true;
            this.Tab_Control.Controls.Add(this.Select_Page);
            this.Tab_Control.Controls.Add(this.Insert_Page);
            this.Tab_Control.Controls.Add(this.Delete_Or_Update_Page);
            this.Tab_Control.Controls.Add(this.Search_Page);
            this.Tab_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Control.Location = new System.Drawing.Point(0, 24);
            this.Tab_Control.Name = "Tab_Control";
            this.Tab_Control.SelectedIndex = 0;
            this.Tab_Control.Size = new System.Drawing.Size(800, 426);
            this.Tab_Control.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tab_Control);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Хранилище учетных записей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.Search_Page.ResumeLayout(false);
            this.Search_Page.PerformLayout();
            this.Delete_Or_Update_Page.ResumeLayout(false);
            this.Delete_Or_Update_Page.PerformLayout();
            this.Insert_Page.ResumeLayout(false);
            this.Insert_Page.PerformLayout();
            this.Select_Page.ResumeLayout(false);
            this.Tab_Control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.TabPage Search_Page;
        private System.Windows.Forms.Label SearchIdLabel;
        private System.Windows.Forms.TextBox SearchIdTextBox;
        private System.Windows.Forms.ListBox ResultOfSearchListBox;
        private System.Windows.Forms.TabPage Delete_Or_Update_Page;
        private System.Windows.Forms.Button DataBaseUdpateButton;
        private System.Windows.Forms.Button DataBaseDeleteButton;
        private System.Windows.Forms.Label DeleteOrUpdateIdLabel;
        private System.Windows.Forms.Label DeleteOrUdpatePasswordLabel;
        private System.Windows.Forms.Label DeleteOrUdpateLoginLabel;
        private System.Windows.Forms.Label DeleteOrUpdateDescriptionOfAccountLabel;
        private System.Windows.Forms.TextBox DeleteOrUpdatePasswordTextBox;
        private System.Windows.Forms.TextBox DeleteOrUpdateLoginTextBox;
        private System.Windows.Forms.TextBox DeleteOrUdpateDescriptionOfAccountTextBox;
        private System.Windows.Forms.TextBox DeleteOrUpdateIdTextBox;
        private System.Windows.Forms.TabPage Insert_Page;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label DescriptionOfAccountLabel;
        private System.Windows.Forms.TextBox DescriptionOfAccountTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TabPage Select_Page;
        private System.Windows.Forms.Button DataBaseUpdateButton;
        private System.Windows.Forms.ListBox SelectListBox;
        private System.Windows.Forms.TabControl Tab_Control;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label SearchDescrOfAccLabel;
        private System.Windows.Forms.Label InsertErrorLabel;
        private System.Windows.Forms.Label DeleteOrUpdateIdErrorLabel;
        private System.Windows.Forms.Label DeleteOrUdpateOneFieldErrorLabel;
        private System.Windows.Forms.Label EmptyFieldErrorLabel;
        private System.Windows.Forms.TextBox SearchDescrOfAccTextBox;
    }
}

