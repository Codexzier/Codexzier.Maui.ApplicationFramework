using Codexzier.Maui.ApplicationFramework.Components.UserSettings;

namespace Codexzier.Wpf.ApplicationFramework.Test.Components.UserSettings
{
    [TestClass]
    public class UserSettingsLoaderTest
    {
        [TestMethod]
        public void Load_SettingFile()
        {
            // arrange
            var settingsLoader = UserSettingsLoader<SettingsFile>
                .GetInstance(
                    s => string.Empty, 
                    s => new SettingsFile());
            
            // act
            var result = settingsLoader.Load();

            // assert
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void Load_CustomSettingFile()
        {
            // arrange
            var settingsLoader = UserSettingsLoader<StubCustomSettingsFile>
                .GetInstance(
                    s => string.Empty, 
                    s => new StubCustomSettingsFile());
            
            // act
            var result = settingsLoader.Load();

            // assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void HasChanged_True()
        {
            // arrange
            var settingsLoader = UserSettingsLoader<StubCustomSettingsFile>
                .GetInstance(
                    s => string.Empty,
                    s => new StubCustomSettingsFile());
            var settings = settingsLoader.Load();

            // act
            settings.SizeX = 123;

            // assert
            Assert.IsTrue(settings.HasChanged());
        }

        [TestMethod]
        public void HasChanged_False()
        {
            // arrange
            var settingsLoader = UserSettingsLoader<StubCustomSettingsFile>
                .GetInstance(
                    s => string.Empty,
                    s => new StubCustomSettingsFile());
            var settings = settingsLoader.Load();

            // act

            // assert
            Assert.IsFalse(settings.HasChanged());
        }

        [TestMethod]
        public void NoChanged_False()
        {
            // arrange
            var settingsLoader = UserSettingsLoader<StubCustomSettingsFile>
                .GetInstance(
                    s => string.Empty,
                    s => new StubCustomSettingsFile());
            var settings = settingsLoader.Load();

            // act
            settings.SizeX = 123;
            settings.NoChanged();

            // assert
            Assert.IsFalse(settings.HasChanged());
        }
    }
}