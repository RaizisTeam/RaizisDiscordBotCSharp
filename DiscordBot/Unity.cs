﻿using DiscordBot.Storage;
using DiscordBot.Storage.Implementations;
using Unity;
using Unity.Lifetime;
using Unity.Resolution;

namespace DiscordBot
{
    public static class Unity
    {
        private static UnityContainer _container;

        public static UnityContainer Container
        {
            get
            {
                if (_container == null)
                    RegisterTypes();
                return _container;
            }
        }

        public static void RegisterTypes()
        {
            _container = new UnityContainer();
            _container.RegisterType<IDataStorage, InMemoryStorage>(new ContainerControlledLifetimeManager());
        }

        public static T Resolve<T>()
        {
            return (T)Container.Resolve(typeof(T));
        }
    }
}
