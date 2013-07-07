using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ServiceStack.Messaging.IronMQ.IronClient;

namespace ServiceStack.Messaging.IronMQ.Tests.IronClient
{
    [TestFixture]
    class IronClientApiTests
    {
        private readonly string _fakeToken = "sometoken";
        private readonly string _fakeProjectId = "someId";
        private readonly string _fakeBaseUrl = "that-base-url";

        [Test]
        public void TestCtorWithArguments()
        {
            var client = new IronClientApi(_fakeToken, _fakeProjectId, _fakeBaseUrl);
            Assert.IsInstanceOf<IronClientApi>(client);  
            Assert.AreEqual(_fakeToken, client.AuthToken, "Auth token mismatch");
            Assert.AreEqual(_fakeProjectId, client.ProjectId, "ProjectId mismatch");
            Assert.AreEqual(_fakeBaseUrl, client.BaseUrl, "BaseUrl mismatch");
        }

        [Test]
        public void TestCtorWithNullAuthTokenArgument()
        {
            Assert.Throws<ArgumentNullException>(() => new IronClientApi(null, _fakeProjectId, _fakeBaseUrl),
                "AuthToken is null");
        }

        [Test]
        public void TestCtorWithNullProjectIdArgument()
        {
            Assert.Throws<ArgumentNullException>(() => new IronClientApi(_fakeToken, null, _fakeBaseUrl),
                "ProjectId is null");
        }

        [Test]
        public void TestCtorWithNullBaseUrlArgument()
        {
            Assert.Throws<ArgumentNullException>(() => new IronClientApi(_fakeToken, _fakeProjectId, null),
                "BaseUrl is null");
        }
    }
}
