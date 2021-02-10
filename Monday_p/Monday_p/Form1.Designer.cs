
namespace Monday_p
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.f_name_txt = new System.Windows.Forms.TextBox();
            this.city_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.l_name_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.check_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // f_name_txt
            // 
            this.f_name_txt.Location = new System.Drawing.Point(295, 40);
            this.f_name_txt.Name = "f_name_txt";
            this.f_name_txt.Size = new System.Drawing.Size(447, 31);
            this.f_name_txt.TabIndex = 4;
            // 
            // city_txt
            // 
            this.city_txt.Location = new System.Drawing.Point(295, 238);
            this.city_txt.Name = "city_txt";
            this.city_txt.Size = new System.Drawing.Size(447, 31);
            this.city_txt.TabIndex = 5;
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(295, 167);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(447, 31);
            this.address_txt.TabIndex = 6;
            // 
            // l_name_txt
            // 
            this.l_name_txt.Location = new System.Drawing.Point(295, 105);
            this.l_name_txt.Name = "l_name_txt";
            this.l_name_txt.Size = new System.Drawing.Size(447, 31);
            this.l_name_txt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(62, 355);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(199, 76);
            this.insert_btn.TabIndex = 9;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(295, 301);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(447, 31);
            this.id_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(305, 355);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(199, 76);
            this.delete_btn.TabIndex = 12;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(553, 355);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(199, 76);
            this.update_btn.TabIndex = 13;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(305, 454);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(199, 76);
            this.reset_btn.TabIndex = 14;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // info_btn
            // 
            this.info_btn.Location = new System.Drawing.Point(62, 454);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(199, 76);
            this.info_btn.TabIndex = 15;
            this.info_btn.Text = "Get INFO";
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(553, 454);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(321, 76);
            this.check_btn.TabIndex = 16;
            this.check_btn.Text = "Check if Exists";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 542);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_name_txt);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.city_txt);
            this.Controls.Add(this.f_name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox f_name_txt;
        private System.Windows.Forms.TextBox city_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox l_name_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button check_btn;
    }
}

