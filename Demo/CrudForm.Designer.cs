//imports
using System.Windows.Forms;

//namespace
namespace Demo
{
    partial class CrudForm
    {

        //variables 
        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button selectAll;
        private Button selectBtn;
        private Button clearBtn;
        private Label label1;
        private Label label2;
        private ListBox queryList;
        private TextBox inputBox;
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            //Initialize variables 
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.selectAll = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.queryList = new System.Windows.Forms.ListBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();

            //insert button
            this.insertBtn.Location = new System.Drawing.Point(449, 433);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(124, 41);
            this.insertBtn.TabIndex = 0;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insert_Click);

            //update button
            this.updateBtn.Location = new System.Drawing.Point(615, 433);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(124, 41);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.update_Click);

            //delete button
            this.deleteBtn.Location = new System.Drawing.Point(783, 433);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(124, 41);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.delete_Click);

            //select all button
            this.selectAll.Location = new System.Drawing.Point(283, 433);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(124, 41);
            this.selectAll.TabIndex = 3;
            this.selectAll.Text = "Select All";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.Click += new System.EventHandler(this.select_All_Click);

            //select button
            this.selectBtn.Location = new System.Drawing.Point(121, 433);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(124, 41);
            this.selectBtn.TabIndex = 4;
            this.selectBtn.Text = "Select Specific";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.select_Click);

            this.clearBtn.Location = new System.Drawing.Point(450, 493);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(124, 41);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clear_Click);

            //list of results 
            this.queryList.FormattingEnabled = true;
            this.queryList.ItemHeight = 17;
            this.queryList.Location = new System.Drawing.Point(121, 93);
            this.queryList.Name = "queryList";
            this.queryList.Size = new System.Drawing.Size(786, 225);
            this.queryList.TabIndex = 5;

            //input for id related queries 
            this.inputBox.Location = new System.Drawing.Point(482, 371);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(91, 23);
            this.inputBox.TabIndex = 6;

            //Results title 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Results";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            //id input label 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id Input:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // CrudForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 487);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.queryList);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "CrudForm";
            this.Text = "Basic CRUD Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

