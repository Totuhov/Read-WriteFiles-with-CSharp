namespace TestTextFileWithForm
{
    public partial class Form1 : Form
    {
        List<Occupant> occupants = new List<Occupant>();
        string filePath = @"C:\Users\User\Desktop\CSharpTraining\FormTests\TestTextFileWithForm\TestFile.txt";
        public Form1()
        {
            InitializeComponent();

            Load();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        public new void Load()
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] input = line.Split(",");

                string firstName = input[0];
                string lastName = input[1];
                string url = input[2];

                Occupant occupant = new Occupant(firstName, lastName, url);

                occupants.Add(occupant);
            }
        }
        public new void Show()
        {
            foreach (Occupant occupant in occupants)
            {
                richTextBox1.AppendText($"{occupant.LastName}, {occupant.FirstName} - {occupant.URL}" + Environment.NewLine);
            }
        }
        public void Save()
        {
            string firstName;
            string lastName;
            string site;

            if (textBoxFirstName.Text != String.Empty && textBoxLastName.Text != String.Empty && textBoxUrl.Text != String.Empty)
            {
                firstName = textBoxFirstName.Text;
                lastName = textBoxLastName.Text;
                site = textBoxUrl.Text;

                foreach (Occupant occupant in occupants)
                {
                    if (occupant.FirstName == firstName && occupant.LastName == lastName && occupant.URL == site)
                    {
                        MessageBox.Show("Already Exists!");
                        break;
                    }                    
                }

                occupants.Add(new Occupant(firstName, lastName, site));

                List<string> output = new List<string>();

                foreach (Occupant occupant in occupants)
                {
                    output.Add($"{occupant.FirstName},{occupant.LastName},{occupant.URL}");
                    File.WriteAllLines(filePath, output);
                }
            }
            else
            {
                MessageBox.Show("One or more fields are empty!");
            }
        }
    }
}