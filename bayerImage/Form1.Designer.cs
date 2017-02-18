namespace bayerImage
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
            this.bayerGen = new System.Windows.Forms.Button();
            this.sizeText = new System.Windows.Forms.TextBox();
            this.addSize_btn = new System.Windows.Forms.Button();
            this.minusSize_btn = new System.Windows.Forms.Button();
            this.valueSlider = new System.Windows.Forms.TrackBar();
            this.sliderViewText = new System.Windows.Forms.TextBox();
            this.ResultViewer = new System.Windows.Forms.PictureBox();
            this.SaveBitmap_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valueSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // bayerGen
            // 
            this.bayerGen.Location = new System.Drawing.Point(42, 111);
            this.bayerGen.Name = "bayerGen";
            this.bayerGen.Size = new System.Drawing.Size(173, 69);
            this.bayerGen.TabIndex = 0;
            this.bayerGen.Text = "Generate Matrix";
            this.bayerGen.UseVisualStyleBackColor = true;
            this.bayerGen.Click += new System.EventHandler(this.bayerGen_Click);
            // 
            // sizeText
            // 
            this.sizeText.Location = new System.Drawing.Point(74, 69);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(100, 25);
            this.sizeText.TabIndex = 1;
            this.sizeText.Text = "2";
            // 
            // addSize_btn
            // 
            this.addSize_btn.Location = new System.Drawing.Point(181, 70);
            this.addSize_btn.Name = "addSize_btn";
            this.addSize_btn.Size = new System.Drawing.Size(34, 23);
            this.addSize_btn.TabIndex = 2;
            this.addSize_btn.Text = "+";
            this.addSize_btn.UseVisualStyleBackColor = true;
            this.addSize_btn.Click += new System.EventHandler(this.addSize_btn_Click);
            // 
            // minusSize_btn
            // 
            this.minusSize_btn.Location = new System.Drawing.Point(42, 71);
            this.minusSize_btn.Name = "minusSize_btn";
            this.minusSize_btn.Size = new System.Drawing.Size(26, 23);
            this.minusSize_btn.TabIndex = 3;
            this.minusSize_btn.Text = "-";
            this.minusSize_btn.UseVisualStyleBackColor = true;
            this.minusSize_btn.Click += new System.EventHandler(this.minusSize_btn_Click);
            // 
            // valueSlider
            // 
            this.valueSlider.Location = new System.Drawing.Point(219, 473);
            this.valueSlider.Maximum = 100;
            this.valueSlider.Name = "valueSlider";
            this.valueSlider.Size = new System.Drawing.Size(747, 56);
            this.valueSlider.TabIndex = 4;
            this.valueSlider.Scroll += new System.EventHandler(this.valueSlider_Scroll);
            // 
            // sliderViewText
            // 
            this.sliderViewText.Location = new System.Drawing.Point(74, 473);
            this.sliderViewText.Name = "sliderViewText";
            this.sliderViewText.Size = new System.Drawing.Size(100, 25);
            this.sliderViewText.TabIndex = 5;
            // 
            // ResultViewer
            // 
            this.ResultViewer.Location = new System.Drawing.Point(274, 12);
            this.ResultViewer.Name = "ResultViewer";
            this.ResultViewer.Size = new System.Drawing.Size(513, 342);
            this.ResultViewer.TabIndex = 6;
            this.ResultViewer.TabStop = false;
            // 
            // SaveBitmap_Btn
            // 
            this.SaveBitmap_Btn.Location = new System.Drawing.Point(42, 218);
            this.SaveBitmap_Btn.Name = "SaveBitmap_Btn";
            this.SaveBitmap_Btn.Size = new System.Drawing.Size(173, 59);
            this.SaveBitmap_Btn.TabIndex = 7;
            this.SaveBitmap_Btn.Text = "Save Bitmap";
            this.SaveBitmap_Btn.UseVisualStyleBackColor = true;
            this.SaveBitmap_Btn.Click += new System.EventHandler(this.SaveBitmap_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 534);
            this.Controls.Add(this.SaveBitmap_Btn);
            this.Controls.Add(this.ResultViewer);
            this.Controls.Add(this.sliderViewText);
            this.Controls.Add(this.valueSlider);
            this.Controls.Add(this.minusSize_btn);
            this.Controls.Add(this.addSize_btn);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.bayerGen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.valueSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bayerGen;
        private System.Windows.Forms.TextBox sizeText;
        private System.Windows.Forms.Button addSize_btn;
        private System.Windows.Forms.Button minusSize_btn;
        private System.Windows.Forms.TrackBar valueSlider;
        private System.Windows.Forms.TextBox sliderViewText;
        private System.Windows.Forms.PictureBox ResultViewer;
        private System.Windows.Forms.Button SaveBitmap_Btn;
    }
}

