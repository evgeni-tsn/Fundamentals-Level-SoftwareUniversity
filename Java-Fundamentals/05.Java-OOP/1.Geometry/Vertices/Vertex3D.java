package _1_Geometry.Vertices;

public class Vertex3D extends Vertex {
    private int z;

    public Vertex3D(int x, int y, int z) {
        super(x, y);
        this.setZ(z);
    }

    public int getZ() {
        return z;
    }

    public void setZ(int z) {
        this.z = z;
    }
}
