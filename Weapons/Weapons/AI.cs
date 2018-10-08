namespace Weapons
{
    public class AI : IActionPoint
    {
        public string Name { get; set; }
        public int Health = 200;
        public int ActionPoint = 15;
        public int Postion = 10;

        public int Move()
        {
            Action();
            return Postion--;
        }

        public void Block()
        {
            
        }

        public int Action()
        {
            return ActionPoint--;
        }
    }
}