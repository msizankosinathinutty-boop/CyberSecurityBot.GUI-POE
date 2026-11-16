using CybersecurityAwarenessBot.Models;
using CybersecurityAwarenessBot.Data;
using MySql.Data.MySqlClient;
using CybersecurityAwarenessBot.GUI;
using CybersecurityAwarenessBot.Services;
using System.Collections.Generic;

namespace CyberSecurityBot.GUI
{
    public partial class Form1 : Form

    {
        private readonly TaskRepository taskRepository =
            new TaskRepository();

        private void TestDatabaseConnection()
        {
            try
            {
                using (MySqlConnection connection =
                       new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    connection.Open();

                    MessageBox.Show("Database connection successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection failed: " + ex.Message);
            }
        }

        private readonly QuizManager quizManager = new QuizManager();

        private readonly NlpProcessor nlpProcessor =
    new NlpProcessor();

        private readonly QuizManager quizManager =
            new QuizManager();

        private readonly ActivityLogger activityLogger =
            new ActivityLogger();

        private readonly TaskRepository taskRepository =
            new TaskRepository();

        private VoiceGreeting voiceGreeting = new VoiceGreeting();

        private ResponseHandler bot = new ResponseHandler();

        public Form1()
        {
            InitializeComponent();

            TestDatabaseConnection();
            voiceGreeting.PlayGreeting();
        }


        private string AddTaskFromChat(
            string taskTitle,
            DateTime? reminderDate)
        {
            if (taskTitle.Trim() == "")
            {
                return "I recognised that you want to add a task, " +
                       "but I need the task details. " +
                       "Try: Add a task to review my privacy settings.";
            }

            CyberTask task = new CyberTask
            {
                Title = taskTitle,

                Description =
                    "Task created from chatbot conversation.",

                ReminderDate = reminderDate,

                IsCompleted = false
            };

            try
            {
                int id = taskRepository.AddTask(task);

                activityLogger.Log(
                    "Task added through chatbot: " + taskTitle);

                if (reminderDate.HasValue)
                {
                    activityLogger.Log(
                        "Reminder set for " + taskTitle +
                        " on " +
                        reminderDate.Value.ToShortDateString());
                }

                LoadTasks();

                if (reminderDate.HasValue)
                {
                    return "Task added: " + taskTitle +
                           ". Reminder set for " +
                           reminderDate.Value.ToShortDateString() + ".";
                }

                return "Task added: " + taskTitle +
                       ". You can open the Tasks tab to add a reminder.";
            }
            catch (Exception ex)
            {
                return "I could not save that task: " + ex.Message;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtUserInput.Text.Trim();

            if (message == "")
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            rtbChatHistory.AppendText(
                "YOU: " + message + Environment.NewLine);

            IntentResult result =
                nlpProcessor.DetectIntent(message);

            string botResponse;

            switch (result.Intent)
            {
                case UserIntent.StartQuiz:

                    tabMain.SelectedTab = tabQuiz;

                    quizManager.StartQuiz();

                    activityLogger.Log(
                        "Quiz started through chatbot command");

                    lblQuizFeedback.Text = "";
                    btnSubmitAnswer.Enabled = true;
                    btnNextQuestion.Enabled = false;

                    DisplayCurrentQuestion();

                    botResponse =
                        "Sure. I have opened the cybersecurity quiz.";

                    break;

                case UserIntent.ShowTasks:

                    tabMain.SelectedTab = tabTasks;

                    LoadTasks();

                    botResponse =
                        "Here are your saved cybersecurity tasks.";

                    break;

                case UserIntent.ShowActivityLog:

                    tabMain.SelectedTab = tabActivity;

                    activityLogger.Log(
                        "Activity log requested through chatbot");

                    DisplayRecentActivity(5);

                    botResponse =
                        "Here are your most recent actions.";

                    break;

                case UserIntent.AddTask:

                    botResponse = AddTaskFromChat(
                        result.TaskTitle, null);

                    break;

                case UserIntent.AddTaskWithReminder:

                    botResponse = AddTaskFromChat(
                        result.TaskTitle,
                        result.ReminderDate);

                    break;

                default:

                    // Keep your existing Part 2 chatbot response logic here.
                    // Replace this example with your actual method call.

                    botResponse = chatBot.ProcessInput(message);

                    break;
            }

            rtbChatHistory.AppendText(
                "BOT: " + botResponse +
                Environment.NewLine + Environment.NewLine);

            txtUserInput.Clear();
            txtUserInput.Focus();

            DisplayRecentActivity(5);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAsciiArt_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void LoadTasks()
        {
            try
            {
                dgvTasks.DataSource = null;

                dgvTasks.DataSource = taskRepository.GetAllTasks();

                // Hide the database ID column.
                if (dgvTasks.Columns["TaskId"] != null)
                {
                    dgvTasks.Columns["TaskId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                lblTaskStatus.Text =
                    "Could not load tasks: " + ex.Message;
            }
        }


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text.Trim();
            string description = txtTaskDescription.Text.Trim();

            // Check that the required fields are filled in.
            if (title == "" || description == "")
            {
                lblTaskStatus.Text =
                    "Please enetr both a task title and description.";

                return;

            }

            // Create a new Cybertask object.
            CyberTask task = new CyberTask
            {
                Title = title,
                Description = description,

                ReminderDate = chkSetAReminder.Checked
                ? dtpReminder.Value :
                null,

                IsCompleted = false

            };

            try
            {
                int newTaskId = taskRepository.AddTask(task);

                lblTaskStatus.Text =
                    "Task added successfully. ID: " + newTaskId;

                txtTaskTitle.Clear();
                txtTaskDescription.Clear();
                chkSetAReminder.Checked = false;

                LoadTasks();
            }

            catch (Exception ex)

            {
                lblTaskStatus.Text =
                    "Task could not be saved: " + ex.Message;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private CyberTask? GetSelectedTask()
        {
            if (dgvTasks.CurrentRow == null)
            {
                return null;
            }


            return dgvTasks.CurrentRow.DataBoundItem as CyberTask;
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            CyberTask? task = GetSelectedTask();

            if (task == null)
            {
                lblTaskStatus.Text = "Please select a task first.";
                return;
            }

            try
            {
                taskRepository.MarkTaskCompleted(task.TaskId);

                lblTaskStatus.Text = "Task marked as completed.";

                LoadTasks();

            }
            catch (Exception ex)
            {
                lblTaskStatus.Text =
                    "Could not mark task as completed: " + ex.Message;
            }

            activityLogger.Log("Task completed: " + task.Title);
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            CyberTask? task = GetSelectedTask();

            if (task == null)
            {
                lblTaskStatus.Text = "Please select a task first.";
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Delete this task? " + task.Title,
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                taskRepository.DeleteTask(task.TaskId);

                lblTaskStatus.Text = "Task deleted.";

                LoadTasks();
            }
            catch (Exception ex)
            {
                lblTaskStatus.Text =
                    "Could not delete task: " + ex.Message;
            }

            activityLogger.Log("Task deleted: " + task.Title);
        }

        private void btnRefreshTasks_Click(object sender, EventArgs e)
        {
            LoadTasks();

            lblTaskStatus.Text =
                "Task list refreshed from MySQL.";

        }

        private void rtbChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayRecentActivity(int count)
        {
            1stActivity.Items.Clear();

            Lisit<ActivityEntry> recent =
                ActivityLogger.GetRecent(count);

            if (recent.Count == 0)
            {
                1stActivity.Items.Add("No activity recorded yet.");
                return;
            }

            foreach (ActivityEntry entry in recent)
            {
                1stActivity.Items.Add(entry.ToString());
            }
        }

        private void btnRefreshActivity_Click(object sender, EventArgs e)
        {
            DisplayRecentActivity(5);
        }

        private void btnShowMore_Click(object sender, EventArgs e)
        {
            DisplayRecentActivity(10);
        }

        private readonly ActivityLogger activityLogger = new ActivityLogger();

        private void btnAddTask_Click_1(object sender, EventArgs e)
        {
            activityLogger.Log("Task added: " + task.Title);
        }

        private void txtTaskDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowMore_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            quizManager.StartQuiz();

            activityLogger.Log("Cybersecurity quiz started");

            lblQuizFeedback.Text = "";

            btnSubmitAnswer.Enabled = true;
            btnNextQuestion.Enabled = false;

            DisplayCurrentQuestion();

            DisplayRecentActivity(5);
        }

        private void DisplayCurrentQuestion()
        {
            QuizQuestion question = quizManager.CurrentQuestion;

            lblQuestionNumber.Text =
                $"Question {quizManager.CurrentIndex + 1} " +
                $"of {quizManager.TotalQuestions}";

            lblQuestion.Text = question.QuestionText;

            RadioButton[] buttons =
            {
        rdoA, rdoB, rdoC, rdoD
    };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Checked = false;

                if (i < question.Options.Count)
                {
                    buttons[i].Text = question.Options[i];
                    buttons[i].Visible = true;
                }
                else
                {
                    buttons[i].Visible = false;
                }
            }

            lblQuizScore.Text =
                $"Score: {quizManager.Score}/{quizManager.TotalQuestions}";
        }


        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private int GetSelectedQuizOption()
        {
            if (rdoA.Checked) return 0;
            if (rdoB.Checked) return 1;
            if (rdoC.Checked) return 2;
            if (rdoD.Checked) return 3;

            return -1;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedQuizOption();

            if (selectedIndex == -1)
            {
                lblQuizFeedback.Text = "Please select an answer.";
                return;
            }

            QuizAnswerResult result =
                quizManager.CheckAnswer(selectedIndex);

            lblQuizFeedback.Text = result.Feedback;

            lblQuizScore.Text =
                $"Score: {quizManager.Score}/{quizManager.TotalQuestions}";

            btnSubmitAnswer.Enabled = false;
            btnNextQuestion.Enabled = true;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            bool hasAnotherQuestion = quizManager.MoveNext();

            if (hasAnotherQuestion)
            {
                lblQuizFeedback.Text = "";

                btnSubmitAnswer.Enabled = true;
                btnNextQuestion.Enabled = false;

                DisplayCurrentQuestion();
            }
            else
            {
                string message =
                    $"Quiz complete! Final score: " +
                    $"{quizManager.Score}/{quizManager.TotalQuestions}.";

                lblQuizFeedback.Text = message;

                activityLogger.Log(
                    $"Quiz completed - score " +
                    $"{quizManager.Score}/{quizManager.TotalQuestions}");

                btnSubmitAnswer.Enabled = false;
                btnNextQuestion.Enabled = false;

                DisplayRecentActivity(5);
            }
        }

        private string GetFinalQuizComment()
        {
            double percentage =
                (double)quizManager.Score /
                quizManager.TotalQuestions * 100;

            if (percentage >= 80)
                return "Excellent! You have strong cybersecurity awareness.";

            if (percentage >= 60)
                return "Good work. Review the topics you missed.";

            return "Keep learning. Revisit the cybersecurity tips and try again.";
        }

    }
}
