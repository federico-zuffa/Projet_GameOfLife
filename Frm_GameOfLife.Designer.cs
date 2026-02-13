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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trckBr_Speed = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherGrilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fernerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modèlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.règlesDuJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.règlesOriginalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highLifeRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_nbStep = new System.Windows.Forms.Label();
            this.btn_BackToInitialConfig = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.gliderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallExploderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replicatorhighLifeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBr_Speed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1146, 642);
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
            this.btn_START.Location = new System.Drawing.Point(550, 692);
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
            this.btn_Step.Location = new System.Drawing.Point(746, 699);
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
            this.btn_RESET.Location = new System.Drawing.Point(441, 699);
            this.btn_RESET.Name = "btn_RESET";
            this.btn_RESET.Size = new System.Drawing.Size(103, 25);
            this.btn_RESET.TabIndex = 3;
            this.btn_RESET.Text = "CLEAR";
            this.btn_RESET.UseVisualStyleBackColor = false;
            this.btn_RESET.Click += new System.EventHandler(this.btn_RESET_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trckBr_Speed
            // 
            this.trckBr_Speed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trckBr_Speed.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trckBr_Speed.Location = new System.Drawing.Point(813, 699);
            this.trckBr_Speed.Margin = new System.Windows.Forms.Padding(1);
            this.trckBr_Speed.Maximum = 5000;
            this.trckBr_Speed.Minimum = 100;
            this.trckBr_Speed.Name = "trckBr_Speed";
            this.trckBr_Speed.Size = new System.Drawing.Size(133, 45);
            this.trckBr_Speed.TabIndex = 5;
            this.trckBr_Speed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trckBr_Speed.Value = 500;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.modèlesToolStripMenuItem,
            this.règlesDuJeuToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.fernerToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherGrilleToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // afficherGrilleToolStripMenuItem
            // 
            this.afficherGrilleToolStripMenuItem.Checked = true;
            this.afficherGrilleToolStripMenuItem.CheckOnClick = true;
            this.afficherGrilleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.afficherGrilleToolStripMenuItem.Name = "afficherGrilleToolStripMenuItem";
            this.afficherGrilleToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.afficherGrilleToolStripMenuItem.Text = "Afficher grille";
            this.afficherGrilleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.afficherGrilleToolStripMenuItem_CheckedChanged);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // fernerToolStripMenuItem
            // 
            this.fernerToolStripMenuItem.Name = "fernerToolStripMenuItem";
            this.fernerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.fernerToolStripMenuItem.Text = "Fermer";
            this.fernerToolStripMenuItem.Click += new System.EventHandler(this.fernerToolStripMenuItem_Click);
            // 
            // modèlesToolStripMenuItem
            // 
            this.modèlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gliderToolStripMenuItem,
            this.exploderToolStripMenuItem,
            this.smallExploderToolStripMenuItem,
            this.soupToolStripMenuItem,
            this.factoryToolStripMenuItem,
            this.replicatorhighLifeToolStripMenuItem});
            this.modèlesToolStripMenuItem.Name = "modèlesToolStripMenuItem";
            this.modèlesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.modèlesToolStripMenuItem.Text = "Modèles";
            // 
            // règlesDuJeuToolStripMenuItem
            // 
            this.règlesDuJeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.règlesOriginalesToolStripMenuItem,
            this.highLifeRulesToolStripMenuItem});
            this.règlesDuJeuToolStripMenuItem.Name = "règlesDuJeuToolStripMenuItem";
            this.règlesDuJeuToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.règlesDuJeuToolStripMenuItem.Text = "Règles du Jeu";
            // 
            // règlesOriginalesToolStripMenuItem
            // 
            this.règlesOriginalesToolStripMenuItem.Checked = true;
            this.règlesOriginalesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.règlesOriginalesToolStripMenuItem.Name = "règlesOriginalesToolStripMenuItem";
            this.règlesOriginalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.règlesOriginalesToolStripMenuItem.Text = "Original Rules";
            this.règlesOriginalesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.règlesOriginalesToolStripMenuItem_CheckedChanged);
            this.règlesOriginalesToolStripMenuItem.Click += new System.EventHandler(this.règlesOriginalesToolStripMenuItem_Click);
            // 
            // highLifeRulesToolStripMenuItem
            // 
            this.highLifeRulesToolStripMenuItem.Name = "highLifeRulesToolStripMenuItem";
            this.highLifeRulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.highLifeRulesToolStripMenuItem.Text = "HighLife Rules";
            this.highLifeRulesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.highLifeRulesToolStripMenuItem_CheckedChanged);
            this.highLifeRulesToolStripMenuItem.Click += new System.EventHandler(this.highLifeRulesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(11, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 648);
            this.panel1.TabIndex = 7;
            // 
            // lbl_nbStep
            // 
            this.lbl_nbStep.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_nbStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_nbStep.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nbStep.Location = new System.Drawing.Point(341, 699);
            this.lbl_nbStep.Name = "lbl_nbStep";
            this.lbl_nbStep.Size = new System.Drawing.Size(94, 23);
            this.lbl_nbStep.TabIndex = 6;
            this.lbl_nbStep.Text = "STEPS : 1";
            this.lbl_nbStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_BackToInitialConfig
            // 
            this.btn_BackToInitialConfig.BackColor = System.Drawing.SystemColors.Window;
            this.btn_BackToInitialConfig.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackToInitialConfig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BackToInitialConfig.Location = new System.Drawing.Point(677, 699);
            this.btn_BackToInitialConfig.Name = "btn_BackToInitialConfig";
            this.btn_BackToInitialConfig.Size = new System.Drawing.Size(63, 25);
            this.btn_BackToInitialConfig.TabIndex = 8;
            this.btn_BackToInitialConfig.Text = "RESET";
            this.btn_BackToInitialConfig.UseVisualStyleBackColor = false;
            this.btn_BackToInitialConfig.Click += new System.EventHandler(this.btn_BackToInitialConfig_Click);
            // 
            // gliderToolStripMenuItem
            // 
            this.gliderToolStripMenuItem.Name = "gliderToolStripMenuItem";
            this.gliderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gliderToolStripMenuItem.Text = "Glider";
            this.gliderToolStripMenuItem.Click += new System.EventHandler(this.gliderToolStripMenuItem_Click);
            // 
            // exploderToolStripMenuItem
            // 
            this.exploderToolStripMenuItem.Name = "exploderToolStripMenuItem";
            this.exploderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exploderToolStripMenuItem.Text = "Exploder";
            this.exploderToolStripMenuItem.Click += new System.EventHandler(this.exploderToolStripMenuItem_Click);
            // 
            // smallExploderToolStripMenuItem
            // 
            this.smallExploderToolStripMenuItem.Name = "smallExploderToolStripMenuItem";
            this.smallExploderToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.smallExploderToolStripMenuItem.Text = "Small Exploder";
            this.smallExploderToolStripMenuItem.Click += new System.EventHandler(this.smallExploderToolStripMenuItem_Click);
            // 
            // soupToolStripMenuItem
            // 
            this.soupToolStripMenuItem.Name = "soupToolStripMenuItem";
            this.soupToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.soupToolStripMenuItem.Text = "Soup";
            this.soupToolStripMenuItem.Click += new System.EventHandler(this.soupToolStripMenuItem_Click);
            // 
            // factoryToolStripMenuItem
            // 
            this.factoryToolStripMenuItem.Name = "factoryToolStripMenuItem";
            this.factoryToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.factoryToolStripMenuItem.Text = "Factory";
            this.factoryToolStripMenuItem.Click += new System.EventHandler(this.factoryToolStripMenuItem_Click);
            // 
            // replicatorhighLifeToolStripMenuItem
            // 
            this.replicatorhighLifeToolStripMenuItem.Name = "replicatorhighLifeToolStripMenuItem";
            this.replicatorhighLifeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.replicatorhighLifeToolStripMenuItem.Text = "Replicator (highLife)";
            this.replicatorhighLifeToolStripMenuItem.Click += new System.EventHandler(this.replicatorhighLifeToolStripMenuItem_Click);
            // 
            // Frm_GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1175, 736);
            this.Controls.Add(this.btn_BackToInitialConfig);
            this.Controls.Add(this.lbl_nbStep);
            this.Controls.Add(this.trckBr_Speed);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Step);
            this.Controls.Add(this.btn_RESET);
            this.Controls.Add(this.btn_START);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_GameOfLife";
            this.Text = "Game Of Life";
            this.Load += new System.EventHandler(this.Frm_GameOfLife_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBr_Speed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_START;
        private System.Windows.Forms.Button btn_Step;
        private System.Windows.Forms.Button btn_RESET;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trckBr_Speed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modèlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem règlesDuJeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherGrilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fernerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nbStep;
        private System.Windows.Forms.Button btn_BackToInitialConfig;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem règlesOriginalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highLifeRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gliderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallExploderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replicatorhighLifeToolStripMenuItem;
    }
}

