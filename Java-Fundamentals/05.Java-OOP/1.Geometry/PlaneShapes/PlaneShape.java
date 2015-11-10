package _1_Geometry.PlaneShapes;

import _1_Geometry.Interfaces.AreaMeasurable;
import _1_Geometry.Interfaces.PerimeterMeasurable;
import _1_Geometry.Shape;
import _1_Geometry.Vertices.Vertex;
import _1_Geometry.Vertices.Vertex2D;

import java.util.Locale;

public abstract class PlaneShape extends Shape implements AreaMeasurable, PerimeterMeasurable {
    protected double area;
    protected double perimeter;

    public PlaneShape(Vertex2D... vertex) {
        super(vertex);
    }

    protected abstract double calculatingArea();
    protected abstract double calculatingPerimeter();

    public double getArea(){
        return area;
    }

    public double getPerimeter(){
        return perimeter;
    }

    @Override
    public String toString(){
        Locale.setDefault(Locale.ENGLISH);

        StringBuilder result = new StringBuilder();
        for(Vertex vertex : this.getVertices()){
            result.append(String.format("Vertex : %d %d, ", vertex.getX(), vertex.getY()));

        }
        return super.toString() + result.toString() + String.format("Area: %.2f, Perimeter: %.2f", this.area, this.perimeter);
    }
}
