using Xunit;
using FluentAssertions;
using Hackney.Shared.Finance.Boundary.Response;

namespace Hackney.Shared.Finance.Tests.Boundary.Response
{
    public class ResponseWrapperTests
    {
        public ResponseWrapperTests()
        { }

        [Fact]
        public void Given_A_Response_Entity_WhenSingle_Then_ResposeWrapper_ShouldNotBeEmpty()
        {
            var response = new DummyResponse();
            var wrapperResponse = new ResponseWrapper<DummyResponse>(response);

            wrapperResponse.IsEmpty.Should().BeFalse();
        }


        [Fact]
        public void Given_A_Response_Entity_WhenNull_Then_ResposeWrapper_ShouldBeEmpty()
        {
            var wrapperResponse = new ResponseWrapper<DummyResponse>(null);

            wrapperResponse.IsEmpty.Should().BeTrue();
        }

        [Fact]
        public void Given_Response_When_EntityCollection_Then_ResposeWrapper_ShouldNotBeEmpty()
        {
            var listResponse = new List<DummyResponse>();
            for (int i = 0; i < 10; i++)
            {
                listResponse.Add(new DummyResponse());
            }    

            var wrapperResponse = new ResponseWrapper<IEnumerable<DummyResponse>>(listResponse);

            wrapperResponse.IsEmpty.Should().BeFalse();
        }

        [Fact]
        public void Given_Response_WhenEmptyCollection_Then_ResposeWrapper_ShouldNotBeEmpty()
        {
            var testList = new List<DummyResponse>();

            var wrapperResponse = new ResponseWrapper<IEnumerable<DummyResponse>>(testList);

            wrapperResponse.IsEmpty.Should().BeTrue();
        }
    }
}
