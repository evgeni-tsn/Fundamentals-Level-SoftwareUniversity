package _1_Geometry;

import _1_Geometry.Vertices.Vertex;

import java.util.ArrayList;
import java.util.List;

public abstract class Shape {
    private List<Vertex> vertices;

    public Shape(Vertex... vertex) {
        vertices = new ArrayList<>();
        this.addVertex(vertex);
    }

    public List<Vertex> getVertices() {
        return vertices;
    }

    private void addVertex(Vertex[] vertices) {
        for (Vertex vertex : vertices){
            this.vertices.add(vertex);
        }
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append(this.getClass().getSimpleName()+ ", ") ;


        return result.toString();
    }
}
