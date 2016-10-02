package _2_1lvShop.Exceptions;

public class ProductExpiredException extends Exception{
    public ProductExpiredException(){
        super("The product has expired");
    }
}
