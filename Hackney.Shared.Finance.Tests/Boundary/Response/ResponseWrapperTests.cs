using Xunit;
using FluentAssertions;
using Hackney.Shared.Finance.Boundary.Response;

namespace Hackney.Shared.Finance.Tests.Boundary.Response
{
    public class ResponseWrapperTests
    {
        public ResponseWrapperTests()
        { }

        /// <summary>
        /// Given a Response Entity When Single Then ResposeWrapper Should Be Not Empty
        /// </summary>
        [Fact]
        public void GivenResponseEntityWhenSingleThenResposewrapperShouldBeNotEmpty()
        {
            var response = new DummyResponse();
            var wrapperResponse = new ResponseWrapper<DummyResponse>(response);

            wrapperResponse.IsEmpty.Should().BeFalse();
        }

        /// <summary>
        /// Given a Response entity When null Then ResposeWrapper Should Be Empty
        /// </summary>
        [Fact]
        public void GivenAResponseEntityWhenNullThenResposeWrapperShouldBeEmpty()
        {
            var wrapperResponse = new ResponseWrapper<DummyResponse>(null);

            wrapperResponse.IsEmpty.Should().BeTrue();
        }

        /// <summary>
        /// Given a Response When Entity Collection Then ResposeWrapper Should Be Not Empty
        /// </summary>
        [Fact]
        public void GivenResponseWhenEntityCollectionThenResposeWrapperShouldNotBeEmpty()
        {
            var listResponse = new List<DummyResponse>();
            for (int i = 0; i < 10; i++)
            {
                listResponse.Add(new DummyResponse());
            }    

            var wrapperResponse = new ResponseWrapper<IEnumerable<DummyResponse>>(listResponse);

            wrapperResponse.IsEmpty.Should().BeFalse();
        }

        /// <summary>
        /// Given a Response When Empty Collection Then ResposeWrapper Should Be Empty
        /// </summary>
        [Fact]
        public void GivenResponseWhenEmptyCollectionThenResposeWrapperShouldBeEmpty()
        {
            var testList = new List<DummyResponse>();

            var wrapperResponse = new ResponseWrapper<IEnumerable<DummyResponse>>(testList);

            wrapperResponse.IsEmpty.Should().BeTrue();
        }
    }
}
