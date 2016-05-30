using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using XomPoll.Core.Repository;
using XomPoll.Core.Data;

namespace XomPoll
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<IDataContext, Linq2SqlDataContext>();
            container.RegisterType<IDataContextFactory, Linq2SqlDataContextFactory>();
            container.RegisterType<IEventRepository, EventRepository>();
            container.RegisterType<IQuestionRepository, QuestionRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}