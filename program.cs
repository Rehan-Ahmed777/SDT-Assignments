// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        string[,] productList = new string[5, 4]
        {
            {"Notebook  ", "Stationery ", "150", "20 "},
            {"Pencil    ", "Stationery ", " 20", "100"},
            {"Eraser    ", "Stationery ", " 10", "50"},
            {"Water Jug ", "Grocery    ", "200", "15 "},
            {"Chips Pack", "Snacks     ", " 50", "30 "}
        };

        CalculateStockValue(productList);
        ShowProducts(productList);
        Console.ReadKey();
    }

    static void ShowProducts(string[,] productList)
    {
        Console.WriteLine("\nProduct List:");
        Console.WriteLine("Name        \tCategory    \tPrice\tQuantity");

        int rows = productList.GetLength(0);

        foreach (var i in Enumerable.Range(0, rows))
        {
            Console.WriteLine(productList[i, 0] + "\t" + productList[i, 1] + "\t" + productList[i, 2] + "\t" + productList[i, 3]);
        }
    }

    static void CalculateStockValue(string[,] productList)
    {
        Console.WriteLine("\nStock Value:");

        foreach (var i in Enumerable.Range(0, productList.GetLength(0)))
        {
            double price = Convert.ToDouble(productList[i, 2]);
            int qty = Convert.ToInt32(productList[i, 3]);
            double total = price * qty;

            Console.WriteLine(productList[i, 0] + " Total Value: " + total);
        }
    }
}
