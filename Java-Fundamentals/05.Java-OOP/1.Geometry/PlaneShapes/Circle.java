package _1_Geometry.PlaneShapes;

import _1_Geometry.Vertices.Vertex2D;

public class Circle extends PlaneShape{

    private double radius;

    public Circle(Vertex2D vertex2D, double radius){
        super(vertex2D);
        setRadius(radius);
        this.perimeter = calculatingPerimeter();
        this.area = calculatingArea();
    }

    @Override
    protected double calculatingArea(){
        return Math.PI*this.radius*this.radius;
    }
    @Override
    protected double calculatingPerimeter() {
        return 2 * Math.PI * this.radius;
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

}
