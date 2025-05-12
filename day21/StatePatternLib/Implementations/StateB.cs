using StatePatternLib.Interfaces;

namespace StatePatternLib.Implementations
{
    public class StateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Состояние B");
            context.SetState(new StateA());
        }
    }
}