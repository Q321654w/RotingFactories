﻿namespace MyFramework.Factories
{
    public interface IFactory<T>
    {
        T Create();
    }
}