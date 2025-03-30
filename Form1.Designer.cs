namespace XJCypher
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
            convertir_btn = new Button();
            input_tb = new TextBox();
            resultado_tb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tipo_cb = new ComboBox();
            separador_chb = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // convertir_btn
            // 
            convertir_btn.BackColor = Color.FromArgb(21, 21, 21);
            convertir_btn.Enabled = false;
            convertir_btn.FlatStyle = FlatStyle.Flat;
            convertir_btn.Font = new Font("OCR A Extended", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertir_btn.ForeColor = Color.White;
            convertir_btn.Location = new Point(362, 355);
            convertir_btn.Name = "convertir_btn";
            convertir_btn.Size = new Size(75, 68);
            convertir_btn.TabIndex = 0;
            convertir_btn.Text = "Con- vertir";
            convertir_btn.UseVisualStyleBackColor = false;
            convertir_btn.Click += convertir_btn_Click;
            // 
            // input_tb
            // 
            input_tb.BackColor = Color.FromArgb(21, 21, 21);
            input_tb.BorderStyle = BorderStyle.FixedSingle;
            input_tb.Font = new Font("OCR A Extended", 9.75F);
            input_tb.ForeColor = Color.White;
            input_tb.Location = new Point(12, 43);
            input_tb.Multiline = true;
            input_tb.Name = "input_tb";
            input_tb.ScrollBars = ScrollBars.Both;
            input_tb.Size = new Size(344, 380);
            input_tb.TabIndex = 1;
            // 
            // resultado_tb
            // 
            resultado_tb.BackColor = Color.FromArgb(21, 21, 21);
            resultado_tb.BorderStyle = BorderStyle.FixedSingle;
            resultado_tb.Font = new Font("OCR A Extended", 9.75F);
            resultado_tb.ForeColor = Color.White;
            resultado_tb.Location = new Point(443, 24);
            resultado_tb.Multiline = true;
            resultado_tb.Name = "resultado_tb";
            resultado_tb.ScrollBars = ScrollBars.Both;
            resultado_tb.Size = new Size(345, 414);
            resultado_tb.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("OCR A Extended", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(443, 6);
            label3.Name = "label3";
            label3.Size = new Size(98, 17);
            label3.TabIndex = 7;
            label3.Text = "Resultado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.25F);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(12, 432);
            label4.Name = "label4";
            label4.Size = new Size(270, 12);
            label4.TabIndex = 8;
            label4.Text = "xabiwebo, joveaaron (c) 2025, Todos los derechos reservados";
            // 
            // tipo_cb
            // 
            tipo_cb.BackColor = Color.FromArgb(21, 21, 21);
            tipo_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            tipo_cb.FlatStyle = FlatStyle.Flat;
            tipo_cb.Font = new Font("OCR A Extended", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tipo_cb.ForeColor = Color.White;
            tipo_cb.FormattingEnabled = true;
            tipo_cb.Items.AddRange(new object[] { "Cifrar en Cifrado Vela", "Cifrar en Cifrado Biher", "Descifrar Cifrado Vela", "Descifrar Cifrado Biher" });
            tipo_cb.Location = new Point(12, 12);
            tipo_cb.Name = "tipo_cb";
            tipo_cb.Size = new Size(344, 25);
            tipo_cb.TabIndex = 9;
            tipo_cb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // separador_chb
            // 
            separador_chb.AutoSize = true;
            separador_chb.Font = new Font("OCR A Extended", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            separador_chb.Location = new Point(360, 44);
            separador_chb.Name = "separador_chb";
            separador_chb.Size = new Size(15, 14);
            separador_chb.TabIndex = 10;
            separador_chb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 44);
            label1.Name = "label1";
            label1.Size = new Size(70, 52);
            label1.TabIndex = 11;
            label1.Text = "Añadir\nseparador\n(solo\nVela)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(separador_chb);
            Controls.Add(label1);
            Controls.Add(tipo_cb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(resultado_tb);
            Controls.Add(input_tb);
            Controls.Add(convertir_btn);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "Programa de cifrado y descifrado";
            TransparencyKey = Color.IndianRed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button convertir_btn;
        private TextBox input_tb;
        private TextBox resultado_tb;
        private Label label3;
        private Label label4;
        private ComboBox tipo_cb;
        private CheckBox separador_chb;
        private Label label1;
    }
}
