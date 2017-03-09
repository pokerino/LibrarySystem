namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AddBook = new System.Windows.Forms.Button();
            this.titleField = new System.Windows.Forms.TextBox();
            this.BookLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.yearField = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.descField = new System.Windows.Forms.RichTextBox();
            this.memberNameField = new System.Windows.Forms.TextBox();
            this.AddMember = new System.Windows.Forms.Button();
            this.memberIdField = new System.Windows.Forms.TextBox();
            this.memberIdLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.ISBNField = new System.Windows.Forms.TextBox();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.authorNameField = new System.Windows.Forms.TextBox();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.AddAuthor = new System.Windows.Forms.Button();
            this.lbAuthor = new System.Windows.Forms.ListBox();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.authorChkBox = new System.Windows.Forms.CheckBox();
            this.availChkBox = new System.Windows.Forms.CheckBox();
            this.loanBtn = new System.Windows.Forms.Button();
            this.lbLoans = new System.Windows.Forms.ListBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.lbBooksLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.lbAuthorsLabel = new System.Windows.Forms.Label();
            this.lbMembersLabel = new System.Windows.Forms.Label();
            this.loanComboBox = new System.Windows.Forms.ComboBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.editLoanButton = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(13, 38);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(433, 381);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(451, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(272, 224);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(450, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(451, 338);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(271, 175);
            this.textBox2.TabIndex = 4;
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(137, 579);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(91, 23);
            this.AddBook.TabIndex = 5;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(12, 470);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(119, 20);
            this.titleField.TabIndex = 6;
            // 
            // BookLabel
            // 
            this.BookLabel.AutoSize = true;
            this.BookLabel.Location = new System.Drawing.Point(55, 454);
            this.BookLabel.Name = "BookLabel";
            this.BookLabel.Size = new System.Drawing.Size(32, 13);
            this.BookLabel.TabIndex = 8;
            this.BookLabel.Text = "Book";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(41, 490);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(55, 13);
            this.AuthorLabel.TabIndex = 9;
            this.AuthorLabel.Text = "Written by";
            // 
            // yearField
            // 
            this.yearField.Location = new System.Drawing.Point(12, 544);
            this.yearField.Name = "yearField";
            this.yearField.Size = new System.Drawing.Size(119, 20);
            this.yearField.TabIndex = 11;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(199, 454);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(66, 13);
            this.descLabel.TabIndex = 12;
            this.descLabel.Text = "Descpription";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(31, 528);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(81, 13);
            this.yearLabel.TabIndex = 13;
            this.yearLabel.Text = "Published Year:";
            // 
            // descField
            // 
            this.descField.Location = new System.Drawing.Point(137, 468);
            this.descField.Name = "descField";
            this.descField.Size = new System.Drawing.Size(188, 110);
            this.descField.TabIndex = 14;
            this.descField.Text = "";
            // 
            // memberNameField
            // 
            this.memberNameField.Location = new System.Drawing.Point(580, 528);
            this.memberNameField.Name = "memberNameField";
            this.memberNameField.Size = new System.Drawing.Size(100, 20);
            this.memberNameField.TabIndex = 15;
            // 
            // AddMember
            // 
            this.AddMember.Location = new System.Drawing.Point(549, 554);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(75, 23);
            this.AddMember.TabIndex = 16;
            this.AddMember.Text = "Add Member";
            this.AddMember.UseVisualStyleBackColor = true;
            this.AddMember.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // memberIdField
            // 
            this.memberIdField.Location = new System.Drawing.Point(474, 528);
            this.memberIdField.Name = "memberIdField";
            this.memberIdField.Size = new System.Drawing.Size(100, 20);
            this.memberIdField.TabIndex = 17;
            // 
            // memberIdLabel
            // 
            this.memberIdLabel.AutoSize = true;
            this.memberIdLabel.Location = new System.Drawing.Point(471, 515);
            this.memberIdLabel.Name = "memberIdLabel";
            this.memberIdLabel.Size = new System.Drawing.Size(88, 13);
            this.memberIdLabel.TabIndex = 18;
            this.memberIdLabel.Text = "Personal Number";
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Location = new System.Drawing.Point(589, 515);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(35, 13);
            this.memberNameLabel.TabIndex = 19;
            this.memberNameLabel.Text = "Name";
            // 
            // ISBNField
            // 
            this.ISBNField.Location = new System.Drawing.Point(12, 581);
            this.ISBNField.Name = "ISBNField";
            this.ISBNField.Size = new System.Drawing.Size(119, 20);
            this.ISBNField.TabIndex = 20;
            this.ISBNField.TextChanged += new System.EventHandler(this.ISBNField_TextChanged);
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Location = new System.Drawing.Point(55, 567);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(32, 13);
            this.ISBNLabel.TabIndex = 21;
            this.ISBNLabel.Text = "ISBN";
            // 
            // authorNameField
            // 
            this.authorNameField.Location = new System.Drawing.Point(949, 53);
            this.authorNameField.Name = "authorNameField";
            this.authorNameField.Size = new System.Drawing.Size(187, 20);
            this.authorNameField.TabIndex = 22;
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Location = new System.Drawing.Point(966, 37);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(72, 13);
            this.authorNameLabel.TabIndex = 23;
            this.authorNameLabel.Text = "Author Name:";
            // 
            // AddAuthor
            // 
            this.AddAuthor.Location = new System.Drawing.Point(963, 79);
            this.AddAuthor.Name = "AddAuthor";
            this.AddAuthor.Size = new System.Drawing.Size(75, 23);
            this.AddAuthor.TabIndex = 24;
            this.AddAuthor.Text = "Add Author";
            this.AddAuthor.UseVisualStyleBackColor = true;
            this.AddAuthor.Click += new System.EventHandler(this.AddAuthor_Click);
            // 
            // lbAuthor
            // 
            this.lbAuthor.FormattingEnabled = true;
            this.lbAuthor.Location = new System.Drawing.Point(730, 38);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(213, 225);
            this.lbAuthor.TabIndex = 25;
            this.lbAuthor.SelectedIndexChanged += new System.EventHandler(this.lbAuthor_SelectedIndexChanged);
            // 
            // authorComboBox
            // 
            this.authorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorComboBox.FormattingEnabled = true;
            this.authorComboBox.Location = new System.Drawing.Point(12, 504);
            this.authorComboBox.Name = "authorComboBox";
            this.authorComboBox.Size = new System.Drawing.Size(119, 21);
            this.authorComboBox.TabIndex = 26;
            // 
            // authorChkBox
            // 
            this.authorChkBox.AutoSize = true;
            this.authorChkBox.Location = new System.Drawing.Point(13, 425);
            this.authorChkBox.Name = "authorChkBox";
            this.authorChkBox.Size = new System.Drawing.Size(96, 17);
            this.authorChkBox.TabIndex = 27;
            this.authorChkBox.Text = "Filter by Author";
            this.authorChkBox.UseVisualStyleBackColor = true;
            this.authorChkBox.CheckedChanged += new System.EventHandler(this.authorChkBox_CheckedChanged);
            // 
            // availChkBox
            // 
            this.availChkBox.AutoSize = true;
            this.availChkBox.Location = new System.Drawing.Point(107, 425);
            this.availChkBox.Name = "availChkBox";
            this.availChkBox.Size = new System.Drawing.Size(114, 17);
            this.availChkBox.TabIndex = 28;
            this.availChkBox.Text = "Filter by Availability";
            this.availChkBox.UseVisualStyleBackColor = true;
            this.availChkBox.CheckedChanged += new System.EventHandler(this.availChkBox_CheckedChanged);
            // 
            // loanBtn
            // 
            this.loanBtn.Enabled = false;
            this.loanBtn.Location = new System.Drawing.Point(729, 284);
            this.loanBtn.Name = "loanBtn";
            this.loanBtn.Size = new System.Drawing.Size(163, 25);
            this.loanBtn.TabIndex = 29;
            this.loanBtn.Text = "Make a Loan";
            this.loanBtn.UseVisualStyleBackColor = true;
            this.loanBtn.Click += new System.EventHandler(this.loanBtn_Click);
            // 
            // lbLoans
            // 
            this.lbLoans.FormattingEnabled = true;
            this.lbLoans.Location = new System.Drawing.Point(730, 315);
            this.lbLoans.Name = "lbLoans";
            this.lbLoans.Size = new System.Drawing.Size(556, 277);
            this.lbLoans.TabIndex = 30;
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(898, 284);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(163, 25);
            this.returnBtn.TabIndex = 31;
            this.returnBtn.Text = "Return Loan";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // lbBooksLabel
            // 
            this.lbBooksLabel.AutoSize = true;
            this.lbBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBooksLabel.Location = new System.Drawing.Point(163, 15);
            this.lbBooksLabel.Name = "lbBooksLabel";
            this.lbBooksLabel.Size = new System.Drawing.Size(58, 20);
            this.lbBooksLabel.TabIndex = 32;
            this.lbBooksLabel.Text = "Books:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(530, 15);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(94, 20);
            this.descriptionLabel.TabIndex = 33;
            this.descriptionLabel.Text = "Information:";
            // 
            // lbAuthorsLabel
            // 
            this.lbAuthorsLabel.AutoSize = true;
            this.lbAuthorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthorsLabel.Location = new System.Drawing.Point(798, 15);
            this.lbAuthorsLabel.Name = "lbAuthorsLabel";
            this.lbAuthorsLabel.Size = new System.Drawing.Size(69, 20);
            this.lbAuthorsLabel.TabIndex = 34;
            this.lbAuthorsLabel.Text = "Authors:";
            // 
            // lbMembersLabel
            // 
            this.lbMembersLabel.AutoSize = true;
            this.lbMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMembersLabel.Location = new System.Drawing.Point(530, 284);
            this.lbMembersLabel.Name = "lbMembersLabel";
            this.lbMembersLabel.Size = new System.Drawing.Size(79, 20);
            this.lbMembersLabel.TabIndex = 35;
            this.lbMembersLabel.Text = "Members:";
            // 
            // loanComboBox
            // 
            this.loanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loanComboBox.FormattingEnabled = true;
            this.loanComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loanComboBox.Items.AddRange(new object[] {
            "Active Loans",
            "Loans overdue",
            "Loan history"});
            this.loanComboBox.Location = new System.Drawing.Point(1067, 286);
            this.loanComboBox.Name = "loanComboBox";
            this.loanComboBox.Size = new System.Drawing.Size(219, 21);
            this.loanComboBox.TabIndex = 36;
            this.loanComboBox.SelectedIndexChanged += new System.EventHandler(this.loanComboBox_SelectedIndexChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(1071, 204);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(215, 20);
            this.startDatePicker.TabIndex = 37;
            this.startDatePicker.Value = new System.DateTime(2016, 10, 30, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // dueDatePicker
            // 
            this.dueDatePicker.Location = new System.Drawing.Point(1071, 230);
            this.dueDatePicker.Name = "dueDatePicker";
            this.dueDatePicker.Size = new System.Drawing.Size(215, 20);
            this.dueDatePicker.TabIndex = 38;
            this.dueDatePicker.Value = new System.DateTime(2016, 11, 14, 0, 0, 0, 0);
            this.dueDatePicker.ValueChanged += new System.EventHandler(this.dueDatePicker_ValueChanged);
            // 
            // editLoanButton
            // 
            this.editLoanButton.Location = new System.Drawing.Point(1158, 256);
            this.editLoanButton.Name = "editLoanButton";
            this.editLoanButton.Size = new System.Drawing.Size(128, 23);
            this.editLoanButton.TabIndex = 39;
            this.editLoanButton.Text = "Edit Loan Date";
            this.editLoanButton.UseVisualStyleBackColor = true;
            this.editLoanButton.Click += new System.EventHandler(this.editLoanButton_Click);
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(299, 423);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(147, 20);
            this.searchField.TabIndex = 40;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Search Field:";
            // 
            // RemoveBook
            // 
            this.RemoveBook.Enabled = false;
            this.RemoveBook.Location = new System.Drawing.Point(234, 579);
            this.RemoveBook.Name = "RemoveBook";
            this.RemoveBook.Size = new System.Drawing.Size(91, 23);
            this.RemoveBook.TabIndex = 42;
            this.RemoveBook.Text = "Remove Copy";
            this.RemoveBook.UseVisualStyleBackColor = true;
            this.RemoveBook.Click += new System.EventHandler(this.RemoveBook_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 604);
            this.Controls.Add(this.RemoveBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.editLoanButton);
            this.Controls.Add(this.dueDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.loanComboBox);
            this.Controls.Add(this.lbMembersLabel);
            this.Controls.Add(this.lbAuthorsLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.lbBooksLabel);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.lbLoans);
            this.Controls.Add(this.loanBtn);
            this.Controls.Add(this.availChkBox);
            this.Controls.Add(this.authorChkBox);
            this.Controls.Add(this.authorComboBox);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.AddAuthor);
            this.Controls.Add(this.authorNameLabel);
            this.Controls.Add(this.authorNameField);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.ISBNField);
            this.Controls.Add(this.memberNameLabel);
            this.Controls.Add(this.memberIdLabel);
            this.Controls.Add(this.memberIdField);
            this.Controls.Add(this.AddMember);
            this.Controls.Add(this.memberNameField);
            this.Controls.Add(this.descField);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.yearField);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.BookLabel);
            this.Controls.Add(this.titleField);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbBooks);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.Label BookLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox yearField;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.RichTextBox descField;
        private System.Windows.Forms.TextBox memberNameField;
        private System.Windows.Forms.Button AddMember;
        private System.Windows.Forms.TextBox memberIdField;
        private System.Windows.Forms.Label memberIdLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.TextBox ISBNField;
        private System.Windows.Forms.Label ISBNLabel;
        private System.Windows.Forms.TextBox authorNameField;
        private System.Windows.Forms.Label authorNameLabel;
        private System.Windows.Forms.Button AddAuthor;
        private System.Windows.Forms.ListBox lbAuthor;
        private System.Windows.Forms.ComboBox authorComboBox;
        private System.Windows.Forms.CheckBox authorChkBox;
        private System.Windows.Forms.CheckBox availChkBox;
        private System.Windows.Forms.Button loanBtn;
        private System.Windows.Forms.ListBox lbLoans;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label lbBooksLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label lbAuthorsLabel;
        private System.Windows.Forms.Label lbMembersLabel;
        private System.Windows.Forms.ComboBox loanComboBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker dueDatePicker;
        private System.Windows.Forms.Button editLoanButton;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveBook;
    }
}

