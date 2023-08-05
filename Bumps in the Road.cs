class Kata
{
    public static string Bump(string input)
    {
        int bumps = 0;

        foreach (char c in input)
        {
            if (c == 'n')
            {
                bumps++;
                if (bumps > 15) // You can adjust this threshold as needed
                    return "Car Dead";
            }
        }

        return bumps <= 15 ? "Woohoo!" : "Car Dead";
    }
}