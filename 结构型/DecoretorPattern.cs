
namespace DecoratorPattern
{
    /// <summary>
    /// IComponent是抽象接口类型,需要修饰的接口
    /// </summary>
    interface IComponent
    {
        void Operation();
    }
    
    /// <summary>
    /// 装饰接口的定义, 如需具体类型, 利用子类化该类型
    /// </summary>
    public abstract class Decorator : IComponent //关键点之二，体现关系为Is-a，有了这个关系，装饰的类也可以继续装饰了
    {
        //通过组合方式引用Decorator类型，该类型实施具体功能的增加
        //这是关键点之一，包含关系，体现为Has-a
        protected IComponent _component;

        //通过构造器注入，初始化平台实现
        protected Decorator(IComponent component)
        {
            _component = component;
        }

        //该方法就相当于Decorator类型的Operation方法
        public override Operation()
        {
            if (_house != null)
            {
                _component.Operation();
            }
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
