using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Diagnostics;
using AcceptanceTest.Resources.Interface;
using FluentAssertions;

namespace AcceptanceTest.Tests.UnitTests.SanityTests
{
    public class SanityUnitTest
    {
        [Trait("Category", " SanityTests")]
        [Fact]
        public void sanityBasicCheckIfStorageIsCreatedAndEmpty()
        {
            FakeUserRepository fur = new FakeUserRepository();

            int usersNumber = fur.GetAllUsers().Count;
         
            usersNumber.Should().BeLessThan(1, "because we didn't put any items in the list");
        }

        [Trait("Category", " SanityTests")]
        [Fact]
        public void sanityCheckIfUserIsAdding()
        {
            FakeUserRepository fur = new FakeUserRepository();

            fur.Insert(1);
            int usersNumber = fur.GetAllUsers().Count;

            usersNumber.Should().BeInRange(0,1, "because we didn't put any items in the list");
        }


        #region TestPriority
        [Fact, TestPriority(2)]
        public void Test1()
        {
            //Test3Called = true;

            //Assert.True(Test1Called);
            //Assert.True(Test2ACalled);
            //Assert.True(Test2BCalled);
            Console.WriteLine("second test1");
            Debug.WriteLine("second test1");
        }

        [Trait("Category", "SanityTests")]
        [Fact]
        public void Test3()
        {
            //Test3Called = true;

            //Assert.True(Test1Called);
            //Assert.True(Test2ACalled);
            //Assert.True(Test2BCalled);
            Console.WriteLine("third test3");
            Debug.WriteLine("third test3");
        }

        [Fact, TestPriority(1)]
        public void Test2()
        {
            //Test3Called = true;

            //Assert.True(Test1Called);
            //Assert.True(Test2ACalled);
            //Assert.True(Test2BCalled);
            Console.WriteLine("first test2");
            Debug.WriteLine("first test2");
        }
        #endregion
    }
}
