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
            this.button1 = new System.Windows.Forms.Button();
            this.messageList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatList
            // 
            this.chatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatList.ContextMenuStrip = this.contextMenuStrip1;
            this.chatList.FormattingEnabled = true;
            this.chatList.Items.AddRange(new object[] {
            "Default"});
            this.chatList.Location = new System.Drawing.Point(12, 12);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(156, 351);
            this.chatList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChatListMenu_Add,
            this.ChatListMenu_Delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 48);
            // 
            // ChatListMenu_Add
            // 
            this.ChatListMenu_Add.Name = "ChatListMenu_Add";
            this.ChatListMenu_Add.Size = new System.Drawing.Size(143, 22);
            this.ChatListMenu_Add.Text = "Añadir chat";
            this.ChatListMenu_Add.Click += new System.EventHandler(this.ChatListMenu_Add_Click);
            // 
            // ChatListMenu_Delete
            // 
            this.ChatListMenu_Delete.Name = "ChatListMenu_Delete";
            this.ChatListMenu_Delete.Size = new System.Drawing.Size(143, 22);
            this.ChatListMenu_Delete.Text = "Eliminar chat";
            this.ChatListMenu_Delete.Click += new System.EventHandler(this.ChatListMenu_Delete_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(174, 330);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(425, 31);
            this.textBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(605, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageList
            // 
            this.messageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageList.FormattingEnabled = true;
            this.messageList.IntegralHeight = false;
            this.messageList.Location = new System.Drawing.Point(174, 12);
            this.messageList.MultiColumn = true;
            this.messageList.Name = "messageList";
            this.messageList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.messageList.Size = new System.Drawing.Size(464, 312);
            this.messageList.TabIndex = 1;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 373);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox messageList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChatListMenu_Add;
        private System.Windows.Forms.ToolStripMenuItem ChatListMenu_Delete;
    }
}

