using System.Windows.Forms;

namespace Registration
{
    partial class member_input
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.memberName = new System.Windows.Forms.TextBox();
            this.memberAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Form";
            // 
            // memberName
            // 
            this.memberName.AcceptsTab = true;
            this.memberName.Location = new System.Drawing.Point(79, 91);
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(143, 20);
            this.memberName.TabIndex = 1;
            this.memberName.TextChanged += new System.EventHandler(this.memberName_TextChanged);
            // 
            // memberAge
            // 
            this.memberAge.AcceptsReturn = true;
            this.memberAge.AcceptsTab = true;
            this.memberAge.Location = new System.Drawing.Point(79, 121);
            this.memberAge.Name = "memberAge";
            this.memberAge.Size = new System.Drawing.Size(143, 20);
            this.memberAge.TabIndex = 2;
            this.memberAge.TextChanged += new System.EventHandler(this.memberAge_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age:";
            // 
            // submit
            // 
            this.submit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submit.Enabled = false;
            this.submit.Location = new System.Drawing.Point(104, 154);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // member_input
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 205);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberAge);
            this.Controls.Add(this.memberName);
            this.Controls.Add(this.label1);
            this.Name = "member_input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "member_input";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberName;
        private System.Windows.Forms.TextBox memberAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;

        public TextBox MemberName
        {
            get
            {
                return memberName;
            }

            set
            {
                memberName = value;
            }
        }

        public TextBox MemberAge
        {
            get
            {
                return memberAge;
            }

            set
            {
                memberAge = value;
            }
        }
    }
}