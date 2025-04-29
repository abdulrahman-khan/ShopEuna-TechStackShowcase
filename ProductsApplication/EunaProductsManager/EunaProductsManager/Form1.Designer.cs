namespace EunaProductsManager
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            previous = new RoundedButton();
            next = new RoundedButton();
            searchbutton = new RoundedButton();
            updatebutton = new RoundedButton();
            removebutton = new RoundedButton();
            addbutton = new RoundedButton();
            Lcustomername = new Label();
            customername = new Label();
            dataGridView1 = new DataGridView();
            Lcustomerid = new Label();
            customerid = new Label();
            groupBox1 = new GroupBox();
            Lage = new Label();
            Lgender = new Label();
            Lphone = new Label();
            Lemail = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            orderslabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // previous
            // 
            previous.Location = new Point(200, 490);
            previous.Name = "previous";
            previous.Size = new Size(100, 35);
            previous.TabIndex = 5;
            previous.Text = "<<- Previous";
            previous.UseVisualStyleBackColor = true;
            previous.Click += previous_Click;
            // 
            // next
            // 
            next.Location = new Point(417, 490);
            next.Name = "next";
            next.Size = new Size(100, 35);
            next.TabIndex = 6;
            next.Text = "Next ->>";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // searchbutton
            // 
            searchbutton.Location = new Point(609, 547);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(75, 30);
            searchbutton.TabIndex = 11;
            searchbutton.Text = "Search";
            searchbutton.UseVisualStyleBackColor = true;
            // 
            // updatebutton
            // 
            updatebutton.Location = new Point(417, 547);
            updatebutton.Name = "updatebutton";
            updatebutton.Size = new Size(75, 30);
            updatebutton.TabIndex = 12;
            updatebutton.Text = "Update";
            updatebutton.UseVisualStyleBackColor = true;
            // 
            // removebutton
            // 
            removebutton.Location = new Point(225, 547);
            removebutton.Name = "removebutton";
            removebutton.Size = new Size(75, 30);
            removebutton.TabIndex = 13;
            removebutton.Text = "Remove";
            removebutton.UseVisualStyleBackColor = true;
            // 
            // addbutton
            // 
            addbutton.Location = new Point(33, 547);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(75, 30);
            addbutton.TabIndex = 14;
            addbutton.Text = "Add";
            addbutton.UseVisualStyleBackColor = true;
            // 
            // Lcustomername
            // 
            Lcustomername.AutoSize = true;
            Lcustomername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lcustomername.Location = new Point(22, 32);
            Lcustomername.Name = "Lcustomername";
            Lcustomername.Size = new Size(103, 15);
            Lcustomername.TabIndex = 0;
            Lcustomername.Text = "Customer Name :";
            // 
            // customername
            // 
            customername.AutoSize = true;
            customername.Location = new Point(123, 34);
            customername.Name = "customername";
            customername.Size = new Size(91, 15);
            customername.TabIndex = 1;
            customername.Text = "customername";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Font = new Font("Segoe UI", 10F);
            dataGridView1.Location = new Point(12, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(675, 234);
            dataGridView1.TabIndex = 2;
            // 
            // Lcustomerid
            // 
            Lcustomerid.AutoSize = true;
            Lcustomerid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Lcustomerid.Location = new Point(22, 55);
            Lcustomerid.Name = "Lcustomerid";
            Lcustomerid.Size = new Size(83, 15);
            Lcustomerid.TabIndex = 3;
            Lcustomerid.Text = "Customer ID :";
            // 
            // customerid
            // 
            customerid.AutoSize = true;
            customerid.Location = new Point(123, 57);
            customerid.Name = "customerid";
            customerid.Size = new Size(70, 15);
            customerid.TabIndex = 4;
            customerid.Text = "customerid";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Lavender;
            groupBox1.Controls.Add(Lage);
            groupBox1.Controls.Add(Lgender);
            groupBox1.Controls.Add(Lphone);
            groupBox1.Controls.Add(Lemail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(customername);
            groupBox1.Controls.Add(Lcustomername);
            groupBox1.Controls.Add(Lcustomerid);
            groupBox1.Controls.Add(customerid);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 102);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // Lage
            // 
            Lage.AutoSize = true;
            Lage.Location = new Point(579, 60);
            Lage.Name = "Lage";
            Lage.Size = new Size(40, 15);
            Lage.TabIndex = 12;
            Lage.Text = "label9";
            // 
            // Lgender
            // 
            Lgender.AutoSize = true;
            Lgender.Location = new Point(579, 38);
            Lgender.Name = "Lgender";
            Lgender.Size = new Size(40, 15);
            Lgender.TabIndex = 11;
            Lgender.Text = "label8";
            // 
            // Lphone
            // 
            Lphone.AutoSize = true;
            Lphone.Location = new Point(342, 60);
            Lphone.Name = "Lphone";
            Lphone.Size = new Size(40, 15);
            Lphone.TabIndex = 10;
            Lphone.Text = "label7";
            // 
            // Lemail
            // 
            Lemail.AutoSize = true;
            Lemail.Location = new Point(342, 32);
            Lemail.Name = "Lemail";
            Lemail.Size = new Size(40, 15);
            Lemail.TabIndex = 9;
            Lemail.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(524, 58);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 8;
            label5.Text = "Age :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(524, 37);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Gender :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(283, 59);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Phone :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(283, 32);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Email :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(137, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(482, 52);
            label1.TabIndex = 9;
            label1.Text = "ShopEuna Customer Manager Application";
            // 
            // orderslabel
            // 
            orderslabel.AutoSize = true;
            orderslabel.Font = new Font("Segoe UI", 11F);
            orderslabel.Location = new Point(14, 214);
            orderslabel.Name = "orderslabel";
            orderslabel.Size = new Size(56, 20);
            orderslabel.TabIndex = 10;
            orderslabel.Text = "Orders :";
            orderslabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 588);
            Controls.Add(addbutton);
            Controls.Add(removebutton);
            Controls.Add(updatebutton);
            Controls.Add(searchbutton);
            Controls.Add(orderslabel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(next);
            Controls.Add(previous);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "ShopEuna Customer Manager Application";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();








        }

        #endregion


        private Label Lcustomername;
        private Label customername;
        private DataGridView dataGridView1;
        private Label Lcustomerid;
        private Label customerid;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label orderslabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Lage;
        private Label Lgender;
        private Label Lphone;
        private Label Lemail;
        private RoundedButton previous;
        private RoundedButton next;
        private RoundedButton searchbutton;
        private RoundedButton updatebutton;
        private RoundedButton removebutton;
        private RoundedButton addbutton;
    }
}
