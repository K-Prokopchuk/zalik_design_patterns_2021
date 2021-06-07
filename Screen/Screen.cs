namespace Patterns.Screen
{
    using Patterns.Vectors;
    public class Screen
    {
        private Screen   _instance;
        public  Vector2D currentPosition;
        public float _screenWidth, _screenHeight;

        private Screen() {
        }

        public Screen GetInstance() {
            if (_instance == null) {
                _instance = new Screen();
            }

            return _instance;
        }

        public void SetPosition(Vector2D desiredPosition) {
            currentPosition = desiredPosition;
        }
        
    }
}