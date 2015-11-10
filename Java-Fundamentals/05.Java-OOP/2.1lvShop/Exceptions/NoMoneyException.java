package _2_1lvShop.Exceptions;

/**
 * Created by Evgeni on 11/10/2015.
 */
public class NoMoneyException extends Exception {
    public NoMoneyException(){
        super("You do not have enough money to buy this product!");
    }
}
