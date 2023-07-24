namespace DesignPatterns.Structural;

public static class Proxy
{
    public interface IRobot
    {
        void Move(int x, int y);
    }

    public class Robot : IRobot
    {
        public void Move(int x, int y) => Console.WriteLine($"{nameof(Robot)}.{nameof(Move)}({x}, {y})");
    }

    public class RobotProxy : IRobot
    {
        readonly IRobot _target;

        public RobotProxy(IRobot target)
        {
            _target = target;
        }

        public void Move(int x, int y)
        {
            //Can do extra things here...
            Console.WriteLine("Before calling Robot.Move()");

            _target.Move(x, y);

            //...or here
            Console.WriteLine("After calling Robot.Move()");
        }
    }

    public static void Execute()
    {
        Console.WriteLine($"[{nameof(Proxy)} Pattern]");
        Console.WriteLine();

        var robot = new Robot();
        var robotProxy = new RobotProxy(robot);
        robotProxy.Move(1, 2);
    }
}

