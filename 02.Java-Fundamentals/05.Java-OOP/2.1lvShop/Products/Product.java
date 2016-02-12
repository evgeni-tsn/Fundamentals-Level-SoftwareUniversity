package _2_1lvShop.Products;

import _2_1lvShop.Enum.AgeRestriction;
import _2_1lvShop.Interfaces.Buyable;

public abstract class Product implements Buyable{
    private String name;
    private double price;
    private int quantity;
    private AgeRestriction ageRestriction;

    public Product(String name, double price,int quantity, AgeRestriction ageRestriction){
        setName(name);
        setAgeRestriction(ageRestriction);
        setPrice(price);
        setQuantity(quantity);
    }

    public void saledProduct(){
        this.quantity--;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        if(name.equals(" ")){
            throw new IllegalArgumentException("The name of the product cannot be empty string");
        }
        this.name = name;
    }
    public double price(){
        return this.price;
    }
    @Override
    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        if(price < 0){
            throw new IllegalArgumentException("The price of the product cannot be a negative number");
        }
        this.price = price;
    }

    public int getQuantity() {
        return this.quantity;
    }

    public void setQuantity(int quantity) {
        if(quantity < 0){
            throw new IllegalArgumentException("The quantity of the product cannot be a negative number");
        }
        this.quantity = quantity;
    }

    public AgeRestriction getAgeRestriction() {
        return ageRestriction;
    }

    public void setAgeRestriction(AgeRestriction ageRestriction) {
        this.ageRestriction = ageRestriction;
    }
}
