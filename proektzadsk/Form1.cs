namespace proektzadsk
{
    public partial class Form1 : Form
    {
        //placeholderText set
        private string placeholderText = "Enter file path here: ";

        //everything that is for Form1:
        public Form1()
        {
            InitializeComponent();
            InitializePlaceholder();
            this.ActiveControl = label1;
            this.MouseClick += Form1_Mouseclick;
        }
        //lose focus on mouse click on background
        private void Form1_Mouseclick(object sender, MouseEventArgs e)
        {
            if (this.GetChildAtPoint(e.Location) == null)
            {
                this.ActiveControl = label1;

                if (string.IsNullOrWhiteSpace(textboxTask.Text))
                {
                    textboxTask.Text = placeholderText;
                    textboxTask.ForeColor = System.Drawing.Color.Gray;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //initializing placaholder
        private void InitializePlaceholder()
        {
            textboxTask.Text = placeholderText;
            textboxTask.ForeColor = System.Drawing.Color.Gray;
            
            textboxTask.Enter += textBoxPath_Enter;
            textboxTask.Leave += textBoxPath_Leave;
        }
        //placing placeholder
        private void textBoxPath_Enter(object sender, EventArgs e)
        {
            if (textboxTask.Text == placeholderText)
            {   
                textboxTask.Text = "";
                textboxTask.ForeColor = System.Drawing.Color.Black;
            }
        }
        //removing placeholder 
        private void textBoxPath_Leave(object? sender, EventArgs e)
        {
            if (textboxTask.Text == placeholderText)
            {   
                textboxTask.Text = "";
                textboxTask.ForeColor = System.Drawing.Color.Black;
            }
        }



        //crteating tasks
        int checkboxNumber = 1;
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            //creating new task
            string task = textboxTask.Text;
            textboxTask.Text = "";
            this.ActiveControl = label1;
            //losing focus
            if (string.IsNullOrWhiteSpace(textboxTask.Text))
            {
                textboxTask.Text = placeholderText;
                textboxTask.ForeColor = System.Drawing.Color.Gray;
            }




            //creating new checkbox
            List<CheckBox> tasks = new List<CheckBox>();
            CheckBox newCheckBox = new CheckBox();
            newCheckBox.Checked = false;
            newCheckBox.Text = task;
            newCheckBox.ForeColor = checkBox1.ForeColor;
            newCheckBox.Size = checkBox1.Size;
            newCheckBox.Font = checkBox1.Font;
            checkboxNumber++;
            

            tasks.Add(newCheckBox);
            for (int i = tasks.Count - 1; i >= 0; i--)
            {
                if (i == tasks.Count - 1)
                {
                    tasks[i].Location = new Point(checkBox1.Location.X, checkBox1.Location.Y);
                    checkBox1.Location = new Point(checkBox1.Location.X, checkBox1.Location.Y + 50);
                }
                else
                {
                    tasks[i].Location = new Point(tasks[i + 1].Location.X, tasks[i + 1].Location.Y);
                    tasks[i + 1].Location = new Point(tasks[i + 1].Location.X, tasks[i + 2].Location.Y + 50);
                }
                
                this.Controls.Add(newCheckBox);
            }
        }
    }
}
