﻿namespace BaseballGameWindows
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창NToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계단식정렬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가로정렬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.세로정렬ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.창WToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(823, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새창NToolStripMenuItem1,
            this.toolStripSeparator1,
            this.종료XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새창NToolStripMenuItem1
            // 
            this.새창NToolStripMenuItem1.Name = "새창NToolStripMenuItem1";
            this.새창NToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.새창NToolStripMenuItem1.Text = "새창(&N)";
            this.새창NToolStripMenuItem1.Click += new System.EventHandler(this.새창NToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 창WToolStripMenuItem
            // 
            this.창WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계단식정렬ToolStripMenuItem,
            this.가로정렬ToolStripMenuItem,
            this.세로정렬ToolStripMenuItem});
            this.창WToolStripMenuItem.Name = "창WToolStripMenuItem";
            this.창WToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.창WToolStripMenuItem.Text = "창(&W)";
            // 
            // 계단식정렬ToolStripMenuItem
            // 
            this.계단식정렬ToolStripMenuItem.Name = "계단식정렬ToolStripMenuItem";
            this.계단식정렬ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.계단식정렬ToolStripMenuItem.Text = "계단식 정렬";
            this.계단식정렬ToolStripMenuItem.Click += new System.EventHandler(this.계단식정렬ToolStripMenuItem_Click);
            // 
            // 가로정렬ToolStripMenuItem
            // 
            this.가로정렬ToolStripMenuItem.Name = "가로정렬ToolStripMenuItem";
            this.가로정렬ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.가로정렬ToolStripMenuItem.Text = "가로 정렬";
            this.가로정렬ToolStripMenuItem.Click += new System.EventHandler(this.가로정렬ToolStripMenuItem_Click);
            // 
            // 세로정렬ToolStripMenuItem
            // 
            this.세로정렬ToolStripMenuItem.Name = "세로정렬ToolStripMenuItem";
            this.세로정렬ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.세로정렬ToolStripMenuItem.Text = "세로 정렬";
            this.세로정렬ToolStripMenuItem.Click += new System.EventHandler(this.세로정렬ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창NToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계단식정렬ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 가로정렬ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 세로정렬ToolStripMenuItem;
    }
}

