namespace RESTfulClient
{
	partial class FormMain
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
			this.components = new System.ComponentModel.Container();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.lstViewResult = new System.Windows.Forms.ListView();
			this.imageList_small = new System.Windows.Forms.ImageList(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.lblCount = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Address";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(76, 12);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(326, 20);
			this.txtAddress.TabIndex = 6;
			this.txtAddress.Text = "http://192.168.1.2:8008/phones";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(711, 12);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(286, 20);
			this.btnSubmit.TabIndex = 7;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(408, 12);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(100, 20);
			this.txtPhone.TabIndex = 8;
			this.txtPhone.Text = "77906";
			// 
			// lstViewResult
			// 
			this.lstViewResult.Location = new System.Drawing.Point(15, 38);
			this.lstViewResult.Name = "lstViewResult";
			this.lstViewResult.Size = new System.Drawing.Size(982, 517);
			this.lstViewResult.TabIndex = 13;
			this.lstViewResult.UseCompatibleStateImageBehavior = false;
			// 
			// imageList_small
			// 
			this.imageList_small.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList_small.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList_small.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(567, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Count:";
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(603, 15);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(13, 13);
			this.lblCount.TabIndex = 15;
			this.lblCount.Text = "0";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1009, 567);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstViewResult);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phones";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.ListView lstViewResult;
		private System.Windows.Forms.ImageList imageList_small;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCount;
	}
}

