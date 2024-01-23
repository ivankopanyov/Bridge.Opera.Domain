﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Bridge.Opera.Domain
{
    public abstract class OperaDbContextBase : DbContext
    {
        private static ISet<Type> _types;

        private static IEnumerable<MethodInfo> _methods;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("OPERA");

            if (_types == null)
                _types = GetType().GetProperties()
                    .Where(property => property.PropertyType.Name == "DbSet`1" &&
                        property.PropertyType.GenericTypeArguments.Any())
                    .Select(property => property.PropertyType.GenericTypeArguments.First())
                    .ToHashSet();

            if (_methods == null)
                _methods = _types
                    .SelectMany(type => type.GetMethods()
                        .Where(method => method.Name == nameof(OnModelCreating) &&
                            method.IsStatic &&
                            method.GetParameters().Length == 2 &&
                            method.GetParameters().Any(parameter => parameter.ParameterType == typeof(ModelBuilder)) &&
                            method.GetParameters().Any(parameter => parameter.ParameterType == typeof(ISet<Type>))));

            foreach (var method in _methods)
                method.Invoke(null, new object[] { modelBuilder, _types });
        }
    }
}