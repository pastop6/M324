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
            SuspendLayout();
            // 
            // listBoxTasks
            // 
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new Point(324, 78);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(120, 94);
            listBoxTasks.TabIndex = 0;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(136, 167);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(100, 23);
            textBoxTask.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(380, 225);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(87, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(380, 254);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(87, 23);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Löschen";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(380, 283);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(87, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
