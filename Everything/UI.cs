using Core.Managers;
using Core.Entitys;
using System.Runtime.InteropServices;


namespace Everything
{
    public partial class UI : Form
    {
        public int ButtonCount = 0;
        StudentManager manager = new StudentManager();


        public UI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = manager.GetAll();
        }

        private void StudentAddButton_Click(object sender, EventArgs e)
        {

            //Start
            string name = StudentNameBox.Text;
            string password = StudentPasswordBox.Text;
            //Count
            ButtonCount++;
            //Object 
            Student student = new Student();
            student.Name = name;
            student.Password = password;
            student.Id = ButtonCount;
            manager.Add(student);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
