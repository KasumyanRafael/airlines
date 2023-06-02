namespace airlines
{
    partial class FormRoutes
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
            this.listBoxTypesofPlanes = new System.Windows.Forms.ListBox();
            this.listBoxroutes = new System.Windows.Forms.ListBox();
            this.listBoxtable = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPlane = new System.Windows.Forms.ComboBox();
            this.comboBoxRoute = new System.Windows.Forms.ComboBox();
            this.textBoxDeparture = new System.Windows.Forms.TextBox();
            this.buttonCreateRoute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxIds = new System.Windows.Forms.ComboBox();
            this.textBoxRData = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboBoxRPlane = new System.Windows.Forms.ComboBox();
            this.comboBoxRRoute = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTypesofPlanes
            // 
            this.listBoxTypesofPlanes.FormattingEnabled = true;
            this.listBoxTypesofPlanes.Location = new System.Drawing.Point(12, 234);
            this.listBoxTypesofPlanes.Name = "listBoxTypesofPlanes";
            this.listBoxTypesofPlanes.Size = new System.Drawing.Size(207, 186);
            this.listBoxTypesofPlanes.TabIndex = 0;
            // 
            // listBoxroutes
            // 
            this.listBoxroutes.FormattingEnabled = true;
            this.listBoxroutes.Location = new System.Drawing.Point(225, 234);
            this.listBoxroutes.Name = "listBoxroutes";
            this.listBoxroutes.Size = new System.Drawing.Size(303, 186);
            this.listBoxroutes.TabIndex = 1;
            // 
            // listBoxtable
            // 
            this.listBoxtable.FormattingEnabled = true;
            this.listBoxtable.Location = new System.Drawing.Point(534, 234);
            this.listBoxtable.Name = "listBoxtable";
            this.listBoxtable.Size = new System.Drawing.Size(380, 186);
            this.listBoxtable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Создайте рейс здесь";
            // 
            // comboBoxPlane
            // 
            this.comboBoxPlane.FormattingEnabled = true;
            this.comboBoxPlane.Location = new System.Drawing.Point(27, 60);
            this.comboBoxPlane.Name = "comboBoxPlane";
            this.comboBoxPlane.Size = new System.Drawing.Size(149, 21);
            this.comboBoxPlane.TabIndex = 5;
            // 
            // comboBoxRoute
            // 
            this.comboBoxRoute.FormattingEnabled = true;
            this.comboBoxRoute.Location = new System.Drawing.Point(210, 60);
            this.comboBoxRoute.Name = "comboBoxRoute";
            this.comboBoxRoute.Size = new System.Drawing.Size(185, 21);
            this.comboBoxRoute.TabIndex = 6;
            // 
            // textBoxDeparture
            // 
            this.textBoxDeparture.Location = new System.Drawing.Point(426, 59);
            this.textBoxDeparture.Name = "textBoxDeparture";
            this.textBoxDeparture.Size = new System.Drawing.Size(164, 20);
            this.textBoxDeparture.TabIndex = 7;
            this.textBoxDeparture.Text = "Вводите в формате ЧЧ:ММ";
            // 
            // buttonCreateRoute
            // 
            this.buttonCreateRoute.Location = new System.Drawing.Point(621, 59);
            this.buttonCreateRoute.Name = "buttonCreateRoute";
            this.buttonCreateRoute.Size = new System.Drawing.Size(159, 21);
            this.buttonCreateRoute.TabIndex = 8;
            this.buttonCreateRoute.Text = "Создать рейс";
            this.buttonCreateRoute.UseVisualStyleBackColor = true;
            this.buttonCreateRoute.Click += new System.EventHandler(this.buttonCreateRoute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Или отредактируйте существующий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите id нужного рейса";
            // 
            // comboBoxIds
            // 
            this.comboBoxIds.FormattingEnabled = true;
            this.comboBoxIds.Location = new System.Drawing.Point(176, 167);
            this.comboBoxIds.Name = "comboBoxIds";
            this.comboBoxIds.Size = new System.Drawing.Size(43, 21);
            this.comboBoxIds.TabIndex = 11;
            // 
            // textBoxRData
            // 
            this.textBoxRData.Location = new System.Drawing.Point(566, 170);
            this.textBoxRData.Name = "textBoxRData";
            this.textBoxRData.Size = new System.Drawing.Size(164, 20);
            this.textBoxRData.TabIndex = 14;
            this.textBoxRData.Text = "Время отправки";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(736, 170);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(159, 21);
            this.buttonEdit.TabIndex = 15;
            this.buttonEdit.Text = "Отредактировать!";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // comboBoxRPlane
            // 
            this.comboBoxRPlane.FormattingEnabled = true;
            this.comboBoxRPlane.Location = new System.Drawing.Point(225, 167);
            this.comboBoxRPlane.Name = "comboBoxRPlane";
            this.comboBoxRPlane.Size = new System.Drawing.Size(149, 21);
            this.comboBoxRPlane.TabIndex = 16;
            // 
            // comboBoxRRoute
            // 
            this.comboBoxRRoute.FormattingEnabled = true;
            this.comboBoxRRoute.Location = new System.Drawing.Point(380, 169);
            this.comboBoxRRoute.Name = "comboBoxRRoute";
            this.comboBoxRRoute.Size = new System.Drawing.Size(185, 21);
            this.comboBoxRRoute.TabIndex = 17;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(139, 207);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(159, 21);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "или удалить по id";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 470);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboBoxRRoute);
            this.Controls.Add(this.comboBoxRPlane);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxRData);
            this.Controls.Add(this.comboBoxIds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreateRoute);
            this.Controls.Add(this.textBoxDeparture);
            this.Controls.Add(this.comboBoxRoute);
            this.Controls.Add(this.comboBoxPlane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxtable);
            this.Controls.Add(this.listBoxroutes);
            this.Controls.Add(this.listBoxTypesofPlanes);
            this.Name = "FormRoutes";
            this.Text = "Создание таблицы рейсов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTypesofPlanes;
        private System.Windows.Forms.ListBox listBoxroutes;
        private System.Windows.Forms.ListBox listBoxtable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPlane;
        private System.Windows.Forms.ComboBox comboBoxRoute;
        private System.Windows.Forms.TextBox textBoxDeparture;
        private System.Windows.Forms.Button buttonCreateRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxIds;
        private System.Windows.Forms.TextBox textBoxRData;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ComboBox comboBoxRPlane;
        private System.Windows.Forms.ComboBox comboBoxRRoute;
        private System.Windows.Forms.Button buttonDelete;
    }
}

