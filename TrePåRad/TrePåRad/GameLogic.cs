namespace TrePåRad
{
    class GameLogic
    {
        public static string Winner;

        public bool CheckVictoryCondition(BoardModel bm)
        {

            return    CheckContent(bm, 0, 1, 2)
                   || CheckContent(bm, 3, 4, 6)
                   || CheckContent(bm, 6, 7, 8)
                   || CheckContent(bm, 0, 3, 5)
                   || CheckContent(bm, 1, 4, 7)
                   || CheckContent(bm, 2, 5, 8)
                   || CheckContent(bm, 0, 4, 8)
                   || CheckContent(bm, 2, 4, 6);
        }

        private bool CheckContent(BoardModel bm, int contentIndex0, int contentIndex1, int contentIndex2)
        {
            var cell0 = bm.Content[contentIndex0];
            var cell1 = bm.Content[contentIndex1];
            var cell2 = bm.Content[contentIndex2];

            if (cell0 == ' ' || cell1 != cell0 || cell2 != cell0) return false;

            Winner = cell0 == 'x' ? "You" : "Computer";
            return true;
        }
    }
}
