//Прототип
namespace Patterns.Vectors
{
    public class Vector2D
    {
        public float pos_x;
        public float pos_y;

        public Vector2D(float x, float y) {
            pos_x = x;
            pos_y = y;
        }

        public Vector2D() { }

        public Vector2D ShallowCopy() {
            return (Vector2D)this.MemberwiseClone();
        }

        public Vector2D DeepCopy() {
            return new(pos_x, pos_y);
        }
    }
}