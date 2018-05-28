using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Pattern
{
        // Базовый декоратор
        public abstract class Decorator :
            ICompressor     // Декарируемый класс
        {
            public virtual string Name
            {
                get
                {
                    return compressor?.Name;
                }
            }

            public virtual string Format
            {
                get
                {
                    return compressor?.Format;
                }
            }

            protected ICompressor compressor;

            protected Decorator(ICompressor compressor)
            {
                this.compressor = compressor;
            }

            public virtual void Compress(string inputFile, string outputFile)
            {
                compressor?.Compress(inputFile, outputFile);
            }

            public virtual void Decompress(string inputFile, string outputFile)
            {
                compressor?.Decompress(inputFile, outputFile);
            }
        }
    

    //abstract class Component
    //{
    //    public abstract void Operation();
    //}
    //class ConcreteComponent : Component
    //{
    //    public override void Operation()
    //    { }
    //}
    //abstract class Decorator : Component
    //{
    //    protected Component component;

    //    public void SetComponent(Component component)
    //    {
    //        this.component = component;
    //    }

    //    public override void Operation()
    //    {
    //        if (component != null)
    //            component.Operation();
    //    }
    //}
    //class ConcreteDecoratorA : Decorator
    //{
    //    public override void Operation()
    //    {
    //        base.Operation();
    //    }
    //}
    //class ConcreteDecoratorB : Decorator
    //{
    //    public override void Operation()
    //    {
    //        base.Operation();
    //    }
    //}
}
