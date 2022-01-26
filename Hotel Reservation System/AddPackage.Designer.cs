
namespace Hotel_Reservation_System
{
    partial class AddPackage
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
            this.txt_perperson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_numper = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_perperson
            // 
            this.txt_perperson.Location = new System.Drawing.Point(334, 332);
            this.txt_perperson.Name = "txt_perperson";
            this.txt_perperson.Size = new System.Drawing.Size(206, 20);
            this.txt_perperson.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Amount of Per Person";
            // 
            // txt_numper
            // 
            this.txt_numper.Location = new System.Drawing.Point(334, 274);
            this.txt_numper.Name = "txt_numper";
            this.txt_numper.Size = new System.Drawing.Size(206, 20);
            this.txt_numper.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Number of Person";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(334, 213);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(206, 20);
            this.txt_name.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Package Name";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(334, 148);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(206, 20);
            this.txt_id.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Package ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Add Package";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(334, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add Package";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_perperson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_numper);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPackage";
            this.Text = "AddPackage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_perperson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_numper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}