// <copyright file="MainPageViewModelTest.cs">Copyright ©  2015</copyright>

using System;
using BadPractise.Wpf;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BadPractise.Wpf.Tests
{
    [TestClass]
    [PexClass(typeof(MainPageViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MainPageViewModelTest
    {

        [PexMethod(MaxBranches = 20000)]
        public MainPageViewModel Constructor()
        {
            MainPageViewModel target = new MainPageViewModel();
            return target;
            // TODO: add assertions to method MainPageViewModelTest.Constructor()
        }
    }
}
