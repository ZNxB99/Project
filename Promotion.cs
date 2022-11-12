class Promotion{
    public string promotion;
    public double sale;
    public Promotion(string promotion, double sale){
        this.promotion = promotion;
        this.sale = sale;
    }
    public string GetProMotion(){
        return this.promotion;
    }
    public double GetSale(){
        return this.sale;
    }
}