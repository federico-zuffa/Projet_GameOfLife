namespace Projet_GameOfLife
{
    partial class Frm_GameOfLife
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GameOfLife));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_START = new System.Windows.Forms.Button();
            this.btn_Step = new System.Windows.Forms.Button();
            this.btn_RESET = new System.Windows.Forms.Button();
            this.btn_previousStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btn_START
            // 
            this.btn_START.BackColor = System.Drawing.SystemColors.Window;
            this.btn_START.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_START.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_START.Location = new System.Drawing.Point(566, 770);
            this.btn_START.Name = "btn_START";
            this.btn_START.Size = new System.Drawing.Size(121, 38);
            this.btn_START.TabIndex = 1;
            this.btn_START.Text = "START";
            this.btn_START.UseVisualStyleBackColor = false;
            this.btn_START.Click += new System.EventHandler(this.btn_START_Click);
            // 
            // btn_Step
            // 
            this.btn_Step.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Step.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Step.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Step.Location = new System.Drawing.Point(762, 777);
            this.btn_Step.Name = "btn_Step";
            this.btn_Step.Size = new System.Drawing.Size(63, 25);
            this.btn_Step.TabIndex = 2;
            this.btn_Step.Text = "STEP + 1";
            this.btn_Step.UseVisualStyleBackColor = false;
            this.btn_Step.Click += new System.EventHandler(this.btn_Step_Click);
            // 
            // btn_RESET
            // 
            this.btn_RESET.BackColor = System.Drawing.SystemColors.Window;
            this.btn_RESET.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RESET.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_RESET.Location = new System.Drawing.Point(457, 777);
            this.btn_RESET.Name = "btn_RESET";
            this.btn_RESET.Size = new System.Drawing.Size(103, 25);
            this.btn_RESET.TabIndex = 3;
            this.btn_RESET.Text = "RESET";
            this.btn_RESET.UseVisualStyleBackColor = false;
            this.btn_RESET.Click += new System.EventHandler(this.btn_RESET_Click);
            // 
            // btn_previousStep
            // 
            this.btn_previousStep.BackColor = System.Drawing.SystemColors.Window;
            this.btn_previousStep.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previousStep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_previousStep.Location = new System.Drawing.Point(693, 777);
            this.btn_previousStep.Name = "btn_previousStep";
            this.btn_previousStep.Size = new System.Drawing.Size(63, 25);
            this.btn_previousStep.TabIndex = 4;
            this.btn_previousStep.Text = "STEP - 1";
            this.btn_previousStep.UseVisualStyleBackColor = false;
            this.btn_previousStep.Click += new System.EventHandler(this.btn_previousStep_Click);
            // 
            // Frm_GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 820);
            this.Controls.Add(this.btn_previousStep);
            this.Controls.Add(this.btn_RESET);
            this.Controls.Add(this.btn_Step);
            this.Controls.Add(this.btn_START);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_GameOfLife";
            this.Text = "Game Of Life";
            this.Load += new System.EventHandler(this.Frm_GameOfLife_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_START;
        private System.Windows.Forms.Button btn_Step;
        private System.Windows.Forms.Button btn_RESET;
        private System.Windows.Forms.Button btn_previousStep;
    }
}

