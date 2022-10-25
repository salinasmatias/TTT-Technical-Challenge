namespace Technical_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "we the people of the united states in order to form a more perfect union etc";
            var textWithoutSpaces = text.Replace(" ", "");
            var columns = Convert.ToInt32(Math.Ceiling(Math.Sqrt(textWithoutSpaces.Length)));
            string[] array = new string[columns];
            int index = 0;
            while (textWithoutSpaces.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if(index >= 0 && index < textWithoutSpaces.Length)
                    {
                        array[i] = array[i] + textWithoutSpaces[index];
                        index++;
                    }
                }
                textWithoutSpaces = textWithoutSpaces.Remove(0, index);
                index = 0;
            }

            var output = string.Join(" ", array);
            Console.WriteLine(output);
        }
    }
}