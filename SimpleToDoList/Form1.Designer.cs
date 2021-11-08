
namespace SimpleToDoList
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
            this.grdToDo = new System.Windows.Forms.DataGridView();
            this.TaskToDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDoing = new System.Windows.Forms.DataGridView();
            this.TaskDoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDone = new System.Windows.Forms.DataGridView();
            this.TaskDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnToDoToDoing = new System.Windows.Forms.Button();
            this.btnToDoToDone = new System.Windows.Forms.Button();
            this.btnDoingToDone = new System.Windows.Forms.Button();
            this.btnDoingToToDo = new System.Windows.Forms.Button();
            this.btnDoneToDoing = new System.Windows.Forms.Button();
            this.btnDoneToToDo = new System.Windows.Forms.Button();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblDoing = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDone)).BeginInit();
            this.SuspendLayout();
            // 
            // grdToDo
            // 
            this.grdToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskToDo});
            this.grdToDo.Location = new System.Drawing.Point(12, 36);
            this.grdToDo.Name = "grdToDo";
            this.grdToDo.RowTemplate.Height = 25;
            this.grdToDo.Size = new System.Drawing.Size(219, 359);
            this.grdToDo.TabIndex = 0;
            // 
            // TaskToDo
            // 
            this.TaskToDo.HeaderText = "Task To Do";
            this.TaskToDo.Name = "TaskToDo";
            // 
            // grdDoing
            // 
            this.grdDoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDoing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskDoing});
            this.grdDoing.Location = new System.Drawing.Point(277, 36);
            this.grdDoing.Name = "grdDoing";
            this.grdDoing.RowTemplate.Height = 25;
            this.grdDoing.Size = new System.Drawing.Size(219, 359);
            this.grdDoing.TabIndex = 1;
            // 
            // TaskDoing
            // 
            this.TaskDoing.HeaderText = "Task Doing";
            this.TaskDoing.Name = "TaskDoing";
            // 
            // grdDone
            // 
            this.grdDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskDone});
            this.grdDone.Location = new System.Drawing.Point(542, 36);
            this.grdDone.Name = "grdDone";
            this.grdDone.RowTemplate.Height = 25;
            this.grdDone.Size = new System.Drawing.Size(219, 359);
            this.grdDone.TabIndex = 2;
            // 
            // TaskDone
            // 
            this.TaskDone.HeaderText = "Task Done";
            this.TaskDone.Name = "TaskDone";
            // 
            // btnToDoToDoing
            // 
            this.btnToDoToDoing.Location = new System.Drawing.Point(12, 401);
            this.btnToDoToDoing.Name = "btnToDoToDoing";
            this.btnToDoToDoing.Size = new System.Drawing.Size(99, 23);
            this.btnToDoToDoing.TabIndex = 3;
            this.btnToDoToDoing.Text = "To Doing";
            this.btnToDoToDoing.UseVisualStyleBackColor = true;
            this.btnToDoToDoing.Click += new System.EventHandler(this.btnToDoToDoing_Click);
            // 
            // btnToDoToDone
            // 
            this.btnToDoToDone.Location = new System.Drawing.Point(132, 401);
            this.btnToDoToDone.Name = "btnToDoToDone";
            this.btnToDoToDone.Size = new System.Drawing.Size(99, 23);
            this.btnToDoToDone.TabIndex = 4;
            this.btnToDoToDone.Text = "To Done";
            this.btnToDoToDone.UseVisualStyleBackColor = true;
            this.btnToDoToDone.Click += new System.EventHandler(this.btnToDoToDone_Click);
            // 
            // btnDoingToDone
            // 
            this.btnDoingToDone.Location = new System.Drawing.Point(397, 401);
            this.btnDoingToDone.Name = "btnDoingToDone";
            this.btnDoingToDone.Size = new System.Drawing.Size(99, 23);
            this.btnDoingToDone.TabIndex = 6;
            this.btnDoingToDone.Text = "To Done";
            this.btnDoingToDone.UseVisualStyleBackColor = true;
            this.btnDoingToDone.Click += new System.EventHandler(this.btnDoingToDone_Click);
            // 
            // btnDoingToToDo
            // 
            this.btnDoingToToDo.Location = new System.Drawing.Point(277, 401);
            this.btnDoingToToDo.Name = "btnDoingToToDo";
            this.btnDoingToToDo.Size = new System.Drawing.Size(99, 23);
            this.btnDoingToToDo.TabIndex = 5;
            this.btnDoingToToDo.Text = "To To Do";
            this.btnDoingToToDo.UseVisualStyleBackColor = true;
            this.btnDoingToToDo.Click += new System.EventHandler(this.btnDoingToToDo_Click);
            // 
            // btnDoneToDoing
            // 
            this.btnDoneToDoing.Location = new System.Drawing.Point(662, 401);
            this.btnDoneToDoing.Name = "btnDoneToDoing";
            this.btnDoneToDoing.Size = new System.Drawing.Size(99, 23);
            this.btnDoneToDoing.TabIndex = 8;
            this.btnDoneToDoing.Text = "To Doing";
            this.btnDoneToDoing.UseVisualStyleBackColor = true;
            this.btnDoneToDoing.Click += new System.EventHandler(this.btnDoneToDoing_Click);
            // 
            // btnDoneToToDo
            // 
            this.btnDoneToToDo.Location = new System.Drawing.Point(542, 401);
            this.btnDoneToToDo.Name = "btnDoneToToDo";
            this.btnDoneToToDo.Size = new System.Drawing.Size(99, 23);
            this.btnDoneToToDo.TabIndex = 7;
            this.btnDoneToToDo.Text = "To To Do";
            this.btnDoneToToDo.UseVisualStyleBackColor = true;
            this.btnDoneToToDo.Click += new System.EventHandler(this.btnDoneToToDo_Click);
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Location = new System.Drawing.Point(95, 9);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(37, 15);
            this.lblToDo.TabIndex = 9;
            this.lblToDo.Text = "To Do";
            // 
            // lblDoing
            // 
            this.lblDoing.AutoSize = true;
            this.lblDoing.Location = new System.Drawing.Point(370, 9);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(39, 15);
            this.lblDoing.TabIndex = 10;
            this.lblDoing.Text = "Doing";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(634, 9);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(35, 15);
            this.lblDone.TabIndex = 11;
            this.lblDone.Text = "Done";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 440);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(219, 74);
            this.txtInput.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(542, 439);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(219, 75);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Calcular";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(277, 440);
            this.txtInput2.Multiline = true;
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(219, 74);
            this.txtInput2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 524);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblDoing);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.btnDoneToDoing);
            this.Controls.Add(this.btnDoneToToDo);
            this.Controls.Add(this.btnDoingToDone);
            this.Controls.Add(this.btnDoingToToDo);
            this.Controls.Add(this.btnToDoToDone);
            this.Controls.Add(this.btnToDoToDoing);
            this.Controls.Add(this.grdDone);
            this.Controls.Add(this.grdDoing);
            this.Controls.Add(this.grdToDo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDoing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdToDo;
        private System.Windows.Forms.DataGridView grdDoing;
        private System.Windows.Forms.DataGridView grdDone;
        private System.Windows.Forms.Button btnToDoToDoing;
        private System.Windows.Forms.Button btnToDoToDone;
        private System.Windows.Forms.Button btnDoingToDone;
        private System.Windows.Forms.Button btnDoingToToDo;
        private System.Windows.Forms.Button btnDoneToDoing;
        private System.Windows.Forms.Button btnDoneToToDo;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskToDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskDone;
        private System.Windows.Forms.TextBox txtInput2;
    }
}

