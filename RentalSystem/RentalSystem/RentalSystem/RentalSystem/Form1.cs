namespace RentalSystem
{
    public partial class Login : Form
    {
        public User CurrentUser = new User();
        public DataController Controller = new DataController();
        public bool BoxSwitch = false;
        public bool Next = false;
        public Login()
        {
            InitializeComponent();
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            PasswordRegBox.Show();
            CurrentUser.NewUser = true;
            
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(CurrentUser.NewUser)
            {
                if (UsernameBox.Text != "" && Controller.FindUserID(UsernameBox.Text,"Username") == 0)
                {
                    if(PasswordBox.Text == PasswordRegBox.Text || BoxSwitch)
                    {
                        if (!BoxSwitch)
                        {
                            CurrentUser.Password = PasswordBox.Text;
                            CurrentUser.Username = UsernameBox.Text;
                            CurrentUser.ID = GenerateID();
                            UsernameBox.Clear();
                            UsernameBox.PlaceholderText = "First Name";
                            PasswordBox.Clear();
                            PasswordBox.PlaceholderText = "Last Name";
                            PasswordBox.PasswordChar = '\0';
                            PasswordRegBox.Clear();
                            PasswordRegBox.PasswordChar = '\0';
                            PasswordRegBox.PlaceholderText = "Insurance Provider";
                            BoxSwitch = true;
                        }
                        else
                        {
                            CurrentUser.FirstName = UsernameBox.Text;
                            CurrentUser.LastName = PasswordBox.Text;
                            CurrentUser.InsuranceProvider = PasswordRegBox.Text;
                            Controller.CreateUser(CurrentUser.Username, CurrentUser.Password, CurrentUser.FirstName, CurrentUser.LastName, CurrentUser.InsuranceProvider, CurrentUser.ID);
                            Next = true;
                            this.Close();
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a new username!");
                }
            }
            else
            {
                if(UsernameBox.Text != null && PasswordBox != null)
                {
                    CurrentUser.Username = UsernameBox.Text;
                    CurrentUser.Password = PasswordBox.Text;
                    CurrentUser.ID = Controller.FindUserID(CurrentUser.Username, CurrentUser.Password);
                    if (CurrentUser.ID == 0)
                    {
                        MessageBox.Show("Invalid Credentials");
                    }
                    else
                    {
                        CurrentUser.FirstName = Controller.FindFirstname(CurrentUser.ID);
                        CurrentUser.LastName = Controller.FindLastname(CurrentUser.ID);
                        CurrentUser.InsuranceProvider = Controller.FindInsuraceInfo(CurrentUser.ID);
                        Next = true;
                        this.Close();
                    }
                }
            }
        }

        public int GenerateID()
        {
            Random RandomNum = new Random();
            string Collection = "";
            for(int i = 0; i < 6; i++)
            {
                int Num = RandomNum.Next(0, 9);
                Collection = Collection + Num.ToString();
            }
            return int.Parse(Collection);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}