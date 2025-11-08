using ServiceLayer;
namespace PresentationLayer
{
    public partial class MainMenu : Form
    {
        public LocalPlayer Player { get; set; }
        public MainMenu(LocalPlayer player)
        {
            Player = player;
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void options_button_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void play_button_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click_1(object sender, EventArgs e)
        {

        }

        private void Title_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Title.DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void play_button_Click_1(object sender, EventArgs e)
        {
            
            DifficultySetting dif1 = new DifficultySetting(Player);
            dif1.Show();
            this.Hide();
        }

        private void exit_button_Click_1(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void profiles_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profiles profiles = new Profiles(Player);
            profiles.Show();

        }

        private void options_button_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Leaderbord_Form l= new Leaderbord_Form(Player);
            l.Show();
        }
    }
}