namespace client_socketchat
{
    partial class ChatForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chatList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChatListMenu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ChatListMenu_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.messageList = new System.Windows.Forms.ListBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatList
            // 
            this.chatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatList.ContextMenuStrip = this.contextMenuStrip1;
            this.chatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatList.FormattingEnabled = true;
            this.chatList.ItemHeight = 20;
            this.chatList.Items.AddRange(new object[] {
            "Global"});
            this.chatList.Location = new System.Drawing.Point(12, 12);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(156, 340);
            this.chatList.TabIndex = 0;
            this.chatList.SelectedIndexChanged += new System.EventHandler(this.chatList_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChatListMenu_Add,
            this.ChatListMenu_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // ChatListMenu_Add
            // 
            this.ChatListMenu_Add.Name = "ChatListMenu_Add";
            this.ChatListMenu_Add.Size = new System.Drawing.Size(152, 22);
            this.ChatListMenu_Add.Text = "Afegir xat";
            this.ChatListMenu_Add.Click += new System.EventHandler(this.ChatListMenu_Add_Click);
            // 
            // ChatListMenu_Delete
            // 
            this.ChatListMenu_Delete.Name = "ChatListMenu_Delete";
            this.ChatListMenu_Delete.Size = new System.Drawing.Size(152, 22);
            this.ChatListMenu_Delete.Text = "Eliminar xat";
            this.ChatListMenu_Delete.Click += new System.EventHandler(this.ChatListMenu_Delete_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(176, 360);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(464, 22);
            this.textBox.TabIndex = 2;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // messageList
            // 
            this.messageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageList.FormattingEnabled = true;
            this.messageList.ItemHeight = 20;
            this.messageList.Location = new System.Drawing.Point(176, 12);
            this.messageList.Name = "messageList";
            this.messageList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.messageList.Size = new System.Drawing.Size(464, 340);
            this.messageList.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 359);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(156, 23);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Default:";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(652, 391);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.messageList);
            this.Controls.Add(this.chatList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChatForm";
            this.ShowIcon = false;
            this.Text = "SocketChat - Pablo González";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chatList;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox messageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChatListMenu_Add;
        private System.Windows.Forms.ToolStripMenuItem ChatListMenu_Delete;
        private System.Windows.Forms.Label UsernameLabel;
    }
}

