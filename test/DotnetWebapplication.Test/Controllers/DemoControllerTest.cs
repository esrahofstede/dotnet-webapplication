using DotnetWebapplication.Controllers;

namespace DotnetWebapplication.Test.Controllers
{
    public class DemoControllerTest
    {
        [Test]
        public void Test()
        {
            //Arrange
            var controller = new DemoController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.That(result.Value, Is.EqualTo("Test"));
        }
    }
}
