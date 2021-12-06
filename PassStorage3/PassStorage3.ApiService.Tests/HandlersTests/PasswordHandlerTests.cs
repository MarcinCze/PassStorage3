namespace ApiService.Tests.HandlersTests
{
    public class PasswordHandlerTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [TearDown]
        public void TearDown()
        {
            var testDbs = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "Test_PassStorage3_*_*_db.db");
            
            if (testDbs.Any())
            {
                foreach (var file in testDbs)
                    File.Delete(file);
            }
        }

        [Test]
        [TestCaseSource(typeof(TestCases.PasswordHandlerTestCases), nameof(TestCases.PasswordHandlerTestCases.AddPasswordTestCases))]
        public async Task Should_Save_When_AddPassword(PasswordRequest passwordRequest)
        {
            // Arrange
            var dtNow = new DateTime(
                year: 2021, month: 12, day: 6, 
                hour: 12, minute: 15, second: 0);
            var dateTimeProviderMock = new Mock<IDateTimeProvider>();
            dateTimeProviderMock.Setup(r => r.Now).Returns(dtNow);

            LiteDbWriteService liteDbWriteService = new(dateTimeProviderMock.Object);
            liteDbWriteService.SetDatabaseName(GetDbName());
            PasswordHandler passwordHandler = new(liteDbWriteService);

            // Act
            await passwordHandler.AddAsync(passwordRequest);

            // Assert
            using var db = new LiteDatabase(liteDbWriteService.ConnString);
            var col = db.GetCollection<PasswordEntity>("passwords");
            var results = col.FindAll().ToList();

            Assert.IsNotNull(results);
            Assert.AreEqual(1, results.Count);
            Assert.AreEqual(passwordRequest.Login, results.First().Login);
            Assert.AreEqual(passwordRequest.Password, results.First().Password);
            Assert.AreEqual(passwordRequest.Title, results.First().Title);
            Assert.AreEqual(passwordRequest.AdditionalData, results.First().AdditionalData);
            Assert.AreEqual(0, results.First().ViewsCounter);
            Assert.AreEqual(dtNow, results.First().Created);
            Assert.AreEqual(dtNow, results.First().PasswordChanged);
        }

        private string GetDbName() =>
            $"Test_PassStorage3_{TestContext.CurrentContext.Test.Name}_{Guid.NewGuid()}_db.db";
    }
}
