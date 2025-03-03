namespace ToDoApp_UI
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
            listBoxTasks = new ListBox();
            textBoxTask = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(53, 118);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(120, 94);
            listBoxTasks.TabIndex = 0;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(53, 63);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(100, 23);
            textBoxTask.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(159, 57);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 32);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(53, 218);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(120, 33);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Löschen";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += ButtonRemove_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(53, 257);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(120, 32);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Daten sichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 45);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "Neues ToDo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 100);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 6;
            label2.Text = "Akutelle ToDo's:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTask);
            Controls.Add(listBoxTasks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTasks;
        private TextBox textBoxTask;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonSave;
        private Label label1;
        private Label label2;
    }
}
