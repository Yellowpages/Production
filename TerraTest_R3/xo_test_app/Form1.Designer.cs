namespace xo_test_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_reverse = new System.Windows.Forms.TextBox();
            this.btn_findReverse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_drivemin = new System.Windows.Forms.TextBox();
            this.center_y = new System.Windows.Forms.TextBox();
            this.center_x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_driving_times = new System.Windows.Forms.Button();
            this.txt_linebuffer = new System.Windows.Forms.TextBox();
            this.btn_buffer_route = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_y);
            this.groupBox1.Controls.Add(this.txt_x);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_reverse);
            this.groupBox1.Controls.Add(this.btn_findReverse);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "reverse geocoding example";
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(24, 52);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(100, 20);
            this.txt_y.TabIndex = 5;
            this.txt_y.Text = "4199657";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(24, 28);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 20);
            this.txt_x.TabIndex = 4;
            this.txt_x.Text = "475893";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_reverse
            // 
            this.txt_reverse.Location = new System.Drawing.Point(6, 114);
            this.txt_reverse.Multiline = true;
            this.txt_reverse.Name = "txt_reverse";
            this.txt_reverse.Size = new System.Drawing.Size(370, 127);
            this.txt_reverse.TabIndex = 1;
            // 
            // btn_findReverse
            // 
            this.btn_findReverse.Location = new System.Drawing.Point(24, 87);
            this.btn_findReverse.Name = "btn_findReverse";
            this.btn_findReverse.Size = new System.Drawing.Size(75, 21);
            this.btn_findReverse.TabIndex = 0;
            this.btn_findReverse.Text = "find address";
            this.btn_findReverse.UseVisualStyleBackColor = true;
            this.btn_findReverse.Click += new System.EventHandler(this.btn_findReverse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_drivemin);
            this.groupBox2.Controls.Add(this.center_y);
            this.groupBox2.Controls.Add(this.center_x);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_driving_times);
            this.groupBox2.Location = new System.Drawing.Point(427, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Driving times";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "time (min)";
            // 
            // txt_drivemin
            // 
            this.txt_drivemin.Location = new System.Drawing.Point(72, 77);
            this.txt_drivemin.Name = "txt_drivemin";
            this.txt_drivemin.Size = new System.Drawing.Size(100, 20);
            this.txt_drivemin.TabIndex = 10;
            this.txt_drivemin.Text = "5";
            // 
            // center_y
            // 
            this.center_y.Location = new System.Drawing.Point(72, 51);
            this.center_y.Name = "center_y";
            this.center_y.Size = new System.Drawing.Size(100, 20);
            this.center_y.TabIndex = 9;
            this.center_y.Text = "4199657";
            // 
            // center_x
            // 
            this.center_x.Location = new System.Drawing.Point(72, 27);
            this.center_x.Name = "center_x";
            this.center_x.Size = new System.Drawing.Size(100, 20);
            this.center_x.TabIndex = 8;
            this.center_x.Text = "475893";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "x";
            // 
            // btn_driving_times
            // 
            this.btn_driving_times.Location = new System.Drawing.Point(46, 111);
            this.btn_driving_times.Name = "btn_driving_times";
            this.btn_driving_times.Size = new System.Drawing.Size(136, 23);
            this.btn_driving_times.TabIndex = 0;
            this.btn_driving_times.Text = "driving times";
            this.btn_driving_times.UseVisualStyleBackColor = true;
            this.btn_driving_times.Click += new System.EventHandler(this.btn_driving_times_Click);
            // 
            // txt_linebuffer
            // 
            this.txt_linebuffer.Location = new System.Drawing.Point(35, 338);
            this.txt_linebuffer.Multiline = true;
            this.txt_linebuffer.Name = "txt_linebuffer";
            this.txt_linebuffer.Size = new System.Drawing.Size(799, 94);
            this.txt_linebuffer.TabIndex = 2;
            this.txt_linebuffer.Text = resources.GetString("txt_linebuffer.Text");
            // 
            // btn_buffer_route
            // 
            this.btn_buffer_route.Location = new System.Drawing.Point(36, 442);
            this.btn_buffer_route.Name = "btn_buffer_route";
            this.btn_buffer_route.Size = new System.Drawing.Size(115, 23);
            this.btn_buffer_route.TabIndex = 3;
            this.btn_buffer_route.Text = "Buffer Route";
            this.btn_buffer_route.UseVisualStyleBackColor = true;
            this.btn_buffer_route.Click += new System.EventHandler(this.btn_buffer_route_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Route buffer JSON (example string)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 492);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_buffer_route);
            this.Controls.Add(this.txt_linebuffer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_reverse;
        private System.Windows.Forms.Button btn_findReverse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_driving_times;
        private System.Windows.Forms.TextBox center_y;
        private System.Windows.Forms.TextBox center_x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_drivemin;
        private System.Windows.Forms.TextBox txt_linebuffer;
        private System.Windows.Forms.Button btn_buffer_route;
        private System.Windows.Forms.Label label6;
    }
}

