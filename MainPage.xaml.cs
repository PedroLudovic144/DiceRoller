namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
      private void Roller_Cliked(object sender, EventArgs e)
        {
            string? line = Console.ReadLine();
            Random rnd = new Random();
            if (!int.TryParse(line, out int picker) || picker <= 0)
            {
                picker = 10;
            }
            for (uint ctr = 1; ctr <= picker; ctr++)
                Console.WriteLine($"{rnd.Next(),15:N0}");
        } 
        

    }

}
