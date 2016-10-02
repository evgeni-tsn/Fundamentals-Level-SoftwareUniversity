package _2_1lvShop.Products;

import _2_1lvShop.Enum.AgeRestriction;

import java.util.Date;

public class Computer extends ElectronicsProduct{
    public Computer(String name, double price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
        this.guaranteePeriod = new Date(new Date().getYear() + 2, new Date().getMonth(), new Date().getDate());
    }

    @Override
    public double getPrice() {
        double price = this.price();
        if(this.getQuantity() > 1000) {
            price *= 0.95;
        }
        return price;
    }
}
