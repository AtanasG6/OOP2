namespace DrawingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            drawLineBtn = new Button();
            drawRectangleBtn = new Button();
            ColorPickerBtn = new Button();
            colorDialog = new ColorDialog();
            pnl = new Panel();
            label1 = new Label();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // drawLineBtn
            // 
            drawLineBtn.Location = new Point(801, 209);
            drawLineBtn.Name = "drawLineBtn";
            drawLineBtn.Size = new Size(150, 60);
            drawLineBtn.TabIndex = 0;
            drawLineBtn.Text = "Line";
            drawLineBtn.UseVisualStyleBackColor = true;
            drawLineBtn.Click += drawLineBtn_Click;
            // 
            // drawRectangleBtn
            // 
            drawRectangleBtn.Location = new Point(801, 287);
            drawRectangleBtn.Name = "drawRectangleBtn";
            drawRectangleBtn.Size = new Size(153, 59);
            drawRectangleBtn.TabIndex = 2;
            drawRectangleBtn.Text = "Rectangle";
            drawRectangleBtn.UseVisualStyleBackColor = true;
            drawRectangleBtn.Click += drawRectangleBtn_Click;
            // 
            // ColorPickerBtn
            // 
            ColorPickerBtn.Location = new Point(801, 371);
            ColorPickerBtn.Name = "ColorPickerBtn";
            ColorPickerBtn.Size = new Size(150, 63);
            ColorPickerBtn.TabIndex = 3;
            ColorPickerBtn.Text = "Pick Color";
            ColorPickerBtn.UseVisualStyleBackColor = true;
            ColorPickerBtn.Click += ColorPickerBtn_Click;
            // 
            // pnl
            // 
            pnl.BackColor = SystemColors.AppWorkspace;
            pnl.Location = new Point(12, 86);
            pnl.Name = "pnl";
            pnl.Size = new Size(766, 563);
            pnl.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, 19);
            label1.Name = "label1";
            label1.Size = new Size(529, 40);
            label1.TabIndex = 5;
            label1.Text = "Drawing App - Gyulchev Paint";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(801, 460);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(150, 65);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 661);
            Controls.Add(clearBtn);
            Controls.Add(label1);
            Controls.Add(pnl);
            Controls.Add(ColorPickerBtn);
            Controls.Add(drawRectangleBtn);
            Controls.Add(drawLineBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button drawLineBtn;
        private Button drawRectangleBtn;
        private Button ColorPickerBtn;
        private ColorDialog colorDialog;
        private Panel pnl;
        private Label label1;
        private Button clearBtn;
    }
}