namespace _02_Bottles
{
    internal class Song
    {
        public string CountBottles(int v)
        {
            
            
            string result = "";
            switch (v)
            {
                case 0:
                    result = " No more bottles of beer on the wall.";
                    break;
                case 1:
                    result = "1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around."
                + " No more bottles of beer on the wall.";
                    break;
                case 2:
                    result = "2 bottles of beer on the wall."
                + " 2 bottles of beer."
                + " Take one down and pass it around."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around."
                + " No more bottles of beer on the wall.";
                    break;
                case 3:
                    result = "3 bottles of beer on the wall."
                + " 3 bottles of beer."
                + " Take one down and pass it around."
                + " 2 bottles of beer on the wall."
                + " 2 bottles of beer on the wall."
                + " 2 bottles of beer."
                + " Take one down and pass it around."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around."
                + " No more bottles of beer on the wall.";
                    break;
            }
            return result;

        }
    }
}