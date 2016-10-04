using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double treshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());
        //
        for (int i = 0; i < n - 1; i++)
        {
            double newPrice = double.Parse(Console.ReadLine());
            double priceChange = PriceChange_Get(lastPrice, newPrice);
            bool treshold_IsSignificant = TresholdSignificance_Get(priceChange, treshold);
            string priceChangeInfo = PriceChangeInfo_Get(newPrice, lastPrice, priceChange, treshold_IsSignificant);
            Console.WriteLine(priceChangeInfo);
            lastPrice = newPrice;
        }
    }
        
    private static string PriceChangeInfo_Get(double newPrice, double lastPrice, double priceChange, bool treshold_IsSignificant)
    {
        string output = "";
        if (priceChange == 0)
        {
            output = string.Format("NO CHANGE: {0}", newPrice);
        }
        else if (!treshold_IsSignificant)
        {
            output = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, newPrice, priceChange*100);
        }
        else if (treshold_IsSignificant && (priceChange > 0))
        {
            output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, newPrice, priceChange*100);
        }
        else if (treshold_IsSignificant && (priceChange < 0))
        {
            output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, newPrice, priceChange*100);
        }
        return output;
    }

    private static bool TresholdSignificance_Get(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double PriceChange_Get(double oldPrice, double newPrice)
    {
        double priceChange_Percent = (newPrice - oldPrice) / oldPrice;
        return priceChange_Percent;
    }
}
