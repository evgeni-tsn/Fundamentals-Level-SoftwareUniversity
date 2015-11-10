package _1_Geometry.SpaceShapes;

import _1_Geometry.Vertices.Vertex3D;

public class Sphere extends SpaceShape {
    private double radius;

    public Sphere(Vertex3D vertex, double radius){
        super(vertex);
        this.setRadius(radius);
        this.area = calculateArea();// make a method to calculate area
        this.volume = calculateVolume();// make a method for perimeter
    }

    @Override
    protected double calculateArea(){
        return 4*Math.PI*this.radius*this.radius;
    }
    @Override
    protected double calculateVolume() {
        return 4 / 3 * Math.PI * this.radius * this.radius * this.radius;
    }
    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        if(radius < 0) {
            throw new IllegalArgumentException("Radius cannot be a negative number.");
        }
        this.radius = radius;
    }
}
