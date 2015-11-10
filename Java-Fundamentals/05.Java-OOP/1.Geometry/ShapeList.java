package _1_Geometry;

import _1_Geometry.PlaneShapes.Circle;
import _1_Geometry.PlaneShapes.PlaneShape;
import _1_Geometry.PlaneShapes.Rectangle;
import _1_Geometry.PlaneShapes.Triangle;
import _1_Geometry.SpaceShapes.Cuboid;
import _1_Geometry.SpaceShapes.SpaceShape;
import _1_Geometry.SpaceShapes.Sphere;
import _1_Geometry.SpaceShapes.SquarePyramid;
import _1_Geometry.Vertices.Vertex2D;
import _1_Geometry.Vertices.Vertex3D;

import java.util.ArrayList;
import java.util.List;

public class ShapeList {
    public static void main(String[] args) {
        List<Shape> shapes = new ArrayList<>();
        shapes.add(new Triangle(new Vertex2D(14, 10), new Vertex2D(30, 22), new Vertex2D(19, 15)));
        shapes.add(new Cuboid(new Vertex3D(51, 25, 32), 9.0, 10.0, 11.0));
        shapes.add(new Sphere(new Vertex3D(21, 9, -5), 18.0));
        shapes.add(new SquarePyramid(new Vertex3D(15, -8, 15), 21, 17.5));
        shapes.add(new Circle(new Vertex2D(20, 20), 12.8));
        shapes.add(new Rectangle(new Vertex2D(20, 20), 11, 21));

        for (Shape shape : shapes) {
            if(shape instanceof Triangle){
                Triangle triangle = ((Triangle) shape);
                System.out.println(triangle);
            } else if (shape instanceof PlaneShape){
                PlaneShape planeShape = ((PlaneShape) shape);
                System.out.println(planeShape);
            } else if (shape instanceof SpaceShape){
                SpaceShape spaceShape = ((SpaceShape) shape);
                System.out.println(spaceShape);
            }


        }
    }
}
