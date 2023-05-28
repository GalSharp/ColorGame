namespace ColorGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.questionLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.health1 = new System.Windows.Forms.PictureBox();
            this.health2 = new System.Windows.Forms.PictureBox();
            this.health3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.health1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(674, 53);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(91, 31);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "ОЧКИ";
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(439, 164);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(242, 25);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "ОСНОВНАЯ НАДПИСЬ";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(909, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 2;
            this.progressBar.Value = 100;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.Location = new System.Drawing.Point(252, 106);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(429, 25);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "КАКИМ ЦВЕТОМ НАПИСАНА НАДПИСЬ?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(82, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 72);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(375, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 72);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(655, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 72);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // health1
            // 
            this.health1.Image = global::ColorGame.Properties.Resources.heart_pixel_art_254x254;
            this.health1.Location = new System.Drawing.Point(12, 38);
            this.health1.Name = "health1";
            this.health1.Size = new System.Drawing.Size(52, 46);
            this.health1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.health1.TabIndex = 4;
            this.health1.TabStop = false;
            // 
            // health2
            // 
            this.health2.Image = global::ColorGame.Properties.Resources.heart_pixel_art_254x254;
            this.health2.Location = new System.Drawing.Point(68, 38);
            this.health2.Name = "health2";
            this.health2.Size = new System.Drawing.Size(52, 46);
            this.health2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.health2.TabIndex = 4;
            this.health2.TabStop = false;
            // 
            // health3
            // 
            this.health3.Image = global::ColorGame.Properties.Resources.heart_pixel_art_254x254;
            this.health3.Location = new System.Drawing.Point(124, 38);
            this.health3.Name = "health3";
            this.health3.Size = new System.Drawing.Size(52, 46);
            this.health3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.health3.TabIndex = 4;
            this.health3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 528);
            this.Controls.Add(this.health3);
            this.Controls.Add(this.health2);
            this.Controls.Add(this.health1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.scoreLabel);
            this.Name = "Form1";
            this.Text = "Игра \"Цвета\"";
            ((System.ComponentModel.ISupportInitialize)(this.health1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox health1;
        private System.Windows.Forms.PictureBox health2;
        private System.Windows.Forms.PictureBox health3;
    }
}

