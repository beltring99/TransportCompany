﻿namespace CourseWork
{
    partial class Catalog
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
            this.informationGridView = new System.Windows.Forms.DataGridView();
            this.addFavouritesButton = new System.Windows.Forms.Button();
            this.detailedInfoButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.informationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // informationGridView
            // 
            this.informationGridView.AllowUserToAddRows = false;
            this.informationGridView.AllowUserToDeleteRows = false;
            this.informationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.cost,
            this.weight,
            this.volume});
            this.informationGridView.Location = new System.Drawing.Point(209, 12);
            this.informationGridView.Name = "informationGridView";
            this.informationGridView.RowHeadersWidth = 51;
            this.informationGridView.RowTemplate.Height = 24;
            this.informationGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.informationGridView.Size = new System.Drawing.Size(408, 403);
            this.informationGridView.TabIndex = 2;
            // 
            // addFavouritesButton
            // 
            this.addFavouritesButton.Location = new System.Drawing.Point(12, 12);
            this.addFavouritesButton.Name = "addFavouritesButton";
            this.addFavouritesButton.Size = new System.Drawing.Size(191, 64);
            this.addFavouritesButton.TabIndex = 3;
            this.addFavouritesButton.Text = "Добавить в избранное";
            this.addFavouritesButton.UseVisualStyleBackColor = true;
            this.addFavouritesButton.Visible = false;
            this.addFavouritesButton.Click += new System.EventHandler(this.AddToFavourites);
            // 
            // detailedInfoButton
            // 
            this.detailedInfoButton.Location = new System.Drawing.Point(12, 100);
            this.detailedInfoButton.Name = "detailedInfoButton";
            this.detailedInfoButton.Size = new System.Drawing.Size(191, 64);
            this.detailedInfoButton.TabIndex = 4;
            this.detailedInfoButton.Text = "Просмотр подробной информации";
            this.detailedInfoButton.UseVisualStyleBackColor = true;
            this.detailedInfoButton.Visible = false;
            this.detailedInfoButton.Click += new System.EventHandler(this.DetailedInformation);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 64);
            this.button3.TabIndex = 5;
            this.button3.Text = "Взять заказ на выполнение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.StatusChange);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 64);
            this.button4.TabIndex = 6;
            this.button4.Text = "Вернуться на страницу пользователя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.ExitToUserPage);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // cost
            // 
            this.cost.HeaderText = "Стоимость";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            // 
            // weight
            // 
            this.weight.HeaderText = "Вес";
            this.weight.MinimumWidth = 6;
            this.weight.Name = "weight";
            this.weight.Width = 60;
            // 
            // volume
            // 
            this.volume.HeaderText = "Объём";
            this.volume.MinimumWidth = 6;
            this.volume.Name = "volume";
            this.volume.Width = 70;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 420);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.detailedInfoButton);
            this.Controls.Add(this.addFavouritesButton);
            this.Controls.Add(this.informationGridView);
            this.Name = "Catalog";
            this.Text = "Каталог";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Catalog_FormClosed);
            this.Load += new System.EventHandler(this.Catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informationGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView informationGridView;
        private System.Windows.Forms.Button addFavouritesButton;
        private System.Windows.Forms.Button detailedInfoButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn volume;
    }
}