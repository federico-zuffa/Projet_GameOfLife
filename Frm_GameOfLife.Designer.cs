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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GameOfLife));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_START = new System.Windows.Forms.Button();
            this.btn_Step = new System.Windows.Forms.Button();
            this.btn_RESET = new System.Windows.Forms.Button();
            this.btn_previousStep = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trckBr_Speed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBr_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1136, 737);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btn_START
            // 
            this.btn_START.BackColor = System.Drawing.SystemColors.Window;
            this.btn_START.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_START.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_START.Location = new System.Drawing.Point(445, 699);
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
            this.btn_Step.Location = new System.Drawing.Point(641, 706);
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
            this.btn_RESET.Location = new System.Drawing.Point(336, 706);
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
            this.btn_previousStep.Location = new System.Drawing.Point(572, 706);
            this.btn_previousStep.Name = "btn_previousStep";
            this.btn_previousStep.Size = new System.Drawing.Size(63, 25);
            this.btn_previousStep.TabIndex = 4;
            this.btn_previousStep.Text = "STEP - 1";
            this.btn_previousStep.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trckBr_Speed
            // 
            this.trckBr_Speed.BackColor = System.Drawing.SystemColors.ControlText;
            this.trckBr_Speed.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trckBr_Speed.Location = new System.Drawing.Point(708, 699);
            this.trckBr_Speed.Margin = new System.Windows.Forms.Padding(1);
            this.trckBr_Speed.Maximum = 5000;
            this.trckBr_Speed.Minimum = 100;
            this.trckBr_Speed.Name = "trckBr_Speed";
            this.trckBr_Speed.Size = new System.Drawing.Size(133, 45);
            this.trckBr_Speed.TabIndex = 5;
            this.trckBr_Speed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trckBr_Speed.Value = 500;
            // 
            // Frm_GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 761);
            this.Controls.Add(this.trckBr_Speed);
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
            ((System.ComponentModel.ISupportInitialize)(this.trckBr_Speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_START;
        private System.Windows.Forms.Button btn_Step;
        private System.Windows.Forms.Button btn_RESET;
        private System.Windows.Forms.Button btn_previousStep;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trckBr_Speed;
    }
}

