namespace TrePåRad
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardView.Show();
            BoardModel boardLogic = new BoardModel();
            boardLogic.ModelLogic();
        }
    }
}
