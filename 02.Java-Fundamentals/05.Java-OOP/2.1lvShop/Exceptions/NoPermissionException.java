package _2_1lvShop.Exceptions;

public class NoPermissionException extends Exception{
    public NoPermissionException(){
        super("You are too young to buy this product!");
    }
}