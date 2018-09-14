

using System;

namespace TrePåRad
{
    class BoardModel
    {

        public char[] Content =
        {

            ' ', ' ', ' ',
            ' ', ' ', ' ',
            ' ', ' ', ' '
        };
        // {'x', '0', ' ', ' ', }
        public void ModelLogic()
        {
            CheckStuff();
        }

        private void CheckStuff()
        {
            if (Content[0] == ' ' || Content[1] == ' ' || Content[2] == ' ') { }
            if (Content[3] == ' ' || Content[4] == ' ' || Content[5] == ' ') { }
            if (Content[6] == ' ' || Content[7] == ' ' || Content[8] == ' ') { }

            if (Content[0] == ' ' || Content[3] == ' ' || Content[6] == ' ') { }
            if (Content[1] == ' ' || Content[4] == ' ' || Content[7] == ' ') { }
            if (Content[2] == ' ' || Content[5] == ' ' || Content[8] == ' ') { }

            if (Content[0] == ' ' || Content[4] == ' ' || Content[8] == ' ') { }
            if (Content[2] == ' ' || Content[4] == ' ' || Content[6] == ' ') { }
        }

    }
}
