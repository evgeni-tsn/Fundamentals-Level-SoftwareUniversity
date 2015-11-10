package _2_1lvShop.Exceptions;

public class NoQuantityException extends Exception {
    public NoQuantityException(){
        super("There is no quantity of this stock");
    }
}
