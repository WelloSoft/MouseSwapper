
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
partial class Form1 : System.Windows.Forms.Form
{

	//Form overrides dispose to clean up the component list.
	[System.Diagnostics.DebuggerNonUserCode()]
	protected override void Dispose(bool disposing)
	{
		try {
			if (disposing && components != null) {
				components.Dispose();
			}
		} finally {
			base.Dispose(disposing);
		}
	}

	//Required by the Windows Form Designer

	private System.ComponentModel.IContainer components;
	//NOTE: The following procedure is required by the Windows Form Designer
	//It can be modified using the Windows Form Designer.  
	//Do not modify it using the code editor.
	[System.Diagnostics.DebuggerStepThrough()]
	private void InitializeComponent()
	{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Enabler = new System.Windows.Forms.CheckBox();
            this.AutoFlip = new System.Windows.Forms.CheckBox();
            this.FlipX = new System.Windows.Forms.CheckBox();
            this.FlipY = new System.Windows.Forms.CheckBox();
            this.SwapXY = new System.Windows.Forms.CheckBox();
            this.ScrRot = new System.Windows.Forms.ComboBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 3;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanel1.Controls.Add(this.Enabler, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.AutoFlip, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.FlipX, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.FlipY, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.SwapXY, 2, 3);
            this.TableLayoutPanel1.Controls.Add(this.ScrRot, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 4;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.Size = new System.Drawing.Size(311, 135);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // Enabler
            // 
            this.Enabler.Appearance = System.Windows.Forms.Appearance.Button;
            this.Enabler.AutoSize = true;
            this.Enabler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Enabler.Checked = true;
            this.Enabler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TableLayoutPanel1.SetColumnSpan(this.Enabler, 3);
            this.Enabler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enabler.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Enabler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enabler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Enabler.ForeColor = System.Drawing.Color.White;
            this.Enabler.Location = new System.Drawing.Point(3, 30);
            this.Enabler.Name = "Enabler";
            this.Enabler.Size = new System.Drawing.Size(305, 48);
            this.Enabler.TabIndex = 4;
            this.Enabler.Text = "Activate";
            this.Enabler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enabler.UseVisualStyleBackColor = false;
            this.Enabler.CheckedChanged += new System.EventHandler(this.ParamUpdate);
            // 
            // AutoFlip
            // 
            this.AutoFlip.AutoSize = true;
            this.AutoFlip.Checked = true;
            this.AutoFlip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TableLayoutPanel1.SetColumnSpan(this.AutoFlip, 3);
            this.AutoFlip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoFlip.Location = new System.Drawing.Point(5, 86);
            this.AutoFlip.Margin = new System.Windows.Forms.Padding(5);
            this.AutoFlip.Name = "AutoFlip";
            this.AutoFlip.Size = new System.Drawing.Size(301, 17);
            this.AutoFlip.TabIndex = 3;
            this.AutoFlip.Text = "Auto Flip";
            this.AutoFlip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoFlip.UseVisualStyleBackColor = true;
            this.AutoFlip.CheckedChanged += new System.EventHandler(this.ParamUpdate);
            // 
            // FlipX
            // 
            this.FlipX.AutoSize = true;
            this.FlipX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlipX.Enabled = false;
            this.FlipX.Location = new System.Drawing.Point(5, 113);
            this.FlipX.Margin = new System.Windows.Forms.Padding(5);
            this.FlipX.Name = "FlipX";
            this.FlipX.Size = new System.Drawing.Size(93, 17);
            this.FlipX.TabIndex = 0;
            this.FlipX.Text = "Flip X";
            this.FlipX.UseVisualStyleBackColor = true;
            this.FlipX.CheckedChanged += new System.EventHandler(this.ParamUpdate);
            // 
            // FlipY
            // 
            this.FlipY.AutoSize = true;
            this.FlipY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlipY.Enabled = false;
            this.FlipY.Location = new System.Drawing.Point(108, 113);
            this.FlipY.Margin = new System.Windows.Forms.Padding(5);
            this.FlipY.Name = "FlipY";
            this.FlipY.Size = new System.Drawing.Size(93, 17);
            this.FlipY.TabIndex = 1;
            this.FlipY.Text = "FlipY";
            this.FlipY.UseVisualStyleBackColor = true;
            this.FlipY.CheckedChanged += new System.EventHandler(this.ParamUpdate);
            // 
            // SwapXY
            // 
            this.SwapXY.AutoSize = true;
            this.SwapXY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwapXY.Enabled = false;
            this.SwapXY.Location = new System.Drawing.Point(211, 113);
            this.SwapXY.Margin = new System.Windows.Forms.Padding(5);
            this.SwapXY.Name = "SwapXY";
            this.SwapXY.Size = new System.Drawing.Size(95, 17);
            this.SwapXY.TabIndex = 2;
            this.SwapXY.Text = "Swap X & Y";
            this.SwapXY.UseMnemonic = false;
            this.SwapXY.UseVisualStyleBackColor = true;
            this.SwapXY.CheckedChanged += new System.EventHandler(this.ParamUpdate);
            // 
            // ScrRot
            // 
            this.TableLayoutPanel1.SetColumnSpan(this.ScrRot, 3);
            this.ScrRot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrRot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScrRot.FormattingEnabled = true;
            this.ScrRot.Items.AddRange(new object[] {
            "Landscape Display",
            "Potrait Display",
            "Landspace (Inverted) Display",
            "Potrait (Inverted) Display"});
            this.ScrRot.Location = new System.Drawing.Point(3, 3);
            this.ScrRot.Name = "ScrRot";
            this.ScrRot.Size = new System.Drawing.Size(305, 21);
            this.ScrRot.TabIndex = 5;
            this.ScrRot.SelectedIndexChanged += new System.EventHandler(this.ParamUpdate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 135);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mouse Swapper";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

	}
	internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
	internal System.Windows.Forms.CheckBox FlipX;
	internal System.Windows.Forms.CheckBox FlipY;
	internal System.Windows.Forms.CheckBox SwapXY;
	internal System.Windows.Forms.CheckBox AutoFlip;

	internal System.Windows.Forms.CheckBox Enabler;
    private System.Windows.Forms.ComboBox ScrRot;
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
