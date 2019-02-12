using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace BL.UnitTest
{
    public class HashTest
    {
        [Fact]
        public void CanHash()
        {
            var password = "123";
            var hashPassword = utils.HashHelper.GetMD5HashData(password);
            var expectedResult = "3244185981728979115075721453575112";
            Xunit.Assert.Equal(expectedResult, hashPassword);
        }
    }
    
}
