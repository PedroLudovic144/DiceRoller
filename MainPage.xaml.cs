namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
      private void RollDiceButton_Clicked(object sender, EventArgs e)
        {
            
            int selectedSides = Convert.ToInt32(picker.SelectedItem);           

            int drawnNumber = new Random().Next(1, selectedSides + 1);
            
            ResultLabel.Text = drawnNumber.ToString();
        } 
        

    }

}
