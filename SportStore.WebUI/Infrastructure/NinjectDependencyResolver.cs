using Moq;
using Ninject;
using SportStore.Domain.Abstract;
using SportStore.Domain.Concrete;
using SportStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SportStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            //Mock<IProductRepository> mock = new Mock<IProductRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product>
            //{
            //    new Product{Name = "Football", Price = 25},
            //    new Product{Name = "Surf board", Price = 179},
            //    new Product{Name = "Running shoes", Price = 95},

            //});

            //kernel.Bind<IProductRepository>().ToConstant(mock.Object);


            kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }

    }
    
}