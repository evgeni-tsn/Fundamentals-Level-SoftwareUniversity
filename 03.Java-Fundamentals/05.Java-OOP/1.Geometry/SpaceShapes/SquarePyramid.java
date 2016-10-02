package _1_Geometry.SpaceShapes;

import _1_Geometry.Vertices.Vertex3D;

public class SquarePyramid extends SpaceShape{
    private double width;
    private double height;

    public SquarePyramid(Vertex3D vertex3D, double width, double height) {
        super(vertex3D);
        setWidth(width);
        setHeight(height);
        this.area = calculateArea();
        this.volume= calculateVolume();
    }

    @Override
    protected double calculateVolume() {
        return this.width * this.width * (this.height / 3);
    }

    @Override
    protected double calculateArea() {
        return this.width * this.width + 2 * this.width * Math.sqrt((this.width*this.width / 4) + this.height * this.height);
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        if(width < 0){
            throw  new IllegalArgumentException("The width of the pyramid cannot be a negative number.");
        }
        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        if(height < 0){
            throw  new IllegalArgumentException("The height of the pyramid cannot be a negative number.");
        }
        this.height = height;
    }
}
