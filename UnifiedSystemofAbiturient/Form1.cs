using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnifiedSystemofAbiturient
{
    public partial class Form1 : Form
    {
        private SystemController SystemController = new SystemController();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int number))
                SystemController.newUniversity(textBox1.Text, number);
            reloadUniversities();
        }
        private void reloadUniversities()
        {
            richTextBox1.Text = "";
            comboBox3.Items.Clear();
            foreach (University u in SystemController.getUniversities())
            {
                richTextBox1.Text += "\n\nУниверситет " + u.Title +
                    ". Количество мест: " + u.Places
                    + ". Количество мест на данный момент: " + u.getFreePlaces();
                comboBox3.Items.Add(u.Title);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<Subjects, int> points = new Dictionary<Subjects, int>();
            points.Add(Subjects.Русский, int.Parse(textBox4.Text));
            points.Add(Subjects.Математика, int.Parse(textBox5.Text));
            points.Add(getSubject(), int.Parse(textBox6.Text));
        
            switch (comboBox2.Text)
            {
                case "Абитуриент":
                    SystemController.newAbiturient(null, textBox3.Text, points);
                    break;
                case "Студент":
                    SystemController.newStudent(null, textBox3.Text, points);
                    break;
                case "Выпускник":
                    SystemController.newGraduate(null, textBox3.Text, points);
                    break;
                default: 
                    SystemController.newActiveUser(textBox3.Text, points);
                    break;
            }
            Subjects getSubject()
            {
                switch (comboBox1.Text)
                {
                    case "Информатика":
                        return Subjects.Информатика;
                    case "Физика":
                        return Subjects.Физика;
                    case "Обществознание":
                        return Subjects.Обществознание;
                    case "История":
                        return Subjects.История;
                    default: return Subjects.Информатика;
                }
            }

            reloadUsers();
        }
        private void reloadUsers()
        {
            richTextBox2.Text = "";
            comboBox4.Items.Clear();
            foreach (User u in SystemController.getUsers())
            {
                richTextBox2.Text += getUserType(u)+" " + u.Name +
                    ".\nБаллы ЕГЭ: \nРусский: " + u.Points.ElementAt(0).Value
                    + ".\nМатематика: " + u.Points.ElementAt(1).Value
                    + ".\n"+ u.Points.ElementAt(2).Key+": " + u.Points.ElementAt(2).Value +".\n\n";
                comboBox4.Items.Add(u.Name);
            }
            string getUserType(User user)
            {
                switch (user.GetType().ToString())
                {
                    case "UnifiedSystemofAbiturient.Abiturient":
                        return "Абитуриент";
                    case "UnifiedSystemofAbiturient.Student":
                        return "Студент";
                    case "UnifiedSystemofAbiturient.Graduate":
                        return "Выпускник";
                    default:
                        return "Пользователь";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SystemController.createApplication(SystemController.getUniversities().Where(university => university.Title == comboBox3.Text).First(),
                SystemController.getUsers().Where(user => user.Name == comboBox4.Text).First(),
                SystemController.getUsers().Where(user => user.Name == comboBox4.Text).First().Points.Keys.ToArray());
            reloadApps();
            reloadUniversities();
        }
        private void reloadApps()
        {
            richTextBox3.Text = "";
            foreach (University u in SystemController.getUniversities())
            {
                foreach (ApplicatioN app in u.GetApplications())
                {
                    richTextBox3.Text += app.ToString() +"\n\n";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int key;
            switch (comboBox5.Text)
            {
                case "По среднему баллу":
                    key = 1;
                    break;
                case "По количеству заявлений":
                    key = 2;
                    break;
                default: key = -1;
                    break;
            }
            

            richTextBox4.Text = "";
            foreach (University u in SystemController.getSelection(key, checkBox1.Checked))
            {
                richTextBox4.Text += "\n\nУниверситет " + u.Title +
                    ". Количество мест: " + u.Places
                    + ". Количество мест на данный момент: " + u.getFreePlaces();
            }
        }
    }
}
