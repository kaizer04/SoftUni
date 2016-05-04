class Products implements Comparable<Products> {
       
    private String product;
    private double price;
       
    public Products(String product, double price) {
        this.product = product;
        this.price = price;
    }
       
    public String getProduct() {
        return product;
    }
       
    public double getPrice() {
        return price;
    }
       
    public int compareTo(Products compareFruit) {
       
        double otherPrice = ((Products) compareFruit).getPrice();
 
        if (this.price > otherPrice) {
            return 1;
        }
        else if (this.price == otherPrice) {
            return 0;
        }
        else {
            return -1;
        }
    }  
}