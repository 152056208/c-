using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Prana.Notepad
{
	/// <summary>
	/// AboutForm ��ժҪ˵����
	/// </summary>
	public class FrmAbout : System.Windows.Forms.Form
	{
		#region member declare

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion
        // ������www.51aspx.com
		#region constructor
		public FrmAbout()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("����", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "���±� V1.0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(14, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(296, 72);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "�鳤�������\n��Ա��Ԭ���ѡ�����ͭ";
            // 
            // FrmAbout
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(322, 175);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "���ڼ��±�";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.FrmAbout_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region link click
		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			//System.Diagnostics.Process.Start(linkLabel1.Text);
		}
		#endregion

		#region key down
		protected override void OnKeyDown(KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Escape)
			{
				this.Close();
				return;
			}
			base.OnKeyDown(e);
		}
		#endregion

		private void FrmAbout_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
