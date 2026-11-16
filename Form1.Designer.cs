namespace CyberSecurityBot.GUI
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
            lblTitle = new Label();
            lblAsciiArt = new Label();
            rtbChat = new RichTextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            tabName = new TabControl();
            tabChat = new TabPage();
            tabTasks = new TabPage();
            lblMyCybersecurityTasks = new Label();
            lblReminder = new Label();
            lblTaskDescrition = new Label();
            lblTaskTitle = new Label();
            btnAddTask = new Button();
            btnRefreshTasks = new Button();
            btnDeleteTask = new Button();
            btnCompleteTask = new Button();
            txtTaskDescription = new TextBox();
            lblTaskStatus = new Label();
            dgvTasks = new DataGridView();
            dtpReminder = new DateTimePicker();
            chkSetAReminder = new CheckBox();
            txtTaskTitle = new TextBox();
            tabQuiz = new TabPage();
            btnNextQuestion = new Button();
            btnSubmitAnswer = new Button();
            btnStartQuiz = new Button();
            rdoD = new RadioButton();
            rdoC = new RadioButton();
            rdoB = new RadioButton();
            rdoA = new RadioButton();
            lblQuizScore = new Label();
            lblQuizFeedback = new Label();
            lblQuestion = new Label();
            lblQuestionNumber = new Label();
            tabActivty = new TabPage();
            lblRecentActivities = new Label();
            Activity = new ListBox();
            btnShowMore = new Button();
            btnRefreshActivity = new Button();
            tabName.SuspendLayout();
            tabChat.SuspendLayout();
            tabTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            tabQuiz.SuspendLayout();
            tabActivty.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(343, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(329, 23);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CYBERSECURITY AWARENESS CHATBOT";
            lblTitle.Click += label1_Click;
            // 
            // lblAsciiArt
            // 
            lblAsciiArt.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAsciiArt.ForeColor = Color.Orange;
            lblAsciiArt.Location = new Point(343, 82);
            lblAsciiArt.Name = "lblAsciiArt";
            lblAsciiArt.Size = new Size(444, 89);
            lblAsciiArt.TabIndex = 1;
            lblAsciiArt.Text = "==================================\r\n CYBERSECURITY AWERENESS CHATBOT\r\n==================================";
            lblAsciiArt.Click += lblAsciiArt_Click;
            // 
            // rtbChat
            // 
            rtbChat.Location = new Point(15, 174);
            rtbChat.Name = "rtbChat";
            rtbChat.ReadOnly = true;
            rtbChat.Size = new Size(1020, 429);
            rtbChat.TabIndex = 2;
            rtbChat.Text = "";
            rtbChat.TextChanged += rtbChat_TextChanged;
            // 
            // txtMessage
            // 
            txtMessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMessage.Location = new Point(15, 610);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(897, 30);
            txtMessage.TabIndex = 3;
            txtMessage.TextChanged += txtMessage_TextChanged;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Red;
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(931, 610);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(104, 29);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // tabName
            // 
            tabName.Controls.Add(tabChat);
            tabName.Controls.Add(tabTasks);
            tabName.Controls.Add(tabQuiz);
            tabName.Controls.Add(tabActivty);
            tabName.Dock = DockStyle.Fill;
            tabName.Location = new Point(0, 0);
            tabName.Name = "tabName";
            tabName.SelectedIndex = 0;
            tabName.Size = new Size(1102, 693);
            tabName.TabIndex = 5;
            // 
            // tabChat
            // 
            tabChat.Controls.Add(lblTitle);
            tabChat.Controls.Add(btnSend);
            tabChat.Controls.Add(lblAsciiArt);
            tabChat.Controls.Add(txtMessage);
            tabChat.Controls.Add(rtbChat);
            tabChat.Location = new Point(4, 32);
            tabChat.Name = "tabChat";
            tabChat.Padding = new Padding(3);
            tabChat.Size = new Size(1094, 657);
            tabChat.TabIndex = 0;
            tabChat.Text = "Chat";
            tabChat.UseVisualStyleBackColor = true;
            tabChat.Click += tabPage1_Click;
            // 
            // tabTasks
            // 
            tabTasks.Controls.Add(lblMyCybersecurityTasks);
            tabTasks.Controls.Add(lblReminder);
            tabTasks.Controls.Add(lblTaskDescrition);
            tabTasks.Controls.Add(lblTaskTitle);
            tabTasks.Controls.Add(btnAddTask);
            tabTasks.Controls.Add(btnRefreshTasks);
            tabTasks.Controls.Add(btnDeleteTask);
            tabTasks.Controls.Add(btnCompleteTask);
            tabTasks.Controls.Add(txtTaskDescription);
            tabTasks.Controls.Add(lblTaskStatus);
            tabTasks.Controls.Add(dgvTasks);
            tabTasks.Controls.Add(dtpReminder);
            tabTasks.Controls.Add(chkSetAReminder);
            tabTasks.Controls.Add(txtTaskTitle);
            tabTasks.Location = new Point(4, 29);
            tabTasks.Name = "tabTasks";
            tabTasks.Padding = new Padding(3);
            tabTasks.Size = new Size(1094, 660);
            tabTasks.TabIndex = 1;
            tabTasks.Text = "Tasks";
            tabTasks.UseVisualStyleBackColor = true;
            // 
            // lblMyCybersecurityTasks
            // 
            lblMyCybersecurityTasks.AutoSize = true;
            lblMyCybersecurityTasks.Location = new Point(19, 337);
            lblMyCybersecurityTasks.Name = "lblMyCybersecurityTasks";
            lblMyCybersecurityTasks.Size = new Size(196, 23);
            lblMyCybersecurityTasks.TabIndex = 18;
            lblMyCybersecurityTasks.Text = "My Cybersecurity Tasks";
            // 
            // lblReminder
            // 
            lblReminder.AutoSize = true;
            lblReminder.Location = new Point(19, 185);
            lblReminder.Name = "lblReminder";
            lblReminder.Size = new Size(88, 23);
            lblReminder.TabIndex = 17;
            lblReminder.Text = "Reminder";
            // 
            // lblTaskDescrition
            // 
            lblTaskDescrition.AutoSize = true;
            lblTaskDescrition.Location = new Point(27, 117);
            lblTaskDescrition.Name = "lblTaskDescrition";
            lblTaskDescrition.Size = new Size(142, 23);
            lblTaskDescrition.TabIndex = 16;
            lblTaskDescrition.Text = "Task Description";
            // 
            // lblTaskTitle
            // 
            lblTaskTitle.AutoSize = true;
            lblTaskTitle.Location = new Point(19, 46);
            lblTaskTitle.Name = "lblTaskTitle";
            lblTaskTitle.Size = new Size(86, 23);
            lblTaskTitle.TabIndex = 15;
            lblTaskTitle.Text = "Task Title";
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(19, 265);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(1051, 57);
            btnAddTask.TabIndex = 14;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click_1;
            // 
            // btnRefreshTasks
            // 
            btnRefreshTasks.Location = new Point(391, 620);
            btnRefreshTasks.Name = "btnRefreshTasks";
            btnRefreshTasks.Size = new Size(180, 29);
            btnRefreshTasks.TabIndex = 11;
            btnRefreshTasks.Text = "Refresh Tasks";
            btnRefreshTasks.UseVisualStyleBackColor = true;
            btnRefreshTasks.Click += btnRefreshTasks_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(205, 620);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(180, 29);
            btnDeleteTask.TabIndex = 10;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.Location = new Point(19, 620);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(180, 29);
            btnCompleteTask.TabIndex = 9;
            btnCompleteTask.Text = "Complete Task";
            btnCompleteTask.UseVisualStyleBackColor = true;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(19, 115);
            txtTaskDescription.Multiline = true;
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(1051, 60);
            txtTaskDescription.TabIndex = 6;
            txtTaskDescription.TextChanged += txtTaskDescription_TextChanged;
            // 
            // lblTaskStatus
            // 
            lblTaskStatus.AutoSize = true;
            lblTaskStatus.Location = new Point(19, 17);
            lblTaskStatus.Name = "lblTaskStatus";
            lblTaskStatus.Size = new Size(134, 23);
            lblTaskStatus.TabIndex = 5;
            lblTaskStatus.Text = "Add a new task";
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(19, 382);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new Size(1051, 216);
            dgvTasks.TabIndex = 4;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            // 
            // dtpReminder
            // 
            dtpReminder.Location = new Point(19, 214);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.Size = new Size(1051, 30);
            dtpReminder.TabIndex = 2;
            // 
            // chkSetAReminder
            // 
            chkSetAReminder.AutoSize = true;
            chkSetAReminder.Location = new Point(912, 181);
            chkSetAReminder.Name = "chkSetAReminder";
            chkSetAReminder.Size = new Size(158, 27);
            chkSetAReminder.TabIndex = 1;
            chkSetAReminder.Text = "Set A Reminder";
            chkSetAReminder.UseVisualStyleBackColor = true;
            chkSetAReminder.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(19, 43);
            txtTaskTitle.Multiline = true;
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(1051, 66);
            txtTaskTitle.TabIndex = 0;
            // 
            // tabQuiz
            // 
            tabQuiz.Controls.Add(btnNextQuestion);
            tabQuiz.Controls.Add(btnSubmitAnswer);
            tabQuiz.Controls.Add(btnStartQuiz);
            tabQuiz.Controls.Add(rdoD);
            tabQuiz.Controls.Add(rdoC);
            tabQuiz.Controls.Add(rdoB);
            tabQuiz.Controls.Add(rdoA);
            tabQuiz.Controls.Add(lblQuizScore);
            tabQuiz.Controls.Add(lblQuizFeedback);
            tabQuiz.Controls.Add(lblQuestion);
            tabQuiz.Controls.Add(lblQuestionNumber);
            tabQuiz.Location = new Point(4, 32);
            tabQuiz.Name = "tabQuiz";
            tabQuiz.Padding = new Padding(3);
            tabQuiz.Size = new Size(1094, 657);
            tabQuiz.TabIndex = 2;
            tabQuiz.Text = "Cyber Quiz";
            tabQuiz.UseVisualStyleBackColor = true;
            tabQuiz.Click += tabPage3_Click;
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.Location = new Point(550, 477);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new Size(520, 29);
            btnNextQuestion.TabIndex = 10;
            btnNextQuestion.Text = "Next Quesstion";
            btnNextQuestion.UseVisualStyleBackColor = true;
            btnNextQuestion.Click += btnNextQuestion_Click;
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.Location = new Point(17, 477);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(520, 29);
            btnSubmitAnswer.TabIndex = 9;
            btnSubmitAnswer.Text = "Submit Answer";
            btnSubmitAnswer.UseVisualStyleBackColor = true;
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(16, 6);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(1054, 48);
            btnStartQuiz.TabIndex = 8;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // rdoD
            // 
            rdoD.AutoSize = true;
            rdoD.Location = new Point(17, 378);
            rdoD.Name = "rdoD";
            rdoD.Size = new Size(48, 27);
            rdoD.TabIndex = 7;
            rdoD.Text = "D.";
            rdoD.UseVisualStyleBackColor = true;
            // 
            // rdoC
            // 
            rdoC.AutoSize = true;
            rdoC.Location = new Point(16, 297);
            rdoC.Name = "rdoC";
            rdoC.Size = new Size(47, 27);
            rdoC.TabIndex = 6;
            rdoC.Text = "C.";
            rdoC.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            rdoB.AutoSize = true;
            rdoB.Location = new Point(16, 228);
            rdoB.Name = "rdoB";
            rdoB.Size = new Size(47, 27);
            rdoB.TabIndex = 5;
            rdoB.Text = "B.";
            rdoB.UseVisualStyleBackColor = true;
            // 
            // rdoA
            // 
            rdoA.AutoSize = true;
            rdoA.Checked = true;
            rdoA.Location = new Point(17, 159);
            rdoA.Name = "rdoA";
            rdoA.Size = new Size(48, 27);
            rdoA.TabIndex = 4;
            rdoA.TabStop = true;
            rdoA.Text = "A.";
            rdoA.UseVisualStyleBackColor = true;
            // 
            // lblQuizScore
            // 
            lblQuizScore.AutoSize = true;
            lblQuizScore.Location = new Point(972, 68);
            lblQuizScore.Name = "lblQuizScore";
            lblQuizScore.Size = new Size(59, 23);
            lblQuizScore.TabIndex = 3;
            lblQuizScore.Text = "Score:";
            // 
            // lblQuizFeedback
            // 
            lblQuizFeedback.AutoSize = true;
            lblQuizFeedback.Location = new Point(17, 535);
            lblQuizFeedback.Name = "lblQuizFeedback";
            lblQuizFeedback.Size = new Size(133, 23);
            lblQuizFeedback.TabIndex = 2;
            lblQuizFeedback.Text = "Quiz Feedback:";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(16, 108);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(86, 23);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question:";
            lblQuestion.Click += lblQuestion_Click;
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Location = new Point(16, 68);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(81, 23);
            lblQuestionNumber.TabIndex = 0;
            lblQuestionNumber.Text = "Question";
            // 
            // tabActivty
            // 
            tabActivty.Controls.Add(lblRecentActivities);
            tabActivty.Controls.Add(Activity);
            tabActivty.Controls.Add(btnShowMore);
            tabActivty.Controls.Add(btnRefreshActivity);
            tabActivty.Location = new Point(4, 29);
            tabActivty.Name = "tabActivty";
            tabActivty.Padding = new Padding(3);
            tabActivty.Size = new Size(1094, 660);
            tabActivty.TabIndex = 3;
            tabActivty.Text = "Activity Log";
            tabActivty.UseVisualStyleBackColor = true;
            // 
            // lblRecentActivities
            // 
            lblRecentActivities.AutoSize = true;
            lblRecentActivities.Location = new Point(8, 21);
            lblRecentActivities.Name = "lblRecentActivities";
            lblRecentActivities.Size = new Size(143, 23);
            lblRecentActivities.TabIndex = 16;
            lblRecentActivities.Text = "Recent Activities";
            // 
            // Activity
            // 
            Activity.FormattingEnabled = true;
            Activity.Location = new Point(8, 47);
            Activity.Name = "Activity";
            Activity.Size = new Size(1078, 556);
            Activity.TabIndex = 15;
            // 
            // btnShowMore
            // 
            btnShowMore.Location = new Point(553, 620);
            btnShowMore.Name = "btnShowMore";
            btnShowMore.Size = new Size(535, 29);
            btnShowMore.TabIndex = 14;
            btnShowMore.Text = "Show More";
            btnShowMore.UseVisualStyleBackColor = true;
            btnShowMore.Click += btnShowMore_Click_1;
            // 
            // btnRefreshActivity
            // 
            btnRefreshActivity.Location = new Point(8, 620);
            btnRefreshActivity.Name = "btnRefreshActivity";
            btnRefreshActivity.Size = new Size(539, 29);
            btnRefreshActivity.TabIndex = 13;
            btnRefreshActivity.Text = "Refresh Activity";
            btnRefreshActivity.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1102, 693);
            Controls.Add(tabName);
            Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CyberSecurity Awareness Chatbot";
            Load += Form1_Load;
            tabName.ResumeLayout(false);
            tabChat.ResumeLayout(false);
            tabChat.PerformLayout();
            tabTasks.ResumeLayout(false);
            tabTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            tabQuiz.ResumeLayout(false);
            tabQuiz.PerformLayout();
            tabActivty.ResumeLayout(false);
            tabActivty.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblAsciiArt;
        private RichTextBox rtbChat;
        private TextBox txtMessage;
        private Button btnSend;
        private TabControl tabName;
        private TabPage tabChat;
        private TabPage tabTasks;
        private TabPage tabQuiz;
        private TabPage tabActivty;
        private TextBox txtTaskTitle;
        private CheckBox chkSetAReminder;
        private DateTimePicker dtpReminder;
        private TextBox txtTaskDescription;
        private Label lblTaskStatus;
        private DataGridView dgvTasks;
        private Button btnCompleteTask;
        private Button btnDeleteTask;
        private Button btnRefreshTasks;
        private Button btnAddTask;
        private Label lblTaskTitle;
        private Label lblReminder;
        private Label lblTaskDescrition;
        private Label lblMyCybersecurityTasks;
        private Button btnRefreshActivity;
        private Button btnShowMore;
        private ListBox Activity;
        private Label lblQuizScore;
        private Label lblQuizFeedback;
        private Label lblQuestion;
        private Label lblQuestionNumber;
        private Label lblRecentActivities;
        private RadioButton rdoD;
        private RadioButton rdoC;
        private RadioButton rdoB;
        private RadioButton rdoA;
        private Button btnNextQuestion;
        private Button btnSubmitAnswer;
        private Button btnStartQuiz;
    }
}
