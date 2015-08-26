namespace HelloFieldWorld
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRequest = new System.Windows.Forms.Label();
            this.labelResponse = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.buttonProjects = new System.Windows.Forms.Button();
            this.labelProject = new System.Windows.Forms.Label();
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.comboBoxEquipments = new System.Windows.Forms.ComboBox();
            this.buttonEquipments = new System.Windows.Forms.Button();
            this.labelFile1 = new System.Windows.Forms.Label();
            this.labelFile2 = new System.Windows.Forms.Label();
            this.textBoxFile1 = new System.Windows.Forms.TextBox();
            this.textBoxFile2 = new System.Windows.Forms.TextBox();
            this.buttonFile1 = new System.Windows.Forms.Button();
            this.buttonFile2 = new System.Windows.Forms.Button();
            this.buttonAttachments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(20, 20);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(79, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(20, 60);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelRequest
            // 
            this.labelRequest.AutoSize = true;
            this.labelRequest.Location = new System.Drawing.Point(20, 295);
            this.labelRequest.Name = "labelRequest";
            this.labelRequest.Size = new System.Drawing.Size(61, 17);
            this.labelRequest.TabIndex = 2;
            this.labelRequest.Text = "Request";
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(20, 390);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(72, 17);
            this.labelResponse.TabIndex = 3;
            this.labelResponse.Text = "Response";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(380, 60);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(90, 25);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(120, 20);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(230, 22);
            this.textBoxUserName.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(120, 60);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(230, 22);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Location = new System.Drawing.Point(20, 317);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequest.Size = new System.Drawing.Size(440, 70);
            this.textBoxRequest.TabIndex = 7;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Location = new System.Drawing.Point(20, 410);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(440, 130);
            this.textBoxResponse.TabIndex = 8;
            // 
            // buttonProjects
            // 
            this.buttonProjects.Location = new System.Drawing.Point(380, 110);
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Size = new System.Drawing.Size(90, 25);
            this.buttonProjects.TabIndex = 9;
            this.buttonProjects.Text = "Projects";
            this.buttonProjects.UseVisualStyleBackColor = true;
            this.buttonProjects.Click += new System.EventHandler(this.buttonProjects_Click);
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Location = new System.Drawing.Point(20, 110);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(52, 17);
            this.labelProject.TabIndex = 10;
            this.labelProject.Text = "Project";
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(120, 110);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(230, 24);
            this.comboBoxProjects.TabIndex = 18;
            this.comboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjects_SelectedIndexChanged);
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Location = new System.Drawing.Point(20, 150);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(75, 17);
            this.labelEquipment.TabIndex = 19;
            this.labelEquipment.Text = "Equipment";
            // 
            // comboBoxEquipments
            // 
            this.comboBoxEquipments.FormattingEnabled = true;
            this.comboBoxEquipments.Location = new System.Drawing.Point(120, 150);
            this.comboBoxEquipments.Name = "comboBoxEquipments";
            this.comboBoxEquipments.Size = new System.Drawing.Size(230, 24);
            this.comboBoxEquipments.TabIndex = 20;
            this.comboBoxEquipments.SelectedIndexChanged += new System.EventHandler(this.comboBoxEquipments_SelectedIndexChanged);
            // 
            // buttonEquipments
            // 
            this.buttonEquipments.Location = new System.Drawing.Point(380, 150);
            this.buttonEquipments.Name = "buttonEquipments";
            this.buttonEquipments.Size = new System.Drawing.Size(90, 25);
            this.buttonEquipments.TabIndex = 21;
            this.buttonEquipments.Text = "Equipments";
            this.buttonEquipments.UseVisualStyleBackColor = true;
            this.buttonEquipments.Click += new System.EventHandler(this.buttonEquipments_Click);
            // 
            // labelFile1
            // 
            this.labelFile1.AutoSize = true;
            this.labelFile1.Location = new System.Drawing.Point(20, 210);
            this.labelFile1.Name = "labelFile1";
            this.labelFile1.Size = new System.Drawing.Size(30, 17);
            this.labelFile1.TabIndex = 22;
            this.labelFile1.Text = "File";
            // 
            // labelFile2
            // 
            this.labelFile2.AutoSize = true;
            this.labelFile2.Location = new System.Drawing.Point(20, 250);
            this.labelFile2.Name = "labelFile2";
            this.labelFile2.Size = new System.Drawing.Size(74, 17);
            this.labelFile2.TabIndex = 23;
            this.labelFile2.Text = "Thumbnail";
            // 
            // textBoxFile1
            // 
            this.textBoxFile1.Location = new System.Drawing.Point(120, 210);
            this.textBoxFile1.Name = "textBoxFile1";
            this.textBoxFile1.Size = new System.Drawing.Size(230, 22);
            this.textBoxFile1.TabIndex = 24;
            // 
            // textBoxFile2
            // 
            this.textBoxFile2.Location = new System.Drawing.Point(120, 250);
            this.textBoxFile2.Name = "textBoxFile2";
            this.textBoxFile2.Size = new System.Drawing.Size(230, 22);
            this.textBoxFile2.TabIndex = 25;
            // 
            // buttonFile1
            // 
            this.buttonFile1.Location = new System.Drawing.Point(350, 210);
            this.buttonFile1.Name = "buttonFile1";
            this.buttonFile1.Size = new System.Drawing.Size(25, 25);
            this.buttonFile1.TabIndex = 26;
            this.buttonFile1.Text = "...";
            this.buttonFile1.UseVisualStyleBackColor = true;
            this.buttonFile1.Click += new System.EventHandler(this.buttonFile1_Click);
            // 
            // buttonFile2
            // 
            this.buttonFile2.Location = new System.Drawing.Point(350, 250);
            this.buttonFile2.Name = "buttonFile2";
            this.buttonFile2.Size = new System.Drawing.Size(25, 25);
            this.buttonFile2.TabIndex = 27;
            this.buttonFile2.Text = "...";
            this.buttonFile2.UseVisualStyleBackColor = true;
            this.buttonFile2.Click += new System.EventHandler(this.buttonFile2_Click);
            // 
            // buttonAttachments
            // 
            this.buttonAttachments.Location = new System.Drawing.Point(380, 250);
            this.buttonAttachments.Name = "buttonAttachments";
            this.buttonAttachments.Size = new System.Drawing.Size(90, 25);
            this.buttonAttachments.TabIndex = 28;
            this.buttonAttachments.Text = "Attachments";
            this.buttonAttachments.UseVisualStyleBackColor = true;
            this.buttonAttachments.Click += new System.EventHandler(this.buttonAttachments_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 555);
            this.Controls.Add(this.buttonAttachments);
            this.Controls.Add(this.buttonFile2);
            this.Controls.Add(this.buttonFile1);
            this.Controls.Add(this.textBoxFile2);
            this.Controls.Add(this.textBoxFile1);
            this.Controls.Add(this.labelFile2);
            this.Controls.Add(this.labelFile1);
            this.Controls.Add(this.buttonEquipments);
            this.Controls.Add(this.comboBoxEquipments);
            this.Controls.Add(this.labelEquipment);
            this.Controls.Add(this.comboBoxProjects);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.buttonProjects);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.labelRequest);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Name = "Form1";
            this.Text = "Field API Intro Attachment Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRequest;
        private System.Windows.Forms.Label labelResponse;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Button buttonProjects;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.ComboBox comboBoxEquipments;
        private System.Windows.Forms.Button buttonEquipments;
        private System.Windows.Forms.Label labelFile1;
        private System.Windows.Forms.Label labelFile2;
        private System.Windows.Forms.TextBox textBoxFile1;
        private System.Windows.Forms.TextBox textBoxFile2;
        private System.Windows.Forms.Button buttonFile1;
        private System.Windows.Forms.Button buttonFile2;
        private System.Windows.Forms.Button buttonAttachments;
    }
}

