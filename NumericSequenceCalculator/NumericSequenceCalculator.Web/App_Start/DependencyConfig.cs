using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using NumericSequenceCalculator.BLL;
using NumericSequenceCalculator.Common;
using NumericSequenceCalculator.SequenceEngine;
using NumericSequenceCalculator.Web.App_Start;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(DependencyConfig), "ConfigureContainer")]
namespace NumericSequenceCalculator.Web.App_Start
{
    public class DependencyConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.Register(c => new AllNumbersSequence()).As<IAllNumbersSequence>();
            builder.Register(c => new AllNumbersMultipleSequence()).As<IAllNumbersMultipleSequence>();
            builder.Register(c => new OddNumberSequence()).As<IOddNumberSequence>();
            builder.Register(c => new EvenNumberSequence()).As<IEvenNumberSequence>();
            builder.Register(c => new FibonacciSequence()).As<IFibonacciSequence>();

            builder.Register(c => new SequenceCalculatorManager(c.Resolve<IAllNumbersSequence>(),
                                                                c.Resolve<IAllNumbersMultipleSequence>(),
                                                                c.Resolve<IOddNumberSequence>(),
                                                                c.Resolve<IEvenNumberSequence>(),
                                                                c.Resolve<IFibonacciSequence>())).As<ISequenceCalculatorManager>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));  
        }
    }
}