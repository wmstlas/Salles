﻿namespace OwServerReader
{
  partial class Form1
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
      this.btnRead = new System.Windows.Forms.Button();
      this.txtXML = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnRead
      // 
      this.btnRead.Location = new System.Drawing.Point(979, 12);
      this.btnRead.Name = "btnRead";
      this.btnRead.Size = new System.Drawing.Size(75, 23);
      this.btnRead.TabIndex = 0;
      this.btnRead.Text = "Read";
      this.btnRead.UseVisualStyleBackColor = true;
      this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
      // 
      // txtXML
      // 
      this.txtXML.Location = new System.Drawing.Point(12, 14);
      this.txtXML.Multiline = true;
      this.txtXML.Name = "txtXML";
      this.txtXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtXML.Size = new System.Drawing.Size(961, 663);
      this.txtXML.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1066, 689);
      this.Controls.Add(this.txtXML);
      this.Controls.Add(this.btnRead);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnRead;
    private System.Windows.Forms.TextBox txtXML;
  }
}

