namespace ZooDBDemo
{
    partial class AddAnimalForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.received = new System.Windows.Forms.Label();
            this.animalName = new System.Windows.Forms.TextBox();
            this.animalSpecies = new System.Windows.Forms.TextBox();
            this.dateReceived = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 442);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 137);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.animalName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Species";
            // 
            // received
            // 
            this.received.AutoSize = true;
            this.received.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.received.Location = new System.Drawing.Point(63, 358);
            this.received.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.received.Name = "received";
            this.received.Size = new System.Drawing.Size(268, 44);
            this.received.TabIndex = 3;
            this.received.Text = "Date Received";
            // 
            // animalName
            // 
            this.animalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalName.Location = new System.Drawing.Point(346, 116);
            this.animalName.Margin = new System.Windows.Forms.Padding(2);
            this.animalName.Name = "animalName";
            this.animalName.Size = new System.Drawing.Size(449, 65);
            this.animalName.TabIndex = 4;
            this.animalName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // animalSpecies
            // 
            this.animalSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalSpecies.Location = new System.Drawing.Point(353, 229);
            this.animalSpecies.Margin = new System.Windows.Forms.Padding(2);
            this.animalSpecies.Name = "animalSpecies";
            this.animalSpecies.Size = new System.Drawing.Size(442, 65);
            this.animalSpecies.TabIndex = 5;
            // 
            // dateReceived
            // 
            this.dateReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReceived.Location = new System.Drawing.Point(353, 362);
            this.dateReceived.Margin = new System.Windows.Forms.Padding(2);
            this.dateReceived.Name = "dateReceived";
            this.dateReceived.Size = new System.Drawing.Size(455, 39);
            this.dateReceived.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 71);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add Animal";
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 647);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateReceived);
            this.Controls.Add(this.animalSpecies);
            this.Controls.Add(this.animalName);
            this.Controls.Add(this.received);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddAnimalForm";
            this.Text = "AddAnimalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label received;
        private System.Windows.Forms.TextBox animalName;
        private System.Windows.Forms.TextBox animalSpecies;
        private System.Windows.Forms.DateTimePicker dateReceived;
        private System.Windows.Forms.Label label3;
    }
}

