
namespace DecoratorPattern
{
    interface IComponent
    {
        void Operation();
    }
    public abstract class Decorator : IComponent
    {
        protected IComponent _component;

        protected Decorator(IComponent component)
        {
            _component = component;
        }

        public override Operation()
        {
            _component.Operation();
            //...
        }
    }

    public sealed class ConcreteComponent : IComponent
    {
        public override void Operation()
        {
            //...
        }
    }

    public sealed class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(IComponent component) : base(component)
        {
            //...
        }

        public override void Operation()
        {
            base.Operation();
            //...
        }
    }
    
}
