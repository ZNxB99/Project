class Calculateprice{
    public string foodname;
    public double foodprice;
    public int quantity;
    public double subtotal;
    public Calculateprice(string foodname, double foodprice, int quantity, double subtotal){
        this.foodname = foodname;
        this.foodprice = foodprice;
        this.quantity = quantity;
        this.subtotal = subtotal;
    }
    public string GetFoodname(){
        return this.foodname;
    }
    public double GetFoodprice(){
        return this.foodprice;
    }
    public int GetQuantity(){
        return this.quantity;
    }
    public double GetSubtotal(){
        return this.subtotal;
    }
    private static void Main(string[] args){
        int calculate;
        Console.Write("foodprice 1: ");
        calculate = int.Parse(Console.ReadLine());
        Console.Write("foodprice 2: ");
        calculate += int.Parse(Console.ReadLine());
        Console.Write("foodprice 3: ");
        calculate += int.Parse(Console.ReadLine());
        Console.Write("foodsalepromotion: ");
        calculate -= int.Parse(Console.ReadLine());
        Console.WriteLine("calculate: {0}", calculate);
    }
}