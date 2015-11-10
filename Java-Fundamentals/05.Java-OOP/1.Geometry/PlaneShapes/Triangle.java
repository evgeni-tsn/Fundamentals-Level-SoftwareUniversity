package _1_Geometry.PlaneShapes;

import _1_Geometry.Vertices.Vertex;
import _1_Geometry.Vertices.Vertex2D;

import java.util.Locale;

public class Triangle extends PlaneShape{
    private Vertex2D a;
    private Vertex2D b;
    private Vertex2D c;

    public Triangle(Vertex2D a, Vertex2D b, Vertex2D c ) {
        super(a, b, c);
        this.a = a;
        this.b = b;
        this.c = c;
        this.area = calculatingArea();
        this.perimeter = calculatingPerimeter();
    }


    @Override
    protected double calculatingArea() {
        return Math.abs(((this.a.getX() * (this.b.getY() - this.c.getY()))
                + (this.b.getX() * (this.c.getY() - this.a.getY()))
                + (this.c.getX() * (this.a.getY() - this.b.getY()))) / 2);
    }

    @Override
    protected double calculatingPerimeter() {
        double sideAB = Math.sqrt(((this.b.getX() - this.a.getX()) * (this.b.getX() - this.a.getX())) + ((this.b.getY() - this.a.getY()) * (this.b.getY() - this.a.getY())));
        double sideBC = Math.sqrt(((this.c.getX() - this.b.getX()) * (this.c.getX() - this.b.getX())) + ((this.c.getY() - this.b.getY()) * (this.c.getY() - this.b.getY())));
        double sideAC = Math.sqrt(((this.c.getX() - this.a.getX()) * (this.c.getX() - this.a.getX())) + ((this.c.getY() - this.a.getY()) * (this.c.getY() - this.a.getY())));
        return sideAB + sideBC + sideAC;
    }

    @Override
    public String toString() {
        Locale.setDefault(Locale.ENGLISH);
        int numberOfVertex = 1;
        StringBuilder result = new StringBuilder();
        for(Vertex vertex : this.getVertices()){
            result.append(String.format("Vertex %d: %d %d, ", numberOfVertex, vertex.getX(), vertex.getY()));
            numberOfVertex++;
        }
        return this.getClass().getSimpleName() + ", " + result.toString() + String.format("Area: %.2f, Perimeter: %.2f", this.area, this.perimeter);
    }
}
