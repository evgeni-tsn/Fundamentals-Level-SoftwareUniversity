package _1_Geometry.SpaceShapes;

import _1_Geometry.Interfaces.AreaMeasurable;
import _1_Geometry.Interfaces.VolumeMeasurable;
import _1_Geometry.Shape;
import _1_Geometry.Vertices.Vertex;
import _1_Geometry.Vertices.Vertex3D;

import java.util.Locale;

public abstract class SpaceShape extends Shape implements AreaMeasurable, VolumeMeasurable {

    protected double area;
    protected double volume;

    public SpaceShape(Vertex3D vertex3D){
        super(vertex3D);
    }
    protected abstract double calculateVolume();
    protected abstract double calculateArea();

    @Override
    public double getArea() {
        return area;
    }

    @Override
    public double getVolume() {
        return volume;
    }

    @Override
    public String toString() {
        Locale.setDefault(Locale.ENGLISH);

        StringBuilder result = new StringBuilder();
        for(Vertex inheritedVertex : this.getVertices()){
            Vertex3D vertex = ((Vertex3D) inheritedVertex);
            result.append(String.format("Vertex : %d %d %d, ", vertex.getX(), vertex.getY(), vertex.getZ() ));

        }
        return super.toString() + result.toString() + String.format("Area: %.2f, Volume: %.2f", this.area, this.volume);

    }
}
