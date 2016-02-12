package _2_1lvShop.Products;

import _2_1lvShop.Enum.AgeRestriction;

import java.util.Date;

public class Appliance extends ElectronicsProduct {

    public Appliance(String name, double price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
        this.guaranteePeriod = new Date(new Date().getYear() , new Date().getMonth() + 6, new Date().getDate());
    }

    @Override
    public double getPrice() {
        double price = this.price();
        if(this.getQuantity() < 50) {
            price *= 1.05;
        }
        return price;
    }
}