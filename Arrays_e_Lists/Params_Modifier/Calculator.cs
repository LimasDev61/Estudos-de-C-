namespace Params_Modifier;

public class Calculator
{
    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum;
    }
}