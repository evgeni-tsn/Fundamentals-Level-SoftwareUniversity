package _2_1lvShop.Products;
import _2_1lvShop.Enum.AgeRestriction;

import java.util.Date;

public abstract class ElectronicsProduct extends Product {
    protected Date guaranteePeriod;

    public ElectronicsProduct(String name, double price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
    }
}