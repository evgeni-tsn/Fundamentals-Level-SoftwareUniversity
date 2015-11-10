package _1_Geometry.PlaneShapes;

import _1_Geometry.Vertices.Vertex2D;

public class Rectangle extends PlaneShape {
    private double width;
    private double height;

    public Rectangle(Vertex2D vertex, double width, double height){
        super(vertex);
        this.setHeight(height);
        this.setWidth(width);
        this.area = calculatingArea();
        this.perimeter = calculatingPerimeter();
    }

    @Override
    protected double calculatingArea(){
        return this.width*this.height;
    }

    @Override
    protected double calculatingPerimeter(){
        return 2*(this.width+this.height);
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        if (width<0){
            throw new IllegalArgumentException("The width must be positive number");
        }
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        if (width<0){
            throw new IllegalArgumentException("The height must be positive number");
        }
        this.height = height;
    }
}
